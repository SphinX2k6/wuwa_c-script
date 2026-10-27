using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F7 RID: 1271
	public class ConfigLordGymEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DD5 RID: 7637 RVA: 0x00101DD3 File Offset: 0x000FFFD3
		static ConfigLordGymEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceById.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00101DF4 File Offset: 0x000FFFF4
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymEntranceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymEntranceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymEntrance` where Id=?")
			});
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00101E73 File Offset: 0x00100073
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceById.LogPair = null;
			ConfigLordGymEntranceById.HandleId = 0;
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x00101E81 File Offset: 0x00100081
		public static void Init()
		{
			ConfigLordGymEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceById.HandleId, "db_lordgym.db", "select BinData from `LordGymEntrance` where Id=?");
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00101E9C File Offset: 0x0010009C
		public static LordGymEntrance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymEntranceById.HandleId, ConfigLordGymEntranceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LordGymEntrance?(LordGymEntrance.GetRootAsLordGymEntrance(configBuffer));
				}
			}
			ConfigLordGymEntranceById.LogPair.Clear();
			ConfigLordGymEntranceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLordGymEntranceById.HandleId, 1, p0Id, ConfigLordGymEntranceById.LogPair) || ConfigCommon.Step(ConfigLordGymEntranceById.HandleId, true, ConfigLordGymEntranceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLordGymEntranceById.HandleId, ConfigLordGymEntranceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymEntranceById.HandleId, 0, ConfigLordGymEntranceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLordGymEntranceById.HandleId, ConfigLordGymEntranceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LordGymEntrance rootAsLordGymEntrance = LordGymEntrance.GetRootAsLordGymEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLordGymEntranceById.HandleId, ConfigLordGymEntranceById.LogPair);
			return new LordGymEntrance?(rootAsLordGymEntrance);
		}

		// Token: 0x040022A5 RID: 8869
		private const string DB = "db_lordgym.db";

		// Token: 0x040022A6 RID: 8870
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x040022A7 RID: 8871
		private const string TABLE = "LordGymEntrance";

		// Token: 0x040022A8 RID: 8872
		private const string COMMAND = "select BinData from `LordGymEntrance` where Id=?";

		// Token: 0x040022A9 RID: 8873
		private const string KEY_PREFIX = "LordGymEntranceById";

		// Token: 0x040022AA RID: 8874
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022AB RID: 8875
		private static int HandleId;
	}
}
