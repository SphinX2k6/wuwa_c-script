using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000585 RID: 1413
	public class ConfigMotionByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600212B RID: 8491 RVA: 0x001186E8 File Offset: 0x001168E8
		static ConfigMotionByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotionByRoleId.CreateStaticDefaultValue), new Action(ConfigMotionByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00118708 File Offset: 0x00116908
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

		// Token: 0x0600212D RID: 8493 RVA: 0x00118787 File Offset: 0x00116987
		public static void ResetStaticDefaultValue()
		{
			ConfigMotionByRoleId.LogPair = null;
			ConfigMotionByRoleId.HandleId = 0;
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00118795 File Offset: 0x00116995
		public static void Init()
		{
			ConfigMotionByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigMotionByRoleId.HandleId, "db_motion.db", "select BinData from `Motion` where RoleId=?");
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x001187B0 File Offset: 0x001169B0
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

		// Token: 0x04002687 RID: 9863
		private const string DB = "db_motion.db";

		// Token: 0x04002688 RID: 9864
		private const string FILE = "d.动作.xlsx";

		// Token: 0x04002689 RID: 9865
		private const string TABLE = "Motion";

		// Token: 0x0400268A RID: 9866
		private const string COMMAND = "select BinData from `Motion` where RoleId=?";

		// Token: 0x0400268B RID: 9867
		private const string KEY_PREFIX = "MotionByRoleId";

		// Token: 0x0400268C RID: 9868
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400268D RID: 9869
		private static int HandleId;
	}
}
