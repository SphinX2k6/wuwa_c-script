using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020B RID: 523
	public class ConfigDirectTrainActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C45 RID: 3141 RVA: 0x0009F00F File Offset: 0x0009D20F
		static ConfigDirectTrainActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainActivityById.CreateStaticDefaultValue), new Action(ConfigDirectTrainActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0009F030 File Offset: 0x0009D230
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

		// Token: 0x06000C47 RID: 3143 RVA: 0x0009F0AF File Offset: 0x0009D2AF
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainActivityById.LogPair = null;
			ConfigDirectTrainActivityById.HandleId = 0;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0009F0BD File Offset: 0x0009D2BD
		public static void Init()
		{
			ConfigDirectTrainActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainActivityById.HandleId, "db_directtrain.db", "select BinData from `DirectTrainActivity` where Id=?");
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0009F0D8 File Offset: 0x0009D2D8
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

		// Token: 0x04000E31 RID: 3633
		private const string DB = "db_directtrain.db";

		// Token: 0x04000E32 RID: 3634
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000E33 RID: 3635
		private const string TABLE = "DirectTrainActivity";

		// Token: 0x04000E34 RID: 3636
		private const string COMMAND = "select BinData from `DirectTrainActivity` where Id=?";

		// Token: 0x04000E35 RID: 3637
		private const string KEY_PREFIX = "DirectTrainActivityById";

		// Token: 0x04000E36 RID: 3638
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E37 RID: 3639
		private static int HandleId;
	}
}
