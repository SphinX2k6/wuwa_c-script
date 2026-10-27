using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086C RID: 2156
	public class ConfigRogueTowerBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600329A RID: 12954 RVA: 0x001778EF File Offset: 0x00175AEF
		static ConfigRogueTowerBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTowerBuffById.CreateStaticDefaultValue), new Action(ConfigRogueTowerBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x00177910 File Offset: 0x00175B10
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueTowerBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueTowerBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽经典复开.xlsx"),
				new ValueTuple<string, object>("表名", "RogueTowerBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueTowerBuff` where Id=?")
			});
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x0017798F File Offset: 0x00175B8F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTowerBuffById.LogPair = null;
			ConfigRogueTowerBuffById.HandleId = 0;
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x0017799D File Offset: 0x00175B9D
		public static void Init()
		{
			ConfigRogueTowerBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTowerBuffById.HandleId, "db_rogue.db", "select BinData from `RogueTowerBuff` where Id=?");
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x001779B8 File Offset: 0x00175BB8
		public static RogueTowerBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueTowerBuffById.HandleId, ConfigRogueTowerBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueTowerBuff?(RogueTowerBuff.GetRootAsRogueTowerBuff(configBuffer));
				}
			}
			ConfigRogueTowerBuffById.LogPair.Clear();
			ConfigRogueTowerBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueTowerBuffById.HandleId, 1, p0Id, ConfigRogueTowerBuffById.LogPair) || ConfigCommon.Step(ConfigRogueTowerBuffById.HandleId, true, ConfigRogueTowerBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueTowerBuffById.HandleId, ConfigRogueTowerBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueTowerBuffById.HandleId, 0, ConfigRogueTowerBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueTowerBuffById.HandleId, ConfigRogueTowerBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueTowerBuff rootAsRogueTowerBuff = RogueTowerBuff.GetRootAsRogueTowerBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueTowerBuffById.HandleId, ConfigRogueTowerBuffById.LogPair);
			return new RogueTowerBuff?(rootAsRogueTowerBuff);
		}

		// Token: 0x04003ADA RID: 15066
		private const string DB = "db_rogue.db";

		// Token: 0x04003ADB RID: 15067
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x04003ADC RID: 15068
		private const string TABLE = "RogueTowerBuff";

		// Token: 0x04003ADD RID: 15069
		private const string COMMAND = "select BinData from `RogueTowerBuff` where Id=?";

		// Token: 0x04003ADE RID: 15070
		private const string KEY_PREFIX = "RogueTowerBuffById";

		// Token: 0x04003ADF RID: 15071
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AE0 RID: 15072
		private static int HandleId;
	}
}
