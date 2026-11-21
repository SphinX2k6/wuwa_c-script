using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055D RID: 1373
	public class ConfigMonsterBodyTypeConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600203B RID: 8251 RVA: 0x001131B4 File Offset: 0x001113B4
		static ConfigMonsterBodyTypeConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterBodyTypeConfigById.CreateStaticDefaultValue), new Action(ConfigMonsterBodyTypeConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x001131D4 File Offset: 0x001113D4
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterBodyTypeConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterBodyTypeConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物信息.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterBodyTypeConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterBodyTypeConfig` where Id = ?")
			});
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00113253 File Offset: 0x00111453
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterBodyTypeConfigById.LogPair = null;
			ConfigMonsterBodyTypeConfigById.HandleId = 0;
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00113261 File Offset: 0x00111461
		public static void Init()
		{
			ConfigMonsterBodyTypeConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterBodyTypeConfigById.HandleId, "db_monster_info.db", "select BinData from `MonsterBodyTypeConfig` where Id = ?");
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0011327C File Offset: 0x0011147C
		public static MonsterBodyTypeConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterBodyTypeConfigById.HandleId, ConfigMonsterBodyTypeConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterBodyTypeConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterBodyTypeConfig?(MonsterBodyTypeConfig.GetRootAsMonsterBodyTypeConfig(configBuffer));
				}
			}
			ConfigMonsterBodyTypeConfigById.LogPair.Clear();
			ConfigMonsterBodyTypeConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterBodyTypeConfigById.HandleId, 1, p0Id, ConfigMonsterBodyTypeConfigById.LogPair) || ConfigCommon.Step(ConfigMonsterBodyTypeConfigById.HandleId, true, ConfigMonsterBodyTypeConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterBodyTypeConfigById.HandleId, ConfigMonsterBodyTypeConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterBodyTypeConfigById.HandleId, 0, ConfigMonsterBodyTypeConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterBodyTypeConfigById.HandleId, ConfigMonsterBodyTypeConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterBodyTypeConfig rootAsMonsterBodyTypeConfig = MonsterBodyTypeConfig.GetRootAsMonsterBodyTypeConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterBodyTypeConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterBodyTypeConfigById.HandleId, ConfigMonsterBodyTypeConfigById.LogPair);
			return new MonsterBodyTypeConfig?(rootAsMonsterBodyTypeConfig);
		}

		// Token: 0x0400256F RID: 9583
		private const string DB = "db_monster_info.db";

		// Token: 0x04002570 RID: 9584
		private const string FILE = "g.怪物信息.xlsx";

		// Token: 0x04002571 RID: 9585
		private const string TABLE = "MonsterBodyTypeConfig";

		// Token: 0x04002572 RID: 9586
		private const string COMMAND = "select BinData from `MonsterBodyTypeConfig` where Id = ?";

		// Token: 0x04002573 RID: 9587
		private const string KEY_PREFIX = "MonsterBodyTypeConfigById";

		// Token: 0x04002574 RID: 9588
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002575 RID: 9589
		private static int HandleId;
	}
}
