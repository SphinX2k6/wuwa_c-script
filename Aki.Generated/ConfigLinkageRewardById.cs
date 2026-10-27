using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DC RID: 1244
	public class ConfigLinkageRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D33 RID: 7475 RVA: 0x000FE40F File Offset: 0x000FC60F
		static ConfigLinkageRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkageRewardById.CreateStaticDefaultValue), new Action(ConfigLinkageRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x000FE430 File Offset: 0x000FC630
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

		// Token: 0x06001D35 RID: 7477 RVA: 0x000FE4AF File Offset: 0x000FC6AF
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkageRewardById.LogPair = null;
			ConfigLinkageRewardById.HandleId = 0;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000FE4BD File Offset: 0x000FC6BD
		public static void Init()
		{
			ConfigLinkageRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigLinkageRewardById.HandleId, "db_linkagereward.db", "select BinData from `LinkageReward` where Id=?");
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x000FE4D8 File Offset: 0x000FC6D8
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

		// Token: 0x040021E8 RID: 8680
		private const string DB = "db_linkagereward.db";

		// Token: 0x040021E9 RID: 8681
		private const string FILE = "l.联动签到活动.xlsx";

		// Token: 0x040021EA RID: 8682
		private const string TABLE = "LinkageReward";

		// Token: 0x040021EB RID: 8683
		private const string COMMAND = "select BinData from `LinkageReward` where Id=?";

		// Token: 0x040021EC RID: 8684
		private const string KEY_PREFIX = "LinkageRewardById";

		// Token: 0x040021ED RID: 8685
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021EE RID: 8686
		private static int HandleId;
	}
}
