using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000226 RID: 550
	public class ConfigDoubleRewardActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CE7 RID: 3303 RVA: 0x000A60FF File Offset: 0x000A42FF
		static ConfigDoubleRewardActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDoubleRewardActivityById.CreateStaticDefaultValue), new Action(ConfigDoubleRewardActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000A6120 File Offset: 0x000A4320
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

		// Token: 0x06000CE9 RID: 3305 RVA: 0x000A619F File Offset: 0x000A439F
		public static void ResetStaticDefaultValue()
		{
			ConfigDoubleRewardActivityById.LogPair = null;
			ConfigDoubleRewardActivityById.HandleId = 0;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000A61AD File Offset: 0x000A43AD
		public static void Init()
		{
			ConfigDoubleRewardActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigDoubleRewardActivityById.HandleId, "db_doublerewardactivity.db", "select BinData from `DoubleRewardActivity` where Id=?");
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x000A61C8 File Offset: 0x000A43C8
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

		// Token: 0x04000EEE RID: 3822
		private const string DB = "db_doublerewardactivity.db";

		// Token: 0x04000EEF RID: 3823
		private const string FILE = "f.副本翻倍掉落活动.xlsx";

		// Token: 0x04000EF0 RID: 3824
		private const string TABLE = "DoubleRewardActivity";

		// Token: 0x04000EF1 RID: 3825
		private const string COMMAND = "select BinData from `DoubleRewardActivity` where Id=?";

		// Token: 0x04000EF2 RID: 3826
		private const string KEY_PREFIX = "DoubleRewardActivityById";

		// Token: 0x04000EF3 RID: 3827
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EF4 RID: 3828
		private static int HandleId;
	}
}
