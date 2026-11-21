using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001724 RID: 5924
	[JsonConverter(typeof(EDisplayModeInPlayerOpJsonConverter))]
	[EnumExtensions]
	public enum EDisplayModeInPlayerOp
	{
		// Token: 0x04004E00 RID: 19968
		ShowUi,
		// Token: 0x04004E01 RID: 19969
		HideUi
	}
}
