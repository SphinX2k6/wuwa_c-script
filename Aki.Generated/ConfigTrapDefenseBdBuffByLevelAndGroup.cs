using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF7 RID: 2807
	public class ConfigTrapDefenseBdBuffByLevelAndGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041DE RID: 16862 RVA: 0x001D1404 File Offset: 0x001CF604
		static ConfigTrapDefenseBdBuffByLevelAndGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdBuffByLevelAndGroup.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdBuffByLevelAndGroup.ResetStaticDefaultValue));
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x001D1424 File Offset: 0x001CF624
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

		// Token: 0x060041E0 RID: 16864 RVA: 0x001D14A3 File Offset: 0x001CF6A3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdBuffByLevelAndGroup.LogPair = null;
			ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId = 0;
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x001D14B1 File Offset: 0x001CF6B1
		public static void Init()
		{
			ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdBuffByLevelAndGroup.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdBuff` where Level=? And GroupId=?");
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x001D14CC File Offset: 0x001CF6CC
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

		// Token: 0x04004CA7 RID: 19623
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CA8 RID: 19624
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x04004CA9 RID: 19625
		private const string TABLE = "TrapDefenseBdBuff";

		// Token: 0x04004CAA RID: 19626
		private const string COMMAND = "select BinData from `TrapDefenseBdBuff` where Level=? And GroupId=?";

		// Token: 0x04004CAB RID: 19627
		private const string KEY_PREFIX = "TrapDefenseBdBuffByLevelAndGroup";

		// Token: 0x04004CAC RID: 19628
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CAD RID: 19629
		private static int HandleId;
	}
}
