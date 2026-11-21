using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000584 RID: 1412
	public class ConfigMotionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002125 RID: 8485 RVA: 0x001184A0 File Offset: 0x001166A0
		static ConfigMotionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotionById.CreateStaticDefaultValue), new Action(ConfigMotionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x001184C0 File Offset: 0x001166C0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motion.db"),
				new ValueTuple<string, object>("文件", "d.动作.xlsx"),
				new ValueTuple<string, object>("表名", "Motion"),
				new ValueTuple<string, object>("语句", "select BinData from `Motion` where Id=?")
			});
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x0011853F File Offset: 0x0011673F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotionById.LogPair = null;
			ConfigMotionById.HandleId = 0;
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0011854D File Offset: 0x0011674D
		public static void Init()
		{
			ConfigMotionById.HandleId = ConfigCommon.InitDataStatement(ConfigMotionById.HandleId, "db_motion.db", "select BinData from `Motion` where Id=?");
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00118568 File Offset: 0x00116768
		public static Motion? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotionById.HandleId, ConfigMotionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Motion?(Motion.GetRootAsMotion(configBuffer));
				}
			}
			ConfigMotionById.LogPair.Clear();
			ConfigMotionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotionById.HandleId, 1, p0Id, ConfigMotionById.LogPair) || ConfigCommon.Step(ConfigMotionById.HandleId, true, ConfigMotionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotionById.HandleId, ConfigMotionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotionById.HandleId, 0, ConfigMotionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotionById.HandleId, ConfigMotionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Motion rootAsMotion = Motion.GetRootAsMotion(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotionById.HandleId, ConfigMotionById.LogPair);
			return new Motion?(rootAsMotion);
		}

		// Token: 0x04002680 RID: 9856
		private const string DB = "db_motion.db";

		// Token: 0x04002681 RID: 9857
		private const string FILE = "d.动作.xlsx";

		// Token: 0x04002682 RID: 9858
		private const string TABLE = "Motion";

		// Token: 0x04002683 RID: 9859
		private const string COMMAND = "select BinData from `Motion` where Id=?";

		// Token: 0x04002684 RID: 9860
		private const string KEY_PREFIX = "MotionById";

		// Token: 0x04002685 RID: 9861
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002686 RID: 9862
		private static int HandleId;
	}
}
