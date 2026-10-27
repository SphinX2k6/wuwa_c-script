using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003326 RID: 13094
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsRecordEffect.TsRecordEffect_C")]
public class TsRecordEffect : AKuroRecordEffect, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002795 RID: 10133
	// (get) Token: 0x0601C87F RID: 116863 RVA: 0x008003E2 File Offset: 0x007FE5E2
	// (set) Token: 0x0601C880 RID: 116864 RVA: 0x008003F6 File Offset: 0x007FE5F6
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string EffectModelDataPath
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsRecordEffect.__PropertyOffset_EffectModelDataPath)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsRecordEffect.__PropertyOffset_EffectModelDataPath)), value);
		}
	}

	// Token: 0x17002796 RID: 10134
	// (get) Token: 0x0601C881 RID: 116865 RVA: 0x0080040B File Offset: 0x007FE60B
	// (set) Token: 0x0601C882 RID: 116866 RVA: 0x0080041B File Offset: 0x007FE61B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int LifeTimeType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsRecordEffect.__PropertyOffset_LifeTimeType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsRecordEffect.__PropertyOffset_LifeTimeType) = value;
		}
	}

	// Token: 0x17002797 RID: 10135
	// (get) Token: 0x0601C883 RID: 116867 RVA: 0x0080042C File Offset: 0x007FE62C
	// (set) Token: 0x0601C884 RID: 116868 RVA: 0x00800440 File Offset: 0x007FE640
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UEffectModelBase EffectModelData
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + TsRecordEffect.__PropertyOffset_EffectModelData);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsRecordEffect.__PropertyOffset_EffectModelData, value);
		}
	}

	// Token: 0x17002798 RID: 10136
	// (get) Token: 0x0601C885 RID: 116869 RVA: 0x00800455 File Offset: 0x007FE655
	// (set) Token: 0x0601C886 RID: 116870 RVA: 0x00800465 File Offset: 0x007FE665
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ManualProcessTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsRecordEffect.__PropertyOffset_ManualProcessTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsRecordEffect.__PropertyOffset_ManualProcessTime) = value;
		}
	}

	// Token: 0x0601C887 RID: 116871 RVA: 0x00800478 File Offset: 0x007FE678
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

	// Token: 0x0601C888 RID: 116872 RVA: 0x008004E8 File Offset: 0x007FE6E8
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		base.SetActorTickEnabled(true);
	}

	// Token: 0x0601C889 RID: 116873 RVA: 0x008004F4 File Offset: 0x007FE6F4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->EndPlayReason) = (byte)endPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C88A RID: 116874 RVA: 0x00800570 File Offset: 0x007FE770
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason endPlayReason)
	{
		if (!EffectSystem.Instance.IsValid(this.EffectHandle))
		{
			return;
		}
		EffectSystem.Instance.StopEffectById(this.EffectHandle, "[TsRecordEffect.ReceiveEndPlay]", true, null);
	}

	// Token: 0x0601C88B RID: 116875 RVA: 0x008005B0 File Offset: 0x007FE7B0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float delta)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveTick_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = delta;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C88C RID: 116876 RVA: 0x00800628 File Offset: 0x007FE828
	protected virtual void ReceiveTick_Implementation(float delta)
	{
		if (this.Playing && this.EffectModelData == null && !string.IsNullOrEmpty(this.EffectModelDataPath))
		{
			this.TryAddEffectView();
		}
		if (this.EffectHandle != 0)
		{
			if (!Info.Instance.IsGameRunning())
			{
				EffectSystem.Instance.TickHandleInEditor(this.EffectHandle, delta);
			}
			if (this.LifeTimeType == 3 && this.ManualProcessTime > -1f)
			{
				EffectSystem.Instance.HandleSeekToTimeWithProcess(this.EffectHandle, this.ManualProcessTime, true, delta);
			}
			if (this.LastHidden != base.bHidden)
			{
				this.LastHidden = base.bHidden;
				EffectSystem.Instance.SetEffectHidden(this.EffectHandle, base.bHidden, null, false);
			}
		}
	}

	// Token: 0x0601C88D RID: 116877 RVA: 0x008006E0 File Offset: 0x007FE8E0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnPlay"), out num);
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

	// Token: 0x0601C88E RID: 116878 RVA: 0x00800750 File Offset: 0x007FE950
	protected virtual void OnPlay_Implementation()
	{
		this.Playing = true;
		this.TryAddEffectView();
	}

	// Token: 0x0601C88F RID: 116879 RVA: 0x00800760 File Offset: 0x007FE960
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnStop()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnStop"), out num);
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

	// Token: 0x0601C890 RID: 116880 RVA: 0x008007D0 File Offset: 0x007FE9D0
	protected virtual void OnStop_Implementation()
	{
		this.Playing = false;
		if (!EffectSystem.Instance.IsValid(this.EffectHandle))
		{
			return;
		}
		EffectSystem.Instance.StopEffectById(this.EffectHandle, "[TsRecordEffect.OnStop]", false, null);
	}

	// Token: 0x0601C891 RID: 116881 RVA: 0x00800818 File Offset: 0x007FEA18
	private unsafe void TryAddEffectView()
	{
		if (this.EffectModelData == null)
		{
			if (string.IsNullOrEmpty(this.EffectModelDataPath))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Recorder;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "No EffectModelData";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", this);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Recorder;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "No EffectModelData but TryLoad";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Path", this.EffectModelDataPath);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.EffectModelData = ResourceSystem.Instance.Load<UEffectModelBase>(this.EffectModelDataPath, "js_undefined");
		}
		if (this.EffectHandle != 0)
		{
			return;
		}
		string pathName = UKismetSystemLibrary.GetPathName(this.EffectModelData);
		FTransformDouble value = base.D_GetTransform();
		EffectSystem instance3 = EffectSystem.Instance;
		FTransformDouble? ftransformDouble = new FTransformDouble?(value);
		this.EffectHandle = instance3.SpawnEffect(this, ftransformDouble, pathName, "[TsRecordEffect.TryAddEffectView]", new EffectContext(null, this, false), EEffectType.Fight, delegate(int h)
		{
			if (this.LifeTimeType == 3)
			{
				EffectSystem.Instance.FreezeHandle(h, true, false);
			}
		}, null, null, false, false);
		if (!EffectSystem.Instance.IsValid(this.EffectHandle))
		{
			return;
		}
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.EffectHandle);
		FName? fname = null;
		effectActor.K2_AttachToActor(this, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
	}

	// Token: 0x0601C892 RID: 116882 RVA: 0x00800973 File Offset: 0x007FEB73
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsRecordEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsRecordEffect.TsRecordEffect_C");
		}
		return TsRecordEffect._ClassPtr;
	}

	// Token: 0x0601C893 RID: 116883 RVA: 0x00800998 File Offset: 0x007FEB98
	public TsRecordEffect() : this(BuiltinUtils.AllocNativeUObject(TsRecordEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C894 RID: 116884 RVA: 0x008009C0 File Offset: 0x007FEBC0
	[NullableContext(1)]
	public TsRecordEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C895 RID: 116885 RVA: 0x008009F3 File Offset: 0x007FEBF3
	protected TsRecordEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C896 RID: 116886 RVA: 0x008009FC File Offset: 0x007FEBFC
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C897 RID: 116887 RVA: 0x00800A04 File Offset: 0x007FEC04
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C898 RID: 116888 RVA: 0x00800A24 File Offset: 0x007FEC24
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C899 RID: 116889 RVA: 0x00800A32 File Offset: 0x007FEC32
	protected virtual void __CPPCALL_OnPlay_Implementation()
	{
		this.OnPlay_Implementation();
	}

	// Token: 0x0601C89A RID: 116890 RVA: 0x00800A3A File Offset: 0x007FEC3A
	protected virtual void __CPPCALL_OnStop_Implementation()
	{
		this.OnStop_Implementation();
	}

	// Token: 0x0400E2A0 RID: 58016
	private int EffectHandle;

	// Token: 0x0400E2A1 RID: 58017
	private bool Playing;

	// Token: 0x0400E2A2 RID: 58018
	private bool LastHidden;

	// Token: 0x0400E2A3 RID: 58019
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsRecordEffect.TsRecordEffect_C";

	// Token: 0x0400E2A4 RID: 58020
	private static IntPtr _ClassPtr;

	// Token: 0x0400E2A5 RID: 58021
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E2A6 RID: 58022
	private static int __PropertyOffset_EffectModelDataPath;

	// Token: 0x0400E2A7 RID: 58023
	private static int __PropertyOffset_LifeTimeType;

	// Token: 0x0400E2A8 RID: 58024
	private static int __PropertyOffset_EffectModelData;

	// Token: 0x0400E2A9 RID: 58025
	private static int __PropertyOffset_ManualProcessTime;
}
