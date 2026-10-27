using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000666 RID: 1638
	public class ConfigPhantomBattleCardGroupInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002674 RID: 9844 RVA: 0x00133187 File Offset: 0x00131387
		static ConfigPhantomBattleCardGroupInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardGroupInfoById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardGroupInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x001331A8 File Offset: 0x001313A8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardGroupInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardGroupInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardGroupInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardGroupInfo` where Id=?")
			});
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00133227 File Offset: 0x00131427
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardGroupInfoById.LogPair = null;
			ConfigPhantomBattleCardGroupInfoById.HandleId = 0;
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00133235 File Offset: 0x00131435
		public static void Init()
		{
			ConfigPhantomBattleCardGroupInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardGroupInfoById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardGroupInfo` where Id=?");
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00133250 File Offset: 0x00131450
		public static PhantomBattleCardGroupInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardGroupInfoById.HandleId, ConfigPhantomBattleCardGroupInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardGroupInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleCardGroupInfo?(PhantomBattleCardGroupInfo.GetRootAsPhantomBattleCardGroupInfo(configBuffer));
				}
			}
			ConfigPhantomBattleCardGroupInfoById.LogPair.Clear();
			ConfigPhantomBattleCardGroupInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardGroupInfoById.HandleId, 1, p0Id, ConfigPhantomBattleCardGroupInfoById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleCardGroupInfoById.HandleId, true, ConfigPhantomBattleCardGroupInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardGroupInfoById.HandleId, ConfigPhantomBattleCardGroupInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardGroupInfoById.HandleId, 0, ConfigPhantomBattleCardGroupInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardGroupInfoById.HandleId, ConfigPhantomBattleCardGroupInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleCardGroupInfo rootAsPhantomBattleCardGroupInfo = PhantomBattleCardGroupInfo.GetRootAsPhantomBattleCardGroupInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardGroupInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardGroupInfoById.HandleId, ConfigPhantomBattleCardGroupInfoById.LogPair);
			return new PhantomBattleCardGroupInfo?(rootAsPhantomBattleCardGroupInfo);
		}

		// Token: 0x04002CB0 RID: 11440
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CB1 RID: 11441
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CB2 RID: 11442
		private const string TABLE = "PhantomBattleCardGroupInfo";

		// Token: 0x04002CB3 RID: 11443
		private const string COMMAND = "select BinData from `PhantomBattleCardGroupInfo` where Id=?";

		// Token: 0x04002CB4 RID: 11444
		private const string KEY_PREFIX = "PhantomBattleCardGroupInfoById";

		// Token: 0x04002CB5 RID: 11445
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CB6 RID: 11446
		private static int HandleId;
	}
}
