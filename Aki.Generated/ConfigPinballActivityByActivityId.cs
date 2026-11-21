using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000720 RID: 1824
	public class ConfigPinballActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AD0 RID: 10960 RVA: 0x0014EDCC File Offset: 0x0014CFCC
		static ConfigPinballActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigPinballActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x0014EDEC File Offset: 0x0014CFEC
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_活动.xlsx"),
				new ValueTuple<string, object>("表名", "PinballActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballActivity` where ActivityId=?")
			});
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x0014EE6B File Offset: 0x0014D06B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballActivityByActivityId.LogPair = null;
			ConfigPinballActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x0014EE79 File Offset: 0x0014D079
		public static void Init()
		{
			ConfigPinballActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballActivityByActivityId.HandleId, "db_pinballbattle.db", "select BinData from `PinballActivity` where ActivityId=?");
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x0014EE94 File Offset: 0x0014D094
		public static PinballActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballActivityByActivityId.HandleId, ConfigPinballActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballActivity?(PinballActivity.GetRootAsPinballActivity(configBuffer));
				}
			}
			ConfigPinballActivityByActivityId.LogPair.Clear();
			ConfigPinballActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPinballActivityByActivityId.HandleId, 1, p0ActivityId, ConfigPinballActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigPinballActivityByActivityId.HandleId, true, ConfigPinballActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballActivityByActivityId.HandleId, ConfigPinballActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballActivityByActivityId.HandleId, 0, ConfigPinballActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballActivityByActivityId.HandleId, ConfigPinballActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballActivity rootAsPinballActivity = PinballActivity.GetRootAsPinballActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballActivityByActivityId.HandleId, ConfigPinballActivityByActivityId.LogPair);
			return new PinballActivity?(rootAsPinballActivity);
		}

		// Token: 0x040031C6 RID: 12742
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031C7 RID: 12743
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x040031C8 RID: 12744
		private const string TABLE = "PinballActivity";

		// Token: 0x040031C9 RID: 12745
		private const string COMMAND = "select BinData from `PinballActivity` where ActivityId=?";

		// Token: 0x040031CA RID: 12746
		private const string KEY_PREFIX = "PinballActivityByActivityId";

		// Token: 0x040031CB RID: 12747
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031CC RID: 12748
		private static int HandleId;
	}
}
