using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020F RID: 527
	public class ConfigDirectTrainMainByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C5D RID: 3165 RVA: 0x0009F7C7 File Offset: 0x0009D9C7
		static ConfigDirectTrainMainByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainMainByActivityId.CreateStaticDefaultValue), new Action(ConfigDirectTrainMainByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0009F7E8 File Offset: 0x0009D9E8
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

		// Token: 0x06000C5F RID: 3167 RVA: 0x0009F867 File Offset: 0x0009DA67
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainMainByActivityId.LogPair = null;
			ConfigDirectTrainMainByActivityId.HandleId = 0;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0009F875 File Offset: 0x0009DA75
		public static void Init()
		{
			ConfigDirectTrainMainByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainMainByActivityId.HandleId, "db_directtrain.db", "select BinData from `DirectTrainMain` where ActivityId=?");
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0009F890 File Offset: 0x0009DA90
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

		// Token: 0x04000E4D RID: 3661
		private const string DB = "db_directtrain.db";

		// Token: 0x04000E4E RID: 3662
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000E4F RID: 3663
		private const string TABLE = "DirectTrainMain";

		// Token: 0x04000E50 RID: 3664
		private const string COMMAND = "select BinData from `DirectTrainMain` where ActivityId=?";

		// Token: 0x04000E51 RID: 3665
		private const string KEY_PREFIX = "DirectTrainMainByActivityId";

		// Token: 0x04000E52 RID: 3666
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E53 RID: 3667
		private static int HandleId;
	}
}
