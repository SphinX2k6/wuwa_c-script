using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B11 RID: 2833
	public class ConfigTrapDefenseMonsterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600427A RID: 17018 RVA: 0x001D49F8 File Offset: 0x001D2BF8
		static ConfigTrapDefenseMonsterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterTypeById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x001D4A18 File Offset: 0x001D2C18
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonsterType"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonsterType` where Id=?")
			});
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x001D4A97 File Offset: 0x001D2C97
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterTypeById.LogPair = null;
			ConfigTrapDefenseMonsterTypeById.HandleId = 0;
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x001D4AA5 File Offset: 0x001D2CA5
		public static void Init()
		{
			ConfigTrapDefenseMonsterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterTypeById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterType` where Id=?");
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x001D4AC0 File Offset: 0x001D2CC0
		public static TrapDefenseMonsterType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterTypeById.HandleId, ConfigTrapDefenseMonsterTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMonsterType?(TrapDefenseMonsterType.GetRootAsTrapDefenseMonsterType(configBuffer));
				}
			}
			ConfigTrapDefenseMonsterTypeById.LogPair.Clear();
			ConfigTrapDefenseMonsterTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMonsterTypeById.HandleId, 1, p0Id, ConfigTrapDefenseMonsterTypeById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMonsterTypeById.HandleId, true, ConfigTrapDefenseMonsterTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterTypeById.HandleId, ConfigTrapDefenseMonsterTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterTypeById.HandleId, 0, ConfigTrapDefenseMonsterTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterTypeById.HandleId, ConfigTrapDefenseMonsterTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMonsterType rootAsTrapDefenseMonsterType = TrapDefenseMonsterType.GetRootAsTrapDefenseMonsterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterTypeById.HandleId, ConfigTrapDefenseMonsterTypeById.LogPair);
			return new TrapDefenseMonsterType?(rootAsTrapDefenseMonsterType);
		}

		// Token: 0x04004D5D RID: 19805
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D5E RID: 19806
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004D5F RID: 19807
		private const string TABLE = "TrapDefenseMonsterType";

		// Token: 0x04004D60 RID: 19808
		private const string COMMAND = "select BinData from `TrapDefenseMonsterType` where Id=?";

		// Token: 0x04004D61 RID: 19809
		private const string KEY_PREFIX = "TrapDefenseMonsterTypeById";

		// Token: 0x04004D62 RID: 19810
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D63 RID: 19811
		private static int HandleId;
	}
}
