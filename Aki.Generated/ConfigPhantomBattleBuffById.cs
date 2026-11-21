using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000675 RID: 1653
	public class ConfigPhantomBattleBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026CE RID: 9934 RVA: 0x00138904 File Offset: 0x00136B04
		static ConfigPhantomBattleBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBuffById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x00138924 File Offset: 0x00136B24
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

		// Token: 0x060026D0 RID: 9936 RVA: 0x001389A3 File Offset: 0x00136BA3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBuffById.LogPair = null;
			ConfigPhantomBattleBuffById.HandleId = 0;
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x001389B1 File Offset: 0x00136BB1
		public static void Init()
		{
			ConfigPhantomBattleBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBuffById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBuff` where Id=?");
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x001389CC File Offset: 0x00136BCC
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

		// Token: 0x04002D19 RID: 11545
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D1A RID: 11546
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002D1B RID: 11547
		private const string TABLE = "PhantomBattleBuff";

		// Token: 0x04002D1C RID: 11548
		private const string COMMAND = "select BinData from `PhantomBattleBuff` where Id=?";

		// Token: 0x04002D1D RID: 11549
		private const string KEY_PREFIX = "PhantomBattleBuffById";

		// Token: 0x04002D1E RID: 11550
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D1F RID: 11551
		private static int HandleId;
	}
}
