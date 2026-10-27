using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x0200307E RID: 12414
[NullableContext(2)]
[Nullable(0)]
public class CharacterPartComponent : EntityComponent
{
	// Token: 0x1700247B RID: 9339
	// (get) Token: 0x0601A83D RID: 108605 RVA: 0x00718555 File Offset: 0x00716755
	public bool IsMultiPart
	{
		get
		{
			return this.IsMultiPartInternal;
		}
	}

	// Token: 0x0601A83E RID: 108606 RVA: 0x00718560 File Offset: 0x00716760
	protected override bool OnInitData(IEntityArgs args = null)
	{
		EntityComponentPb entityComponentPb;
		if (base.Entity.GetComponent<CreatureDataComponent>().ComponentDataMap.TryGetValue("PartComponent", out entityComponentPb))
		{
			this.PartComponentPb = ((entityComponentPb != null) ? entityComponentPb.PartComponent : null);
		}
		this.Parts = new CharacterPart[0];
		this.PartMapByBone = new Dictionary<string, CharacterPart>();
		this.PartMapByTag = new Dictionary<string, CharacterPart>();
		this.GroupMapByBone = new Dictionary<string, string>();
		this.WeaknessByBone = new Dictionary<string, CharacterPart>();
		this.PartForwardByBone = new Dictionary<string, string>();
		this.PartActiveTagChangeTaskList = new ITagTask[0];
		return true;
	}

	// Token: 0x0601A83F RID: 108607 RVA: 0x007185ED File Offset: 0x007167ED
	protected override bool OnInit()
	{
		this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
		TsBaseCharacter actor = base.Entity.GetComponent<CharacterActorComponent>().Actor;
		if (((actor != null) ? actor.DtCharacterPart : null) != null)
		{
			this.IsMultiPartInternal = true;
		}
		return true;
	}

	// Token: 0x0601A840 RID: 108608 RVA: 0x00718628 File Offset: 0x00716828
	protected unsafe override void OnActivate()
	{
		if (!this.IsMultiPartInternal)
		{
			return;
		}
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.BaseChar = this.ActorComp.Actor;
		this.DtCharacterPart = this.BaseChar.DtCharacterPart;
		List<SCharacterPart> dataTableAllRowFromTable = DataTableUtil.GetDataTableAllRowFromTable<SCharacterPart>(this.DtCharacterPart);
		PartComponentPb partComponentPb = this.PartComponentPb;
		List<CharacterPart> list = new List<CharacterPart>();
		List<ITagTask> list2 = new List<ITagTask>();
		for (int i = 0; i < dataTableAllRowFromTable.Count; i++)
		{
			SCharacterPart scharacterPart = dataTableAllRowFromTable[i];
			CharacterPart characterPart = new CharacterPart(base.Entity, i, scharacterPart);
			list.Add(characterPart);
			this.PartMapByBone.Add(scharacterPart.部位名, characterPart);
			int num = scharacterPart.骨骼名.Num();
			bool isWeakness = characterPart.IsWeakness;
			for (int j = 0; j < num; j++)
			{
				string key = scharacterPart.骨骼名.Get(j);
				this.GroupMapByBone.Add(key, scharacterPart.部位名);
				if (isWeakness)
				{
					this.WeaknessByBone.Add(key, characterPart);
				}
			}
			TMap<string, string> 碰撞框朝向 = scharacterPart.碰撞框朝向;
			if (碰撞框朝向 != null)
			{
				int maxIndex = 碰撞框朝向.GetMaxIndex();
				for (int k = 0; k < maxIndex; k++)
				{
					if (碰撞框朝向.IsValidIndex(k))
					{
						string key2 = 碰撞框朝向.GetKey(k);
						string text = 碰撞框朝向.Get(key2);
						if (text != null)
						{
							this.PartForwardByBone[key2] = text;
						}
					}
				}
			}
			this.TagComponent.RemoveTag(new int?(scharacterPart.部位标签.TagId()));
			Dictionary<string, CharacterPart> partMapByTag = this.PartMapByTag;
			FGameplayTag 部位标签 = scharacterPart.部位标签;
			if (partMapByTag.ContainsKey(部位标签.TagName.ToString()))
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Part;
				Entity entity = base.Entity;
				string message = "部位标签重复注册";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("v", scharacterPart.部位标签.TagName);
				instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			Dictionary<string, CharacterPart> partMapByTag2 = this.PartMapByTag;
			部位标签 = scharacterPart.部位标签;
			partMapByTag2.Add(部位标签.TagName.ToString(), characterPart);
			ITagTask tagTask = this.ListenCharPartActiveChange(characterPart, scharacterPart.部位激活标签);
			if (tagTask != null)
			{
				list2.Add(tagTask);
			}
			if (!FNameUtil.IsNothing(scharacterPart.合体骨骼名))
			{
				if (this.PartMapByCombineBone == null)
				{
					this.PartMapByCombineBone = new Dictionary<string, CharacterPart>();
				}
				this.PartMapByCombineBone.Add(scharacterPart.合体骨骼名.ToString(), characterPart);
			}
			if (partComponentPb == null)
			{
				if (scharacterPart.是否出生激活)
				{
					if (this.TagComponent.HasTag(scharacterPart.部位激活标签.TagId()))
					{
						Log instance2 = Log.Instance;
						ELogModule module = ELogModule.Character;
						ELogAuthor author = ELogAuthor.HCW;
						string message2 = "部位勾选了[是否出生激活]，但是在蓝图中提前加了标签，会导致标签添加时无法触发从无到有事件，引起功能失效";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("角色", this.BaseChar);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("部位", scharacterPart.部位名);
						instance2.Error(module, author, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
					this.TagComponent.AddTag(new int?(scharacterPart.部位激活标签.TagId()));
				}
				PartInformation partInformation = PartInformation.Create();
				partInformation.LifeValue = characterPart.Life;
				partInformation.LifeMax = characterPart.LifeMax;
				partInformation.PartId = characterPart.Index;
				partInformation.Activated = scharacterPart.是否出生激活;
				partInformation.PartTag = characterPart.PartTag.Value.TagId();
			}
			else
			{
				PartInformation partInformation2 = null;
				RepeatedField<PartInformation> partLifeInfos = partComponentPb.PartLifeInfos;
				for (int l = 0; l < partLifeInfos.Count; l++)
				{
					if (partLifeInfos[l].PartId == i)
					{
						partInformation2 = partLifeInfos[l];
						break;
					}
				}
				if (partInformation2 != null)
				{
					characterPart.UpdatePartInfo(partInformation2, true);
				}
			}
		}
		this.Parts = list.ToArray();
		this.PartActiveTagChangeTaskList = list2.ToArray();
	}

	// Token: 0x0601A841 RID: 108609 RVA: 0x00718A04 File Offset: 0x00716C04
	protected override bool OnEnd()
	{
		if (this.IsMultiPartInternal)
		{
			ITagTask[] partActiveTagChangeTaskList = this.PartActiveTagChangeTaskList;
			for (int i = 0; i < partActiveTagChangeTaskList.Length; i++)
			{
				partActiveTagChangeTaskList[i].EndTask();
			}
		}
		return true;
	}

	// Token: 0x0601A842 RID: 108610 RVA: 0x00718A38 File Offset: 0x00716C38
	[NullableContext(1)]
	public bool IsWeakness(string boneName)
	{
		CharacterPart characterPart = this.WeaknessByBone.ContainsKey(boneName) ? this.WeaknessByBone[boneName] : null;
		return characterPart != null && characterPart.Active;
	}

	// Token: 0x0601A843 RID: 108611 RVA: 0x00718A70 File Offset: 0x00716C70
	[NullableContext(1)]
	[return: Nullable(2)]
	public CharacterPart GetPart(string boneName)
	{
		string valueOrDefault = this.GroupMapByBone.GetValueOrDefault(boneName);
		if (valueOrDefault == null)
		{
			return null;
		}
		return this.PartMapByBone.GetValueOrDefault(valueOrDefault);
	}

	// Token: 0x0601A844 RID: 108612 RVA: 0x00718A9C File Offset: 0x00716C9C
	public CharacterPart GetPartByTag(FGameplayTag tag)
	{
		CharacterPart characterPart;
		this.PartMapByTag.TryGetValue(tag.TagName.ToString(), out characterPart);
		if (characterPart == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Part;
			Entity entity = base.Entity;
			string message = "获取部位失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TagName", tag.TagName);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return characterPart;
	}

	// Token: 0x0601A845 RID: 108613 RVA: 0x00718B04 File Offset: 0x00716D04
	public CharacterPart GetPartByIndex(int index)
	{
		if (index < 0 || index >= this.Parts.Length)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Part;
			Entity entity = base.Entity;
			string message = "获取部位失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", index);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return this.Parts[index];
	}

	// Token: 0x0601A846 RID: 108614 RVA: 0x00718B5A File Offset: 0x00716D5A
	[NullableContext(1)]
	[return: Nullable(2)]
	public CharacterPart GetPartByCombineBoneName(string boneName)
	{
		if (this.PartMapByCombineBone == null)
		{
			return null;
		}
		return this.PartMapByCombineBone.GetValueOrDefault(boneName);
	}

	// Token: 0x0601A847 RID: 108615 RVA: 0x00718B74 File Offset: 0x00716D74
	[NullableContext(1)]
	[return: Nullable(2)]
	private ITagTask ListenCharPartActiveChange(CharacterPart part, FGameplayTag tag)
	{
		return this.TagComponent.ListenForTagAddOrRemove(new int?(tag.TagId()), delegate(int tagId, bool bTagExists)
		{
			part.SetActive(bTagExists);
		}, null);
	}

	// Token: 0x0601A848 RID: 108616 RVA: 0x00718BB4 File Offset: 0x00716DB4
	[CombatListen(ENotifyMessageId.PartUpdateNotify, false, false)]
	public static void PartUpdateNotify(Entity entity, [Nullable(1)] PartUpdateNotify data, CombatCommon combatCommon = null)
	{
		long entityId = data.EntityId;
		EntityHandle entity2 = CreatureModel.Instance.GetEntity(entityId);
		if (entity2 == null)
		{
			return;
		}
		CharacterPartComponent component = entity2.Entity.GetComponent<CharacterPartComponent>();
		foreach (PartInformation partInformation in data.PartInfos)
		{
			CharacterPart partByIndex = component.GetPartByIndex(partInformation.PartId);
			if (partByIndex != null)
			{
				partByIndex.UpdatePartInfo(partInformation, true);
			}
		}
	}

	// Token: 0x0601A849 RID: 108617 RVA: 0x00718C3C File Offset: 0x00716E3C
	[CombatListen(ENotifyMessageId.PartComponentInitNotify, false, false)]
	public static void PartComponentInitNotify(Entity entity, [Nullable(1)] PartComponentInitNotify data, CombatCommon combatCommon = null)
	{
		long entityId = data.EntityId;
		EntityHandle entity2 = CreatureModel.Instance.GetEntity(entityId);
		if (entity2 == null)
		{
			return;
		}
		CombatLog.Instance.Info(CombatLog.EDebugModule.Part, entity, "PartComponentInitNotify", default(ReadOnlySpan<ValueTuple<string, object>>));
		CharacterPartComponent component = entity2.Entity.GetComponent<CharacterPartComponent>();
		foreach (PartInformation partInformation in data.PartComponent.PartLifeInfos)
		{
			CharacterPart partByIndex = component.GetPartByIndex(partInformation.PartId);
			if (partByIndex != null)
			{
				partByIndex.UpdatePartInfo(partInformation, true);
			}
		}
	}

	// Token: 0x0601A84A RID: 108618 RVA: 0x00718CE8 File Offset: 0x00716EE8
	[NullableContext(1)]
	public string GetDebugText()
	{
		string text = "";
		foreach (CharacterPart characterPart in this.Parts)
		{
			string[] array = new string[9];
			array[0] = text;
			array[1] = "\n\t\t";
			array[2] = characterPart.Index.ToString();
			array[3] = " ";
			int num = 4;
			CharacterPart characterPart2 = characterPart;
			array[num] = ((characterPart2.PartTag != null) ? new FName?(characterPart2.PartTag.GetValueOrDefault().TagName) : null).ToString();
			array[5] = " : ";
			array[6] = characterPart.Life.ToString();
			array[7] = ", ";
			array[8] = characterPart.Active.ToString();
			text = string.Concat(array);
		}
		return text;
	}

	// Token: 0x0601A84B RID: 108619 RVA: 0x00718DB4 File Offset: 0x00716FB4
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterPartComponent characterPartComponent = (CharacterPartComponent)componentTemplate;
		if (base.CanResetComponentProperty("BaseChar"))
		{
			if (characterPartComponent.BaseChar == null)
			{
				this.BaseChar = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.BaseChar), "BaseChar"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterPartComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (characterPartComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DtCharacterPart"))
		{
			if (characterPartComponent.DtCharacterPart == null)
			{
				this.DtCharacterPart = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UDataTable>(this.DtCharacterPart), "DtCharacterPart"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("Parts"))
		{
			if (characterPartComponent.Parts == null)
			{
				this.Parts = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterPart[]>(this.Parts), "Parts"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PartMapByBone"))
		{
			if (characterPartComponent.PartMapByBone == null)
			{
				this.PartMapByBone = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, CharacterPart>>(this.PartMapByBone), "PartMapByBone"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PartMapByTag"))
		{
			if (characterPartComponent.PartMapByTag == null)
			{
				this.PartMapByTag = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, CharacterPart>>(this.PartMapByTag), "PartMapByTag"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("WeaknessByBone"))
		{
			if (characterPartComponent.WeaknessByBone == null)
			{
				this.WeaknessByBone = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, CharacterPart>>(this.WeaknessByBone), "WeaknessByBone"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PartForwardByBone"))
		{
			if (characterPartComponent.PartForwardByBone == null)
			{
				this.PartForwardByBone = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, string>>(this.PartForwardByBone), "PartForwardByBone"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("GroupMapByBone"))
		{
			if (characterPartComponent.GroupMapByBone == null)
			{
				this.GroupMapByBone = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, string>>(this.GroupMapByBone), "GroupMapByBone"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PartMapByCombineBone"))
		{
			if (characterPartComponent.PartMapByCombineBone == null)
			{
				this.PartMapByCombineBone = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, CharacterPart>>(this.PartMapByCombineBone), "PartMapByCombineBone"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PartActiveTagChangeTaskList"))
		{
			if (characterPartComponent.PartActiveTagChangeTaskList == null)
			{
				this.PartActiveTagChangeTaskList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask[]>(this.PartActiveTagChangeTaskList), "PartActiveTagChangeTaskList"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PartComponentPb"))
		{
			if (characterPartComponent.PartComponentPb == null)
			{
				this.PartComponentPb = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PartComponentPb>(this.PartComponentPb), "PartComponentPb"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsMultiPartInternal"))
		{
			this.IsMultiPartInternal = characterPartComponent.IsMultiPartInternal;
		}
		return true;
	}

	// Token: 0x0400CB90 RID: 52112
	public TsBaseCharacter BaseChar;

	// Token: 0x0400CB91 RID: 52113
	public CharacterActorComponent ActorComp;

	// Token: 0x0400CB92 RID: 52114
	public BaseTagComponent TagComponent;

	// Token: 0x0400CB93 RID: 52115
	public UDataTable DtCharacterPart;

	// Token: 0x0400CB94 RID: 52116
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public CharacterPart[] Parts;

	// Token: 0x0400CB95 RID: 52117
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<string, CharacterPart> PartMapByBone;

	// Token: 0x0400CB96 RID: 52118
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<string, CharacterPart> PartMapByTag;

	// Token: 0x0400CB97 RID: 52119
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<string, CharacterPart> WeaknessByBone;

	// Token: 0x0400CB98 RID: 52120
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<string, string> PartForwardByBone;

	// Token: 0x0400CB99 RID: 52121
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<string, string> GroupMapByBone;

	// Token: 0x0400CB9A RID: 52122
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<string, CharacterPart> PartMapByCombineBone;

	// Token: 0x0400CB9B RID: 52123
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ITagTask[] PartActiveTagChangeTaskList;

	// Token: 0x0400CB9C RID: 52124
	private PartComponentPb PartComponentPb;

	// Token: 0x0400CB9D RID: 52125
	private bool IsMultiPartInternal;
}
