using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiComponent.UiHomeButton;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020021B2 RID: 8626
[UClass("/Game/Aki/TypeScript/Game/Module/UiComponent/UiHomeButton/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiComponent/UiHomeButton/TsUiHomeHelper.TsUiHomeHelper_C")]
public class TsUiHomeHelper : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x060153A8 RID: 86952 RVA: 0x0062C38C File Offset: 0x0062A58C
	public void CreateHomeBtn(int homeBtnStyle, bool snapSize = false)
	{
		if (this.HasCreate)
		{
			Log.Instance.Error(ELogModule.HomeBtn, ELogAuthor.CB, "Home键被重复创建", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.CreateHomeBtnAsync(homeBtnStyle, snapSize).Forget();
	}

	// Token: 0x060153A9 RID: 86953 RVA: 0x0062C3D0 File Offset: 0x0062A5D0
	private UniTask CreateHomeBtnAsync(int homeBtnStyle, bool snapSize = false)
	{
		TsUiHomeHelper.<CreateHomeBtnAsync>d__3 <CreateHomeBtnAsync>d__;
		<CreateHomeBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateHomeBtnAsync>d__.<>4__this = this;
		<CreateHomeBtnAsync>d__.homeBtnStyle = homeBtnStyle;
		<CreateHomeBtnAsync>d__.snapSize = snapSize;
		<CreateHomeBtnAsync>d__.<>1__state = -1;
		<CreateHomeBtnAsync>d__.<>t__builder.Start<TsUiHomeHelper.<CreateHomeBtnAsync>d__3>(ref <CreateHomeBtnAsync>d__);
		return <CreateHomeBtnAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060153AA RID: 86954 RVA: 0x0062C423 File Offset: 0x0062A623
	private void OnBtnClick()
	{
		HomeBtnController.Instance.ExecuteBtnClick();
	}

	// Token: 0x060153AB RID: 86955 RVA: 0x0062C42F File Offset: 0x0062A62F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiHomeHelper._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiComponent/UiHomeButton/TsUiHomeHelper.TsUiHomeHelper_C");
		}
		return TsUiHomeHelper._ClassPtr;
	}

	// Token: 0x060153AC RID: 86956 RVA: 0x0062C454 File Offset: 0x0062A654
	public TsUiHomeHelper() : this(BuiltinUtils.AllocNativeUObject(TsUiHomeHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060153AD RID: 86957 RVA: 0x0062C47C File Offset: 0x0062A67C
	[NullableContext(1)]
	public TsUiHomeHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHomeHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060153AE RID: 86958 RVA: 0x0062C4AF File Offset: 0x0062A6AF
	protected TsUiHomeHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B3FC RID: 46076
	private bool HasCreate;

	// Token: 0x0400B3FD RID: 46077
	[Nullable(2)]
	private HomeBtnItem HomeBtnItem;

	// Token: 0x0400B3FE RID: 46078
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiComponent/UiHomeButton/TsUiHomeHelper.TsUiHomeHelper_C";

	// Token: 0x0400B3FF RID: 46079
	private static IntPtr _ClassPtr;

	// Token: 0x0400B400 RID: 46080
	private static IntPtr _ClassDefaultObjectPtr;
}
