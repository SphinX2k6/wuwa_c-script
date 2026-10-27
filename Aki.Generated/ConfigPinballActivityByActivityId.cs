using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000708 RID: 1800
	public class ConfigPinballActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A40 RID: 10816 RVA: 0x00148350 File Offset: 0x00146550
		static ConfigPinballActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigPinballActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00148370 File Offset: 0x00146570
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

		// Token: 0x06002A42 RID: 10818 RVA: 0x001483EF File Offset: 0x001465EF
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballActivityByActivityId.LogPair = null;
			ConfigPinballActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x001483FD File Offset: 0x001465FD
		public static void Init()
		{
			ConfigPinballActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballActivityByActivityId.HandleId, "db_pinballbattle.db", "select BinData from `PinballActivity` where ActivityId=?");
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00148418 File Offset: 0x00146618
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

		// Token: 0x0400311E RID: 12574
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400311F RID: 12575
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x04003120 RID: 12576
		private const string TABLE = "PinballActivity";

		// Token: 0x04003121 RID: 12577
		private const string COMMAND = "select BinData from `PinballActivity` where ActivityId=?";

		// Token: 0x04003122 RID: 12578
		private const string KEY_PREFIX = "PinballActivityByActivityId";

		// Token: 0x04003123 RID: 12579
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003124 RID: 12580
		private static int HandleId;
	}
}
