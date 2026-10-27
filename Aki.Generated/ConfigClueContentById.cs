using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000176 RID: 374
	public class ConfigClueContentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x0008B05F File Offset: 0x0008925F
		static ConfigClueContentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigClueContentById.CreateStaticDefaultValue), new Action(ConfigClueContentById.ResetStaticDefaultValue));
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0008B080 File Offset: 0x00089280
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

		// Token: 0x060008C7 RID: 2247 RVA: 0x0008B0FF File Offset: 0x000892FF
		public static void ResetStaticDefaultValue()
		{
			ConfigClueContentById.LogPair = null;
			ConfigClueContentById.HandleId = 0;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0008B10D File Offset: 0x0008930D
		public static void Init()
		{
			ConfigClueContentById.HandleId = ConfigCommon.InitDataStatement(ConfigClueContentById.HandleId, "db_clue.db", "select BinData from `ClueContent` where Id=?");
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0008B128 File Offset: 0x00089328
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

		// Token: 0x04000A1E RID: 2590
		private const string DB = "db_clue.db";

		// Token: 0x04000A1F RID: 2591
		private const string FILE = "x.线索.xlsx";

		// Token: 0x04000A20 RID: 2592
		private const string TABLE = "ClueContent";

		// Token: 0x04000A21 RID: 2593
		private const string COMMAND = "select BinData from `ClueContent` where Id=?";

		// Token: 0x04000A22 RID: 2594
		private const string KEY_PREFIX = "ClueContentById";

		// Token: 0x04000A23 RID: 2595
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A24 RID: 2596
		private static int HandleId;
	}
}
