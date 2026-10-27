using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C8 RID: 968
	public class ConfigGuQinActivityTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016B7 RID: 5815 RVA: 0x000D9EB4 File Offset: 0x000D80B4
		static ConfigGuQinActivityTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuQinActivityTaskById.CreateStaticDefaultValue), new Action(ConfigGuQinActivityTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x000D9ED4 File Offset: 0x000D80D4
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

		// Token: 0x060016B9 RID: 5817 RVA: 0x000D9F53 File Offset: 0x000D8153
		public static void ResetStaticDefaultValue()
		{
			ConfigGuQinActivityTaskById.LogPair = null;
			ConfigGuQinActivityTaskById.HandleId = 0;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x000D9F61 File Offset: 0x000D8161
		public static void Init()
		{
			ConfigGuQinActivityTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigGuQinActivityTaskById.HandleId, "db_guqinactivity.db", "select BinData from `GuQinActivityTask` where Id=?");
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x000D9F7C File Offset: 0x000D817C
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

		// Token: 0x04001A5C RID: 6748
		private const string DB = "db_guqinactivity.db";

		// Token: 0x04001A5D RID: 6749
		private const string FILE = "q.清宵弹琴活动.xlsx";

		// Token: 0x04001A5E RID: 6750
		private const string TABLE = "GuQinActivityTask";

		// Token: 0x04001A5F RID: 6751
		private const string COMMAND = "select BinData from `GuQinActivityTask` where Id=?";

		// Token: 0x04001A60 RID: 6752
		private const string KEY_PREFIX = "GuQinActivityTaskById";

		// Token: 0x04001A61 RID: 6753
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A62 RID: 6754
		private static int HandleId;
	}
}
