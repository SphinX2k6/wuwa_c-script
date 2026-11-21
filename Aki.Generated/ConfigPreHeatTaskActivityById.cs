using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000774 RID: 1908
	public class ConfigPreHeatTaskActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CC9 RID: 11465 RVA: 0x00159F2C File Offset: 0x0015812C
		static ConfigPreHeatTaskActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreHeatTaskActivityById.CreateStaticDefaultValue), new Action(ConfigPreHeatTaskActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x00159F4C File Offset: 0x0015814C
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

		// Token: 0x06002CCB RID: 11467 RVA: 0x00159FCB File Offset: 0x001581CB
		public static void ResetStaticDefaultValue()
		{
			ConfigPreHeatTaskActivityById.LogPair = null;
			ConfigPreHeatTaskActivityById.HandleId = 0;
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x00159FD9 File Offset: 0x001581D9
		public static void Init()
		{
			ConfigPreHeatTaskActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigPreHeatTaskActivityById.HandleId, "db_preheattaskactivity.db", "select BinData from `PreHeatTaskActivity` where Id=?");
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x00159FF4 File Offset: 0x001581F4
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

		// Token: 0x04003412 RID: 13330
		private const string DB = "db_preheattaskactivity.db";

		// Token: 0x04003413 RID: 13331
		private const string FILE = "y.预热活动.xlsx";

		// Token: 0x04003414 RID: 13332
		private const string TABLE = "PreHeatTaskActivity";

		// Token: 0x04003415 RID: 13333
		private const string COMMAND = "select BinData from `PreHeatTaskActivity` where Id=?";

		// Token: 0x04003416 RID: 13334
		private const string KEY_PREFIX = "PreHeatTaskActivityById";

		// Token: 0x04003417 RID: 13335
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003418 RID: 13336
		private static int HandleId;
	}
}
