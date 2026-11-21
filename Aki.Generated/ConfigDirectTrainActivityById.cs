using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021D RID: 541
	public class ConfigDirectTrainActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CB1 RID: 3249 RVA: 0x000A4F47 File Offset: 0x000A3147
		static ConfigDirectTrainActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainActivityById.CreateStaticDefaultValue), new Action(ConfigDirectTrainActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000A4F68 File Offset: 0x000A3168
		public static void CreateStaticDefaultValue()
		{
			ConfigDirectTrainActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDirectTrainActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_directtrain.db"),
				new ValueTuple<string, object>("文件", "j.剧情直通车活动.xlsx"),
				new ValueTuple<string, object>("表名", "DirectTrainActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `DirectTrainActivity` where Id=?")
			});
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000A4FE7 File Offset: 0x000A31E7
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainActivityById.LogPair = null;
			ConfigDirectTrainActivityById.HandleId = 0;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000A4FF5 File Offset: 0x000A31F5
		public static void Init()
		{
			ConfigDirectTrainActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainActivityById.HandleId, "db_directtrain.db", "select BinData from `DirectTrainActivity` where Id=?");
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000A5010 File Offset: 0x000A3210
		public static DirectTrainActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDirectTrainActivityById.HandleId, ConfigDirectTrainActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DirectTrainActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DirectTrainActivity?(DirectTrainActivity.GetRootAsDirectTrainActivity(configBuffer));
				}
			}
			ConfigDirectTrainActivityById.LogPair.Clear();
			ConfigDirectTrainActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDirectTrainActivityById.HandleId, 1, p0Id, ConfigDirectTrainActivityById.LogPair) || ConfigCommon.Step(ConfigDirectTrainActivityById.HandleId, true, ConfigDirectTrainActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDirectTrainActivityById.HandleId, ConfigDirectTrainActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDirectTrainActivityById.HandleId, 0, ConfigDirectTrainActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDirectTrainActivityById.HandleId, ConfigDirectTrainActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DirectTrainActivity rootAsDirectTrainActivity = DirectTrainActivity.GetRootAsDirectTrainActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DirectTrainActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDirectTrainActivityById.HandleId, ConfigDirectTrainActivityById.LogPair);
			return new DirectTrainActivity?(rootAsDirectTrainActivity);
		}

		// Token: 0x04000EAF RID: 3759
		private const string DB = "db_directtrain.db";

		// Token: 0x04000EB0 RID: 3760
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000EB1 RID: 3761
		private const string TABLE = "DirectTrainActivity";

		// Token: 0x04000EB2 RID: 3762
		private const string COMMAND = "select BinData from `DirectTrainActivity` where Id=?";

		// Token: 0x04000EB3 RID: 3763
		private const string KEY_PREFIX = "DirectTrainActivityById";

		// Token: 0x04000EB4 RID: 3764
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EB5 RID: 3765
		private static int HandleId;
	}
}
