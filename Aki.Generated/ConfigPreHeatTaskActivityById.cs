using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075C RID: 1884
	public class ConfigPreHeatTaskActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C39 RID: 11321 RVA: 0x001534B0 File Offset: 0x001516B0
		static ConfigPreHeatTaskActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreHeatTaskActivityById.CreateStaticDefaultValue), new Action(ConfigPreHeatTaskActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x001534D0 File Offset: 0x001516D0
		public static void CreateStaticDefaultValue()
		{
			ConfigPreHeatTaskActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreHeatTaskActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_preheattaskactivity.db"),
				new ValueTuple<string, object>("文件", "y.预热活动.xlsx"),
				new ValueTuple<string, object>("表名", "PreHeatTaskActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PreHeatTaskActivity` where Id=?")
			});
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x0015354F File Offset: 0x0015174F
		public static void ResetStaticDefaultValue()
		{
			ConfigPreHeatTaskActivityById.LogPair = null;
			ConfigPreHeatTaskActivityById.HandleId = 0;
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x0015355D File Offset: 0x0015175D
		public static void Init()
		{
			ConfigPreHeatTaskActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigPreHeatTaskActivityById.HandleId, "db_preheattaskactivity.db", "select BinData from `PreHeatTaskActivity` where Id=?");
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00153578 File Offset: 0x00151778
		public static PreHeatTaskActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreHeatTaskActivityById.HandleId, ConfigPreHeatTaskActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreHeatTaskActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PreHeatTaskActivity?(PreHeatTaskActivity.GetRootAsPreHeatTaskActivity(configBuffer));
				}
			}
			ConfigPreHeatTaskActivityById.LogPair.Clear();
			ConfigPreHeatTaskActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPreHeatTaskActivityById.HandleId, 1, p0Id, ConfigPreHeatTaskActivityById.LogPair) || ConfigCommon.Step(ConfigPreHeatTaskActivityById.HandleId, true, ConfigPreHeatTaskActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPreHeatTaskActivityById.HandleId, ConfigPreHeatTaskActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreHeatTaskActivityById.HandleId, 0, ConfigPreHeatTaskActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPreHeatTaskActivityById.HandleId, ConfigPreHeatTaskActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PreHeatTaskActivity rootAsPreHeatTaskActivity = PreHeatTaskActivity.GetRootAsPreHeatTaskActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreHeatTaskActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPreHeatTaskActivityById.HandleId, ConfigPreHeatTaskActivityById.LogPair);
			return new PreHeatTaskActivity?(rootAsPreHeatTaskActivity);
		}

		// Token: 0x0400336A RID: 13162
		private const string DB = "db_preheattaskactivity.db";

		// Token: 0x0400336B RID: 13163
		private const string FILE = "y.预热活动.xlsx";

		// Token: 0x0400336C RID: 13164
		private const string TABLE = "PreHeatTaskActivity";

		// Token: 0x0400336D RID: 13165
		private const string COMMAND = "select BinData from `PreHeatTaskActivity` where Id=?";

		// Token: 0x0400336E RID: 13166
		private const string KEY_PREFIX = "PreHeatTaskActivityById";

		// Token: 0x0400336F RID: 13167
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003370 RID: 13168
		private static int HandleId;
	}
}
