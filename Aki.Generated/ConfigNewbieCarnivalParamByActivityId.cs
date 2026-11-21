using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F9 RID: 1529
	public class ConfigNewbieCarnivalParamByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023E5 RID: 9189 RVA: 0x00127F69 File Offset: 0x00126169
		static ConfigNewbieCarnivalParamByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCarnivalParamByActivityId.CreateStaticDefaultValue), new Action(ConfigNewbieCarnivalParamByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00127F88 File Offset: 0x00126188
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCarnivalParamByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCarnivalParamByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecarnival.db"),
				new ValueTuple<string, object>("文件", "x.新手嘉年华.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCarnivalParam"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCarnivalParam` where ActivityId=?")
			});
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00128007 File Offset: 0x00126207
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCarnivalParamByActivityId.LogPair = null;
			ConfigNewbieCarnivalParamByActivityId.HandleId = 0;
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00128015 File Offset: 0x00126215
		public static void Init()
		{
			ConfigNewbieCarnivalParamByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCarnivalParamByActivityId.HandleId, "db_newbiecarnival.db", "select BinData from `NewbieCarnivalParam` where ActivityId=?");
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00128030 File Offset: 0x00126230
		public static NewbieCarnivalParam? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCarnivalParamByActivityId.HandleId, ConfigNewbieCarnivalParamByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalParamByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieCarnivalParam?(NewbieCarnivalParam.GetRootAsNewbieCarnivalParam(configBuffer));
				}
			}
			ConfigNewbieCarnivalParamByActivityId.LogPair.Clear();
			ConfigNewbieCarnivalParamByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigNewbieCarnivalParamByActivityId.HandleId, 1, p0ActivityId, ConfigNewbieCarnivalParamByActivityId.LogPair) || ConfigCommon.Step(ConfigNewbieCarnivalParamByActivityId.HandleId, true, ConfigNewbieCarnivalParamByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalParamByActivityId.HandleId, ConfigNewbieCarnivalParamByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCarnivalParamByActivityId.HandleId, 0, ConfigNewbieCarnivalParamByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalParamByActivityId.HandleId, ConfigNewbieCarnivalParamByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieCarnivalParam rootAsNewbieCarnivalParam = NewbieCarnivalParam.GetRootAsNewbieCarnivalParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalParamByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieCarnivalParamByActivityId.HandleId, ConfigNewbieCarnivalParamByActivityId.LogPair);
			return new NewbieCarnivalParam?(rootAsNewbieCarnivalParam);
		}

		// Token: 0x040029B5 RID: 10677
		private const string DB = "db_newbiecarnival.db";

		// Token: 0x040029B6 RID: 10678
		private const string FILE = "x.新手嘉年华.xlsx";

		// Token: 0x040029B7 RID: 10679
		private const string TABLE = "NewbieCarnivalParam";

		// Token: 0x040029B8 RID: 10680
		private const string COMMAND = "select BinData from `NewbieCarnivalParam` where ActivityId=?";

		// Token: 0x040029B9 RID: 10681
		private const string KEY_PREFIX = "NewbieCarnivalParamByActivityId";

		// Token: 0x040029BA RID: 10682
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029BB RID: 10683
		private static int HandleId;
	}
}
