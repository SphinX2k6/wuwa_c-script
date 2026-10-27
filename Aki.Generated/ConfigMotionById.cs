using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056E RID: 1390
	public class ConfigMotionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020A1 RID: 8353 RVA: 0x00111D4C File Offset: 0x0010FF4C
		static ConfigMotionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotionById.CreateStaticDefaultValue), new Action(ConfigMotionById.ResetStaticDefaultValue));
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00111D6C File Offset: 0x0010FF6C
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

		// Token: 0x060020A3 RID: 8355 RVA: 0x00111DEB File Offset: 0x0010FFEB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotionById.LogPair = null;
			ConfigMotionById.HandleId = 0;
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00111DF9 File Offset: 0x0010FFF9
		public static void Init()
		{
			ConfigMotionById.HandleId = ConfigCommon.InitDataStatement(ConfigMotionById.HandleId, "db_motion.db", "select BinData from `Motion` where Id=?");
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00111E14 File Offset: 0x00110014
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

		// Token: 0x040025E6 RID: 9702
		private const string DB = "db_motion.db";

		// Token: 0x040025E7 RID: 9703
		private const string FILE = "d.动作.xlsx";

		// Token: 0x040025E8 RID: 9704
		private const string TABLE = "Motion";

		// Token: 0x040025E9 RID: 9705
		private const string COMMAND = "select BinData from `Motion` where Id=?";

		// Token: 0x040025EA RID: 9706
		private const string KEY_PREFIX = "MotionById";

		// Token: 0x040025EB RID: 9707
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025EC RID: 9708
		private static int HandleId;
	}
}
