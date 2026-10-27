using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200001E RID: 30
	public class ConfigAbyssRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x0005DD9B File Offset: 0x0005BF9B
		static ConfigAbyssRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRewardById.CreateStaticDefaultValue), new Action(ConfigAbyssRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0005DDBC File Offset: 0x0005BFBC
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssReward"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssReward` where Id=?")
			});
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0005DE3B File Offset: 0x0005C03B
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRewardById.LogPair = null;
			ConfigAbyssRewardById.HandleId = 0;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0005DE49 File Offset: 0x0005C049
		public static void Init()
		{
			ConfigAbyssRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRewardById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssReward` where Id=?");
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0005DE64 File Offset: 0x0005C064
		public static AbyssReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRewardById.HandleId, ConfigAbyssRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssReward?(AbyssReward.GetRootAsAbyssReward(configBuffer));
				}
			}
			ConfigAbyssRewardById.LogPair.Clear();
			ConfigAbyssRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssRewardById.HandleId, 1, p0Id, ConfigAbyssRewardById.LogPair) || ConfigCommon.Step(ConfigAbyssRewardById.HandleId, true, ConfigAbyssRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssRewardById.HandleId, ConfigAbyssRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRewardById.HandleId, 0, ConfigAbyssRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssRewardById.HandleId, ConfigAbyssRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssReward rootAsAbyssReward = AbyssReward.GetRootAsAbyssReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssRewardById.HandleId, ConfigAbyssRewardById.LogPair);
			return new AbyssReward?(rootAsAbyssReward);
		}

		// Token: 0x040000B6 RID: 182
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000B7 RID: 183
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000B8 RID: 184
		private const string TABLE = "AbyssReward";

		// Token: 0x040000B9 RID: 185
		private const string COMMAND = "select BinData from `AbyssReward` where Id=?";

		// Token: 0x040000BA RID: 186
		private const string KEY_PREFIX = "AbyssRewardById";

		// Token: 0x040000BB RID: 187
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000BC RID: 188
		private static int HandleId;
	}
}
