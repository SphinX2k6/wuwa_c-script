using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FC RID: 1276
	public class ConfigLordGymEntranceSetByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DF3 RID: 7667 RVA: 0x00102878 File Offset: 0x00100A78
		static ConfigLordGymEntranceSetByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceSetByMarkId.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceSetByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00102898 File Offset: 0x00100A98
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymEntranceSetByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymEntranceSetByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymEntranceSet"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymEntranceSet` where MarkId=?")
			});
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00102917 File Offset: 0x00100B17
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceSetByMarkId.LogPair = null;
			ConfigLordGymEntranceSetByMarkId.HandleId = 0;
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00102925 File Offset: 0x00100B25
		public static void Init()
		{
			ConfigLordGymEntranceSetByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceSetByMarkId.HandleId, "db_lordgym.db", "select BinData from `LordGymEntranceSet` where MarkId=?");
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00102940 File Offset: 0x00100B40
		public static LordGymEntranceSet? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymEntranceSetByMarkId.HandleId, ConfigLordGymEntranceSetByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceSetByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LordGymEntranceSet?(LordGymEntranceSet.GetRootAsLordGymEntranceSet(configBuffer));
				}
			}
			ConfigLordGymEntranceSetByMarkId.LogPair.Clear();
			ConfigLordGymEntranceSetByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigLordGymEntranceSetByMarkId.HandleId, 1, p0MarkId, ConfigLordGymEntranceSetByMarkId.LogPair) || ConfigCommon.Step(ConfigLordGymEntranceSetByMarkId.HandleId, true, ConfigLordGymEntranceSetByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLordGymEntranceSetByMarkId.HandleId, ConfigLordGymEntranceSetByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymEntranceSetByMarkId.HandleId, 0, ConfigLordGymEntranceSetByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLordGymEntranceSetByMarkId.HandleId, ConfigLordGymEntranceSetByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LordGymEntranceSet rootAsLordGymEntranceSet = LordGymEntranceSet.GetRootAsLordGymEntranceSet(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceSetByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLordGymEntranceSetByMarkId.HandleId, ConfigLordGymEntranceSetByMarkId.LogPair);
			return new LordGymEntranceSet?(rootAsLordGymEntranceSet);
		}

		// Token: 0x040022C8 RID: 8904
		private const string DB = "db_lordgym.db";

		// Token: 0x040022C9 RID: 8905
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x040022CA RID: 8906
		private const string TABLE = "LordGymEntranceSet";

		// Token: 0x040022CB RID: 8907
		private const string COMMAND = "select BinData from `LordGymEntranceSet` where MarkId=?";

		// Token: 0x040022CC RID: 8908
		private const string KEY_PREFIX = "LordGymEntranceSetByMarkId";

		// Token: 0x040022CD RID: 8909
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022CE RID: 8910
		private static int HandleId;
	}
}
