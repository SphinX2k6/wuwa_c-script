using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200000C RID: 12
	public class ConfigAbpStateByAbp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0005BA8C File Offset: 0x00059C8C
		static ConfigAbpStateByAbp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbpStateByAbp.CreateStaticDefaultValue), new Action(ConfigAbpStateByAbp.ResetStaticDefaultValue));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0005BAAC File Offset: 0x00059CAC
		public static void CreateStaticDefaultValue()
		{
			ConfigAbpStateByAbp.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbpStateByAbp.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_abpstate.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.ABP状态定义/*.csv*"),
				new ValueTuple<string, object>("表名", "AbpState"),
				new ValueTuple<string, object>("语句", "select BinData from `AbpState` where Abp=?")
			});
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0005BB2B File Offset: 0x00059D2B
		public static void ResetStaticDefaultValue()
		{
			ConfigAbpStateByAbp.LogPair = null;
			ConfigAbpStateByAbp.HandleId = 0;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0005BB39 File Offset: 0x00059D39
		public static void Init()
		{
			ConfigAbpStateByAbp.HandleId = ConfigCommon.InitDataStatement(ConfigAbpStateByAbp.HandleId, "db_abpstate.db", "select BinData from `AbpState` where Abp=?");
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0005BB54 File Offset: 0x00059D54
		public static AbpState? GetConfig(string p0Abp, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbpStateByAbp.HandleId, ConfigAbpStateByAbp.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("AbpStateByAbp#" + p0Abp);
				if (configBuffer != null)
				{
					return new AbpState?(AbpState.GetRootAsAbpState(configBuffer));
				}
			}
			ConfigAbpStateByAbp.LogPair.Clear();
			ConfigAbpStateByAbp.LogPair.Add(new ValueTuple<string, object>("Abp", p0Abp));
			if (!ConfigCommon.BindString(ConfigAbpStateByAbp.HandleId, 1, p0Abp, ConfigAbpStateByAbp.LogPair) || ConfigCommon.Step(ConfigAbpStateByAbp.HandleId, true, ConfigAbpStateByAbp.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbpStateByAbp.HandleId, ConfigAbpStateByAbp.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbpStateByAbp.HandleId, 0, ConfigAbpStateByAbp.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbpStateByAbp.HandleId, ConfigAbpStateByAbp.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbpState rootAsAbpState = AbpState.GetRootAsAbpState(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("AbpStateByAbp#" + p0Abp, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbpStateByAbp.HandleId, ConfigAbpStateByAbp.LogPair);
			return new AbpState?(rootAsAbpState);
		}

		// Token: 0x04000038 RID: 56
		private const string DB = "db_abpstate.db";

		// Token: 0x04000039 RID: 57
		private const string FILE = "k.可视化编辑/c.Csv/a.ABP状态定义/*.csv*";

		// Token: 0x0400003A RID: 58
		private const string TABLE = "AbpState";

		// Token: 0x0400003B RID: 59
		private const string COMMAND = "select BinData from `AbpState` where Abp=?";

		// Token: 0x0400003C RID: 60
		private const string KEY_PREFIX = "AbpStateByAbp";

		// Token: 0x0400003D RID: 61
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400003E RID: 62
		private static int HandleId;
	}
}
