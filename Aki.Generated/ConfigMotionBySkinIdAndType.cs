using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000588 RID: 1416
	public class ConfigMotionBySkinIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600213D RID: 8509 RVA: 0x00118DE7 File Offset: 0x00116FE7
		static ConfigMotionBySkinIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotionBySkinIdAndType.CreateStaticDefaultValue), new Action(ConfigMotionBySkinIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x00118E08 File Offset: 0x00117008
		public static void CreateStaticDefaultValue()
		{
			ConfigMotionBySkinIdAndType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotionBySkinIdAndType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motion.db"),
				new ValueTuple<string, object>("文件", "d.动作.xlsx"),
				new ValueTuple<string, object>("表名", "Motion"),
				new ValueTuple<string, object>("语句", "select BinData from `Motion` where SkinId=? And Type=? Order By Sort")
			});
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00118E87 File Offset: 0x00117087
		public static void ResetStaticDefaultValue()
		{
			ConfigMotionBySkinIdAndType.LogPair = null;
			ConfigMotionBySkinIdAndType.HandleId = 0;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00118E95 File Offset: 0x00117095
		public static void Init()
		{
			ConfigMotionBySkinIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigMotionBySkinIdAndType.HandleId, "db_motion.db", "select BinData from `Motion` where SkinId=? And Type=? Order By Sort");
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00118EB0 File Offset: 0x001170B0
		[NullableContext(2)]
		public static IReadOnlyList<Motion> GetConfigList(int p0SkinId, int p1Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotionBySkinIdAndType.HandleId, ConfigMotionBySkinIdAndType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MotionBySkinIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				IReadOnlyList<Motion> readOnlyList = (IReadOnlyList<Motion>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotionBySkinIdAndType.LogPair.Clear();
			ConfigMotionBySkinIdAndType.LogPair.Add(new ValueTuple<string, object>("SkinId", p0SkinId));
			ConfigMotionBySkinIdAndType.LogPair.Add(new ValueTuple<string, object>("Type", p1Type));
			if (!ConfigCommon.BindInt(ConfigMotionBySkinIdAndType.HandleId, 1, p0SkinId, ConfigMotionBySkinIdAndType.LogPair) || !ConfigCommon.BindInt(ConfigMotionBySkinIdAndType.HandleId, 2, p1Type, ConfigMotionBySkinIdAndType.LogPair))
			{
				ConfigCommon.Reset(ConfigMotionBySkinIdAndType.HandleId, ConfigMotionBySkinIdAndType.LogPair);
				return null;
			}
			List<Motion> list = new List<Motion>();
			while (ConfigCommon.Step(ConfigMotionBySkinIdAndType.HandleId, false, ConfigMotionBySkinIdAndType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotionBySkinIdAndType.HandleId, 0, ConfigMotionBySkinIdAndType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotionBySkinIdAndType.HandleId, ConfigMotionBySkinIdAndType.LogPair);
					return null;
				}
				Motion rootAsMotion = Motion.GetRootAsMotion(new ByteBuffer(item2));
				list.Add(rootAsMotion);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MotionBySkinIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotionBySkinIdAndType.HandleId, ConfigMotionBySkinIdAndType.LogPair);
			return list;
		}

		// Token: 0x0400269C RID: 9884
		private const string DB = "db_motion.db";

		// Token: 0x0400269D RID: 9885
		private const string FILE = "d.动作.xlsx";

		// Token: 0x0400269E RID: 9886
		private const string TABLE = "Motion";

		// Token: 0x0400269F RID: 9887
		private const string COMMAND = "select BinData from `Motion` where SkinId=? And Type=? Order By Sort";

		// Token: 0x040026A0 RID: 9888
		private const string KEY_PREFIX = "MotionBySkinIdAndType";

		// Token: 0x040026A1 RID: 9889
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026A2 RID: 9890
		private static int HandleId;
	}
}
