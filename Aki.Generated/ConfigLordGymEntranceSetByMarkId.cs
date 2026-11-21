using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000512 RID: 1298
	public class ConfigLordGymEntranceSetByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E77 RID: 7799 RVA: 0x00108FCC File Offset: 0x001071CC
		static ConfigLordGymEntranceSetByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceSetByMarkId.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceSetByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00108FEC File Offset: 0x001071EC
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

		// Token: 0x06001E79 RID: 7801 RVA: 0x0010906B File Offset: 0x0010726B
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceSetByMarkId.LogPair = null;
			ConfigLordGymEntranceSetByMarkId.HandleId = 0;
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00109079 File Offset: 0x00107279
		public static void Init()
		{
			ConfigLordGymEntranceSetByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceSetByMarkId.HandleId, "db_lordgym.db", "select BinData from `LordGymEntranceSet` where MarkId=?");
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00109094 File Offset: 0x00107294
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

		// Token: 0x04002362 RID: 9058
		private const string DB = "db_lordgym.db";

		// Token: 0x04002363 RID: 9059
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x04002364 RID: 9060
		private const string TABLE = "LordGymEntranceSet";

		// Token: 0x04002365 RID: 9061
		private const string COMMAND = "select BinData from `LordGymEntranceSet` where MarkId=?";

		// Token: 0x04002366 RID: 9062
		private const string KEY_PREFIX = "LordGymEntranceSetByMarkId";

		// Token: 0x04002367 RID: 9063
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002368 RID: 9064
		private static int HandleId;
	}
}
