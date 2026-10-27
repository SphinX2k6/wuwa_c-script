using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000740 RID: 1856
	public class ConfigPlayerExpByPlayerLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B91 RID: 11153 RVA: 0x0014FCF3 File Offset: 0x0014DEF3
		static ConfigPlayerExpByPlayerLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerExpByPlayerLevel.CreateStaticDefaultValue), new Action(ConfigPlayerExpByPlayerLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x0014FD14 File Offset: 0x0014DF14
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayerExpByPlayerLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayerExpByPlayerLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_player_exp.db"),
				new ValueTuple<string, object>("文件", "j.经验.xlsx"),
				new ValueTuple<string, object>("表名", "PlayerExp"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayerExp` where PlayerLevel=?")
			});
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x0014FD93 File Offset: 0x0014DF93
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerExpByPlayerLevel.LogPair = null;
			ConfigPlayerExpByPlayerLevel.HandleId = 0;
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x0014FDA1 File Offset: 0x0014DFA1
		public static void Init()
		{
			ConfigPlayerExpByPlayerLevel.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerExpByPlayerLevel.HandleId, "db_player_exp.db", "select BinData from `PlayerExp` where PlayerLevel=?");
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x0014FDBC File Offset: 0x0014DFBC
		public static PlayerExp? GetConfig(int p0PlayerLevel, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerExpByPlayerLevel.HandleId, ConfigPlayerExpByPlayerLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerExpByPlayerLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PlayerLevel);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PlayerExp?(PlayerExp.GetRootAsPlayerExp(configBuffer));
				}
			}
			ConfigPlayerExpByPlayerLevel.LogPair.Clear();
			ConfigPlayerExpByPlayerLevel.LogPair.Add(new ValueTuple<string, object>("PlayerLevel", p0PlayerLevel));
			if (!ConfigCommon.BindInt(ConfigPlayerExpByPlayerLevel.HandleId, 1, p0PlayerLevel, ConfigPlayerExpByPlayerLevel.LogPair) || ConfigCommon.Step(ConfigPlayerExpByPlayerLevel.HandleId, true, ConfigPlayerExpByPlayerLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlayerExpByPlayerLevel.HandleId, ConfigPlayerExpByPlayerLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerExpByPlayerLevel.HandleId, 0, ConfigPlayerExpByPlayerLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlayerExpByPlayerLevel.HandleId, ConfigPlayerExpByPlayerLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlayerExp rootAsPlayerExp = PlayerExp.GetRootAsPlayerExp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerExpByPlayerLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PlayerLevel);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlayerExpByPlayerLevel.HandleId, ConfigPlayerExpByPlayerLevel.LogPair);
			return new PlayerExp?(rootAsPlayerExp);
		}

		// Token: 0x040032A6 RID: 12966
		private const string DB = "db_player_exp.db";

		// Token: 0x040032A7 RID: 12967
		private const string FILE = "j.经验.xlsx";

		// Token: 0x040032A8 RID: 12968
		private const string TABLE = "PlayerExp";

		// Token: 0x040032A9 RID: 12969
		private const string COMMAND = "select BinData from `PlayerExp` where PlayerLevel=?";

		// Token: 0x040032AA RID: 12970
		private const string KEY_PREFIX = "PlayerExpByPlayerLevel";

		// Token: 0x040032AB RID: 12971
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032AC RID: 12972
		private static int HandleId;
	}
}
