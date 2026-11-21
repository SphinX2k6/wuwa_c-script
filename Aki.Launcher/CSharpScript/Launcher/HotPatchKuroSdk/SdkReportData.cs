using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001ED RID: 493
	[NullableContext(1)]
	[Nullable(0)]
	public class SdkReportData
	{
		// Token: 0x06000D1F RID: 3359 RVA: 0x00050DFB File Offset: 0x0004EFFB
		public SdkReportData([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData)
		{
			this.EventData = eventData;
			this.IfGlobalSdk = (BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN");
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00050E2C File Offset: 0x0004F02C
		public virtual string GetEventName()
		{
			LauncherLog.Instance.Debug("当前LogReport没有重写EventName,请重写EventName", default(ReadOnlySpan<ValueTuple<string, object>>));
			return "";
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00050E58 File Offset: 0x0004F058
		protected virtual string GetEventDataJson()
		{
			if (this.EventData == null)
			{
				return "{}";
			}
			int count = this.EventData.Count;
			if (count == 0)
			{
				return "{}";
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('{');
			int num = 0;
			foreach (KeyValuePair<string, string> keyValuePair in this.EventData)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("\"");
				appendInterpolatedStringHandler.AppendFormatted(keyValuePair.Key);
				appendInterpolatedStringHandler.AppendLiteral("\":\"");
				appendInterpolatedStringHandler.AppendFormatted(keyValuePair.Value);
				appendInterpolatedStringHandler.AppendLiteral("\"");
				stringBuilder3.Append(ref appendInterpolatedStringHandler);
				if (count - 1 != num)
				{
					stringBuilder.Append(',');
				}
				num++;
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00050F54 File Offset: 0x0004F154
		public string GetReportString()
		{
			string text = JsonSerializer.Serialize<Dictionary<string, string>>(new Dictionary<string, string>
			{
				{
					"eventName",
					this.GetEventName()
				},
				{
					"eventParams",
					this.GetEventDataJson()
				}
			}, null);
			LauncherLog instance = LauncherLog.Instance;
			string message = "上报埋点信息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("finalJson", text);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return text;
		}

		// Token: 0x0400083E RID: 2110
		public bool IfGlobalSdk;

		// Token: 0x0400083F RID: 2111
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected Dictionary<string, string> EventData;
	}
}
