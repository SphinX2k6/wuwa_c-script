using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015CD RID: 5581
	[EnumExtensions]
	public enum EEditFlag
	{
		// Token: 0x04004A61 RID: 19041
		[EnumStringMember("新增")]
		Add,
		// Token: 0x04004A62 RID: 19042
		[EnumStringMember("修改")]
		Modify,
		// Token: 0x04004A63 RID: 19043
		[EnumStringMember("删除")]
		Delete
	}
}
