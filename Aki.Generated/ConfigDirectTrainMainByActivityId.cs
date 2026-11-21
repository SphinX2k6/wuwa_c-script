using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000221 RID: 545
	public class ConfigDirectTrainMainByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CC9 RID: 3273 RVA: 0x000A56FF File Offset: 0x000A38FF
		static ConfigDirectTrainMainByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainMainByActivityId.CreateStaticDefaultValue), new Action(ConfigDirectTrainMainByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000A5720 File Offset: 0x000A3920
		public static void CreateStaticDefaultValue()
		{
			ConfigDirectTrainMainByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDirectTrainMainByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_directtrain.db"),
				new ValueTuple<string, object>("文件", "j.剧情直通车活动.xlsx"),
				new ValueTuple<string, object>("表名", "DirectTrainMain"),
				new ValueTuple<string, object>("语句", "select BinData from `DirectTrainMain` where ActivityId=?")
			});
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000A579F File Offset: 0x000A399F
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainMainByActivityId.LogPair = null;
			ConfigDirectTrainMainByActivityId.HandleId = 0;
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x000A57AD File Offset: 0x000A39AD
		public static void Init()
		{
			ConfigDirectTrainMainByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainMainByActivityId.HandleId, "db_directtrain.db", "select BinData from `DirectTrainMain` where ActivityId=?");
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000A57C8 File Offset: 0x000A39C8
		public static DirectTrainMain? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDirectTrainMainByActivityId.HandleId, ConfigDirectTrainMainByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DirectTrainMainByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DirectTrainMain?(DirectTrainMain.GetRootAsDirectTrainMain(configBuffer));
				}
			}
			ConfigDirectTrainMainByActivityId.LogPair.Clear();
			ConfigDirectTrainMainByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigDirectTrainMainByActivityId.HandleId, 1, p0ActivityId, ConfigDirectTrainMainByActivityId.LogPair) || ConfigCommon.Step(ConfigDirectTrainMainByActivityId.HandleId, true, ConfigDirectTrainMainByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDirectTrainMainByActivityId.HandleId, ConfigDirectTrainMainByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDirectTrainMainByActivityId.HandleId, 0, ConfigDirectTrainMainByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDirectTrainMainByActivityId.HandleId, ConfigDirectTrainMainByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DirectTrainMain rootAsDirectTrainMain = DirectTrainMain.GetRootAsDirectTrainMain(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DirectTrainMainByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDirectTrainMainByActivityId.HandleId, ConfigDirectTrainMainByActivityId.LogPair);
			return new DirectTrainMain?(rootAsDirectTrainMain);
		}

		// Token: 0x04000ECB RID: 3787
		private const string DB = "db_directtrain.db";

		// Token: 0x04000ECC RID: 3788
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000ECD RID: 3789
		private const string TABLE = "DirectTrainMain";

		// Token: 0x04000ECE RID: 3790
		private const string COMMAND = "select BinData from `DirectTrainMain` where ActivityId=?";

		// Token: 0x04000ECF RID: 3791
		private const string KEY_PREFIX = "DirectTrainMainByActivityId";

		// Token: 0x04000ED0 RID: 3792
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ED1 RID: 3793
		private static int HandleId;
	}
}
