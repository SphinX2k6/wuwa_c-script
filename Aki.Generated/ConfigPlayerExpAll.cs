using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073F RID: 1855
	public class ConfigPlayerExpAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B8A RID: 11146 RVA: 0x0014FA78 File Offset: 0x0014DC78
		static ConfigPlayerExpAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerExpAll.CreateStaticDefaultValue), new Action(ConfigPlayerExpAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x0014FA98 File Offset: 0x0014DC98
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayerExpAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayerExpAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_player_exp.db"),
				new ValueTuple<string, object>("文件", "j.经验.xlsx"),
				new ValueTuple<string, object>("表名", "PlayerExp"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayerExp`")
			});
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x0014FB17 File Offset: 0x0014DD17
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerExpAll.LogPair = null;
			ConfigPlayerExpAll.HandleId = 0;
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x0014FB25 File Offset: 0x0014DD25
		public static void Init()
		{
			ConfigPlayerExpAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerExpAll.HandleId, "db_player_exp.db", "select BinData from `PlayerExp`");
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x0014FB40 File Offset: 0x0014DD40
		public static PlayerExp? GetConfig(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerExpAll.HandleId, ConfigPlayerExpAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("PlayerExpAll");
				if (configBuffer != null)
				{
					return new PlayerExp?(PlayerExp.GetRootAsPlayerExp(configBuffer));
				}
			}
			if (ConfigCommon.Step(ConfigPlayerExpAll.HandleId, true, ConfigPlayerExpAll.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlayerExpAll.HandleId, ConfigPlayerExpAll.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerExpAll.HandleId, 0, ConfigPlayerExpAll.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlayerExpAll.HandleId, ConfigPlayerExpAll.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlayerExp rootAsPlayerExp = PlayerExp.GetRootAsPlayerExp(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("PlayerExpAll", byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlayerExpAll.HandleId, ConfigPlayerExpAll.LogPair);
			return new PlayerExp?(rootAsPlayerExp);
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x0014FC28 File Offset: 0x0014DE28
		[NullableContext(2)]
		public static IReadOnlyList<PlayerExp> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerExpAll.HandleId, ConfigPlayerExpAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PlayerExp> readOnlyList = (IReadOnlyList<PlayerExp>)ConfigCommon.GetConfig("PlayerExpAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PlayerExp> list = new List<PlayerExp>();
			while (ConfigCommon.Step(ConfigPlayerExpAll.HandleId, false, ConfigPlayerExpAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerExpAll.HandleId, 0, ConfigPlayerExpAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPlayerExpAll.HandleId, ConfigPlayerExpAll.LogPair);
					return null;
				}
				PlayerExp rootAsPlayerExp = PlayerExp.GetRootAsPlayerExp(new ByteBuffer(item2));
				list.Add(rootAsPlayerExp);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PlayerExpAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPlayerExpAll.HandleId, ConfigPlayerExpAll.LogPair);
			return list;
		}

		// Token: 0x0400329F RID: 12959
		private const string DB = "db_player_exp.db";

		// Token: 0x040032A0 RID: 12960
		private const string FILE = "j.经验.xlsx";

		// Token: 0x040032A1 RID: 12961
		private const string TABLE = "PlayerExp";

		// Token: 0x040032A2 RID: 12962
		private const string COMMAND = "select BinData from `PlayerExp`";

		// Token: 0x040032A3 RID: 12963
		private const string KEY_PREFIX = "PlayerExpAll";

		// Token: 0x040032A4 RID: 12964
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032A5 RID: 12965
		private static int HandleId;
	}
}
