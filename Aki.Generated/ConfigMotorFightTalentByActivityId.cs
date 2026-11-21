using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B2 RID: 1458
	public class ConfigMotorFightTalentByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002239 RID: 8761 RVA: 0x0011E8C4 File Offset: 0x0011CAC4
		static ConfigMotorFightTalentByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTalentByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightTalentByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x0011E8E4 File Offset: 0x0011CAE4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightTalentByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightTalentByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightTalent"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightTalent` where ActivityId=?")
			});
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x0011E963 File Offset: 0x0011CB63
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTalentByActivityId.LogPair = null;
			ConfigMotorFightTalentByActivityId.HandleId = 0;
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x0011E971 File Offset: 0x0011CB71
		public static void Init()
		{
			ConfigMotorFightTalentByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTalentByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightTalent` where ActivityId=?");
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0011E98C File Offset: 0x0011CB8C
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightTalent> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightTalentByActivityId.HandleId, ConfigMotorFightTalentByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTalentByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<MotorFightTalent> readOnlyList = (IReadOnlyList<MotorFightTalent>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorFightTalentByActivityId.LogPair.Clear();
			ConfigMotorFightTalentByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorFightTalentByActivityId.HandleId, 1, p0ActivityId, ConfigMotorFightTalentByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorFightTalentByActivityId.HandleId, ConfigMotorFightTalentByActivityId.LogPair);
				return null;
			}
			List<MotorFightTalent> list = new List<MotorFightTalent>();
			while (ConfigCommon.Step(ConfigMotorFightTalentByActivityId.HandleId, false, ConfigMotorFightTalentByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightTalentByActivityId.HandleId, 0, ConfigMotorFightTalentByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightTalentByActivityId.HandleId, ConfigMotorFightTalentByActivityId.LogPair);
					return null;
				}
				MotorFightTalent rootAsMotorFightTalent = MotorFightTalent.GetRootAsMotorFightTalent(new ByteBuffer(item2));
				list.Add(rootAsMotorFightTalent);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTalentByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightTalentByActivityId.HandleId, ConfigMotorFightTalentByActivityId.LogPair);
			return list;
		}

		// Token: 0x040027C2 RID: 10178
		private const string DB = "db_motorfight.db";

		// Token: 0x040027C3 RID: 10179
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040027C4 RID: 10180
		private const string TABLE = "MotorFightTalent";

		// Token: 0x040027C5 RID: 10181
		private const string COMMAND = "select BinData from `MotorFightTalent` where ActivityId=?";

		// Token: 0x040027C6 RID: 10182
		private const string KEY_PREFIX = "MotorFightTalentByActivityId";

		// Token: 0x040027C7 RID: 10183
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027C8 RID: 10184
		private static int HandleId;
	}
}
