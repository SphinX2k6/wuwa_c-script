using System;
using System.Runtime.CompilerServices;

// Token: 0x02001572 RID: 5490
[NullableContext(1)]
[Nullable(0)]
public class SdkLoginConfig
{
	// Token: 0x0600DB6D RID: 56173 RVA: 0x00410566 File Offset: 0x0040E766
	public SdkLoginConfig(string uId = "", string userName = "", string token = "")
	{
		this.Uid = uId;
		this.UserName = userName;
		this.Token = token;
	}

	// Token: 0x0600DB6E RID: 56174 RVA: 0x004105A4 File Offset: 0x0040E7A4
	public string GetLoginUserNameWithUriEncode()
	{
		return Uri.EscapeDataString(this.UserName);
	}

	// Token: 0x04007A7F RID: 31359
	public string Uid = string.Empty;

	// Token: 0x04007A80 RID: 31360
	public string UserName = string.Empty;

	// Token: 0x04007A81 RID: 31361
	public string Token = string.Empty;
}
