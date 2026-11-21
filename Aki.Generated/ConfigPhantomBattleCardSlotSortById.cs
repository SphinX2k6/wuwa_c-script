using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000685 RID: 1669
	public class ConfigPhantomBattleCardSlotSortById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600272E RID: 10030 RVA: 0x0013AA73 File Offset: 0x00138C73
		static ConfigPhantomBattleCardSlotSortById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardSlotSortById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardSlotSortById.ResetStaticDefaultValue));
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x0013AA94 File Offset: 0x00138C94
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardSlotSortById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardSlotSortById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardSlotSort"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardSlotSort` where Id=?")
			});
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x0013AB13 File Offset: 0x00138D13
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardSlotSortById.LogPair = null;
			ConfigPhantomBattleCardSlotSortById.HandleId = 0;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0013AB21 File Offset: 0x00138D21
		public static void Init()
		{
			ConfigPhantomBattleCardSlotSortById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardSlotSortById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardSlotSort` where Id=?");
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0013AB3C File Offset: 0x00138D3C
		public static PhantomBattleCardSlotSort? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardSlotSortById.HandleId, ConfigPhantomBattleCardSlotSortById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardSlotSortById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleCardSlotSort?(PhantomBattleCardSlotSort.GetRootAsPhantomBattleCardSlotSort(configBuffer));
				}
			}
			ConfigPhantomBattleCardSlotSortById.LogPair.Clear();
			ConfigPhantomBattleCardSlotSortById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardSlotSortById.HandleId, 1, p0Id, ConfigPhantomBattleCardSlotSortById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleCardSlotSortById.HandleId, true, ConfigPhantomBattleCardSlotSortById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardSlotSortById.HandleId, ConfigPhantomBattleCardSlotSortById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardSlotSortById.HandleId, 0, ConfigPhantomBattleCardSlotSortById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardSlotSortById.HandleId, ConfigPhantomBattleCardSlotSortById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleCardSlotSort rootAsPhantomBattleCardSlotSort = PhantomBattleCardSlotSort.GetRootAsPhantomBattleCardSlotSort(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardSlotSortById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardSlotSortById.HandleId, ConfigPhantomBattleCardSlotSortById.LogPair);
			return new PhantomBattleCardSlotSort?(rootAsPhantomBattleCardSlotSort);
		}

		// Token: 0x04002D89 RID: 11657
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D8A RID: 11658
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D8B RID: 11659
		private const string TABLE = "PhantomBattleCardSlotSort";

		// Token: 0x04002D8C RID: 11660
		private const string COMMAND = "select BinData from `PhantomBattleCardSlotSort` where Id=?";

		// Token: 0x04002D8D RID: 11661
		private const string KEY_PREFIX = "PhantomBattleCardSlotSortById";

		// Token: 0x04002D8E RID: 11662
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D8F RID: 11663
		private static int HandleId;
	}
}
