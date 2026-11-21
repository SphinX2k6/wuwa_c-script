using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000958 RID: 2392
	public class ConfigShareRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003823 RID: 14371 RVA: 0x00199D88 File Offset: 0x00197F88
		static ConfigShareRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShareRewardById.CreateStaticDefaultValue), new Action(ConfigShareRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x00199DA8 File Offset: 0x00197FA8
		public static void CreateStaticDefaultValue()
		{
			ConfigShareRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigShareRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shareinfo.db"),
				new ValueTuple<string, object>("文件", "f.分享.xlsx"),
				new ValueTuple<string, object>("表名", "ShareReward"),
				new ValueTuple<string, object>("语句", "select BinData from `ShareReward` where Id=?")
			});
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x00199E27 File Offset: 0x00198027
		public static void ResetStaticDefaultValue()
		{
			ConfigShareRewardById.LogPair = null;
			ConfigShareRewardById.HandleId = 0;
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00199E35 File Offset: 0x00198035
		public static void Init()
		{
			ConfigShareRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigShareRewardById.HandleId, "db_shareinfo.db", "select BinData from `ShareReward` where Id=?");
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00199E50 File Offset: 0x00198050
		public static ShareReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigShareRewardById.HandleId, ConfigShareRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShareRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ShareReward?(ShareReward.GetRootAsShareReward(configBuffer));
				}
			}
			ConfigShareRewardById.LogPair.Clear();
			ConfigShareRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigShareRewardById.HandleId, 1, p0Id, ConfigShareRewardById.LogPair) || ConfigCommon.Step(ConfigShareRewardById.HandleId, true, ConfigShareRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigShareRewardById.HandleId, ConfigShareRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigShareRewardById.HandleId, 0, ConfigShareRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigShareRewardById.HandleId, ConfigShareRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ShareReward rootAsShareReward = ShareReward.GetRootAsShareReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShareRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigShareRewardById.HandleId, ConfigShareRewardById.LogPair);
			return new ShareReward?(rootAsShareReward);
		}

		// Token: 0x0400414E RID: 16718
		private const string DB = "db_shareinfo.db";

		// Token: 0x0400414F RID: 16719
		private const string FILE = "f.分享.xlsx";

		// Token: 0x04004150 RID: 16720
		private const string TABLE = "ShareReward";

		// Token: 0x04004151 RID: 16721
		private const string COMMAND = "select BinData from `ShareReward` where Id=?";

		// Token: 0x04004152 RID: 16722
		private const string KEY_PREFIX = "ShareRewardById";

		// Token: 0x04004153 RID: 16723
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004154 RID: 16724
		private static int HandleId;
	}
}
