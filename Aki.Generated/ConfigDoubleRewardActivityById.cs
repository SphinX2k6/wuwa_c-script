using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000214 RID: 532
	public class ConfigDoubleRewardActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C7B RID: 3195 RVA: 0x000A01C7 File Offset: 0x0009E3C7
		static ConfigDoubleRewardActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDoubleRewardActivityById.CreateStaticDefaultValue), new Action(ConfigDoubleRewardActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000A01E8 File Offset: 0x0009E3E8
		public static void CreateStaticDefaultValue()
		{
			ConfigDoubleRewardActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDoubleRewardActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_doublerewardactivity.db"),
				new ValueTuple<string, object>("文件", "f.副本翻倍掉落活动.xlsx"),
				new ValueTuple<string, object>("表名", "DoubleRewardActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `DoubleRewardActivity` where Id=?")
			});
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x000A0267 File Offset: 0x0009E467
		public static void ResetStaticDefaultValue()
		{
			ConfigDoubleRewardActivityById.LogPair = null;
			ConfigDoubleRewardActivityById.HandleId = 0;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000A0275 File Offset: 0x0009E475
		public static void Init()
		{
			ConfigDoubleRewardActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigDoubleRewardActivityById.HandleId, "db_doublerewardactivity.db", "select BinData from `DoubleRewardActivity` where Id=?");
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000A0290 File Offset: 0x0009E490
		public static DoubleRewardActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDoubleRewardActivityById.HandleId, ConfigDoubleRewardActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DoubleRewardActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DoubleRewardActivity?(DoubleRewardActivity.GetRootAsDoubleRewardActivity(configBuffer));
				}
			}
			ConfigDoubleRewardActivityById.LogPair.Clear();
			ConfigDoubleRewardActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDoubleRewardActivityById.HandleId, 1, p0Id, ConfigDoubleRewardActivityById.LogPair) || ConfigCommon.Step(ConfigDoubleRewardActivityById.HandleId, true, ConfigDoubleRewardActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDoubleRewardActivityById.HandleId, ConfigDoubleRewardActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDoubleRewardActivityById.HandleId, 0, ConfigDoubleRewardActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDoubleRewardActivityById.HandleId, ConfigDoubleRewardActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DoubleRewardActivity rootAsDoubleRewardActivity = DoubleRewardActivity.GetRootAsDoubleRewardActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DoubleRewardActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDoubleRewardActivityById.HandleId, ConfigDoubleRewardActivityById.LogPair);
			return new DoubleRewardActivity?(rootAsDoubleRewardActivity);
		}

		// Token: 0x04000E70 RID: 3696
		private const string DB = "db_doublerewardactivity.db";

		// Token: 0x04000E71 RID: 3697
		private const string FILE = "f.副本翻倍掉落活动.xlsx";

		// Token: 0x04000E72 RID: 3698
		private const string TABLE = "DoubleRewardActivity";

		// Token: 0x04000E73 RID: 3699
		private const string COMMAND = "select BinData from `DoubleRewardActivity` where Id=?";

		// Token: 0x04000E74 RID: 3700
		private const string KEY_PREFIX = "DoubleRewardActivityById";

		// Token: 0x04000E75 RID: 3701
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E76 RID: 3702
		private static int HandleId;
	}
}
