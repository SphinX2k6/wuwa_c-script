using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000163 RID: 355
	public class ConfigCiacconaActivityRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000853 RID: 2131 RVA: 0x00088803 File Offset: 0x00086A03
		static ConfigCiacconaActivityRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaActivityRewardById.CreateStaticDefaultValue), new Action(ConfigCiacconaActivityRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00088824 File Offset: 0x00086A24
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaActivityRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaActivityRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaActivityReward"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaActivityReward` where Id=?")
			});
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000888A3 File Offset: 0x00086AA3
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaActivityRewardById.LogPair = null;
			ConfigCiacconaActivityRewardById.HandleId = 0;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000888B1 File Offset: 0x00086AB1
		public static void Init()
		{
			ConfigCiacconaActivityRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaActivityRewardById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaActivityReward` where Id=?");
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000888CC File Offset: 0x00086ACC
		public static CiacconaActivityReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaActivityRewardById.HandleId, ConfigCiacconaActivityRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaActivityRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaActivityReward?(CiacconaActivityReward.GetRootAsCiacconaActivityReward(configBuffer));
				}
			}
			ConfigCiacconaActivityRewardById.LogPair.Clear();
			ConfigCiacconaActivityRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaActivityRewardById.HandleId, 1, p0Id, ConfigCiacconaActivityRewardById.LogPair) || ConfigCommon.Step(ConfigCiacconaActivityRewardById.HandleId, true, ConfigCiacconaActivityRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaActivityRewardById.HandleId, ConfigCiacconaActivityRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaActivityRewardById.HandleId, 0, ConfigCiacconaActivityRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaActivityRewardById.HandleId, ConfigCiacconaActivityRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaActivityReward rootAsCiacconaActivityReward = CiacconaActivityReward.GetRootAsCiacconaActivityReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaActivityRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaActivityRewardById.HandleId, ConfigCiacconaActivityRewardById.LogPair);
			return new CiacconaActivityReward?(rootAsCiacconaActivityReward);
		}

		// Token: 0x04000999 RID: 2457
		private const string DB = "db_ciacconagal.db";

		// Token: 0x0400099A RID: 2458
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x0400099B RID: 2459
		private const string TABLE = "CiacconaActivityReward";

		// Token: 0x0400099C RID: 2460
		private const string COMMAND = "select BinData from `CiacconaActivityReward` where Id=?";

		// Token: 0x0400099D RID: 2461
		private const string KEY_PREFIX = "CiacconaActivityRewardById";

		// Token: 0x0400099E RID: 2462
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400099F RID: 2463
		private static int HandleId;
	}
}
