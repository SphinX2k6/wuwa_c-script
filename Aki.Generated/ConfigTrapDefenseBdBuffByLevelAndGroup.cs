using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A22 RID: 2594
	public class ConfigTrapDefenseBdBuffByLevelAndGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CE0 RID: 15584 RVA: 0x001B2070 File Offset: 0x001B0270
		static ConfigTrapDefenseBdBuffByLevelAndGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdBuffByLevelAndGroup.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdBuffByLevelAndGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x001B2090 File Offset: 0x001B0290
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBdBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBdBuff` where Level=? And GroupId=?")
			});
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x001B210F File Offset: 0x001B030F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair = null;
			ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId = 0;
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x001B211D File Offset: 0x001B031D
		public static void Init()
		{
			ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdBuff` where Level=? And GroupId=?");
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x001B2138 File Offset: 0x001B0338
		public static TrapDefenseBdBuff? GetConfig(int p0Level, int p1GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId, ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdBuffByLevelAndGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseBdBuff?(TrapDefenseBdBuff.GetRootAsTrapDefenseBdBuff(configBuffer));
				}
			}
			ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair.Clear();
			ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair.Add(new ValueTuple<string, object>("GroupId", p1GroupId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId, 1, p0Level, ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair) || !ConfigCommon.BindInt(ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId, 2, p1GroupId, ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair) || ConfigCommon.Step(ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId, true, ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId, ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId, 0, ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId, ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseBdBuff rootAsTrapDefenseBdBuff = TrapDefenseBdBuff.GetRootAsTrapDefenseBdBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdBuffByLevelAndGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId, ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair);
			return new TrapDefenseBdBuff?(rootAsTrapDefenseBdBuff);
		}

		// Token: 0x040046D4 RID: 18132
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046D5 RID: 18133
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x040046D6 RID: 18134
		private const string TABLE = "TrapDefenseBdBuff";

		// Token: 0x040046D7 RID: 18135
		private const string COMMAND = "select BinData from `TrapDefenseBdBuff` where Level=? And GroupId=?";

		// Token: 0x040046D8 RID: 18136
		private const string KEY_PREFIX = "TrapDefenseBdBuffByLevelAndGroup";

		// Token: 0x040046D9 RID: 18137
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046DA RID: 18138
		private static int HandleId;
	}
}
