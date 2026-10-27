using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000256 RID: 598
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Controller/TsActionHandle.TsActionHandle_C")]
public class TsActionHandle : UObject, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000593 RID: 1427
	// (get) Token: 0x06002465 RID: 9317 RVA: 0x000DDBFE File Offset: 0x000DBDFE
	// (set) Token: 0x06002466 RID: 9318 RVA: 0x000DDC12 File Offset: 0x000DBE12
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe TsBasePlayerController PlayerController
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<TsBasePlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + TsActionHandle.__PropertyOffset_PlayerController);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsActionHandle.__PropertyOffset_PlayerController, value);
		}
	}

	// Token: 0x17000594 RID: 1428
	// (get) Token: 0x06002467 RID: 9319 RVA: 0x000DDC27 File Offset: 0x000DBE27
	// (set) Token: 0x06002468 RID: 9320 RVA: 0x000DDC3B File Offset: 0x000DBE3B
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe string ActionName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsActionHandle.__PropertyOffset_ActionName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsActionHandle.__PropertyOffset_ActionName)), value);
		}
	}

	// Token: 0x06002469 RID: 9321 RVA: 0x000DDC50 File Offset: 0x000DBE50
	public void Initialize(TsBasePlayerController playerController)
	{
		this.PlayerController = playerController;
		this.OnPressStat = Stat.Create("TsActionHandle.OnPressAction", "", "STATGROUP_KuroBattle");
		this.OnReleaseStat = Stat.Create("TsActionHandle.OnReleaseAction", "", "STATGROUP_KuroBattle");
	}

	// Token: 0x0600246A RID: 9322 RVA: 0x000DDC8D File Offset: 0x000DBE8D
	public void Reset()
	{
		this.PlayerController = null;
		this.ActionName = string.Empty;
		this.OnInputActionCallback = null;
	}

	// Token: 0x0600246B RID: 9323 RVA: 0x000DDCA8 File Offset: 0x000DBEA8
	public void AddActionBinding(string actionName, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Action<string, bool, FKey> onInputAction)
	{
		if (onInputAction == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Controller;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加Action输入绑定时，回调不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.ActionName = actionName;
		this.OnInputActionCallback = onInputAction;
		FName? dynamicFName = FNameUtil.GetDynamicFName(actionName);
		if (dynamicFName == null)
		{
			return;
		}
		TsBasePlayerController playerController = this.PlayerController;
		FName value;
		FName fname;
		if (playerController != null)
		{
			value = dynamicFName.Value;
			EInputEvent keyEvent = EInputEvent.IE_Pressed;
			fname = new FName("OnPressAction");
			playerController.AddActionBinding(value, keyEvent, this, fname);
		}
		TsBasePlayerController playerController2 = this.PlayerController;
		if (playerController2 == null)
		{
			return;
		}
		value = dynamicFName.Value;
		EInputEvent keyEvent2 = EInputEvent.IE_Released;
		fname = new FName("OnReleaseAction");
		playerController2.AddActionBinding(value, keyEvent2, this, fname);
	}

	// Token: 0x0600246C RID: 9324 RVA: 0x000DDD58 File Offset: 0x000DBF58
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnPressAction(FKey key)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnPressAction"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsActionHandle.__OnPressAction_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsActionHandle.__OnPressAction_FunctionParams*)ptr + 15L / (long)sizeof(TsActionHandle.__OnPressAction_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr2->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0600246D RID: 9325 RVA: 0x000DDDE7 File Offset: 0x000DBFE7
	protected void OnPressAction_Implementation(FKey key)
	{
		Action<string, bool, FKey> onInputActionCallback = this.OnInputActionCallback;
		if (onInputActionCallback == null)
		{
			return;
		}
		onInputActionCallback(this.ActionName, true, key);
	}

	// Token: 0x0600246E RID: 9326 RVA: 0x000DDE04 File Offset: 0x000DC004
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnReleaseAction(FKey key)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnReleaseAction"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsActionHandle.__OnReleaseAction_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsActionHandle.__OnReleaseAction_FunctionParams*)ptr + 15L / (long)sizeof(TsActionHandle.__OnReleaseAction_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr2->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0600246F RID: 9327 RVA: 0x000DDE93 File Offset: 0x000DC093
	protected void OnReleaseAction_Implementation(FKey key)
	{
		Action<string, bool, FKey> onInputActionCallback = this.OnInputActionCallback;
		if (onInputActionCallback == null)
		{
			return;
		}
		onInputActionCallback(this.ActionName, false, key);
	}

	// Token: 0x06002470 RID: 9328 RVA: 0x000DDEAD File Offset: 0x000DC0AD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsActionHandle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Controller/TsActionHandle.TsActionHandle_C");
		}
		return TsActionHandle._ClassPtr;
	}

	// Token: 0x06002471 RID: 9329 RVA: 0x000DDED4 File Offset: 0x000DC0D4
	public TsActionHandle() : this(BuiltinUtils.AllocNativeUObject(TsActionHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002472 RID: 9330 RVA: 0x000DDEFC File Offset: 0x000DC0FC
	public TsActionHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsActionHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002473 RID: 9331 RVA: 0x000DDF2F File Offset: 0x000DC12F
	protected TsActionHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06002474 RID: 9332 RVA: 0x000DDF38 File Offset: 0x000DC138
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnPressAction_Implementation(TsActionHandle.__OnPressAction_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		this.OnPressAction_Implementation(key);
	}

	// Token: 0x06002475 RID: 9333 RVA: 0x000DDF5C File Offset: 0x000DC15C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnReleaseAction_Implementation(TsActionHandle.__OnReleaseAction_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		this.OnReleaseAction_Implementation(key);
	}

	// Token: 0x040023D4 RID: 9172
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<string, bool, FKey> OnInputActionCallback;

	// Token: 0x040023D5 RID: 9173
	[Nullable(2)]
	private Stat OnPressStat;

	// Token: 0x040023D6 RID: 9174
	[Nullable(2)]
	private Stat OnReleaseStat;

	// Token: 0x040023D7 RID: 9175
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Controller/TsActionHandle.TsActionHandle_C";

	// Token: 0x040023D8 RID: 9176
	private static IntPtr _ClassPtr;

	// Token: 0x040023D9 RID: 9177
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040023DA RID: 9178
	private static int __PropertyOffset_PlayerController;

	// Token: 0x040023DB RID: 9179
	private static int __PropertyOffset_ActionName;

	// Token: 0x02007443 RID: 29763
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OnPressAction_FunctionParams
	{
		// Token: 0x0402682B RID: 157739
		[FieldOffset(0)]
		public byte key;
	}

	// Token: 0x02007444 RID: 29764
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OnReleaseAction_FunctionParams
	{
		// Token: 0x0402682C RID: 157740
		[FieldOffset(0)]
		public byte key;
	}
}
