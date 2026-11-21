using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F2 RID: 1266
	public class ConfigLinkageRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DB7 RID: 7607 RVA: 0x00104B63 File Offset: 0x00102D63
		static ConfigLinkageRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkageRewardById.CreateStaticDefaultValue), new Action(ConfigLinkageRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00104B84 File Offset: 0x00102D84
		public static void CreateStaticDefaultValue()
		{
			ConfigLinkageRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLinkageRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_linkagereward.db"),
				new ValueTuple<string, object>("文件", "l.联动签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "LinkageReward"),
				new ValueTuple<string, object>("语句", "select BinData from `LinkageReward` where Id=?")
			});
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00104C03 File Offset: 0x00102E03
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkageRewardById.LogPair = null;
			ConfigLinkageRewardById.HandleId = 0;
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00104C11 File Offset: 0x00102E11
		public static void Init()
		{
			ConfigLinkageRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigLinkageRewardById.HandleId, "db_linkagereward.db", "select BinData from `LinkageReward` where Id=?");
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00104C2C File Offset: 0x00102E2C
		public static LinkageReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLinkageRewardById.HandleId, ConfigLinkageRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkageRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LinkageReward?(LinkageReward.GetRootAsLinkageReward(configBuffer));
				}
			}
			ConfigLinkageRewardById.LogPair.Clear();
			ConfigLinkageRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLinkageRewardById.HandleId, 1, p0Id, ConfigLinkageRewardById.LogPair) || ConfigCommon.Step(ConfigLinkageRewardById.HandleId, true, ConfigLinkageRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLinkageRewardById.HandleId, ConfigLinkageRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLinkageRewardById.HandleId, 0, ConfigLinkageRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLinkageRewardById.HandleId, ConfigLinkageRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LinkageReward rootAsLinkageReward = LinkageReward.GetRootAsLinkageReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkageRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLinkageRewardById.HandleId, ConfigLinkageRewardById.LogPair);
			return new LinkageReward?(rootAsLinkageReward);
		}

		// Token: 0x04002282 RID: 8834
		private const string DB = "db_linkagereward.db";

		// Token: 0x04002283 RID: 8835
		private const string FILE = "l.联动签到活动.xlsx";

		// Token: 0x04002284 RID: 8836
		private const string TABLE = "LinkageReward";

		// Token: 0x04002285 RID: 8837
		private const string COMMAND = "select BinData from `LinkageReward` where Id=?";

		// Token: 0x04002286 RID: 8838
		private const string KEY_PREFIX = "LinkageRewardById";

		// Token: 0x04002287 RID: 8839
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002288 RID: 8840
		private static int HandleId;
	}
}
