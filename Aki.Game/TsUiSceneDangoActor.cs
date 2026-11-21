using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020021B0 RID: 8624
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiComponent/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneDangoActor.TsUiSceneDangoActor_C")]
public class TsUiSceneDangoActor : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002023 RID: 8227
	// (get) Token: 0x06015387 RID: 86919 RVA: 0x0062BE34 File Offset: 0x0062A034
	// (set) Token: 0x06015388 RID: 86920 RVA: 0x0062BE3C File Offset: 0x0062A03C
	public UiModelBase Model { get; private set; }

	// Token: 0x17002024 RID: 8228
	// (get) Token: 0x06015389 RID: 86921 RVA: 0x0062BE45 File Offset: 0x0062A045
	// (set) Token: 0x0601538A RID: 86922 RVA: 0x0062BE4D File Offset: 0x0062A04D
	private int ActorIndex { get; set; }

	// Token: 0x0601538B RID: 86923 RVA: 0x0062BE58 File Offset: 0x0062A058
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

	// Token: 0x0601538C RID: 86924 RVA: 0x0062BECC File Offset: 0x0062A0CC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiSceneDangoActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), TsUiSceneDangoActor.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601538D RID: 86925 RVA: 0x0062BF58 File Offset: 0x0062A158
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		UiModelBase model = this.Model;
		if (model == null)
		{
			return;
		}
		model.Tick(deltaSeconds);
	}

	// Token: 0x0601538E RID: 86926 RVA: 0x0062BF6B File Offset: 0x0062A16B
	public int GetActorIndex()
	{
		return this.ActorIndex;
	}

	// Token: 0x0601538F RID: 86927 RVA: 0x0062BF73 File Offset: 0x0062A173
	public void SetState(EDangoState state, float stateParam = 0f, float stateParam2 = 0f)
	{
		UiDangoStateMachineComponent stateMachine = this.GetStateMachine();
		if (stateMachine == null)
		{
			return;
		}
		stateMachine.SetState(state, stateParam, stateParam2);
	}

	// Token: 0x06015390 RID: 86928 RVA: 0x0062BF88 File Offset: 0x0062A188
	public UiDangoStateMachineComponent GetStateMachine()
	{
		UiModelBase model = this.Model;
		if (model == null)
		{
			return null;
		}
		return model.CheckGetComponent<UiDangoStateMachineComponent>();
	}

	// Token: 0x06015391 RID: 86929 RVA: 0x0062BF9C File Offset: 0x0062A19C
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

	// Token: 0x06015392 RID: 86930 RVA: 0x0062BFEB File Offset: 0x0062A1EB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiSceneDangoActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneDangoActor.TsUiSceneDangoActor_C");
		}
		return TsUiSceneDangoActor._ClassPtr;
	}

	// Token: 0x06015393 RID: 86931 RVA: 0x0062C010 File Offset: 0x0062A210
	public TsUiSceneDangoActor() : this(BuiltinUtils.AllocNativeUObject(TsUiSceneDangoActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06015394 RID: 86932 RVA: 0x0062C038 File Offset: 0x0062A238
	public TsUiSceneDangoActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiSceneDangoActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06015395 RID: 86933 RVA: 0x0062C06B File Offset: 0x0062A26B
	protected TsUiSceneDangoActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17002025 RID: 8229
	// (get) Token: 0x06015396 RID: 86934 RVA: 0x0062C074 File Offset: 0x0062A274
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiSceneDangoActor.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x06015397 RID: 86935 RVA: 0x0062C088 File Offset: 0x0062A288
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0400B3F1 RID: 46065
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneDangoActor.TsUiSceneDangoActor_C";

	// Token: 0x0400B3F2 RID: 46066
	private static IntPtr _ClassPtr;

	// Token: 0x0400B3F3 RID: 46067
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B3F4 RID: 46068
	private static int __PropertyOffset_DefaultSceneRoot;
}
