using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CF RID: 719
	public class ConfigFavorWordByRoleIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010DF RID: 4319 RVA: 0x000BC610 File Offset: 0x000BA810
		static ConfigFavorWordByRoleIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorWordByRoleIdAndType.CreateStaticDefaultValue), new Action(ConfigFavorWordByRoleIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x000BC630 File Offset: 0x000BA830
		public static void CreateStaticDefaultValue()
		{
			ConfigFavorWordByRoleIdAndType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFavorWordByRoleIdAndType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_favor.db"),
				new ValueTuple<string, object>("文件", "h.好感度.xlsx"),
				new ValueTuple<string, object>("表名", "FavorWord"),
				new ValueTuple<string, object>("语句", "select BinData from `FavorWord` where RoleId=? and Type=? Order By Sort")
			});
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x000BC6AF File Offset: 0x000BA8AF
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorWordByRoleIdAndType.LogPair = null;
			ConfigFavorWordByRoleIdAndType.HandleId = 0;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000BC6BD File Offset: 0x000BA8BD
		public static void Init()
		{
			ConfigFavorWordByRoleIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigFavorWordByRoleIdAndType.HandleId, "db_favor.db", "select BinData from `FavorWord` where RoleId=? and Type=? Order By Sort");
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x000BC6D8 File Offset: 0x000BA8D8
		[NullableContext(2)]
		public static IReadOnlyList<FavorWord> GetConfigList(int p0RoleId, int p1Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFavorWordByRoleIdAndType.HandleId, ConfigFavorWordByRoleIdAndType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FavorWordByRoleIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				IReadOnlyList<FavorWord> readOnlyList = (IReadOnlyList<FavorWord>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFavorWordByRoleIdAndType.LogPair.Clear();
			ConfigFavorWordByRoleIdAndType.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigFavorWordByRoleIdAndType.LogPair.Add(new ValueTuple<string, object>("Type", p1Type));
			if (!ConfigCommon.BindInt(ConfigFavorWordByRoleIdAndType.HandleId, 1, p0RoleId, ConfigFavorWordByRoleIdAndType.LogPair) || !ConfigCommon.BindInt(ConfigFavorWordByRoleIdAndType.HandleId, 2, p1Type, ConfigFavorWordByRoleIdAndType.LogPair))
			{
				ConfigCommon.Reset(ConfigFavorWordByRoleIdAndType.HandleId, ConfigFavorWordByRoleIdAndType.LogPair);
				return null;
			}
			List<FavorWord> list = new List<FavorWord>();
			while (ConfigCommon.Step(ConfigFavorWordByRoleIdAndType.HandleId, false, ConfigFavorWordByRoleIdAndType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFavorWordByRoleIdAndType.HandleId, 0, ConfigFavorWordByRoleIdAndType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFavorWordByRoleIdAndType.HandleId, ConfigFavorWordByRoleIdAndType.LogPair);
					return null;
				}
				FavorWord rootAsFavorWord = FavorWord.GetRootAsFavorWord(new ByteBuffer(item2));
				list.Add(rootAsFavorWord);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FavorWordByRoleIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFavorWordByRoleIdAndType.HandleId, ConfigFavorWordByRoleIdAndType.LogPair);
			return list;
		}

		// Token: 0x0400138D RID: 5005
		private const string DB = "db_favor.db";

		// Token: 0x0400138E RID: 5006
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x0400138F RID: 5007
		private const string TABLE = "FavorWord";

		// Token: 0x04001390 RID: 5008
		private const string COMMAND = "select BinData from `FavorWord` where RoleId=? and Type=? Order By Sort";

		// Token: 0x04001391 RID: 5009
		private const string KEY_PREFIX = "FavorWordByRoleIdAndType";

		// Token: 0x04001392 RID: 5010
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001393 RID: 5011
		private static int HandleId;
	}
}
