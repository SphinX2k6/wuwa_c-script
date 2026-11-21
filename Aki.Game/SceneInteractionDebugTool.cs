using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029FB RID: 10747
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Interaction/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Interaction/SceneInteractionDebugTool.SceneInteractionDebugTool_C")]
public class SceneInteractionDebugTool : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BBB RID: 11195
	// (get) Token: 0x0601AF67 RID: 110439 RVA: 0x00846B48 File Offset: 0x00844D48
	// (set) Token: 0x0601AF68 RID: 110440 RVA: 0x00846B81 File Offset: 0x00844D81
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public SWaterEffectObject Config
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			SWaterEffectObject result;
			if ((result = this._Config) == null)
			{
				result = (this._Config = new SWaterEffectObject(base.NativePtr + (IntPtr)SceneInteractionDebugTool.__PropertyOffset_Config, this));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SWaterEffectObject.StaticStruct(), base.NativePtr + (IntPtr)SceneInteractionDebugTool.__PropertyOffset_Config, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002BBC RID: 11196
	// (get) Token: 0x0601AF69 RID: 110441 RVA: 0x00846BA9 File Offset: 0x00844DA9
	// (set) Token: 0x0601AF6A RID: 110442 RVA: 0x00846BBD File Offset: 0x00844DBD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor TargetActor
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionDebugTool.__PropertyOffset_TargetActor);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionDebugTool.__PropertyOffset_TargetActor, value);
		}
	}

	// Token: 0x17002BBD RID: 11197
	// (get) Token: 0x0601AF6B RID: 110443 RVA: 0x00846BD2 File Offset: 0x00844DD2
	// (set) Token: 0x0601AF6C RID: 110444 RVA: 0x00846BDA File Offset: 0x00844DDA
	private SceneObjectWaterEffect Interaction { get; set; }

	// Token: 0x0601AF6D RID: 110445 RVA: 0x00846BE4 File Offset: 0x00844DE4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void AttachInteraction()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugTool) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AttachInteraction"), SceneInteractionDebugTool.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AttachInteraction_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AF6E RID: 110446 RVA: 0x00846C40 File Offset: 0x00844E40
	protected void AttachInteraction_Implementation()
	{
		if (this.TargetActor == null)
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.LSY, "SceneInteractionDebugTool缺少目标对象", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (this.Interaction != null)
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.LSY, "SceneInteractionDebugTool勿重复添加", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.Interaction = new SceneObjectWaterEffect();
		this.Interaction.Start(this.Config, this.TargetActor.K2_GetRootComponent());
		SceneInteractionManager.Get().RegisterWaterEffectObject(this.Interaction);
	}

	// Token: 0x0601AF6F RID: 110447 RVA: 0x00846CCC File Offset: 0x00844ECC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void RemoveInteraction()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(SceneInteractionDebugTool) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveInteraction"), SceneInteractionDebugTool.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.RemoveInteraction_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AF70 RID: 110448 RVA: 0x00846D25 File Offset: 0x00844F25
	protected void RemoveInteraction_Implementation()
	{
		if (this.Interaction == null)
		{
			return;
		}
		SceneInteractionManager.Get().UnregisterWaterEffectObject(this.Interaction);
		this.Interaction = null;
	}

	// Token: 0x0601AF71 RID: 110449 RVA: 0x00846D47 File Offset: 0x00844F47
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SceneInteractionDebugTool._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Interaction/SceneInteractionDebugTool.SceneInteractionDebugTool_C");
		}
		return SceneInteractionDebugTool._ClassPtr;
	}

	// Token: 0x0601AF72 RID: 110450 RVA: 0x00846D6C File Offset: 0x00844F6C
	public SceneInteractionDebugTool() : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugTool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AF73 RID: 110451 RVA: 0x00846D94 File Offset: 0x00844F94
	[NullableContext(1)]
	public SceneInteractionDebugTool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AF74 RID: 110452 RVA: 0x00846DC7 File Offset: 0x00844FC7
	protected SceneInteractionDebugTool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17002BBE RID: 11198
	// (get) Token: 0x0601AF75 RID: 110453 RVA: 0x00846DD0 File Offset: 0x00844FD0
	public unsafe USceneComponent DefaultSceneRoot
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionDebugTool.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0601AF76 RID: 110454 RVA: 0x00846DE4 File Offset: 0x00844FE4
	protected virtual void __CPPCALL_AttachInteraction_Implementation()
	{
		this.AttachInteraction_Implementation();
	}

	// Token: 0x0601AF77 RID: 110455 RVA: 0x00846DEC File Offset: 0x00844FEC
	protected virtual void __CPPCALL_RemoveInteraction_Implementation()
	{
		this.RemoveInteraction_Implementation();
	}

	// Token: 0x0400EA66 RID: 60006
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Interaction/SceneInteractionDebugTool.SceneInteractionDebugTool_C";

	// Token: 0x0400EA67 RID: 60007
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA68 RID: 60008
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400EA69 RID: 60009
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400EA6A RID: 60010
	private static int __PropertyOffset_Config;

	// Token: 0x0400EA6B RID: 60011
	private SWaterEffectObject _Config;

	// Token: 0x0400EA6C RID: 60012
	private static int __PropertyOffset_TargetActor;
}
