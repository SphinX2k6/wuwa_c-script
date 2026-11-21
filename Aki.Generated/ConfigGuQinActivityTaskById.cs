using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DE RID: 990
	public class ConfigGuQinActivityTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600173B RID: 5947 RVA: 0x000E0608 File Offset: 0x000DE808
		static ConfigGuQinActivityTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuQinActivityTaskById.CreateStaticDefaultValue), new Action(ConfigGuQinActivityTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x000E0628 File Offset: 0x000DE828
		public static void CreateStaticDefaultValue()
		{
			ConfigGuQinActivityTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuQinActivityTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guqinactivity.db"),
				new ValueTuple<string, object>("文件", "q.清宵弹琴活动.xlsx"),
				new ValueTuple<string, object>("表名", "GuQinActivityTask"),
				new ValueTuple<string, object>("语句", "select BinData from `GuQinActivityTask` where Id=?")
			});
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x000E06A7 File Offset: 0x000DE8A7
		public static void ResetStaticDefaultValue()
		{
			ConfigGuQinActivityTaskById.LogPair = null;
			ConfigGuQinActivityTaskById.HandleId = 0;
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x000E06B5 File Offset: 0x000DE8B5
		public static void Init()
		{
			ConfigGuQinActivityTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigGuQinActivityTaskById.HandleId, "db_guqinactivity.db", "select BinData from `GuQinActivityTask` where Id=?");
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x000E06D0 File Offset: 0x000DE8D0
		public static GuQinActivityTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuQinActivityTaskById.HandleId, ConfigGuQinActivityTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuQinActivityTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuQinActivityTask?(GuQinActivityTask.GetRootAsGuQinActivityTask(configBuffer));
				}
			}
			ConfigGuQinActivityTaskById.LogPair.Clear();
			ConfigGuQinActivityTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuQinActivityTaskById.HandleId, 1, p0Id, ConfigGuQinActivityTaskById.LogPair) || ConfigCommon.Step(ConfigGuQinActivityTaskById.HandleId, true, ConfigGuQinActivityTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuQinActivityTaskById.HandleId, ConfigGuQinActivityTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuQinActivityTaskById.HandleId, 0, ConfigGuQinActivityTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuQinActivityTaskById.HandleId, ConfigGuQinActivityTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuQinActivityTask rootAsGuQinActivityTask = GuQinActivityTask.GetRootAsGuQinActivityTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuQinActivityTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuQinActivityTaskById.HandleId, ConfigGuQinActivityTaskById.LogPair);
			return new GuQinActivityTask?(rootAsGuQinActivityTask);
		}

		// Token: 0x04001AF6 RID: 6902
		private const string DB = "db_guqinactivity.db";

		// Token: 0x04001AF7 RID: 6903
		private const string FILE = "q.清宵弹琴活动.xlsx";

		// Token: 0x04001AF8 RID: 6904
		private const string TABLE = "GuQinActivityTask";

		// Token: 0x04001AF9 RID: 6905
		private const string COMMAND = "select BinData from `GuQinActivityTask` where Id=?";

		// Token: 0x04001AFA RID: 6906
		private const string KEY_PREFIX = "GuQinActivityTaskById";

		// Token: 0x04001AFB RID: 6907
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AFC RID: 6908
		private static int HandleId;
	}
}
