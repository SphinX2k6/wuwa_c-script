using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B07 RID: 2823
	public class ConfigTrapDefenseMapByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600423E RID: 16958 RVA: 0x001D35F7 File Offset: 0x001D17F7
		static ConfigTrapDefenseMapByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMapByMapId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMapByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x001D3618 File Offset: 0x001D1818
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMapByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMapByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMap"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMap` where MapId=?")
			});
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x001D3697 File Offset: 0x001D1897
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMapByMapId.LogPair = null;
			ConfigTrapDefenseMapByMapId.HandleId = 0;
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x001D36A5 File Offset: 0x001D18A5
		public static void Init()
		{
			ConfigTrapDefenseMapByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMapByMapId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMap` where MapId=?");
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x001D36C0 File Offset: 0x001D18C0
		public static TrapDefenseMap? GetConfig(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMapByMapId.HandleId, ConfigTrapDefenseMapByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMapByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMap?(TrapDefenseMap.GetRootAsTrapDefenseMap(configBuffer));
				}
			}
			ConfigTrapDefenseMapByMapId.LogPair.Clear();
			ConfigTrapDefenseMapByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMapByMapId.HandleId, 1, p0MapId, ConfigTrapDefenseMapByMapId.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMapByMapId.HandleId, true, ConfigTrapDefenseMapByMapId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMapByMapId.HandleId, ConfigTrapDefenseMapByMapId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMapByMapId.HandleId, 0, ConfigTrapDefenseMapByMapId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMapByMapId.HandleId, ConfigTrapDefenseMapByMapId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMap rootAsTrapDefenseMap = TrapDefenseMap.GetRootAsTrapDefenseMap(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMapByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMapByMapId.HandleId, ConfigTrapDefenseMapByMapId.LogPair);
			return new TrapDefenseMap?(rootAsTrapDefenseMap);
		}

		// Token: 0x04004D17 RID: 19735
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D18 RID: 19736
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004D19 RID: 19737
		private const string TABLE = "TrapDefenseMap";

		// Token: 0x04004D1A RID: 19738
		private const string COMMAND = "select BinData from `TrapDefenseMap` where MapId=?";

		// Token: 0x04004D1B RID: 19739
		private const string KEY_PREFIX = "TrapDefenseMapByMapId";

		// Token: 0x04004D1C RID: 19740
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D1D RID: 19741
		private static int HandleId;
	}
}
