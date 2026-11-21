using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020027CC RID: 10188
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/TsSimpleNpc.TsSimpleNpc_C")]
public class TsSimpleNpc : AKuroEffectActor, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06019904 RID: 104708 RVA: 0x007DA4CE File Offset: 0x007D86CE
	static TsSimpleNpc()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsSimpleNpc.CreateStaticDefaultValue), new Action(TsSimpleNpc.ResetStaticDefaultValue));
	}

	// Token: 0x170028CC RID: 10444
	// (get) Token: 0x06019905 RID: 104709 RVA: 0x007DA4ED File Offset: 0x007D86ED
	// (set) Token: 0x06019906 RID: 104710 RVA: 0x007DA501 File Offset: 0x007D8701
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCapsuleComponent CapsuleCollision
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsSimpleNpc.__PropertyOffset_CapsuleCollision);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsSimpleNpc.__PropertyOffset_CapsuleCollision, value);
		}
	}

	// Token: 0x170028CD RID: 10445
	// (get) Token: 0x06019907 RID: 104711 RVA: 0x007DA516 File Offset: 0x007D8716
	// (set) Token: 0x06019908 RID: 104712 RVA: 0x007DA52A File Offset: 0x007D872A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe USkeletalMeshComponent Mesh
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsSimpleNpc.__PropertyOffset_Mesh);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsSimpleNpc.__PropertyOffset_Mesh, value);
		}
	}

	// Token: 0x170028CE RID: 10446
	// (get) Token: 0x06019909 RID: 104713 RVA: 0x007DA53F File Offset: 0x007D873F
	// (set) Token: 0x0601990A RID: 104714 RVA: 0x007DA553 File Offset: 0x007D8753
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe CharRenderingComponent CharRenderingComponent
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<CharRenderingComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsSimpleNpc.__PropertyOffset_CharRenderingComponent);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsSimpleNpc.__PropertyOffset_CharRenderingComponent, value);
		}
	}

	// Token: 0x170028CF RID: 10447
	// (get) Token: 0x0601990B RID: 104715 RVA: 0x007DA568 File Offset: 0x007D8768
	// (set) Token: 0x0601990C RID: 104716 RVA: 0x007DA5A1 File Offset: 0x007D87A1
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public FSoftObjectPath DA
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			FSoftObjectPath result;
			if ((result = this._DA) == null)
			{
				result = (this._DA = new FSoftObjectPath(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DA, this));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DA, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170028D0 RID: 10448
	// (get) Token: 0x0601990D RID: 104717 RVA: 0x007DA5C9 File Offset: 0x007D87C9
	// (set) Token: 0x0601990E RID: 104718 RVA: 0x007DA5D9 File Offset: 0x007D87D9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DisappearOnSunny
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DisappearOnSunny) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DisappearOnSunny) = (value ? 1 : 0);
		}
	}

	// Token: 0x170028D1 RID: 10449
	// (get) Token: 0x0601990F RID: 104719 RVA: 0x007DA5EA File Offset: 0x007D87EA
	// (set) Token: 0x06019910 RID: 104720 RVA: 0x007DA5FA File Offset: 0x007D87FA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DisappearOnCloudy
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DisappearOnCloudy) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DisappearOnCloudy) = (value ? 1 : 0);
		}
	}

	// Token: 0x170028D2 RID: 10450
	// (get) Token: 0x06019911 RID: 104721 RVA: 0x007DA60B File Offset: 0x007D880B
	// (set) Token: 0x06019912 RID: 104722 RVA: 0x007DA61B File Offset: 0x007D881B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DisappearOnRainy
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DisappearOnRainy) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DisappearOnRainy) = (value ? 1 : 0);
		}
	}

	// Token: 0x170028D3 RID: 10451
	// (get) Token: 0x06019913 RID: 104723 RVA: 0x007DA62C File Offset: 0x007D882C
	// (set) Token: 0x06019914 RID: 104724 RVA: 0x007DA63C File Offset: 0x007D883C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DisappearOnThunderRain
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DisappearOnThunderRain) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DisappearOnThunderRain) = (value ? 1 : 0);
		}
	}

	// Token: 0x170028D4 RID: 10452
	// (get) Token: 0x06019915 RID: 104725 RVA: 0x007DA64D File Offset: 0x007D884D
	// (set) Token: 0x06019916 RID: 104726 RVA: 0x007DA65D File Offset: 0x007D885D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DisappearOnSnowy
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DisappearOnSnowy) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DisappearOnSnowy) = (value ? 1 : 0);
		}
	}

	// Token: 0x170028D5 RID: 10453
	// (get) Token: 0x06019917 RID: 104727 RVA: 0x007DA66E File Offset: 0x007D886E
	// (set) Token: 0x06019918 RID: 104728 RVA: 0x007DA67E File Offset: 0x007D887E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int LodLevel
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_LodLevel);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_LodLevel) = value;
		}
	}

	// Token: 0x170028D6 RID: 10454
	// (get) Token: 0x06019919 RID: 104729 RVA: 0x007DA68F File Offset: 0x007D888F
	// (set) Token: 0x0601991A RID: 104730 RVA: 0x007DA69F File Offset: 0x007D889F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DebugDitherValue
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DebugDitherValue);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleNpc.__PropertyOffset_DebugDitherValue) = value;
		}
	}

	// Token: 0x170028D7 RID: 10455
	// (get) Token: 0x0601991B RID: 104731 RVA: 0x007DA6B0 File Offset: 0x007D88B0
	[Nullable(1)]
	public CharacterDitherEffectController DitherEffectController
	{
		[NullableContext(1)]
		get
		{
			if (this.DitherEffectControllerInternal == null)
			{
				this.DitherEffectControllerInternal = new CharacterDitherEffectController(this, this.CharRenderingComponent);
			}
			return this.DitherEffectControllerInternal;
		}
	}

	// Token: 0x0601991C RID: 104732 RVA: 0x007DA6D4 File Offset: 0x007D88D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void EditorInit()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("EditorInit"), TsSimpleNpc.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.EditorInit_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601991D RID: 104733 RVA: 0x007DA730 File Offset: 0x007D8930
	protected virtual void EditorInit_Implementation()
	{
		base.bEditorTickBySelected = true;
		this.CachedLocation = Vector.Create();
		this.TempLocation = Vector.Create();
		Vector cachedLocation = this.CachedLocation;
		FVectorDouble fvectorDouble = base.D_K2_GetActorLocation();
		cachedLocation.FromUeVector(fvectorDouble);
		if (this.Mesh != null)
		{
			this.TempAnimInstance = this.Mesh.AnimScriptInstance;
			this.TempAnimAsset = this.Mesh.AnimationData.AnimToPlay;
		}
		this.TempDaPath = this.DA.AssetPathName.ToString();
		this.LoadModel();
		if (!base.Tags.Contains(CharacterNameDefines.Instance.PFT_NO_SPAWN))
		{
			base.Tags.Add(CharacterNameDefines.Instance.PFT_NO_SPAWN);
		}
		base.bSetActorComponentTickEnabledByFocus = true;
		base.EditorSetActorComponentsTickEnabled(false);
	}

	// Token: 0x0601991E RID: 104734 RVA: 0x007DA7FC File Offset: 0x007D89FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void EditorTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("EditorTick"), TsSimpleNpc.StaticClass(), out intPtr, out num))
		{
			this.EditorTick_Implementation(deltaSeconds);
			return;
		}
		AKuroEffectActor.__EditorTick_FunctionParams* ptr = stackalloc AKuroEffectActor.__EditorTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AKuroEffectActor.__EditorTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601991F RID: 104735 RVA: 0x007DA888 File Offset: 0x007D8A88
	protected virtual void EditorTick_Implementation(float deltaSeconds)
	{
		if (this.TempLocation == null)
		{
			this.EditorInit();
			return;
		}
		Vector tempLocation = this.TempLocation;
		FVectorDouble fvectorDouble = base.D_K2_GetActorLocation();
		tempLocation.FromUeVector(fvectorDouble);
		if (Vector.DistSquared(this.CachedLocation, this.TempLocation) > 900.0)
		{
			this.CachedLocation.DeepCopy(this.TempLocation);
			this.IsDirty = true;
			return;
		}
		if (this.Mesh != null)
		{
			if (this.Mesh.AnimationMode == EAnimationMode.AnimationBlueprint)
			{
				this.TempAnimAsset = null;
				if (this.Mesh.AnimScriptInstance != this.TempAnimInstance)
				{
					this.TempAnimInstance = this.Mesh.AnimScriptInstance;
					this.IsDirty = true;
					return;
				}
			}
			else if (this.Mesh.AnimationMode == EAnimationMode.AnimationSingleNode)
			{
				this.TempAnimInstance = null;
				if (this.Mesh.AnimationData.AnimToPlay != this.TempAnimAsset)
				{
					this.TempAnimAsset = this.Mesh.AnimationData.AnimToPlay;
					this.IsDirty = true;
					return;
				}
			}
		}
		if (this.TempDaPath != this.DA.AssetPathName.ToString())
		{
			this.TempDaPath = this.DA.AssetPathName.ToString();
			this.IsDirty = true;
			return;
		}
		if (this.IsDirty)
		{
			this.IsDirty = false;
			this.LoadModel();
			UKuroStaticLibrary.SetActorModify(this);
			return;
		}
		if (this.NeedResetCollision)
		{
			this.NeedResetCollision = false;
			this.SetDefaultCollision();
			this.ResetMeshLocation();
		}
	}

	// Token: 0x06019920 RID: 104736 RVA: 0x007DAA1C File Offset: 0x007D8C1C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsSimpleNpc.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019921 RID: 104737 RVA: 0x007DAA75 File Offset: 0x007D8C75
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.InitData();
	}

	// Token: 0x06019922 RID: 104738 RVA: 0x007DAA80 File Offset: 0x007D8C80
	public void InitData()
	{
		this.FindComponents();
		this.InitCollisionInfo();
		this.InitBaseInfo();
		this.InitRenderInfo();
		this.InitDaInfo();
		this.SetTickEnabled(false);
		this.SetMainShadowEnabled(false);
		SimpleNpcController.Instance.Add(this);
		base.Tags.Add(CharacterNameDefines.Instance.NO_SLIDE);
	}

	// Token: 0x06019923 RID: 104739 RVA: 0x007DAADC File Offset: 0x007D8CDC
	private void InitCollisionInfo()
	{
		this.CapsuleCollision.bCanCharacterStandOn = false;
		this.CapsuleCollision.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
		this.CapsuleCollision.SetCollisionObjectType(ECollisionChannel.ECC_WorldStatic);
		this.CapsuleCollision.SetCollisionResponseToAllChannels(ECollisionResponse.ECR_Ignore);
		CollisionUtils.Instance.SetCollisionResponseToPawn(this.CapsuleCollision, EPawnChannel.All, ECollisionResponse.ECR_Block);
	}

	// Token: 0x06019924 RID: 104740 RVA: 0x007DAB30 File Offset: 0x007D8D30
	private void InitBaseInfo()
	{
		this.FlowLogic = new SimpleNpcFlowLogic(this);
		this.StartLocation = new FVectorDouble?(base.D_K2_GetActorLocation());
		this.StartLocationProxy = Vector.Create(this.StartLocation);
		this.IsInLogicRangeInternal = new bool?(false);
		this.RegisterLoopTimerId = null;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter != null)
		{
			Vector actorLocationProxy = baseCharacter.CharacterActorComponent.ActorLocationProxy;
			this.TempDistanceSquared = Vector.DistSquared(this.StartLocationProxy, actorLocationProxy);
		}
		this.InstanceId = ++TsSimpleNpc.InstanceCount;
		if (GlobalData.IsPlayInEditor)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "创建SimpleNpc";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.InstanceId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06019925 RID: 104741 RVA: 0x007DABF5 File Offset: 0x007D8DF5
	private void InitRenderInfo()
	{
		this.CharRenderingComponent.Init(ECharacterRenderingType.Npc);
		base.SetPrimitiveEntityType(2U);
		this.SetAnimUROParams();
	}

	// Token: 0x06019926 RID: 104742 RVA: 0x007DAC10 File Offset: 0x007D8E10
	private void InitDaInfo()
	{
		if (ObjectUtils.SoftObjectPathIsValid(this.DA))
		{
			this.IsNotUnload = true;
			this.IsModelLoadedInternal = false;
			return;
		}
		this.IsModelLoadedInternal = true;
		if (!GlobalData.IsPlayInEditor)
		{
			this.CacheComponents();
			this.CloseSkeletalMeshShadow();
		}
		this.CharRenderingComponent.UpdateNpcDitherComponent();
		SimpleNpcController.Instance.CheckNpcShowState(this, true, true);
	}

	// Token: 0x06019927 RID: 104743 RVA: 0x007DAC6C File Offset: 0x007D8E6C
	[NullableContext(0)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ReceiveEndPlay(TEnumAsByte<EEndPlayReason> endPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsSimpleNpc.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(endPlayReason);
			return;
		}
		TsSimpleNpc.__ReceiveEndPlay_FunctionParams* ptr = stackalloc TsSimpleNpc.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsSimpleNpc.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->endPlayReason = endPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019928 RID: 104744 RVA: 0x007DACF8 File Offset: 0x007D8EF8
	[NullableContext(0)]
	protected unsafe void ReceiveEndPlay_Implementation(TEnumAsByte<EEndPlayReason> endPlayReason)
	{
		SimpleNpcController.Instance.Remove(this);
		if (this.RegisterLoopTimerId != null)
		{
			TimerSystem.Instance.Remove(this.RegisterLoopTimerId);
			this.RegisterLoopTimerId = null;
		}
		if (this.FlowLogic != null)
		{
			this.FlowLogic.Dispose();
			this.FlowLogic = null;
		}
		this.DA = null;
		this.DitherEffectControllerInternal = null;
		this.CachedComponents = null;
		if (GlobalData.IsPlayInEditor)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "销毁SimpleNpc";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.InstanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DeleteCount", ++TsSimpleNpc.DeleteCount);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x06019929 RID: 104745 RVA: 0x007DADD4 File Offset: 0x007D8FD4
	private void FindComponents()
	{
		if (this.CapsuleCollision == null || !this.CapsuleCollision.IsValid())
		{
			this.CapsuleCollision = (base.GetComponentByClass(UCapsuleComponent.StaticClass()) as UCapsuleComponent);
		}
		if (this.Mesh == null || !this.Mesh.IsValid())
		{
			this.Mesh = (base.GetComponentByClass(USkeletalMeshComponent.StaticClass()) as USkeletalMeshComponent);
		}
		if (this.CharRenderingComponent == null || !this.CharRenderingComponent.IsValid())
		{
			this.CharRenderingComponent = (base.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
		}
	}

	// Token: 0x0601992A RID: 104746 RVA: 0x007DAE74 File Offset: 0x007D9074
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void LoadModel()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("LoadModel"), TsSimpleNpc.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.LoadModel_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601992B RID: 104747 RVA: 0x007DAECD File Offset: 0x007D90CD
	protected void LoadModel_Implementation()
	{
		this.FindComponents();
		this.IsNotUnload = true;
		this.LoadModelByDA();
	}

	// Token: 0x0601992C RID: 104748 RVA: 0x007DAEE4 File Offset: 0x007D90E4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void DebugSetNpcDitherValue(float value)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("DebugSetNpcDitherValue"), TsSimpleNpc.StaticClass(), out intPtr, out num))
		{
			this.DebugSetNpcDitherValue_Implementation(value);
			return;
		}
		TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams* ptr = stackalloc TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->value = value;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601992D RID: 104749 RVA: 0x007DAF70 File Offset: 0x007D9170
	protected void DebugSetNpcDitherValue_Implementation(float value)
	{
		this.SetDitherEffect(value, ECharacterDitherType.Fight);
	}

	// Token: 0x0601992E RID: 104750 RVA: 0x007DAF7C File Offset: 0x007D917C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void SetDefaultCollision()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDefaultCollision"), TsSimpleNpc.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.SetDefaultCollision_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601992F RID: 104751 RVA: 0x007DAFD8 File Offset: 0x007D91D8
	protected void SetDefaultCollision_Implementation()
	{
		USkeletalMeshComponent mesh = this.Mesh;
		if (((mesh != null) ? mesh.SkeletalMesh : null) != null)
		{
			FBoxSphereBounds bounds = this.Mesh.SkeletalMesh.GetBounds();
			this.CapsuleCollision.CapsuleHalfHeight = bounds.BoxExtent.GetMax();
			this.CapsuleCollision.CapsuleRadius = 25f;
			return;
		}
		this.CapsuleCollision.CapsuleHalfHeight = 85f;
		this.CapsuleCollision.CapsuleRadius = 25f;
	}

	// Token: 0x06019930 RID: 104752 RVA: 0x007DB054 File Offset: 0x007D9254
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ResetMeshLocation()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ResetMeshLocation"), TsSimpleNpc.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ResetMeshLocation_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019931 RID: 104753 RVA: 0x007DB0B0 File Offset: 0x007D92B0
	protected void ResetMeshLocation_Implementation()
	{
		FHitResult fhitResult = new FHitResult();
		USceneComponent mesh = this.Mesh;
		FRotator frotator = new FRotator(0f, -90f, 0f);
		FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, (double)(-(double)this.CapsuleCollision.CapsuleHalfHeight));
		FVector fvector = Vector.OneVectorDouble;
		FTransformDouble ftransformDouble = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
		mesh.D_K2_SetRelativeTransform(ftransformDouble, false, ref fhitResult, false);
	}

	// Token: 0x06019932 RID: 104754 RVA: 0x007DB128 File Offset: 0x007D9328
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void FindFloor()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("FindFloor"), TsSimpleNpc.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.FindFloor_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019933 RID: 104755 RVA: 0x007DB184 File Offset: 0x007D9384
	protected void FindFloor_Implementation()
	{
		this.FindComponents();
		float scaledCapsuleHalfHeight = this.CapsuleCollision.GetScaledCapsuleHalfHeight();
		float scaledCapsuleRadius = this.CapsuleCollision.GetScaledCapsuleRadius();
		FVectorDouble fvectorDouble = base.D_K2_GetActorLocation();
		FVector fvector = new FVector((float)fvectorDouble.X, (float)fvectorDouble.Y, (float)fvectorDouble.Z - 500f - (scaledCapsuleHalfHeight - scaledCapsuleRadius));
		if (TsSimpleNpc.SphereTrace == null)
		{
			TsSimpleNpc.SphereTrace = new UTraceSphereElement();
			TsSimpleNpc.SphereTrace.bIsSingle = true;
			TsSimpleNpc.SphereTrace.bIgnoreSelf = true;
			TsSimpleNpc.SphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		}
		UTraceSphereElement sphereTrace = TsSimpleNpc.SphereTrace;
		sphereTrace.WorldContextObject = this;
		sphereTrace.Radius = scaledCapsuleRadius;
		TraceElementCommon.Instance.SetStartLocation(sphereTrace, fvectorDouble);
		TraceElementCommon.Instance.SetEndLocation(sphereTrace, fvector);
		bool flag = TraceElementCommon.Instance.SphereTrace(sphereTrace, "SimpleNpc_FindFloor");
		UKuroHitResult hitResult = sphereTrace.HitResult;
		if (flag && hitResult.bBlockingHit)
		{
			FVectorDouble fvectorDouble2 = new FVectorDouble();
			TraceElementCommon.Instance.GetHitLocation(hitResult, 0, fvectorDouble2);
			fvectorDouble2.Z += (double)(scaledCapsuleHalfHeight - scaledCapsuleRadius);
			FHitResult fhitResult = new FHitResult();
			base.D_K2_SetActorLocation(fvectorDouble2, false, ref fhitResult, false);
		}
	}

	// Token: 0x06019934 RID: 104756 RVA: 0x007DB2B0 File Offset: 0x007D94B0
	public bool LoadModelByDA()
	{
		if (this.CapsuleCollision == null || this.Mesh == null)
		{
			return false;
		}
		if (!ObjectUtils.SoftObjectPathIsValid(this.DA))
		{
			return false;
		}
		string text = this.DA.AssetPathName.ToString();
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		ResourceSystem.Instance.LoadAsync<PD_NpcSetupData_C>(text, delegate([Nullable(2)] PD_NpcSetupData_C daConfig, string _)
		{
			if (this.IsNotUnload)
			{
				this.HandleLoadedDaConfig(daConfig, false);
			}
			this.SetTickEnabled(this.IsInLogicRangeInternal.Value);
			this.SetMainShadowEnabled(this.IsInLogicRangeInternal.Value);
		}, 100, "js_undefined");
		return true;
	}

	// Token: 0x06019935 RID: 104757 RVA: 0x007DB324 File Offset: 0x007D9524
	private void HandleLoadedDaConfig(PD_NpcSetupData_C daConfig, bool isEditor = false)
	{
		if (daConfig == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CJH, "[TsSimpleNpc.HandleLoadedDaConfig] DA资源类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.CapsuleCollision == null || this.Mesh == null)
		{
			return;
		}
		CombineMeshTool.LoadDaConfig(this, this.CapsuleCollision.GetRelativeTransform(), this.Mesh, daConfig);
		if (!isEditor)
		{
			this.CharRenderingComponent.UpdateNpcDitherComponent();
			SimpleNpcController.Instance.CheckNpcShowState(this, true, true);
		}
		if (!GlobalData.IsPlayInEditor)
		{
			this.CacheComponents();
			this.CloseSkeletalMeshShadow();
		}
		this.NeedResetCollision = true;
	}

	// Token: 0x06019936 RID: 104758 RVA: 0x007DB3AF File Offset: 0x007D95AF
	public void StartFlowLogic()
	{
		if (this.FlowLogic == null)
		{
			return;
		}
		this.FlowLogic.StartFlowLogic();
	}

	// Token: 0x06019937 RID: 104759 RVA: 0x007DB3C5 File Offset: 0x007D95C5
	public void SetDitherEffect(float dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
	{
		this.DitherEffectController.SetDitherEffect((double)dither, ditherType, true);
	}

	// Token: 0x06019938 RID: 104760 RVA: 0x007DB3D8 File Offset: 0x007D95D8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ShowDialog(string text, float removeSeconds = -1f)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ShowDialog"), TsSimpleNpc.StaticClass(), out intPtr, out num))
		{
			this.ShowDialog_Implementation(text, removeSeconds);
			return;
		}
		TsSimpleNpc.__ShowDialog_FunctionParams* ptr = stackalloc TsSimpleNpc.__ShowDialog_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsSimpleNpc.__ShowDialog_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->text), text);
		ptr->removeSeconds = removeSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019939 RID: 104761 RVA: 0x007DB474 File Offset: 0x007D9674
	[NullableContext(1)]
	protected void ShowDialog_Implementation(string text, float removeSeconds = -1f)
	{
		if (this.FlowLogic == null)
		{
			return;
		}
		this.FlowLogic.AddHeadView().ContinueWith(delegate()
		{
			this.FlowLogic.ShowDialog(text, removeSeconds);
		}).Forget();
	}

	// Token: 0x0601993A RID: 104762 RVA: 0x007DB4C8 File Offset: 0x007D96C8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void HideDialog()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("HideDialog"), TsSimpleNpc.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.HideDialog_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601993B RID: 104763 RVA: 0x007DB521 File Offset: 0x007D9721
	protected void HideDialog_Implementation()
	{
		if (this.FlowLogic == null)
		{
			return;
		}
		this.FlowLogic.HideDialog();
	}

	// Token: 0x0601993C RID: 104764 RVA: 0x007DB538 File Offset: 0x007D9738
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool TryPlayMontage(string montagePath)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("TryPlayMontage"), TsSimpleNpc.StaticClass(), out intPtr, out num))
		{
			return this.TryPlayMontage_Implementation(montagePath);
		}
		TsSimpleNpc.__TryPlayMontage_FunctionParams* ptr = stackalloc TsSimpleNpc.__TryPlayMontage_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsSimpleNpc.__TryPlayMontage_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->montagePath), montagePath);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601993D RID: 104765 RVA: 0x007DB5D0 File Offset: 0x007D97D0
	[NullableContext(1)]
	protected bool TryPlayMontage_Implementation(string montagePath)
	{
		return this.FlowLogic != null && this.FlowLogic.TryPlayMontage(montagePath);
	}

	// Token: 0x0601993E RID: 104766 RVA: 0x007DB5E8 File Offset: 0x007D97E8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void StopMontage()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsSimpleNpc) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("StopMontage"), TsSimpleNpc.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.StopMontage_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601993F RID: 104767 RVA: 0x007DB641 File Offset: 0x007D9841
	protected void StopMontage_Implementation()
	{
		if (this.FlowLogic == null)
		{
			return;
		}
		this.FlowLogic.StopMontage();
	}

	// Token: 0x06019940 RID: 104768 RVA: 0x007DB657 File Offset: 0x007D9857
	public void FilterFlowWorldState()
	{
		SimpleNpcFlowLogic flowLogic = this.FlowLogic;
		if (flowLogic == null)
		{
			return;
		}
		flowLogic.FilterFlowWorldState();
	}

	// Token: 0x170028D8 RID: 10456
	// (get) Token: 0x06019941 RID: 104769 RVA: 0x007DB669 File Offset: 0x007D9869
	public bool IsHiding
	{
		get
		{
			return !this.IsNotUnload;
		}
	}

	// Token: 0x170028D9 RID: 10457
	// (get) Token: 0x06019942 RID: 104770 RVA: 0x007DB674 File Offset: 0x007D9874
	public FVectorDouble SelfLocation
	{
		get
		{
			return this.StartLocation.Value;
		}
	}

	// Token: 0x170028DA RID: 10458
	// (get) Token: 0x06019943 RID: 104771 RVA: 0x007DB681 File Offset: 0x007D9881
	[Nullable(1)]
	public Vector SelfLocationProxy
	{
		[NullableContext(1)]
		get
		{
			return this.StartLocationProxy;
		}
	}

	// Token: 0x170028DB RID: 10459
	// (get) Token: 0x06019944 RID: 104772 RVA: 0x007DB689 File Offset: 0x007D9889
	public bool IsInLogicRange
	{
		get
		{
			return this.IsInLogicRangeInternal.Value;
		}
	}

	// Token: 0x06019945 RID: 104773 RVA: 0x007DB698 File Offset: 0x007D9898
	public void ChangeLogicRangeState(bool isInLogicRange)
	{
		bool? isInLogicRangeInternal = this.IsInLogicRangeInternal;
		if (!(isInLogicRangeInternal.GetValueOrDefault() == isInLogicRange & isInLogicRangeInternal != null))
		{
			if (isInLogicRange)
			{
				if (!this.IsModelLoadedInternal)
				{
					SimpleNpcLoadController.Instance.AddSimpleNpc(this);
					this.IsModelLoadedInternal = true;
				}
				this.SetLogicTickRunning(true);
			}
			else
			{
				this.SetLogicTickRunning(false);
			}
		}
		this.IsInLogicRangeInternal = new bool?(isInLogicRange);
	}

	// Token: 0x06019946 RID: 104774 RVA: 0x007DB6FC File Offset: 0x007D98FC
	private void SetLogicTickRunning(bool isRun)
	{
		if (!isRun)
		{
			if (this.RegisterLoopTimerId != null)
			{
				if (TimerSystem.Instance.Has(this.RegisterLoopTimerId))
				{
					TimerSystem.Instance.Remove(this.RegisterLoopTimerId);
				}
				this.RegisterLoopTimerId = null;
				if (this.FlowLogic != null)
				{
					this.FlowLogic.ForceStopFlow();
				}
			}
			return;
		}
		if (this.RegisterLoopTimerId != null)
		{
			return;
		}
		this.LastGameSeconds = (float)Time.Instance.WorldTimeSeconds;
		this.RegisterLoopTimerId = TimerSystem.Instance.Forever(delegate(float _)
		{
			this.OnLogicTick();
		}, 100f, 1f, null, null, true);
	}

	// Token: 0x06019947 RID: 104775 RVA: 0x007DB798 File Offset: 0x007D9998
	private void OnLogicTick()
	{
		double worldTimeSeconds = Time.Instance.WorldTimeSeconds;
		double num = worldTimeSeconds - (double)this.LastGameSeconds;
		this.LastGameSeconds = (float)worldTimeSeconds;
		if (this.FlowLogic != null)
		{
			this.FlowLogic.Tick((float)num);
		}
	}

	// Token: 0x06019948 RID: 104776 RVA: 0x007DB7D7 File Offset: 0x007D99D7
	private void CacheComponents()
	{
		this.CachedComponents = base.K2_GetComponentsByClass(UActorComponent.StaticClass());
	}

	// Token: 0x06019949 RID: 104777 RVA: 0x007DB7F0 File Offset: 0x007D99F0
	public void SetTickEnabled(bool value)
	{
		bool? isTickEnabled = this.IsTickEnabled;
		if (value == isTickEnabled.GetValueOrDefault() & isTickEnabled != null)
		{
			return;
		}
		this.IsTickEnabled = new bool?(value);
		TArray<UActorComponent> tarray = (this.CachedComponents != null) ? this.CachedComponents : base.K2_GetComponentsByClass(UActorComponent.StaticClass());
		int i = 0;
		int num = tarray.Num();
		while (i < num)
		{
			UActorComponent uactorComponent = tarray.Get(i);
			if (uactorComponent != null)
			{
				uactorComponent.SetComponentTickEnabled(value);
			}
			i++;
		}
	}

	// Token: 0x0601994A RID: 104778 RVA: 0x007DB870 File Offset: 0x007D9A70
	private void CloseSkeletalMeshShadow()
	{
		if (this.CachedComponents == null)
		{
			Log.Instance.Error(ELogModule.NPC, ELogAuthor.WY, "You must call CloseSkeletalMeshShadow after CacheComponents", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int i = 0;
		int num = this.CachedComponents.Num();
		while (i < num)
		{
			UActorComponent uactorComponent = this.CachedComponents.Get(i);
			if (uactorComponent != null)
			{
				USkeletalMeshComponent uskeletalMeshComponent = uactorComponent as USkeletalMeshComponent;
				if (uskeletalMeshComponent != null)
				{
					uskeletalMeshComponent.SetCastShadow(false);
				}
			}
			i++;
		}
	}

	// Token: 0x0601994B RID: 104779 RVA: 0x007DB8E4 File Offset: 0x007D9AE4
	public unsafe void SetMainShadowEnabled(bool value)
	{
		bool? isShowShadow = this.IsShowShadow;
		if (value == isShowShadow.GetValueOrDefault() & isShowShadow != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.WY;
			string message = "SetShadowEnabled, value === IsShowShadow";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Value", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsShowShadow", this.IsShowShadow);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Entity;
		ELogAuthor author2 = ELogAuthor.WY;
		string message2 = "SetShadowEnabled, value !== IsShowShadow";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Value", value);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("IsShowShadow", this.IsShowShadow);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		this.IsShowShadow = new bool?(value);
		TArray<UActorComponent> tarray = (this.CachedComponents != null) ? this.CachedComponents : base.K2_GetComponentsByClass(UActorComponent.StaticClass());
		if (tarray == null)
		{
			return;
		}
		int i = 0;
		int num = tarray.Num();
		while (i < num)
		{
			UActorComponent uactorComponent = tarray.Get(i);
			if (uactorComponent != null && uactorComponent is USkinnedMeshComponent && !(uactorComponent is USkeletalMeshComponent))
			{
				(uactorComponent as USkinnedMeshComponent).SetCastShadow(value);
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Entity;
				ELogAuthor author3 = ELogAuthor.WY;
				string message3 = "SetShadowEnabled, SetCastShadow";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Value", value);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			i++;
		}
	}

	// Token: 0x170028DC RID: 10460
	// (get) Token: 0x0601994C RID: 104780 RVA: 0x007DBA75 File Offset: 0x007D9C75
	public bool IsLodShow
	{
		get
		{
			return !Info.Instance.IsGameRunning() || GameSettingsDeviceRender.Instance.GameQualitySettingLevel >= (EGameQualitySettingLevel)this.LodLevel;
		}
	}

	// Token: 0x0601994D RID: 104781 RVA: 0x007DBA9C File Offset: 0x007D9C9C
	private void SetAnimUROParams()
	{
		FAnimUpdateRateParameters fanimUpdateRateParameters = new FAnimUpdateRateParameters();
		fanimUpdateRateParameters.bShouldUseLodMap = true;
		int num = this.Mesh.LODInfo.Num();
		fanimUpdateRateParameters.LODToFrameSkipMap.Empty(0);
		for (int i = 0; i < num; i++)
		{
			fanimUpdateRateParameters.LODToFrameSkipMap.Add(i, (i < 2) ? 0 : (i - 1));
		}
		fanimUpdateRateParameters.BaseNonRenderedUpdateRate = 8;
		fanimUpdateRateParameters.MaxEvalRateForInterpolation = num;
		EVisibilityBasedAnimTickOption visibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.OnlyTickPoseWhenRendered;
		FAnimUpdateRateParameters fanimUpdateRateParameters2 = fanimUpdateRateParameters;
		TArray<UActorComponent> tarray = base.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
		for (int j = 0; j < tarray.Num(); j++)
		{
			USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(j) as USkeletalMeshComponent;
			uskeletalMeshComponent.bEnableUpdateRateOptimizations = true;
			uskeletalMeshComponent.SetAnimUpdateRateParameters(ref fanimUpdateRateParameters2);
			uskeletalMeshComponent.VisibilityBasedAnimTickOption = visibilityBasedAnimTickOption;
		}
	}

	// Token: 0x0601994E RID: 104782 RVA: 0x007DBB5A File Offset: 0x007D9D5A
	public static void CreateStaticDefaultValue()
	{
		TsSimpleNpc.InstanceCount = 0;
		TsSimpleNpc.DeleteCount = 0;
		TsSimpleNpc.SphereTrace = null;
	}

	// Token: 0x0601994F RID: 104783 RVA: 0x007DBB6E File Offset: 0x007D9D6E
	public static void ResetStaticDefaultValue()
	{
		TsSimpleNpc.InstanceCount = 0;
		TsSimpleNpc.DeleteCount = 0;
		TsSimpleNpc.SphereTrace = null;
	}

	// Token: 0x06019950 RID: 104784 RVA: 0x007DBB82 File Offset: 0x007D9D82
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSimpleNpc._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/TsSimpleNpc.TsSimpleNpc_C");
		}
		return TsSimpleNpc._ClassPtr;
	}

	// Token: 0x06019951 RID: 104785 RVA: 0x007DBBA8 File Offset: 0x007D9DA8
	public TsSimpleNpc() : this(BuiltinUtils.AllocNativeUObject(TsSimpleNpc.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019952 RID: 104786 RVA: 0x007DBBD0 File Offset: 0x007D9DD0
	[NullableContext(1)]
	public TsSimpleNpc(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleNpc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019953 RID: 104787 RVA: 0x007DBC03 File Offset: 0x007D9E03
	protected TsSimpleNpc(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06019954 RID: 104788 RVA: 0x007DBC0C File Offset: 0x007D9E0C
	protected virtual void __CPPCALL_EditorInit_Implementation()
	{
		this.EditorInit_Implementation();
	}

	// Token: 0x06019955 RID: 104789 RVA: 0x007DBC14 File Offset: 0x007D9E14
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_EditorTick_Implementation(AKuroEffectActor.__EditorTick_FunctionParams* __Params)
	{
		this.EditorTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x06019956 RID: 104790 RVA: 0x007DBC22 File Offset: 0x007D9E22
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06019957 RID: 104791 RVA: 0x007DBC2A File Offset: 0x007D9E2A
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(TsSimpleNpc.__ReceiveEndPlay_FunctionParams* __Params)
	{
		this.ReceiveEndPlay_Implementation(__Params->endPlayReason);
	}

	// Token: 0x06019958 RID: 104792 RVA: 0x007DBC38 File Offset: 0x007D9E38
	protected virtual void __CPPCALL_LoadModel_Implementation()
	{
		this.LoadModel_Implementation();
	}

	// Token: 0x06019959 RID: 104793 RVA: 0x007DBC40 File Offset: 0x007D9E40
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_DebugSetNpcDitherValue_Implementation(TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams* __Params)
	{
		this.DebugSetNpcDitherValue_Implementation(__Params->value);
	}

	// Token: 0x0601995A RID: 104794 RVA: 0x007DBC4E File Offset: 0x007D9E4E
	protected virtual void __CPPCALL_SetDefaultCollision_Implementation()
	{
		this.SetDefaultCollision_Implementation();
	}

	// Token: 0x0601995B RID: 104795 RVA: 0x007DBC56 File Offset: 0x007D9E56
	protected virtual void __CPPCALL_ResetMeshLocation_Implementation()
	{
		this.ResetMeshLocation_Implementation();
	}

	// Token: 0x0601995C RID: 104796 RVA: 0x007DBC5E File Offset: 0x007D9E5E
	protected virtual void __CPPCALL_FindFloor_Implementation()
	{
		this.FindFloor_Implementation();
	}

	// Token: 0x0601995D RID: 104797 RVA: 0x007DBC68 File Offset: 0x007D9E68
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ShowDialog_Implementation(TsSimpleNpc.__ShowDialog_FunctionParams* __Params)
	{
		string text = FString.ToString((void*)(&__Params->text));
		this.ShowDialog_Implementation(text, __Params->removeSeconds);
	}

	// Token: 0x0601995E RID: 104798 RVA: 0x007DBC8F File Offset: 0x007D9E8F
	protected virtual void __CPPCALL_HideDialog_Implementation()
	{
		this.HideDialog_Implementation();
	}

	// Token: 0x0601995F RID: 104799 RVA: 0x007DBC98 File Offset: 0x007D9E98
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_TryPlayMontage_Implementation(TsSimpleNpc.__TryPlayMontage_FunctionParams* __Params)
	{
		string montagePath = FString.ToString((void*)(&__Params->montagePath));
		__Params->__Result = this.TryPlayMontage_Implementation(montagePath);
	}

	// Token: 0x06019960 RID: 104800 RVA: 0x007DBCBF File Offset: 0x007D9EBF
	protected virtual void __CPPCALL_StopMontage_Implementation()
	{
		this.StopMontage_Implementation();
	}

	// Token: 0x0400E038 RID: 57400
	[Nullable(1)]
	private const string PROFILE_KEY = "SimpleNpc_FindFloor";

	// Token: 0x0400E039 RID: 57401
	private const float DEFAULT_HALF_HEIGHT = 85f;

	// Token: 0x0400E03A RID: 57402
	private const float DEFAULT_RADIUS = 25f;

	// Token: 0x0400E03B RID: 57403
	private const float DEFAULT_MESH_YAW = -90f;

	// Token: 0x0400E03C RID: 57404
	private const float FIND_FLOOR_RAY_LENGTH = 500f;

	// Token: 0x0400E03D RID: 57405
	private const float MIN_EDITOR_MOVE_CHANGED = 900f;

	// Token: 0x0400E03E RID: 57406
	private const int LOGIC_TICK_INTERVAL = 100;

	// Token: 0x0400E03F RID: 57407
	public double TempDistanceSquared;

	// Token: 0x0400E040 RID: 57408
	public float CurDither;

	// Token: 0x0400E041 RID: 57409
	public bool IsNotUnload;

	// Token: 0x0400E042 RID: 57410
	private SimpleNpcFlowLogic FlowLogic;

	// Token: 0x0400E043 RID: 57411
	private Vector TempLocation;

	// Token: 0x0400E044 RID: 57412
	private Vector CachedLocation;

	// Token: 0x0400E045 RID: 57413
	private UAnimInstance TempAnimInstance;

	// Token: 0x0400E046 RID: 57414
	private UAnimationAsset TempAnimAsset;

	// Token: 0x0400E047 RID: 57415
	private string TempDaPath;

	// Token: 0x0400E048 RID: 57416
	private bool NeedResetCollision;

	// Token: 0x0400E049 RID: 57417
	private bool IsDirty;

	// Token: 0x0400E04A RID: 57418
	private FVectorDouble? StartLocation;

	// Token: 0x0400E04B RID: 57419
	private Vector StartLocationProxy;

	// Token: 0x0400E04C RID: 57420
	private int InstanceId;

	// Token: 0x0400E04D RID: 57421
	private CharacterDitherEffectController DitherEffectControllerInternal;

	// Token: 0x0400E04E RID: 57422
	private bool? IsInLogicRangeInternal;

	// Token: 0x0400E04F RID: 57423
	private TimerHandle RegisterLoopTimerId;

	// Token: 0x0400E050 RID: 57424
	private float LastGameSeconds;

	// Token: 0x0400E051 RID: 57425
	private bool IsModelLoadedInternal;

	// Token: 0x0400E052 RID: 57426
	private static int InstanceCount;

	// Token: 0x0400E053 RID: 57427
	private static int DeleteCount;

	// Token: 0x0400E054 RID: 57428
	private static UTraceSphereElement SphereTrace;

	// Token: 0x0400E055 RID: 57429
	private bool? IsShowShadow;

	// Token: 0x0400E056 RID: 57430
	private bool? IsTickEnabled;

	// Token: 0x0400E057 RID: 57431
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<UActorComponent> CachedComponents;

	// Token: 0x0400E058 RID: 57432
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/TsSimpleNpc.TsSimpleNpc_C";

	// Token: 0x0400E059 RID: 57433
	private static IntPtr _ClassPtr;

	// Token: 0x0400E05A RID: 57434
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E05B RID: 57435
	private static int __PropertyOffset_CapsuleCollision;

	// Token: 0x0400E05C RID: 57436
	private static int __PropertyOffset_Mesh;

	// Token: 0x0400E05D RID: 57437
	private static int __PropertyOffset_CharRenderingComponent;

	// Token: 0x0400E05E RID: 57438
	private static int __PropertyOffset_DA;

	// Token: 0x0400E05F RID: 57439
	private FSoftObjectPath _DA;

	// Token: 0x0400E060 RID: 57440
	private static int __PropertyOffset_DisappearOnSunny;

	// Token: 0x0400E061 RID: 57441
	private static int __PropertyOffset_DisappearOnCloudy;

	// Token: 0x0400E062 RID: 57442
	private static int __PropertyOffset_DisappearOnRainy;

	// Token: 0x0400E063 RID: 57443
	private static int __PropertyOffset_DisappearOnThunderRain;

	// Token: 0x0400E064 RID: 57444
	private static int __PropertyOffset_DisappearOnSnowy;

	// Token: 0x0400E065 RID: 57445
	private static int __PropertyOffset_LodLevel;

	// Token: 0x0400E066 RID: 57446
	private static int __PropertyOffset_DebugDitherValue;

	// Token: 0x02008958 RID: 35160
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected new ref struct __ReceiveEndPlay_FunctionParams
	{
		// Token: 0x0402BCCC RID: 179404
		[FieldOffset(0)]
		public TEnumAsByte<EEndPlayReason> endPlayReason;
	}

	// Token: 0x02008959 RID: 35161
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __DebugSetNpcDitherValue_FunctionParams
	{
		// Token: 0x0402BCCD RID: 179405
		[FieldOffset(0)]
		public float value;
	}

	// Token: 0x0200895A RID: 35162
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ShowDialog_FunctionParams
	{
		// Token: 0x0402BCCE RID: 179406
		[FieldOffset(0)]
		public FString text;

		// Token: 0x0402BCCF RID: 179407
		[FieldOffset(16)]
		public float removeSeconds;
	}

	// Token: 0x0200895B RID: 35163
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TryPlayMontage_FunctionParams
	{
		// Token: 0x0402BCD0 RID: 179408
		[FieldOffset(0)]
		public FString montagePath;

		// Token: 0x0402BCD1 RID: 179409
		[FieldOffset(16)]
		public bool __Result;
	}
}
