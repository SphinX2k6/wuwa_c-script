using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B7 RID: 695
	public class ConfigFavorStoryByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600104F RID: 4175 RVA: 0x000B5A3C File Offset: 0x000B3C3C
		static ConfigFavorStoryByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorStoryByRoleId.CreateStaticDefaultValue), new Action(ConfigFavorStoryByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x000B5A5C File Offset: 0x000B3C5C
		public static void CreateStaticDefaultValue()
		{
			ConfigFavorStoryByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFavorStoryByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_favor.db"),
				new ValueTuple<string, object>("文件", "h.好感度.xlsx"),
				new ValueTuple<string, object>("表名", "FavorStory"),
				new ValueTuple<string, object>("语句", "select BinData from `FavorStory` where RoleId=?")
			});
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x000B5ADB File Offset: 0x000B3CDB
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorStoryByRoleId.LogPair = null;
			ConfigFavorStoryByRoleId.HandleId = 0;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x000B5AE9 File Offset: 0x000B3CE9
		public static void Init()
		{
			ConfigFavorStoryByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigFavorStoryByRoleId.HandleId, "db_favor.db", "select BinData from `FavorStory` where RoleId=?");
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000B5B04 File Offset: 0x000B3D04
		[NullableContext(2)]
		public static IReadOnlyList<FavorStory> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFavorStoryByRoleId.HandleId, ConfigFavorStoryByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorStoryByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<FavorStory> readOnlyList = (IReadOnlyList<FavorStory>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFavorStoryByRoleId.LogPair.Clear();
			ConfigFavorStoryByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigFavorStoryByRoleId.HandleId, 1, p0RoleId, ConfigFavorStoryByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigFavorStoryByRoleId.HandleId, ConfigFavorStoryByRoleId.LogPair);
				return null;
			}
			List<FavorStory> list = new List<FavorStory>();
			while (ConfigCommon.Step(ConfigFavorStoryByRoleId.HandleId, false, ConfigFavorStoryByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFavorStoryByRoleId.HandleId, 0, ConfigFavorStoryByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFavorStoryByRoleId.HandleId, ConfigFavorStoryByRoleId.LogPair);
					return null;
				}
				FavorStory rootAsFavorStory = FavorStory.GetRootAsFavorStory(new ByteBuffer(item2));
				list.Add(rootAsFavorStory);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorStoryByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFavorStoryByRoleId.HandleId, ConfigFavorStoryByRoleId.LogPair);
			return list;
		}

		// Token: 0x040012E5 RID: 4837
		private const string DB = "db_favor.db";

		// Token: 0x040012E6 RID: 4838
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x040012E7 RID: 4839
		private const string TABLE = "FavorStory";

		// Token: 0x040012E8 RID: 4840
		private const string COMMAND = "select BinData from `FavorStory` where RoleId=?";

		// Token: 0x040012E9 RID: 4841
		private const string KEY_PREFIX = "FavorStoryByRoleId";

		// Token: 0x040012EA RID: 4842
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012EB RID: 4843
		private static int HandleId;
	}
}
