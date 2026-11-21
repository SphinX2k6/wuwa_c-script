using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

// Token: 0x0200286D RID: 10349
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleOutlookComponent : BaseOutlookComponent
{
	// Token: 0x0601A3B0 RID: 107440 RVA: 0x0081E664 File Offset: 0x0081C864
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

	// Token: 0x0601A3B1 RID: 107441 RVA: 0x0081E760 File Offset: 0x0081C960
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

	// Token: 0x0601A3B2 RID: 107442 RVA: 0x0081E7D8 File Offset: 0x0081C9D8
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

	// Token: 0x0601A3B3 RID: 107443 RVA: 0x0081E880 File Offset: 0x0081CA80
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

	// Token: 0x0601A3B4 RID: 107444 RVA: 0x0081E950 File Offset: 0x0081CB50
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

	// Token: 0x0601A3B5 RID: 107445 RVA: 0x0081EA0C File Offset: 0x0081CC0C
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

	// Token: 0x0601A3B6 RID: 107446 RVA: 0x0081EB93 File Offset: 0x0081CD93
	public bool EquipMotor(MotorOutlookEquippedPb equippedPd)
	{
		base.EquipDecoration((equippedPd != null) ? new List<int>(equippedPd.DecorationsEquipped) : null);
		return this.EquipMotorSticker((equippedPd != null) ? new List<int>(equippedPd.StickerEquipped) : null);
	}

	// Token: 0x0601A3B7 RID: 107447 RVA: 0x0081EBC4 File Offset: 0x0081CDC4
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

	// Token: 0x0601A3B8 RID: 107448 RVA: 0x0081EC44 File Offset: 0x0081CE44
	protected override int? GetDecorationModelId(int decorationId)
	{
		MotorDecorations? config = ConfigMotorDecorationsById.GetConfig(decorationId, true);
		if (config == null)
		{
			return null;
		}
		return new int?(config.GetValueOrDefault().ModelId);
	}

	// Token: 0x0601A3B9 RID: 107449 RVA: 0x0081EC80 File Offset: 0x0081CE80
	public override int GetSkinId()
	{
		VehicleActorComponent component = base.Entity.GetComponent<VehicleActorComponent>();
		if (component == null)
		{
			return 0;
		}
		return component.CreatureData.GetSkinId();
	}

	// Token: 0x0601A3BA RID: 107450 RVA: 0x0081ECA0 File Offset: 0x0081CEA0
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

	// Token: 0x0601A3BB RID: 107451 RVA: 0x0081EF80 File Offset: 0x0081D180
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

	// Token: 0x0601A3BC RID: 107452 RVA: 0x0081F004 File Offset: 0x0081D204
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleOutlookComponent motorcycleOutlookComponent = (MotorcycleOutlookComponent)componentTemplate;
		this.MotorWingId = motorcycleOutlookComponent.MotorWingId;
		if (motorcycleOutlookComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (motorcycleOutlookComponent.CharRenderComp == null)
		{
			this.CharRenderComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharRenderComp), "CharRenderComp"))
		{
			return false;
		}
		if (motorcycleOutlookComponent.CurrentStickers == null)
		{
			this.CurrentStickers = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentStickers), "CurrentStickers"))
		{
			return false;
		}
		if (motorcycleOutlookComponent.SoarWingDecoration == null)
		{
			this.SoarWingDecoration = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SoarWingDecoration), "SoarWingDecoration"))
		{
			return false;
		}
		if (motorcycleOutlookComponent.DisableSoarWingTimer == null)
		{
			this.DisableSoarWingTimer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DisableSoarWingTimer), "DisableSoarWingTimer"))
		{
			return false;
		}
		return motorcycleOutlookComponent.SoarWingVisibleTags == null || base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.SoarWingVisibleTags), "SoarWingVisibleTags");
	}

	// Token: 0x17002AE5 RID: 10981
	// (get) Token: 0x0601A3BD RID: 107453 RVA: 0x0081F129 File Offset: 0x0081D329
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AE6 RID: 10982
	// (get) Token: 0x0601A3BE RID: 107454 RVA: 0x0081F12C File Offset: 0x0081D32C
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AE7 RID: 10983
	// (get) Token: 0x0601A3BF RID: 107455 RVA: 0x0081F12F File Offset: 0x0081D32F
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AE8 RID: 10984
	// (get) Token: 0x0601A3C0 RID: 107456 RVA: 0x0081F132 File Offset: 0x0081D332
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AE9 RID: 10985
	// (get) Token: 0x0601A3C1 RID: 107457 RVA: 0x0081F135 File Offset: 0x0081D335
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AEA RID: 10986
	// (get) Token: 0x0601A3C2 RID: 107458 RVA: 0x0081F138 File Offset: 0x0081D338
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E64E RID: 58958
	private const int SOAR_WING_INDEX = 101;

	// Token: 0x0400E64F RID: 58959
	private const int SOAR_WING_ID = 800001;

	// Token: 0x0400E650 RID: 58960
	private const long SOAR_WING_HIDE_DELAY = 1200L;

	// Token: 0x0400E651 RID: 58961
	private int MotorWingId = 800001;

	// Token: 0x0400E652 RID: 58962
	protected BaseTagComponent TagComp;

	// Token: 0x0400E653 RID: 58963
	protected CharRenderingComponent CharRenderComp;

	// Token: 0x0400E654 RID: 58964
	[Nullable(1)]
	protected List<MotorcycleOutlookComponent.StickerParams> CurrentStickers = new List<MotorcycleOutlookComponent.StickerParams>();

	// Token: 0x0400E655 RID: 58965
	protected DecorationItem SoarWingDecoration;

	// Token: 0x0400E656 RID: 58966
	private TimerHandle DisableSoarWingTimer;

	// Token: 0x0400E657 RID: 58967
	[Nullable(1)]
	private readonly HashSet<int> SoarWingVisibleTags = new HashSet<int>();

	// Token: 0x020089AC RID: 35244
	[NullableContext(0)]
	protected class StickerParams
	{
		// Token: 0x06042A17 RID: 272919 RVA: 0x013C8C13 File Offset: 0x013C6E13
		public StickerParams(int inStickerId, int inPdHandle = 0)
		{
			this.StickerId = inStickerId;
			this.PdHandle = inPdHandle;
		}

		// Token: 0x0402BD9C RID: 179612
		public int StickerId;

		// Token: 0x0402BD9D RID: 179613
		public int PdHandle;
	}
}
