using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002C57 RID: 11351
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiComponent/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneDangoActor.TsUiSceneDangoActor_C")]
public class TsUiSceneDangoActor : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17001FD0 RID: 8144
	// (get) Token: 0x06017B11 RID: 97041 RVA: 0x00606390 File Offset: 0x00604590
	// (set) Token: 0x06017B12 RID: 97042 RVA: 0x00606398 File Offset: 0x00604598
	public UiModelBase Model { get; private set; }

	// Token: 0x17001FD1 RID: 8145
	// (get) Token: 0x06017B13 RID: 97043 RVA: 0x006063A1 File Offset: 0x006045A1
	// (set) Token: 0x06017B14 RID: 97044 RVA: 0x006063A9 File Offset: 0x006045A9
	private int ActorIndex { get; set; }

	// Token: 0x06017B15 RID: 97045 RVA: 0x006063B4 File Offset: 0x006045B4
	public void Init(int actorIndex, int useWay)
	{
		this.ActorIndex = actorIndex;
		base.SetTickableWhenPaused(true);
		base.SetActorTickEnabled(true);
		base.CustomTimeDilation = CharacterModel.Instance.InverseSelfCenteredTimeDilation;
		UKuroRenderingRuntimeBPPluginBPLibrary.SetActorUISceneRendering(this, true);
		this.Model = UiModelSystem.Instance.CreateUiModelByUseWay((EUiModelUseWay)useWay, this);
		UiModelBase model = this.Model;
		if (model != null)
		{
			model.Init();
		}
		UiModelBase model2 = this.Model;
		if (model2 != null)
		{
			model2.Start();
		}
		base.SetPrimitiveEntityType(1U);
	}

	// Token: 0x06017B16 RID: 97046 RVA: 0x00606428 File Offset: 0x00604628
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

	// Token: 0x06017B17 RID: 97047 RVA: 0x0060649E File Offset: 0x0060469E
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		UiModelBase model = this.Model;
		if (model == null)
		{
			return;
		}
		model.Tick(deltaSeconds);
	}

	// Token: 0x06017B18 RID: 97048 RVA: 0x006064B1 File Offset: 0x006046B1
	public int GetActorIndex()
	{
		return this.ActorIndex;
	}

	// Token: 0x06017B19 RID: 97049 RVA: 0x006064B9 File Offset: 0x006046B9
	public void SetState(EDangoState state, float stateParam = 0f, float stateParam2 = 0f)
	{
		UiDangoStateMachineComponent stateMachine = this.GetStateMachine();
		if (stateMachine == null)
		{
			return;
		}
		stateMachine.SetState(state, stateParam, stateParam2);
	}

	// Token: 0x06017B1A RID: 97050 RVA: 0x006064CE File Offset: 0x006046CE
	public UiDangoStateMachineComponent GetStateMachine()
	{
		UiModelBase model = this.Model;
		if (model == null)
		{
			return null;
		}
		return model.CheckGetComponent<UiDangoStateMachineComponent>();
	}

	// Token: 0x06017B1B RID: 97051 RVA: 0x006064E4 File Offset: 0x006046E4
	public void Destroy()
	{
		UiModelBase model = this.Model;
		if (model != null)
		{
			model.End();
		}
		UiModelBase model2 = this.Model;
		if (model2 != null)
		{
			model2.Clear();
		}
		this.Model = null;
		this.ActorIndex = 0;
		ActorSystem.Instance.Put("TsUiSceneDangoActor.Destroy", this, null);
	}

	// Token: 0x06017B1C RID: 97052 RVA: 0x00606533 File Offset: 0x00604733
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiSceneDangoActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneDangoActor.TsUiSceneDangoActor_C");
		}
		return TsUiSceneDangoActor._ClassPtr;
	}

	// Token: 0x06017B1D RID: 97053 RVA: 0x00606558 File Offset: 0x00604758
	public TsUiSceneDangoActor() : this(BuiltinUtils.AllocNativeUObject(TsUiSceneDangoActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06017B1E RID: 97054 RVA: 0x00606580 File Offset: 0x00604780
	public TsUiSceneDangoActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiSceneDangoActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06017B1F RID: 97055 RVA: 0x006065B3 File Offset: 0x006047B3
	protected TsUiSceneDangoActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17001FD2 RID: 8146
	// (get) Token: 0x06017B20 RID: 97056 RVA: 0x006065BC File Offset: 0x006047BC
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiSceneDangoActor.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x17001FD3 RID: 8147
	// (get) Token: 0x06017B21 RID: 97057 RVA: 0x006065CC File Offset: 0x006047CC
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiSceneDangoActor.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x06017B22 RID: 97058 RVA: 0x006065E0 File Offset: 0x006047E0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0400B083 RID: 45187
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneDangoActor.TsUiSceneDangoActor_C";

	// Token: 0x0400B084 RID: 45188
	private static IntPtr _ClassPtr;

	// Token: 0x0400B085 RID: 45189
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B086 RID: 45190
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400B087 RID: 45191
	private static int __PropertyOffset_DefaultSceneRoot;
}
