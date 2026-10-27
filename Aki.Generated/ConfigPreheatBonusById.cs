using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000757 RID: 1879
	public class ConfigPreheatBonusById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C1B RID: 11291 RVA: 0x00152AAF File Offset: 0x00150CAF
		static ConfigPreheatBonusById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatBonusById.CreateStaticDefaultValue), new Action(ConfigPreheatBonusById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00152AD0 File Offset: 0x00150CD0
		public static void CreateStaticDefaultValue()
		{
			ConfigPreheatBonusById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreheatBonusById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_preheat.db"),
				new ValueTuple<string, object>("文件", "y.预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "PreheatBonus"),
				new ValueTuple<string, object>("语句", "select BinData from `PreheatBonus` where Id=?")
			});
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00152B4F File Offset: 0x00150D4F
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatBonusById.LogPair = null;
			ConfigPreheatBonusById.HandleId = 0;
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x00152B5D File Offset: 0x00150D5D
		public static void Init()
		{
			ConfigPreheatBonusById.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatBonusById.HandleId, "db_preheat.db", "select BinData from `PreheatBonus` where Id=?");
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x00152B78 File Offset: 0x00150D78
		public static PreheatBonus? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreheatBonusById.HandleId, ConfigPreheatBonusById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreheatBonusById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PreheatBonus?(PreheatBonus.GetRootAsPreheatBonus(configBuffer));
				}
			}
			ConfigPreheatBonusById.LogPair.Clear();
			ConfigPreheatBonusById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPreheatBonusById.HandleId, 1, p0Id, ConfigPreheatBonusById.LogPair) || ConfigCommon.Step(ConfigPreheatBonusById.HandleId, true, ConfigPreheatBonusById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPreheatBonusById.HandleId, ConfigPreheatBonusById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreheatBonusById.HandleId, 0, ConfigPreheatBonusById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPreheatBonusById.HandleId, ConfigPreheatBonusById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PreheatBonus rootAsPreheatBonus = PreheatBonus.GetRootAsPreheatBonus(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreheatBonusById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPreheatBonusById.HandleId, ConfigPreheatBonusById.LogPair);
			return new PreheatBonus?(rootAsPreheatBonus);
		}

		// Token: 0x04003347 RID: 13127
		private const string DB = "db_preheat.db";

		// Token: 0x04003348 RID: 13128
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x04003349 RID: 13129
		private const string TABLE = "PreheatBonus";

		// Token: 0x0400334A RID: 13130
		private const string COMMAND = "select BinData from `PreheatBonus` where Id=?";

		// Token: 0x0400334B RID: 13131
		private const string KEY_PREFIX = "PreheatBonusById";

		// Token: 0x0400334C RID: 13132
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400334D RID: 13133
		private static int HandleId;
	}
}
