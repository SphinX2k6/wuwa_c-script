using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.GamePlay.TriggerItems;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Season;
using CSharpScript.Game.NewWorld.TriggerItems.Model;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200282E RID: 10286
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTriggerVolume.TsTriggerVolume_C")]
public class TsTriggerVolume : AKuroEffectActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x170029E5 RID: 10725
	// (get) Token: 0x06019EE8 RID: 106216 RVA: 0x007FE004 File Offset: 0x007FC204
	// (set) Token: 0x06019EE9 RID: 106217 RVA: 0x007FE018 File Offset: 0x007FC218
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ABrush TriggerItem
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<ABrush>(base.NativePtr / (IntPtr)sizeof(void*) + TsTriggerVolume.__PropertyOffset_TriggerItem);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsTriggerVolume.__PropertyOffset_TriggerItem, value);
		}
	}

	// Token: 0x170029E6 RID: 10726
	// (get) Token: 0x06019EEA RID: 106218 RVA: 0x007FE030 File Offset: 0x007FC230
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<ABrush> TriggerItems
	{
		get
		{
			base.FastCheckIsValid();
			TArray<ABrush> result;
			if ((result = this._TriggerItems) == null)
			{
				result = (this._TriggerItems = new TArray<ABrush>(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_TriggerItems, this));
			}
			return result;
		}
	}

	// Token: 0x170029E7 RID: 10727
	// (get) Token: 0x06019EEB RID: 106219 RVA: 0x007FE069 File Offset: 0x007FC269
	// (set) Token: 0x06019EEC RID: 106220 RVA: 0x007FE079 File Offset: 0x007FC279
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AkiClient.Game.Aki.GamePlay.TriggerItems.ETriggerType TriggerType
	{
		get
		{
			return (AkiClient.Game.Aki.GamePlay.TriggerItems.ETriggerType)(*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_TriggerType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_TriggerType) = (byte)value;
		}
	}

	// Token: 0x170029E8 RID: 10728
	// (get) Token: 0x06019EED RID: 106221 RVA: 0x007FE08A File Offset: 0x007FC28A
	// (set) Token: 0x06019EEE RID: 106222 RVA: 0x007FE09A File Offset: 0x007FC29A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TriggerGroup
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_TriggerGroup);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_TriggerGroup) = value;
		}
	}

	// Token: 0x170029E9 RID: 10729
	// (get) Token: 0x06019EEF RID: 106223 RVA: 0x007FE0AB File Offset: 0x007FC2AB
	// (set) Token: 0x06019EF0 RID: 106224 RVA: 0x007FE0BB File Offset: 0x007FC2BB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TriggerId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_TriggerId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_TriggerId) = value;
		}
	}

	// Token: 0x170029EA RID: 10730
	// (get) Token: 0x06019EF1 RID: 106225 RVA: 0x007FE0CC File Offset: 0x007FC2CC
	// (set) Token: 0x06019EF2 RID: 106226 RVA: 0x007FE0E0 File Offset: 0x007FC2E0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ConditionGroupId
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTriggerVolume.__PropertyOffset_ConditionGroupId)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTriggerVolume.__PropertyOffset_ConditionGroupId)), value);
		}
	}

	// Token: 0x170029EB RID: 10731
	// (get) Token: 0x06019EF3 RID: 106227 RVA: 0x007FE0F5 File Offset: 0x007FC2F5
	// (set) Token: 0x06019EF4 RID: 106228 RVA: 0x007FE109 File Offset: 0x007FC309
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string EventGroupId
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTriggerVolume.__PropertyOffset_EventGroupId)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTriggerVolume.__PropertyOffset_EventGroupId)), value);
		}
	}

	// Token: 0x170029EC RID: 10732
	// (get) Token: 0x06019EF5 RID: 106229 RVA: 0x007FE11E File Offset: 0x007FC31E
	// (set) Token: 0x06019EF6 RID: 106230 RVA: 0x007FE132 File Offset: 0x007FC332
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ExitEventGroupId
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTriggerVolume.__PropertyOffset_ExitEventGroupId)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTriggerVolume.__PropertyOffset_ExitEventGroupId)), value);
		}
	}

	// Token: 0x170029ED RID: 10733
	// (get) Token: 0x06019EF7 RID: 106231 RVA: 0x007FE147 File Offset: 0x007FC347
	// (set) Token: 0x06019EF8 RID: 106232 RVA: 0x007FE157 File Offset: 0x007FC357
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsPlayer
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IsPlayer) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IsPlayer) = (value ? 1 : 0);
		}
	}

	// Token: 0x170029EE RID: 10734
	// (get) Token: 0x06019EF9 RID: 106233 RVA: 0x007FE168 File Offset: 0x007FC368
	// (set) Token: 0x06019EFA RID: 106234 RVA: 0x007FE1A1 File Offset: 0x007FC3A1
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> TriggerItemEffectData
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._TriggerItemEffectData) == null)
			{
				result = (this._TriggerItemEffectData = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_TriggerItemEffectData, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_TriggerItemEffectData, 1);
		}
	}

	// Token: 0x170029EF RID: 10735
	// (get) Token: 0x06019EFB RID: 106235 RVA: 0x007FE1C6 File Offset: 0x007FC3C6
	// (set) Token: 0x06019EFC RID: 106236 RVA: 0x007FE1D6 File Offset: 0x007FC3D6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NotScale
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_NotScale) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_NotScale) = (value ? 1 : 0);
		}
	}

	// Token: 0x170029F0 RID: 10736
	// (get) Token: 0x06019EFD RID: 106237 RVA: 0x007FE1E7 File Offset: 0x007FC3E7
	// (set) Token: 0x06019EFE RID: 106238 RVA: 0x007FE1F7 File Offset: 0x007FC3F7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IgnoreBullet
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IgnoreBullet) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IgnoreBullet) = (value ? 1 : 0);
		}
	}

	// Token: 0x170029F1 RID: 10737
	// (get) Token: 0x06019EFF RID: 106239 RVA: 0x007FE208 File Offset: 0x007FC408
	// (set) Token: 0x06019F00 RID: 106240 RVA: 0x007FE218 File Offset: 0x007FC418
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float HitCd
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_HitCd);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_HitCd) = value;
		}
	}

	// Token: 0x170029F2 RID: 10738
	// (get) Token: 0x06019F01 RID: 106241 RVA: 0x007FE22C File Offset: 0x007FC42C
	// (set) Token: 0x06019F02 RID: 106242 RVA: 0x007FE265 File Offset: 0x007FC465
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> HitEffectData
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._HitEffectData) == null)
			{
				result = (this._HitEffectData = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_HitEffectData, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_HitEffectData, 1);
		}
	}

	// Token: 0x170029F3 RID: 10739
	// (get) Token: 0x06019F03 RID: 106243 RVA: 0x007FE28A File Offset: 0x007FC48A
	// (set) Token: 0x06019F04 RID: 106244 RVA: 0x007FE29E File Offset: 0x007FC49E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string HitDataName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTriggerVolume.__PropertyOffset_HitDataName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTriggerVolume.__PropertyOffset_HitDataName)), value);
		}
	}

	// Token: 0x170029F4 RID: 10740
	// (get) Token: 0x06019F05 RID: 106245 RVA: 0x007FE2B3 File Offset: 0x007FC4B3
	// (set) Token: 0x06019F06 RID: 106246 RVA: 0x007FE2C3 File Offset: 0x007FC4C3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsBlockCamera
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IsBlockCamera) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IsBlockCamera) = (value ? 1 : 0);
		}
	}

	// Token: 0x170029F5 RID: 10741
	// (get) Token: 0x06019F07 RID: 106247 RVA: 0x007FE2D4 File Offset: 0x007FC4D4
	// (set) Token: 0x06019F08 RID: 106248 RVA: 0x007FE2E4 File Offset: 0x007FC4E4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int AreaId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_AreaId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_AreaId) = value;
		}
	}

	// Token: 0x170029F6 RID: 10742
	// (get) Token: 0x06019F09 RID: 106249 RVA: 0x007FE2F5 File Offset: 0x007FC4F5
	// (set) Token: 0x06019F0A RID: 106250 RVA: 0x007FE305 File Offset: 0x007FC505
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SeasonAreaId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_SeasonAreaId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_SeasonAreaId) = value;
		}
	}

	// Token: 0x170029F7 RID: 10743
	// (get) Token: 0x06019F0B RID: 106251 RVA: 0x007FE316 File Offset: 0x007FC516
	// (set) Token: 0x06019F0C RID: 106252 RVA: 0x007FE326 File Offset: 0x007FC526
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsAutoTriggerEffect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IsAutoTriggerEffect) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IsAutoTriggerEffect) = (value ? 1 : 0);
		}
	}

	// Token: 0x170029F8 RID: 10744
	// (get) Token: 0x06019F0D RID: 106253 RVA: 0x007FE337 File Offset: 0x007FC537
	// (set) Token: 0x06019F0E RID: 106254 RVA: 0x007FE347 File Offset: 0x007FC547
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EffectCd
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_EffectCd);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_EffectCd) = value;
		}
	}

	// Token: 0x170029F9 RID: 10745
	// (get) Token: 0x06019F0F RID: 106255 RVA: 0x007FE358 File Offset: 0x007FC558
	// (set) Token: 0x06019F10 RID: 106256 RVA: 0x007FE368 File Offset: 0x007FC568
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ToleranceDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_ToleranceDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_ToleranceDistance) = value;
		}
	}

	// Token: 0x170029FA RID: 10746
	// (get) Token: 0x06019F11 RID: 106257 RVA: 0x007FE379 File Offset: 0x007FC579
	// (set) Token: 0x06019F12 RID: 106258 RVA: 0x007FE38D File Offset: 0x007FC58D
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UAkAudioEvent EnterAkEvent
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + TsTriggerVolume.__PropertyOffset_EnterAkEvent);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsTriggerVolume.__PropertyOffset_EnterAkEvent, value);
		}
	}

	// Token: 0x170029FB RID: 10747
	// (get) Token: 0x06019F13 RID: 106259 RVA: 0x007FE3A2 File Offset: 0x007FC5A2
	// (set) Token: 0x06019F14 RID: 106260 RVA: 0x007FE3B6 File Offset: 0x007FC5B6
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UAkAudioEvent ExitAkEvent
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + TsTriggerVolume.__PropertyOffset_ExitAkEvent);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsTriggerVolume.__PropertyOffset_ExitAkEvent, value);
		}
	}

	// Token: 0x170029FC RID: 10748
	// (get) Token: 0x06019F15 RID: 106261 RVA: 0x007FE3CB File Offset: 0x007FC5CB
	// (set) Token: 0x06019F16 RID: 106262 RVA: 0x007FE3DB File Offset: 0x007FC5DB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsChangeFootStep
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IsChangeFootStep) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IsChangeFootStep) = (value ? 1 : 0);
		}
	}

	// Token: 0x170029FD RID: 10749
	// (get) Token: 0x06019F17 RID: 106263 RVA: 0x007FE3EC File Offset: 0x007FC5EC
	// (set) Token: 0x06019F18 RID: 106264 RVA: 0x007FE3FC File Offset: 0x007FC5FC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int FootStepMaterialId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_FootStepMaterialId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_FootStepMaterialId) = value;
		}
	}

	// Token: 0x170029FE RID: 10750
	// (get) Token: 0x06019F19 RID: 106265 RVA: 0x007FE410 File Offset: 0x007FC610
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<long> BuffIds
	{
		get
		{
			base.FastCheckIsValid();
			TArray<long> result;
			if ((result = this._BuffIds) == null)
			{
				result = (this._BuffIds = new TArray<long>(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_BuffIds, this));
			}
			return result;
		}
	}

	// Token: 0x170029FF RID: 10751
	// (get) Token: 0x06019F1A RID: 106266 RVA: 0x007FE449 File Offset: 0x007FC649
	// (set) Token: 0x06019F1B RID: 106267 RVA: 0x007FE459 File Offset: 0x007FC659
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsRemoveBuffIds
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IsRemoveBuffIds) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_IsRemoveBuffIds) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002A00 RID: 10752
	// (get) Token: 0x06019F1C RID: 106268 RVA: 0x007FE46C File Offset: 0x007FC66C
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> PropsIds
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._PropsIds) == null)
			{
				result = (this._PropsIds = new TArray<int>(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_PropsIds, this));
			}
			return result;
		}
	}

	// Token: 0x17002A01 RID: 10753
	// (get) Token: 0x06019F1D RID: 106269 RVA: 0x007FE4A5 File Offset: 0x007FC6A5
	// (set) Token: 0x06019F1E RID: 106270 RVA: 0x007FE4B5 File Offset: 0x007FC6B5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int AddBuffType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_AddBuffType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTriggerVolume.__PropertyOffset_AddBuffType) = value;
		}
	}

	// Token: 0x06019F1F RID: 106271 RVA: 0x007FE4C8 File Offset: 0x007FC6C8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsTriggerVolume.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019F20 RID: 106272 RVA: 0x007FE524 File Offset: 0x007FC724
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		base.SetActorTickEnabled(false);
		this.InitTriggerItem(this.TriggerItem);
		for (int i = 0; i < this.TriggerItems.Num(); i++)
		{
			this.InitTriggerItem(this.TriggerItems.Get(i));
		}
		this.HandleWorldDone = new Action(this.OnWorldDone);
		GameModeModel instance = GameModeModel.Instance;
		if (instance == null || !instance.WorldDone)
		{
			GlobalData.BpEventManager.WorldDoneNotify.Remove(this.HandleWorldDone);
			GlobalData.BpEventManager.WorldDoneNotify.Add(this.HandleWorldDone);
		}
		else
		{
			this.OnWorldDone();
		}
		if (this.TriggerGroup != 0f && this.TriggerId != 0f)
		{
			TriggerVolumeModel.Instance.AddTriggerVolume((int)this.TriggerGroup, (int)this.TriggerId, this);
		}
		if (this.AreaId != 0)
		{
			AreaModel.Instance.AddArea(this.AreaId, this);
		}
		if (this.SeasonAreaId != 0)
		{
			SeasonController.Instance.RegisterVolume(this);
		}
		this.AddBuff();
	}

	// Token: 0x06019F21 RID: 106273 RVA: 0x007FE62C File Offset: 0x007FC82C
	protected virtual void OnWorldDone()
	{
		if (this.AreaId != 0)
		{
			bool valueOrDefault = AreaModel.Instance.GetAreaState(this.AreaId).GetValueOrDefault();
			this.SetEnable(valueOrDefault);
		}
		this.RegistEvents(this.TriggerItem);
		for (int i = 0; i < this.TriggerItems.Num(); i++)
		{
			this.RegistEvents(this.TriggerItems.Get(i));
		}
	}

	// Token: 0x06019F22 RID: 106274 RVA: 0x007FE695 File Offset: 0x007FC895
	protected virtual void InitTriggerItem(ABrush inTrigger)
	{
		if (inTrigger == null)
		{
			return;
		}
		if (this.TriggerType == AkiClient.Game.Aki.GamePlay.TriggerItems.ETriggerType.Events)
		{
			inTrigger.BrushComponent.SetCollisionObjectType(TsTriggerVolume.KuroTriggerType);
		}
	}

	// Token: 0x06019F23 RID: 106275 RVA: 0x007FE6B4 File Offset: 0x007FC8B4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsTriggerVolume.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(EndPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)EndPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019F24 RID: 106276 RVA: 0x007FE744 File Offset: 0x007FC944
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		this.RemoveEvents(this.TriggerItem);
		for (int i = 0; i < this.TriggerItems.Num(); i++)
		{
			this.RemoveEvents(this.TriggerItems.Get(i));
		}
		if (this.TriggerGroup != 0f && this.TriggerId != 0f)
		{
			TriggerVolumeModel instance = TriggerVolumeModel.Instance;
			if (instance != null)
			{
				instance.RemoveTriggerVolume((int)this.TriggerGroup, (int)this.TriggerId);
			}
		}
		if (this.AreaId != 0)
		{
			if (this.CountInTrigger > 0)
			{
				this.HandleAreaLeave(RoleTriggerController.Instance.GetMyRoleTrigger(), null);
			}
			AreaModel instance2 = AreaModel.Instance;
			if (instance2 != null)
			{
				instance2.RemoveArea(this.AreaId);
			}
		}
		if (this.SeasonAreaId != 0)
		{
			if (this.SeasonPlayerOverlapCount > 0)
			{
				SeasonController.Instance.HandleVolumeExit(this);
				this.SeasonPlayerOverlapCount = 0;
			}
			SeasonController.Instance.UnregisterVolume(this);
		}
	}

	// Token: 0x06019F25 RID: 106277 RVA: 0x007FE824 File Offset: 0x007FCA24
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), TsTriggerVolume.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTick_Implementation(deltaSeconds);
			return;
		}
		AActor.__ReceiveTick_FunctionParams* ptr = stackalloc AActor.__ReceiveTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019F26 RID: 106278 RVA: 0x007FE8B0 File Offset: 0x007FCAB0
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
	}

	// Token: 0x06019F27 RID: 106279 RVA: 0x007FE8B4 File Offset: 0x007FCAB4
	private void RegistEvents(ABrush inTrigger)
	{
		this.CountInTrigger = 0;
		if (inTrigger == null || !inTrigger.IsValid())
		{
			return;
		}
		TArray<AActor> tarray = new TArray<AActor>();
		inTrigger.GetOverlappingActors(ref tarray, default(TSubclassOf<AActor>));
		if (tarray.Num() > 0)
		{
			int i = 0;
			int num = tarray.Num();
			while (i < num)
			{
				AActor otherActor2 = tarray.Get(i);
				this.OnCollisionEnterFunc(otherActor2, null);
				i++;
			}
		}
		inTrigger.OnActorBeginOverlap.Add(delegate(AActor overlapped, AActor otherActor)
		{
			this.OnCollisionEnterFunc(otherActor, overlapped);
		});
		inTrigger.OnActorEndOverlap.Add(delegate(AActor overlapped, AActor otherActor)
		{
			this.OnCollisionExitFunc(otherActor, overlapped);
		});
	}

	// Token: 0x06019F28 RID: 106280 RVA: 0x007FE94D File Offset: 0x007FCB4D
	private void RemoveEvents(ABrush inTrigger)
	{
		if (inTrigger != null)
		{
			inTrigger.OnActorBeginOverlap.Clear();
			inTrigger.OnActorEndOverlap.Clear();
			inTrigger.OnActorHit.Clear();
		}
		GlobalData.BpEventManager.WorldDoneNotify.Remove(this.HandleWorldDone);
	}

	// Token: 0x06019F29 RID: 106281 RVA: 0x007FE988 File Offset: 0x007FCB88
	[NullableContext(2)]
	protected virtual void OnCollisionEnterFunc(AActor otherActor, AActor overlapped)
	{
		if (this.SeasonAreaId != 0 && otherActor != null && this.CheckBeginOverlapRoleTrigger(otherActor))
		{
			this.SeasonPlayerOverlapCount++;
			if (this.SeasonPlayerOverlapCount == 1)
			{
				SeasonController.Instance.HandleVolumeEnter(this);
			}
		}
		if (!this.CheckCondition(otherActor))
		{
			return;
		}
		this.CountInTrigger++;
		if (this.AreaId != 0 && this.CountInTrigger == 1)
		{
			this.HandleAreaEnter(otherActor, overlapped);
		}
		if (Global.BaseCharacter == null)
		{
			return;
		}
		if (this.EnterAkEvent != null)
		{
			this.PostAkEvent(otherActor, this.EnterAkEvent);
		}
	}

	// Token: 0x06019F2A RID: 106282 RVA: 0x007FEA1C File Offset: 0x007FCC1C
	[NullableContext(2)]
	protected virtual void OnCollisionExitFunc(AActor otherActor, AActor overlapped)
	{
		if (this.CheckBeginOverlapRoleTrigger(otherActor))
		{
			EventSystem.Instance.Emit<AActor>(EEventName.OnTriggerVolumeExit, this);
			if (this.SeasonAreaId != 0 && this.SeasonPlayerOverlapCount > 0)
			{
				this.SeasonPlayerOverlapCount--;
				if (this.SeasonPlayerOverlapCount == 0)
				{
					SeasonController.Instance.HandleVolumeExit(this);
				}
			}
		}
		if (!this.CheckCondition(otherActor))
		{
			return;
		}
		this.CountInTrigger--;
		if (this.AreaId != 0 && this.CountInTrigger <= 0)
		{
			this.HandleAreaLeave(otherActor, overlapped);
			this.CountInTrigger = 0;
		}
		if (this.ExitAkEvent != null)
		{
			this.PostAkEvent(otherActor, this.ExitAkEvent);
		}
	}

	// Token: 0x06019F2B RID: 106283 RVA: 0x007FEAC4 File Offset: 0x007FCCC4
	private bool CheckCondition(AActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			return false;
		}
		if (this.IsPlayer || this.TriggerType == AkiClient.Game.Aki.GamePlay.TriggerItems.ETriggerType.NotOpened || this.EnterAkEvent != null || this.ExitAkEvent != null)
		{
			bool flag = this.CheckBeginOverlapRoleTrigger(actor);
			return flag && flag;
		}
		return actor is TsBaseCharacter || actor is TsBaseItem;
	}

	// Token: 0x06019F2C RID: 106284 RVA: 0x007FEB28 File Offset: 0x007FCD28
	private void SetEnable(bool value)
	{
		if (this.TriggerItem != null)
		{
			this.TriggerItem.SetActorEnableCollision(value);
		}
		for (int i = 0; i < this.TriggerItems.Num(); i++)
		{
			ABrush abrush = this.TriggerItems.Get(i);
			if (abrush != null)
			{
				abrush.SetActorEnableCollision(value);
			}
		}
	}

	// Token: 0x06019F2D RID: 106285 RVA: 0x007FEB78 File Offset: 0x007FCD78
	private void HandleAreaEnter(AActor otherActor, [Nullable(2)] AActor overlapped)
	{
		if (otherActor != RoleTriggerController.Instance.GetMyRoleTrigger())
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Area;
		ELogAuthor author = ELogAuthor.YZH;
		string message = "[AreaController.EnterOverlap_TstriggerVolume] 进入区域";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EnterArea", this.AreaId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Area? area;
		AreaController.Instance.EnterAreaRequest((AreaModel.Instance.AreaInfo != null) ? new int?(area.GetValueOrDefault().AreaId) : null, this.AreaId, true, "AreaController.EnterOverlap_TstriggerVolume");
	}

	// Token: 0x06019F2E RID: 106286 RVA: 0x007FEC10 File Offset: 0x007FCE10
	private void HandleAreaLeave(AActor otherActor, [Nullable(2)] AActor overlapped)
	{
		if (otherActor != RoleTriggerController.Instance.GetMyRoleTrigger())
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Area;
		ELogAuthor author = ELogAuthor.YZH;
		string message = "[AreaController.EndOverlap_TstriggerVolume] 离开区域";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LeaveArea", this.AreaId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		AreaController.Instance.EndOverlap(this.AreaId);
	}

	// Token: 0x06019F2F RID: 106287 RVA: 0x007FEC6E File Offset: 0x007FCE6E
	public void ToggleArea(bool inEnable)
	{
		this.SetEnable(inEnable);
	}

	// Token: 0x06019F30 RID: 106288 RVA: 0x007FEC78 File Offset: 0x007FCE78
	private void PostAkEvent(AActor actor, UAkAudioEvent @event)
	{
		if (actor != RoleTriggerController.Instance.GetMyRoleTrigger())
		{
			return;
		}
		string pathName = UKismetSystemLibrary.GetPathName(@event);
		AudioController.Instance.PostEvent(pathName, null, null, null, null, null, true, "");
	}

	// Token: 0x06019F31 RID: 106289 RVA: 0x007FECC0 File Offset: 0x007FCEC0
	private void AddBuff()
	{
		TArray<long> buffIds = this.BuffIds;
		if (buffIds == null || !buffIds.IsValidIndex(0))
		{
			return;
		}
		this.AddBuffInner(this.BuffIds.Get(0));
		this.TryReportSelfBuffDamageLog();
	}

	// Token: 0x06019F32 RID: 106290 RVA: 0x007FECF3 File Offset: 0x007FCEF3
	private bool CheckBeginOverlapRoleTrigger(AActor otherActor)
	{
		return otherActor == RoleTriggerController.Instance.GetMyRoleTrigger();
	}

	// Token: 0x06019F33 RID: 106291 RVA: 0x007FED08 File Offset: 0x007FCF08
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AddBuffInner(long buffId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddBuffInner"), TsTriggerVolume.StaticClass(), out intPtr, out num))
		{
			this.AddBuffInner_Implementation(buffId);
			return;
		}
		TsTriggerVolume.__AddBuffInner_FunctionParams* ptr = stackalloc TsTriggerVolume.__AddBuffInner_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsTriggerVolume.__AddBuffInner_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->buffId = buffId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019F34 RID: 106292 RVA: 0x007FED94 File Offset: 0x007FCF94
	protected void AddBuffInner_Implementation(long buffId)
	{
	}

	// Token: 0x06019F35 RID: 106293 RVA: 0x007FED98 File Offset: 0x007FCF98
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void TryReportSelfBuffDamageLog()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTriggerVolume) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("TryReportSelfBuffDamageLog"), TsTriggerVolume.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.TryReportSelfBuffDamageLog_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019F36 RID: 106294 RVA: 0x007FEDF1 File Offset: 0x007FCFF1
	protected void TryReportSelfBuffDamageLog_Implementation()
	{
	}

	// Token: 0x06019F37 RID: 106295 RVA: 0x007FEDF3 File Offset: 0x007FCFF3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTriggerVolume._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTriggerVolume.TsTriggerVolume_C");
		}
		return TsTriggerVolume._ClassPtr;
	}

	// Token: 0x06019F38 RID: 106296 RVA: 0x007FEE18 File Offset: 0x007FD018
	public TsTriggerVolume() : this(BuiltinUtils.AllocNativeUObject(TsTriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019F39 RID: 106297 RVA: 0x007FEE40 File Offset: 0x007FD040
	public TsTriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019F3A RID: 106298 RVA: 0x007FEE73 File Offset: 0x007FD073
	protected TsTriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06019F3B RID: 106299 RVA: 0x007FEE7C File Offset: 0x007FD07C
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06019F3C RID: 106300 RVA: 0x007FEE84 File Offset: 0x007FD084
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x06019F3D RID: 106301 RVA: 0x007FEEA4 File Offset: 0x007FD0A4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x06019F3E RID: 106302 RVA: 0x007FEEB2 File Offset: 0x007FD0B2
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_AddBuffInner_Implementation(TsTriggerVolume.__AddBuffInner_FunctionParams* __Params)
	{
		this.AddBuffInner_Implementation(__Params->buffId);
	}

	// Token: 0x06019F3F RID: 106303 RVA: 0x007FEEC0 File Offset: 0x007FD0C0
	protected virtual void __CPPCALL_TryReportSelfBuffDamageLog_Implementation()
	{
		this.TryReportSelfBuffDamageLog_Implementation();
	}

	// Token: 0x0400E37F RID: 58239
	private static readonly ECollisionChannel KuroTriggerType = KuroCollisionChannel.KuroTrigger;

	// Token: 0x0400E380 RID: 58240
	private int CountInTrigger;

	// Token: 0x0400E381 RID: 58241
	private int SeasonPlayerOverlapCount;

	// Token: 0x0400E382 RID: 58242
	[Nullable(2)]
	public TimerHandle BuffTimerId;

	// Token: 0x0400E383 RID: 58243
	[Nullable(2)]
	private Action HandleWorldDone;

	// Token: 0x0400E384 RID: 58244
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTriggerVolume.TsTriggerVolume_C";

	// Token: 0x0400E385 RID: 58245
	private static IntPtr _ClassPtr;

	// Token: 0x0400E386 RID: 58246
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E387 RID: 58247
	private static int __PropertyOffset_TriggerItem;

	// Token: 0x0400E388 RID: 58248
	private static int __PropertyOffset_TriggerItems;

	// Token: 0x0400E389 RID: 58249
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<ABrush> _TriggerItems;

	// Token: 0x0400E38A RID: 58250
	private static int __PropertyOffset_TriggerType;

	// Token: 0x0400E38B RID: 58251
	private static int __PropertyOffset_TriggerGroup;

	// Token: 0x0400E38C RID: 58252
	private static int __PropertyOffset_TriggerId;

	// Token: 0x0400E38D RID: 58253
	private static int __PropertyOffset_ConditionGroupId;

	// Token: 0x0400E38E RID: 58254
	private static int __PropertyOffset_EventGroupId;

	// Token: 0x0400E38F RID: 58255
	private static int __PropertyOffset_ExitEventGroupId;

	// Token: 0x0400E390 RID: 58256
	private static int __PropertyOffset_IsPlayer;

	// Token: 0x0400E391 RID: 58257
	private static int __PropertyOffset_TriggerItemEffectData;

	// Token: 0x0400E392 RID: 58258
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _TriggerItemEffectData;

	// Token: 0x0400E393 RID: 58259
	private static int __PropertyOffset_NotScale;

	// Token: 0x0400E394 RID: 58260
	private static int __PropertyOffset_IgnoreBullet;

	// Token: 0x0400E395 RID: 58261
	private static int __PropertyOffset_HitCd;

	// Token: 0x0400E396 RID: 58262
	private static int __PropertyOffset_HitEffectData;

	// Token: 0x0400E397 RID: 58263
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _HitEffectData;

	// Token: 0x0400E398 RID: 58264
	private static int __PropertyOffset_HitDataName;

	// Token: 0x0400E399 RID: 58265
	private static int __PropertyOffset_IsBlockCamera;

	// Token: 0x0400E39A RID: 58266
	private static int __PropertyOffset_AreaId;

	// Token: 0x0400E39B RID: 58267
	private static int __PropertyOffset_SeasonAreaId;

	// Token: 0x0400E39C RID: 58268
	private static int __PropertyOffset_IsAutoTriggerEffect;

	// Token: 0x0400E39D RID: 58269
	private static int __PropertyOffset_EffectCd;

	// Token: 0x0400E39E RID: 58270
	private static int __PropertyOffset_ToleranceDistance;

	// Token: 0x0400E39F RID: 58271
	private static int __PropertyOffset_EnterAkEvent;

	// Token: 0x0400E3A0 RID: 58272
	private static int __PropertyOffset_ExitAkEvent;

	// Token: 0x0400E3A1 RID: 58273
	private static int __PropertyOffset_IsChangeFootStep;

	// Token: 0x0400E3A2 RID: 58274
	private static int __PropertyOffset_FootStepMaterialId;

	// Token: 0x0400E3A3 RID: 58275
	private static int __PropertyOffset_BuffIds;

	// Token: 0x0400E3A4 RID: 58276
	[Nullable(2)]
	private TArray<long> _BuffIds;

	// Token: 0x0400E3A5 RID: 58277
	private static int __PropertyOffset_IsRemoveBuffIds;

	// Token: 0x0400E3A6 RID: 58278
	private static int __PropertyOffset_PropsIds;

	// Token: 0x0400E3A7 RID: 58279
	[Nullable(2)]
	private TArray<int> _PropsIds;

	// Token: 0x0400E3A8 RID: 58280
	private static int __PropertyOffset_AddBuffType;

	// Token: 0x02008988 RID: 35208
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddBuffInner_FunctionParams
	{
		// Token: 0x0402BD2E RID: 179502
		[FieldOffset(0)]
		public long buffId;
	}
}
