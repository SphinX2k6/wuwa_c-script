using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A1 RID: 1697
	public class ConfigPhantomBattleWeekExpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027D6 RID: 10198 RVA: 0x0013E6A7 File Offset: 0x0013C8A7
		static ConfigPhantomBattleWeekExpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleWeekExpById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleWeekExpById.ResetStaticDefaultValue));
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x0013E6C8 File Offset: 0x0013C8C8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleWeekExpById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleWeekExpById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleWeekExp"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleWeekExp` where Id=?")
			});
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x0013E747 File Offset: 0x0013C947
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleWeekExpById.LogPair = null;
			ConfigPhantomBattleWeekExpById.HandleId = 0;
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x0013E755 File Offset: 0x0013C955
		public static void Init()
		{
			ConfigPhantomBattleWeekExpById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleWeekExpById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleWeekExp` where Id=?");
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x0013E770 File Offset: 0x0013C970
		public static PhantomBattleWeekExp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleWeekExpById.HandleId, ConfigPhantomBattleWeekExpById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleWeekExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleWeekExp?(PhantomBattleWeekExp.GetRootAsPhantomBattleWeekExp(configBuffer));
				}
			}
			ConfigPhantomBattleWeekExpById.LogPair.Clear();
			ConfigPhantomBattleWeekExpById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleWeekExpById.HandleId, 1, p0Id, ConfigPhantomBattleWeekExpById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleWeekExpById.HandleId, true, ConfigPhantomBattleWeekExpById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleWeekExpById.HandleId, ConfigPhantomBattleWeekExpById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleWeekExpById.HandleId, 0, ConfigPhantomBattleWeekExpById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleWeekExpById.HandleId, ConfigPhantomBattleWeekExpById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleWeekExp rootAsPhantomBattleWeekExp = PhantomBattleWeekExp.GetRootAsPhantomBattleWeekExp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleWeekExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleWeekExpById.HandleId, ConfigPhantomBattleWeekExpById.LogPair);
			return new PhantomBattleWeekExp?(rootAsPhantomBattleWeekExp);
		}

		// Token: 0x04002E4D RID: 11853
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E4E RID: 11854
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E4F RID: 11855
		private const string TABLE = "PhantomBattleWeekExp";

		// Token: 0x04002E50 RID: 11856
		private const string COMMAND = "select BinData from `PhantomBattleWeekExp` where Id=?";

		// Token: 0x04002E51 RID: 11857
		private const string KEY_PREFIX = "PhantomBattleWeekExpById";

		// Token: 0x04002E52 RID: 11858
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E53 RID: 11859
		private static int HandleId;
	}
}
