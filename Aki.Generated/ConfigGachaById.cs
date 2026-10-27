using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036D RID: 877
	public class ConfigGachaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001493 RID: 5267 RVA: 0x000CDBA3 File Offset: 0x000CBDA3
		static ConfigGachaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaById.CreateStaticDefaultValue), new Action(ConfigGachaById.ResetStaticDefaultValue));
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x000CDBC4 File Offset: 0x000CBDC4
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "Gacha"),
				new ValueTuple<string, object>("语句", "select BinData from `Gacha` where Id=?")
			});
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x000CDC43 File Offset: 0x000CBE43
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaById.LogPair = null;
			ConfigGachaById.HandleId = 0;
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x000CDC51 File Offset: 0x000CBE51
		public static void Init()
		{
			ConfigGachaById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaById.HandleId, "db_gacha.db", "select BinData from `Gacha` where Id=?");
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000CDC6C File Offset: 0x000CBE6C
		public static Gacha? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaById.HandleId, ConfigGachaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Gacha?(Gacha.GetRootAsGacha(configBuffer));
				}
			}
			ConfigGachaById.LogPair.Clear();
			ConfigGachaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaById.HandleId, 1, p0Id, ConfigGachaById.LogPair) || ConfigCommon.Step(ConfigGachaById.HandleId, true, ConfigGachaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaById.HandleId, ConfigGachaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaById.HandleId, 0, ConfigGachaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaById.HandleId, ConfigGachaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Gacha rootAsGacha = Gacha.GetRootAsGacha(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaById.HandleId, ConfigGachaById.LogPair);
			return new Gacha?(rootAsGacha);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x000CDDE4 File Offset: 0x000CBFE4
		[NullableContext(2)]
		public static IReadOnlyList<Gacha> GetConfigList(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaById.HandleId, ConfigGachaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				IReadOnlyList<Gacha> readOnlyList = (IReadOnlyList<Gacha>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigGachaById.LogPair.Clear();
			ConfigGachaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaById.HandleId, 1, p0Id, ConfigGachaById.LogPair))
			{
				ConfigCommon.Reset(ConfigGachaById.HandleId, ConfigGachaById.LogPair);
				return null;
			}
			List<Gacha> list = new List<Gacha>();
			while (ConfigCommon.Step(ConfigGachaById.HandleId, false, ConfigGachaById.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaById.HandleId, 0, ConfigGachaById.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGachaById.HandleId, ConfigGachaById.LogPair);
					return null;
				}
				Gacha rootAsGacha = Gacha.GetRootAsGacha(new ByteBuffer(item2));
				list.Add(rootAsGacha);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigGachaById.HandleId, ConfigGachaById.LogPair);
			return list;
		}

		// Token: 0x040017DF RID: 6111
		private const string DB = "db_gacha.db";

		// Token: 0x040017E0 RID: 6112
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x040017E1 RID: 6113
		private const string TABLE = "Gacha";

		// Token: 0x040017E2 RID: 6114
		private const string COMMAND = "select BinData from `Gacha` where Id=?";

		// Token: 0x040017E3 RID: 6115
		private const string KEY_PREFIX = "GachaById";

		// Token: 0x040017E4 RID: 6116
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017E5 RID: 6117
		private static int HandleId;
	}
}
