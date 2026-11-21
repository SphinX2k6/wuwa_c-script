using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000338 RID: 824
	public class ConfigFloroRanchRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001355 RID: 4949 RVA: 0x000CA397 File Offset: 0x000C8597
		static ConfigFloroRanchRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRewardById.CreateStaticDefaultValue), new Action(ConfigFloroRanchRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x000CA3B8 File Offset: 0x000C85B8
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchReward"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchReward` where Id=?")
			});
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x000CA437 File Offset: 0x000C8637
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRewardById.LogPair = null;
			ConfigFloroRanchRewardById.HandleId = 0;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x000CA445 File Offset: 0x000C8645
		public static void Init()
		{
			ConfigFloroRanchRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRewardById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchReward` where Id=?");
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x000CA460 File Offset: 0x000C8660
		public static FloroRanchReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchRewardById.HandleId, ConfigFloroRanchRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchReward?(FloroRanchReward.GetRootAsFloroRanchReward(configBuffer));
				}
			}
			ConfigFloroRanchRewardById.LogPair.Clear();
			ConfigFloroRanchRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchRewardById.HandleId, 1, p0Id, ConfigFloroRanchRewardById.LogPair) || ConfigCommon.Step(ConfigFloroRanchRewardById.HandleId, true, ConfigFloroRanchRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchRewardById.HandleId, ConfigFloroRanchRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchRewardById.HandleId, 0, ConfigFloroRanchRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchRewardById.HandleId, ConfigFloroRanchRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchReward rootAsFloroRanchReward = FloroRanchReward.GetRootAsFloroRanchReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchRewardById.HandleId, ConfigFloroRanchRewardById.LogPair);
			return new FloroRanchReward?(rootAsFloroRanchReward);
		}

		// Token: 0x0400166C RID: 5740
		private const string DB = "db_flororanch.db";

		// Token: 0x0400166D RID: 5741
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400166E RID: 5742
		private const string TABLE = "FloroRanchReward";

		// Token: 0x0400166F RID: 5743
		private const string COMMAND = "select BinData from `FloroRanchReward` where Id=?";

		// Token: 0x04001670 RID: 5744
		private const string KEY_PREFIX = "FloroRanchRewardById";

		// Token: 0x04001671 RID: 5745
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001672 RID: 5746
		private static int HandleId;
	}
}
