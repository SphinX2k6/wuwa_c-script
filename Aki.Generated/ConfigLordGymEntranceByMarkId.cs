using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F8 RID: 1272
	public class ConfigLordGymEntranceByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DDB RID: 7643 RVA: 0x0010201C File Offset: 0x0010021C
		static ConfigLordGymEntranceByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceByMarkId.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0010203C File Offset: 0x0010023C
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

		// Token: 0x06001DDD RID: 7645 RVA: 0x001020BB File Offset: 0x001002BB
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceByMarkId.LogPair = null;
			ConfigLordGymEntranceByMarkId.HandleId = 0;
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x001020C9 File Offset: 0x001002C9
		public static void Init()
		{
			ConfigLordGymEntranceByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceByMarkId.HandleId, "db_lordgym.db", "select BinData from `LordGymEntrance` where MarkId=?");
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x001020E4 File Offset: 0x001002E4
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

		// Token: 0x040022AC RID: 8876
		private const string DB = "db_lordgym.db";

		// Token: 0x040022AD RID: 8877
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x040022AE RID: 8878
		private const string TABLE = "LordGymEntrance";

		// Token: 0x040022AF RID: 8879
		private const string COMMAND = "select BinData from `LordGymEntrance` where MarkId=?";

		// Token: 0x040022B0 RID: 8880
		private const string KEY_PREFIX = "LordGymEntranceByMarkId";

		// Token: 0x040022B1 RID: 8881
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022B2 RID: 8882
		private static int HandleId;
	}
}
