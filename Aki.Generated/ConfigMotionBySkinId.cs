using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000571 RID: 1393
	public class ConfigMotionBySkinId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020B3 RID: 8371 RVA: 0x0011245B File Offset: 0x0011065B
		static ConfigMotionBySkinId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotionBySkinId.CreateStaticDefaultValue), new Action(ConfigMotionBySkinId.ResetStaticDefaultValue));
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0011247C File Offset: 0x0011067C
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

		// Token: 0x060020B5 RID: 8373 RVA: 0x001124FB File Offset: 0x001106FB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotionBySkinId.LogPair = null;
			ConfigMotionBySkinId.HandleId = 0;
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00112509 File Offset: 0x00110709
		public static void Init()
		{
			ConfigMotionBySkinId.HandleId = ConfigCommon.InitDataStatement(ConfigMotionBySkinId.HandleId, "db_motion.db", "select BinData from `Motion` where SkinId=?");
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00112524 File Offset: 0x00110724
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

		// Token: 0x040025FB RID: 9723
		private const string DB = "db_motion.db";

		// Token: 0x040025FC RID: 9724
		private const string FILE = "d.动作.xlsx";

		// Token: 0x040025FD RID: 9725
		private const string TABLE = "Motion";

		// Token: 0x040025FE RID: 9726
		private const string COMMAND = "select BinData from `Motion` where SkinId=?";

		// Token: 0x040025FF RID: 9727
		private const string KEY_PREFIX = "MotionBySkinId";

		// Token: 0x04002600 RID: 9728
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002601 RID: 9729
		private static int HandleId;
	}
}
