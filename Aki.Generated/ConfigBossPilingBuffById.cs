using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000114 RID: 276
	public class ConfigBossPilingBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000679 RID: 1657 RVA: 0x00081D94 File Offset: 0x0007FF94
		static ConfigBossPilingBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossPilingBuffById.CreateStaticDefaultValue), new Action(ConfigBossPilingBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00081DB4 File Offset: 0x0007FFB4
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

		// Token: 0x0600067B RID: 1659 RVA: 0x00081E33 File Offset: 0x00080033
		public static void ResetStaticDefaultValue()
		{
			ConfigBossPilingBuffById.LogPair = null;
			ConfigBossPilingBuffById.HandleId = 0;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00081E41 File Offset: 0x00080041
		public static void Init()
		{
			ConfigBossPilingBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigBossPilingBuffById.HandleId, "db_bosspiling.db", "select BinData from `BossPilingBuff` where Id=?");
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00081E5C File Offset: 0x0008005C
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

		// Token: 0x04000770 RID: 1904
		private const string DB = "db_bosspiling.db";

		// Token: 0x04000771 RID: 1905
		private const string FILE = "b.Boss打桩活动.xlsx";

		// Token: 0x04000772 RID: 1906
		private const string TABLE = "BossPilingBuff";

		// Token: 0x04000773 RID: 1907
		private const string COMMAND = "select BinData from `BossPilingBuff` where Id=?";

		// Token: 0x04000774 RID: 1908
		private const string KEY_PREFIX = "BossPilingBuffById";

		// Token: 0x04000775 RID: 1909
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000776 RID: 1910
		private static int HandleId;
	}
}
