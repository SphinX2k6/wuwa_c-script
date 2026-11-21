using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067C RID: 1660
	public class ConfigPhantomBattleCardFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026F8 RID: 9976 RVA: 0x00139783 File Offset: 0x00137983
		static ConfigPhantomBattleCardFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardFilterById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x001397A4 File Offset: 0x001379A4
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

		// Token: 0x060026FA RID: 9978 RVA: 0x00139823 File Offset: 0x00137A23
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardFilterById.LogPair = null;
			ConfigPhantomBattleCardFilterById.HandleId = 0;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00139831 File Offset: 0x00137A31
		public static void Init()
		{
			ConfigPhantomBattleCardFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardFilterById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardFilter` where Id=?");
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x0013984C File Offset: 0x00137A4C
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

		// Token: 0x04002D4A RID: 11594
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D4B RID: 11595
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D4C RID: 11596
		private const string TABLE = "PhantomBattleCardFilter";

		// Token: 0x04002D4D RID: 11597
		private const string COMMAND = "select BinData from `PhantomBattleCardFilter` where Id=?";

		// Token: 0x04002D4E RID: 11598
		private const string KEY_PREFIX = "PhantomBattleCardFilterById";

		// Token: 0x04002D4F RID: 11599
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D50 RID: 11600
		private static int HandleId;
	}
}
