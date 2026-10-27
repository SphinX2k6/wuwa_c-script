using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015C5 RID: 5573
	[JsonConverter(typeof(EDisplayModeInPlayerOpJsonConverter))]
	[EnumExtensions]
	public enum EDisplayModeInPlayerOp
	{
		// Token: 0x04004A46 RID: 19014
		ShowUi,
		// Token: 0x04004A47 RID: 19015
		HideUi
	}
}
