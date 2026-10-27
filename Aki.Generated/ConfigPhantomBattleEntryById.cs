using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000675 RID: 1653
	public class ConfigPhantomBattleEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026CE RID: 9934 RVA: 0x00135250 File Offset: 0x00133450
		static ConfigPhantomBattleEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleEntryById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x00135270 File Offset: 0x00133470
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleEntryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleEntryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战战斗.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleEntry` where Id=?")
			});
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x001352EF File Offset: 0x001334EF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleEntryById.LogPair = null;
			ConfigPhantomBattleEntryById.HandleId = 0;
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x001352FD File Offset: 0x001334FD
		public static void Init()
		{
			ConfigPhantomBattleEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleEntryById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleEntry` where Id=?");
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00135318 File Offset: 0x00133518
		public static PhantomBattleEntry? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleEntryById.HandleId, ConfigPhantomBattleEntryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleEntry?(PhantomBattleEntry.GetRootAsPhantomBattleEntry(configBuffer));
				}
			}
			ConfigPhantomBattleEntryById.LogPair.Clear();
			ConfigPhantomBattleEntryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleEntryById.HandleId, 1, p0Id, ConfigPhantomBattleEntryById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleEntryById.HandleId, true, ConfigPhantomBattleEntryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleEntryById.HandleId, ConfigPhantomBattleEntryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleEntryById.HandleId, 0, ConfigPhantomBattleEntryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleEntryById.HandleId, ConfigPhantomBattleEntryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleEntry rootAsPhantomBattleEntry = PhantomBattleEntry.GetRootAsPhantomBattleEntry(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleEntryById.HandleId, ConfigPhantomBattleEntryById.LogPair);
			return new PhantomBattleEntry?(rootAsPhantomBattleEntry);
		}

		// Token: 0x04002D19 RID: 11545
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D1A RID: 11546
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002D1B RID: 11547
		private const string TABLE = "PhantomBattleEntry";

		// Token: 0x04002D1C RID: 11548
		private const string COMMAND = "select BinData from `PhantomBattleEntry` where Id=?";

		// Token: 0x04002D1D RID: 11549
		private const string KEY_PREFIX = "PhantomBattleEntryById";

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
