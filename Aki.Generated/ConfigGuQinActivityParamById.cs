using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DD RID: 989
	public class ConfigGuQinActivityParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x000E03C0 File Offset: 0x000DE5C0
		static ConfigGuQinActivityParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuQinActivityParamById.CreateStaticDefaultValue), new Action(ConfigGuQinActivityParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x000E03E0 File Offset: 0x000DE5E0
		public static void CreateStaticDefaultValue()
		{
			ConfigGuQinActivityParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuQinActivityParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guqinactivity.db"),
				new ValueTuple<string, object>("文件", "q.清宵弹琴活动.xlsx"),
				new ValueTuple<string, object>("表名", "GuQinActivityParam"),
				new ValueTuple<string, object>("语句", "select BinData from `GuQinActivityParam` where Id=?")
			});
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x000E045F File Offset: 0x000DE65F
		public static void ResetStaticDefaultValue()
		{
			ConfigGuQinActivityParamById.LogPair = null;
			ConfigGuQinActivityParamById.HandleId = 0;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x000E046D File Offset: 0x000DE66D
		public static void Init()
		{
			ConfigGuQinActivityParamById.HandleId = ConfigCommon.InitDataStatement(ConfigGuQinActivityParamById.HandleId, "db_guqinactivity.db", "select BinData from `GuQinActivityParam` where Id=?");
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000E0488 File Offset: 0x000DE688
		public static GuQinActivityParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuQinActivityParamById.HandleId, ConfigGuQinActivityParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuQinActivityParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuQinActivityParam?(GuQinActivityParam.GetRootAsGuQinActivityParam(configBuffer));
				}
			}
			ConfigGuQinActivityParamById.LogPair.Clear();
			ConfigGuQinActivityParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuQinActivityParamById.HandleId, 1, p0Id, ConfigGuQinActivityParamById.LogPair) || ConfigCommon.Step(ConfigGuQinActivityParamById.HandleId, true, ConfigGuQinActivityParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuQinActivityParamById.HandleId, ConfigGuQinActivityParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuQinActivityParamById.HandleId, 0, ConfigGuQinActivityParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuQinActivityParamById.HandleId, ConfigGuQinActivityParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuQinActivityParam rootAsGuQinActivityParam = GuQinActivityParam.GetRootAsGuQinActivityParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuQinActivityParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuQinActivityParamById.HandleId, ConfigGuQinActivityParamById.LogPair);
			return new GuQinActivityParam?(rootAsGuQinActivityParam);
		}

		// Token: 0x04001AEF RID: 6895
		private const string DB = "db_guqinactivity.db";

		// Token: 0x04001AF0 RID: 6896
		private const string FILE = "q.清宵弹琴活动.xlsx";

		// Token: 0x04001AF1 RID: 6897
		private const string TABLE = "GuQinActivityParam";

		// Token: 0x04001AF2 RID: 6898
		private const string COMMAND = "select BinData from `GuQinActivityParam` where Id=?";

		// Token: 0x04001AF3 RID: 6899
		private const string KEY_PREFIX = "GuQinActivityParamById";

		// Token: 0x04001AF4 RID: 6900
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AF5 RID: 6901
		private static int HandleId;
	}
}
