using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000567 RID: 1383
	public class ConfigMonsterHandBookByMonsterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002077 RID: 8311 RVA: 0x0011466C File Offset: 0x0011286C
		static ConfigMonsterHandBookByMonsterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookByMonsterId.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookByMonsterId.ResetStaticDefaultValue));
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x0011468C File Offset: 0x0011288C
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

		// Token: 0x06002079 RID: 8313 RVA: 0x0011470B File Offset: 0x0011290B
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookByMonsterId.LogPair = null;
			ConfigMonsterHandBookByMonsterId.HandleId = 0;
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00114719 File Offset: 0x00112919
		public static void Init()
		{
			ConfigMonsterHandBookByMonsterId.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookByMonsterId.HandleId, "db_handbook.db", "select BinData from `MonsterHandBook` where MonsterId=?");
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00114734 File Offset: 0x00112934
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

		// Token: 0x040025B5 RID: 9653
		private const string DB = "db_handbook.db";

		// Token: 0x040025B6 RID: 9654
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040025B7 RID: 9655
		private const string TABLE = "MonsterHandBook";

		// Token: 0x040025B8 RID: 9656
		private const string COMMAND = "select BinData from `MonsterHandBook` where MonsterId=?";

		// Token: 0x040025B9 RID: 9657
		private const string KEY_PREFIX = "MonsterHandBookByMonsterId";

		// Token: 0x040025BA RID: 9658
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025BB RID: 9659
		private static int HandleId;
	}
}
