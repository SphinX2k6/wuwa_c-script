using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000586 RID: 1414
	public class ConfigMotionByRoleIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002131 RID: 8497 RVA: 0x0011891F File Offset: 0x00116B1F
		static ConfigMotionByRoleIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotionByRoleIdAndType.CreateStaticDefaultValue), new Action(ConfigMotionByRoleIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00118940 File Offset: 0x00116B40
		public static void CreateStaticDefaultValue()
		{
			ConfigMotionByRoleIdAndType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotionByRoleIdAndType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motion.db"),
				new ValueTuple<string, object>("文件", "d.动作.xlsx"),
				new ValueTuple<string, object>("表名", "Motion"),
				new ValueTuple<string, object>("语句", "select BinData from `Motion` where RoleId=? And Type=? Order By Sort")
			});
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x001189BF File Offset: 0x00116BBF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotionByRoleIdAndType.LogPair = null;
			ConfigMotionByRoleIdAndType.HandleId = 0;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x001189CD File Offset: 0x00116BCD
		public static void Init()
		{
			ConfigMotionByRoleIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigMotionByRoleIdAndType.HandleId, "db_motion.db", "select BinData from `Motion` where RoleId=? And Type=? Order By Sort");
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x001189E8 File Offset: 0x00116BE8
		[NullableContext(2)]
		public static IReadOnlyList<Motion> GetConfigList(int p0RoleId, int p1Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotionByRoleIdAndType.HandleId, ConfigMotionByRoleIdAndType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MotionByRoleIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				IReadOnlyList<Motion> readOnlyList = (IReadOnlyList<Motion>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotionByRoleIdAndType.LogPair.Clear();
			ConfigMotionByRoleIdAndType.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigMotionByRoleIdAndType.LogPair.Add(new ValueTuple<string, object>("Type", p1Type));
			if (!ConfigCommon.BindInt(ConfigMotionByRoleIdAndType.HandleId, 1, p0RoleId, ConfigMotionByRoleIdAndType.LogPair) || !ConfigCommon.BindInt(ConfigMotionByRoleIdAndType.HandleId, 2, p1Type, ConfigMotionByRoleIdAndType.LogPair))
			{
				ConfigCommon.Reset(ConfigMotionByRoleIdAndType.HandleId, ConfigMotionByRoleIdAndType.LogPair);
				return null;
			}
			List<Motion> list = new List<Motion>();
			while (ConfigCommon.Step(ConfigMotionByRoleIdAndType.HandleId, false, ConfigMotionByRoleIdAndType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotionByRoleIdAndType.HandleId, 0, ConfigMotionByRoleIdAndType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotionByRoleIdAndType.HandleId, ConfigMotionByRoleIdAndType.LogPair);
					return null;
				}
				Motion rootAsMotion = Motion.GetRootAsMotion(new ByteBuffer(item2));
				list.Add(rootAsMotion);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MotionByRoleIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotionByRoleIdAndType.HandleId, ConfigMotionByRoleIdAndType.LogPair);
			return list;
		}

		// Token: 0x0400268E RID: 9870
		private const string DB = "db_motion.db";

		// Token: 0x0400268F RID: 9871
		private const string FILE = "d.动作.xlsx";

		// Token: 0x04002690 RID: 9872
		private const string TABLE = "Motion";

		// Token: 0x04002691 RID: 9873
		private const string COMMAND = "select BinData from `Motion` where RoleId=? And Type=? Order By Sort";

		// Token: 0x04002692 RID: 9874
		private const string KEY_PREFIX = "MotionByRoleIdAndType";

		// Token: 0x04002693 RID: 9875
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002694 RID: 9876
		private static int HandleId;
	}
}
