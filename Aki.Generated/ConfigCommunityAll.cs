using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019F RID: 415
	public class ConfigCommunityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x000941EC File Offset: 0x000923EC
		static ConfigCommunityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommunityAll.CreateStaticDefaultValue), new Action(ConfigCommunityAll.ResetStaticDefaultValue));
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0009420C File Offset: 0x0009240C
		public static void CreateStaticDefaultValue()
		{
			ConfigCommunityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommunityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformchannel.db"),
				new ValueTuple<string, object>("文件", "p.平台渠道.xlsx"),
				new ValueTuple<string, object>("表名", "Community"),
				new ValueTuple<string, object>("语句", "select BinData from `Community` where PackageType!=?")
			});
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0009428B File Offset: 0x0009248B
		public static void ResetStaticDefaultValue()
		{
			ConfigCommunityAll.LogPair = null;
			ConfigCommunityAll.HandleId = 0;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00094299 File Offset: 0x00092499
		public static void Init()
		{
			ConfigCommunityAll.HandleId = ConfigCommon.InitDataStatement(ConfigCommunityAll.HandleId, "db_platformchannel.db", "select BinData from `Community` where PackageType!=?");
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000942B4 File Offset: 0x000924B4
		[NullableContext(2)]
		public static IReadOnlyList<Community> GetConfigList(int p0PackageType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommunityAll.HandleId, ConfigCommunityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommunityAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PackageType);
				IReadOnlyList<Community> readOnlyList = (IReadOnlyList<Community>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCommunityAll.LogPair.Clear();
			ConfigCommunityAll.LogPair.Add(new ValueTuple<string, object>("PackageType", p0PackageType));
			if (!ConfigCommon.BindInt(ConfigCommunityAll.HandleId, 1, p0PackageType, ConfigCommunityAll.LogPair))
			{
				ConfigCommon.Reset(ConfigCommunityAll.HandleId, ConfigCommunityAll.LogPair);
				return null;
			}
			List<Community> list = new List<Community>();
			while (ConfigCommon.Step(ConfigCommunityAll.HandleId, false, ConfigCommunityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommunityAll.HandleId, 0, ConfigCommunityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCommunityAll.HandleId, ConfigCommunityAll.LogPair);
					return null;
				}
				Community rootAsCommunity = Community.GetRootAsCommunity(new ByteBuffer(item2));
				list.Add(rootAsCommunity);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommunityAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PackageType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCommunityAll.HandleId, ConfigCommunityAll.LogPair);
			return list;
		}

		// Token: 0x04000B3D RID: 2877
		private const string DB = "db_platformchannel.db";

		// Token: 0x04000B3E RID: 2878
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04000B3F RID: 2879
		private const string TABLE = "Community";

		// Token: 0x04000B40 RID: 2880
		private const string COMMAND = "select BinData from `Community` where PackageType!=?";

		// Token: 0x04000B41 RID: 2881
		private const string KEY_PREFIX = "CommunityAll";

		// Token: 0x04000B42 RID: 2882
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B43 RID: 2883
		private static int HandleId;
	}
}
