using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BB RID: 1467
	public class ConfigMotorFramePartById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600226F RID: 8815 RVA: 0x0011FD1C File Offset: 0x0011DF1C
		static ConfigMotorFramePartById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFramePartById.CreateStaticDefaultValue), new Action(ConfigMotorFramePartById.ResetStaticDefaultValue));
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x0011FD3C File Offset: 0x0011DF3C
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

		// Token: 0x06002271 RID: 8817 RVA: 0x0011FDBB File Offset: 0x0011DFBB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFramePartById.LogPair = null;
			ConfigMotorFramePartById.HandleId = 0;
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x0011FDC9 File Offset: 0x0011DFC9
		public static void Init()
		{
			ConfigMotorFramePartById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFramePartById.HandleId, "db_motordiy.db", "select BinData from `MotorFramePart` where Id=?");
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x0011FDE4 File Offset: 0x0011DFE4
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

		// Token: 0x04002801 RID: 10241
		private const string DB = "db_motordiy.db";

		// Token: 0x04002802 RID: 10242
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002803 RID: 10243
		private const string TABLE = "MotorFramePart";

		// Token: 0x04002804 RID: 10244
		private const string COMMAND = "select BinData from `MotorFramePart` where Id=?";

		// Token: 0x04002805 RID: 10245
		private const string KEY_PREFIX = "MotorFramePartById";

		// Token: 0x04002806 RID: 10246
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002807 RID: 10247
		private static int HandleId;
	}
}
