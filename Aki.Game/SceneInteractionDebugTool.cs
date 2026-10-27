using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003487 RID: 13447
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Interaction/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Interaction/SceneInteractionDebugTool.SceneInteractionDebugTool_C")]
public class SceneInteractionDebugTool : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700281C RID: 10268
	// (get) Token: 0x0601D25F RID: 119391 RVA: 0x0081F818 File Offset: 0x0081DA18
	// (set) Token: 0x0601D260 RID: 119392 RVA: 0x0081F851 File Offset: 0x0081DA51
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

	// Token: 0x1700281D RID: 10269
	// (get) Token: 0x0601D261 RID: 119393 RVA: 0x0081F879 File Offset: 0x0081DA79
	// (set) Token: 0x0601D262 RID: 119394 RVA: 0x0081F88D File Offset: 0x0081DA8D
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

	// Token: 0x1700281E RID: 10270
	// (get) Token: 0x0601D263 RID: 119395 RVA: 0x0081F8A2 File Offset: 0x0081DAA2
	// (set) Token: 0x0601D264 RID: 119396 RVA: 0x0081F8AA File Offset: 0x0081DAAA
	private SceneObjectWaterEffect Interaction { get; set; }

	// Token: 0x0601D265 RID: 119397 RVA: 0x0081F8B4 File Offset: 0x0081DAB4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AttachInteraction()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AttachInteraction"), out num);
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

	// Token: 0x0601D266 RID: 119398 RVA: 0x0081F924 File Offset: 0x0081DB24
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

	// Token: 0x0601D267 RID: 119399 RVA: 0x0081F9B0 File Offset: 0x0081DBB0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveInteraction()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveInteraction"), out num);
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

	// Token: 0x0601D268 RID: 119400 RVA: 0x0081FA20 File Offset: 0x0081DC20
	protected void RemoveInteraction_Implementation()
	{
		if (this.Interaction == null)
		{
			return;
		}
		SceneInteractionManager.Get().UnregisterWaterEffectObject(this.Interaction);
		this.Interaction = null;
	}

	// Token: 0x0601D269 RID: 119401 RVA: 0x0081FA42 File Offset: 0x0081DC42
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SceneInteractionDebugTool._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Interaction/SceneInteractionDebugTool.SceneInteractionDebugTool_C");
		}
		return SceneInteractionDebugTool._ClassPtr;
	}

	// Token: 0x0601D26A RID: 119402 RVA: 0x0081FA68 File Offset: 0x0081DC68
	public SceneInteractionDebugTool() : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugTool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D26B RID: 119403 RVA: 0x0081FA90 File Offset: 0x0081DC90
	[NullableContext(1)]
	public SceneInteractionDebugTool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D26C RID: 119404 RVA: 0x0081FAC3 File Offset: 0x0081DCC3
	protected SceneInteractionDebugTool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x1700281F RID: 10271
	// (get) Token: 0x0601D26D RID: 119405 RVA: 0x0081FACC File Offset: 0x0081DCCC
	[Nullable(1)]
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		[NullableContext(1)]
		get
		{
			return *(base.NativePtr + (IntPtr)SceneInteractionDebugTool.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x17002820 RID: 10272
	// (get) Token: 0x0601D26E RID: 119406 RVA: 0x0081FADC File Offset: 0x0081DCDC
	public unsafe USceneComponent DefaultSceneRoot
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + SceneInteractionDebugTool.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0601D26F RID: 119407 RVA: 0x0081FAF0 File Offset: 0x0081DCF0
	protected virtual void __CPPCALL_AttachInteraction_Implementation()
	{
		this.AttachInteraction_Implementation();
	}

	// Token: 0x0601D270 RID: 119408 RVA: 0x0081FAF8 File Offset: 0x0081DCF8
	protected virtual void __CPPCALL_RemoveInteraction_Implementation()
	{
		this.RemoveInteraction_Implementation();
	}

	// Token: 0x0400E5AE RID: 58798
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Interaction/SceneInteractionDebugTool.SceneInteractionDebugTool_C";

	// Token: 0x0400E5AF RID: 58799
	private static IntPtr _ClassPtr;

	// Token: 0x0400E5B0 RID: 58800
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E5B1 RID: 58801
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400E5B2 RID: 58802
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400E5B3 RID: 58803
	private static int __PropertyOffset_Config;

	// Token: 0x0400E5B4 RID: 58804
	private SWaterEffectObject _Config;

	// Token: 0x0400E5B5 RID: 58805
	private static int __PropertyOffset_TargetActor;
}
