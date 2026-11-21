using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050F RID: 1295
	public class ConfigLordGymEntranceGroupByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E65 RID: 7781 RVA: 0x001089B8 File Offset: 0x00106BB8
		static ConfigLordGymEntranceGroupByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceGroupByMarkId.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceGroupByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x001089D8 File Offset: 0x00106BD8
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

		// Token: 0x06001E67 RID: 7783 RVA: 0x00108A57 File Offset: 0x00106C57
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceGroupByMarkId.LogPair = null;
			ConfigLordGymEntranceGroupByMarkId.HandleId = 0;
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00108A65 File Offset: 0x00106C65
		public static void Init()
		{
			ConfigLordGymEntranceGroupByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceGroupByMarkId.HandleId, "db_lordgym.db", "select BinData from `LordGymEntrance` where MarkId=?");
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00108A80 File Offset: 0x00106C80
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

		// Token: 0x0400234D RID: 9037
		private const string DB = "db_lordgym.db";

		// Token: 0x0400234E RID: 9038
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x0400234F RID: 9039
		private const string TABLE = "LordGymEntrance";

		// Token: 0x04002350 RID: 9040
		private const string COMMAND = "select BinData from `LordGymEntrance` where MarkId=?";

		// Token: 0x04002351 RID: 9041
		private const string KEY_PREFIX = "LordGymEntranceGroupByMarkId";

		// Token: 0x04002352 RID: 9042
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002353 RID: 9043
		private static int HandleId;
	}
}
