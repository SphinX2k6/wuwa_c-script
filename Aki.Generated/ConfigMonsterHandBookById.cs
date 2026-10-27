using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000550 RID: 1360
	public class ConfigMonsterHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FED RID: 8173 RVA: 0x0010DCCF File Offset: 0x0010BECF
		static ConfigMonsterHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookById.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0010DCF0 File Offset: 0x0010BEF0
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterHandBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterHandBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterHandBook` where Id=?")
			});
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0010DD6F File Offset: 0x0010BF6F
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookById.LogPair = null;
			ConfigMonsterHandBookById.HandleId = 0;
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0010DD7D File Offset: 0x0010BF7D
		public static void Init()
		{
			ConfigMonsterHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookById.HandleId, "db_handbook.db", "select BinData from `MonsterHandBook` where Id=?");
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0010DD98 File Offset: 0x0010BF98
		public static MonsterHandBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterHandBookById.HandleId, ConfigMonsterHandBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterHandBook?(MonsterHandBook.GetRootAsMonsterHandBook(configBuffer));
				}
			}
			ConfigMonsterHandBookById.LogPair.Clear();
			ConfigMonsterHandBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterHandBookById.HandleId, 1, p0Id, ConfigMonsterHandBookById.LogPair) || ConfigCommon.Step(ConfigMonsterHandBookById.HandleId, true, ConfigMonsterHandBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterHandBookById.HandleId, ConfigMonsterHandBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterHandBookById.HandleId, 0, ConfigMonsterHandBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterHandBookById.HandleId, ConfigMonsterHandBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterHandBook rootAsMonsterHandBook = MonsterHandBook.GetRootAsMonsterHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterHandBookById.HandleId, ConfigMonsterHandBookById.LogPair);
			return new MonsterHandBook?(rootAsMonsterHandBook);
		}

		// Token: 0x04002514 RID: 9492
		private const string DB = "db_handbook.db";

		// Token: 0x04002515 RID: 9493
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002516 RID: 9494
		private const string TABLE = "MonsterHandBook";

		// Token: 0x04002517 RID: 9495
		private const string COMMAND = "select BinData from `MonsterHandBook` where Id=?";

		// Token: 0x04002518 RID: 9496
		private const string KEY_PREFIX = "MonsterHandBookById";

		// Token: 0x04002519 RID: 9497
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400251A RID: 9498
		private static int HandleId;
	}
}
