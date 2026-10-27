using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056D RID: 1389
	public class ConfigMoraleRoleGrowthByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600209B RID: 8347 RVA: 0x00111B04 File Offset: 0x0010FD04
		static ConfigMoraleRoleGrowthByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleRoleGrowthByLevel.CreateStaticDefaultValue), new Action(ConfigMoraleRoleGrowthByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00111B24 File Offset: 0x0010FD24
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleRoleGrowthByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleRoleGrowthByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleRoleGrowth"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleRoleGrowth` where Level=?")
			});
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x00111BA3 File Offset: 0x0010FDA3
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleRoleGrowthByLevel.LogPair = null;
			ConfigMoraleRoleGrowthByLevel.HandleId = 0;
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x00111BB1 File Offset: 0x0010FDB1
		public static void Init()
		{
			ConfigMoraleRoleGrowthByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleRoleGrowthByLevel.HandleId, "db_moraleplay.db", "select BinData from `MoraleRoleGrowth` where Level=?");
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00111BCC File Offset: 0x0010FDCC
		public static MoraleRoleGrowth? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleRoleGrowthByLevel.HandleId, ConfigMoraleRoleGrowthByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleRoleGrowthByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleRoleGrowth?(MoraleRoleGrowth.GetRootAsMoraleRoleGrowth(configBuffer));
				}
			}
			ConfigMoraleRoleGrowthByLevel.LogPair.Clear();
			ConfigMoraleRoleGrowthByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigMoraleRoleGrowthByLevel.HandleId, 1, p0Level, ConfigMoraleRoleGrowthByLevel.LogPair) || ConfigCommon.Step(ConfigMoraleRoleGrowthByLevel.HandleId, true, ConfigMoraleRoleGrowthByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleRoleGrowthByLevel.HandleId, ConfigMoraleRoleGrowthByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleRoleGrowthByLevel.HandleId, 0, ConfigMoraleRoleGrowthByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleRoleGrowthByLevel.HandleId, ConfigMoraleRoleGrowthByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleRoleGrowth rootAsMoraleRoleGrowth = MoraleRoleGrowth.GetRootAsMoraleRoleGrowth(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleRoleGrowthByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleRoleGrowthByLevel.HandleId, ConfigMoraleRoleGrowthByLevel.LogPair);
			return new MoraleRoleGrowth?(rootAsMoraleRoleGrowth);
		}

		// Token: 0x040025DF RID: 9695
		private const string DB = "db_moraleplay.db";

		// Token: 0x040025E0 RID: 9696
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x040025E1 RID: 9697
		private const string TABLE = "MoraleRoleGrowth";

		// Token: 0x040025E2 RID: 9698
		private const string COMMAND = "select BinData from `MoraleRoleGrowth` where Level=?";

		// Token: 0x040025E3 RID: 9699
		private const string KEY_PREFIX = "MoraleRoleGrowthByLevel";

		// Token: 0x040025E4 RID: 9700
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025E5 RID: 9701
		private static int HandleId;
	}
}
