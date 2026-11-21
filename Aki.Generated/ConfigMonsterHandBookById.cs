using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000566 RID: 1382
	public class ConfigMonsterHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002071 RID: 8305 RVA: 0x00114423 File Offset: 0x00112623
		static ConfigMonsterHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookById.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00114444 File Offset: 0x00112644
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

		// Token: 0x06002073 RID: 8307 RVA: 0x001144C3 File Offset: 0x001126C3
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookById.LogPair = null;
			ConfigMonsterHandBookById.HandleId = 0;
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x001144D1 File Offset: 0x001126D1
		public static void Init()
		{
			ConfigMonsterHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookById.HandleId, "db_handbook.db", "select BinData from `MonsterHandBook` where Id=?");
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x001144EC File Offset: 0x001126EC
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

		// Token: 0x040025AE RID: 9646
		private const string DB = "db_handbook.db";

		// Token: 0x040025AF RID: 9647
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040025B0 RID: 9648
		private const string TABLE = "MonsterHandBook";

		// Token: 0x040025B1 RID: 9649
		private const string COMMAND = "select BinData from `MonsterHandBook` where Id=?";

		// Token: 0x040025B2 RID: 9650
		private const string KEY_PREFIX = "MonsterHandBookById";

		// Token: 0x040025B3 RID: 9651
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025B4 RID: 9652
		private static int HandleId;
	}
}
