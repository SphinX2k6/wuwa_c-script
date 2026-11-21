using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077C RID: 1916
	public class ConfigPrizeAwardsGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CF9 RID: 11513 RVA: 0x0015AF50 File Offset: 0x00159150
		static ConfigPrizeAwardsGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrizeAwardsGroupById.CreateStaticDefaultValue), new Action(ConfigPrizeAwardsGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x0015AF70 File Offset: 0x00159170
		public static void CreateStaticDefaultValue()
		{
			ConfigPrizeAwardsGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPrizeAwardsGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "PrizeAwardsGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `PrizeAwardsGroup` where Id=?")
			});
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x0015AFEF File Offset: 0x001591EF
		public static void ResetStaticDefaultValue()
		{
			ConfigPrizeAwardsGroupById.LogPair = null;
			ConfigPrizeAwardsGroupById.HandleId = 0;
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x0015AFFD File Offset: 0x001591FD
		public static void Init()
		{
			ConfigPrizeAwardsGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigPrizeAwardsGroupById.HandleId, "db_solarschool.db", "select BinData from `PrizeAwardsGroup` where Id=?");
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x0015B018 File Offset: 0x00159218
		public static PrizeAwardsGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPrizeAwardsGroupById.HandleId, ConfigPrizeAwardsGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PrizeAwardsGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PrizeAwardsGroup?(PrizeAwardsGroup.GetRootAsPrizeAwardsGroup(configBuffer));
				}
			}
			ConfigPrizeAwardsGroupById.LogPair.Clear();
			ConfigPrizeAwardsGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPrizeAwardsGroupById.HandleId, 1, p0Id, ConfigPrizeAwardsGroupById.LogPair) || ConfigCommon.Step(ConfigPrizeAwardsGroupById.HandleId, true, ConfigPrizeAwardsGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPrizeAwardsGroupById.HandleId, ConfigPrizeAwardsGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPrizeAwardsGroupById.HandleId, 0, ConfigPrizeAwardsGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPrizeAwardsGroupById.HandleId, ConfigPrizeAwardsGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PrizeAwardsGroup rootAsPrizeAwardsGroup = PrizeAwardsGroup.GetRootAsPrizeAwardsGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PrizeAwardsGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPrizeAwardsGroupById.HandleId, ConfigPrizeAwardsGroupById.LogPair);
			return new PrizeAwardsGroup?(rootAsPrizeAwardsGroup);
		}

		// Token: 0x0400344A RID: 13386
		private const string DB = "db_solarschool.db";

		// Token: 0x0400344B RID: 13387
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x0400344C RID: 13388
		private const string TABLE = "PrizeAwardsGroup";

		// Token: 0x0400344D RID: 13389
		private const string COMMAND = "select BinData from `PrizeAwardsGroup` where Id=?";

		// Token: 0x0400344E RID: 13390
		private const string KEY_PREFIX = "PrizeAwardsGroupById";

		// Token: 0x0400344F RID: 13391
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003450 RID: 13392
		private static int HandleId;
	}
}
