using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000689 RID: 1673
	public class ConfigPhantomBattleWeekExpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002746 RID: 10054 RVA: 0x00137C2B File Offset: 0x00135E2B
		static ConfigPhantomBattleWeekExpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleWeekExpById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleWeekExpById.ResetStaticDefaultValue));
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00137C4C File Offset: 0x00135E4C
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

		// Token: 0x06002748 RID: 10056 RVA: 0x00137CCB File Offset: 0x00135ECB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleWeekExpById.LogPair = null;
			ConfigPhantomBattleWeekExpById.HandleId = 0;
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00137CD9 File Offset: 0x00135ED9
		public static void Init()
		{
			ConfigPhantomBattleWeekExpById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleWeekExpById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleWeekExp` where Id=?");
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x00137CF4 File Offset: 0x00135EF4
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

		// Token: 0x04002DA5 RID: 11685
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DA6 RID: 11686
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DA7 RID: 11687
		private const string TABLE = "PhantomBattleWeekExp";

		// Token: 0x04002DA8 RID: 11688
		private const string COMMAND = "select BinData from `PhantomBattleWeekExp` where Id=?";

		// Token: 0x04002DA9 RID: 11689
		private const string KEY_PREFIX = "PhantomBattleWeekExpById";

		// Token: 0x04002DAA RID: 11690
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DAB RID: 11691
		private static int HandleId;
	}
}
