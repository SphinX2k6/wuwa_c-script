using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000570 RID: 1392
	public class ConfigMotionByRoleIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020AD RID: 8365 RVA: 0x001121CB File Offset: 0x001103CB
		static ConfigMotionByRoleIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotionByRoleIdAndType.CreateStaticDefaultValue), new Action(ConfigMotionByRoleIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x001121EC File Offset: 0x001103EC
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

		// Token: 0x060020AF RID: 8367 RVA: 0x0011226B File Offset: 0x0011046B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotionByRoleIdAndType.LogPair = null;
			ConfigMotionByRoleIdAndType.HandleId = 0;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00112279 File Offset: 0x00110479
		public static void Init()
		{
			ConfigMotionByRoleIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigMotionByRoleIdAndType.HandleId, "db_motion.db", "select BinData from `Motion` where RoleId=? And Type=? Order By Sort");
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00112294 File Offset: 0x00110494
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

		// Token: 0x040025F4 RID: 9716
		private const string DB = "db_motion.db";

		// Token: 0x040025F5 RID: 9717
		private const string FILE = "d.动作.xlsx";

		// Token: 0x040025F6 RID: 9718
		private const string TABLE = "Motion";

		// Token: 0x040025F7 RID: 9719
		private const string COMMAND = "select BinData from `Motion` where RoleId=? And Type=? Order By Sort";

		// Token: 0x040025F8 RID: 9720
		private const string KEY_PREFIX = "MotionByRoleIdAndType";

		// Token: 0x040025F9 RID: 9721
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025FA RID: 9722
		private static int HandleId;
	}
}
