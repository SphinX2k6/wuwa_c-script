using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066D RID: 1645
	public class ConfigPhantomBattleCardSlotSortById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600269E RID: 9886 RVA: 0x00133FF7 File Offset: 0x001321F7
		static ConfigPhantomBattleCardSlotSortById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardSlotSortById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardSlotSortById.ResetStaticDefaultValue));
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00134018 File Offset: 0x00132218
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

		// Token: 0x060026A0 RID: 9888 RVA: 0x00134097 File Offset: 0x00132297
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardSlotSortById.LogPair = null;
			ConfigPhantomBattleCardSlotSortById.HandleId = 0;
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x001340A5 File Offset: 0x001322A5
		public static void Init()
		{
			ConfigPhantomBattleCardSlotSortById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardSlotSortById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardSlotSort` where Id=?");
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x001340C0 File Offset: 0x001322C0
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

		// Token: 0x04002CE1 RID: 11489
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CE2 RID: 11490
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CE3 RID: 11491
		private const string TABLE = "PhantomBattleCardSlotSort";

		// Token: 0x04002CE4 RID: 11492
		private const string COMMAND = "select BinData from `PhantomBattleCardSlotSort` where Id=?";

		// Token: 0x04002CE5 RID: 11493
		private const string KEY_PREFIX = "PhantomBattleCardSlotSortById";

		// Token: 0x04002CE6 RID: 11494
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CE7 RID: 11495
		private static int HandleId;
	}
}
