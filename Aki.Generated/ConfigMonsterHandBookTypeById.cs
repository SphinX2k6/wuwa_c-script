using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056A RID: 1386
	public class ConfigMonsterHandBookTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002089 RID: 8329 RVA: 0x00114C7F File Offset: 0x00112E7F
		static ConfigMonsterHandBookTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookTypeById.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00114CA0 File Offset: 0x00112EA0
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterHandBookTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterHandBookTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterHandBookType"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterHandBookType` where Id=?")
			});
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00114D1F File Offset: 0x00112F1F
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookTypeById.LogPair = null;
			ConfigMonsterHandBookTypeById.HandleId = 0;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00114D2D File Offset: 0x00112F2D
		public static void Init()
		{
			ConfigMonsterHandBookTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookTypeById.HandleId, "db_handbook.db", "select BinData from `MonsterHandBookType` where Id=?");
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00114D48 File Offset: 0x00112F48
		public static MonsterHandBookType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterHandBookTypeById.HandleId, ConfigMonsterHandBookTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterHandBookTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterHandBookType?(MonsterHandBookType.GetRootAsMonsterHandBookType(configBuffer));
				}
			}
			ConfigMonsterHandBookTypeById.LogPair.Clear();
			ConfigMonsterHandBookTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterHandBookTypeById.HandleId, 1, p0Id, ConfigMonsterHandBookTypeById.LogPair) || ConfigCommon.Step(ConfigMonsterHandBookTypeById.HandleId, true, ConfigMonsterHandBookTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterHandBookTypeById.HandleId, ConfigMonsterHandBookTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterHandBookTypeById.HandleId, 0, ConfigMonsterHandBookTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterHandBookTypeById.HandleId, ConfigMonsterHandBookTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterHandBookType rootAsMonsterHandBookType = MonsterHandBookType.GetRootAsMonsterHandBookType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterHandBookTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterHandBookTypeById.HandleId, ConfigMonsterHandBookTypeById.LogPair);
			return new MonsterHandBookType?(rootAsMonsterHandBookType);
		}

		// Token: 0x040025CA RID: 9674
		private const string DB = "db_handbook.db";

		// Token: 0x040025CB RID: 9675
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040025CC RID: 9676
		private const string TABLE = "MonsterHandBookType";

		// Token: 0x040025CD RID: 9677
		private const string COMMAND = "select BinData from `MonsterHandBookType` where Id=?";

		// Token: 0x040025CE RID: 9678
		private const string KEY_PREFIX = "MonsterHandBookTypeById";

		// Token: 0x040025CF RID: 9679
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025D0 RID: 9680
		private static int HandleId;
	}
}
