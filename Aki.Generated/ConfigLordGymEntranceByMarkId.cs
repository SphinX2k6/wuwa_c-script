using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050E RID: 1294
	public class ConfigLordGymEntranceByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E5F RID: 7775 RVA: 0x00108770 File Offset: 0x00106970
		static ConfigLordGymEntranceByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceByMarkId.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00108790 File Offset: 0x00106990
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymEntranceByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymEntranceByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymEntrance` where MarkId=?")
			});
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0010880F File Offset: 0x00106A0F
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceByMarkId.LogPair = null;
			ConfigLordGymEntranceByMarkId.HandleId = 0;
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0010881D File Offset: 0x00106A1D
		public static void Init()
		{
			ConfigLordGymEntranceByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceByMarkId.HandleId, "db_lordgym.db", "select BinData from `LordGymEntrance` where MarkId=?");
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00108838 File Offset: 0x00106A38
		public static LordGymEntrance? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymEntranceByMarkId.HandleId, ConfigLordGymEntranceByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LordGymEntrance?(LordGymEntrance.GetRootAsLordGymEntrance(configBuffer));
				}
			}
			ConfigLordGymEntranceByMarkId.LogPair.Clear();
			ConfigLordGymEntranceByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigLordGymEntranceByMarkId.HandleId, 1, p0MarkId, ConfigLordGymEntranceByMarkId.LogPair) || ConfigCommon.Step(ConfigLordGymEntranceByMarkId.HandleId, true, ConfigLordGymEntranceByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLordGymEntranceByMarkId.HandleId, ConfigLordGymEntranceByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymEntranceByMarkId.HandleId, 0, ConfigLordGymEntranceByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLordGymEntranceByMarkId.HandleId, ConfigLordGymEntranceByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LordGymEntrance rootAsLordGymEntrance = LordGymEntrance.GetRootAsLordGymEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLordGymEntranceByMarkId.HandleId, ConfigLordGymEntranceByMarkId.LogPair);
			return new LordGymEntrance?(rootAsLordGymEntrance);
		}

		// Token: 0x04002346 RID: 9030
		private const string DB = "db_lordgym.db";

		// Token: 0x04002347 RID: 9031
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x04002348 RID: 9032
		private const string TABLE = "LordGymEntrance";

		// Token: 0x04002349 RID: 9033
		private const string COMMAND = "select BinData from `LordGymEntrance` where MarkId=?";

		// Token: 0x0400234A RID: 9034
		private const string KEY_PREFIX = "LordGymEntranceByMarkId";

		// Token: 0x0400234B RID: 9035
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400234C RID: 9036
		private static int HandleId;
	}
}
