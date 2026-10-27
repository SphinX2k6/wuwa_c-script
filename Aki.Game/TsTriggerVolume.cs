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

// Token: 0x020032BD RID: 12989
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTriggerVolume.TsTriggerVolume_C")]
public class TsTriggerVolume : AKuroEffectActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x170026F9 RID: 9977
	// (get) Token: 0x0601C2A5 RID: 115365 RVA: 0x007D6E94 File Offset: 0x007D5094
	// (set) Token: 0x0601C2A6 RID: 115366 RVA: 0x007D6EA8 File Offset: 0x007D50A8
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

	// Token: 0x170026FA RID: 9978
	// (get) Token: 0x0601C2A7 RID: 115367 RVA: 0x007D6EC0 File Offset: 0x007D50C0
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

	// Token: 0x170026FB RID: 9979
	// (get) Token: 0x0601C2A8 RID: 115368 RVA: 0x007D6EF9 File Offset: 0x007D50F9
	// (set) Token: 0x0601C2A9 RID: 115369 RVA: 0x007D6F09 File Offset: 0x007D5109
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

	// Token: 0x170026FC RID: 9980
	// (get) Token: 0x0601C2AA RID: 115370 RVA: 0x007D6F1A File Offset: 0x007D511A
	// (set) Token: 0x0601C2AB RID: 115371 RVA: 0x007D6F2A File Offset: 0x007D512A
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

	// Token: 0x170026FD RID: 9981
	// (get) Token: 0x0601C2AC RID: 115372 RVA: 0x007D6F3B File Offset: 0x007D513B
	// (set) Token: 0x0601C2AD RID: 115373 RVA: 0x007D6F4B File Offset: 0x007D514B
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

	// Token: 0x170026FE RID: 9982
	// (get) Token: 0x0601C2AE RID: 115374 RVA: 0x007D6F5C File Offset: 0x007D515C
	// (set) Token: 0x0601C2AF RID: 115375 RVA: 0x007D6F70 File Offset: 0x007D5170
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

	// Token: 0x170026FF RID: 9983
	// (get) Token: 0x0601C2B0 RID: 115376 RVA: 0x007D6F85 File Offset: 0x007D5185
	// (set) Token: 0x0601C2B1 RID: 115377 RVA: 0x007D6F99 File Offset: 0x007D5199
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

	// Token: 0x17002700 RID: 9984
	// (get) Token: 0x0601C2B2 RID: 115378 RVA: 0x007D6FAE File Offset: 0x007D51AE
	// (set) Token: 0x0601C2B3 RID: 115379 RVA: 0x007D6FC2 File Offset: 0x007D51C2
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

	// Token: 0x17002701 RID: 9985
	// (get) Token: 0x0601C2B4 RID: 115380 RVA: 0x007D6FD7 File Offset: 0x007D51D7
	// (set) Token: 0x0601C2B5 RID: 115381 RVA: 0x007D6FE7 File Offset: 0x007D51E7
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

	// Token: 0x17002702 RID: 9986
	// (get) Token: 0x0601C2B6 RID: 115382 RVA: 0x007D6FF8 File Offset: 0x007D51F8
	// (set) Token: 0x0601C2B7 RID: 115383 RVA: 0x007D7031 File Offset: 0x007D5231
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

	// Token: 0x17002703 RID: 9987
	// (get) Token: 0x0601C2B8 RID: 115384 RVA: 0x007D7056 File Offset: 0x007D5256
	// (set) Token: 0x0601C2B9 RID: 115385 RVA: 0x007D7066 File Offset: 0x007D5266
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

	// Token: 0x17002704 RID: 9988
	// (get) Token: 0x0601C2BA RID: 115386 RVA: 0x007D7077 File Offset: 0x007D5277
	// (set) Token: 0x0601C2BB RID: 115387 RVA: 0x007D7087 File Offset: 0x007D5287
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

	// Token: 0x17002705 RID: 9989
	// (get) Token: 0x0601C2BC RID: 115388 RVA: 0x007D7098 File Offset: 0x007D5298
	// (set) Token: 0x0601C2BD RID: 115389 RVA: 0x007D70A8 File Offset: 0x007D52A8
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

	// Token: 0x17002706 RID: 9990
	// (get) Token: 0x0601C2BE RID: 115390 RVA: 0x007D70BC File Offset: 0x007D52BC
	// (set) Token: 0x0601C2BF RID: 115391 RVA: 0x007D70F5 File Offset: 0x007D52F5
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

	// Token: 0x17002707 RID: 9991
	// (get) Token: 0x0601C2C0 RID: 115392 RVA: 0x007D711A File Offset: 0x007D531A
	// (set) Token: 0x0601C2C1 RID: 115393 RVA: 0x007D712E File Offset: 0x007D532E
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

	// Token: 0x17002708 RID: 9992
	// (get) Token: 0x0601C2C2 RID: 115394 RVA: 0x007D7143 File Offset: 0x007D5343
	// (set) Token: 0x0601C2C3 RID: 115395 RVA: 0x007D7153 File Offset: 0x007D5353
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

	// Token: 0x17002709 RID: 9993
	// (get) Token: 0x0601C2C4 RID: 115396 RVA: 0x007D7164 File Offset: 0x007D5364
	// (set) Token: 0x0601C2C5 RID: 115397 RVA: 0x007D7174 File Offset: 0x007D5374
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

	// Token: 0x1700270A RID: 9994
	// (get) Token: 0x0601C2C6 RID: 115398 RVA: 0x007D7185 File Offset: 0x007D5385
	// (set) Token: 0x0601C2C7 RID: 115399 RVA: 0x007D7195 File Offset: 0x007D5395
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

	// Token: 0x1700270B RID: 9995
	// (get) Token: 0x0601C2C8 RID: 115400 RVA: 0x007D71A6 File Offset: 0x007D53A6
	// (set) Token: 0x0601C2C9 RID: 115401 RVA: 0x007D71B6 File Offset: 0x007D53B6
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

	// Token: 0x1700270C RID: 9996
	// (get) Token: 0x0601C2CA RID: 115402 RVA: 0x007D71C7 File Offset: 0x007D53C7
	// (set) Token: 0x0601C2CB RID: 115403 RVA: 0x007D71D7 File Offset: 0x007D53D7
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

	// Token: 0x1700270D RID: 9997
	// (get) Token: 0x0601C2CC RID: 115404 RVA: 0x007D71E8 File Offset: 0x007D53E8
	// (set) Token: 0x0601C2CD RID: 115405 RVA: 0x007D71F8 File Offset: 0x007D53F8
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

	// Token: 0x1700270E RID: 9998
	// (get) Token: 0x0601C2CE RID: 115406 RVA: 0x007D7209 File Offset: 0x007D5409
	// (set) Token: 0x0601C2CF RID: 115407 RVA: 0x007D721D File Offset: 0x007D541D
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

	// Token: 0x1700270F RID: 9999
	// (get) Token: 0x0601C2D0 RID: 115408 RVA: 0x007D7232 File Offset: 0x007D5432
	// (set) Token: 0x0601C2D1 RID: 115409 RVA: 0x007D7246 File Offset: 0x007D5446
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

	// Token: 0x17002710 RID: 10000
	// (get) Token: 0x0601C2D2 RID: 115410 RVA: 0x007D725B File Offset: 0x007D545B
	// (set) Token: 0x0601C2D3 RID: 115411 RVA: 0x007D726B File Offset: 0x007D546B
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

	// Token: 0x17002711 RID: 10001
	// (get) Token: 0x0601C2D4 RID: 115412 RVA: 0x007D727C File Offset: 0x007D547C
	// (set) Token: 0x0601C2D5 RID: 115413 RVA: 0x007D728C File Offset: 0x007D548C
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

	// Token: 0x17002712 RID: 10002
	// (get) Token: 0x0601C2D6 RID: 115414 RVA: 0x007D72A0 File Offset: 0x007D54A0
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

	// Token: 0x17002713 RID: 10003
	// (get) Token: 0x0601C2D7 RID: 115415 RVA: 0x007D72D9 File Offset: 0x007D54D9
	// (set) Token: 0x0601C2D8 RID: 115416 RVA: 0x007D72E9 File Offset: 0x007D54E9
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

	// Token: 0x17002714 RID: 10004
	// (get) Token: 0x0601C2D9 RID: 115417 RVA: 0x007D72FC File Offset: 0x007D54FC
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

	// Token: 0x17002715 RID: 10005
	// (get) Token: 0x0601C2DA RID: 115418 RVA: 0x007D7335 File Offset: 0x007D5535
	// (set) Token: 0x0601C2DB RID: 115419 RVA: 0x007D7345 File Offset: 0x007D5545
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

	// Token: 0x0601C2DC RID: 115420 RVA: 0x007D7358 File Offset: 0x007D5558
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C2DD RID: 115421 RVA: 0x007D73C8 File Offset: 0x007D55C8
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

	// Token: 0x0601C2DE RID: 115422 RVA: 0x007D74D0 File Offset: 0x007D56D0
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

	// Token: 0x0601C2DF RID: 115423 RVA: 0x007D7539 File Offset: 0x007D5739
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

	// Token: 0x0601C2E0 RID: 115424 RVA: 0x007D7558 File Offset: 0x007D5758
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->EndPlayReason) = (byte)EndPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C2E1 RID: 115425 RVA: 0x007D75D4 File Offset: 0x007D57D4
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

	// Token: 0x0601C2E2 RID: 115426 RVA: 0x007D76B4 File Offset: 0x007D58B4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveTick_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C2E3 RID: 115427 RVA: 0x007D772A File Offset: 0x007D592A
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
	}

	// Token: 0x0601C2E4 RID: 115428 RVA: 0x007D772C File Offset: 0x007D592C
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

	// Token: 0x0601C2E5 RID: 115429 RVA: 0x007D77C5 File Offset: 0x007D59C5
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

	// Token: 0x0601C2E6 RID: 115430 RVA: 0x007D7800 File Offset: 0x007D5A00
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

	// Token: 0x0601C2E7 RID: 115431 RVA: 0x007D7894 File Offset: 0x007D5A94
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

	// Token: 0x0601C2E8 RID: 115432 RVA: 0x007D793C File Offset: 0x007D5B3C
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

	// Token: 0x0601C2E9 RID: 115433 RVA: 0x007D79A0 File Offset: 0x007D5BA0
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

	// Token: 0x0601C2EA RID: 115434 RVA: 0x007D79F0 File Offset: 0x007D5BF0
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

	// Token: 0x0601C2EB RID: 115435 RVA: 0x007D7A88 File Offset: 0x007D5C88
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

	// Token: 0x0601C2EC RID: 115436 RVA: 0x007D7AE6 File Offset: 0x007D5CE6
	public void ToggleArea(bool inEnable)
	{
		this.SetEnable(inEnable);
	}

	// Token: 0x0601C2ED RID: 115437 RVA: 0x007D7AF0 File Offset: 0x007D5CF0
	private void PostAkEvent(AActor actor, UAkAudioEvent @event)
	{
		if (actor != RoleTriggerController.Instance.GetMyRoleTrigger())
		{
			return;
		}
		string pathName = UKismetSystemLibrary.GetPathName(@event);
		AudioController.Instance.PostEvent(pathName, null, null, null, null, null, true, "");
	}

	// Token: 0x0601C2EE RID: 115438 RVA: 0x007D7B38 File Offset: 0x007D5D38
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

	// Token: 0x0601C2EF RID: 115439 RVA: 0x007D7B6B File Offset: 0x007D5D6B
	private bool CheckBeginOverlapRoleTrigger(AActor otherActor)
	{
		return otherActor == RoleTriggerController.Instance.GetMyRoleTrigger();
	}

	// Token: 0x0601C2F0 RID: 115440 RVA: 0x007D7B80 File Offset: 0x007D5D80
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AddBuffInner(long buffId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddBuffInner"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTriggerVolume.__AddBuffInner_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTriggerVolume.__AddBuffInner_FunctionParams*)ptr + 15L / (long)sizeof(TsTriggerVolume.__AddBuffInner_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->buffId = buffId;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C2F1 RID: 115441 RVA: 0x007D7BF6 File Offset: 0x007D5DF6
	protected void AddBuffInner_Implementation(long buffId)
	{
	}

	// Token: 0x0601C2F2 RID: 115442 RVA: 0x007D7BF8 File Offset: 0x007D5DF8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void TryReportSelfBuffDamageLog()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("TryReportSelfBuffDamageLog"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C2F3 RID: 115443 RVA: 0x007D7C68 File Offset: 0x007D5E68
	protected void TryReportSelfBuffDamageLog_Implementation()
	{
	}

	// Token: 0x0601C2F4 RID: 115444 RVA: 0x007D7C6A File Offset: 0x007D5E6A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTriggerVolume._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTriggerVolume.TsTriggerVolume_C");
		}
		return TsTriggerVolume._ClassPtr;
	}

	// Token: 0x0601C2F5 RID: 115445 RVA: 0x007D7C90 File Offset: 0x007D5E90
	public TsTriggerVolume() : this(BuiltinUtils.AllocNativeUObject(TsTriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C2F6 RID: 115446 RVA: 0x007D7CB8 File Offset: 0x007D5EB8
	public TsTriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C2F7 RID: 115447 RVA: 0x007D7CEB File Offset: 0x007D5EEB
	protected TsTriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C2F8 RID: 115448 RVA: 0x007D7CF4 File Offset: 0x007D5EF4
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C2F9 RID: 115449 RVA: 0x007D7CFC File Offset: 0x007D5EFC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C2FA RID: 115450 RVA: 0x007D7D1C File Offset: 0x007D5F1C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C2FB RID: 115451 RVA: 0x007D7D2A File Offset: 0x007D5F2A
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_AddBuffInner_Implementation(TsTriggerVolume.__AddBuffInner_FunctionParams* __Params)
	{
		this.AddBuffInner_Implementation(__Params->buffId);
	}

	// Token: 0x0601C2FC RID: 115452 RVA: 0x007D7D38 File Offset: 0x007D5F38
	protected virtual void __CPPCALL_TryReportSelfBuffDamageLog_Implementation()
	{
		this.TryReportSelfBuffDamageLog_Implementation();
	}

	// Token: 0x0400DEDD RID: 57053
	private static readonly ECollisionChannel KuroTriggerType = KuroCollisionChannel.KuroTrigger;

	// Token: 0x0400DEDE RID: 57054
	private int CountInTrigger;

	// Token: 0x0400DEDF RID: 57055
	private int SeasonPlayerOverlapCount;

	// Token: 0x0400DEE0 RID: 57056
	[Nullable(2)]
	public TimerHandle BuffTimerId;

	// Token: 0x0400DEE1 RID: 57057
	[Nullable(2)]
	private Action HandleWorldDone;

	// Token: 0x0400DEE2 RID: 57058
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsTriggerVolume.TsTriggerVolume_C";

	// Token: 0x0400DEE3 RID: 57059
	private static IntPtr _ClassPtr;

	// Token: 0x0400DEE4 RID: 57060
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400DEE5 RID: 57061
	private static int __PropertyOffset_TriggerItem;

	// Token: 0x0400DEE6 RID: 57062
	private static int __PropertyOffset_TriggerItems;

	// Token: 0x0400DEE7 RID: 57063
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<ABrush> _TriggerItems;

	// Token: 0x0400DEE8 RID: 57064
	private static int __PropertyOffset_TriggerType;

	// Token: 0x0400DEE9 RID: 57065
	private static int __PropertyOffset_TriggerGroup;

	// Token: 0x0400DEEA RID: 57066
	private static int __PropertyOffset_TriggerId;

	// Token: 0x0400DEEB RID: 57067
	private static int __PropertyOffset_ConditionGroupId;

	// Token: 0x0400DEEC RID: 57068
	private static int __PropertyOffset_EventGroupId;

	// Token: 0x0400DEED RID: 57069
	private static int __PropertyOffset_ExitEventGroupId;

	// Token: 0x0400DEEE RID: 57070
	private static int __PropertyOffset_IsPlayer;

	// Token: 0x0400DEEF RID: 57071
	private static int __PropertyOffset_TriggerItemEffectData;

	// Token: 0x0400DEF0 RID: 57072
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _TriggerItemEffectData;

	// Token: 0x0400DEF1 RID: 57073
	private static int __PropertyOffset_NotScale;

	// Token: 0x0400DEF2 RID: 57074
	private static int __PropertyOffset_IgnoreBullet;

	// Token: 0x0400DEF3 RID: 57075
	private static int __PropertyOffset_HitCd;

	// Token: 0x0400DEF4 RID: 57076
	private static int __PropertyOffset_HitEffectData;

	// Token: 0x0400DEF5 RID: 57077
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _HitEffectData;

	// Token: 0x0400DEF6 RID: 57078
	private static int __PropertyOffset_HitDataName;

	// Token: 0x0400DEF7 RID: 57079
	private static int __PropertyOffset_IsBlockCamera;

	// Token: 0x0400DEF8 RID: 57080
	private static int __PropertyOffset_AreaId;

	// Token: 0x0400DEF9 RID: 57081
	private static int __PropertyOffset_SeasonAreaId;

	// Token: 0x0400DEFA RID: 57082
	private static int __PropertyOffset_IsAutoTriggerEffect;

	// Token: 0x0400DEFB RID: 57083
	private static int __PropertyOffset_EffectCd;

	// Token: 0x0400DEFC RID: 57084
	private static int __PropertyOffset_ToleranceDistance;

	// Token: 0x0400DEFD RID: 57085
	private static int __PropertyOffset_EnterAkEvent;

	// Token: 0x0400DEFE RID: 57086
	private static int __PropertyOffset_ExitAkEvent;

	// Token: 0x0400DEFF RID: 57087
	private static int __PropertyOffset_IsChangeFootStep;

	// Token: 0x0400DF00 RID: 57088
	private static int __PropertyOffset_FootStepMaterialId;

	// Token: 0x0400DF01 RID: 57089
	private static int __PropertyOffset_BuffIds;

	// Token: 0x0400DF02 RID: 57090
	[Nullable(2)]
	private TArray<long> _BuffIds;

	// Token: 0x0400DF03 RID: 57091
	private static int __PropertyOffset_IsRemoveBuffIds;

	// Token: 0x0400DF04 RID: 57092
	private static int __PropertyOffset_PropsIds;

	// Token: 0x0400DF05 RID: 57093
	[Nullable(2)]
	private TArray<int> _PropsIds;

	// Token: 0x0400DF06 RID: 57094
	private static int __PropertyOffset_AddBuffType;

	// Token: 0x02009765 RID: 38757
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddBuffInner_FunctionParams
	{
		// Token: 0x040306A1 RID: 198305
		[FieldOffset(0)]
		public long buffId;
	}
}
