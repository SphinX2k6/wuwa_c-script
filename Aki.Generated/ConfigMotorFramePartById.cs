using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A4 RID: 1444
	public class ConfigMotorFramePartById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021E5 RID: 8677 RVA: 0x00119434 File Offset: 0x00117634
		static ConfigMotorFramePartById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFramePartById.CreateStaticDefaultValue), new Action(ConfigMotorFramePartById.ResetStaticDefaultValue));
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00119454 File Offset: 0x00117654
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFramePartById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFramePartById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFramePart"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFramePart` where Id=?")
			});
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x001194D3 File Offset: 0x001176D3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFramePartById.LogPair = null;
			ConfigMotorFramePartById.HandleId = 0;
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x001194E1 File Offset: 0x001176E1
		public static void Init()
		{
			ConfigMotorFramePartById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFramePartById.HandleId, "db_motordiy.db", "select BinData from `MotorFramePart` where Id=?");
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x001194FC File Offset: 0x001176FC
		public static MotorFramePart? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFramePartById.HandleId, ConfigMotorFramePartById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFramePartById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFramePart?(MotorFramePart.GetRootAsMotorFramePart(configBuffer));
				}
			}
			ConfigMotorFramePartById.LogPair.Clear();
			ConfigMotorFramePartById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFramePartById.HandleId, 1, p0Id, ConfigMotorFramePartById.LogPair) || ConfigCommon.Step(ConfigMotorFramePartById.HandleId, true, ConfigMotorFramePartById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFramePartById.HandleId, ConfigMotorFramePartById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFramePartById.HandleId, 0, ConfigMotorFramePartById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFramePartById.HandleId, ConfigMotorFramePartById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFramePart rootAsMotorFramePart = MotorFramePart.GetRootAsMotorFramePart(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFramePartById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFramePartById.HandleId, ConfigMotorFramePartById.LogPair);
			return new MotorFramePart?(rootAsMotorFramePart);
		}

		// Token: 0x04002760 RID: 10080
		private const string DB = "db_motordiy.db";

		// Token: 0x04002761 RID: 10081
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002762 RID: 10082
		private const string TABLE = "MotorFramePart";

		// Token: 0x04002763 RID: 10083
		private const string COMMAND = "select BinData from `MotorFramePart` where Id=?";

		// Token: 0x04002764 RID: 10084
		private const string KEY_PREFIX = "MotorFramePartById";

		// Token: 0x04002765 RID: 10085
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002766 RID: 10086
		private static int HandleId;
	}
}
