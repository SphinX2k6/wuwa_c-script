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

// Token: 0x02002C59 RID: 11353
[UClass("/Game/Aki/TypeScript/Game/Module/UiComponent/UiHomeButton/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiComponent/UiHomeButton/TsUiHomeHelper.TsUiHomeHelper_C")]
public class TsUiHomeHelper : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x06017B34 RID: 97076 RVA: 0x006068C8 File Offset: 0x00604AC8
	public void CreateHomeBtn(int homeBtnStyle, bool snapSize = false)
	{
		if (this.HasCreate)
		{
			Log.Instance.Error(ELogModule.HomeBtn, ELogAuthor.CB, "Home键被重复创建", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.CreateHomeBtnAsync(homeBtnStyle, snapSize).Forget();
	}

	// Token: 0x06017B35 RID: 97077 RVA: 0x0060690C File Offset: 0x00604B0C
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

	// Token: 0x06017B36 RID: 97078 RVA: 0x0060695F File Offset: 0x00604B5F
	private void OnBtnClick()
	{
		HomeBtnController.Instance.ExecuteBtnClick();
	}

	// Token: 0x06017B37 RID: 97079 RVA: 0x0060696B File Offset: 0x00604B6B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiHomeHelper._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiComponent/UiHomeButton/TsUiHomeHelper.TsUiHomeHelper_C");
		}
		return TsUiHomeHelper._ClassPtr;
	}

	// Token: 0x06017B38 RID: 97080 RVA: 0x00606990 File Offset: 0x00604B90
	public TsUiHomeHelper() : this(BuiltinUtils.AllocNativeUObject(TsUiHomeHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06017B39 RID: 97081 RVA: 0x006069B8 File Offset: 0x00604BB8
	[NullableContext(1)]
	public TsUiHomeHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHomeHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06017B3A RID: 97082 RVA: 0x006069EB File Offset: 0x00604BEB
	protected TsUiHomeHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B090 RID: 45200
	private bool HasCreate;

	// Token: 0x0400B091 RID: 45201
	[Nullable(2)]
	private HomeBtnItem HomeBtnItem;

	// Token: 0x0400B092 RID: 45202
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiComponent/UiHomeButton/TsUiHomeHelper.TsUiHomeHelper_C";

	// Token: 0x0400B093 RID: 45203
	private static IntPtr _ClassPtr;

	// Token: 0x0400B094 RID: 45204
	private static IntPtr _ClassDefaultObjectPtr;
}
