using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000105 RID: 261
	public class ConfigBossPilingBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600061F RID: 1567 RVA: 0x0007C430 File Offset: 0x0007A630
		static ConfigBossPilingBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossPilingBuffById.CreateStaticDefaultValue), new Action(ConfigBossPilingBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0007C450 File Offset: 0x0007A650
		public static void CreateStaticDefaultValue()
		{
			ConfigBossPilingBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossPilingBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bosspiling.db"),
				new ValueTuple<string, object>("文件", "b.Boss打桩活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossPilingBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `BossPilingBuff` where Id=?")
			});
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0007C4CF File Offset: 0x0007A6CF
		public static void ResetStaticDefaultValue()
		{
			ConfigBossPilingBuffById.LogPair = null;
			ConfigBossPilingBuffById.HandleId = 0;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0007C4DD File Offset: 0x0007A6DD
		public static void Init()
		{
			ConfigBossPilingBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigBossPilingBuffById.HandleId, "db_bosspiling.db", "select BinData from `BossPilingBuff` where Id=?");
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0007C4F8 File Offset: 0x0007A6F8
		public static BossPilingBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossPilingBuffById.HandleId, ConfigBossPilingBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossPilingBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossPilingBuff?(BossPilingBuff.GetRootAsBossPilingBuff(configBuffer));
				}
			}
			ConfigBossPilingBuffById.LogPair.Clear();
			ConfigBossPilingBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBossPilingBuffById.HandleId, 1, p0Id, ConfigBossPilingBuffById.LogPair) || ConfigCommon.Step(ConfigBossPilingBuffById.HandleId, true, ConfigBossPilingBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossPilingBuffById.HandleId, ConfigBossPilingBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossPilingBuffById.HandleId, 0, ConfigBossPilingBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossPilingBuffById.HandleId, ConfigBossPilingBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossPilingBuff rootAsBossPilingBuff = BossPilingBuff.GetRootAsBossPilingBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossPilingBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossPilingBuffById.HandleId, ConfigBossPilingBuffById.LogPair);
			return new BossPilingBuff?(rootAsBossPilingBuff);
		}

		// Token: 0x04000707 RID: 1799
		private const string DB = "db_bosspiling.db";

		// Token: 0x04000708 RID: 1800
		private const string FILE = "b.Boss打桩活动.xlsx";

		// Token: 0x04000709 RID: 1801
		private const string TABLE = "BossPilingBuff";

		// Token: 0x0400070A RID: 1802
		private const string COMMAND = "select BinData from `BossPilingBuff` where Id=?";

		// Token: 0x0400070B RID: 1803
		private const string KEY_PREFIX = "BossPilingBuffById";

		// Token: 0x0400070C RID: 1804
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400070D RID: 1805
		private static int HandleId;
	}
}
