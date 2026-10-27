using System;
using System.Runtime.CompilerServices;

// Token: 0x02002087 RID: 8327
public class LoginDefine
{
	// Token: 0x04007915 RID: 30997
	[Nullable(1)]
	public const string DEFAULTPORT = "5500";

	// Token: 0x0200866A RID: 34410
	public enum ELoginStatus
	{
		// Token: 0x0402BBB4 RID: 179124
		Init,
		// Token: 0x0402BBB5 RID: 179125
		LoginViewOpen,
		// Token: 0x0402BBB6 RID: 179126
		SdkViewOpen,
		// Token: 0x0402BBB7 RID: 179127
		SdkLoginSuccecc,
		// Token: 0x0402BBB8 RID: 179128
		SdkLoginFail,
		// Token: 0x0402BBB9 RID: 179129
		LoginHttp,
		// Token: 0x0402BBBA RID: 179130
		LoginHttpRet,
		// Token: 0x0402BBBB RID: 179131
		ConvGate,
		// Token: 0x0402BBBC RID: 179132
		ConvRet,
		// Token: 0x0402BBBD RID: 179133
		ProtoKeyReq,
		// Token: 0x0402BBBE RID: 179134
		ProtoKeyRet,
		// Token: 0x0402BBBF RID: 179135
		LoginReq,
		// Token: 0x0402BBC0 RID: 179136
		LoginRet,
		// Token: 0x0402BBC1 RID: 179137
		CreateReq,
		// Token: 0x0402BBC2 RID: 179138
		CreateRet,
		// Token: 0x0402BBC3 RID: 179139
		EnterGameReq,
		// Token: 0x0402BBC4 RID: 179140
		EnterGameRet,
		// Token: 0x0402BBC5 RID: 179141
		PatchVerifyFail,
		// Token: 0x0402BBC6 RID: 179142
		SDKLoginBefore,
		// Token: 0x0402BBC7 RID: 179143
		SDKLoginAfter
	}

	// Token: 0x0200866B RID: 34411
	public enum ELoginSex
	{
		// Token: 0x0402BBC9 RID: 179145
		Girl,
		// Token: 0x0402BBCA RID: 179146
		Boy
	}

	// Token: 0x0200866C RID: 34412
	public enum ECleanFailCountWay
	{
		// Token: 0x0402BBCC RID: 179148
		LoginSuccess,
		// Token: 0x0402BBCD RID: 179149
		RefreshTime,
		// Token: 0x0402BBCE RID: 179150
		TestLogin
	}

	// Token: 0x0200866D RID: 34413
	public enum ESdkLoginCode
	{
		// Token: 0x0402BBD0 RID: 179152
		LoginFailed,
		// Token: 0x0402BBD1 RID: 179153
		LoginSuccess,
		// Token: 0x0402BBD2 RID: 179154
		FirstLogin
	}

	// Token: 0x0200866E RID: 34414
	public enum ESdkLoginState
	{
		// Token: 0x0402BBD4 RID: 179156
		Logout,
		// Token: 0x0402BBD5 RID: 179157
		Login,
		// Token: 0x0402BBD6 RID: 179158
		LoggingIn
	}
}
