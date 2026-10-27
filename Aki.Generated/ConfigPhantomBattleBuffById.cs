using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065D RID: 1629
	public class ConfigPhantomBattleBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600263E RID: 9790 RVA: 0x00131E88 File Offset: 0x00130088
		static ConfigPhantomBattleBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBuffById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00131EA8 File Offset: 0x001300A8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战战斗.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleBuff` where Id=?")
			});
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x00131F27 File Offset: 0x00130127
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBuffById.LogPair = null;
			ConfigPhantomBattleBuffById.HandleId = 0;
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00131F35 File Offset: 0x00130135
		public static void Init()
		{
			ConfigPhantomBattleBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBuffById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBuff` where Id=?");
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00131F50 File Offset: 0x00130150
		public static PhantomBattleBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleBuffById.HandleId, ConfigPhantomBattleBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleBuff?(PhantomBattleBuff.GetRootAsPhantomBattleBuff(configBuffer));
				}
			}
			ConfigPhantomBattleBuffById.LogPair.Clear();
			ConfigPhantomBattleBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleBuffById.HandleId, 1, p0Id, ConfigPhantomBattleBuffById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleBuffById.HandleId, true, ConfigPhantomBattleBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleBuffById.HandleId, ConfigPhantomBattleBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleBuffById.HandleId, 0, ConfigPhantomBattleBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleBuffById.HandleId, ConfigPhantomBattleBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleBuff rootAsPhantomBattleBuff = PhantomBattleBuff.GetRootAsPhantomBattleBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleBuffById.HandleId, ConfigPhantomBattleBuffById.LogPair);
			return new PhantomBattleBuff?(rootAsPhantomBattleBuff);
		}

		// Token: 0x04002C71 RID: 11377
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C72 RID: 11378
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002C73 RID: 11379
		private const string TABLE = "PhantomBattleBuff";

		// Token: 0x04002C74 RID: 11380
		private const string COMMAND = "select BinData from `PhantomBattleBuff` where Id=?";

		// Token: 0x04002C75 RID: 11381
		private const string KEY_PREFIX = "PhantomBattleBuffById";

		// Token: 0x04002C76 RID: 11382
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C77 RID: 11383
		private static int HandleId;
	}
}
