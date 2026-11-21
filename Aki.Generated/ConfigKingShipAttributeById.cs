using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000488 RID: 1160
	public class ConfigKingShipAttributeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B3A RID: 6970 RVA: 0x000F6DE0 File Offset: 0x000F4FE0
		static ConfigKingShipAttributeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKingShipAttributeById.CreateStaticDefaultValue), new Action(ConfigKingShipAttributeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000F6E00 File Offset: 0x000F5000
		public static void CreateStaticDefaultValue()
		{
			ConfigKingShipAttributeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKingShipAttributeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kingship.db"),
				new ValueTuple<string, object>("文件", "w.王权.xlsx"),
				new ValueTuple<string, object>("表名", "KingShipAttribute"),
				new ValueTuple<string, object>("语句", "select BinData from `KingShipAttribute` where Id = ?")
			});
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x000F6E7F File Offset: 0x000F507F
		public static void ResetStaticDefaultValue()
		{
			ConfigKingShipAttributeById.LogPair = null;
			ConfigKingShipAttributeById.HandleId = 0;
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000F6E8D File Offset: 0x000F508D
		public static void Init()
		{
			ConfigKingShipAttributeById.HandleId = ConfigCommon.InitDataStatement(ConfigKingShipAttributeById.HandleId, "db_kingship.db", "select BinData from `KingShipAttribute` where Id = ?");
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000F6EA8 File Offset: 0x000F50A8
		public static KingShipAttribute? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKingShipAttributeById.HandleId, ConfigKingShipAttributeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KingShipAttributeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KingShipAttribute?(KingShipAttribute.GetRootAsKingShipAttribute(configBuffer));
				}
			}
			ConfigKingShipAttributeById.LogPair.Clear();
			ConfigKingShipAttributeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKingShipAttributeById.HandleId, 1, p0Id, ConfigKingShipAttributeById.LogPair) || ConfigCommon.Step(ConfigKingShipAttributeById.HandleId, true, ConfigKingShipAttributeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKingShipAttributeById.HandleId, ConfigKingShipAttributeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKingShipAttributeById.HandleId, 0, ConfigKingShipAttributeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKingShipAttributeById.HandleId, ConfigKingShipAttributeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KingShipAttribute rootAsKingShipAttribute = KingShipAttribute.GetRootAsKingShipAttribute(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KingShipAttributeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKingShipAttributeById.HandleId, ConfigKingShipAttributeById.LogPair);
			return new KingShipAttribute?(rootAsKingShipAttribute);
		}

		// Token: 0x04001F9C RID: 8092
		private const string DB = "db_kingship.db";

		// Token: 0x04001F9D RID: 8093
		private const string FILE = "w.王权.xlsx";

		// Token: 0x04001F9E RID: 8094
		private const string TABLE = "KingShipAttribute";

		// Token: 0x04001F9F RID: 8095
		private const string COMMAND = "select BinData from `KingShipAttribute` where Id = ?";

		// Token: 0x04001FA0 RID: 8096
		private const string KEY_PREFIX = "KingShipAttributeById";

		// Token: 0x04001FA1 RID: 8097
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FA2 RID: 8098
		private static int HandleId;
	}
}
