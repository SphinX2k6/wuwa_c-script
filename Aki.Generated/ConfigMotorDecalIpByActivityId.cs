using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058E RID: 1422
	public class ConfigMotorDecalIpByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002161 RID: 8545 RVA: 0x00119A78 File Offset: 0x00117C78
		static ConfigMotorDecalIpByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecalIpByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorDecalIpByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00119A98 File Offset: 0x00117C98
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDecalIpByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDecalIpByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorstickerip.db"),
				new ValueTuple<string, object>("文件", "m.摩托车贴纸活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDecalIp"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDecalIp` where ActivityId=?")
			});
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00119B17 File Offset: 0x00117D17
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecalIpByActivityId.LogPair = null;
			ConfigMotorDecalIpByActivityId.HandleId = 0;
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00119B25 File Offset: 0x00117D25
		public static void Init()
		{
			ConfigMotorDecalIpByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecalIpByActivityId.HandleId, "db_motorstickerip.db", "select BinData from `MotorDecalIp` where ActivityId=?");
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00119B40 File Offset: 0x00117D40
		[NullableContext(2)]
		public static IReadOnlyList<MotorDecalIp> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDecalIpByActivityId.HandleId, ConfigMotorDecalIpByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalIpByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<MotorDecalIp> readOnlyList = (IReadOnlyList<MotorDecalIp>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorDecalIpByActivityId.LogPair.Clear();
			ConfigMotorDecalIpByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorDecalIpByActivityId.HandleId, 1, p0ActivityId, ConfigMotorDecalIpByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorDecalIpByActivityId.HandleId, ConfigMotorDecalIpByActivityId.LogPair);
				return null;
			}
			List<MotorDecalIp> list = new List<MotorDecalIp>();
			while (ConfigCommon.Step(ConfigMotorDecalIpByActivityId.HandleId, false, ConfigMotorDecalIpByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDecalIpByActivityId.HandleId, 0, ConfigMotorDecalIpByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorDecalIpByActivityId.HandleId, ConfigMotorDecalIpByActivityId.LogPair);
					return null;
				}
				MotorDecalIp rootAsMotorDecalIp = MotorDecalIp.GetRootAsMotorDecalIp(new ByteBuffer(item2));
				list.Add(rootAsMotorDecalIp);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalIpByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorDecalIpByActivityId.HandleId, ConfigMotorDecalIpByActivityId.LogPair);
			return list;
		}

		// Token: 0x040026C6 RID: 9926
		private const string DB = "db_motorstickerip.db";

		// Token: 0x040026C7 RID: 9927
		private const string FILE = "m.摩托车贴纸活动.xlsx";

		// Token: 0x040026C8 RID: 9928
		private const string TABLE = "MotorDecalIp";

		// Token: 0x040026C9 RID: 9929
		private const string COMMAND = "select BinData from `MotorDecalIp` where ActivityId=?";

		// Token: 0x040026CA RID: 9930
		private const string KEY_PREFIX = "MotorDecalIpByActivityId";

		// Token: 0x040026CB RID: 9931
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026CC RID: 9932
		private static int HandleId;
	}
}
