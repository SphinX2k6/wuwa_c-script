using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight.Manager;
using AkiClient.Game.Aki.CreatureTools;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200023E RID: 574
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Character/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Character/TsBaseCharacter.TsBaseCharacter_C")]
public class TsBaseCharacter : ABaseCharacter, IBPI_CreatureInterface_C, IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject, IUnrealUObject
{
	// Token: 0x17000543 RID: 1347
	// (get) Token: 0x06002310 RID: 8976 RVA: 0x000D9704 File Offset: 0x000D7904
	// (set) Token: 0x06002311 RID: 8977 RVA: 0x000D9718 File Offset: 0x000D7918
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe CharRenderingComponent CharRenderingComponent
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<CharRenderingComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_CharRenderingComponent);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_CharRenderingComponent, value);
		}
	}

	// Token: 0x17000544 RID: 1348
	// (get) Token: 0x06002312 RID: 8978 RVA: 0x000D972D File Offset: 0x000D792D
	// (set) Token: 0x06002313 RID: 8979 RVA: 0x000D973D File Offset: 0x000D793D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECharacterRenderingType RenderType
	{
		get
		{
			return (ECharacterRenderingType)(*(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_RenderType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_RenderType) = (byte)value;
		}
	}

	// Token: 0x17000545 RID: 1349
	// (get) Token: 0x06002314 RID: 8980 RVA: 0x000D974E File Offset: 0x000D794E
	// (set) Token: 0x06002315 RID: 8981 RVA: 0x000D9762 File Offset: 0x000D7962
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TsCharacterDebugComponent TsCharacterDebugComponent
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<TsCharacterDebugComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_TsCharacterDebugComponent);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_TsCharacterDebugComponent, value);
		}
	}

	// Token: 0x17000546 RID: 1350
	// (get) Token: 0x06002316 RID: 8982 RVA: 0x000D9777 File Offset: 0x000D7977
	// (set) Token: 0x06002317 RID: 8983 RVA: 0x000D978B File Offset: 0x000D798B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UNavigationInvokerComponent NavigationInvoker
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UNavigationInvokerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_NavigationInvoker);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_NavigationInvoker, value);
		}
	}

	// Token: 0x17000547 RID: 1351
	// (get) Token: 0x06002318 RID: 8984 RVA: 0x000D97A0 File Offset: 0x000D79A0
	// (set) Token: 0x06002319 RID: 8985 RVA: 0x000D97D9 File Offset: 0x000D79D9
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public FSoftClassPath InputComponentClass
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			FSoftClassPath result;
			if ((result = this._InputComponentClass) == null)
			{
				result = (this._InputComponentClass = new FSoftClassPath(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_InputComponentClass, this));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_InputComponentClass, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17000548 RID: 1352
	// (get) Token: 0x0600231A RID: 8986 RVA: 0x000D9801 File Offset: 0x000D7A01
	// (set) Token: 0x0600231B RID: 8987 RVA: 0x000D9815 File Offset: 0x000D7A15
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe BP_BasePlatform_C BasePlatform
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<BP_BasePlatform_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_BasePlatform);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_BasePlatform, value);
		}
	}

	// Token: 0x17000549 RID: 1353
	// (get) Token: 0x0600231C RID: 8988 RVA: 0x000D982A File Offset: 0x000D7A2A
	// (set) Token: 0x0600231D RID: 8989 RVA: 0x000D983A File Offset: 0x000D7A3A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int EntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_EntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_EntityId) = value;
		}
	}

	// Token: 0x0600231E RID: 8990 RVA: 0x000D984B File Offset: 0x000D7A4B
	public void SetEntityId(int entityId)
	{
		this.EntityId = entityId;
		base.EntityIdInternal = entityId;
	}

	// Token: 0x0600231F RID: 8991 RVA: 0x000D985C File Offset: 0x000D7A5C
	public void TryAddTsAbilitySystemComponent()
	{
		if (base.AbilitySystemComponent == null)
		{
			base.AbilitySystemComponent = (base.AddComponentByClass(UBaseAbilitySystemComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UBaseAbilitySystemComponent);
		}
	}

	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x06002320 RID: 8992 RVA: 0x000D98A1 File Offset: 0x000D7AA1
	// (set) Token: 0x06002321 RID: 8993 RVA: 0x000D98B5 File Offset: 0x000D7AB5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe BP_FightManager_C FightManager
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<BP_FightManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_FightManager);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_FightManager, value);
		}
	}

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x06002322 RID: 8994 RVA: 0x000D98CA File Offset: 0x000D7ACA
	// (set) Token: 0x06002323 RID: 8995 RVA: 0x000D98DE File Offset: 0x000D7ADE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UDataTable DtHitEffect
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtHitEffect);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtHitEffect, value);
		}
	}

	// Token: 0x1700054C RID: 1356
	// (get) Token: 0x06002324 RID: 8996 RVA: 0x000D98F3 File Offset: 0x000D7AF3
	// (set) Token: 0x06002325 RID: 8997 RVA: 0x000D9907 File Offset: 0x000D7B07
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UDataTable DtBaseMovementSetting
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtBaseMovementSetting);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtBaseMovementSetting, value);
		}
	}

	// Token: 0x1700054D RID: 1357
	// (get) Token: 0x06002326 RID: 8998 RVA: 0x000D991C File Offset: 0x000D7B1C
	// (set) Token: 0x06002327 RID: 8999 RVA: 0x000D9930 File Offset: 0x000D7B30
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UDataTable DtNewBulletDataMain
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtNewBulletDataMain);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtNewBulletDataMain, value);
		}
	}

	// Token: 0x1700054E RID: 1358
	// (get) Token: 0x06002328 RID: 9000 RVA: 0x000D9945 File Offset: 0x000D7B45
	// (set) Token: 0x06002329 RID: 9001 RVA: 0x000D9959 File Offset: 0x000D7B59
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UDataTable DtCharacterPart
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtCharacterPart);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtCharacterPart, value);
		}
	}

	// Token: 0x1700054F RID: 1359
	// (get) Token: 0x0600232A RID: 9002 RVA: 0x000D996E File Offset: 0x000D7B6E
	// (set) Token: 0x0600232B RID: 9003 RVA: 0x000D9982 File Offset: 0x000D7B82
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UDataTable DtCameraConfig
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtCameraConfig);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtCameraConfig, value);
		}
	}

	// Token: 0x17000550 RID: 1360
	// (get) Token: 0x0600232C RID: 9004 RVA: 0x000D9998 File Offset: 0x000D7B98
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FName> BattleSockets
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TArray<FName> result;
			if ((result = this._BattleSockets) == null)
			{
				result = (this._BattleSockets = new TArray<FName>(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_BattleSockets, this));
			}
			return result;
		}
	}

	// Token: 0x17000551 RID: 1361
	// (get) Token: 0x0600232D RID: 9005 RVA: 0x000D99D4 File Offset: 0x000D7BD4
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FName> NormalSockets
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TArray<FName> result;
			if ((result = this._NormalSockets) == null)
			{
				result = (this._NormalSockets = new TArray<FName>(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_NormalSockets, this));
			}
			return result;
		}
	}

	// Token: 0x17000552 RID: 1362
	// (get) Token: 0x0600232E RID: 9006 RVA: 0x000D9A0D File Offset: 0x000D7C0D
	// (set) Token: 0x0600232F RID: 9007 RVA: 0x000D9A21 File Offset: 0x000D7C21
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerData_C WeaponInEffect
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_WeaponInEffect);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_WeaponInEffect, value);
		}
	}

	// Token: 0x17000553 RID: 1363
	// (get) Token: 0x06002330 RID: 9008 RVA: 0x000D9A36 File Offset: 0x000D7C36
	// (set) Token: 0x06002331 RID: 9009 RVA: 0x000D9A4A File Offset: 0x000D7C4A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UEffectModelBase WeaponHideEffect
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_WeaponHideEffect);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_WeaponHideEffect, value);
		}
	}

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x06002332 RID: 9010 RVA: 0x000D9A5F File Offset: 0x000D7C5F
	// (set) Token: 0x06002333 RID: 9011 RVA: 0x000D9A73 File Offset: 0x000D7C73
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UPrimaryDataAsset FkData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UPrimaryDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_FkData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_FkData, value);
		}
	}

	// Token: 0x17000555 RID: 1365
	// (get) Token: 0x06002334 RID: 9012 RVA: 0x000D9A88 File Offset: 0x000D7C88
	// (set) Token: 0x06002335 RID: 9013 RVA: 0x000D9A9C File Offset: 0x000D7C9C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UPrimaryDataAsset CharacterData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UPrimaryDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_CharacterData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_CharacterData, value);
		}
	}

	// Token: 0x17000556 RID: 1366
	// (get) Token: 0x06002336 RID: 9014 RVA: 0x000D9AB1 File Offset: 0x000D7CB1
	// (set) Token: 0x06002337 RID: 9015 RVA: 0x000D9AC1 File Offset: 0x000D7CC1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECamp Camp
	{
		get
		{
			return (ECamp)(*(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_Camp));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_Camp) = (byte)value;
		}
	}

	// Token: 0x06002338 RID: 9016 RVA: 0x000D9AD2 File Offset: 0x000D7CD2
	public void SetCamp(ECamp camp)
	{
		this.Camp = camp;
	}

	// Token: 0x17000557 RID: 1367
	// (get) Token: 0x06002339 RID: 9017 RVA: 0x000D9ADB File Offset: 0x000D7CDB
	// (set) Token: 0x0600233A RID: 9018 RVA: 0x000D9AEB File Offset: 0x000D7CEB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool PhysicsClothSimulateEnable
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_PhysicsClothSimulateEnable) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_PhysicsClothSimulateEnable) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x0600233B RID: 9019 RVA: 0x000D9AFC File Offset: 0x000D7CFC
	// (set) Token: 0x0600233C RID: 9020 RVA: 0x000D9B0C File Offset: 0x000D7D0C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool PhysicsClothSimulateDisableOneFrame
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_PhysicsClothSimulateDisableOneFrame) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_PhysicsClothSimulateDisableOneFrame) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000559 RID: 1369
	// (get) Token: 0x0600233D RID: 9021 RVA: 0x000D9B1D File Offset: 0x000D7D1D
	// (set) Token: 0x0600233E RID: 9022 RVA: 0x000D9B2D File Offset: 0x000D7D2D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CachePoseEnableOneFrame
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_CachePoseEnableOneFrame) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_CachePoseEnableOneFrame) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x0600233F RID: 9023 RVA: 0x000D9B3E File Offset: 0x000D7D3E
	// (set) Token: 0x06002340 RID: 9024 RVA: 0x000D9B4E File Offset: 0x000D7D4E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CacheTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_CacheTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBaseCharacter.__PropertyOffset_CacheTime) = value;
		}
	}

	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x06002341 RID: 9025 RVA: 0x000D9B5F File Offset: 0x000D7D5F
	// (set) Token: 0x06002342 RID: 9026 RVA: 0x000D9B73 File Offset: 0x000D7D73
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UDataTable DtGameplayAbpConfig
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtGameplayAbpConfig);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseCharacter.__PropertyOffset_DtGameplayAbpConfig, value);
		}
	}

	// Token: 0x1700055C RID: 1372
	// (get) Token: 0x06002343 RID: 9027 RVA: 0x000D9B88 File Offset: 0x000D7D88
	// (set) Token: 0x06002344 RID: 9028 RVA: 0x000D9B90 File Offset: 0x000D7D90
	public CharacterActorComponent CharacterActorComponent { get; set; }

	// Token: 0x1700055D RID: 1373
	// (get) Token: 0x06002345 RID: 9029 RVA: 0x000D9B99 File Offset: 0x000D7D99
	// (set) Token: 0x06002346 RID: 9030 RVA: 0x000D9BA1 File Offset: 0x000D7DA1
	public SimpleNpcActorComponent SimpleNpcActorComponent { get; set; }

	// Token: 0x06002347 RID: 9031 RVA: 0x000D9BAC File Offset: 0x000D7DAC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void K2_OnMovementModeChanged(EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_OnMovementModeChanged"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		ACharacter.__K2_OnMovementModeChanged_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((ACharacter.__K2_OnMovementModeChanged_FunctionParams*)ptr + 15L / (long)sizeof(ACharacter.__K2_OnMovementModeChanged_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->PrevMovementMode) = (byte)prevMovementMode;
			*(byte*)(&ptr2->NewMovementMode) = (byte)newMovementMode;
			ptr2->PrevCustomMode = prevCustomMode;
			ptr2->NewCustomMode = newCustomMode;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06002348 RID: 9032 RVA: 0x000D9C40 File Offset: 0x000D7E40
	protected virtual void K2_OnMovementModeChanged_Implementation(EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
	{
		if (this.CharacterActorComponent == null)
		{
			return;
		}
		this.OnMovementModeChanged = true;
		EventSystem.Instance.EmitWithTarget<int, EMovementMode, EMovementMode, byte, byte>(this.CharacterActorComponent.Entity, EEventName.CharMovementModeChanged, this.CharacterActorComponent.Entity.Id, prevMovementMode, newMovementMode, prevCustomMode, newCustomMode);
		this.OnMovementModeChanged = false;
	}

	// Token: 0x06002349 RID: 9033 RVA: 0x000D9C94 File Offset: 0x000D7E94
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void BindGameplayEnableState(ref bool gameplayEnable)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("BindGameplayEnableState"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseCharacter.__BindGameplayEnableState_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseCharacter.__BindGameplayEnableState_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseCharacter.__BindGameplayEnableState_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->gameplayEnable = gameplayEnable;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		gameplayEnable = ptr2->gameplayEnable;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0600234A RID: 9034 RVA: 0x000D9D13 File Offset: 0x000D7F13
	protected void BindGameplayEnableState_Implementation(ref bool gameplayEnable)
	{
		this.AbpGameplayEnableState = new bool?(gameplayEnable);
	}

	// Token: 0x0600234B RID: 9035 RVA: 0x000D9D22 File Offset: 0x000D7F22
	public void SetGameplayEnableState(bool enable)
	{
		if (this.AbpGameplayEnableState == null)
		{
			return;
		}
		this.AbpGameplayEnableState = new bool?(enable);
	}

	// Token: 0x0600234C RID: 9036 RVA: 0x000D9D40 File Offset: 0x000D7F40
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceivePossessed(AController newController)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceivePossessed"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		APawn.__ReceivePossessed_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((APawn.__ReceivePossessed_FunctionParams*)ptr + 15L / (long)sizeof(APawn.__ReceivePossessed_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->NewController) = ((newController != null) ? newController.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0600234D RID: 9037 RVA: 0x000D9DC4 File Offset: 0x000D7FC4
	protected virtual void ReceivePossessed_Implementation(AController newController)
	{
		if (this.CharacterActorComponent == null || !(newController is BP_CharacterController_C))
		{
			return;
		}
		EventSystem.Instance.EmitWithTarget<Entity, AController>(this.CharacterActorComponent.Entity, EEventName.CharPossessed, this.CharacterActorComponent.Entity, newController);
	}

	// Token: 0x0600234E RID: 9038 RVA: 0x000D9E00 File Offset: 0x000D8000
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveUnpossessed(AController oldController)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveUnpossessed"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		APawn.__ReceiveUnpossessed_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((APawn.__ReceiveUnpossessed_FunctionParams*)ptr + 15L / (long)sizeof(APawn.__ReceiveUnpossessed_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OldController) = ((oldController != null) ? oldController.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0600234F RID: 9039 RVA: 0x000D9E84 File Offset: 0x000D8084
	protected virtual void ReceiveUnpossessed_Implementation(AController oldController)
	{
		if (this.CharacterActorComponent == null || !(oldController is BP_CharacterController_C))
		{
			return;
		}
		EventSystem.Instance.EmitWithTarget<Entity, AController>(this.CharacterActorComponent.Entity, EEventName.CharUnpossessed, this.CharacterActorComponent.Entity, oldController);
	}

	// Token: 0x06002350 RID: 9040 RVA: 0x000D9EC0 File Offset: 0x000D80C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual int GetEntityId()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetEntityId"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseCharacter.__GetEntityId_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseCharacter.__GetEntityId_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseCharacter.__GetEntityId_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		int _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06002351 RID: 9041 RVA: 0x000D9F35 File Offset: 0x000D8135
	protected int GetEntityId_Implementation()
	{
		return ((IBPI_CreatureInterface_C)this).GetEntityId();
	}

	// Token: 0x06002352 RID: 9042 RVA: 0x000D9F3D File Offset: 0x000D813D
	int IBPI_CreatureInterface_C.GetEntityId()
	{
		if (this.CharacterActorComponent != null)
		{
			return this.CharacterActorComponent.Entity.Id;
		}
		if (this.SimpleNpcActorComponent != null)
		{
			return this.SimpleNpcActorComponent.Entity.Id;
		}
		return 0;
	}

	// Token: 0x06002353 RID: 9043 RVA: 0x000D9F72 File Offset: 0x000D8172
	public int GetEntityIdNoBlueprint()
	{
		if (this.CharacterActorComponent != null)
		{
			return this.CharacterActorComponent.Entity.Id;
		}
		if (this.SimpleNpcActorComponent != null)
		{
			return this.SimpleNpcActorComponent.Entity.Id;
		}
		return 0;
	}

	// Token: 0x06002354 RID: 9044 RVA: 0x000D9FA8 File Offset: 0x000D81A8
	public Entity GetEntityNoBlueprint()
	{
		Entity result = null;
		if (this.CharacterActorComponent != null)
		{
			result = this.CharacterActorComponent.Entity;
		}
		else if (this.SimpleNpcActorComponent != null)
		{
			result = this.SimpleNpcActorComponent.Entity;
		}
		return result;
	}

	// Token: 0x06002355 RID: 9045 RVA: 0x000D9FE4 File Offset: 0x000D81E4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Initialize()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Initialize"), out num);
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

	// Token: 0x06002356 RID: 9046 RVA: 0x000DA054 File Offset: 0x000D8254
	protected void Initialize_Implementation()
	{
	}

	// Token: 0x1700055E RID: 1374
	// (get) Token: 0x06002357 RID: 9047 RVA: 0x000DA058 File Offset: 0x000D8258
	// (set) Token: 0x06002358 RID: 9048 RVA: 0x000DA084 File Offset: 0x000D8284
	[Nullable(1)]
	public CharacterDitherEffectController DitherEffectController
	{
		[NullableContext(1)]
		get
		{
			CharacterDitherEffectController result;
			if ((result = this.DitherEffectControllerInternal) == null)
			{
				result = (this.DitherEffectControllerInternal = new CharacterDitherEffectController(this, this.CharRenderingComponent));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			this.DitherEffectControllerInternal = value;
		}
	}

	// Token: 0x1700055F RID: 1375
	// (get) Token: 0x06002359 RID: 9049 RVA: 0x000DA08D File Offset: 0x000D828D
	public bool HasDitherEffectController
	{
		get
		{
			return this.DitherEffectControllerInternal != null;
		}
	}

	// Token: 0x0600235A RID: 9050 RVA: 0x000DA098 File Offset: 0x000D8298
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDitherEffect(float dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDitherEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseCharacter.__SetDitherEffect_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseCharacter.__SetDitherEffect_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseCharacter.__SetDitherEffect_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->dither = dither;
			*(&ptr2->ditherType) = (byte)ditherType;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0600235B RID: 9051 RVA: 0x000DA117 File Offset: 0x000D8317
	protected void SetDitherEffect_Implementation(float dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
	{
		if (this.HasDitherEffectController)
		{
			CharacterDitherEffectController ditherEffectController = this.DitherEffectController;
			if (ditherEffectController == null)
			{
				return;
			}
			ditherEffectController.SetDitherEffect((double)dither, ditherType, true);
		}
	}

	// Token: 0x0600235C RID: 9052 RVA: 0x000DA138 File Offset: 0x000D8338
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void K2_UpdateCustomMovement(float delta)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_UpdateCustomMovement"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		ACharacter.__K2_UpdateCustomMovement_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((ACharacter.__K2_UpdateCustomMovement_FunctionParams*)ptr + 15L / (long)sizeof(ACharacter.__K2_UpdateCustomMovement_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaTime = delta;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0600235D RID: 9053 RVA: 0x000DA1B0 File Offset: 0x000D83B0
	protected virtual void K2_UpdateCustomMovement_Implementation(float delta)
	{
		switch (base.CharacterMovement.CustomMovementMode)
		{
		case 0:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveClimb, delta);
			return;
		case 1:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveSwim, delta);
			return;
		case 2:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveGlide, delta);
			return;
		case 3:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMovePendulum, delta);
			return;
		case 4:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveSlide, delta);
			return;
		case 5:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveWalkOnWater, delta);
			return;
		case 6:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveCatapult, delta);
			return;
		case 7:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveSoar, delta);
			return;
		case 8:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveSki, delta);
			return;
		case 9:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveRoll, delta);
			return;
		case 10:
		{
			CharacterActorComponent characterActorComponent = this.CharacterActorComponent;
			if (characterActorComponent == null)
			{
				return;
			}
			CharacterKiteComponent component = characterActorComponent.Entity.GetComponent<CharacterKiteComponent>();
			if (component == null)
			{
				return;
			}
			component.KiteMove(delta);
			return;
		}
		case 11:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveRide, delta);
			return;
		case 12:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveRailSlide, delta);
			return;
		case 13:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveSplineClimb, delta);
			break;
		case 14:
			break;
		case 15:
			EventSystem.Instance.EmitWithTarget<float>(this.CharacterActorComponent.Entity, EEventName.CustomMoveFloating, delta);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600235E RID: 9054 RVA: 0x000DA39C File Offset: 0x000D859C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void FightCommand(bool isInAir)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("FightCommand"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseCharacter.__FightCommand_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseCharacter.__FightCommand_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseCharacter.__FightCommand_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->isInAir = isInAir;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0600235F RID: 9055 RVA: 0x000DA412 File Offset: 0x000D8612
	protected void FightCommand_Implementation(bool isInAir)
	{
	}

	// Token: 0x06002360 RID: 9056 RVA: 0x000DA414 File Offset: 0x000D8614
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveDestroyed()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveDestroyed"), out num);
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

	// Token: 0x06002361 RID: 9057 RVA: 0x000DA484 File Offset: 0x000D8684
	protected virtual void ReceiveDestroyed_Implementation()
	{
		if (!ObjectUtils.IsValid(this))
		{
			return;
		}
		this.CharRenderingComponent = null;
		this.NavigationInvoker = null;
		this.InputComponentClass = null;
		this.FightManager = null;
		this.DtHitEffect = null;
		this.DtBaseMovementSetting = null;
		this.DtNewBulletDataMain = null;
		this.DtCharacterPart = null;
		this.WeaponInEffect = null;
		this.WeaponHideEffect = null;
		this.FkData = null;
		this.CharacterData = null;
		this.CharacterActorComponent = null;
		this.DitherEffectControllerInternal = null;
		TsCharacterDebugComponent tsCharacterDebugComponent = this.TsCharacterDebugComponent;
		if (tsCharacterDebugComponent != null)
		{
			tsCharacterDebugComponent.Destroy();
		}
		this.TsCharacterDebugComponent = null;
	}

	// Token: 0x17000560 RID: 1376
	// (get) Token: 0x06002362 RID: 9058 RVA: 0x000DA514 File Offset: 0x000D8714
	[Nullable(1)]
	private Queue<SetMovementModeInfo>[] MovementModeLayer
	{
		[NullableContext(1)]
		get
		{
			if (this.MovementModeLayerInternal == null)
			{
				this.MovementModeLayerInternal = new Queue<SetMovementModeInfo>[]
				{
					new Queue<SetMovementModeInfo>(4),
					new Queue<SetMovementModeInfo>(4),
					new Queue<SetMovementModeInfo>(4),
					new Queue<SetMovementModeInfo>(4)
				};
			}
			return this.MovementModeLayerInternal;
		}
	}

	// Token: 0x17000561 RID: 1377
	// (get) Token: 0x06002363 RID: 9059 RVA: 0x000DA554 File Offset: 0x000D8754
	// (set) Token: 0x06002364 RID: 9060 RVA: 0x000DA55C File Offset: 0x000D875C
	private SetMovementModeInfo CurrentMovementParam { get; set; }

	// Token: 0x06002365 RID: 9061 RVA: 0x000DA568 File Offset: 0x000D8768
	[NullableContext(1)]
	public unsafe void KuroSetMovementMode(SetMovementModeInfo @params)
	{
		if (base.CharacterMovement == null)
		{
			return;
		}
		int num = 0;
		if (this.CharacterActorComponent != null)
		{
			num = this.CharacterActorComponent.Entity.Id;
		}
		else if (this.SimpleNpcActorComponent != null)
		{
			num = this.SimpleNpcActorComponent.Entity.Id;
		}
		if (!this.Mutex)
		{
			this.Mutex = true;
			this.Count++;
			this.CurrentMovementParam = @params;
			TEnumAsByte<EMovementMode> movementMode = base.CharacterMovement.MovementMode;
			byte customMovementMode = base.CharacterMovement.CustomMovementMode;
			if (movementMode != @params.Mode || customMovementMode != @params.CustomMode)
			{
				EMovementMode mode = @params.Mode;
			}
			base.CharacterMovement.SetMovementMode(@params.Mode, @params.CustomMode);
			if (@params.Callback != null)
			{
				try
				{
					@params.Callback();
				}
				catch (Exception ex)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CWZ;
					string message = "[SetMovementMode] 回调执行异常";
					Exception error = ex;
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Error", ex.Message);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Context", @params.Context);
					instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}
			this.Mutex = false;
			int count = this.Count;
			if (count <= 3)
			{
				while (!this.MovementModeLayer[count].Empty)
				{
					SetMovementModeInfo params2 = this.MovementModeLayer[count].Pop();
					this.KuroSetMovementMode(params2);
				}
			}
			this.Count--;
			this.CurrentMovementParam = null;
			return;
		}
		if (this.Count > 3)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "[SetMovementMode] 产生嵌套循环层数过高，不往后执行";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", num);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		int movementModeInfoUid = this.MovementModeInfoUid;
		this.MovementModeInfoUid = movementModeInfoUid + 1;
		@params.Uid = new long?((long)movementModeInfoUid);
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.Character;
		ELogAuthor author3 = ELogAuthor.CWZ;
		string message3 = "[SetMovementMode] 产生嵌套设置，加入队列";
		<>y__InlineArray9<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray9<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("UID", @params.Uid);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Count", this.Count);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("Mode", @params.Mode);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("Context", @params.Context);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("CustomMode", @params.CustomMode);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 6);
		string item = "now Mode";
		SetMovementModeInfo currentMovementParam = this.CurrentMovementParam;
		ptr = new ValueTuple<string, object>(item, (currentMovementParam != null) ? new EMovementMode?(currentMovementParam.Mode) : null);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 7);
		string item2 = "now Context";
		SetMovementModeInfo currentMovementParam2 = this.CurrentMovementParam;
		ptr2 = new ValueTuple<string, object>(item2, (currentMovementParam2 != null) ? currentMovementParam2.Context : null);
		ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 8);
		string item3 = "now CustomMode";
		SetMovementModeInfo currentMovementParam3 = this.CurrentMovementParam;
		ptr3 = new ValueTuple<string, object>(item3, (currentMovementParam3 != null) ? new byte?(currentMovementParam3.CustomMode) : null);
		instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 9));
		this.MovementModeLayer[this.Count].Push(@params);
	}

	// Token: 0x06002366 RID: 9062 RVA: 0x000DA924 File Offset: 0x000D8B24
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBaseCharacter._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Character/TsBaseCharacter.TsBaseCharacter_C");
		}
		return TsBaseCharacter._ClassPtr;
	}

	// Token: 0x06002367 RID: 9063 RVA: 0x000DA948 File Offset: 0x000D8B48
	public TsBaseCharacter() : this(BuiltinUtils.AllocNativeUObject(TsBaseCharacter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002368 RID: 9064 RVA: 0x000DA970 File Offset: 0x000D8B70
	[NullableContext(1)]
	public TsBaseCharacter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseCharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002369 RID: 9065 RVA: 0x000DA9A3 File Offset: 0x000D8BA3
	protected TsBaseCharacter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600236A RID: 9066 RVA: 0x000DA9AC File Offset: 0x000D8BAC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_OnMovementModeChanged_Implementation(ACharacter.__K2_OnMovementModeChanged_FunctionParams* __Params)
	{
		EMovementMode prevMovementMode = __Params->PrevMovementMode;
		EMovementMode newMovementMode = __Params->NewMovementMode;
		this.K2_OnMovementModeChanged_Implementation(prevMovementMode, newMovementMode, __Params->PrevCustomMode, __Params->NewCustomMode);
	}

	// Token: 0x0600236B RID: 9067 RVA: 0x000DA9E5 File Offset: 0x000D8BE5
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_BindGameplayEnableState_Implementation(TsBaseCharacter.__BindGameplayEnableState_FunctionParams* __Params)
	{
		this.BindGameplayEnableState_Implementation(ref __Params->gameplayEnable);
	}

	// Token: 0x0600236C RID: 9068 RVA: 0x000DA9F4 File Offset: 0x000D8BF4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceivePossessed_Implementation(APawn.__ReceivePossessed_FunctionParams* __Params)
	{
		AController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(__Params->NewController);
		this.ReceivePossessed_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0600236D RID: 9069 RVA: 0x000DAA14 File Offset: 0x000D8C14
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveUnpossessed_Implementation(APawn.__ReceiveUnpossessed_FunctionParams* __Params)
	{
		AController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(__Params->OldController);
		this.ReceiveUnpossessed_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0600236E RID: 9070 RVA: 0x000DAA34 File Offset: 0x000D8C34
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetEntityId_Implementation(TsBaseCharacter.__GetEntityId_FunctionParams* __Params)
	{
		__Params->__Result = this.GetEntityId_Implementation();
	}

	// Token: 0x0600236F RID: 9071 RVA: 0x000DAA42 File Offset: 0x000D8C42
	protected virtual void __CPPCALL_Initialize_Implementation()
	{
		this.Initialize_Implementation();
	}

	// Token: 0x06002370 RID: 9072 RVA: 0x000DAA4C File Offset: 0x000D8C4C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetDitherEffect_Implementation(TsBaseCharacter.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		this.SetDitherEffect_Implementation(__Params->dither, ditherType);
	}

	// Token: 0x06002371 RID: 9073 RVA: 0x000DAA6D File Offset: 0x000D8C6D
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_UpdateCustomMovement_Implementation(ACharacter.__K2_UpdateCustomMovement_FunctionParams* __Params)
	{
		this.K2_UpdateCustomMovement_Implementation(__Params->DeltaTime);
	}

	// Token: 0x06002372 RID: 9074 RVA: 0x000DAA7B File Offset: 0x000D8C7B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_FightCommand_Implementation(TsBaseCharacter.__FightCommand_FunctionParams* __Params)
	{
		this.FightCommand_Implementation(__Params->isInAir);
	}

	// Token: 0x06002373 RID: 9075 RVA: 0x000DAA89 File Offset: 0x000D8C89
	protected virtual void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x040017D3 RID: 6099
	public bool OnMovementModeChanged;

	// Token: 0x040017D6 RID: 6102
	public bool? AbpGameplayEnableState;

	// Token: 0x040017D7 RID: 6103
	private CharacterDitherEffectController DitherEffectControllerInternal;

	// Token: 0x040017D8 RID: 6104
	private int MovementModeInfoUid;

	// Token: 0x040017D9 RID: 6105
	private int Count;

	// Token: 0x040017DA RID: 6106
	private bool Mutex;

	// Token: 0x040017DB RID: 6107
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Queue<SetMovementModeInfo>[] MovementModeLayerInternal;

	// Token: 0x040017DD RID: 6109
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Character/TsBaseCharacter.TsBaseCharacter_C";

	// Token: 0x040017DE RID: 6110
	private static IntPtr _ClassPtr;

	// Token: 0x040017DF RID: 6111
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040017E0 RID: 6112
	private static int __PropertyOffset_CharRenderingComponent;

	// Token: 0x040017E1 RID: 6113
	private static int __PropertyOffset_RenderType;

	// Token: 0x040017E2 RID: 6114
	private static int __PropertyOffset_TsCharacterDebugComponent;

	// Token: 0x040017E3 RID: 6115
	private static int __PropertyOffset_NavigationInvoker;

	// Token: 0x040017E4 RID: 6116
	private static int __PropertyOffset_InputComponentClass;

	// Token: 0x040017E5 RID: 6117
	private FSoftClassPath _InputComponentClass;

	// Token: 0x040017E6 RID: 6118
	private static int __PropertyOffset_BasePlatform;

	// Token: 0x040017E7 RID: 6119
	private static int __PropertyOffset_EntityId;

	// Token: 0x040017E8 RID: 6120
	private static int __PropertyOffset_FightManager;

	// Token: 0x040017E9 RID: 6121
	private static int __PropertyOffset_DtHitEffect;

	// Token: 0x040017EA RID: 6122
	private static int __PropertyOffset_DtBaseMovementSetting;

	// Token: 0x040017EB RID: 6123
	private static int __PropertyOffset_DtNewBulletDataMain;

	// Token: 0x040017EC RID: 6124
	private static int __PropertyOffset_DtCharacterPart;

	// Token: 0x040017ED RID: 6125
	private static int __PropertyOffset_DtCameraConfig;

	// Token: 0x040017EE RID: 6126
	private static int __PropertyOffset_BattleSockets;

	// Token: 0x040017EF RID: 6127
	private TArray<FName> _BattleSockets;

	// Token: 0x040017F0 RID: 6128
	private static int __PropertyOffset_NormalSockets;

	// Token: 0x040017F1 RID: 6129
	private TArray<FName> _NormalSockets;

	// Token: 0x040017F2 RID: 6130
	private static int __PropertyOffset_WeaponInEffect;

	// Token: 0x040017F3 RID: 6131
	private static int __PropertyOffset_WeaponHideEffect;

	// Token: 0x040017F4 RID: 6132
	private static int __PropertyOffset_FkData;

	// Token: 0x040017F5 RID: 6133
	private static int __PropertyOffset_CharacterData;

	// Token: 0x040017F6 RID: 6134
	private static int __PropertyOffset_Camp;

	// Token: 0x040017F7 RID: 6135
	private static int __PropertyOffset_PhysicsClothSimulateEnable;

	// Token: 0x040017F8 RID: 6136
	private static int __PropertyOffset_PhysicsClothSimulateDisableOneFrame;

	// Token: 0x040017F9 RID: 6137
	private static int __PropertyOffset_CachePoseEnableOneFrame;

	// Token: 0x040017FA RID: 6138
	private static int __PropertyOffset_CacheTime;

	// Token: 0x040017FB RID: 6139
	private static int __PropertyOffset_DtGameplayAbpConfig;

	// Token: 0x0200743B RID: 29755
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __BindGameplayEnableState_FunctionParams
	{
		// Token: 0x04026818 RID: 157720
		[FieldOffset(0)]
		public bool gameplayEnable;
	}

	// Token: 0x0200743C RID: 29756
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetEntityId_FunctionParams
	{
		// Token: 0x04026819 RID: 157721
		[FieldOffset(0)]
		public int __Result;
	}

	// Token: 0x0200743D RID: 29757
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetDitherEffect_FunctionParams
	{
		// Token: 0x0402681A RID: 157722
		[FieldOffset(0)]
		public float dither;

		// Token: 0x0402681B RID: 157723
		[FieldOffset(4)]
		public byte ditherType;
	}

	// Token: 0x0200743E RID: 29758
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __FightCommand_FunctionParams
	{
		// Token: 0x0402681C RID: 157724
		[FieldOffset(0)]
		public bool isInAir;
	}
}
