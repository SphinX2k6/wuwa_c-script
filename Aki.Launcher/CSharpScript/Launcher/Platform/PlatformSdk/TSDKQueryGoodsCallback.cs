using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000191 RID: 401
	// (Invoke) Token: 0x06000AF9 RID: 2809
	public delegate void TSDKQueryGoodsCallback(string msg, bool needReLogin, [Nullable(new byte[]
	{
		2,
		1
	})] List<IQueryGoodsResponseData> data);
}
