using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui.Splash;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200000E RID: 14
[UClass("/Game/Aki/TypeScript/Launcher/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Launcher/TsSplash.TsSplash_C")]
public class TsSplash : UObject, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000078 RID: 120 RVA: 0x00006969 File Offset: 0x00004B69
	static TsSplash()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsSplash.CreateStaticDefaultValue), new Action(TsSplash.ResetStaticDefaultValue));
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00006988 File Offset: 0x00004B88
	public static void CreateStaticDefaultValue()
	{
		TsSplash.CurrentPhase = SplashPhase.SplashPhaseOne;
		TsSplash.WorldContext = null;
		TsSplash.KuroSplashVideo = null;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0000699C File Offset: 0x00004B9C
	public static void ResetStaticDefaultValue()
	{
		TsSplash.CurrentPhase = SplashPhase.SplashPhaseOne;
		TsSplash.WorldContext = null;
		TsSplash.KuroSplashVideo = null;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x000069B0 File Offset: 0x00004BB0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public void Init(UObject worldContext)
	{
		if (UKismetSystemLibrary.GetCommandLine().Contains("-SkipSplash"))
		{
			UGameplayStatics.OpenLevel(worldContext, new FName("/Game/Aki/Map/Launch/Bootstrap"), true, "");
			return;
		}
		TsSplash.WorldContext = worldContext;
		TsSplash.DoInit(worldContext);
		worldContext.GetWorld().AuthorityGameMode.bUseSeamlessTravel = true;
		this.ShowSplashView();
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00006A08 File Offset: 0x00004C08
	[UFunction(EFunctionFlags.FUNC_None)]
	public float GetDelay()
	{
		return 0f;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00006A10 File Offset: 0x00004C10
	[UFunction(EFunctionFlags.FUNC_None)]
	private void ChangeToPhaseOne()
	{
		if (!SplashRegionBlockLib.ShouldBlockPhaseOne())
		{
			TsSplash.CurrentPhase = SplashPhase.SplashPhaseOne;
			TsSplash.KuroSplashVideo.PlayAnimationLogo(delegate
			{
				if (LauncherLanguageLib.Instance.GetPackageLanguage() == "ko")
				{
					this.ChangeToPhaseSpecial();
					return;
				}
				this.ChangeToPhaseThree();
			});
			return;
		}
		if (LauncherLanguageLib.Instance.GetPackageLanguage() == "ko")
		{
			this.ChangeToPhaseSpecial();
			return;
		}
		this.ChangeToPhaseThree();
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00006A64 File Offset: 0x00004C64
	[UFunction(EFunctionFlags.FUNC_None)]
	private void ChangeToPhaseSpecial()
	{
		TsSplash.CurrentPhase = SplashPhase.SplashPhaseSpecial;
		TsSplash.KuroSplashVideo.PlayPreventAddictionAnimation(new Action(this.ChangeToPhaseThree));
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00006A82 File Offset: 0x00004C82
	[UFunction(EFunctionFlags.FUNC_None)]
	private void ChangeToPhaseThree()
	{
		TsSplash.CurrentPhase = SplashPhase.SplashPhaseThree;
		TsSplash.KuroSplashVideo.PlayCautionAnimation(new Action(this.ChangeScene));
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00006AA0 File Offset: 0x00004CA0
	[UFunction(EFunctionFlags.FUNC_None)]
	public void ShowSplashView()
	{
		TsSplash.KuroSplashVideo = new SplashUiView();
		this.<ShowSplashView>g__InitAndPrepareAsync|11_0();
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00006AB3 File Offset: 0x00004CB3
	[UFunction(EFunctionFlags.FUNC_None)]
	public void ChangeScene()
	{
		TsSplash.KuroSplashVideo.StopCurrentAnimation();
		TsSplash.KuroSplashVideo.Destroy();
		UGameplayStatics.OpenLevel(TsSplash.WorldContext, new FName("/Game/Aki/Map/Launch/Bootstrap"), true, "");
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00006AE4 File Offset: 0x00004CE4
	[NullableContext(1)]
	private static void DoInit(UObject worldContext)
	{
		AppUtil.SetWorldContext(worldContext);
		CloudGameManagerLauncher.Instance.Init();
		LauncherStorageLib.Instance.Initialize();
		LauncherResourceLib.Instance.Initialize();
		LauncherConfigLib.Instance.Initialize();
		LauncherLanguageLib.Instance.Initialize(UKuroStaticLibrary.IsEditor(worldContext));
		LauncherGameSettingLib.Instance.Initialize();
		SplashRegionBlockLib.Initialize();
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00006B3E File Offset: 0x00004D3E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSplash._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Launcher/TsSplash.TsSplash_C");
		}
		return TsSplash._ClassPtr;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00006B64 File Offset: 0x00004D64
	public TsSplash() : this(BuiltinUtils.AllocNativeUObject(TsSplash.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00006B8C File Offset: 0x00004D8C
	[NullableContext(1)]
	public TsSplash(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSplash.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00006BBF File Offset: 0x00004DBF
	protected TsSplash(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00006BC8 File Offset: 0x00004DC8
	protected unsafe virtual void __CPPCALL_Init_Implementation(TsSplash.__Init_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->worldContext);
		this.Init(orCreateUObjectByNativePointer);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00006BE8 File Offset: 0x00004DE8
	protected unsafe virtual void __CPPCALL_GetDelay_Implementation(TsSplash.__GetDelay_FunctionParams* __Params)
	{
		__Params->__Result = this.GetDelay();
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00006BF6 File Offset: 0x00004DF6
	protected virtual void __CPPCALL_ChangeToPhaseOne_Implementation()
	{
		this.ChangeToPhaseOne();
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00006BFE File Offset: 0x00004DFE
	protected virtual void __CPPCALL_ChangeToPhaseSpecial_Implementation()
	{
		this.ChangeToPhaseSpecial();
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00006C06 File Offset: 0x00004E06
	protected virtual void __CPPCALL_ChangeToPhaseThree_Implementation()
	{
		this.ChangeToPhaseThree();
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00006C0E File Offset: 0x00004E0E
	protected virtual void __CPPCALL_ShowSplashView_Implementation()
	{
		this.ShowSplashView();
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00006C16 File Offset: 0x00004E16
	protected virtual void __CPPCALL_ChangeScene_Implementation()
	{
		this.ChangeScene();
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00006C44 File Offset: 0x00004E44
	[CompilerGenerated]
	private UniTask <ShowSplashView>g__InitAndPrepareAsync|11_0()
	{
		TsSplash.<<ShowSplashView>g__InitAndPrepareAsync|11_0>d <<ShowSplashView>g__InitAndPrepareAsync|11_0>d;
		<<ShowSplashView>g__InitAndPrepareAsync|11_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<<ShowSplashView>g__InitAndPrepareAsync|11_0>d.<>4__this = this;
		<<ShowSplashView>g__InitAndPrepareAsync|11_0>d.<>1__state = -1;
		<<ShowSplashView>g__InitAndPrepareAsync|11_0>d.<>t__builder.Start<TsSplash.<<ShowSplashView>g__InitAndPrepareAsync|11_0>d>(ref <<ShowSplashView>g__InitAndPrepareAsync|11_0>d);
		return <<ShowSplashView>g__InitAndPrepareAsync|11_0>d.<>t__builder.Task;
	}

	// Token: 0x04000049 RID: 73
	public static SplashPhase CurrentPhase;

	// Token: 0x0400004A RID: 74
	[Nullable(2)]
	public static UObject WorldContext;

	// Token: 0x0400004B RID: 75
	[Nullable(2)]
	private static SplashUiView KuroSplashVideo;

	// Token: 0x0400004C RID: 76
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Launcher/TsSplash.TsSplash_C";

	// Token: 0x0400004D RID: 77
	private static IntPtr _ClassPtr;

	// Token: 0x0400004E RID: 78
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02000283 RID: 643
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __Init_FunctionParams
	{
		// Token: 0x04000A37 RID: 2615
		[FieldOffset(0)]
		public IntPtr worldContext;
	}

	// Token: 0x02000284 RID: 644
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetDelay_FunctionParams
	{
		// Token: 0x04000A38 RID: 2616
		[FieldOffset(0)]
		public float __Result;
	}
}
