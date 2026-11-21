using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000678 RID: 1656
	public class ConfigPhantomBattleCardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026E0 RID: 9952 RVA: 0x00138F17 File Offset: 0x00137117
		static ConfigPhantomBattleCardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardById.ResetStaticDefaultValue));
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00138F38 File Offset: 0x00137138
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCard"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCard` where Id=?")
			});
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00138FB7 File Offset: 0x001371B7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardById.LogPair = null;
			ConfigPhantomBattleCardById.HandleId = 0;
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00138FC5 File Offset: 0x001371C5
		public static void Init()
		{
			ConfigPhantomBattleCardById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCard` where Id=?");
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00138FE0 File Offset: 0x001371E0
		public static PhantomBattleCard? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardById.HandleId, ConfigPhantomBattleCardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleCard?(PhantomBattleCard.GetRootAsPhantomBattleCard(configBuffer));
				}
			}
			ConfigPhantomBattleCardById.LogPair.Clear();
			ConfigPhantomBattleCardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardById.HandleId, 1, p0Id, ConfigPhantomBattleCardById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleCardById.HandleId, true, ConfigPhantomBattleCardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardById.HandleId, ConfigPhantomBattleCardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardById.HandleId, 0, ConfigPhantomBattleCardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardById.HandleId, ConfigPhantomBattleCardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleCard rootAsPhantomBattleCard = PhantomBattleCard.GetRootAsPhantomBattleCard(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardById.HandleId, ConfigPhantomBattleCardById.LogPair);
			return new PhantomBattleCard?(rootAsPhantomBattleCard);
		}

		// Token: 0x04002D2E RID: 11566
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D2F RID: 11567
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D30 RID: 11568
		private const string TABLE = "PhantomBattleCard";

		// Token: 0x04002D31 RID: 11569
		private const string COMMAND = "select BinData from `PhantomBattleCard` where Id=?";

		// Token: 0x04002D32 RID: 11570
		private const string KEY_PREFIX = "PhantomBattleCardById";

		// Token: 0x04002D33 RID: 11571
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D34 RID: 11572
		private static int HandleId;
	}
}
