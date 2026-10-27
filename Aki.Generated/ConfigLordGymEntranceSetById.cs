using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FB RID: 1275
	public class ConfigLordGymEntranceSetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DED RID: 7661 RVA: 0x0010262F File Offset: 0x0010082F
		static ConfigLordGymEntranceSetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceSetById.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceSetById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00102650 File Offset: 0x00100850
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymEntranceSetById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymEntranceSetById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymEntranceSet"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymEntranceSet` where Id=?")
			});
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x001026CF File Offset: 0x001008CF
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceSetById.LogPair = null;
			ConfigLordGymEntranceSetById.HandleId = 0;
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x001026DD File Offset: 0x001008DD
		public static void Init()
		{
			ConfigLordGymEntranceSetById.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceSetById.HandleId, "db_lordgym.db", "select BinData from `LordGymEntranceSet` where Id=?");
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x001026F8 File Offset: 0x001008F8
		public static LordGymEntranceSet? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymEntranceSetById.HandleId, ConfigLordGymEntranceSetById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceSetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LordGymEntranceSet?(LordGymEntranceSet.GetRootAsLordGymEntranceSet(configBuffer));
				}
			}
			ConfigLordGymEntranceSetById.LogPair.Clear();
			ConfigLordGymEntranceSetById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLordGymEntranceSetById.HandleId, 1, p0Id, ConfigLordGymEntranceSetById.LogPair) || ConfigCommon.Step(ConfigLordGymEntranceSetById.HandleId, true, ConfigLordGymEntranceSetById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLordGymEntranceSetById.HandleId, ConfigLordGymEntranceSetById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymEntranceSetById.HandleId, 0, ConfigLordGymEntranceSetById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLordGymEntranceSetById.HandleId, ConfigLordGymEntranceSetById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LordGymEntranceSet rootAsLordGymEntranceSet = LordGymEntranceSet.GetRootAsLordGymEntranceSet(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceSetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLordGymEntranceSetById.HandleId, ConfigLordGymEntranceSetById.LogPair);
			return new LordGymEntranceSet?(rootAsLordGymEntranceSet);
		}

		// Token: 0x040022C1 RID: 8897
		private const string DB = "db_lordgym.db";

		// Token: 0x040022C2 RID: 8898
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x040022C3 RID: 8899
		private const string TABLE = "LordGymEntranceSet";

		// Token: 0x040022C4 RID: 8900
		private const string COMMAND = "select BinData from `LordGymEntranceSet` where Id=?";

		// Token: 0x040022C5 RID: 8901
		private const string KEY_PREFIX = "LordGymEntranceSetById";

		// Token: 0x040022C6 RID: 8902
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022C7 RID: 8903
		private static int HandleId;
	}
}
