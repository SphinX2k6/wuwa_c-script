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

// Token: 0x0200325D RID: 12893
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/TsSimpleNpc.TsSimpleNpc_C")]
public class TsSimpleNpc : AKuroEffectActor, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601BD3D RID: 113981 RVA: 0x007B224A File Offset: 0x007B044A
	static TsSimpleNpc()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsSimpleNpc.CreateStaticDefaultValue), new Action(TsSimpleNpc.ResetStaticDefaultValue));
	}

	// Token: 0x1700264A RID: 9802
	// (get) Token: 0x0601BD3E RID: 113982 RVA: 0x007B2269 File Offset: 0x007B0469
	// (set) Token: 0x0601BD3F RID: 113983 RVA: 0x007B227D File Offset: 0x007B047D
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

	// Token: 0x1700264B RID: 9803
	// (get) Token: 0x0601BD40 RID: 113984 RVA: 0x007B2292 File Offset: 0x007B0492
	// (set) Token: 0x0601BD41 RID: 113985 RVA: 0x007B22A6 File Offset: 0x007B04A6
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

	// Token: 0x1700264C RID: 9804
	// (get) Token: 0x0601BD42 RID: 113986 RVA: 0x007B22BB File Offset: 0x007B04BB
	// (set) Token: 0x0601BD43 RID: 113987 RVA: 0x007B22CF File Offset: 0x007B04CF
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

	// Token: 0x1700264D RID: 9805
	// (get) Token: 0x0601BD44 RID: 113988 RVA: 0x007B22E4 File Offset: 0x007B04E4
	// (set) Token: 0x0601BD45 RID: 113989 RVA: 0x007B231D File Offset: 0x007B051D
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

	// Token: 0x1700264E RID: 9806
	// (get) Token: 0x0601BD46 RID: 113990 RVA: 0x007B2345 File Offset: 0x007B0545
	// (set) Token: 0x0601BD47 RID: 113991 RVA: 0x007B2355 File Offset: 0x007B0555
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

	// Token: 0x1700264F RID: 9807
	// (get) Token: 0x0601BD48 RID: 113992 RVA: 0x007B2366 File Offset: 0x007B0566
	// (set) Token: 0x0601BD49 RID: 113993 RVA: 0x007B2376 File Offset: 0x007B0576
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

	// Token: 0x17002650 RID: 9808
	// (get) Token: 0x0601BD4A RID: 113994 RVA: 0x007B2387 File Offset: 0x007B0587
	// (set) Token: 0x0601BD4B RID: 113995 RVA: 0x007B2397 File Offset: 0x007B0597
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

	// Token: 0x17002651 RID: 9809
	// (get) Token: 0x0601BD4C RID: 113996 RVA: 0x007B23A8 File Offset: 0x007B05A8
	// (set) Token: 0x0601BD4D RID: 113997 RVA: 0x007B23B8 File Offset: 0x007B05B8
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

	// Token: 0x17002652 RID: 9810
	// (get) Token: 0x0601BD4E RID: 113998 RVA: 0x007B23C9 File Offset: 0x007B05C9
	// (set) Token: 0x0601BD4F RID: 113999 RVA: 0x007B23D9 File Offset: 0x007B05D9
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

	// Token: 0x17002653 RID: 9811
	// (get) Token: 0x0601BD50 RID: 114000 RVA: 0x007B23EA File Offset: 0x007B05EA
	// (set) Token: 0x0601BD51 RID: 114001 RVA: 0x007B23FA File Offset: 0x007B05FA
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

	// Token: 0x17002654 RID: 9812
	// (get) Token: 0x0601BD52 RID: 114002 RVA: 0x007B240B File Offset: 0x007B060B
	// (set) Token: 0x0601BD53 RID: 114003 RVA: 0x007B241B File Offset: 0x007B061B
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

	// Token: 0x17002655 RID: 9813
	// (get) Token: 0x0601BD54 RID: 114004 RVA: 0x007B242C File Offset: 0x007B062C
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

	// Token: 0x0601BD55 RID: 114005 RVA: 0x007B2450 File Offset: 0x007B0650
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void EditorInit()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("EditorInit"), out num);
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

	// Token: 0x0601BD56 RID: 114006 RVA: 0x007B24C0 File Offset: 0x007B06C0
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

	// Token: 0x0601BD57 RID: 114007 RVA: 0x007B258C File Offset: 0x007B078C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void EditorTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("EditorTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AKuroEffectActor.__EditorTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AKuroEffectActor.__EditorTick_FunctionParams*)ptr + 15L / (long)sizeof(AKuroEffectActor.__EditorTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601BD58 RID: 114008 RVA: 0x007B2604 File Offset: 0x007B0804
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

	// Token: 0x0601BD59 RID: 114009 RVA: 0x007B2798 File Offset: 0x007B0998
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

	// Token: 0x0601BD5A RID: 114010 RVA: 0x007B2808 File Offset: 0x007B0A08
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.InitData();
	}

	// Token: 0x0601BD5B RID: 114011 RVA: 0x007B2810 File Offset: 0x007B0A10
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

	// Token: 0x0601BD5C RID: 114012 RVA: 0x007B286C File Offset: 0x007B0A6C
	private void InitCollisionInfo()
	{
		this.CapsuleCollision.bCanCharacterStandOn = false;
		this.CapsuleCollision.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
		this.CapsuleCollision.SetCollisionObjectType(ECollisionChannel.ECC_WorldStatic);
		this.CapsuleCollision.SetCollisionResponseToAllChannels(ECollisionResponse.ECR_Ignore);
		CollisionUtils.Instance.SetCollisionResponseToPawn(this.CapsuleCollision, EPawnChannel.All, ECollisionResponse.ECR_Block);
	}

	// Token: 0x0601BD5D RID: 114013 RVA: 0x007B28C0 File Offset: 0x007B0AC0
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

	// Token: 0x0601BD5E RID: 114014 RVA: 0x007B2985 File Offset: 0x007B0B85
	private void InitRenderInfo()
	{
		this.CharRenderingComponent.Init(ECharacterRenderingType.Npc);
		base.SetPrimitiveEntityType(2U);
		this.SetAnimUROParams();
	}

	// Token: 0x0601BD5F RID: 114015 RVA: 0x007B29A0 File Offset: 0x007B0BA0
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

	// Token: 0x0601BD60 RID: 114016 RVA: 0x007B29FC File Offset: 0x007B0BFC
	[NullableContext(0)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ReceiveEndPlay(TEnumAsByte<EEndPlayReason> endPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSimpleNpc.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSimpleNpc.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(TsSimpleNpc.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->endPlayReason = endPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601BD61 RID: 114017 RVA: 0x007B2A74 File Offset: 0x007B0C74
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

	// Token: 0x0601BD62 RID: 114018 RVA: 0x007B2B50 File Offset: 0x007B0D50
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

	// Token: 0x0601BD63 RID: 114019 RVA: 0x007B2BF0 File Offset: 0x007B0DF0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void LoadModel()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("LoadModel"), out num);
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

	// Token: 0x0601BD64 RID: 114020 RVA: 0x007B2C60 File Offset: 0x007B0E60
	protected void LoadModel_Implementation()
	{
		this.FindComponents();
		this.IsNotUnload = true;
		this.LoadModelByDA();
	}

	// Token: 0x0601BD65 RID: 114021 RVA: 0x007B2C78 File Offset: 0x007B0E78
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void DebugSetNpcDitherValue(float value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DebugSetNpcDitherValue"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams*)ptr + 15L / (long)sizeof(TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->value = value;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601BD66 RID: 114022 RVA: 0x007B2CEE File Offset: 0x007B0EEE
	protected void DebugSetNpcDitherValue_Implementation(float value)
	{
		this.SetDitherEffect(value, ECharacterDitherType.Fight);
	}

	// Token: 0x0601BD67 RID: 114023 RVA: 0x007B2CF8 File Offset: 0x007B0EF8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDefaultCollision()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDefaultCollision"), out num);
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

	// Token: 0x0601BD68 RID: 114024 RVA: 0x007B2D68 File Offset: 0x007B0F68
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

	// Token: 0x0601BD69 RID: 114025 RVA: 0x007B2DE4 File Offset: 0x007B0FE4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ResetMeshLocation()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ResetMeshLocation"), out num);
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

	// Token: 0x0601BD6A RID: 114026 RVA: 0x007B2E54 File Offset: 0x007B1054
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

	// Token: 0x0601BD6B RID: 114027 RVA: 0x007B2ECC File Offset: 0x007B10CC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void FindFloor()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("FindFloor"), out num);
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

	// Token: 0x0601BD6C RID: 114028 RVA: 0x007B2F3C File Offset: 0x007B113C
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

	// Token: 0x0601BD6D RID: 114029 RVA: 0x007B3068 File Offset: 0x007B1268
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

	// Token: 0x0601BD6E RID: 114030 RVA: 0x007B30DC File Offset: 0x007B12DC
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

	// Token: 0x0601BD6F RID: 114031 RVA: 0x007B3167 File Offset: 0x007B1367
	public void StartFlowLogic()
	{
		if (this.FlowLogic == null)
		{
			return;
		}
		this.FlowLogic.StartFlowLogic();
	}

	// Token: 0x0601BD70 RID: 114032 RVA: 0x007B317D File Offset: 0x007B137D
	public void SetDitherEffect(float dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
	{
		this.DitherEffectController.SetDitherEffect((double)dither, ditherType, true);
	}

	// Token: 0x0601BD71 RID: 114033 RVA: 0x007B3190 File Offset: 0x007B1390
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ShowDialog(string text, float removeSeconds = -1f)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ShowDialog"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSimpleNpc.__ShowDialog_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSimpleNpc.__ShowDialog_FunctionParams*)ptr + 15L / (long)sizeof(TsSimpleNpc.__ShowDialog_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->text), text);
			ptr2->removeSeconds = removeSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601BD72 RID: 114034 RVA: 0x007B3214 File Offset: 0x007B1414
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

	// Token: 0x0601BD73 RID: 114035 RVA: 0x007B3268 File Offset: 0x007B1468
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void HideDialog()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("HideDialog"), out num);
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

	// Token: 0x0601BD74 RID: 114036 RVA: 0x007B32D8 File Offset: 0x007B14D8
	protected void HideDialog_Implementation()
	{
		if (this.FlowLogic == null)
		{
			return;
		}
		this.FlowLogic.HideDialog();
	}

	// Token: 0x0601BD75 RID: 114037 RVA: 0x007B32F0 File Offset: 0x007B14F0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool TryPlayMontage(string montagePath)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("TryPlayMontage"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSimpleNpc.__TryPlayMontage_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSimpleNpc.__TryPlayMontage_FunctionParams*)ptr + 15L / (long)sizeof(TsSimpleNpc.__TryPlayMontage_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->montagePath), montagePath);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601BD76 RID: 114038 RVA: 0x007B3372 File Offset: 0x007B1572
	[NullableContext(1)]
	protected bool TryPlayMontage_Implementation(string montagePath)
	{
		return this.FlowLogic != null && this.FlowLogic.TryPlayMontage(montagePath);
	}

	// Token: 0x0601BD77 RID: 114039 RVA: 0x007B338C File Offset: 0x007B158C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void StopMontage()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("StopMontage"), out num);
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

	// Token: 0x0601BD78 RID: 114040 RVA: 0x007B33FC File Offset: 0x007B15FC
	protected void StopMontage_Implementation()
	{
		if (this.FlowLogic == null)
		{
			return;
		}
		this.FlowLogic.StopMontage();
	}

	// Token: 0x0601BD79 RID: 114041 RVA: 0x007B3412 File Offset: 0x007B1612
	public void FilterFlowWorldState()
	{
		SimpleNpcFlowLogic flowLogic = this.FlowLogic;
		if (flowLogic == null)
		{
			return;
		}
		flowLogic.FilterFlowWorldState();
	}

	// Token: 0x17002656 RID: 9814
	// (get) Token: 0x0601BD7A RID: 114042 RVA: 0x007B3424 File Offset: 0x007B1624
	public bool IsHiding
	{
		get
		{
			return !this.IsNotUnload;
		}
	}

	// Token: 0x17002657 RID: 9815
	// (get) Token: 0x0601BD7B RID: 114043 RVA: 0x007B342F File Offset: 0x007B162F
	public FVectorDouble SelfLocation
	{
		get
		{
			return this.StartLocation.Value;
		}
	}

	// Token: 0x17002658 RID: 9816
	// (get) Token: 0x0601BD7C RID: 114044 RVA: 0x007B343C File Offset: 0x007B163C
	[Nullable(1)]
	public Vector SelfLocationProxy
	{
		[NullableContext(1)]
		get
		{
			return this.StartLocationProxy;
		}
	}

	// Token: 0x17002659 RID: 9817
	// (get) Token: 0x0601BD7D RID: 114045 RVA: 0x007B3444 File Offset: 0x007B1644
	public bool IsInLogicRange
	{
		get
		{
			return this.IsInLogicRangeInternal.Value;
		}
	}

	// Token: 0x0601BD7E RID: 114046 RVA: 0x007B3454 File Offset: 0x007B1654
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

	// Token: 0x0601BD7F RID: 114047 RVA: 0x007B34B8 File Offset: 0x007B16B8
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

	// Token: 0x0601BD80 RID: 114048 RVA: 0x007B3554 File Offset: 0x007B1754
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

	// Token: 0x0601BD81 RID: 114049 RVA: 0x007B3593 File Offset: 0x007B1793
	private void CacheComponents()
	{
		this.CachedComponents = base.K2_GetComponentsByClass(UActorComponent.StaticClass());
	}

	// Token: 0x0601BD82 RID: 114050 RVA: 0x007B35AC File Offset: 0x007B17AC
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

	// Token: 0x0601BD83 RID: 114051 RVA: 0x007B362C File Offset: 0x007B182C
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

	// Token: 0x0601BD84 RID: 114052 RVA: 0x007B36A0 File Offset: 0x007B18A0
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

	// Token: 0x1700265A RID: 9818
	// (get) Token: 0x0601BD85 RID: 114053 RVA: 0x007B3831 File Offset: 0x007B1A31
	public bool IsLodShow
	{
		get
		{
			return !Info.Instance.IsGameRunning() || GameSettingsDeviceRender.Instance.GameQualitySettingLevel >= (EGameQualitySettingLevel)this.LodLevel;
		}
	}

	// Token: 0x0601BD86 RID: 114054 RVA: 0x007B3858 File Offset: 0x007B1A58
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

	// Token: 0x0601BD87 RID: 114055 RVA: 0x007B3916 File Offset: 0x007B1B16
	public static void CreateStaticDefaultValue()
	{
		TsSimpleNpc.InstanceCount = 0;
		TsSimpleNpc.DeleteCount = 0;
		TsSimpleNpc.SphereTrace = null;
	}

	// Token: 0x0601BD88 RID: 114056 RVA: 0x007B392A File Offset: 0x007B1B2A
	public static void ResetStaticDefaultValue()
	{
		TsSimpleNpc.InstanceCount = 0;
		TsSimpleNpc.DeleteCount = 0;
		TsSimpleNpc.SphereTrace = null;
	}

	// Token: 0x0601BD89 RID: 114057 RVA: 0x007B393E File Offset: 0x007B1B3E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSimpleNpc._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/TsSimpleNpc.TsSimpleNpc_C");
		}
		return TsSimpleNpc._ClassPtr;
	}

	// Token: 0x0601BD8A RID: 114058 RVA: 0x007B3964 File Offset: 0x007B1B64
	public TsSimpleNpc() : this(BuiltinUtils.AllocNativeUObject(TsSimpleNpc.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601BD8B RID: 114059 RVA: 0x007B398C File Offset: 0x007B1B8C
	[NullableContext(1)]
	public TsSimpleNpc(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleNpc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD8C RID: 114060 RVA: 0x007B39BF File Offset: 0x007B1BBF
	protected TsSimpleNpc(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BD8D RID: 114061 RVA: 0x007B39C8 File Offset: 0x007B1BC8
	protected virtual void __CPPCALL_EditorInit_Implementation()
	{
		this.EditorInit_Implementation();
	}

	// Token: 0x0601BD8E RID: 114062 RVA: 0x007B39D0 File Offset: 0x007B1BD0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_EditorTick_Implementation(AKuroEffectActor.__EditorTick_FunctionParams* __Params)
	{
		this.EditorTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601BD8F RID: 114063 RVA: 0x007B39DE File Offset: 0x007B1BDE
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601BD90 RID: 114064 RVA: 0x007B39E6 File Offset: 0x007B1BE6
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(TsSimpleNpc.__ReceiveEndPlay_FunctionParams* __Params)
	{
		this.ReceiveEndPlay_Implementation(__Params->endPlayReason);
	}

	// Token: 0x0601BD91 RID: 114065 RVA: 0x007B39F4 File Offset: 0x007B1BF4
	protected virtual void __CPPCALL_LoadModel_Implementation()
	{
		this.LoadModel_Implementation();
	}

	// Token: 0x0601BD92 RID: 114066 RVA: 0x007B39FC File Offset: 0x007B1BFC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_DebugSetNpcDitherValue_Implementation(TsSimpleNpc.__DebugSetNpcDitherValue_FunctionParams* __Params)
	{
		this.DebugSetNpcDitherValue_Implementation(__Params->value);
	}

	// Token: 0x0601BD93 RID: 114067 RVA: 0x007B3A0A File Offset: 0x007B1C0A
	protected virtual void __CPPCALL_SetDefaultCollision_Implementation()
	{
		this.SetDefaultCollision_Implementation();
	}

	// Token: 0x0601BD94 RID: 114068 RVA: 0x007B3A12 File Offset: 0x007B1C12
	protected virtual void __CPPCALL_ResetMeshLocation_Implementation()
	{
		this.ResetMeshLocation_Implementation();
	}

	// Token: 0x0601BD95 RID: 114069 RVA: 0x007B3A1A File Offset: 0x007B1C1A
	protected virtual void __CPPCALL_FindFloor_Implementation()
	{
		this.FindFloor_Implementation();
	}

	// Token: 0x0601BD96 RID: 114070 RVA: 0x007B3A24 File Offset: 0x007B1C24
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ShowDialog_Implementation(TsSimpleNpc.__ShowDialog_FunctionParams* __Params)
	{
		string text = FString.ToString((void*)(&__Params->text));
		this.ShowDialog_Implementation(text, __Params->removeSeconds);
	}

	// Token: 0x0601BD97 RID: 114071 RVA: 0x007B3A4B File Offset: 0x007B1C4B
	protected virtual void __CPPCALL_HideDialog_Implementation()
	{
		this.HideDialog_Implementation();
	}

	// Token: 0x0601BD98 RID: 114072 RVA: 0x007B3A54 File Offset: 0x007B1C54
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_TryPlayMontage_Implementation(TsSimpleNpc.__TryPlayMontage_FunctionParams* __Params)
	{
		string montagePath = FString.ToString((void*)(&__Params->montagePath));
		__Params->__Result = this.TryPlayMontage_Implementation(montagePath);
	}

	// Token: 0x0601BD99 RID: 114073 RVA: 0x007B3A7B File Offset: 0x007B1C7B
	protected virtual void __CPPCALL_StopMontage_Implementation()
	{
		this.StopMontage_Implementation();
	}

	// Token: 0x0400DB99 RID: 56217
	[Nullable(1)]
	private const string PROFILE_KEY = "SimpleNpc_FindFloor";

	// Token: 0x0400DB9A RID: 56218
	private const float DEFAULT_HALF_HEIGHT = 85f;

	// Token: 0x0400DB9B RID: 56219
	private const float DEFAULT_RADIUS = 25f;

	// Token: 0x0400DB9C RID: 56220
	private const float DEFAULT_MESH_YAW = -90f;

	// Token: 0x0400DB9D RID: 56221
	private const float FIND_FLOOR_RAY_LENGTH = 500f;

	// Token: 0x0400DB9E RID: 56222
	private const float MIN_EDITOR_MOVE_CHANGED = 900f;

	// Token: 0x0400DB9F RID: 56223
	private const int LOGIC_TICK_INTERVAL = 100;

	// Token: 0x0400DBA0 RID: 56224
	public double TempDistanceSquared;

	// Token: 0x0400DBA1 RID: 56225
	public float CurDither;

	// Token: 0x0400DBA2 RID: 56226
	public bool IsNotUnload;

	// Token: 0x0400DBA3 RID: 56227
	private SimpleNpcFlowLogic FlowLogic;

	// Token: 0x0400DBA4 RID: 56228
	private Vector TempLocation;

	// Token: 0x0400DBA5 RID: 56229
	private Vector CachedLocation;

	// Token: 0x0400DBA6 RID: 56230
	private UAnimInstance TempAnimInstance;

	// Token: 0x0400DBA7 RID: 56231
	private UAnimationAsset TempAnimAsset;

	// Token: 0x0400DBA8 RID: 56232
	private string TempDaPath;

	// Token: 0x0400DBA9 RID: 56233
	private bool NeedResetCollision;

	// Token: 0x0400DBAA RID: 56234
	private bool IsDirty;

	// Token: 0x0400DBAB RID: 56235
	private FVectorDouble? StartLocation;

	// Token: 0x0400DBAC RID: 56236
	private Vector StartLocationProxy;

	// Token: 0x0400DBAD RID: 56237
	private int InstanceId;

	// Token: 0x0400DBAE RID: 56238
	private CharacterDitherEffectController DitherEffectControllerInternal;

	// Token: 0x0400DBAF RID: 56239
	private bool? IsInLogicRangeInternal;

	// Token: 0x0400DBB0 RID: 56240
	private TimerHandle RegisterLoopTimerId;

	// Token: 0x0400DBB1 RID: 56241
	private float LastGameSeconds;

	// Token: 0x0400DBB2 RID: 56242
	private bool IsModelLoadedInternal;

	// Token: 0x0400DBB3 RID: 56243
	private static int InstanceCount;

	// Token: 0x0400DBB4 RID: 56244
	private static int DeleteCount;

	// Token: 0x0400DBB5 RID: 56245
	private static UTraceSphereElement SphereTrace;

	// Token: 0x0400DBB6 RID: 56246
	private bool? IsShowShadow;

	// Token: 0x0400DBB7 RID: 56247
	private bool? IsTickEnabled;

	// Token: 0x0400DBB8 RID: 56248
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<UActorComponent> CachedComponents;

	// Token: 0x0400DBB9 RID: 56249
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/TsSimpleNpc.TsSimpleNpc_C";

	// Token: 0x0400DBBA RID: 56250
	private static IntPtr _ClassPtr;

	// Token: 0x0400DBBB RID: 56251
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400DBBC RID: 56252
	private static int __PropertyOffset_CapsuleCollision;

	// Token: 0x0400DBBD RID: 56253
	private static int __PropertyOffset_Mesh;

	// Token: 0x0400DBBE RID: 56254
	private static int __PropertyOffset_CharRenderingComponent;

	// Token: 0x0400DBBF RID: 56255
	private static int __PropertyOffset_DA;

	// Token: 0x0400DBC0 RID: 56256
	private FSoftObjectPath _DA;

	// Token: 0x0400DBC1 RID: 56257
	private static int __PropertyOffset_DisappearOnSunny;

	// Token: 0x0400DBC2 RID: 56258
	private static int __PropertyOffset_DisappearOnCloudy;

	// Token: 0x0400DBC3 RID: 56259
	private static int __PropertyOffset_DisappearOnRainy;

	// Token: 0x0400DBC4 RID: 56260
	private static int __PropertyOffset_DisappearOnThunderRain;

	// Token: 0x0400DBC5 RID: 56261
	private static int __PropertyOffset_DisappearOnSnowy;

	// Token: 0x0400DBC6 RID: 56262
	private static int __PropertyOffset_LodLevel;

	// Token: 0x0400DBC7 RID: 56263
	private static int __PropertyOffset_DebugDitherValue;

	// Token: 0x02009732 RID: 38706
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected new ref struct __ReceiveEndPlay_FunctionParams
	{
		// Token: 0x04030636 RID: 198198
		[FieldOffset(0)]
		public TEnumAsByte<EEndPlayReason> endPlayReason;
	}

	// Token: 0x02009733 RID: 38707
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __DebugSetNpcDitherValue_FunctionParams
	{
		// Token: 0x04030637 RID: 198199
		[FieldOffset(0)]
		public float value;
	}

	// Token: 0x02009734 RID: 38708
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ShowDialog_FunctionParams
	{
		// Token: 0x04030638 RID: 198200
		[FieldOffset(0)]
		public FString text;

		// Token: 0x04030639 RID: 198201
		[FieldOffset(16)]
		public float removeSeconds;
	}

	// Token: 0x02009735 RID: 38709
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TryPlayMontage_FunctionParams
	{
		// Token: 0x0403063A RID: 198202
		[FieldOffset(0)]
		public FString montagePath;

		// Token: 0x0403063B RID: 198203
		[FieldOffset(16)]
		public bool __Result;
	}
}
