using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036B RID: 875
	public class ConfigGachaAccumulateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001487 RID: 5255 RVA: 0x000CD7C8 File Offset: 0x000CB9C8
		static ConfigGachaAccumulateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaAccumulateById.CreateStaticDefaultValue), new Action(ConfigGachaAccumulateById.ResetStaticDefaultValue));
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x000CD7E8 File Offset: 0x000CB9E8
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaAccumulateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaAccumulateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gachaaccumulate.db"),
				new ValueTuple<string, object>("文件", "c.抽卡累抽.xlsx"),
				new ValueTuple<string, object>("表名", "GachaAccumulate"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaAccumulate` where Id=?")
			});
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x000CD867 File Offset: 0x000CBA67
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaAccumulateById.LogPair = null;
			ConfigGachaAccumulateById.HandleId = 0;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x000CD875 File Offset: 0x000CBA75
		public static void Init()
		{
			ConfigGachaAccumulateById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaAccumulateById.HandleId, "db_gachaaccumulate.db", "select BinData from `GachaAccumulate` where Id=?");
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000CD890 File Offset: 0x000CBA90
		public static GachaAccumulate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaAccumulateById.HandleId, ConfigGachaAccumulateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaAccumulateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaAccumulate?(GachaAccumulate.GetRootAsGachaAccumulate(configBuffer));
				}
			}
			ConfigGachaAccumulateById.LogPair.Clear();
			ConfigGachaAccumulateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaAccumulateById.HandleId, 1, p0Id, ConfigGachaAccumulateById.LogPair) || ConfigCommon.Step(ConfigGachaAccumulateById.HandleId, true, ConfigGachaAccumulateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaAccumulateById.HandleId, ConfigGachaAccumulateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaAccumulateById.HandleId, 0, ConfigGachaAccumulateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaAccumulateById.HandleId, ConfigGachaAccumulateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaAccumulate rootAsGachaAccumulate = GachaAccumulate.GetRootAsGachaAccumulate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaAccumulateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaAccumulateById.HandleId, ConfigGachaAccumulateById.LogPair);
			return new GachaAccumulate?(rootAsGachaAccumulate);
		}

		// Token: 0x040017D1 RID: 6097
		private const string DB = "db_gachaaccumulate.db";

		// Token: 0x040017D2 RID: 6098
		private const string FILE = "c.抽卡累抽.xlsx";

		// Token: 0x040017D3 RID: 6099
		private const string TABLE = "GachaAccumulate";

		// Token: 0x040017D4 RID: 6100
		private const string COMMAND = "select BinData from `GachaAccumulate` where Id=?";

		// Token: 0x040017D5 RID: 6101
		private const string KEY_PREFIX = "GachaAccumulateById";

		// Token: 0x040017D6 RID: 6102
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017D7 RID: 6103
		private static int HandleId;
	}
}
