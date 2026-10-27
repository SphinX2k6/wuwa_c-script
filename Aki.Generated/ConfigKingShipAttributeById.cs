using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000472 RID: 1138
	public class ConfigKingShipAttributeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AB6 RID: 6838 RVA: 0x000F068C File Offset: 0x000EE88C
		static ConfigKingShipAttributeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKingShipAttributeById.CreateStaticDefaultValue), new Action(ConfigKingShipAttributeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000F06AC File Offset: 0x000EE8AC
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

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000F072B File Offset: 0x000EE92B
		public static void ResetStaticDefaultValue()
		{
			ConfigKingShipAttributeById.LogPair = null;
			ConfigKingShipAttributeById.HandleId = 0;
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000F0739 File Offset: 0x000EE939
		public static void Init()
		{
			ConfigKingShipAttributeById.HandleId = ConfigCommon.InitDataStatement(ConfigKingShipAttributeById.HandleId, "db_kingship.db", "select BinData from `KingShipAttribute` where Id = ?");
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000F0754 File Offset: 0x000EE954
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

		// Token: 0x04001F02 RID: 7938
		private const string DB = "db_kingship.db";

		// Token: 0x04001F03 RID: 7939
		private const string FILE = "w.王权.xlsx";

		// Token: 0x04001F04 RID: 7940
		private const string TABLE = "KingShipAttribute";

		// Token: 0x04001F05 RID: 7941
		private const string COMMAND = "select BinData from `KingShipAttribute` where Id = ?";

		// Token: 0x04001F06 RID: 7942
		private const string KEY_PREFIX = "KingShipAttributeById";

		// Token: 0x04001F07 RID: 7943
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F08 RID: 7944
		private static int HandleId;
	}
}
