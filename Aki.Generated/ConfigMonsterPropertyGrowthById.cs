using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056F RID: 1391
	public class ConfigMonsterPropertyGrowthById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020A7 RID: 8359 RVA: 0x00115787 File Offset: 0x00113987
		static ConfigMonsterPropertyGrowthById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterPropertyGrowthById.CreateStaticDefaultValue), new Action(ConfigMonsterPropertyGrowthById.ResetStaticDefaultValue));
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x001157A8 File Offset: 0x001139A8
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterPropertyGrowthById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterPropertyGrowthById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_property.db"),
				new ValueTuple<string, object>("文件", "s.属性.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterPropertyGrowth"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterPropertyGrowth` where id=?")
			});
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x00115827 File Offset: 0x00113A27
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterPropertyGrowthById.LogPair = null;
			ConfigMonsterPropertyGrowthById.HandleId = 0;
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00115835 File Offset: 0x00113A35
		public static void Init()
		{
			ConfigMonsterPropertyGrowthById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterPropertyGrowthById.HandleId, "db_property.db", "select BinData from `MonsterPropertyGrowth` where id=?");
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00115850 File Offset: 0x00113A50
		public static MonsterPropertyGrowth? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterPropertyGrowthById.HandleId, ConfigMonsterPropertyGrowthById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterPropertyGrowthById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterPropertyGrowth?(MonsterPropertyGrowth.GetRootAsMonsterPropertyGrowth(configBuffer));
				}
			}
			ConfigMonsterPropertyGrowthById.LogPair.Clear();
			ConfigMonsterPropertyGrowthById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterPropertyGrowthById.HandleId, 1, p0Id, ConfigMonsterPropertyGrowthById.LogPair) || ConfigCommon.Step(ConfigMonsterPropertyGrowthById.HandleId, true, ConfigMonsterPropertyGrowthById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterPropertyGrowthById.HandleId, ConfigMonsterPropertyGrowthById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterPropertyGrowthById.HandleId, 0, ConfigMonsterPropertyGrowthById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterPropertyGrowthById.HandleId, ConfigMonsterPropertyGrowthById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterPropertyGrowth rootAsMonsterPropertyGrowth = MonsterPropertyGrowth.GetRootAsMonsterPropertyGrowth(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterPropertyGrowthById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterPropertyGrowthById.HandleId, ConfigMonsterPropertyGrowthById.LogPair);
			return new MonsterPropertyGrowth?(rootAsMonsterPropertyGrowth);
		}

		// Token: 0x040025ED RID: 9709
		private const string DB = "db_property.db";

		// Token: 0x040025EE RID: 9710
		private const string FILE = "s.属性.xlsx";

		// Token: 0x040025EF RID: 9711
		private const string TABLE = "MonsterPropertyGrowth";

		// Token: 0x040025F0 RID: 9712
		private const string COMMAND = "select BinData from `MonsterPropertyGrowth` where id=?";

		// Token: 0x040025F1 RID: 9713
		private const string KEY_PREFIX = "MonsterPropertyGrowthById";

		// Token: 0x040025F2 RID: 9714
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025F3 RID: 9715
		private static int HandleId;
	}
}
