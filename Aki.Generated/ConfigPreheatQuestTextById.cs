using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000771 RID: 1905
	public class ConfigPreheatQuestTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CB7 RID: 11447 RVA: 0x00159907 File Offset: 0x00157B07
		static ConfigPreheatQuestTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatQuestTextById.CreateStaticDefaultValue), new Action(ConfigPreheatQuestTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x00159928 File Offset: 0x00157B28
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

		// Token: 0x06002CB9 RID: 11449 RVA: 0x001599A7 File Offset: 0x00157BA7
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatQuestTextById.LogPair = null;
			ConfigPreheatQuestTextById.HandleId = 0;
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x001599B5 File Offset: 0x00157BB5
		public static void Init()
		{
			ConfigPreheatQuestTextById.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatQuestTextById.HandleId, "db_preheat.db", "select BinData from `PreheatQuestText` where Id=?");
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x001599D0 File Offset: 0x00157BD0
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

		// Token: 0x040033FD RID: 13309
		private const string DB = "db_preheat.db";

		// Token: 0x040033FE RID: 13310
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x040033FF RID: 13311
		private const string TABLE = "PreheatQuestText";

		// Token: 0x04003400 RID: 13312
		private const string COMMAND = "select BinData from `PreheatQuestText` where Id=?";

		// Token: 0x04003401 RID: 13313
		private const string KEY_PREFIX = "PreheatQuestTextById";

		// Token: 0x04003402 RID: 13314
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003403 RID: 13315
		private static int HandleId;
	}
}
