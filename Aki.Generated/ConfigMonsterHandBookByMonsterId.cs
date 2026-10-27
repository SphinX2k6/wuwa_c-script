using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000551 RID: 1361
	public class ConfigMonsterHandBookByMonsterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FF3 RID: 8179 RVA: 0x0010DF18 File Offset: 0x0010C118
		static ConfigMonsterHandBookByMonsterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookByMonsterId.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookByMonsterId.ResetStaticDefaultValue));
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0010DF38 File Offset: 0x0010C138
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterHandBookByMonsterId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterHandBookByMonsterId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterHandBook` where MonsterId=?")
			});
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0010DFB7 File Offset: 0x0010C1B7
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookByMonsterId.LogPair = null;
			ConfigMonsterHandBookByMonsterId.HandleId = 0;
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0010DFC5 File Offset: 0x0010C1C5
		public static void Init()
		{
			ConfigMonsterHandBookByMonsterId.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookByMonsterId.HandleId, "db_handbook.db", "select BinData from `MonsterHandBook` where MonsterId=?");
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0010DFE0 File Offset: 0x0010C1E0
		public static MonsterHandBook? GetConfig(int p0MonsterId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterHandBookByMonsterId.HandleId, ConfigMonsterHandBookByMonsterId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterHandBookByMonsterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MonsterId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterHandBook?(MonsterHandBook.GetRootAsMonsterHandBook(configBuffer));
				}
			}
			ConfigMonsterHandBookByMonsterId.LogPair.Clear();
			ConfigMonsterHandBookByMonsterId.LogPair.Add(new ValueTuple<string, object>("MonsterId", p0MonsterId));
			if (!ConfigCommon.BindInt(ConfigMonsterHandBookByMonsterId.HandleId, 1, p0MonsterId, ConfigMonsterHandBookByMonsterId.LogPair) || ConfigCommon.Step(ConfigMonsterHandBookByMonsterId.HandleId, true, ConfigMonsterHandBookByMonsterId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterHandBookByMonsterId.HandleId, ConfigMonsterHandBookByMonsterId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterHandBookByMonsterId.HandleId, 0, ConfigMonsterHandBookByMonsterId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterHandBookByMonsterId.HandleId, ConfigMonsterHandBookByMonsterId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterHandBook rootAsMonsterHandBook = MonsterHandBook.GetRootAsMonsterHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterHandBookByMonsterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MonsterId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterHandBookByMonsterId.HandleId, ConfigMonsterHandBookByMonsterId.LogPair);
			return new MonsterHandBook?(rootAsMonsterHandBook);
		}

		// Token: 0x0400251B RID: 9499
		private const string DB = "db_handbook.db";

		// Token: 0x0400251C RID: 9500
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400251D RID: 9501
		private const string TABLE = "MonsterHandBook";

		// Token: 0x0400251E RID: 9502
		private const string COMMAND = "select BinData from `MonsterHandBook` where MonsterId=?";

		// Token: 0x0400251F RID: 9503
		private const string KEY_PREFIX = "MonsterHandBookByMonsterId";

		// Token: 0x04002520 RID: 9504
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002521 RID: 9505
		private static int HandleId;
	}
}
