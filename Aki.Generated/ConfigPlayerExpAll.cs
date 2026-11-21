using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000757 RID: 1879
	public class ConfigPlayerExpAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C1A RID: 11290 RVA: 0x001564F4 File Offset: 0x001546F4
		static ConfigPlayerExpAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerExpAll.CreateStaticDefaultValue), new Action(ConfigPlayerExpAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00156514 File Offset: 0x00154714
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

		// Token: 0x06002C1C RID: 11292 RVA: 0x00156593 File Offset: 0x00154793
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerExpAll.LogPair = null;
			ConfigPlayerExpAll.HandleId = 0;
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x001565A1 File Offset: 0x001547A1
		public static void Init()
		{
			ConfigPlayerExpAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerExpAll.HandleId, "db_player_exp.db", "select BinData from `PlayerExp`");
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x001565BC File Offset: 0x001547BC
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

		// Token: 0x06002C1F RID: 11295 RVA: 0x001566A4 File Offset: 0x001548A4
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

		// Token: 0x04003347 RID: 13127
		private const string DB = "db_player_exp.db";

		// Token: 0x04003348 RID: 13128
		private const string FILE = "j.经验.xlsx";

		// Token: 0x04003349 RID: 13129
		private const string TABLE = "PlayerExp";

		// Token: 0x0400334A RID: 13130
		private const string COMMAND = "select BinData from `PlayerExp`";

		// Token: 0x0400334B RID: 13131
		private const string KEY_PREFIX = "PlayerExpAll";

		// Token: 0x0400334C RID: 13132
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400334D RID: 13133
		private static int HandleId;
	}
}
