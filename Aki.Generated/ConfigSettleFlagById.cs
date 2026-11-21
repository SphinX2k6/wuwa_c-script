using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000953 RID: 2387
	public class ConfigSettleFlagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003805 RID: 14341 RVA: 0x001992E3 File Offset: 0x001974E3
		static ConfigSettleFlagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSettleFlagById.CreateStaticDefaultValue), new Action(ConfigSettleFlagById.ResetStaticDefaultValue));
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x00199304 File Offset: 0x00197504
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

		// Token: 0x06003807 RID: 14343 RVA: 0x00199383 File Offset: 0x00197583
		public static void ResetStaticDefaultValue()
		{
			ConfigSettleFlagById.LogPair = null;
			ConfigSettleFlagById.HandleId = 0;
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x00199391 File Offset: 0x00197591
		public static void Init()
		{
			ConfigSettleFlagById.HandleId = ConfigCommon.InitDataStatement(ConfigSettleFlagById.HandleId, "db_teamparkour.db", "select BinData from `SettleFlag` where Id=?");
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x001993AC File Offset: 0x001975AC
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

		// Token: 0x0400412B RID: 16683
		private const string DB = "db_teamparkour.db";

		// Token: 0x0400412C RID: 16684
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x0400412D RID: 16685
		private const string TABLE = "SettleFlag";

		// Token: 0x0400412E RID: 16686
		private const string COMMAND = "select BinData from `SettleFlag` where Id=?";

		// Token: 0x0400412F RID: 16687
		private const string KEY_PREFIX = "SettleFlagById";

		// Token: 0x04004130 RID: 16688
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004131 RID: 16689
		private static int HandleId;
	}
}
