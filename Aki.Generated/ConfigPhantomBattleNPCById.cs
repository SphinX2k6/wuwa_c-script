using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000683 RID: 1667
	public class ConfigPhantomBattleNPCById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002722 RID: 10018 RVA: 0x00136F3F File Offset: 0x0013513F
		static ConfigPhantomBattleNPCById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleNPCById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleNPCById.ResetStaticDefaultValue));
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00136F60 File Offset: 0x00135160
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleNPCById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleNPCById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleNPC"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleNPC` where Id=?")
			});
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00136FDF File Offset: 0x001351DF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleNPCById.LogPair = null;
			ConfigPhantomBattleNPCById.HandleId = 0;
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00136FED File Offset: 0x001351ED
		public static void Init()
		{
			ConfigPhantomBattleNPCById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleNPCById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleNPC` where Id=?");
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00137008 File Offset: 0x00135208
		public static PhantomBattleNPC? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleNPCById.HandleId, ConfigPhantomBattleNPCById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleNPCById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleNPC?(PhantomBattleNPC.GetRootAsPhantomBattleNPC(configBuffer));
				}
			}
			ConfigPhantomBattleNPCById.LogPair.Clear();
			ConfigPhantomBattleNPCById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleNPCById.HandleId, 1, p0Id, ConfigPhantomBattleNPCById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleNPCById.HandleId, true, ConfigPhantomBattleNPCById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleNPCById.HandleId, ConfigPhantomBattleNPCById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleNPCById.HandleId, 0, ConfigPhantomBattleNPCById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleNPCById.HandleId, ConfigPhantomBattleNPCById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleNPC rootAsPhantomBattleNPC = PhantomBattleNPC.GetRootAsPhantomBattleNPC(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleNPCById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleNPCById.HandleId, ConfigPhantomBattleNPCById.LogPair);
			return new PhantomBattleNPC?(rootAsPhantomBattleNPC);
		}

		// Token: 0x04002D7B RID: 11643
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D7C RID: 11644
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D7D RID: 11645
		private const string TABLE = "PhantomBattleNPC";

		// Token: 0x04002D7E RID: 11646
		private const string COMMAND = "select BinData from `PhantomBattleNPC` where Id=?";

		// Token: 0x04002D7F RID: 11647
		private const string KEY_PREFIX = "PhantomBattleNPCById";

		// Token: 0x04002D80 RID: 11648
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D81 RID: 11649
		private static int HandleId;
	}
}
