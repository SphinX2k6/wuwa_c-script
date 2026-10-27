using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000759 RID: 1881
	public class ConfigPreheatQuestTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C27 RID: 11303 RVA: 0x00152E8B File Offset: 0x0015108B
		static ConfigPreheatQuestTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatQuestTextById.CreateStaticDefaultValue), new Action(ConfigPreheatQuestTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x00152EAC File Offset: 0x001510AC
		public static void CreateStaticDefaultValue()
		{
			ConfigPreheatQuestTextById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreheatQuestTextById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_preheat.db"),
				new ValueTuple<string, object>("文件", "y.预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "PreheatQuestText"),
				new ValueTuple<string, object>("语句", "select BinData from `PreheatQuestText` where Id=?")
			});
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x00152F2B File Offset: 0x0015112B
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatQuestTextById.LogPair = null;
			ConfigPreheatQuestTextById.HandleId = 0;
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x00152F39 File Offset: 0x00151139
		public static void Init()
		{
			ConfigPreheatQuestTextById.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatQuestTextById.HandleId, "db_preheat.db", "select BinData from `PreheatQuestText` where Id=?");
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x00152F54 File Offset: 0x00151154
		public static PreheatQuestText? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreheatQuestTextById.HandleId, ConfigPreheatQuestTextById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreheatQuestTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PreheatQuestText?(PreheatQuestText.GetRootAsPreheatQuestText(configBuffer));
				}
			}
			ConfigPreheatQuestTextById.LogPair.Clear();
			ConfigPreheatQuestTextById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPreheatQuestTextById.HandleId, 1, p0Id, ConfigPreheatQuestTextById.LogPair) || ConfigCommon.Step(ConfigPreheatQuestTextById.HandleId, true, ConfigPreheatQuestTextById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPreheatQuestTextById.HandleId, ConfigPreheatQuestTextById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreheatQuestTextById.HandleId, 0, ConfigPreheatQuestTextById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPreheatQuestTextById.HandleId, ConfigPreheatQuestTextById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PreheatQuestText rootAsPreheatQuestText = PreheatQuestText.GetRootAsPreheatQuestText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreheatQuestTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPreheatQuestTextById.HandleId, ConfigPreheatQuestTextById.LogPair);
			return new PreheatQuestText?(rootAsPreheatQuestText);
		}

		// Token: 0x04003355 RID: 13141
		private const string DB = "db_preheat.db";

		// Token: 0x04003356 RID: 13142
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x04003357 RID: 13143
		private const string TABLE = "PreheatQuestText";

		// Token: 0x04003358 RID: 13144
		private const string COMMAND = "select BinData from `PreheatQuestText` where Id=?";

		// Token: 0x04003359 RID: 13145
		private const string KEY_PREFIX = "PreheatQuestTextById";

		// Token: 0x0400335A RID: 13146
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400335B RID: 13147
		private static int HandleId;
	}
}
