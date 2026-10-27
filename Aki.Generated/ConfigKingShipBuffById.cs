using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000473 RID: 1139
	public class ConfigKingShipBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ABC RID: 6844 RVA: 0x000F08D4 File Offset: 0x000EEAD4
		static ConfigKingShipBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKingShipBuffById.CreateStaticDefaultValue), new Action(ConfigKingShipBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x000F08F4 File Offset: 0x000EEAF4
		public static void CreateStaticDefaultValue()
		{
			ConfigKingShipBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKingShipBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kingship.db"),
				new ValueTuple<string, object>("文件", "w.王权.xlsx"),
				new ValueTuple<string, object>("表名", "KingShipBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `KingShipBuff` where Id = ?")
			});
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x000F0973 File Offset: 0x000EEB73
		public static void ResetStaticDefaultValue()
		{
			ConfigKingShipBuffById.LogPair = null;
			ConfigKingShipBuffById.HandleId = 0;
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x000F0981 File Offset: 0x000EEB81
		public static void Init()
		{
			ConfigKingShipBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigKingShipBuffById.HandleId, "db_kingship.db", "select BinData from `KingShipBuff` where Id = ?");
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x000F099C File Offset: 0x000EEB9C
		public static KingShipBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKingShipBuffById.HandleId, ConfigKingShipBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KingShipBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KingShipBuff?(KingShipBuff.GetRootAsKingShipBuff(configBuffer));
				}
			}
			ConfigKingShipBuffById.LogPair.Clear();
			ConfigKingShipBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKingShipBuffById.HandleId, 1, p0Id, ConfigKingShipBuffById.LogPair) || ConfigCommon.Step(ConfigKingShipBuffById.HandleId, true, ConfigKingShipBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKingShipBuffById.HandleId, ConfigKingShipBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKingShipBuffById.HandleId, 0, ConfigKingShipBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKingShipBuffById.HandleId, ConfigKingShipBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KingShipBuff rootAsKingShipBuff = KingShipBuff.GetRootAsKingShipBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KingShipBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKingShipBuffById.HandleId, ConfigKingShipBuffById.LogPair);
			return new KingShipBuff?(rootAsKingShipBuff);
		}

		// Token: 0x04001F09 RID: 7945
		private const string DB = "db_kingship.db";

		// Token: 0x04001F0A RID: 7946
		private const string FILE = "w.王权.xlsx";

		// Token: 0x04001F0B RID: 7947
		private const string TABLE = "KingShipBuff";

		// Token: 0x04001F0C RID: 7948
		private const string COMMAND = "select BinData from `KingShipBuff` where Id = ?";

		// Token: 0x04001F0D RID: 7949
		private const string KEY_PREFIX = "KingShipBuffById";

		// Token: 0x04001F0E RID: 7950
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F0F RID: 7951
		private static int HandleId;
	}
}
