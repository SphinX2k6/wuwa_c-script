using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018E RID: 398
	public class ConfigCommunityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000956 RID: 2390 RVA: 0x0008E4EB File Offset: 0x0008C6EB
		static ConfigCommunityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommunityById.CreateStaticDefaultValue), new Action(ConfigCommunityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0008E50C File Offset: 0x0008C70C
		public static void CreateStaticDefaultValue()
		{
			ConfigCommunityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommunityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformchannel.db"),
				new ValueTuple<string, object>("文件", "p.平台渠道.xlsx"),
				new ValueTuple<string, object>("表名", "Community"),
				new ValueTuple<string, object>("语句", "select BinData from `Community` where Id=?")
			});
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0008E58B File Offset: 0x0008C78B
		public static void ResetStaticDefaultValue()
		{
			ConfigCommunityById.LogPair = null;
			ConfigCommunityById.HandleId = 0;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0008E599 File Offset: 0x0008C799
		public static void Init()
		{
			ConfigCommunityById.HandleId = ConfigCommon.InitDataStatement(ConfigCommunityById.HandleId, "db_platformchannel.db", "select BinData from `Community` where Id=?");
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0008E5B4 File Offset: 0x0008C7B4
		public static Community? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommunityById.HandleId, ConfigCommunityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommunityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Community?(Community.GetRootAsCommunity(configBuffer));
				}
			}
			ConfigCommunityById.LogPair.Clear();
			ConfigCommunityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCommunityById.HandleId, 1, p0Id, ConfigCommunityById.LogPair) || ConfigCommon.Step(ConfigCommunityById.HandleId, true, ConfigCommunityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCommunityById.HandleId, ConfigCommunityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommunityById.HandleId, 0, ConfigCommunityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCommunityById.HandleId, ConfigCommunityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Community rootAsCommunity = Community.GetRootAsCommunity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommunityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCommunityById.HandleId, ConfigCommunityById.LogPair);
			return new Community?(rootAsCommunity);
		}

		// Token: 0x04000AC6 RID: 2758
		private const string DB = "db_platformchannel.db";

		// Token: 0x04000AC7 RID: 2759
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04000AC8 RID: 2760
		private const string TABLE = "Community";

		// Token: 0x04000AC9 RID: 2761
		private const string COMMAND = "select BinData from `Community` where Id=?";

		// Token: 0x04000ACA RID: 2762
		private const string KEY_PREFIX = "CommunityById";

		// Token: 0x04000ACB RID: 2763
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ACC RID: 2764
		private static int HandleId;
	}
}
