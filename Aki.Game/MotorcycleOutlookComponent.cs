using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

// Token: 0x020032FB RID: 13051
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleOutlookComponent : BaseOutlookComponent
{
	// Token: 0x0601C6D0 RID: 116432 RVA: 0x007F845C File Offset: 0x007F665C
	private void OnSoarTagChanged(int tagId, bool tagExist)
	{
		if (tagExist)
		{
			if (this.SoarWingVisibleTags.Contains(tagId))
			{
				return;
			}
			this.SoarWingVisibleTags.Add(tagId);
		}
		else
		{
			if (!this.SoarWingVisibleTags.Contains(tagId))
			{
				return;
			}
			this.SoarWingVisibleTags.Remove(tagId);
		}
		if (this.SoarWingDecoration == null)
		{
			return;
		}
		if (!(tagExist ? (this.SoarWingVisibleTags.Count == 1) : (this.SoarWingVisibleTags.Count == 0)))
		{
			return;
		}
		if (this.DisableSoarWingTimer != null)
		{
			TimerSystem.Instance.Remove(this.DisableSoarWingTimer);
			this.DisableSoarWingTimer = null;
		}
		if (tagExist)
		{
			USkeletalMeshComponent meshComp = this.SoarWingDecoration.MeshComp;
			if (meshComp != null)
			{
				UAnimInstance animInstance = meshComp.GetAnimInstance();
				if (animInstance != null)
				{
					animInstance.SyncAnimStates(null);
				}
			}
			this.SoarWingDecoration.SetVisible(true, "Motorcycle.OnSoarTagExist true");
			return;
		}
		this.DisableSoarWingTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			if (this.SoarWingVisibleTags.Count > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "[Decoration][Motor] 不可以隐藏翱翔翼";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tags", JsonSerializer.Serialize<HashSet<int>>(this.SoarWingVisibleTags, null));
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Log.Instance.Warn(ELogModule.Test, ELogAuthor.LCZ, "[Decoration][Motor] 翱翔翼由计时器触发了隐藏", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SoarWingDecoration.SetVisible(false, "Motorcycle.OnSoarTagExist false");
		}, 1200f, null, null, true, 1f);
	}

	// Token: 0x0601C6D1 RID: 116433 RVA: 0x007F8558 File Offset: 0x007F6758
	[NullableContext(1)]
	private void OnVehicleEntered(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (byChangeRole)
		{
			return;
		}
		if (this.SoarWingVisibleTags.Count > 0)
		{
			DecorationItem soarWingDecoration = this.SoarWingDecoration;
			if (soarWingDecoration != null)
			{
				USkeletalMeshComponent meshComp = soarWingDecoration.MeshComp;
				if (meshComp != null)
				{
					UAnimInstance animInstance = meshComp.GetAnimInstance();
					if (animInstance != null)
					{
						animInstance.SyncAnimStates(null);
					}
				}
			}
			DecorationItem soarWingDecoration2 = this.SoarWingDecoration;
			if (soarWingDecoration2 == null)
			{
				return;
			}
			soarWingDecoration2.SetVisible(true, "Motorcycle.OnVehicleEntered true");
			return;
		}
		else
		{
			DecorationItem soarWingDecoration3 = this.SoarWingDecoration;
			if (soarWingDecoration3 == null)
			{
				return;
			}
			soarWingDecoration3.SetVisible(false, "Motorcycle.OnVehicleEntered false");
			return;
		}
	}

	// Token: 0x0601C6D2 RID: 116434 RVA: 0x007F85D0 File Offset: 0x007F67D0
	protected override bool OnStart()
	{
		VehicleActorComponent component = base.Entity.GetComponent<VehicleActorComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		if (component != null)
		{
			this.SkelMeshComp = component.Actor.Mesh;
			this.CharRenderComp = component.Actor.CharRenderingComponent;
			Log.Instance.Info(ELogModule.Decoration, ELogAuthor.LCZ, "[Decoration][Motor] EquipMotor OnStart", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InitMotorWingId();
			this.EquipMotor(component.CreatureData.MotorOutlookInfo);
		}
		EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleEntered));
		return true;
	}

	// Token: 0x0601C6D3 RID: 116435 RVA: 0x007F8678 File Offset: 0x007F6878
	private void InitMotorWingId()
	{
		VehicleActorComponent component = base.Entity.GetComponent<VehicleActorComponent>();
		if (((component != null) ? component.CreatureData.MotorOutlookInfo : null) != null)
		{
			MotorFrame? config = ConfigMotorFrameById.GetConfig(component.CreatureData.MotorOutlookInfo.FrameEquipped, true);
			if (config != null)
			{
				this.MotorWingId = config.Value.Wing;
				return;
			}
		}
		this.MotorWingId = 800001;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Decoration;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "[Decoration][Motor] 初始化摩托翱翔翼失败，使用默认ID";
		string item = "Frame";
		int? num;
		if (component == null)
		{
			num = null;
		}
		else
		{
			MotorOutlookEquippedPb motorOutlookInfo = component.CreatureData.MotorOutlookInfo;
			num = ((motorOutlookInfo != null) ? new int?(motorOutlookInfo.FrameEquipped) : null);
		}
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, num);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601C6D4 RID: 116436 RVA: 0x007F8748 File Offset: 0x007F6948
	protected override bool OnEnd()
	{
		if (this.SkelMeshComp != null)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"], new BaseTagComponent.TTagSwitchedCallback(this.OnSoarTagChanged));
			}
			BaseTagComponent tagComp2 = this.TagComp;
			if (tagComp2 != null)
			{
				tagComp2.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.外观状态.显示翱翔翼"], new BaseTagComponent.TTagSwitchedCallback(this.OnSoarTagChanged));
			}
		}
		if (this.DisableSoarWingTimer != null)
		{
			TimerSystem.Instance.Remove(this.DisableSoarWingTimer);
			this.DisableSoarWingTimer = null;
		}
		this.SoarWingVisibleTags.Clear();
		EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleEntered));
		return true;
	}

	// Token: 0x0601C6D5 RID: 116437 RVA: 0x007F8804 File Offset: 0x007F6A04
	protected override void OnActivate()
	{
		this.SoarWingVisibleTags.Clear();
		if (this.DisableSoarWingTimer != null)
		{
			TimerSystem.Instance.Remove(this.DisableSoarWingTimer);
			this.DisableSoarWingTimer = null;
		}
		if (this.SkelMeshComp != null)
		{
			this.SoarWingDecoration = base.CreateDecorationItem(this.SkelMeshComp, 101, false, true);
			this.SoarWingDecoration.SetDecorationId(this.MotorWingId);
			if (this.TagComp != null)
			{
				if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]))
				{
					this.SoarWingVisibleTags.Add(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]);
				}
				if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.外观状态.显示翱翔翼"]))
				{
					this.SoarWingVisibleTags.Add(GameplayTagDefine.EGameplayTagId["载具.摩托.外观状态.显示翱翔翼"]);
				}
				if (this.SoarWingVisibleTags.Count > 0)
				{
					USkeletalMeshComponent meshComp = this.SoarWingDecoration.MeshComp;
					if (meshComp != null)
					{
						UAnimInstance animInstance = meshComp.GetAnimInstance();
						if (animInstance != null)
						{
							animInstance.SyncAnimStates(null);
						}
					}
					this.SoarWingDecoration.SetVisible(true, "Motorcycle.OnActivate true");
				}
				else
				{
					this.SoarWingDecoration.SetVisible(false, "Motorcycle.OnActivate false");
				}
				this.TagComp.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"], new BaseTagComponent.TTagSwitchedCallback(this.OnSoarTagChanged), null);
				this.TagComp.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.外观状态.显示翱翔翼"], new BaseTagComponent.TTagSwitchedCallback(this.OnSoarTagChanged), null);
			}
		}
	}

	// Token: 0x0601C6D6 RID: 116438 RVA: 0x007F898B File Offset: 0x007F6B8B
	public bool EquipMotor(MotorOutlookEquippedPb equippedPd)
	{
		base.EquipDecoration((equippedPd != null) ? equippedPd.DecorationsEquipped.ToList<int>() : null);
		return this.EquipMotorSticker((equippedPd != null) ? equippedPd.StickerEquipped.ToList<int>() : null);
	}

	// Token: 0x0601C6D7 RID: 116439 RVA: 0x007F89BC File Offset: 0x007F6BBC
	[NullableContext(1)]
	protected override void AddRenderMesh(DecorationItem item)
	{
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		if (component != null && item.MeshComp != null)
		{
			component.Actor.CharRenderingComponent.AddComponent(item.MeshComp.GetName(), item.MeshComp);
		}
		MotorcycleActorComponent component2 = base.Entity.GetComponent<MotorcycleActorComponent>();
		if (component2 != null && item.MeshComp != null)
		{
			component2.VehicleOwner.CharRenderingComponent.AddComponent(item.MeshComp.GetName(), item.MeshComp);
		}
	}

	// Token: 0x0601C6D8 RID: 116440 RVA: 0x007F8A3C File Offset: 0x007F6C3C
	protected override int? GetDecorationModelId(int decorationId)
	{
		MotorDecorations? config = ConfigMotorDecorationsById.GetConfig(decorationId, true);
		if (config == null)
		{
			return null;
		}
		return new int?(config.GetValueOrDefault().ModelId);
	}

	// Token: 0x0601C6D9 RID: 116441 RVA: 0x007F8A78 File Offset: 0x007F6C78
	public override int GetSkinId()
	{
		VehicleActorComponent component = base.Entity.GetComponent<VehicleActorComponent>();
		if (component == null)
		{
			return 0;
		}
		return component.CreatureData.GetSkinId();
	}

	// Token: 0x0601C6DA RID: 116442 RVA: 0x007F8A98 File Offset: 0x007F6C98
	public unsafe bool EquipMotorSticker(List<int> stickerIds)
	{
		List<int> list = stickerIds ?? new List<int>();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Decoration;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "[Decoration][Motor] Equip MotorStickers";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("length", list.Count);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		for (int i = 0; i < list.Count; i++)
		{
			if (this.CurrentStickers.Count <= i)
			{
				this.CurrentStickers.Add(new MotorcycleOutlookComponent.StickerParams(0, 0));
			}
			MotorcycleOutlookComponent.StickerParams stickerParams = this.CurrentStickers[i];
			int num = list[i];
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Decoration;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "[Decoration][Motor] Equip MotorSticker";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Index", i);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("From", stickerParams.StickerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("To", num);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (stickerParams.StickerId != num)
			{
				if (stickerParams.PdHandle != 0)
				{
					CharRenderingComponent charRenderComp = this.CharRenderComp;
					if (charRenderComp != null)
					{
						charRenderComp.RemoveMaterialControllerData(stickerParams.PdHandle);
					}
					stickerParams.PdHandle = 0;
				}
				stickerParams.StickerId = num;
				if (num != 0)
				{
					MotorSticker? config = ConfigMotorStickerById.GetConfig(num, true);
					if (((config != null) ? config.GetValueOrDefault().MaterialDA : null) != null)
					{
						PD_CharacterControllerData_C pd_CharacterControllerData_C = ResourceSystem.Instance.Load<PD_CharacterControllerData_C>(config.Value.MaterialDA, "js_undefined");
						if (pd_CharacterControllerData_C != null)
						{
							MotorcycleOutlookComponent.StickerParams stickerParams2 = stickerParams;
							CharRenderingComponent charRenderComp2 = this.CharRenderComp;
							stickerParams2.PdHandle = ((charRenderComp2 != null) ? charRenderComp2.AddMaterialControllerData(pd_CharacterControllerData_C) : 0);
						}
						else
						{
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.Decoration;
							ELogAuthor author3 = ELogAuthor.LCZ;
							string message3 = "[Decoration][Motor] Motor CharCtrl not found.";
							ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Path", (config != null) ? config.GetValueOrDefault().MaterialDA : null);
							instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						}
					}
					else
					{
						Log instance4 = Log.Instance;
						ELogModule module4 = ELogModule.Decoration;
						ELogAuthor author4 = ELogAuthor.LCZ;
						string message4 = "[Decoration][Motor] Motor stickerId not found.";
						ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Id", num);
						instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					}
				}
			}
		}
		for (int j = list.Count; j < this.CurrentStickers.Count; j++)
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.Decoration;
			ELogAuthor author5 = ELogAuthor.LCZ;
			string message5 = "[Decoration][Motor] EquipMotor Clear";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("Index", j);
			instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			MotorcycleOutlookComponent.StickerParams stickerParams3 = this.CurrentStickers[j];
			if (stickerParams3.PdHandle != 0)
			{
				CharRenderingComponent charRenderComp3 = this.CharRenderComp;
				if (charRenderComp3 != null)
				{
					charRenderComp3.RemoveMaterialControllerData(stickerParams3.PdHandle);
				}
				stickerParams3.PdHandle = 0;
			}
			stickerParams3.StickerId = 0;
		}
		return true;
	}

	// Token: 0x0601C6DB RID: 116443 RVA: 0x007F8D78 File Offset: 0x007F6F78
	public void DisableSoarWing()
	{
		if (this.SoarWingVisibleTags.Count > 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "[Decoration][Motor] 不可以隐藏翱翔翼";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tags", JsonSerializer.Serialize<HashSet<int>>(this.SoarWingVisibleTags, null));
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.DisableSoarWingTimer != null)
		{
			TimerSystem.Instance.Remove(this.DisableSoarWingTimer);
			this.DisableSoarWingTimer = null;
		}
		DecorationItem soarWingDecoration = this.SoarWingDecoration;
		if (soarWingDecoration == null)
		{
			return;
		}
		soarWingDecoration.SetVisible(false, "Motorcycle.DisableSoarWing");
	}

	// Token: 0x0601C6DC RID: 116444 RVA: 0x007F8DFC File Offset: 0x007F6FFC
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleOutlookComponent motorcycleOutlookComponent = (MotorcycleOutlookComponent)componentTemplate;
		if (base.CanResetComponentProperty("MotorWingId"))
		{
			this.MotorWingId = motorcycleOutlookComponent.MotorWingId;
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (motorcycleOutlookComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CharRenderComp"))
		{
			if (motorcycleOutlookComponent.CharRenderComp == null)
			{
				this.CharRenderComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharRenderingComponent>(this.CharRenderComp), "CharRenderComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurrentStickers"))
		{
			if (motorcycleOutlookComponent.CurrentStickers == null)
			{
				this.CurrentStickers = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<MotorcycleOutlookComponent.StickerParams>>(this.CurrentStickers), "CurrentStickers"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SoarWingDecoration"))
		{
			if (motorcycleOutlookComponent.SoarWingDecoration == null)
			{
				this.SoarWingDecoration = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<DecorationItem>(this.SoarWingDecoration), "SoarWingDecoration"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DisableSoarWingTimer"))
		{
			if (motorcycleOutlookComponent.DisableSoarWingTimer == null)
			{
				this.DisableSoarWingTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.DisableSoarWingTimer), "DisableSoarWingTimer"))
			{
				return false;
			}
		}
		return !base.CanResetComponentProperty("SoarWingVisibleTags") || motorcycleOutlookComponent.SoarWingVisibleTags == null || base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.SoarWingVisibleTags), "SoarWingVisibleTags");
	}

	// Token: 0x0400E1A3 RID: 57763
	private const int SOAR_WING_INDEX = 101;

	// Token: 0x0400E1A4 RID: 57764
	private const int SOAR_WING_ID = 800001;

	// Token: 0x0400E1A5 RID: 57765
	private const long SOAR_WING_HIDE_DELAY = 1200L;

	// Token: 0x0400E1A6 RID: 57766
	private int MotorWingId = 800001;

	// Token: 0x0400E1A7 RID: 57767
	protected BaseTagComponent TagComp;

	// Token: 0x0400E1A8 RID: 57768
	protected CharRenderingComponent CharRenderComp;

	// Token: 0x0400E1A9 RID: 57769
	[Nullable(1)]
	protected List<MotorcycleOutlookComponent.StickerParams> CurrentStickers = new List<MotorcycleOutlookComponent.StickerParams>();

	// Token: 0x0400E1AA RID: 57770
	protected DecorationItem SoarWingDecoration;

	// Token: 0x0400E1AB RID: 57771
	private TimerHandle DisableSoarWingTimer;

	// Token: 0x0400E1AC RID: 57772
	[Nullable(1)]
	private readonly HashSet<int> SoarWingVisibleTags = new HashSet<int>();

	// Token: 0x02009789 RID: 38793
	[NullableContext(0)]
	protected class StickerParams
	{
		// Token: 0x0604C591 RID: 312721 RVA: 0x0141E05F File Offset: 0x0141C25F
		public StickerParams(int inStickerId, int inPdHandle = 0)
		{
			this.StickerId = inStickerId;
			this.PdHandle = inPdHandle;
		}

		// Token: 0x0403070F RID: 198415
		public int StickerId;

		// Token: 0x04030710 RID: 198416
		public int PdHandle;
	}
}
