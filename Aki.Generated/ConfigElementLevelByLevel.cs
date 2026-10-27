using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000263 RID: 611
	public class ConfigElementLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x000AA777 File Offset: 0x000A8977
		static ConfigElementLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementLevelByLevel.CreateStaticDefaultValue), new Action(ConfigElementLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000AA798 File Offset: 0x000A8998
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

		// Token: 0x06000E58 RID: 3672 RVA: 0x000AA817 File Offset: 0x000A8A17
		public static void ResetStaticDefaultValue()
		{
			ConfigElementLevelByLevel.LogPair = null;
			ConfigElementLevelByLevel.HandleId = 0;
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000AA825 File Offset: 0x000A8A25
		public static void Init()
		{
			ConfigElementLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigElementLevelByLevel.HandleId, "db_rogue.db", "select BinData from `ElementLevel` where Level=?");
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000AA840 File Offset: 0x000A8A40
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

		// Token: 0x04001099 RID: 4249
		private const string DB = "db_rogue.db";

		// Token: 0x0400109A RID: 4250
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x0400109B RID: 4251
		private const string TABLE = "ElementLevel";

		// Token: 0x0400109C RID: 4252
		private const string COMMAND = "select BinData from `ElementLevel` where Level=?";

		// Token: 0x0400109D RID: 4253
		private const string KEY_PREFIX = "ElementLevelByLevel";

		// Token: 0x0400109E RID: 4254
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400109F RID: 4255
		private static int HandleId;
	}
}
