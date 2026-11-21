using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000759 RID: 1881
	public class ConfigPlayerExpByPlayerLevelArea : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C27 RID: 11303 RVA: 0x001569B8 File Offset: 0x00154BB8
		static ConfigPlayerExpByPlayerLevelArea()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerExpByPlayerLevelArea.CreateStaticDefaultValue), new Action(ConfigPlayerExpByPlayerLevelArea.ResetStaticDefaultValue));
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x001569D8 File Offset: 0x00154BD8
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayerExpByPlayerLevelArea.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayerExpByPlayerLevelArea.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_player_exp.db"),
				new ValueTuple<string, object>("文件", "j.经验.xlsx"),
				new ValueTuple<string, object>("表名", "PlayerExp"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayerExp` where PlayerLevel >= ? AND PlayerLevel < ?")
			});
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x00156A57 File Offset: 0x00154C57
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerExpByPlayerLevelArea.LogPair = null;
			ConfigPlayerExpByPlayerLevelArea.HandleId = 0;
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x00156A65 File Offset: 0x00154C65
		public static void Init()
		{
			ConfigPlayerExpByPlayerLevelArea.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerExpByPlayerLevelArea.HandleId, "db_player_exp.db", "select BinData from `PlayerExp` where PlayerLevel >= ? AND PlayerLevel < ?");
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x00156A80 File Offset: 0x00154C80
		[NullableContext(2)]
		public static IReadOnlyList<PlayerExp> GetConfigList(int p0PlayerLevel, int p1PlayerLevel, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerExpByPlayerLevelArea.HandleId, ConfigPlayerExpByPlayerLevelArea.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerExpByPlayerLevelArea");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PlayerLevel);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1PlayerLevel);
				IReadOnlyList<PlayerExp> readOnlyList = (IReadOnlyList<PlayerExp>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPlayerExpByPlayerLevelArea.LogPair.Clear();
			ConfigPlayerExpByPlayerLevelArea.LogPair.Add(new ValueTuple<string, object>("PlayerLevel", p0PlayerLevel));
			ConfigPlayerExpByPlayerLevelArea.LogPair.Add(new ValueTuple<string, object>("PlayerLevel", p1PlayerLevel));
			if (!ConfigCommon.BindInt(ConfigPlayerExpByPlayerLevelArea.HandleId, 1, p0PlayerLevel, ConfigPlayerExpByPlayerLevelArea.LogPair) || !ConfigCommon.BindInt(ConfigPlayerExpByPlayerLevelArea.HandleId, 2, p1PlayerLevel, ConfigPlayerExpByPlayerLevelArea.LogPair))
			{
				ConfigCommon.Reset(ConfigPlayerExpByPlayerLevelArea.HandleId, ConfigPlayerExpByPlayerLevelArea.LogPair);
				return null;
			}
			List<PlayerExp> list = new List<PlayerExp>();
			while (ConfigCommon.Step(ConfigPlayerExpByPlayerLevelArea.HandleId, false, ConfigPlayerExpByPlayerLevelArea.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerExpByPlayerLevelArea.HandleId, 0, ConfigPlayerExpByPlayerLevelArea.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPlayerExpByPlayerLevelArea.HandleId, ConfigPlayerExpByPlayerLevelArea.LogPair);
					return null;
				}
				PlayerExp rootAsPlayerExp = PlayerExp.GetRootAsPlayerExp(new ByteBuffer(item2));
				list.Add(rootAsPlayerExp);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerExpByPlayerLevelArea");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PlayerLevel);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1PlayerLevel);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPlayerExpByPlayerLevelArea.HandleId, ConfigPlayerExpByPlayerLevelArea.LogPair);
			return list;
		}

		// Token: 0x04003355 RID: 13141
		private const string DB = "db_player_exp.db";

		// Token: 0x04003356 RID: 13142
		private const string FILE = "j.经验.xlsx";

		// Token: 0x04003357 RID: 13143
		private const string TABLE = "PlayerExp";

		// Token: 0x04003358 RID: 13144
		private const string COMMAND = "select BinData from `PlayerExp` where PlayerLevel >= ? AND PlayerLevel < ?";

		// Token: 0x04003359 RID: 13145
		private const string KEY_PREFIX = "PlayerExpByPlayerLevelArea";

		// Token: 0x0400335A RID: 13146
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400335B RID: 13147
		private static int HandleId;
	}
}
