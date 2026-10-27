using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000137 RID: 311
	public class ConfigCalabashLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x00082DEB File Offset: 0x00080FEB
		static ConfigCalabashLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashLevelByLevel.CreateStaticDefaultValue), new Action(ConfigCalabashLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00082E0C File Offset: 0x0008100C
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashLevelByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashLevelByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashLevel` where Level=?")
			});
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00082E8B File Offset: 0x0008108B
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashLevelByLevel.LogPair = null;
			ConfigCalabashLevelByLevel.HandleId = 0;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00082E99 File Offset: 0x00081099
		public static void Init()
		{
			ConfigCalabashLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashLevelByLevel.HandleId, "db_calabash.db", "select BinData from `CalabashLevel` where Level=?");
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00082EB4 File Offset: 0x000810B4
		public static CalabashLevel? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashLevelByLevel.HandleId, ConfigCalabashLevelByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CalabashLevel?(CalabashLevel.GetRootAsCalabashLevel(configBuffer));
				}
			}
			ConfigCalabashLevelByLevel.LogPair.Clear();
			ConfigCalabashLevelByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigCalabashLevelByLevel.HandleId, 1, p0Level, ConfigCalabashLevelByLevel.LogPair) || ConfigCommon.Step(ConfigCalabashLevelByLevel.HandleId, true, ConfigCalabashLevelByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCalabashLevelByLevel.HandleId, ConfigCalabashLevelByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashLevelByLevel.HandleId, 0, ConfigCalabashLevelByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCalabashLevelByLevel.HandleId, ConfigCalabashLevelByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CalabashLevel rootAsCalabashLevel = CalabashLevel.GetRootAsCalabashLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCalabashLevelByLevel.HandleId, ConfigCalabashLevelByLevel.LogPair);
			return new CalabashLevel?(rootAsCalabashLevel);
		}

		// Token: 0x04000865 RID: 2149
		private const string DB = "db_calabash.db";

		// Token: 0x04000866 RID: 2150
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04000867 RID: 2151
		private const string TABLE = "CalabashLevel";

		// Token: 0x04000868 RID: 2152
		private const string COMMAND = "select BinData from `CalabashLevel` where Level=?";

		// Token: 0x04000869 RID: 2153
		private const string KEY_PREFIX = "CalabashLevelByLevel";

		// Token: 0x0400086A RID: 2154
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400086B RID: 2155
		private static int HandleId;
	}
}
