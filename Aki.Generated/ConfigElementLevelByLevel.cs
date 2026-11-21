using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000277 RID: 631
	public class ConfigElementLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000ECE RID: 3790 RVA: 0x000B0A3B File Offset: 0x000AEC3B
		static ConfigElementLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementLevelByLevel.CreateStaticDefaultValue), new Action(ConfigElementLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000B0A5C File Offset: 0x000AEC5C
		public static void CreateStaticDefaultValue()
		{
			ConfigElementLevelByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigElementLevelByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "ElementLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `ElementLevel` where Level=?")
			});
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000B0ADB File Offset: 0x000AECDB
		public static void ResetStaticDefaultValue()
		{
			ConfigElementLevelByLevel.LogPair = null;
			ConfigElementLevelByLevel.HandleId = 0;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000B0AE9 File Offset: 0x000AECE9
		public static void Init()
		{
			ConfigElementLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigElementLevelByLevel.HandleId, "db_rogue.db", "select BinData from `ElementLevel` where Level=?");
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000B0B04 File Offset: 0x000AED04
		public static ElementLevel? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigElementLevelByLevel.HandleId, ConfigElementLevelByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ElementLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ElementLevel?(ElementLevel.GetRootAsElementLevel(configBuffer));
				}
			}
			ConfigElementLevelByLevel.LogPair.Clear();
			ConfigElementLevelByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigElementLevelByLevel.HandleId, 1, p0Level, ConfigElementLevelByLevel.LogPair) || ConfigCommon.Step(ConfigElementLevelByLevel.HandleId, true, ConfigElementLevelByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigElementLevelByLevel.HandleId, ConfigElementLevelByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigElementLevelByLevel.HandleId, 0, ConfigElementLevelByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigElementLevelByLevel.HandleId, ConfigElementLevelByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ElementLevel rootAsElementLevel = ElementLevel.GetRootAsElementLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ElementLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigElementLevelByLevel.HandleId, ConfigElementLevelByLevel.LogPair);
			return new ElementLevel?(rootAsElementLevel);
		}

		// Token: 0x04001125 RID: 4389
		private const string DB = "db_rogue.db";

		// Token: 0x04001126 RID: 4390
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04001127 RID: 4391
		private const string TABLE = "ElementLevel";

		// Token: 0x04001128 RID: 4392
		private const string COMMAND = "select BinData from `ElementLevel` where Level=?";

		// Token: 0x04001129 RID: 4393
		private const string KEY_PREFIX = "ElementLevelByLevel";

		// Token: 0x0400112A RID: 4394
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400112B RID: 4395
		private static int HandleId;
	}
}
