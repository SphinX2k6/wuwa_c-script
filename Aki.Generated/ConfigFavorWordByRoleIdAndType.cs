using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BA RID: 698
	public class ConfigFavorWordByRoleIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x000B6104 File Offset: 0x000B4304
		static ConfigFavorWordByRoleIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorWordByRoleIdAndType.CreateStaticDefaultValue), new Action(ConfigFavorWordByRoleIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x000B6124 File Offset: 0x000B4324
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

		// Token: 0x06001063 RID: 4195 RVA: 0x000B61A3 File Offset: 0x000B43A3
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorWordByRoleIdAndType.LogPair = null;
			ConfigFavorWordByRoleIdAndType.HandleId = 0;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x000B61B1 File Offset: 0x000B43B1
		public static void Init()
		{
			ConfigFavorWordByRoleIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigFavorWordByRoleIdAndType.HandleId, "db_favor.db", "select BinData from `FavorWord` where RoleId=? and Type=? Order By Sort");
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x000B61CC File Offset: 0x000B43CC
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

		// Token: 0x040012FA RID: 4858
		private const string DB = "db_favor.db";

		// Token: 0x040012FB RID: 4859
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x040012FC RID: 4860
		private const string TABLE = "FavorWord";

		// Token: 0x040012FD RID: 4861
		private const string COMMAND = "select BinData from `FavorWord` where RoleId=? and Type=? Order By Sort";

		// Token: 0x040012FE RID: 4862
		private const string KEY_PREFIX = "FavorWordByRoleIdAndType";

		// Token: 0x040012FF RID: 4863
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001300 RID: 4864
		private static int HandleId;
	}
}
