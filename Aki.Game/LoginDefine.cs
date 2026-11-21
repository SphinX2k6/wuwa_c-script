using System;
using System.Runtime.CompilerServices;

// Token: 0x0200155A RID: 5466
public class LoginDefine
{
	// Token: 0x040079FE RID: 31230
	[Nullable(1)]
	public const string DEFAULTPORT = "5500";

	// Token: 0x020077F1 RID: 30705
	public enum EAccountLoginMode
	{
		// Token: 0x04026EC3 RID: 159427
		NewAccount,
		// Token: 0x04026EC4 RID: 159428
		CopyAccount,
		// Token: 0x04026EC5 RID: 159429
		CopyAccountQuickFormation
	}

	// Token: 0x020077F2 RID: 30706
	public enum ELoginStatus
	{
		// Token: 0x04026EC7 RID: 159431
		Init,
		// Token: 0x04026EC8 RID: 159432
		LoginViewOpen,
		// Token: 0x04026EC9 RID: 159433
		SdkViewOpen,
		// Token: 0x04026ECA RID: 159434
		SdkLoginSuccecc,
		// Token: 0x04026ECB RID: 159435
		SdkLoginFail,
		// Token: 0x04026ECC RID: 159436
		LoginHttp,
		// Token: 0x04026ECD RID: 159437
		LoginHttpRet,
		// Token: 0x04026ECE RID: 159438
		ConvGate,
		// Token: 0x04026ECF RID: 159439
		ConvRet,
		// Token: 0x04026ED0 RID: 159440
		ProtoKeyReq,
		// Token: 0x04026ED1 RID: 159441
		ProtoKeyRet,
		// Token: 0x04026ED2 RID: 159442
		LoginReq,
		// Token: 0x04026ED3 RID: 159443
		LoginRet,
		// Token: 0x04026ED4 RID: 159444
		CreateReq,
		// Token: 0x04026ED5 RID: 159445
		CreateRet,
		// Token: 0x04026ED6 RID: 159446
		EnterGameReq,
		// Token: 0x04026ED7 RID: 159447
		EnterGameRet,
		// Token: 0x04026ED8 RID: 159448
		PatchVerifyFail,
		// Token: 0x04026ED9 RID: 159449
		SDKLoginBefore,
		// Token: 0x04026EDA RID: 159450
		SDKLoginAfter
	}

	// Token: 0x020077F3 RID: 30707
	public enum ELoginSex
	{
		// Token: 0x04026EDC RID: 159452
		Girl,
		// Token: 0x04026EDD RID: 159453
		Boy
	}

	// Token: 0x020077F4 RID: 30708
	public enum ECleanFailCountWay
	{
		// Token: 0x04026EDF RID: 159455
		LoginSuccess,
		// Token: 0x04026EE0 RID: 159456
		RefreshTime,
		// Token: 0x04026EE1 RID: 159457
		TestLogin
	}

	// Token: 0x020077F5 RID: 30709
	public enum ESdkLoginCode
	{
		// Token: 0x04026EE3 RID: 159459
		LoginFailed,
		// Token: 0x04026EE4 RID: 159460
		LoginSuccess,
		// Token: 0x04026EE5 RID: 159461
		FirstLogin
	}

	// Token: 0x020077F6 RID: 30710
	public enum ESdkLoginState
	{
		// Token: 0x04026EE7 RID: 159463
		Logout,
		// Token: 0x04026EE8 RID: 159464
		Login,
		// Token: 0x04026EE9 RID: 159465
		LoggingIn
	}
}
