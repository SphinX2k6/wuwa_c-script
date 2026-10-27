using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C7 RID: 967
	public class ConfigGuQinActivityParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016B1 RID: 5809 RVA: 0x000D9C6C File Offset: 0x000D7E6C
		static ConfigGuQinActivityParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuQinActivityParamById.CreateStaticDefaultValue), new Action(ConfigGuQinActivityParamById.ResetStaticDefaultValue));
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x000D9C8C File Offset: 0x000D7E8C
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

		// Token: 0x060016B3 RID: 5811 RVA: 0x000D9D0B File Offset: 0x000D7F0B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuQinActivityParamById.LogPair = null;
			ConfigGuQinActivityParamById.HandleId = 0;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000D9D19 File Offset: 0x000D7F19
		public static void Init()
		{
			ConfigGuQinActivityParamById.HandleId = ConfigCommon.InitDataStatement(ConfigGuQinActivityParamById.HandleId, "db_guqinactivity.db", "select BinData from `GuQinActivityParam` where Id=?");
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000D9D34 File Offset: 0x000D7F34
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

		// Token: 0x04001A55 RID: 6741
		private const string DB = "db_guqinactivity.db";

		// Token: 0x04001A56 RID: 6742
		private const string FILE = "q.清宵弹琴活动.xlsx";

		// Token: 0x04001A57 RID: 6743
		private const string TABLE = "GuQinActivityParam";

		// Token: 0x04001A58 RID: 6744
		private const string COMMAND = "select BinData from `GuQinActivityParam` where Id=?";

		// Token: 0x04001A59 RID: 6745
		private const string KEY_PREFIX = "GuQinActivityParamById";

		// Token: 0x04001A5A RID: 6746
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A5B RID: 6747
		private static int HandleId;
	}
}
