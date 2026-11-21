using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.InputSetting;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200025E RID: 606
[UClass("/Game/Aki/TypeScript/Game/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Controller/TsStartupPlayerController.TsStartupPlayerController_C")]
public class TsStartupPlayerController : TsBasePlayerController, IUnrealUObject, IUnrealObject
{
	// Token: 0x060025BE RID: 9662 RVA: 0x000E65D8 File Offset: 0x000E47D8
	protected override void BindActionHandle()
	{
		base.BindActionHandle();
		foreach (ActionMapping actionMapping in InputSettingsConfig.Instance.GetAllActionMappingConfig())
		{
			base.AddActionHandle(actionMapping.ActionName);
		}
	}

	// Token: 0x060025BF RID: 9663 RVA: 0x000E6638 File Offset: 0x000E4838
	protected override void BindAxisHandle()
	{
		base.BindAxisHandle();
		foreach (AxisMapping axisMapping in InputSettingsConfig.Instance.GetAllAxisMappingConfig())
		{
			this.AddAxisHandle(axisMapping.AxisName);
		}
	}

	// Token: 0x060025C0 RID: 9664 RVA: 0x000E6698 File Offset: 0x000E4898
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsStartupPlayerController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Controller/TsStartupPlayerController.TsStartupPlayerController_C");
		}
		return TsStartupPlayerController._ClassPtr;
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x000E66BC File Offset: 0x000E48BC
	public TsStartupPlayerController() : this(BuiltinUtils.AllocNativeUObject(TsStartupPlayerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060025C2 RID: 9666 RVA: 0x000E66E4 File Offset: 0x000E48E4
	[NullableContext(1)]
	public TsStartupPlayerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsStartupPlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060025C3 RID: 9667 RVA: 0x000E6717 File Offset: 0x000E4917
	protected TsStartupPlayerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400247B RID: 9339
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Controller/TsStartupPlayerController.TsStartupPlayerController_C";

	// Token: 0x0400247C RID: 9340
	private static IntPtr _ClassPtr;

	// Token: 0x0400247D RID: 9341
	private static IntPtr _ClassDefaultObjectPtr;
}
