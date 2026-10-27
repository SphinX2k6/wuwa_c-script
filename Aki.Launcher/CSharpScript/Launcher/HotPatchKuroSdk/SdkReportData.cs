using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E8 RID: 488
	[NullableContext(1)]
	[Nullable(0)]
	public class SdkReportData
	{
		// Token: 0x06000CDE RID: 3294 RVA: 0x0004E30F File Offset: 0x0004C50F
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

		// Token: 0x06000CDF RID: 3295 RVA: 0x0004E340 File Offset: 0x0004C540
		public virtual string GetEventName()
		{
			LauncherLog.Instance.Debug("当前LogReport没有重写EventName,请重写EventName", default(ReadOnlySpan<ValueTuple<string, object>>));
			return "";
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0004E36C File Offset: 0x0004C56C
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

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0004E468 File Offset: 0x0004C668
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

		// Token: 0x040007FE RID: 2046
		public bool IfGlobalSdk;

		// Token: 0x040007FF RID: 2047
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected Dictionary<string, string> EventData;
	}
}
