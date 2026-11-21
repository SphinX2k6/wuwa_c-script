using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000959 RID: 2393
	public class ConfigSheriffAnomalyByCriminalId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003829 RID: 14377 RVA: 0x00199FD0 File Offset: 0x001981D0
		static ConfigSheriffAnomalyByCriminalId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffAnomalyByCriminalId.CreateStaticDefaultValue), new Action(ConfigSheriffAnomalyByCriminalId.ResetStaticDefaultValue));
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x00199FF0 File Offset: 0x001981F0
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffAnomalyByCriminalId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffAnomalyByCriminalId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffAnomaly"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffAnomaly` where CriminalId=?")
			});
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x0019A06F File Offset: 0x0019826F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffAnomalyByCriminalId.LogPair = null;
			ConfigSheriffAnomalyByCriminalId.HandleId = 0;
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x0019A07D File Offset: 0x0019827D
		public static void Init()
		{
			ConfigSheriffAnomalyByCriminalId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffAnomalyByCriminalId.HandleId, "db_sheriff.db", "select BinData from `SheriffAnomaly` where CriminalId=?");
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x0019A098 File Offset: 0x00198298
		public static SheriffAnomaly? GetConfig(int p0CriminalId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffAnomalyByCriminalId.HandleId, ConfigSheriffAnomalyByCriminalId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffAnomalyByCriminalId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CriminalId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffAnomaly?(SheriffAnomaly.GetRootAsSheriffAnomaly(configBuffer));
				}
			}
			ConfigSheriffAnomalyByCriminalId.LogPair.Clear();
			ConfigSheriffAnomalyByCriminalId.LogPair.Add(new ValueTuple<string, object>("CriminalId", p0CriminalId));
			if (!ConfigCommon.BindInt(ConfigSheriffAnomalyByCriminalId.HandleId, 1, p0CriminalId, ConfigSheriffAnomalyByCriminalId.LogPair) || ConfigCommon.Step(ConfigSheriffAnomalyByCriminalId.HandleId, true, ConfigSheriffAnomalyByCriminalId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffAnomalyByCriminalId.HandleId, ConfigSheriffAnomalyByCriminalId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffAnomalyByCriminalId.HandleId, 0, ConfigSheriffAnomalyByCriminalId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffAnomalyByCriminalId.HandleId, ConfigSheriffAnomalyByCriminalId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffAnomaly rootAsSheriffAnomaly = SheriffAnomaly.GetRootAsSheriffAnomaly(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffAnomalyByCriminalId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CriminalId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffAnomalyByCriminalId.HandleId, ConfigSheriffAnomalyByCriminalId.LogPair);
			return new SheriffAnomaly?(rootAsSheriffAnomaly);
		}

		// Token: 0x04004155 RID: 16725
		private const string DB = "db_sheriff.db";

		// Token: 0x04004156 RID: 16726
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04004157 RID: 16727
		private const string TABLE = "SheriffAnomaly";

		// Token: 0x04004158 RID: 16728
		private const string COMMAND = "select BinData from `SheriffAnomaly` where CriminalId=?";

		// Token: 0x04004159 RID: 16729
		private const string KEY_PREFIX = "SheriffAnomalyByCriminalId";

		// Token: 0x0400415A RID: 16730
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400415B RID: 16731
		private static int HandleId;
	}
}
