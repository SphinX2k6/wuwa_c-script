using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000578 RID: 1400
	public class ConfigMotorDecalIpByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020DD RID: 8413 RVA: 0x00113324 File Offset: 0x00111524
		static ConfigMotorDecalIpByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecalIpByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorDecalIpByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00113344 File Offset: 0x00111544
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

		// Token: 0x060020DF RID: 8415 RVA: 0x001133C3 File Offset: 0x001115C3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecalIpByActivityId.LogPair = null;
			ConfigMotorDecalIpByActivityId.HandleId = 0;
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x001133D1 File Offset: 0x001115D1
		public static void Init()
		{
			ConfigMotorDecalIpByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecalIpByActivityId.HandleId, "db_motorstickerip.db", "select BinData from `MotorDecalIp` where ActivityId=?");
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x001133EC File Offset: 0x001115EC
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

		// Token: 0x0400262C RID: 9772
		private const string DB = "db_motorstickerip.db";

		// Token: 0x0400262D RID: 9773
		private const string FILE = "m.摩托车贴纸活动.xlsx";

		// Token: 0x0400262E RID: 9774
		private const string TABLE = "MotorDecalIp";

		// Token: 0x0400262F RID: 9775
		private const string COMMAND = "select BinData from `MotorDecalIp` where ActivityId=?";

		// Token: 0x04002630 RID: 9776
		private const string KEY_PREFIX = "MotorDecalIpByActivityId";

		// Token: 0x04002631 RID: 9777
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002632 RID: 9778
		private static int HandleId;
	}
}
