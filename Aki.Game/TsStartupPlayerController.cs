using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.InputSetting;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200025A RID: 602
[UClass("/Game/Aki/TypeScript/Game/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Controller/TsStartupPlayerController.TsStartupPlayerController_C")]
public class TsStartupPlayerController : TsBasePlayerController, IUnrealUObject, IUnrealObject
{
	// Token: 0x06002507 RID: 9479 RVA: 0x000E019C File Offset: 0x000DE39C
	protected override void BindActionHandle()
	{
		base.BindActionHandle();
		foreach (ActionMapping actionMapping in InputSettingsConfig.Instance.GetAllActionMappingConfig())
		{
			base.AddActionHandle(actionMapping.ActionName);
		}
	}

	// Token: 0x06002508 RID: 9480 RVA: 0x000E01FC File Offset: 0x000DE3FC
	protected override void BindAxisHandle()
	{
		base.BindAxisHandle();
		foreach (AxisMapping axisMapping in InputSettingsConfig.Instance.GetAllAxisMappingConfig())
		{
			this.AddAxisHandle(axisMapping.AxisName);
		}
	}

	// Token: 0x06002509 RID: 9481 RVA: 0x000E025C File Offset: 0x000DE45C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsStartupPlayerController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Controller/TsStartupPlayerController.TsStartupPlayerController_C");
		}
		return TsStartupPlayerController._ClassPtr;
	}

	// Token: 0x0600250A RID: 9482 RVA: 0x000E0280 File Offset: 0x000DE480
	public TsStartupPlayerController() : this(BuiltinUtils.AllocNativeUObject(TsStartupPlayerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600250B RID: 9483 RVA: 0x000E02A8 File Offset: 0x000DE4A8
	[NullableContext(1)]
	public TsStartupPlayerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsStartupPlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600250C RID: 9484 RVA: 0x000E02DB File Offset: 0x000DE4DB
	protected TsStartupPlayerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x040023FD RID: 9213
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Controller/TsStartupPlayerController.TsStartupPlayerController_C";

	// Token: 0x040023FE RID: 9214
	private static IntPtr _ClassPtr;

	// Token: 0x040023FF RID: 9215
	private static IntPtr _ClassDefaultObjectPtr;
}
