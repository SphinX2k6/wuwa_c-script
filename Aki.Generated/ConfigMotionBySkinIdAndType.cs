using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000572 RID: 1394
	public class ConfigMotionBySkinIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020B9 RID: 8377 RVA: 0x00112693 File Offset: 0x00110893
		static ConfigMotionBySkinIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotionBySkinIdAndType.CreateStaticDefaultValue), new Action(ConfigMotionBySkinIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x001126B4 File Offset: 0x001108B4
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

		// Token: 0x060020BB RID: 8379 RVA: 0x00112733 File Offset: 0x00110933
		public static void ResetStaticDefaultValue()
		{
			ConfigMotionBySkinIdAndType.LogPair = null;
			ConfigMotionBySkinIdAndType.HandleId = 0;
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00112741 File Offset: 0x00110941
		public static void Init()
		{
			ConfigMotionBySkinIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigMotionBySkinIdAndType.HandleId, "db_motion.db", "select BinData from `Motion` where SkinId=? And Type=? Order By Sort");
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x0011275C File Offset: 0x0011095C
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

		// Token: 0x04002602 RID: 9730
		private const string DB = "db_motion.db";

		// Token: 0x04002603 RID: 9731
		private const string FILE = "d.动作.xlsx";

		// Token: 0x04002604 RID: 9732
		private const string TABLE = "Motion";

		// Token: 0x04002605 RID: 9733
		private const string COMMAND = "select BinData from `Motion` where SkinId=? And Type=? Order By Sort";

		// Token: 0x04002606 RID: 9734
		private const string KEY_PREFIX = "MotionBySkinIdAndType";

		// Token: 0x04002607 RID: 9735
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002608 RID: 9736
		private static int HandleId;
	}
}
