using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090B RID: 2315
	public class ConfigSharePlatformAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003655 RID: 13909 RVA: 0x0018C6E8 File Offset: 0x0018A8E8
		static ConfigSharePlatformAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSharePlatformAll.CreateStaticDefaultValue), new Action(ConfigSharePlatformAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x0018C708 File Offset: 0x0018A908
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

		// Token: 0x06003657 RID: 13911 RVA: 0x0018C787 File Offset: 0x0018A987
		public static void ResetStaticDefaultValue()
		{
			ConfigSharePlatformAll.LogPair = null;
			ConfigSharePlatformAll.HandleId = 0;
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x0018C795 File Offset: 0x0018A995
		public static void Init()
		{
			ConfigSharePlatformAll.HandleId = ConfigCommon.InitDataStatement(ConfigSharePlatformAll.HandleId, "db_platformchannel.db", "select BinData from `SharePlatform` where PackageType!=?");
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x0018C7B0 File Offset: 0x0018A9B0
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

		// Token: 0x04003F33 RID: 16179
		private const string DB = "db_platformchannel.db";

		// Token: 0x04003F34 RID: 16180
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04003F35 RID: 16181
		private const string TABLE = "SharePlatform";

		// Token: 0x04003F36 RID: 16182
		private const string COMMAND = "select BinData from `SharePlatform` where PackageType!=?";

		// Token: 0x04003F37 RID: 16183
		private const string KEY_PREFIX = "SharePlatformAll";

		// Token: 0x04003F38 RID: 16184
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F39 RID: 16185
		private static int HandleId;
	}
}
