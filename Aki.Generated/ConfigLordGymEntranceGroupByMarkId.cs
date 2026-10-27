using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F9 RID: 1273
	public class ConfigLordGymEntranceGroupByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DE1 RID: 7649 RVA: 0x00102264 File Offset: 0x00100464
		static ConfigLordGymEntranceGroupByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceGroupByMarkId.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceGroupByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x00102284 File Offset: 0x00100484
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymEntranceGroupByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymEntranceGroupByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymEntrance` where MarkId=?")
			});
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00102303 File Offset: 0x00100503
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceGroupByMarkId.LogPair = null;
			ConfigLordGymEntranceGroupByMarkId.HandleId = 0;
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00102311 File Offset: 0x00100511
		public static void Init()
		{
			ConfigLordGymEntranceGroupByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceGroupByMarkId.HandleId, "db_lordgym.db", "select BinData from `LordGymEntrance` where MarkId=?");
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0010232C File Offset: 0x0010052C
		[NullableContext(2)]
		public static IReadOnlyList<LordGymEntrance> GetConfigList(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymEntranceGroupByMarkId.HandleId, ConfigLordGymEntranceGroupByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceGroupByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				IReadOnlyList<LordGymEntrance> readOnlyList = (IReadOnlyList<LordGymEntrance>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigLordGymEntranceGroupByMarkId.LogPair.Clear();
			ConfigLordGymEntranceGroupByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigLordGymEntranceGroupByMarkId.HandleId, 1, p0MarkId, ConfigLordGymEntranceGroupByMarkId.LogPair))
			{
				ConfigCommon.Reset(ConfigLordGymEntranceGroupByMarkId.HandleId, ConfigLordGymEntranceGroupByMarkId.LogPair);
				return null;
			}
			List<LordGymEntrance> list = new List<LordGymEntrance>();
			while (ConfigCommon.Step(ConfigLordGymEntranceGroupByMarkId.HandleId, false, ConfigLordGymEntranceGroupByMarkId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymEntranceGroupByMarkId.HandleId, 0, ConfigLordGymEntranceGroupByMarkId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLordGymEntranceGroupByMarkId.HandleId, ConfigLordGymEntranceGroupByMarkId.LogPair);
					return null;
				}
				LordGymEntrance rootAsLordGymEntrance = LordGymEntrance.GetRootAsLordGymEntrance(new ByteBuffer(item2));
				list.Add(rootAsLordGymEntrance);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceGroupByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigLordGymEntranceGroupByMarkId.HandleId, ConfigLordGymEntranceGroupByMarkId.LogPair);
			return list;
		}

		// Token: 0x040022B3 RID: 8883
		private const string DB = "db_lordgym.db";

		// Token: 0x040022B4 RID: 8884
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x040022B5 RID: 8885
		private const string TABLE = "LordGymEntrance";

		// Token: 0x040022B6 RID: 8886
		private const string COMMAND = "select BinData from `LordGymEntrance` where MarkId=?";

		// Token: 0x040022B7 RID: 8887
		private const string KEY_PREFIX = "LordGymEntranceGroupByMarkId";

		// Token: 0x040022B8 RID: 8888
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022B9 RID: 8889
		private static int HandleId;
	}
}
