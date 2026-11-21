using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000587 RID: 1415
	public class ConfigMotionBySkinId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002137 RID: 8503 RVA: 0x00118BAF File Offset: 0x00116DAF
		static ConfigMotionBySkinId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotionBySkinId.CreateStaticDefaultValue), new Action(ConfigMotionBySkinId.ResetStaticDefaultValue));
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00118BD0 File Offset: 0x00116DD0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotionBySkinId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotionBySkinId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motion.db"),
				new ValueTuple<string, object>("文件", "d.动作.xlsx"),
				new ValueTuple<string, object>("表名", "Motion"),
				new ValueTuple<string, object>("语句", "select BinData from `Motion` where SkinId=?")
			});
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x00118C4F File Offset: 0x00116E4F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotionBySkinId.LogPair = null;
			ConfigMotionBySkinId.HandleId = 0;
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00118C5D File Offset: 0x00116E5D
		public static void Init()
		{
			ConfigMotionBySkinId.HandleId = ConfigCommon.InitDataStatement(ConfigMotionBySkinId.HandleId, "db_motion.db", "select BinData from `Motion` where SkinId=?");
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00118C78 File Offset: 0x00116E78
		[NullableContext(2)]
		public static IReadOnlyList<Motion> GetConfigList(int p0SkinId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotionBySkinId.HandleId, ConfigMotionBySkinId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotionBySkinId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				IReadOnlyList<Motion> readOnlyList = (IReadOnlyList<Motion>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotionBySkinId.LogPair.Clear();
			ConfigMotionBySkinId.LogPair.Add(new ValueTuple<string, object>("SkinId", p0SkinId));
			if (!ConfigCommon.BindInt(ConfigMotionBySkinId.HandleId, 1, p0SkinId, ConfigMotionBySkinId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotionBySkinId.HandleId, ConfigMotionBySkinId.LogPair);
				return null;
			}
			List<Motion> list = new List<Motion>();
			while (ConfigCommon.Step(ConfigMotionBySkinId.HandleId, false, ConfigMotionBySkinId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotionBySkinId.HandleId, 0, ConfigMotionBySkinId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotionBySkinId.HandleId, ConfigMotionBySkinId.LogPair);
					return null;
				}
				Motion rootAsMotion = Motion.GetRootAsMotion(new ByteBuffer(item2));
				list.Add(rootAsMotion);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotionBySkinId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotionBySkinId.HandleId, ConfigMotionBySkinId.LogPair);
			return list;
		}

		// Token: 0x04002695 RID: 9877
		private const string DB = "db_motion.db";

		// Token: 0x04002696 RID: 9878
		private const string FILE = "d.动作.xlsx";

		// Token: 0x04002697 RID: 9879
		private const string TABLE = "Motion";

		// Token: 0x04002698 RID: 9880
		private const string COMMAND = "select BinData from `Motion` where SkinId=?";

		// Token: 0x04002699 RID: 9881
		private const string KEY_PREFIX = "MotionBySkinId";

		// Token: 0x0400269A RID: 9882
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400269B RID: 9883
		private static int HandleId;
	}
}
