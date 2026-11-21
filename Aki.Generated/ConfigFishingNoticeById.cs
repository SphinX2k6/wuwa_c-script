using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F5 RID: 757
	public class ConfigFishingNoticeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011C3 RID: 4547 RVA: 0x000C1648 File Offset: 0x000BF848
		static ConfigFishingNoticeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingNoticeById.CreateStaticDefaultValue), new Action(ConfigFishingNoticeById.ResetStaticDefaultValue));
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000C1668 File Offset: 0x000BF868
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingNoticeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingNoticeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingNotice"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingNotice` where Id=?")
			});
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x000C16E7 File Offset: 0x000BF8E7
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingNoticeById.LogPair = null;
			ConfigFishingNoticeById.HandleId = 0;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x000C16F5 File Offset: 0x000BF8F5
		public static void Init()
		{
			ConfigFishingNoticeById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingNoticeById.HandleId, "db_fishing.db", "select BinData from `FishingNotice` where Id=?");
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000C1710 File Offset: 0x000BF910
		public static FishingNotice? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingNoticeById.HandleId, ConfigFishingNoticeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingNoticeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingNotice?(FishingNotice.GetRootAsFishingNotice(configBuffer));
				}
			}
			ConfigFishingNoticeById.LogPair.Clear();
			ConfigFishingNoticeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingNoticeById.HandleId, 1, p0Id, ConfigFishingNoticeById.LogPair) || ConfigCommon.Step(ConfigFishingNoticeById.HandleId, true, ConfigFishingNoticeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingNoticeById.HandleId, ConfigFishingNoticeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingNoticeById.HandleId, 0, ConfigFishingNoticeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingNoticeById.HandleId, ConfigFishingNoticeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingNotice rootAsFishingNotice = FishingNotice.GetRootAsFishingNotice(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingNoticeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingNoticeById.HandleId, ConfigFishingNoticeById.LogPair);
			return new FishingNotice?(rootAsFishingNotice);
		}

		// Token: 0x04001497 RID: 5271
		private const string DB = "db_fishing.db";

		// Token: 0x04001498 RID: 5272
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001499 RID: 5273
		private const string TABLE = "FishingNotice";

		// Token: 0x0400149A RID: 5274
		private const string COMMAND = "select BinData from `FishingNotice` where Id=?";

		// Token: 0x0400149B RID: 5275
		private const string KEY_PREFIX = "FishingNoticeById";

		// Token: 0x0400149C RID: 5276
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400149D RID: 5277
		private static int HandleId;
	}
}
