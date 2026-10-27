using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000554 RID: 1364
	public class ConfigMonsterHandBookTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002005 RID: 8197 RVA: 0x0010E52B File Offset: 0x0010C72B
		static ConfigMonsterHandBookTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookTypeById.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0010E54C File Offset: 0x0010C74C
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

		// Token: 0x06002007 RID: 8199 RVA: 0x0010E5CB File Offset: 0x0010C7CB
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookTypeById.LogPair = null;
			ConfigMonsterHandBookTypeById.HandleId = 0;
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0010E5D9 File Offset: 0x0010C7D9
		public static void Init()
		{
			ConfigMonsterHandBookTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookTypeById.HandleId, "db_handbook.db", "select BinData from `MonsterHandBookType` where Id=?");
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x0010E5F4 File Offset: 0x0010C7F4
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

		// Token: 0x04002530 RID: 9520
		private const string DB = "db_handbook.db";

		// Token: 0x04002531 RID: 9521
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002532 RID: 9522
		private const string TABLE = "MonsterHandBookType";

		// Token: 0x04002533 RID: 9523
		private const string COMMAND = "select BinData from `MonsterHandBookType` where Id=?";

		// Token: 0x04002534 RID: 9524
		private const string KEY_PREFIX = "MonsterHandBookTypeById";

		// Token: 0x04002535 RID: 9525
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002536 RID: 9526
		private static int HandleId;
	}
}
