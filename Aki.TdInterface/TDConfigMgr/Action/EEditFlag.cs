using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200172C RID: 5932
	[EnumExtensions]
	public enum EEditFlag
	{
		// Token: 0x04004E1B RID: 19995
		[EnumStringMember("新增")]
		Add,
		// Token: 0x04004E1C RID: 19996
		[EnumStringMember("修改")]
		Modify,
		// Token: 0x04004E1D RID: 19997
		[EnumStringMember("删除")]
		Delete
	}
}
