using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CC RID: 716
	public class ConfigFavorStoryByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010CD RID: 4301 RVA: 0x000BBF48 File Offset: 0x000BA148
		static ConfigFavorStoryByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorStoryByRoleId.CreateStaticDefaultValue), new Action(ConfigFavorStoryByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000BBF68 File Offset: 0x000BA168
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

		// Token: 0x060010CF RID: 4303 RVA: 0x000BBFE7 File Offset: 0x000BA1E7
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorStoryByRoleId.LogPair = null;
			ConfigFavorStoryByRoleId.HandleId = 0;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x000BBFF5 File Offset: 0x000BA1F5
		public static void Init()
		{
			ConfigFavorStoryByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigFavorStoryByRoleId.HandleId, "db_favor.db", "select BinData from `FavorStory` where RoleId=?");
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x000BC010 File Offset: 0x000BA210
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

		// Token: 0x04001378 RID: 4984
		private const string DB = "db_favor.db";

		// Token: 0x04001379 RID: 4985
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x0400137A RID: 4986
		private const string TABLE = "FavorStory";

		// Token: 0x0400137B RID: 4987
		private const string COMMAND = "select BinData from `FavorStory` where RoleId=?";

		// Token: 0x0400137C RID: 4988
		private const string KEY_PREFIX = "FavorStoryByRoleId";

		// Token: 0x0400137D RID: 4989
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400137E RID: 4990
		private static int HandleId;
	}
}
