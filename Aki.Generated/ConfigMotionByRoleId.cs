using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056F RID: 1391
	public class ConfigMotionByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020A7 RID: 8359 RVA: 0x00111F94 File Offset: 0x00110194
		static ConfigMotionByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotionByRoleId.CreateStaticDefaultValue), new Action(ConfigMotionByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x00111FB4 File Offset: 0x001101B4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotionByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotionByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motion.db"),
				new ValueTuple<string, object>("文件", "d.动作.xlsx"),
				new ValueTuple<string, object>("表名", "Motion"),
				new ValueTuple<string, object>("语句", "select BinData from `Motion` where RoleId=?")
			});
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x00112033 File Offset: 0x00110233
		public static void ResetStaticDefaultValue()
		{
			ConfigMotionByRoleId.LogPair = null;
			ConfigMotionByRoleId.HandleId = 0;
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00112041 File Offset: 0x00110241
		public static void Init()
		{
			ConfigMotionByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigMotionByRoleId.HandleId, "db_motion.db", "select BinData from `Motion` where RoleId=?");
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0011205C File Offset: 0x0011025C
		[NullableContext(2)]
		public static IReadOnlyList<Motion> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotionByRoleId.HandleId, ConfigMotionByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotionByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<Motion> readOnlyList = (IReadOnlyList<Motion>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotionByRoleId.LogPair.Clear();
			ConfigMotionByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigMotionByRoleId.HandleId, 1, p0RoleId, ConfigMotionByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotionByRoleId.HandleId, ConfigMotionByRoleId.LogPair);
				return null;
			}
			List<Motion> list = new List<Motion>();
			while (ConfigCommon.Step(ConfigMotionByRoleId.HandleId, false, ConfigMotionByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotionByRoleId.HandleId, 0, ConfigMotionByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotionByRoleId.HandleId, ConfigMotionByRoleId.LogPair);
					return null;
				}
				Motion rootAsMotion = Motion.GetRootAsMotion(new ByteBuffer(item2));
				list.Add(rootAsMotion);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotionByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotionByRoleId.HandleId, ConfigMotionByRoleId.LogPair);
			return list;
		}

		// Token: 0x040025ED RID: 9709
		private const string DB = "db_motion.db";

		// Token: 0x040025EE RID: 9710
		private const string FILE = "d.动作.xlsx";

		// Token: 0x040025EF RID: 9711
		private const string TABLE = "Motion";

		// Token: 0x040025F0 RID: 9712
		private const string COMMAND = "select BinData from `Motion` where RoleId=?";

		// Token: 0x040025F1 RID: 9713
		private const string KEY_PREFIX = "MotionByRoleId";

		// Token: 0x040025F2 RID: 9714
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025F3 RID: 9715
		private static int HandleId;
	}
}
