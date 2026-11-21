using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021F RID: 543
	public class ConfigDirectTrainHighlightById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CBD RID: 3261 RVA: 0x000A5323 File Offset: 0x000A3523
		static ConfigDirectTrainHighlightById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainHighlightById.CreateStaticDefaultValue), new Action(ConfigDirectTrainHighlightById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x000A5344 File Offset: 0x000A3544
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

		// Token: 0x06000CBF RID: 3263 RVA: 0x000A53C3 File Offset: 0x000A35C3
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainHighlightById.LogPair = null;
			ConfigDirectTrainHighlightById.HandleId = 0;
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x000A53D1 File Offset: 0x000A35D1
		public static void Init()
		{
			ConfigDirectTrainHighlightById.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainHighlightById.HandleId, "db_directtrain.db", "select BinData from `DirectTrainHighlight` where Id=?");
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x000A53EC File Offset: 0x000A35EC
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

		// Token: 0x04000EBD RID: 3773
		private const string DB = "db_directtrain.db";

		// Token: 0x04000EBE RID: 3774
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000EBF RID: 3775
		private const string TABLE = "DirectTrainHighlight";

		// Token: 0x04000EC0 RID: 3776
		private const string COMMAND = "select BinData from `DirectTrainHighlight` where Id=?";

		// Token: 0x04000EC1 RID: 3777
		private const string KEY_PREFIX = "DirectTrainHighlightById";

		// Token: 0x04000EC2 RID: 3778
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EC3 RID: 3779
		private static int HandleId;
	}
}
