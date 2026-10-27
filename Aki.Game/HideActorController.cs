using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x02001E5C RID: 7772
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class HideActorController : ControllerBase
{
	// Token: 0x0600EC38 RID: 60472 RVA: 0x00381678 File Offset: 0x0037F878
	protected override bool OnInit()
	{
		this.IsHideMesh = false;
		this.IsHideEffect = false;
		this.HiddenEffectSet.Clear();
		this.HiddenMeshMap.Clear();
		this.IsHideNpcMesh = false;
		this.IsHideNpcEffect = false;
		this.HiddenNpcEffectSet.Clear();
		this.HiddenNpcMeshMap.Clear();
		this.HideActorParameterDirty = false;
		this.HideNpcParameterDirty = false;
		base.PauseTick();
		return true;
	}

	// Token: 0x0600EC39 RID: 60473 RVA: 0x003816E4 File Offset: 0x0037F8E4
	protected override void OnTick(float delta)
	{
		if (this.IsHideMesh || this.IsHideEffect || this.IsHideNpcMesh || this.IsHideNpcEffect)
		{
			if (this.HideActorParameterDirty || this.HideNpcParameterDirty)
			{
				this.HideActorInternal(this.IsHideMesh, this.IsHideEffect, true);
				this.HideNpcActorInternal(this.IsHideMesh, this.IsHideEffect, true);
				return;
			}
			if (this.HideDistance > 0f)
			{
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				if (baseCharacter != null && baseCharacter.IsValid() && this.HideBasisBoneName != FNameUtil.NONE)
				{
					USkeletalMeshComponent mesh = Global.BaseCharacter.Mesh;
					if (mesh != null && mesh.DoesSocketExist(this.HideBasisBoneName))
					{
						Vector tmpVector = this.TmpVector;
						Vector vector = tmpVector;
						FVectorDouble fvectorDouble = Global.BaseCharacter.Mesh.D_GetSocketLocation(this.HideBasisBoneName);
						vector.FromUeVector(fvectorDouble);
						if (!this.HideLocation.Equals(tmpVector, 0.0001))
						{
							this.HideActorInternal(this.IsHideMesh, this.IsHideEffect, true);
							this.HideNpcActorInternal(this.IsHideMesh, this.IsHideEffect, true);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600EC3A RID: 60474 RVA: 0x00381806 File Offset: 0x0037FA06
	public void HideMesh()
	{
		if (this.IsHideMesh)
		{
			return;
		}
		this.IsHideMesh = true;
		this.HideActorInternal(true, false, false);
		base.ResumeTick();
	}

	// Token: 0x0600EC3B RID: 60475 RVA: 0x00381827 File Offset: 0x0037FA27
	public void HideEffect()
	{
		if (this.IsHideEffect)
		{
			return;
		}
		this.IsHideEffect = true;
		this.HideActorInternal(false, true, false);
		base.ResumeTick();
	}

	// Token: 0x0600EC3C RID: 60476 RVA: 0x00381848 File Offset: 0x0037FA48
	public void HideNpcMesh()
	{
		if (this.IsHideNpcMesh)
		{
			return;
		}
		this.IsHideNpcMesh = true;
		this.HideNpcActorInternal(true, false, false);
		base.ResumeTick();
	}

	// Token: 0x0600EC3D RID: 60477 RVA: 0x00381869 File Offset: 0x0037FA69
	public void HideNpcEffect()
	{
		if (this.IsHideNpcEffect)
		{
			return;
		}
		this.IsHideNpcEffect = true;
		this.HideNpcActorInternal(false, true, false);
		base.ResumeTick();
	}

	// Token: 0x0600EC3E RID: 60478 RVA: 0x0038188A File Offset: 0x0037FA8A
	public void ShowMesh()
	{
		if (!this.IsHideMesh)
		{
			return;
		}
		this.IsHideMesh = false;
		this.ShowActorInternal(true, false);
	}

	// Token: 0x0600EC3F RID: 60479 RVA: 0x003818A4 File Offset: 0x0037FAA4
	public void ShowEffect()
	{
		if (!this.IsHideEffect)
		{
			return;
		}
		this.IsHideEffect = false;
		this.ShowActorInternal(false, true);
	}

	// Token: 0x0600EC40 RID: 60480 RVA: 0x003818BE File Offset: 0x0037FABE
	public void ShowNpcMesh()
	{
		if (!this.IsHideNpcMesh)
		{
			return;
		}
		this.IsHideNpcMesh = false;
		this.ShowNpcActorInternal(true, false);
	}

	// Token: 0x0600EC41 RID: 60481 RVA: 0x003818D8 File Offset: 0x0037FAD8
	public void ShowNpcEffect()
	{
		if (!this.IsHideNpcEffect)
		{
			return;
		}
		this.IsHideNpcEffect = false;
		this.ShowNpcActorInternal(false, true);
	}

	// Token: 0x0600EC42 RID: 60482 RVA: 0x003818F2 File Offset: 0x0037FAF2
	public void SetHideParameter(float distance, FName boneName)
	{
		if (this.HideDistance == distance && this.HideBasisBoneName == boneName)
		{
			return;
		}
		this.HideDistance = distance;
		this.HideBasisBoneName = boneName;
		this.HideActorParameterDirty = true;
		this.HideNpcParameterDirty = true;
		base.ResumeTick();
	}

	// Token: 0x0600EC43 RID: 60483 RVA: 0x0038192E File Offset: 0x0037FB2E
	public void ResetHideParameter()
	{
		this.HideDistance = 0f;
		this.HideBasisBoneName = FNameUtil.NONE;
		this.HideActorParameterDirty = false;
		this.HideNpcParameterDirty = false;
		base.PauseTick();
	}

	// Token: 0x0600EC44 RID: 60484 RVA: 0x0038195C File Offset: 0x0037FB5C
	private void HideActorInternal(bool hideMesh, bool hideEffect, bool forceUpdateEntity = false)
	{
		if (Global.BaseCharacter == null)
		{
			return;
		}
		HashSet<EntityHandle> characterValidHandles = this.GetCharacterValidHandles(forceUpdateEntity);
		if (this.HiddenMeshMap.Count > 0)
		{
			List<EntityHandle> list = new List<EntityHandle>();
			foreach (KeyValuePair<EntityHandle, int> keyValuePair in this.HiddenMeshMap)
			{
				EntityHandle key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (!characterValidHandles.Contains(key))
				{
					list.Add(key);
					if (key.Valid)
					{
						key.Entity.GetComponent<CharacterActorComponent>().EnableActor(value);
					}
				}
			}
			foreach (EntityHandle key2 in list)
			{
				this.HiddenMeshMap.Remove(key2);
			}
		}
		if (this.HiddenEffectSet.Count > 0)
		{
			List<EntityHandle> list2 = new List<EntityHandle>();
			foreach (EntityHandle entityHandle in this.HiddenEffectSet)
			{
				if (!characterValidHandles.Contains(entityHandle))
				{
					list2.Add(entityHandle);
					if (entityHandle.Valid)
					{
						this.HideEffectInternal(entityHandle, false);
					}
				}
			}
			foreach (EntityHandle item in list2)
			{
				this.HiddenEffectSet.Remove(item);
			}
		}
		foreach (EntityHandle entityHandle2 in characterValidHandles)
		{
			if (entityHandle2.Valid && entityHandle2.IsInit && entityHandle2.Entity.Active)
			{
				CharacterActorComponent component = entityHandle2.Entity.GetComponent<CharacterActorComponent>();
				TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
				if (tsBaseCharacter != null && tsBaseCharacter != Global.BaseCharacter && CampUtils.GetCampRelationship(tsBaseCharacter.Camp, Global.BaseCharacter.Camp) != ERelation.Friend)
				{
					if (!this.HiddenMeshMap.ContainsKey(entityHandle2) && hideMesh)
					{
						int value2 = component.DisableActor("[HideActorController] 隐藏Mesh");
						this.HiddenMeshMap[entityHandle2] = value2;
					}
					if (!this.HiddenEffectSet.Contains(entityHandle2) && hideEffect)
					{
						this.HideEffectInternal(entityHandle2, true);
						this.HiddenEffectSet.Add(entityHandle2);
					}
				}
			}
		}
	}

	// Token: 0x0600EC45 RID: 60485 RVA: 0x00381C20 File Offset: 0x0037FE20
	private void HideNpcActorInternal(bool hideMesh, bool hideEffect, bool forceUpdateEntity = false)
	{
		if (Global.BaseCharacter == null)
		{
			return;
		}
		HashSet<EntityHandle> npcValidHandles = this.GetNpcValidHandles(forceUpdateEntity);
		if (this.HiddenNpcMeshMap.Count > 0)
		{
			List<EntityHandle> list = new List<EntityHandle>();
			foreach (KeyValuePair<EntityHandle, int> keyValuePair in this.HiddenNpcMeshMap)
			{
				EntityHandle key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (!npcValidHandles.Contains(key))
				{
					list.Add(key);
					if (key.Valid)
					{
						key.Entity.GetComponent<BaseCharacterComponent>().EnableActor(value);
						this.HideHeadInfoInternal(key, false);
					}
				}
			}
			foreach (EntityHandle key2 in list)
			{
				this.HiddenNpcMeshMap.Remove(key2);
			}
		}
		if (this.HiddenNpcEffectSet.Count > 0)
		{
			List<EntityHandle> list2 = new List<EntityHandle>();
			foreach (EntityHandle entityHandle in this.HiddenNpcEffectSet)
			{
				if (!npcValidHandles.Contains(entityHandle))
				{
					list2.Add(entityHandle);
					if (entityHandle.Valid)
					{
						this.HideEffectInternal(entityHandle, false);
					}
				}
			}
			foreach (EntityHandle item in list2)
			{
				this.HiddenNpcEffectSet.Remove(item);
			}
		}
		foreach (EntityHandle entityHandle2 in npcValidHandles)
		{
			if (entityHandle2.Valid && entityHandle2.IsInit && entityHandle2.Entity.Active)
			{
				BaseCharacterComponent component = entityHandle2.Entity.GetComponent<BaseCharacterComponent>();
				TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
				if (tsBaseCharacter != null && tsBaseCharacter != Global.BaseCharacter)
				{
					CreatureDataComponent component2 = entityHandle2.Entity.GetComponent<CreatureDataComponent>();
					if (component2 != null && component2.Valid && component2.IsNpc())
					{
						if (!this.HiddenNpcMeshMap.ContainsKey(entityHandle2) && hideMesh)
						{
							this.HideHeadInfoInternal(entityHandle2, true);
							int value2 = component.DisableActor("[HideNpcActorController] 隐藏NpcMesh");
							this.HiddenNpcMeshMap[entityHandle2] = value2;
						}
						if (!this.HiddenNpcEffectSet.Contains(entityHandle2) && hideEffect)
						{
							this.HideEffectInternal(entityHandle2, true);
							this.HiddenNpcEffectSet.Add(entityHandle2);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600EC46 RID: 60486 RVA: 0x00381F48 File Offset: 0x00380148
	private void ShowActorInternal(bool showMesh, bool showEffect)
	{
		if (showMesh)
		{
			foreach (KeyValuePair<EntityHandle, int> keyValuePair in this.HiddenMeshMap)
			{
				EntityHandle key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (key.Valid)
				{
					key.Entity.GetComponent<CharacterActorComponent>().EnableActor(value);
				}
			}
			this.HiddenMeshMap.Clear();
		}
		if (showEffect)
		{
			foreach (EntityHandle entityHandle in this.HiddenEffectSet)
			{
				if (entityHandle.Valid)
				{
					this.HideEffectInternal(entityHandle, false);
				}
			}
			this.HiddenEffectSet.Clear();
		}
	}

	// Token: 0x0600EC47 RID: 60487 RVA: 0x0038202C File Offset: 0x0038022C
	private void ShowNpcActorInternal(bool showMesh, bool showEffect)
	{
		if (showMesh)
		{
			foreach (KeyValuePair<EntityHandle, int> keyValuePair in this.HiddenNpcMeshMap)
			{
				EntityHandle key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (key.Valid)
				{
					key.Entity.GetComponent<BaseCharacterComponent>().EnableActor(value);
					this.HideHeadInfoInternal(key, false);
				}
			}
			this.HiddenNpcMeshMap.Clear();
		}
		if (showEffect)
		{
			foreach (EntityHandle entityHandle in this.HiddenNpcEffectSet)
			{
				if (entityHandle.Valid)
				{
					this.HideEffectInternal(entityHandle, false);
				}
			}
			this.HiddenNpcEffectSet.Clear();
		}
	}

	// Token: 0x0600EC48 RID: 60488 RVA: 0x00382118 File Offset: 0x00380318
	private unsafe HashSet<EntityHandle> GetCharacterValidHandles(bool forceUpdateEntity)
	{
		if (this.LastFrameUpdateActor == (long)Time.Instance.Frame && !this.HideActorParameterDirty && !forceUpdateEntity)
		{
			return this.CharacterHandles;
		}
		this.LastFrameUpdateActor = (long)Time.Instance.Frame;
		this.HideActorParameterDirty = false;
		this.CharacterHandles.Clear();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (this.HideDistance > 0f && baseCharacter != null && baseCharacter.IsValid() && this.HideBasisBoneName != FNameUtil.NONE)
		{
			USkeletalMeshComponent mesh = baseCharacter.Mesh;
			if (mesh != null && mesh.DoesSocketExist(this.HideBasisBoneName))
			{
				Vector hideLocation = this.HideLocation;
				Vector vector = hideLocation;
				FVectorDouble fvectorDouble = baseCharacter.Mesh.D_GetSocketLocation(this.HideBasisBoneName);
				vector.FromUeVector(fvectorDouble);
				CreatureModel.Instance.GetEntitiesInRangeWithLocation(hideLocation, this.HideDistance, HideActorController.CHARACTER, this.CharacterHandles, true);
				return this.CharacterHandles;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[HideActorController][Actor]隐藏全部角色";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("baseCharacter", (baseCharacter != null) ? new bool?(baseCharacter.IsValid()) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HideDistance", this.HideDistance);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HideBasisBoneName", this.HideBasisBoneName);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item = "SocketExist";
		bool? flag;
		if (baseCharacter == null)
		{
			flag = null;
		}
		else
		{
			USkeletalMeshComponent mesh2 = baseCharacter.Mesh;
			flag = ((mesh2 != null) ? new bool?(mesh2.DoesSocketExist(this.HideBasisBoneName)) : null);
		}
		ptr = new ValueTuple<string, object>(item, flag);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
		if (allEntities != null)
		{
			foreach (EntityHandle item2 in allEntities)
			{
				this.CharacterHandles.Add(item2);
			}
		}
		return this.CharacterHandles;
	}

	// Token: 0x0600EC49 RID: 60489 RVA: 0x00382348 File Offset: 0x00380548
	private unsafe HashSet<EntityHandle> GetNpcValidHandles(bool forceUpdateEntity)
	{
		if (this.LastFrameUpdateNpc == (long)Time.Instance.Frame && !this.HideNpcParameterDirty && !forceUpdateEntity)
		{
			return this.NpcHandles;
		}
		this.LastFrameUpdateNpc = (long)Time.Instance.Frame;
		this.HideNpcParameterDirty = false;
		this.NpcHandles.Clear();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (this.HideDistance > 0f && baseCharacter != null && baseCharacter.IsValid() && this.HideBasisBoneName != FNameUtil.NONE)
		{
			USkeletalMeshComponent mesh = baseCharacter.Mesh;
			if (mesh != null && mesh.DoesSocketExist(this.HideBasisBoneName))
			{
				Vector hideLocation = this.HideLocation;
				Vector vector = hideLocation;
				FVectorDouble fvectorDouble = baseCharacter.Mesh.D_GetSocketLocation(this.HideBasisBoneName);
				vector.FromUeVector(fvectorDouble);
				CreatureModel.Instance.GetEntitiesInRangeWithLocation(hideLocation, this.HideDistance, HideActorController.NPC, this.NpcHandles, true);
				return this.NpcHandles;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[HideActorController][Npc]隐藏全部角色";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("baseCharacter", (baseCharacter != null) ? new bool?(baseCharacter.IsValid()) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HideDistance", this.HideDistance);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HideBasisBoneName", this.HideBasisBoneName);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item = "SocketExist";
		bool? flag;
		if (baseCharacter == null)
		{
			flag = null;
		}
		else
		{
			USkeletalMeshComponent mesh2 = baseCharacter.Mesh;
			flag = ((mesh2 != null) ? new bool?(mesh2.DoesSocketExist(this.HideBasisBoneName)) : null);
		}
		ptr = new ValueTuple<string, object>(item, flag);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
		if (allEntities != null)
		{
			foreach (EntityHandle item2 in allEntities)
			{
				this.NpcHandles.Add(item2);
			}
		}
		return this.NpcHandles;
	}

	// Token: 0x0600EC4A RID: 60490 RVA: 0x00382578 File Offset: 0x00380778
	private void HideEffectInternal(EntityHandle handle, bool hidden)
	{
		CharacterSkillComponent component = handle.Entity.GetComponent<CharacterSkillComponent>();
		if (component != null)
		{
			Skill currentSkill = component.CurrentSkill;
			if (currentSkill != null)
			{
				currentSkill.SetEffectHidden(hidden);
			}
		}
		CharacterGameplayCueComponent component2 = handle.Entity.GetComponent<CharacterGameplayCueComponent>();
		if (component2 == null)
		{
			return;
		}
		component2.SetHidden(hidden);
	}

	// Token: 0x0600EC4B RID: 60491 RVA: 0x003825B2 File Offset: 0x003807B2
	private void HideHeadInfoInternal(EntityHandle handle, bool hidden)
	{
		PawnHeadInfoComponent component = handle.Entity.GetComponent<PawnHeadInfoComponent>();
		if (component == null)
		{
			return;
		}
		component.EnableHeadInfo(!hidden);
	}

	// Token: 0x0600EC4C RID: 60492 RVA: 0x003825CD File Offset: 0x003807CD
	protected override bool OnClear()
	{
		this.IsHideMesh = false;
		this.IsHideEffect = false;
		this.ShowActorInternal(true, true);
		this.IsHideNpcMesh = false;
		this.IsHideNpcEffect = false;
		this.ShowNpcActorInternal(true, true);
		this.ResetHideParameter();
		return true;
	}

	// Token: 0x17001289 RID: 4745
	// (get) Token: 0x0600EC4D RID: 60493 RVA: 0x00382602 File Offset: 0x00380802
	public static HideActorController Instance
	{
		get
		{
			return HideActorController._Instance;
		}
	}

	// Token: 0x0600EC4E RID: 60494 RVA: 0x00382609 File Offset: 0x00380809
	public static HideActorController GetOrCreateInstance()
	{
		if (HideActorController._Instance == null)
		{
			HideActorController.CreateInstance();
		}
		return HideActorController._Instance;
	}

	// Token: 0x0600EC4F RID: 60495 RVA: 0x0038261D File Offset: 0x0038081D
	public static bool CreateInstance()
	{
		if (HideActorController._Instance != null)
		{
			return true;
		}
		HideActorController._Instance = new HideActorController();
		return true;
	}

	// Token: 0x0600EC50 RID: 60496 RVA: 0x00382633 File Offset: 0x00380833
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EC51 RID: 60497 RVA: 0x00382635 File Offset: 0x00380835
	public static void ResetStaticDefaultValue()
	{
		HideActorController._Instance = null;
	}

	// Token: 0x0600EC52 RID: 60498 RVA: 0x0038263D File Offset: 0x0038083D
	static HideActorController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HideActorController.CreateStaticDefaultValue), new Action(HideActorController.ResetStaticDefaultValue));
	}

	// Token: 0x04006D87 RID: 28039
	private static readonly EEntityTypeQuery CHARACTER = EEntityTypeQuery.PasserbyNPC | EEntityTypeQuery.Boss | EEntityTypeQuery.Team;

	// Token: 0x04006D88 RID: 28040
	private static readonly EEntityTypeQuery NPC = EEntityTypeQuery.SimpleNPC | EEntityTypeQuery.NormalNPC | EEntityTypeQuery.PasserbyNPC;

	// Token: 0x04006D89 RID: 28041
	private bool IsHideMesh;

	// Token: 0x04006D8A RID: 28042
	private bool IsHideEffect;

	// Token: 0x04006D8B RID: 28043
	private readonly HashSet<EntityHandle> HiddenEffectSet = new HashSet<EntityHandle>();

	// Token: 0x04006D8C RID: 28044
	private readonly Dictionary<EntityHandle, int> HiddenMeshMap = new Dictionary<EntityHandle, int>();

	// Token: 0x04006D8D RID: 28045
	private bool IsHideNpcMesh;

	// Token: 0x04006D8E RID: 28046
	private bool IsHideNpcEffect;

	// Token: 0x04006D8F RID: 28047
	private readonly HashSet<EntityHandle> HiddenNpcEffectSet = new HashSet<EntityHandle>();

	// Token: 0x04006D90 RID: 28048
	private readonly Dictionary<EntityHandle, int> HiddenNpcMeshMap = new Dictionary<EntityHandle, int>();

	// Token: 0x04006D91 RID: 28049
	private float HideDistance;

	// Token: 0x04006D92 RID: 28050
	private FName HideBasisBoneName = FNameUtil.NONE;

	// Token: 0x04006D93 RID: 28051
	private long LastFrameUpdateActor;

	// Token: 0x04006D94 RID: 28052
	private long LastFrameUpdateNpc;

	// Token: 0x04006D95 RID: 28053
	private bool HideActorParameterDirty;

	// Token: 0x04006D96 RID: 28054
	private bool HideNpcParameterDirty;

	// Token: 0x04006D97 RID: 28055
	private readonly HashSet<EntityHandle> CharacterHandles = new HashSet<EntityHandle>();

	// Token: 0x04006D98 RID: 28056
	private readonly HashSet<EntityHandle> NpcHandles = new HashSet<EntityHandle>();

	// Token: 0x04006D99 RID: 28057
	private readonly Vector HideLocation = Vector.Create();

	// Token: 0x04006D9A RID: 28058
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x04006D9B RID: 28059
	private const bool Debug = false;

	// Token: 0x04006D9C RID: 28060
	[Nullable(2)]
	private static HideActorController _Instance;
}
