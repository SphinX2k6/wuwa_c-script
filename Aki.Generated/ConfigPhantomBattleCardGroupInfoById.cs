using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067E RID: 1662
	public class ConfigPhantomBattleCardGroupInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002704 RID: 9988 RVA: 0x00139C03 File Offset: 0x00137E03
		static ConfigPhantomBattleCardGroupInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardGroupInfoById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardGroupInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00139C24 File Offset: 0x00137E24
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

		// Token: 0x06002706 RID: 9990 RVA: 0x00139CA3 File Offset: 0x00137EA3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardGroupInfoById.LogPair = null;
			ConfigPhantomBattleCardGroupInfoById.HandleId = 0;
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00139CB1 File Offset: 0x00137EB1
		public static void Init()
		{
			ConfigPhantomBattleCardGroupInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardGroupInfoById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardGroupInfo` where Id=?");
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00139CCC File Offset: 0x00137ECC
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

		// Token: 0x04002D58 RID: 11608
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D59 RID: 11609
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D5A RID: 11610
		private const string TABLE = "PhantomBattleCardGroupInfo";

		// Token: 0x04002D5B RID: 11611
		private const string COMMAND = "select BinData from `PhantomBattleCardGroupInfo` where Id=?";

		// Token: 0x04002D5C RID: 11612
		private const string KEY_PREFIX = "PhantomBattleCardGroupInfoById";

		// Token: 0x04002D5D RID: 11613
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D5E RID: 11614
		private static int HandleId;
	}
}
