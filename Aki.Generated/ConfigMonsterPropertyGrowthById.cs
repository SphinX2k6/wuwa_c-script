using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000559 RID: 1369
	public class ConfigMonsterPropertyGrowthById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002023 RID: 8227 RVA: 0x0010F033 File Offset: 0x0010D233
		static ConfigMonsterPropertyGrowthById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterPropertyGrowthById.CreateStaticDefaultValue), new Action(ConfigMonsterPropertyGrowthById.ResetStaticDefaultValue));
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0010F054 File Offset: 0x0010D254
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

		// Token: 0x06002025 RID: 8229 RVA: 0x0010F0D3 File Offset: 0x0010D2D3
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterPropertyGrowthById.LogPair = null;
			ConfigMonsterPropertyGrowthById.HandleId = 0;
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0010F0E1 File Offset: 0x0010D2E1
		public static void Init()
		{
			ConfigMonsterPropertyGrowthById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterPropertyGrowthById.HandleId, "db_property.db", "select BinData from `MonsterPropertyGrowth` where id=?");
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0010F0FC File Offset: 0x0010D2FC
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

		// Token: 0x04002553 RID: 9555
		private const string DB = "db_property.db";

		// Token: 0x04002554 RID: 9556
		private const string FILE = "s.属性.xlsx";

		// Token: 0x04002555 RID: 9557
		private const string TABLE = "MonsterPropertyGrowth";

		// Token: 0x04002556 RID: 9558
		private const string COMMAND = "select BinData from `MonsterPropertyGrowth` where id=?";

		// Token: 0x04002557 RID: 9559
		private const string KEY_PREFIX = "MonsterPropertyGrowthById";

		// Token: 0x04002558 RID: 9560
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002559 RID: 9561
		private static int HandleId;
	}
}
