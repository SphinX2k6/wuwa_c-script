using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000186 RID: 390
	public class ConfigClueContentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x00090BBB File Offset: 0x0008EDBB
		static ConfigClueContentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigClueContentById.CreateStaticDefaultValue), new Action(ConfigClueContentById.ResetStaticDefaultValue));
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00090BDC File Offset: 0x0008EDDC
		public static void CreateStaticDefaultValue()
		{
			ConfigClueContentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigClueContentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_clue.db"),
				new ValueTuple<string, object>("文件", "x.线索.xlsx"),
				new ValueTuple<string, object>("表名", "ClueContent"),
				new ValueTuple<string, object>("语句", "select BinData from `ClueContent` where Id=?")
			});
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00090C5B File Offset: 0x0008EE5B
		public static void ResetStaticDefaultValue()
		{
			ConfigClueContentById.LogPair = null;
			ConfigClueContentById.HandleId = 0;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00090C69 File Offset: 0x0008EE69
		public static void Init()
		{
			ConfigClueContentById.HandleId = ConfigCommon.InitDataStatement(ConfigClueContentById.HandleId, "db_clue.db", "select BinData from `ClueContent` where Id=?");
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00090C84 File Offset: 0x0008EE84
		public static ClueContent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigClueContentById.HandleId, ConfigClueContentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ClueContentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ClueContent?(ClueContent.GetRootAsClueContent(configBuffer));
				}
			}
			ConfigClueContentById.LogPair.Clear();
			ConfigClueContentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigClueContentById.HandleId, 1, p0Id, ConfigClueContentById.LogPair) || ConfigCommon.Step(ConfigClueContentById.HandleId, true, ConfigClueContentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigClueContentById.HandleId, ConfigClueContentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigClueContentById.HandleId, 0, ConfigClueContentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigClueContentById.HandleId, ConfigClueContentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ClueContent rootAsClueContent = ClueContent.GetRootAsClueContent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ClueContentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigClueContentById.HandleId, ConfigClueContentById.LogPair);
			return new ClueContent?(rootAsClueContent);
		}

		// Token: 0x04000A8E RID: 2702
		private const string DB = "db_clue.db";

		// Token: 0x04000A8F RID: 2703
		private const string FILE = "x.线索.xlsx";

		// Token: 0x04000A90 RID: 2704
		private const string TABLE = "ClueContent";

		// Token: 0x04000A91 RID: 2705
		private const string COMMAND = "select BinData from `ClueContent` where Id=?";

		// Token: 0x04000A92 RID: 2706
		private const string KEY_PREFIX = "ClueContentById";

		// Token: 0x04000A93 RID: 2707
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A94 RID: 2708
		private static int HandleId;
	}
}
