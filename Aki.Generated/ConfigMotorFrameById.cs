using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A3 RID: 1443
	public class ConfigMotorFrameById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021DF RID: 8671 RVA: 0x001191EC File Offset: 0x001173EC
		static ConfigMotorFrameById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFrameById.CreateStaticDefaultValue), new Action(ConfigMotorFrameById.ResetStaticDefaultValue));
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0011920C File Offset: 0x0011740C
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

		// Token: 0x060021E1 RID: 8673 RVA: 0x0011928B File Offset: 0x0011748B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFrameById.LogPair = null;
			ConfigMotorFrameById.HandleId = 0;
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00119299 File Offset: 0x00117499
		public static void Init()
		{
			ConfigMotorFrameById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFrameById.HandleId, "db_motordiy.db", "select BinData from `MotorFrame` where Id=?");
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x001192B4 File Offset: 0x001174B4
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

		// Token: 0x04002759 RID: 10073
		private const string DB = "db_motordiy.db";

		// Token: 0x0400275A RID: 10074
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x0400275B RID: 10075
		private const string TABLE = "MotorFrame";

		// Token: 0x0400275C RID: 10076
		private const string COMMAND = "select BinData from `MotorFrame` where Id=?";

		// Token: 0x0400275D RID: 10077
		private const string KEY_PREFIX = "MotorFrameById";

		// Token: 0x0400275E RID: 10078
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400275F RID: 10079
		private static int HandleId;
	}
}
