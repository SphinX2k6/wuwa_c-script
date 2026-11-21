using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BA RID: 1466
	public class ConfigMotorFrameById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002269 RID: 8809 RVA: 0x0011FAD4 File Offset: 0x0011DCD4
		static ConfigMotorFrameById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFrameById.CreateStaticDefaultValue), new Action(ConfigMotorFrameById.ResetStaticDefaultValue));
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0011FAF4 File Offset: 0x0011DCF4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFrameById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFrameById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFrame"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFrame` where Id=?")
			});
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x0011FB73 File Offset: 0x0011DD73
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFrameById.LogPair = null;
			ConfigMotorFrameById.HandleId = 0;
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0011FB81 File Offset: 0x0011DD81
		public static void Init()
		{
			ConfigMotorFrameById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFrameById.HandleId, "db_motordiy.db", "select BinData from `MotorFrame` where Id=?");
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0011FB9C File Offset: 0x0011DD9C
		public static MotorFrame? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFrameById.HandleId, ConfigMotorFrameById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFrameById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFrame?(MotorFrame.GetRootAsMotorFrame(configBuffer));
				}
			}
			ConfigMotorFrameById.LogPair.Clear();
			ConfigMotorFrameById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFrameById.HandleId, 1, p0Id, ConfigMotorFrameById.LogPair) || ConfigCommon.Step(ConfigMotorFrameById.HandleId, true, ConfigMotorFrameById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFrameById.HandleId, ConfigMotorFrameById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFrameById.HandleId, 0, ConfigMotorFrameById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFrameById.HandleId, ConfigMotorFrameById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFrame rootAsMotorFrame = MotorFrame.GetRootAsMotorFrame(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFrameById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFrameById.HandleId, ConfigMotorFrameById.LogPair);
			return new MotorFrame?(rootAsMotorFrame);
		}

		// Token: 0x040027FA RID: 10234
		private const string DB = "db_motordiy.db";

		// Token: 0x040027FB RID: 10235
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040027FC RID: 10236
		private const string TABLE = "MotorFrame";

		// Token: 0x040027FD RID: 10237
		private const string COMMAND = "select BinData from `MotorFrame` where Id=?";

		// Token: 0x040027FE RID: 10238
		private const string KEY_PREFIX = "MotorFrameById";

		// Token: 0x040027FF RID: 10239
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002800 RID: 10240
		private static int HandleId;
	}
}
