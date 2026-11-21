using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069B RID: 1691
	public class ConfigPhantomBattleNPCById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027B2 RID: 10162 RVA: 0x0013D9BB File Offset: 0x0013BBBB
		static ConfigPhantomBattleNPCById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleNPCById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleNPCById.ResetStaticDefaultValue));
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x0013D9DC File Offset: 0x0013BBDC
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

		// Token: 0x060027B4 RID: 10164 RVA: 0x0013DA5B File Offset: 0x0013BC5B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleNPCById.LogPair = null;
			ConfigPhantomBattleNPCById.HandleId = 0;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x0013DA69 File Offset: 0x0013BC69
		public static void Init()
		{
			ConfigPhantomBattleNPCById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleNPCById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleNPC` where Id=?");
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x0013DA84 File Offset: 0x0013BC84
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

		// Token: 0x04002E23 RID: 11811
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E24 RID: 11812
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E25 RID: 11813
		private const string TABLE = "PhantomBattleNPC";

		// Token: 0x04002E26 RID: 11814
		private const string COMMAND = "select BinData from `PhantomBattleNPC` where Id=?";

		// Token: 0x04002E27 RID: 11815
		private const string KEY_PREFIX = "PhantomBattleNPCById";

		// Token: 0x04002E28 RID: 11816
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E29 RID: 11817
		private static int HandleId;
	}
}
