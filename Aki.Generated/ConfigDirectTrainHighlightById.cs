using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020D RID: 525
	public class ConfigDirectTrainHighlightById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C51 RID: 3153 RVA: 0x0009F3EB File Offset: 0x0009D5EB
		static ConfigDirectTrainHighlightById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainHighlightById.CreateStaticDefaultValue), new Action(ConfigDirectTrainHighlightById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0009F40C File Offset: 0x0009D60C
		public static void CreateStaticDefaultValue()
		{
			ConfigDirectTrainHighlightById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDirectTrainHighlightById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_directtrain.db"),
				new ValueTuple<string, object>("文件", "j.剧情直通车活动.xlsx"),
				new ValueTuple<string, object>("表名", "DirectTrainHighlight"),
				new ValueTuple<string, object>("语句", "select BinData from `DirectTrainHighlight` where Id=?")
			});
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0009F48B File Offset: 0x0009D68B
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainHighlightById.LogPair = null;
			ConfigDirectTrainHighlightById.HandleId = 0;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0009F499 File Offset: 0x0009D699
		public static void Init()
		{
			ConfigDirectTrainHighlightById.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainHighlightById.HandleId, "db_directtrain.db", "select BinData from `DirectTrainHighlight` where Id=?");
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0009F4B4 File Offset: 0x0009D6B4
		public static DirectTrainHighlight? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDirectTrainHighlightById.HandleId, ConfigDirectTrainHighlightById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DirectTrainHighlightById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DirectTrainHighlight?(DirectTrainHighlight.GetRootAsDirectTrainHighlight(configBuffer));
				}
			}
			ConfigDirectTrainHighlightById.LogPair.Clear();
			ConfigDirectTrainHighlightById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDirectTrainHighlightById.HandleId, 1, p0Id, ConfigDirectTrainHighlightById.LogPair) || ConfigCommon.Step(ConfigDirectTrainHighlightById.HandleId, true, ConfigDirectTrainHighlightById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDirectTrainHighlightById.HandleId, ConfigDirectTrainHighlightById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDirectTrainHighlightById.HandleId, 0, ConfigDirectTrainHighlightById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDirectTrainHighlightById.HandleId, ConfigDirectTrainHighlightById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DirectTrainHighlight rootAsDirectTrainHighlight = DirectTrainHighlight.GetRootAsDirectTrainHighlight(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DirectTrainHighlightById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDirectTrainHighlightById.HandleId, ConfigDirectTrainHighlightById.LogPair);
			return new DirectTrainHighlight?(rootAsDirectTrainHighlight);
		}

		// Token: 0x04000E3F RID: 3647
		private const string DB = "db_directtrain.db";

		// Token: 0x04000E40 RID: 3648
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000E41 RID: 3649
		private const string TABLE = "DirectTrainHighlight";

		// Token: 0x04000E42 RID: 3650
		private const string COMMAND = "select BinData from `DirectTrainHighlight` where Id=?";

		// Token: 0x04000E43 RID: 3651
		private const string KEY_PREFIX = "DirectTrainHighlightById";

		// Token: 0x04000E44 RID: 3652
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E45 RID: 3653
		private static int HandleId;
	}
}
