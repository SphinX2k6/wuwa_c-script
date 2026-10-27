using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200002F RID: 47
	public class ConfigAbyssSettleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00060003 File Offset: 0x0005E203
		static ConfigAbyssSettleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssSettleById.CreateStaticDefaultValue), new Action(ConfigAbyssSettleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00060024 File Offset: 0x0005E224
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssSettleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssSettleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssSettle"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssSettle` where Id=?")
			});
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000600A3 File Offset: 0x0005E2A3
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssSettleById.LogPair = null;
			ConfigAbyssSettleById.HandleId = 0;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000600B1 File Offset: 0x0005E2B1
		public static void Init()
		{
			ConfigAbyssSettleById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssSettleById.HandleId, "db_dangoabyss.db", "select BinData from `AbyssSettle` where Id=?");
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000600CC File Offset: 0x0005E2CC
		public static AbyssSettle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssSettleById.HandleId, ConfigAbyssSettleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssSettleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssSettle?(AbyssSettle.GetRootAsAbyssSettle(configBuffer));
				}
			}
			ConfigAbyssSettleById.LogPair.Clear();
			ConfigAbyssSettleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssSettleById.HandleId, 1, p0Id, ConfigAbyssSettleById.LogPair) || ConfigCommon.Step(ConfigAbyssSettleById.HandleId, true, ConfigAbyssSettleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssSettleById.HandleId, ConfigAbyssSettleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssSettleById.HandleId, 0, ConfigAbyssSettleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssSettleById.HandleId, ConfigAbyssSettleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssSettle rootAsAbyssSettle = AbyssSettle.GetRootAsAbyssSettle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssSettleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssSettleById.HandleId, ConfigAbyssSettleById.LogPair);
			return new AbyssSettle?(rootAsAbyssSettle);
		}

		// Token: 0x0400012D RID: 301
		private const string DB = "db_dangoabyss.db";

		// Token: 0x0400012E RID: 302
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x0400012F RID: 303
		private const string TABLE = "AbyssSettle";

		// Token: 0x04000130 RID: 304
		private const string COMMAND = "select BinData from `AbyssSettle` where Id=?";

		// Token: 0x04000131 RID: 305
		private const string KEY_PREFIX = "AbyssSettleById";

		// Token: 0x04000132 RID: 306
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000133 RID: 307
		private static int HandleId;
	}
}
