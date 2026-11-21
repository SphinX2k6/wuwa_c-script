using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A0 RID: 416
	public class ConfigCommunityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009C2 RID: 2498 RVA: 0x00094423 File Offset: 0x00092623
		static ConfigCommunityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommunityById.CreateStaticDefaultValue), new Action(ConfigCommunityById.ResetStaticDefaultValue));
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00094444 File Offset: 0x00092644
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

		// Token: 0x060009C4 RID: 2500 RVA: 0x000944C3 File Offset: 0x000926C3
		public static void ResetStaticDefaultValue()
		{
			ConfigCommunityById.LogPair = null;
			ConfigCommunityById.HandleId = 0;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000944D1 File Offset: 0x000926D1
		public static void Init()
		{
			ConfigCommunityById.HandleId = ConfigCommon.InitDataStatement(ConfigCommunityById.HandleId, "db_platformchannel.db", "select BinData from `Community` where Id=?");
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000944EC File Offset: 0x000926EC
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

		// Token: 0x04000B44 RID: 2884
		private const string DB = "db_platformchannel.db";

		// Token: 0x04000B45 RID: 2885
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04000B46 RID: 2886
		private const string TABLE = "Community";

		// Token: 0x04000B47 RID: 2887
		private const string COMMAND = "select BinData from `Community` where Id=?";

		// Token: 0x04000B48 RID: 2888
		private const string KEY_PREFIX = "CommunityById";

		// Token: 0x04000B49 RID: 2889
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B4A RID: 2890
		private static int HandleId;
	}
}
