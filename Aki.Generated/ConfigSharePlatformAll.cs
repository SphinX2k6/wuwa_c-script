using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000956 RID: 2390
	public class ConfigSharePlatformAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003817 RID: 14359 RVA: 0x00199908 File Offset: 0x00197B08
		static ConfigSharePlatformAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSharePlatformAll.CreateStaticDefaultValue), new Action(ConfigSharePlatformAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x00199928 File Offset: 0x00197B28
		public static void CreateStaticDefaultValue()
		{
			ConfigSharePlatformAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSharePlatformAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformchannel.db"),
				new ValueTuple<string, object>("文件", "p.平台渠道.xlsx"),
				new ValueTuple<string, object>("表名", "SharePlatform"),
				new ValueTuple<string, object>("语句", "select BinData from `SharePlatform` where PackageType!=?")
			});
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x001999A7 File Offset: 0x00197BA7
		public static void ResetStaticDefaultValue()
		{
			ConfigSharePlatformAll.LogPair = null;
			ConfigSharePlatformAll.HandleId = 0;
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x001999B5 File Offset: 0x00197BB5
		public static void Init()
		{
			ConfigSharePlatformAll.HandleId = ConfigCommon.InitDataStatement(ConfigSharePlatformAll.HandleId, "db_platformchannel.db", "select BinData from `SharePlatform` where PackageType!=?");
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x001999D0 File Offset: 0x00197BD0
		[NullableContext(2)]
		public static IReadOnlyList<SharePlatform> GetConfigList(int p0PackageType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSharePlatformAll.HandleId, ConfigSharePlatformAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SharePlatformAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PackageType);
				IReadOnlyList<SharePlatform> readOnlyList = (IReadOnlyList<SharePlatform>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSharePlatformAll.LogPair.Clear();
			ConfigSharePlatformAll.LogPair.Add(new ValueTuple<string, object>("PackageType", p0PackageType));
			if (!ConfigCommon.BindInt(ConfigSharePlatformAll.HandleId, 1, p0PackageType, ConfigSharePlatformAll.LogPair))
			{
				ConfigCommon.Reset(ConfigSharePlatformAll.HandleId, ConfigSharePlatformAll.LogPair);
				return null;
			}
			List<SharePlatform> list = new List<SharePlatform>();
			while (ConfigCommon.Step(ConfigSharePlatformAll.HandleId, false, ConfigSharePlatformAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSharePlatformAll.HandleId, 0, ConfigSharePlatformAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSharePlatformAll.HandleId, ConfigSharePlatformAll.LogPair);
					return null;
				}
				SharePlatform rootAsSharePlatform = SharePlatform.GetRootAsSharePlatform(new ByteBuffer(item2));
				list.Add(rootAsSharePlatform);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SharePlatformAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PackageType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSharePlatformAll.HandleId, ConfigSharePlatformAll.LogPair);
			return list;
		}

		// Token: 0x04004140 RID: 16704
		private const string DB = "db_platformchannel.db";

		// Token: 0x04004141 RID: 16705
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04004142 RID: 16706
		private const string TABLE = "SharePlatform";

		// Token: 0x04004143 RID: 16707
		private const string COMMAND = "select BinData from `SharePlatform` where PackageType!=?";

		// Token: 0x04004144 RID: 16708
		private const string KEY_PREFIX = "SharePlatformAll";

		// Token: 0x04004145 RID: 16709
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004146 RID: 16710
		private static int HandleId;
	}
}
