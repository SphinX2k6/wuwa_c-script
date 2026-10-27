using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E1 RID: 1505
	public class ConfigNewbieCarnivalParamByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002355 RID: 9045 RVA: 0x001214ED File Offset: 0x0011F6ED
		static ConfigNewbieCarnivalParamByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCarnivalParamByActivityId.CreateStaticDefaultValue), new Action(ConfigNewbieCarnivalParamByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x0012150C File Offset: 0x0011F70C
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

		// Token: 0x06002357 RID: 9047 RVA: 0x0012158B File Offset: 0x0011F78B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCarnivalParamByActivityId.LogPair = null;
			ConfigNewbieCarnivalParamByActivityId.HandleId = 0;
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00121599 File Offset: 0x0011F799
		public static void Init()
		{
			ConfigNewbieCarnivalParamByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCarnivalParamByActivityId.HandleId, "db_newbiecarnival.db", "select BinData from `NewbieCarnivalParam` where ActivityId=?");
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x001215B4 File Offset: 0x0011F7B4
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

		// Token: 0x0400290D RID: 10509
		private const string DB = "db_newbiecarnival.db";

		// Token: 0x0400290E RID: 10510
		private const string FILE = "x.新手嘉年华.xlsx";

		// Token: 0x0400290F RID: 10511
		private const string TABLE = "NewbieCarnivalParam";

		// Token: 0x04002910 RID: 10512
		private const string COMMAND = "select BinData from `NewbieCarnivalParam` where ActivityId=?";

		// Token: 0x04002911 RID: 10513
		private const string KEY_PREFIX = "NewbieCarnivalParamByActivityId";

		// Token: 0x04002912 RID: 10514
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002913 RID: 10515
		private static int HandleId;
	}
}
