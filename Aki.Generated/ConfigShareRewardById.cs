using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090D RID: 2317
	public class ConfigShareRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003661 RID: 13921 RVA: 0x0018CB68 File Offset: 0x0018AD68
		static ConfigShareRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShareRewardById.CreateStaticDefaultValue), new Action(ConfigShareRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x0018CB88 File Offset: 0x0018AD88
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

		// Token: 0x06003663 RID: 13923 RVA: 0x0018CC07 File Offset: 0x0018AE07
		public static void ResetStaticDefaultValue()
		{
			ConfigShareRewardById.LogPair = null;
			ConfigShareRewardById.HandleId = 0;
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x0018CC15 File Offset: 0x0018AE15
		public static void Init()
		{
			ConfigShareRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigShareRewardById.HandleId, "db_shareinfo.db", "select BinData from `ShareReward` where Id=?");
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x0018CC30 File Offset: 0x0018AE30
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

		// Token: 0x04003F41 RID: 16193
		private const string DB = "db_shareinfo.db";

		// Token: 0x04003F42 RID: 16194
		private const string FILE = "f.分享.xlsx";

		// Token: 0x04003F43 RID: 16195
		private const string TABLE = "ShareReward";

		// Token: 0x04003F44 RID: 16196
		private const string COMMAND = "select BinData from `ShareReward` where Id=?";

		// Token: 0x04003F45 RID: 16197
		private const string KEY_PREFIX = "ShareRewardById";

		// Token: 0x04003F46 RID: 16198
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F47 RID: 16199
		private static int HandleId;
	}
}
