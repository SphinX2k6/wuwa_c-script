using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E0 RID: 736
	public class ConfigFishingNoticeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001145 RID: 4421 RVA: 0x000BB13C File Offset: 0x000B933C
		static ConfigFishingNoticeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingNoticeById.CreateStaticDefaultValue), new Action(ConfigFishingNoticeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x000BB15C File Offset: 0x000B935C
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

		// Token: 0x06001147 RID: 4423 RVA: 0x000BB1DB File Offset: 0x000B93DB
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingNoticeById.LogPair = null;
			ConfigFishingNoticeById.HandleId = 0;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x000BB1E9 File Offset: 0x000B93E9
		public static void Init()
		{
			ConfigFishingNoticeById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingNoticeById.HandleId, "db_fishing.db", "select BinData from `FishingNotice` where Id=?");
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x000BB204 File Offset: 0x000B9404
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

		// Token: 0x04001404 RID: 5124
		private const string DB = "db_fishing.db";

		// Token: 0x04001405 RID: 5125
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001406 RID: 5126
		private const string TABLE = "FishingNotice";

		// Token: 0x04001407 RID: 5127
		private const string COMMAND = "select BinData from `FishingNotice` where Id=?";

		// Token: 0x04001408 RID: 5128
		private const string KEY_PREFIX = "FishingNoticeById";

		// Token: 0x04001409 RID: 5129
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400140A RID: 5130
		private static int HandleId;
	}
}
