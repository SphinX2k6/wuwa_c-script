using System;
using System.Runtime.CompilerServices;

// Token: 0x0200209B RID: 8347
[NullableContext(1)]
[Nullable(0)]
public class SdkLoginConfig
{
	// Token: 0x060106FF RID: 67327 RVA: 0x00403F96 File Offset: 0x00402196
	public SdkLoginConfig(string uId = "", string userName = "", string token = "")
	{
		this.Uid = uId;
		this.UserName = userName;
		this.Token = token;
	}

	// Token: 0x06010700 RID: 67328 RVA: 0x00403FD4 File Offset: 0x004021D4
	public string GetLoginUserNameWithUriEncode()
	{
		return Uri.EscapeDataString(this.UserName);
	}

	// Token: 0x04007981 RID: 31105
	public string Uid = string.Empty;

	// Token: 0x04007982 RID: 31106
	public string UserName = string.Empty;

	// Token: 0x04007983 RID: 31107
	public string Token = string.Empty;
}
