using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076F RID: 1903
	public class ConfigPreheatBonusById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CAB RID: 11435 RVA: 0x0015952B File Offset: 0x0015772B
		static ConfigPreheatBonusById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatBonusById.CreateStaticDefaultValue), new Action(ConfigPreheatBonusById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x0015954C File Offset: 0x0015774C
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

		// Token: 0x06002CAD RID: 11437 RVA: 0x001595CB File Offset: 0x001577CB
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatBonusById.LogPair = null;
			ConfigPreheatBonusById.HandleId = 0;
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x001595D9 File Offset: 0x001577D9
		public static void Init()
		{
			ConfigPreheatBonusById.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatBonusById.HandleId, "db_preheat.db", "select BinData from `PreheatBonus` where Id=?");
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x001595F4 File Offset: 0x001577F4
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

		// Token: 0x040033EF RID: 13295
		private const string DB = "db_preheat.db";

		// Token: 0x040033F0 RID: 13296
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x040033F1 RID: 13297
		private const string TABLE = "PreheatBonus";

		// Token: 0x040033F2 RID: 13298
		private const string COMMAND = "select BinData from `PreheatBonus` where Id=?";

		// Token: 0x040033F3 RID: 13299
		private const string KEY_PREFIX = "PreheatBonusById";

		// Token: 0x040033F4 RID: 13300
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033F5 RID: 13301
		private static int HandleId;
	}
}
