using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001EB RID: 491
	public class ConfigDangoBrawlRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B85 RID: 2949 RVA: 0x0009E44B File Offset: 0x0009C64B
		static ConfigDangoBrawlRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRewardById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0009E46C File Offset: 0x0009C66C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlReward"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlReward` where Id=?")
			});
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0009E4EB File Offset: 0x0009C6EB
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRewardById.LogPair = null;
			ConfigDangoBrawlRewardById.HandleId = 0;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0009E4F9 File Offset: 0x0009C6F9
		public static void Init()
		{
			ConfigDangoBrawlRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRewardById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlReward` where Id=?");
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0009E514 File Offset: 0x0009C714
		public static DangoBrawlReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlRewardById.HandleId, ConfigDangoBrawlRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlReward?(DangoBrawlReward.GetRootAsDangoBrawlReward(configBuffer));
				}
			}
			ConfigDangoBrawlRewardById.LogPair.Clear();
			ConfigDangoBrawlRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlRewardById.HandleId, 1, p0Id, ConfigDangoBrawlRewardById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlRewardById.HandleId, true, ConfigDangoBrawlRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRewardById.HandleId, ConfigDangoBrawlRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlRewardById.HandleId, 0, ConfigDangoBrawlRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRewardById.HandleId, ConfigDangoBrawlRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlReward rootAsDangoBrawlReward = DangoBrawlReward.GetRootAsDangoBrawlReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlRewardById.HandleId, ConfigDangoBrawlRewardById.LogPair);
			return new DangoBrawlReward?(rootAsDangoBrawlReward);
		}

		// Token: 0x04000D51 RID: 3409
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D52 RID: 3410
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D53 RID: 3411
		private const string TABLE = "DangoBrawlReward";

		// Token: 0x04000D54 RID: 3412
		private const string COMMAND = "select BinData from `DangoBrawlReward` where Id=?";

		// Token: 0x04000D55 RID: 3413
		private const string KEY_PREFIX = "DangoBrawlRewardById";

		// Token: 0x04000D56 RID: 3414
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D57 RID: 3415
		private static int HandleId;
	}
}
