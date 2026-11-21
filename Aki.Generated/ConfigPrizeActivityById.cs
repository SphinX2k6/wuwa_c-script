using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077B RID: 1915
	public class ConfigPrizeActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CF3 RID: 11507 RVA: 0x0015AD08 File Offset: 0x00158F08
		static ConfigPrizeActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrizeActivityById.CreateStaticDefaultValue), new Action(ConfigPrizeActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x0015AD28 File Offset: 0x00158F28
		public static void CreateStaticDefaultValue()
		{
			ConfigPrizeActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPrizeActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "PrizeActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PrizeActivity` where Id=?")
			});
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x0015ADA7 File Offset: 0x00158FA7
		public static void ResetStaticDefaultValue()
		{
			ConfigPrizeActivityById.LogPair = null;
			ConfigPrizeActivityById.HandleId = 0;
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x0015ADB5 File Offset: 0x00158FB5
		public static void Init()
		{
			ConfigPrizeActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigPrizeActivityById.HandleId, "db_solarschool.db", "select BinData from `PrizeActivity` where Id=?");
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x0015ADD0 File Offset: 0x00158FD0
		public static PrizeActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPrizeActivityById.HandleId, ConfigPrizeActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PrizeActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PrizeActivity?(PrizeActivity.GetRootAsPrizeActivity(configBuffer));
				}
			}
			ConfigPrizeActivityById.LogPair.Clear();
			ConfigPrizeActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPrizeActivityById.HandleId, 1, p0Id, ConfigPrizeActivityById.LogPair) || ConfigCommon.Step(ConfigPrizeActivityById.HandleId, true, ConfigPrizeActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPrizeActivityById.HandleId, ConfigPrizeActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPrizeActivityById.HandleId, 0, ConfigPrizeActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPrizeActivityById.HandleId, ConfigPrizeActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PrizeActivity rootAsPrizeActivity = PrizeActivity.GetRootAsPrizeActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PrizeActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPrizeActivityById.HandleId, ConfigPrizeActivityById.LogPair);
			return new PrizeActivity?(rootAsPrizeActivity);
		}

		// Token: 0x04003443 RID: 13379
		private const string DB = "db_solarschool.db";

		// Token: 0x04003444 RID: 13380
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x04003445 RID: 13381
		private const string TABLE = "PrizeActivity";

		// Token: 0x04003446 RID: 13382
		private const string COMMAND = "select BinData from `PrizeActivity` where Id=?";

		// Token: 0x04003447 RID: 13383
		private const string KEY_PREFIX = "PrizeActivityById";

		// Token: 0x04003448 RID: 13384
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003449 RID: 13385
		private static int HandleId;
	}
}
