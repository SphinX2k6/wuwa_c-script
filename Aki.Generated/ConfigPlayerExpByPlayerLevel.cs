using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000758 RID: 1880
	public class ConfigPlayerExpByPlayerLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C21 RID: 11297 RVA: 0x0015676F File Offset: 0x0015496F
		static ConfigPlayerExpByPlayerLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerExpByPlayerLevel.CreateStaticDefaultValue), new Action(ConfigPlayerExpByPlayerLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00156790 File Offset: 0x00154990
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

		// Token: 0x06002C23 RID: 11299 RVA: 0x0015680F File Offset: 0x00154A0F
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerExpByPlayerLevel.LogPair = null;
			ConfigPlayerExpByPlayerLevel.HandleId = 0;
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x0015681D File Offset: 0x00154A1D
		public static void Init()
		{
			ConfigPlayerExpByPlayerLevel.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerExpByPlayerLevel.HandleId, "db_player_exp.db", "select BinData from `PlayerExp` where PlayerLevel=?");
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00156838 File Offset: 0x00154A38
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

		// Token: 0x0400334E RID: 13134
		private const string DB = "db_player_exp.db";

		// Token: 0x0400334F RID: 13135
		private const string FILE = "j.经验.xlsx";

		// Token: 0x04003350 RID: 13136
		private const string TABLE = "PlayerExp";

		// Token: 0x04003351 RID: 13137
		private const string COMMAND = "select BinData from `PlayerExp` where PlayerLevel=?";

		// Token: 0x04003352 RID: 13138
		private const string KEY_PREFIX = "PlayerExpByPlayerLevel";

		// Token: 0x04003353 RID: 13139
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003354 RID: 13140
		private static int HandleId;
	}
}
