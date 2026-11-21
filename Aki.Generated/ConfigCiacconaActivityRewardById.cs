using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000173 RID: 371
	public class ConfigCiacconaActivityRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008B3 RID: 2227 RVA: 0x0008E35F File Offset: 0x0008C55F
		static ConfigCiacconaActivityRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaActivityRewardById.CreateStaticDefaultValue), new Action(ConfigCiacconaActivityRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0008E380 File Offset: 0x0008C580
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

		// Token: 0x060008B5 RID: 2229 RVA: 0x0008E3FF File Offset: 0x0008C5FF
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaActivityRewardById.LogPair = null;
			ConfigCiacconaActivityRewardById.HandleId = 0;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0008E40D File Offset: 0x0008C60D
		public static void Init()
		{
			ConfigCiacconaActivityRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaActivityRewardById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaActivityReward` where Id=?");
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0008E428 File Offset: 0x0008C628
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

		// Token: 0x04000A09 RID: 2569
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A0A RID: 2570
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A0B RID: 2571
		private const string TABLE = "CiacconaActivityReward";

		// Token: 0x04000A0C RID: 2572
		private const string COMMAND = "select BinData from `CiacconaActivityReward` where Id=?";

		// Token: 0x04000A0D RID: 2573
		private const string KEY_PREFIX = "CiacconaActivityRewardById";

		// Token: 0x04000A0E RID: 2574
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A0F RID: 2575
		private static int HandleId;
	}
}
