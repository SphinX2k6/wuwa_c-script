using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002222 RID: 8738
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationTextChangeListener.TsUiNavigationTextChangeListener_C")]
public class TsUiNavigationTextChangeListener : UUINavigationTextChangeListener, IUnrealUObject, IUnrealObject
{
	// Token: 0x060158C1 RID: 88257 RVA: 0x006408AC File Offset: 0x0063EAAC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void AwakeBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationTextChangeListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AwakeBP"), TsUiNavigationTextChangeListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AwakeBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060158C2 RID: 88258 RVA: 0x00640905 File Offset: 0x0063EB05
	protected virtual void AwakeBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.Listener = (base.GetOwner().GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) as TsUiNavigationBehaviorListener);
	}

	// Token: 0x060158C3 RID: 88259 RVA: 0x00640930 File Offset: 0x0063EB30
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void StartBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationTextChangeListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("StartBP"), TsUiNavigationTextChangeListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.StartBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060158C4 RID: 88260 RVA: 0x00640989 File Offset: 0x0063EB89
	protected virtual void StartBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.NotifyDefaultText();
	}

	// Token: 0x060158C5 RID: 88261 RVA: 0x0064099C File Offset: 0x0063EB9C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnNotifyTextChangeBP(string NotifyText)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationTextChangeListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnNotifyTextChangeBP"), TsUiNavigationTextChangeListener.StaticClass(), out intPtr, out num))
		{
			this.OnNotifyTextChangeBP_Implementation(NotifyText);
			return;
		}
		UUINavigationTextChangeListener.__OnNotifyTextChangeBP_FunctionParams* ptr = stackalloc UUINavigationTextChangeListener.__OnNotifyTextChangeBP_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UUINavigationTextChangeListener.__OnNotifyTextChangeBP_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->NotifyText), NotifyText);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060158C6 RID: 88262 RVA: 0x00640A2E File Offset: 0x0063EC2E
	[NullableContext(1)]
	protected virtual void OnNotifyTextChangeBP_Implementation(string NotifyText)
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		if (this.Listener == null)
		{
			return;
		}
		this.Listener.NotifyTextChangeByComponent(NotifyText);
	}

	// Token: 0x060158C7 RID: 88263 RVA: 0x00640A50 File Offset: 0x0063EC50
	private void NotifyDefaultText()
	{
		if (this.Listener == null)
		{
			return;
		}
		if (base.TextActor == null)
		{
			return;
		}
		this.Text = (base.TextActor.GetComponentByClass(UUIText.StaticClass()) as UUIText);
		if (this.Text == null)
		{
			return;
		}
		this.Listener.NotifyTextChangeByComponent(this.Text.GetText());
	}

	// Token: 0x060158C8 RID: 88264 RVA: 0x00640AAE File Offset: 0x0063ECAE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiNavigationTextChangeListener._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationTextChangeListener.TsUiNavigationTextChangeListener_C");
		}
		return TsUiNavigationTextChangeListener._ClassPtr;
	}

	// Token: 0x060158C9 RID: 88265 RVA: 0x00640AD4 File Offset: 0x0063ECD4
	public TsUiNavigationTextChangeListener() : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationTextChangeListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060158CA RID: 88266 RVA: 0x00640AFC File Offset: 0x0063ECFC
	[NullableContext(1)]
	public TsUiNavigationTextChangeListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationTextChangeListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060158CB RID: 88267 RVA: 0x00640B2F File Offset: 0x0063ED2F
	protected TsUiNavigationTextChangeListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060158CC RID: 88268 RVA: 0x00640B38 File Offset: 0x0063ED38
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x060158CD RID: 88269 RVA: 0x00640B40 File Offset: 0x0063ED40
	protected virtual void __CPPCALL_StartBP_Implementation()
	{
		this.StartBP_Implementation();
	}

	// Token: 0x060158CE RID: 88270 RVA: 0x00640B48 File Offset: 0x0063ED48
	protected unsafe virtual void __CPPCALL_OnNotifyTextChangeBP_Implementation(UUINavigationTextChangeListener.__OnNotifyTextChangeBP_FunctionParams* __Params)
	{
		string notifyText = FString.ToString((void*)(&__Params->NotifyText));
		this.OnNotifyTextChangeBP_Implementation(notifyText);
	}

	// Token: 0x0400B64C RID: 46668
	[Nullable(2)]
	private TsUiNavigationBehaviorListener Listener;

	// Token: 0x0400B64D RID: 46669
	[Nullable(2)]
	public UUIText Text;

	// Token: 0x0400B64E RID: 46670
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationTextChangeListener.TsUiNavigationTextChangeListener_C";

	// Token: 0x0400B64F RID: 46671
	private static IntPtr _ClassPtr;

	// Token: 0x0400B650 RID: 46672
	private static IntPtr _ClassDefaultObjectPtr;
}
