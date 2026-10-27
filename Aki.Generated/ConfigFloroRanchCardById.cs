using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000312 RID: 786
	public class ConfigFloroRanchCardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001271 RID: 4721 RVA: 0x000C1C1B File Offset: 0x000BFE1B
		static ConfigFloroRanchCardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCardById.CreateStaticDefaultValue), new Action(ConfigFloroRanchCardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x000C1C3C File Offset: 0x000BFE3C
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchCardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchCardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchCard"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchCard` where Id=?")
			});
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x000C1CBB File Offset: 0x000BFEBB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCardById.LogPair = null;
			ConfigFloroRanchCardById.HandleId = 0;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x000C1CC9 File Offset: 0x000BFEC9
		public static void Init()
		{
			ConfigFloroRanchCardById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCardById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCard` where Id=?");
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000C1CE4 File Offset: 0x000BFEE4
		public static FloroRanchCard? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchCardById.HandleId, ConfigFloroRanchCardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchCard?(FloroRanchCard.GetRootAsFloroRanchCard(configBuffer));
				}
			}
			ConfigFloroRanchCardById.LogPair.Clear();
			ConfigFloroRanchCardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchCardById.HandleId, 1, p0Id, ConfigFloroRanchCardById.LogPair) || ConfigCommon.Step(ConfigFloroRanchCardById.HandleId, true, ConfigFloroRanchCardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchCardById.HandleId, ConfigFloroRanchCardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchCardById.HandleId, 0, ConfigFloroRanchCardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchCardById.HandleId, ConfigFloroRanchCardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchCard rootAsFloroRanchCard = FloroRanchCard.GetRootAsFloroRanchCard(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchCardById.HandleId, ConfigFloroRanchCardById.LogPair);
			return new FloroRanchCard?(rootAsFloroRanchCard);
		}

		// Token: 0x04001562 RID: 5474
		private const string DB = "db_flororanch.db";

		// Token: 0x04001563 RID: 5475
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001564 RID: 5476
		private const string TABLE = "FloroRanchCard";

		// Token: 0x04001565 RID: 5477
		private const string COMMAND = "select BinData from `FloroRanchCard` where Id=?";

		// Token: 0x04001566 RID: 5478
		private const string KEY_PREFIX = "FloroRanchCardById";

		// Token: 0x04001567 RID: 5479
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001568 RID: 5480
		private static int HandleId;
	}
}
