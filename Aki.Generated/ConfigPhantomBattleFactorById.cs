using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000677 RID: 1655
	public class ConfigPhantomBattleFactorById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026DA RID: 9946 RVA: 0x0013562B File Offset: 0x0013382B
		static ConfigPhantomBattleFactorById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleFactorById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleFactorById.ResetStaticDefaultValue));
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x0013564C File Offset: 0x0013384C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleFactorById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleFactorById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战战斗.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleFactor"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleFactor` where Id=?")
			});
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x001356CB File Offset: 0x001338CB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleFactorById.LogPair = null;
			ConfigPhantomBattleFactorById.HandleId = 0;
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x001356D9 File Offset: 0x001338D9
		public static void Init()
		{
			ConfigPhantomBattleFactorById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleFactorById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleFactor` where Id=?");
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x001356F4 File Offset: 0x001338F4
		public static PhantomBattleFactor? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleFactorById.HandleId, ConfigPhantomBattleFactorById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleFactorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleFactor?(PhantomBattleFactor.GetRootAsPhantomBattleFactor(configBuffer));
				}
			}
			ConfigPhantomBattleFactorById.LogPair.Clear();
			ConfigPhantomBattleFactorById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleFactorById.HandleId, 1, p0Id, ConfigPhantomBattleFactorById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleFactorById.HandleId, true, ConfigPhantomBattleFactorById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleFactorById.HandleId, ConfigPhantomBattleFactorById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleFactorById.HandleId, 0, ConfigPhantomBattleFactorById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleFactorById.HandleId, ConfigPhantomBattleFactorById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleFactor rootAsPhantomBattleFactor = PhantomBattleFactor.GetRootAsPhantomBattleFactor(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleFactorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleFactorById.HandleId, ConfigPhantomBattleFactorById.LogPair);
			return new PhantomBattleFactor?(rootAsPhantomBattleFactor);
		}

		// Token: 0x04002D27 RID: 11559
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D28 RID: 11560
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002D29 RID: 11561
		private const string TABLE = "PhantomBattleFactor";

		// Token: 0x04002D2A RID: 11562
		private const string COMMAND = "select BinData from `PhantomBattleFactor` where Id=?";

		// Token: 0x04002D2B RID: 11563
		private const string KEY_PREFIX = "PhantomBattleFactorById";

		// Token: 0x04002D2C RID: 11564
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D2D RID: 11565
		private static int HandleId;
	}
}
