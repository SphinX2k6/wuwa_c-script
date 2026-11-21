using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000382 RID: 898
	public class ConfigGachaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001511 RID: 5393 RVA: 0x000D40AF File Offset: 0x000D22AF
		static ConfigGachaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaById.CreateStaticDefaultValue), new Action(ConfigGachaById.ResetStaticDefaultValue));
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000D40D0 File Offset: 0x000D22D0
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

		// Token: 0x06001513 RID: 5395 RVA: 0x000D414F File Offset: 0x000D234F
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaById.LogPair = null;
			ConfigGachaById.HandleId = 0;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000D415D File Offset: 0x000D235D
		public static void Init()
		{
			ConfigGachaById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaById.HandleId, "db_gacha.db", "select BinData from `Gacha` where Id=?");
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000D4178 File Offset: 0x000D2378
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

		// Token: 0x06001516 RID: 5398 RVA: 0x000D42F0 File Offset: 0x000D24F0
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

		// Token: 0x04001872 RID: 6258
		private const string DB = "db_gacha.db";

		// Token: 0x04001873 RID: 6259
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x04001874 RID: 6260
		private const string TABLE = "Gacha";

		// Token: 0x04001875 RID: 6261
		private const string COMMAND = "select BinData from `Gacha` where Id=?";

		// Token: 0x04001876 RID: 6262
		private const string KEY_PREFIX = "GachaById";

		// Token: 0x04001877 RID: 6263
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001878 RID: 6264
		private static int HandleId;
	}
}
