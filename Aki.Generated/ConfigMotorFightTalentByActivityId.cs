using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059B RID: 1435
	public class ConfigMotorFightTalentByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021AF RID: 8623 RVA: 0x00117FDC File Offset: 0x001161DC
		static ConfigMotorFightTalentByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTalentByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightTalentByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00117FFC File Offset: 0x001161FC
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

		// Token: 0x060021B1 RID: 8625 RVA: 0x0011807B File Offset: 0x0011627B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTalentByActivityId.LogPair = null;
			ConfigMotorFightTalentByActivityId.HandleId = 0;
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x00118089 File Offset: 0x00116289
		public static void Init()
		{
			ConfigMotorFightTalentByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTalentByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightTalent` where ActivityId=?");
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x001180A4 File Offset: 0x001162A4
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

		// Token: 0x04002721 RID: 10017
		private const string DB = "db_motorfight.db";

		// Token: 0x04002722 RID: 10018
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002723 RID: 10019
		private const string TABLE = "MotorFightTalent";

		// Token: 0x04002724 RID: 10020
		private const string COMMAND = "select BinData from `MotorFightTalent` where ActivityId=?";

		// Token: 0x04002725 RID: 10021
		private const string KEY_PREFIX = "MotorFightTalentByActivityId";

		// Token: 0x04002726 RID: 10022
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002727 RID: 10023
		private static int HandleId;
	}
}
