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

// Token: 0x02000242 RID: 578
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Character/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Character/TsBaseCharacter.TsBaseCharacter_C")]
public class TsBaseCharacter : ABaseCharacter, IBPI_CreatureInterface_C, IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject, IUnrealUObject
{
	// Token: 0x1700056A RID: 1386
	// (get) Token: 0x060023C8 RID: 9160 RVA: 0x000DFBC4 File Offset: 0x000DDDC4
	// (set) Token: 0x060023C9 RID: 9161 RVA: 0x000DFBD8 File Offset: 0x000DDDD8
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

	// Token: 0x1700056B RID: 1387
	// (get) Token: 0x060023CA RID: 9162 RVA: 0x000DFBED File Offset: 0x000DDDED
	// (set) Token: 0x060023CB RID: 9163 RVA: 0x000DFBFD File Offset: 0x000DDDFD
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

	// Token: 0x1700056C RID: 1388
	// (get) Token: 0x060023CC RID: 9164 RVA: 0x000DFC0E File Offset: 0x000DDE0E
	// (set) Token: 0x060023CD RID: 9165 RVA: 0x000DFC22 File Offset: 0x000DDE22
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

	// Token: 0x1700056D RID: 1389
	// (get) Token: 0x060023CE RID: 9166 RVA: 0x000DFC37 File Offset: 0x000DDE37
	// (set) Token: 0x060023CF RID: 9167 RVA: 0x000DFC4B File Offset: 0x000DDE4B
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

	// Token: 0x1700056E RID: 1390
	// (get) Token: 0x060023D0 RID: 9168 RVA: 0x000DFC60 File Offset: 0x000DDE60
	// (set) Token: 0x060023D1 RID: 9169 RVA: 0x000DFC99 File Offset: 0x000DDE99
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

	// Token: 0x1700056F RID: 1391
	// (get) Token: 0x060023D2 RID: 9170 RVA: 0x000DFCC1 File Offset: 0x000DDEC1
	// (set) Token: 0x060023D3 RID: 9171 RVA: 0x000DFCD5 File Offset: 0x000DDED5
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

	// Token: 0x17000570 RID: 1392
	// (get) Token: 0x060023D4 RID: 9172 RVA: 0x000DFCEA File Offset: 0x000DDEEA
	// (set) Token: 0x060023D5 RID: 9173 RVA: 0x000DFCFA File Offset: 0x000DDEFA
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

	// Token: 0x060023D6 RID: 9174 RVA: 0x000DFD0B File Offset: 0x000DDF0B
	public void SetEntityId(int entityId)
	{
		this.EntityId = entityId;
		base.EntityIdInternal = entityId;
	}

	// Token: 0x060023D7 RID: 9175 RVA: 0x000DFD1C File Offset: 0x000DDF1C
	public void TryAddTsAbilitySystemComponent()
	{
		if (base.AbilitySystemComponent == null)
		{
			base.AbilitySystemComponent = (base.AddComponentByClass(UBaseAbilitySystemComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UBaseAbilitySystemComponent);
		}
	}

	// Token: 0x17000571 RID: 1393
	// (get) Token: 0x060023D8 RID: 9176 RVA: 0x000DFD61 File Offset: 0x000DDF61
	// (set) Token: 0x060023D9 RID: 9177 RVA: 0x000DFD75 File Offset: 0x000DDF75
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

	// Token: 0x17000572 RID: 1394
	// (get) Token: 0x060023DA RID: 9178 RVA: 0x000DFD8A File Offset: 0x000DDF8A
	// (set) Token: 0x060023DB RID: 9179 RVA: 0x000DFD9E File Offset: 0x000DDF9E
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

	// Token: 0x17000573 RID: 1395
	// (get) Token: 0x060023DC RID: 9180 RVA: 0x000DFDB3 File Offset: 0x000DDFB3
	// (set) Token: 0x060023DD RID: 9181 RVA: 0x000DFDC7 File Offset: 0x000DDFC7
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

	// Token: 0x17000574 RID: 1396
	// (get) Token: 0x060023DE RID: 9182 RVA: 0x000DFDDC File Offset: 0x000DDFDC
	// (set) Token: 0x060023DF RID: 9183 RVA: 0x000DFDF0 File Offset: 0x000DDFF0
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

	// Token: 0x17000575 RID: 1397
	// (get) Token: 0x060023E0 RID: 9184 RVA: 0x000DFE05 File Offset: 0x000DE005
	// (set) Token: 0x060023E1 RID: 9185 RVA: 0x000DFE19 File Offset: 0x000DE019
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

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x060023E2 RID: 9186 RVA: 0x000DFE2E File Offset: 0x000DE02E
	// (set) Token: 0x060023E3 RID: 9187 RVA: 0x000DFE42 File Offset: 0x000DE042
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

	// Token: 0x17000577 RID: 1399
	// (get) Token: 0x060023E4 RID: 9188 RVA: 0x000DFE58 File Offset: 0x000DE058
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

	// Token: 0x17000578 RID: 1400
	// (get) Token: 0x060023E5 RID: 9189 RVA: 0x000DFE94 File Offset: 0x000DE094
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

	// Token: 0x17000579 RID: 1401
	// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000DFECD File Offset: 0x000DE0CD
	// (set) Token: 0x060023E7 RID: 9191 RVA: 0x000DFEE1 File Offset: 0x000DE0E1
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

	// Token: 0x1700057A RID: 1402
	// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000DFEF6 File Offset: 0x000DE0F6
	// (set) Token: 0x060023E9 RID: 9193 RVA: 0x000DFF0A File Offset: 0x000DE10A
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

	// Token: 0x1700057B RID: 1403
	// (get) Token: 0x060023EA RID: 9194 RVA: 0x000DFF1F File Offset: 0x000DE11F
	// (set) Token: 0x060023EB RID: 9195 RVA: 0x000DFF33 File Offset: 0x000DE133
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

	// Token: 0x1700057C RID: 1404
	// (get) Token: 0x060023EC RID: 9196 RVA: 0x000DFF48 File Offset: 0x000DE148
	// (set) Token: 0x060023ED RID: 9197 RVA: 0x000DFF5C File Offset: 0x000DE15C
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

	// Token: 0x1700057D RID: 1405
	// (get) Token: 0x060023EE RID: 9198 RVA: 0x000DFF71 File Offset: 0x000DE171
	// (set) Token: 0x060023EF RID: 9199 RVA: 0x000DFF81 File Offset: 0x000DE181
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

	// Token: 0x060023F0 RID: 9200 RVA: 0x000DFF92 File Offset: 0x000DE192
	public void SetCamp(ECamp camp)
	{
		this.Camp = camp;
	}

	// Token: 0x1700057E RID: 1406
	// (get) Token: 0x060023F1 RID: 9201 RVA: 0x000DFF9B File Offset: 0x000DE19B
	// (set) Token: 0x060023F2 RID: 9202 RVA: 0x000DFFAB File Offset: 0x000DE1AB
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

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x060023F3 RID: 9203 RVA: 0x000DFFBC File Offset: 0x000DE1BC
	// (set) Token: 0x060023F4 RID: 9204 RVA: 0x000DFFCC File Offset: 0x000DE1CC
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

	// Token: 0x17000580 RID: 1408
	// (get) Token: 0x060023F5 RID: 9205 RVA: 0x000DFFDD File Offset: 0x000DE1DD
	// (set) Token: 0x060023F6 RID: 9206 RVA: 0x000DFFED File Offset: 0x000DE1ED
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

	// Token: 0x17000581 RID: 1409
	// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000DFFFE File Offset: 0x000DE1FE
	// (set) Token: 0x060023F8 RID: 9208 RVA: 0x000E000E File Offset: 0x000DE20E
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

	// Token: 0x17000582 RID: 1410
	// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000E001F File Offset: 0x000DE21F
	// (set) Token: 0x060023FA RID: 9210 RVA: 0x000E0033 File Offset: 0x000DE233
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

	// Token: 0x17000583 RID: 1411
	// (get) Token: 0x060023FB RID: 9211 RVA: 0x000E0048 File Offset: 0x000DE248
	// (set) Token: 0x060023FC RID: 9212 RVA: 0x000E0050 File Offset: 0x000DE250
	public CharacterActorComponent CharacterActorComponent { get; set; }

	// Token: 0x17000584 RID: 1412
	// (get) Token: 0x060023FD RID: 9213 RVA: 0x000E0059 File Offset: 0x000DE259
	// (set) Token: 0x060023FE RID: 9214 RVA: 0x000E0061 File Offset: 0x000DE261
	public SimpleNpcActorComponent SimpleNpcActorComponent { get; set; }

	// Token: 0x060023FF RID: 9215 RVA: 0x000E006C File Offset: 0x000DE26C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void K2_OnMovementModeChanged(EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseCharacter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_OnMovementModeChanged"), TsBaseCharacter.StaticClass(), out intPtr, out num))
		{
			this.K2_OnMovementModeChanged_Implementation(prevMovementMode, newMovementMode, prevCustomMode, newCustomMode);
			return;
		}
		ACharacter.__K2_OnMovementModeChanged_FunctionParams* ptr = stackalloc ACharacter.__K2_OnMovementModeChanged_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(ACharacter.__K2_OnMovementModeChanged_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->PrevMovementMode) = (byte)prevMovementMode;
		*(byte*)(&ptr->NewMovementMode) = (byte)newMovementMode;
		ptr->PrevCustomMode = prevCustomMode;
		ptr->NewCustomMode = newCustomMode;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002400 RID: 9216 RVA: 0x000E0118 File Offset: 0x000DE318
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

	// Token: 0x06002401 RID: 9217 RVA: 0x000E016C File Offset: 0x000DE36C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void BindGameplayEnableState(ref bool gameplayEnable)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseCharacter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("BindGameplayEnableState"), TsBaseCharacter.StaticClass(), out intPtr, out num))
		{
			this.BindGameplayEnableState_Implementation(ref gameplayEnable);
			return;
		}
		TsBaseCharacter.__BindGameplayEnableState_FunctionParams* ptr = stackalloc TsBaseCharacter.__BindGameplayEnableState_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBaseCharacter.__BindGameplayEnableState_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->gameplayEnable = gameplayEnable;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		gameplayEnable = ptr->gameplayEnable;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x000E0201 File Offset: 0x000DE401
	protected void BindGameplayEnableState_Implementation(ref bool gameplayEnable)
	{
		this.AbpGameplayEnableState = new bool?(gameplayEnable);
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x000E0210 File Offset: 0x000DE410
	public void SetGameplayEnableState(bool enable)
	{
		if (this.AbpGameplayEnableState == null)
		{
			return;
		}
		this.AbpGameplayEnableState = new bool?(enable);
	}

	// Token: 0x06002404 RID: 9220 RVA: 0x000E022C File Offset: 0x000DE42C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceivePossessed(AController newController)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseCharacter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceivePossessed"), TsBaseCharacter.StaticClass(), out intPtr, out num))
		{
			this.ReceivePossessed_Implementation(newController);
			return;
		}
		APawn.__ReceivePossessed_FunctionParams* ptr = stackalloc APawn.__ReceivePossessed_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(APawn.__ReceivePossessed_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->NewController) = ((newController != null) ? newController.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x000E02C6 File Offset: 0x000DE4C6
	protected virtual void ReceivePossessed_Implementation(AController newController)
	{
		if (this.CharacterActorComponent == null || !(newController is BP_CharacterController_C))
		{
			return;
		}
		EventSystem.Instance.EmitWithTarget<Entity, AController>(this.CharacterActorComponent.Entity, EEventName.CharPossessed, this.CharacterActorComponent.Entity, newController);
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x000E0300 File Offset: 0x000DE500
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveUnpossessed(AController oldController)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseCharacter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveUnpossessed"), TsBaseCharacter.StaticClass(), out intPtr, out num))
		{
			this.ReceiveUnpossessed_Implementation(oldController);
			return;
		}
		APawn.__ReceiveUnpossessed_FunctionParams* ptr = stackalloc APawn.__ReceiveUnpossessed_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(APawn.__ReceiveUnpossessed_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OldController) = ((oldController != null) ? oldController.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x000E039A File Offset: 0x000DE59A
	protected virtual void ReceiveUnpossessed_Implementation(AController oldController)
	{
		if (this.CharacterActorComponent == null || !(oldController is BP_CharacterController_C))
		{
			return;
		}
		EventSystem.Instance.EmitWithTarget<Entity, AController>(this.CharacterActorComponent.Entity, EEventName.CharUnpossessed, this.CharacterActorComponent.Entity, oldController);
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x000E03D4 File Offset: 0x000DE5D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual int GetEntityId()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseCharacter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetEntityId"), TsBaseCharacter.StaticClass(), out intPtr, out num))
		{
			return this.GetEntityId_Implementation();
		}
		TsBaseCharacter.__GetEntityId_FunctionParams* ptr = stackalloc TsBaseCharacter.__GetEntityId_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBaseCharacter.__GetEntityId_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		int _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x000E045E File Offset: 0x000DE65E
	protected int GetEntityId_Implementation()
	{
		return ((IBPI_CreatureInterface_C)this).GetEntityId();
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x000E0466 File Offset: 0x000DE666
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

	// Token: 0x0600240B RID: 9227 RVA: 0x000E049B File Offset: 0x000DE69B
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

	// Token: 0x0600240C RID: 9228 RVA: 0x000E04D0 File Offset: 0x000DE6D0
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

	// Token: 0x0600240D RID: 9229 RVA: 0x000E050C File Offset: 0x000DE70C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void Initialize()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBaseCharacter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Initialize"), TsBaseCharacter.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.Initialize_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x000E0565 File Offset: 0x000DE765
	protected void Initialize_Implementation()
	{
	}

	// Token: 0x17000585 RID: 1413
	// (get) Token: 0x0600240F RID: 9231 RVA: 0x000E0568 File Offset: 0x000DE768
	// (set) Token: 0x06002410 RID: 9232 RVA: 0x000E0594 File Offset: 0x000DE794
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

	// Token: 0x17000586 RID: 1414
	// (get) Token: 0x06002411 RID: 9233 RVA: 0x000E059D File Offset: 0x000DE79D
	public bool HasDitherEffectController
	{
		get
		{
			return this.DitherEffectControllerInternal != null;
		}
	}

	// Token: 0x06002412 RID: 9234 RVA: 0x000E05A8 File Offset: 0x000DE7A8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDitherEffect(float dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseCharacter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDitherEffect"), TsBaseCharacter.StaticClass(), out intPtr, out num))
		{
			this.SetDitherEffect_Implementation(dither, ditherType);
			return;
		}
		TsBaseCharacter.__SetDitherEffect_FunctionParams* ptr = stackalloc TsBaseCharacter.__SetDitherEffect_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBaseCharacter.__SetDitherEffect_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->dither = dither;
		*(&ptr->ditherType) = (byte)ditherType;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002413 RID: 9235 RVA: 0x000E063E File Offset: 0x000DE83E
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

	// Token: 0x06002414 RID: 9236 RVA: 0x000E065C File Offset: 0x000DE85C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void K2_UpdateCustomMovement(float delta)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseCharacter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_UpdateCustomMovement"), TsBaseCharacter.StaticClass(), out intPtr, out num))
		{
			this.K2_UpdateCustomMovement_Implementation(delta);
			return;
		}
		ACharacter.__K2_UpdateCustomMovement_FunctionParams* ptr = stackalloc ACharacter.__K2_UpdateCustomMovement_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(ACharacter.__K2_UpdateCustomMovement_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaTime = delta;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002415 RID: 9237 RVA: 0x000E06E8 File Offset: 0x000DE8E8
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

	// Token: 0x06002416 RID: 9238 RVA: 0x000E08E0 File Offset: 0x000DEAE0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void FightCommand(bool isInAir)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseCharacter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("FightCommand"), TsBaseCharacter.StaticClass(), out intPtr, out num))
		{
			this.FightCommand_Implementation(isInAir);
			return;
		}
		TsBaseCharacter.__FightCommand_FunctionParams* ptr = stackalloc TsBaseCharacter.__FightCommand_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBaseCharacter.__FightCommand_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->isInAir = isInAir;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x000E096C File Offset: 0x000DEB6C
	protected void FightCommand_Implementation(bool isInAir)
	{
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x000E0970 File Offset: 0x000DEB70
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveDestroyed()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBaseCharacter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveDestroyed"), TsBaseCharacter.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveDestroyed_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x000E09CC File Offset: 0x000DEBCC
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

	// Token: 0x17000587 RID: 1415
	// (get) Token: 0x0600241A RID: 9242 RVA: 0x000E0A5C File Offset: 0x000DEC5C
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

	// Token: 0x17000588 RID: 1416
	// (get) Token: 0x0600241B RID: 9243 RVA: 0x000E0A9C File Offset: 0x000DEC9C
	// (set) Token: 0x0600241C RID: 9244 RVA: 0x000E0AA4 File Offset: 0x000DECA4
	private SetMovementModeInfo CurrentMovementParam { get; set; }

	// Token: 0x0600241D RID: 9245 RVA: 0x000E0AB0 File Offset: 0x000DECB0
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

	// Token: 0x0600241E RID: 9246 RVA: 0x000E0E6C File Offset: 0x000DF06C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBaseCharacter._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Character/TsBaseCharacter.TsBaseCharacter_C");
		}
		return TsBaseCharacter._ClassPtr;
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x000E0E90 File Offset: 0x000DF090
	public TsBaseCharacter() : this(BuiltinUtils.AllocNativeUObject(TsBaseCharacter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x000E0EB8 File Offset: 0x000DF0B8
	[NullableContext(1)]
	public TsBaseCharacter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseCharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x000E0EEB File Offset: 0x000DF0EB
	protected TsBaseCharacter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x000E0EF4 File Offset: 0x000DF0F4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_OnMovementModeChanged_Implementation(ACharacter.__K2_OnMovementModeChanged_FunctionParams* __Params)
	{
		EMovementMode prevMovementMode = __Params->PrevMovementMode;
		EMovementMode newMovementMode = __Params->NewMovementMode;
		this.K2_OnMovementModeChanged_Implementation(prevMovementMode, newMovementMode, __Params->PrevCustomMode, __Params->NewCustomMode);
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x000E0F2D File Offset: 0x000DF12D
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_BindGameplayEnableState_Implementation(TsBaseCharacter.__BindGameplayEnableState_FunctionParams* __Params)
	{
		this.BindGameplayEnableState_Implementation(ref __Params->gameplayEnable);
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x000E0F3C File Offset: 0x000DF13C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceivePossessed_Implementation(APawn.__ReceivePossessed_FunctionParams* __Params)
	{
		AController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(__Params->NewController);
		this.ReceivePossessed_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x000E0F5C File Offset: 0x000DF15C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveUnpossessed_Implementation(APawn.__ReceiveUnpossessed_FunctionParams* __Params)
	{
		AController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(__Params->OldController);
		this.ReceiveUnpossessed_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x000E0F7C File Offset: 0x000DF17C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetEntityId_Implementation(TsBaseCharacter.__GetEntityId_FunctionParams* __Params)
	{
		__Params->__Result = this.GetEntityId_Implementation();
	}

	// Token: 0x06002427 RID: 9255 RVA: 0x000E0F8A File Offset: 0x000DF18A
	protected virtual void __CPPCALL_Initialize_Implementation()
	{
		this.Initialize_Implementation();
	}

	// Token: 0x06002428 RID: 9256 RVA: 0x000E0F94 File Offset: 0x000DF194
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetDitherEffect_Implementation(TsBaseCharacter.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		this.SetDitherEffect_Implementation(__Params->dither, ditherType);
	}

	// Token: 0x06002429 RID: 9257 RVA: 0x000E0FB5 File Offset: 0x000DF1B5
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_UpdateCustomMovement_Implementation(ACharacter.__K2_UpdateCustomMovement_FunctionParams* __Params)
	{
		this.K2_UpdateCustomMovement_Implementation(__Params->DeltaTime);
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x000E0FC3 File Offset: 0x000DF1C3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_FightCommand_Implementation(TsBaseCharacter.__FightCommand_FunctionParams* __Params)
	{
		this.FightCommand_Implementation(__Params->isInAir);
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x000E0FD1 File Offset: 0x000DF1D1
	protected virtual void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x04001817 RID: 6167
	public bool OnMovementModeChanged;

	// Token: 0x0400181A RID: 6170
	public bool? AbpGameplayEnableState;

	// Token: 0x0400181B RID: 6171
	private CharacterDitherEffectController DitherEffectControllerInternal;

	// Token: 0x0400181C RID: 6172
	private int MovementModeInfoUid;

	// Token: 0x0400181D RID: 6173
	private int Count;

	// Token: 0x0400181E RID: 6174
	private bool Mutex;

	// Token: 0x0400181F RID: 6175
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Queue<SetMovementModeInfo>[] MovementModeLayerInternal;

	// Token: 0x04001821 RID: 6177
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Character/TsBaseCharacter.TsBaseCharacter_C";

	// Token: 0x04001822 RID: 6178
	private static IntPtr _ClassPtr;

	// Token: 0x04001823 RID: 6179
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001824 RID: 6180
	private static int __PropertyOffset_CharRenderingComponent;

	// Token: 0x04001825 RID: 6181
	private static int __PropertyOffset_RenderType;

	// Token: 0x04001826 RID: 6182
	private static int __PropertyOffset_TsCharacterDebugComponent;

	// Token: 0x04001827 RID: 6183
	private static int __PropertyOffset_NavigationInvoker;

	// Token: 0x04001828 RID: 6184
	private static int __PropertyOffset_InputComponentClass;

	// Token: 0x04001829 RID: 6185
	private FSoftClassPath _InputComponentClass;

	// Token: 0x0400182A RID: 6186
	private static int __PropertyOffset_BasePlatform;

	// Token: 0x0400182B RID: 6187
	private static int __PropertyOffset_EntityId;

	// Token: 0x0400182C RID: 6188
	private static int __PropertyOffset_FightManager;

	// Token: 0x0400182D RID: 6189
	private static int __PropertyOffset_DtHitEffect;

	// Token: 0x0400182E RID: 6190
	private static int __PropertyOffset_DtBaseMovementSetting;

	// Token: 0x0400182F RID: 6191
	private static int __PropertyOffset_DtNewBulletDataMain;

	// Token: 0x04001830 RID: 6192
	private static int __PropertyOffset_DtCharacterPart;

	// Token: 0x04001831 RID: 6193
	private static int __PropertyOffset_DtCameraConfig;

	// Token: 0x04001832 RID: 6194
	private static int __PropertyOffset_BattleSockets;

	// Token: 0x04001833 RID: 6195
	private TArray<FName> _BattleSockets;

	// Token: 0x04001834 RID: 6196
	private static int __PropertyOffset_NormalSockets;

	// Token: 0x04001835 RID: 6197
	private TArray<FName> _NormalSockets;

	// Token: 0x04001836 RID: 6198
	private static int __PropertyOffset_WeaponInEffect;

	// Token: 0x04001837 RID: 6199
	private static int __PropertyOffset_WeaponHideEffect;

	// Token: 0x04001838 RID: 6200
	private static int __PropertyOffset_FkData;

	// Token: 0x04001839 RID: 6201
	private static int __PropertyOffset_CharacterData;

	// Token: 0x0400183A RID: 6202
	private static int __PropertyOffset_Camp;

	// Token: 0x0400183B RID: 6203
	private static int __PropertyOffset_PhysicsClothSimulateEnable;

	// Token: 0x0400183C RID: 6204
	private static int __PropertyOffset_PhysicsClothSimulateDisableOneFrame;

	// Token: 0x0400183D RID: 6205
	private static int __PropertyOffset_CachePoseEnableOneFrame;

	// Token: 0x0400183E RID: 6206
	private static int __PropertyOffset_CacheTime;

	// Token: 0x0400183F RID: 6207
	private static int __PropertyOffset_DtGameplayAbpConfig;

	// Token: 0x020065CC RID: 26060
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __BindGameplayEnableState_FunctionParams
	{
		// Token: 0x04021B56 RID: 138070
		[FieldOffset(0)]
		public bool gameplayEnable;
	}

	// Token: 0x020065CD RID: 26061
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetEntityId_FunctionParams
	{
		// Token: 0x04021B57 RID: 138071
		[FieldOffset(0)]
		public int __Result;
	}

	// Token: 0x020065CE RID: 26062
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetDitherEffect_FunctionParams
	{
		// Token: 0x04021B58 RID: 138072
		[FieldOffset(0)]
		public float dither;

		// Token: 0x04021B59 RID: 138073
		[FieldOffset(4)]
		public byte ditherType;
	}

	// Token: 0x020065CF RID: 26063
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __FightCommand_FunctionParams
	{
		// Token: 0x04021B5A RID: 138074
		[FieldOffset(0)]
		public bool isInAir;
	}
}
