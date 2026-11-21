using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002898 RID: 10392
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsRecordEffect.TsRecordEffect_C")]
public class TsRecordEffect : AKuroRecordEffect, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B31 RID: 11057
	// (get) Token: 0x0601A577 RID: 107895 RVA: 0x008269BA File Offset: 0x00824BBA
	// (set) Token: 0x0601A578 RID: 107896 RVA: 0x008269CE File Offset: 0x00824BCE
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

	// Token: 0x17002B32 RID: 11058
	// (get) Token: 0x0601A579 RID: 107897 RVA: 0x008269E3 File Offset: 0x00824BE3
	// (set) Token: 0x0601A57A RID: 107898 RVA: 0x008269F3 File Offset: 0x00824BF3
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

	// Token: 0x17002B33 RID: 11059
	// (get) Token: 0x0601A57B RID: 107899 RVA: 0x00826A04 File Offset: 0x00824C04
	// (set) Token: 0x0601A57C RID: 107900 RVA: 0x00826A18 File Offset: 0x00824C18
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

	// Token: 0x17002B34 RID: 11060
	// (get) Token: 0x0601A57D RID: 107901 RVA: 0x00826A2D File Offset: 0x00824C2D
	// (set) Token: 0x0601A57E RID: 107902 RVA: 0x00826A3D File Offset: 0x00824C3D
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

	// Token: 0x0601A57F RID: 107903 RVA: 0x00826A50 File Offset: 0x00824C50
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsRecordEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsRecordEffect.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A580 RID: 107904 RVA: 0x00826AA9 File Offset: 0x00824CA9
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		base.SetActorTickEnabled(true);
	}

	// Token: 0x0601A581 RID: 107905 RVA: 0x00826AB4 File Offset: 0x00824CB4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsRecordEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsRecordEffect.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(endPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)endPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601A582 RID: 107906 RVA: 0x00826B44 File Offset: 0x00824D44
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason endPlayReason)
	{
		if (!EffectSystem.Instance.IsValid(this.EffectHandle))
		{
			return;
		}
		EffectSystem.Instance.StopEffectById(this.EffectHandle, "[TsRecordEffect.ReceiveEndPlay]", true, null);
	}

	// Token: 0x0601A583 RID: 107907 RVA: 0x00826B84 File Offset: 0x00824D84
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float delta)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsRecordEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), TsRecordEffect.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTick_Implementation(delta);
			return;
		}
		AActor.__ReceiveTick_FunctionParams* ptr = stackalloc AActor.__ReceiveTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = delta;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601A584 RID: 107908 RVA: 0x00826C10 File Offset: 0x00824E10
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

	// Token: 0x0601A585 RID: 107909 RVA: 0x00826CC8 File Offset: 0x00824EC8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsRecordEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnPlay"), TsRecordEffect.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A586 RID: 107910 RVA: 0x00826D21 File Offset: 0x00824F21
	protected virtual void OnPlay_Implementation()
	{
		this.Playing = true;
		this.TryAddEffectView();
	}

	// Token: 0x0601A587 RID: 107911 RVA: 0x00826D30 File Offset: 0x00824F30
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnStop()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsRecordEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnStop"), TsRecordEffect.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnStop_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A588 RID: 107912 RVA: 0x00826D8C File Offset: 0x00824F8C
	protected virtual void OnStop_Implementation()
	{
		this.Playing = false;
		if (!EffectSystem.Instance.IsValid(this.EffectHandle))
		{
			return;
		}
		EffectSystem.Instance.StopEffectById(this.EffectHandle, "[TsRecordEffect.OnStop]", false, null);
	}

	// Token: 0x0601A589 RID: 107913 RVA: 0x00826DD4 File Offset: 0x00824FD4
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

	// Token: 0x0601A58A RID: 107914 RVA: 0x00826F2F File Offset: 0x0082512F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsRecordEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsRecordEffect.TsRecordEffect_C");
		}
		return TsRecordEffect._ClassPtr;
	}

	// Token: 0x0601A58B RID: 107915 RVA: 0x00826F54 File Offset: 0x00825154
	public TsRecordEffect() : this(BuiltinUtils.AllocNativeUObject(TsRecordEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601A58C RID: 107916 RVA: 0x00826F7C File Offset: 0x0082517C
	[NullableContext(1)]
	public TsRecordEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsRecordEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601A58D RID: 107917 RVA: 0x00826FAF File Offset: 0x008251AF
	protected TsRecordEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601A58E RID: 107918 RVA: 0x00826FB8 File Offset: 0x008251B8
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601A58F RID: 107919 RVA: 0x00826FC0 File Offset: 0x008251C0
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601A590 RID: 107920 RVA: 0x00826FE0 File Offset: 0x008251E0
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601A591 RID: 107921 RVA: 0x00826FEE File Offset: 0x008251EE
	protected virtual void __CPPCALL_OnPlay_Implementation()
	{
		this.OnPlay_Implementation();
	}

	// Token: 0x0601A592 RID: 107922 RVA: 0x00826FF6 File Offset: 0x008251F6
	protected virtual void __CPPCALL_OnStop_Implementation()
	{
		this.OnStop_Implementation();
	}

	// Token: 0x0400E750 RID: 59216
	private int EffectHandle;

	// Token: 0x0400E751 RID: 59217
	private bool Playing;

	// Token: 0x0400E752 RID: 59218
	private bool LastHidden;

	// Token: 0x0400E753 RID: 59219
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsRecordEffect.TsRecordEffect_C";

	// Token: 0x0400E754 RID: 59220
	private static IntPtr _ClassPtr;

	// Token: 0x0400E755 RID: 59221
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E756 RID: 59222
	private static int __PropertyOffset_EffectModelDataPath;

	// Token: 0x0400E757 RID: 59223
	private static int __PropertyOffset_LifeTimeType;

	// Token: 0x0400E758 RID: 59224
	private static int __PropertyOffset_EffectModelData;

	// Token: 0x0400E759 RID: 59225
	private static int __PropertyOffset_ManualProcessTime;
}
