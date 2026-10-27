using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018D RID: 397
	public class ConfigCommunityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x0008E2B4 File Offset: 0x0008C4B4
		static ConfigCommunityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommunityAll.CreateStaticDefaultValue), new Action(ConfigCommunityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0008E2D4 File Offset: 0x0008C4D4
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

		// Token: 0x06000952 RID: 2386 RVA: 0x0008E353 File Offset: 0x0008C553
		public static void ResetStaticDefaultValue()
		{
			ConfigCommunityAll.LogPair = null;
			ConfigCommunityAll.HandleId = 0;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0008E361 File Offset: 0x0008C561
		public static void Init()
		{
			ConfigCommunityAll.HandleId = ConfigCommon.InitDataStatement(ConfigCommunityAll.HandleId, "db_platformchannel.db", "select BinData from `Community` where PackageType!=?");
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0008E37C File Offset: 0x0008C57C
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

		// Token: 0x04000ABF RID: 2751
		private const string DB = "db_platformchannel.db";

		// Token: 0x04000AC0 RID: 2752
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04000AC1 RID: 2753
		private const string TABLE = "Community";

		// Token: 0x04000AC2 RID: 2754
		private const string COMMAND = "select BinData from `Community` where PackageType!=?";

		// Token: 0x04000AC3 RID: 2755
		private const string KEY_PREFIX = "CommunityAll";

		// Token: 0x04000AC4 RID: 2756
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AC5 RID: 2757
		private static int HandleId;
	}
}
