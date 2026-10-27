using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000664 RID: 1636
	public class ConfigPhantomBattleCardFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002668 RID: 9832 RVA: 0x00132D07 File Offset: 0x00130F07
		static ConfigPhantomBattleCardFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardFilterById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00132D28 File Offset: 0x00130F28
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardFilterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardFilterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardFilter` where Id=?")
			});
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00132DA7 File Offset: 0x00130FA7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardFilterById.LogPair = null;
			ConfigPhantomBattleCardFilterById.HandleId = 0;
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00132DB5 File Offset: 0x00130FB5
		public static void Init()
		{
			ConfigPhantomBattleCardFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardFilterById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardFilter` where Id=?");
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00132DD0 File Offset: 0x00130FD0
		public static PhantomBattleCardFilter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardFilterById.HandleId, ConfigPhantomBattleCardFilterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleCardFilter?(PhantomBattleCardFilter.GetRootAsPhantomBattleCardFilter(configBuffer));
				}
			}
			ConfigPhantomBattleCardFilterById.LogPair.Clear();
			ConfigPhantomBattleCardFilterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardFilterById.HandleId, 1, p0Id, ConfigPhantomBattleCardFilterById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleCardFilterById.HandleId, true, ConfigPhantomBattleCardFilterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardFilterById.HandleId, ConfigPhantomBattleCardFilterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardFilterById.HandleId, 0, ConfigPhantomBattleCardFilterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardFilterById.HandleId, ConfigPhantomBattleCardFilterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleCardFilter rootAsPhantomBattleCardFilter = PhantomBattleCardFilter.GetRootAsPhantomBattleCardFilter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardFilterById.HandleId, ConfigPhantomBattleCardFilterById.LogPair);
			return new PhantomBattleCardFilter?(rootAsPhantomBattleCardFilter);
		}

		// Token: 0x04002CA2 RID: 11426
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CA3 RID: 11427
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CA4 RID: 11428
		private const string TABLE = "PhantomBattleCardFilter";

		// Token: 0x04002CA5 RID: 11429
		private const string COMMAND = "select BinData from `PhantomBattleCardFilter` where Id=?";

		// Token: 0x04002CA6 RID: 11430
		private const string KEY_PREFIX = "PhantomBattleCardFilterById";

		// Token: 0x04002CA7 RID: 11431
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CA8 RID: 11432
		private static int HandleId;
	}
}
