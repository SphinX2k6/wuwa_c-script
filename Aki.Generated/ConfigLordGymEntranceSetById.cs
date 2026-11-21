using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000511 RID: 1297
	public class ConfigLordGymEntranceSetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E71 RID: 7793 RVA: 0x00108D83 File Offset: 0x00106F83
		static ConfigLordGymEntranceSetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceSetById.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceSetById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00108DA4 File Offset: 0x00106FA4
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

		// Token: 0x06001E73 RID: 7795 RVA: 0x00108E23 File Offset: 0x00107023
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceSetById.LogPair = null;
			ConfigLordGymEntranceSetById.HandleId = 0;
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00108E31 File Offset: 0x00107031
		public static void Init()
		{
			ConfigLordGymEntranceSetById.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceSetById.HandleId, "db_lordgym.db", "select BinData from `LordGymEntranceSet` where Id=?");
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00108E4C File Offset: 0x0010704C
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

		// Token: 0x0400235B RID: 9051
		private const string DB = "db_lordgym.db";

		// Token: 0x0400235C RID: 9052
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x0400235D RID: 9053
		private const string TABLE = "LordGymEntranceSet";

		// Token: 0x0400235E RID: 9054
		private const string COMMAND = "select BinData from `LordGymEntranceSet` where Id=?";

		// Token: 0x0400235F RID: 9055
		private const string KEY_PREFIX = "LordGymEntranceSetById";

		// Token: 0x04002360 RID: 9056
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002361 RID: 9057
		private static int HandleId;
	}
}
