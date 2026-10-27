using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000908 RID: 2312
	public class ConfigSettleFlagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003643 RID: 13891 RVA: 0x0018C0C3 File Offset: 0x0018A2C3
		static ConfigSettleFlagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSettleFlagById.CreateStaticDefaultValue), new Action(ConfigSettleFlagById.ResetStaticDefaultValue));
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x0018C0E4 File Offset: 0x0018A2E4
		public static void CreateStaticDefaultValue()
		{
			ConfigSettleFlagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSettleFlagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teamparkour.db"),
				new ValueTuple<string, object>("文件", "l.联机跑酷活动.xlsx"),
				new ValueTuple<string, object>("表名", "SettleFlag"),
				new ValueTuple<string, object>("语句", "select BinData from `SettleFlag` where Id=?")
			});
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x0018C163 File Offset: 0x0018A363
		public static void ResetStaticDefaultValue()
		{
			ConfigSettleFlagById.LogPair = null;
			ConfigSettleFlagById.HandleId = 0;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0018C171 File Offset: 0x0018A371
		public static void Init()
		{
			ConfigSettleFlagById.HandleId = ConfigCommon.InitDataStatement(ConfigSettleFlagById.HandleId, "db_teamparkour.db", "select BinData from `SettleFlag` where Id=?");
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x0018C18C File Offset: 0x0018A38C
		public static SettleFlag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSettleFlagById.HandleId, ConfigSettleFlagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SettleFlagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SettleFlag?(SettleFlag.GetRootAsSettleFlag(configBuffer));
				}
			}
			ConfigSettleFlagById.LogPair.Clear();
			ConfigSettleFlagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSettleFlagById.HandleId, 1, p0Id, ConfigSettleFlagById.LogPair) || ConfigCommon.Step(ConfigSettleFlagById.HandleId, true, ConfigSettleFlagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSettleFlagById.HandleId, ConfigSettleFlagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSettleFlagById.HandleId, 0, ConfigSettleFlagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSettleFlagById.HandleId, ConfigSettleFlagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SettleFlag rootAsSettleFlag = SettleFlag.GetRootAsSettleFlag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SettleFlagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSettleFlagById.HandleId, ConfigSettleFlagById.LogPair);
			return new SettleFlag?(rootAsSettleFlag);
		}

		// Token: 0x04003F1E RID: 16158
		private const string DB = "db_teamparkour.db";

		// Token: 0x04003F1F RID: 16159
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x04003F20 RID: 16160
		private const string TABLE = "SettleFlag";

		// Token: 0x04003F21 RID: 16161
		private const string COMMAND = "select BinData from `SettleFlag` where Id=?";

		// Token: 0x04003F22 RID: 16162
		private const string KEY_PREFIX = "SettleFlagById";

		// Token: 0x04003F23 RID: 16163
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F24 RID: 16164
		private static int HandleId;
	}
}
