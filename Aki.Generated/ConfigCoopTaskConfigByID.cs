using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A8 RID: 424
	public class ConfigCoopTaskConfigByID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009F3 RID: 2547 RVA: 0x00091C6F File Offset: 0x0008FE6F
		static ConfigCoopTaskConfigByID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopTaskConfigByID.CreateStaticDefaultValue), new Action(ConfigCoopTaskConfigByID.ResetStaticDefaultValue));
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00091C90 File Offset: 0x0008FE90
		public static void CreateStaticDefaultValue()
		{
			ConfigCoopTaskConfigByID.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCoopTaskConfigByID.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cooprolelevel.db"),
				new ValueTuple<string, object>("文件", "c.3.2coop活动.xlsx"),
				new ValueTuple<string, object>("表名", "CoopTaskConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `CoopTaskConfig` where Id=?")
			});
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00091D0F File Offset: 0x0008FF0F
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopTaskConfigByID.LogPair = null;
			ConfigCoopTaskConfigByID.HandleId = 0;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00091D1D File Offset: 0x0008FF1D
		public static void Init()
		{
			ConfigCoopTaskConfigByID.HandleId = ConfigCommon.InitDataStatement(ConfigCoopTaskConfigByID.HandleId, "db_cooprolelevel.db", "select BinData from `CoopTaskConfig` where Id=?");
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00091D38 File Offset: 0x0008FF38
		public static CoopTaskConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCoopTaskConfigByID.HandleId, ConfigCoopTaskConfigByID.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CoopTaskConfigByID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CoopTaskConfig?(CoopTaskConfig.GetRootAsCoopTaskConfig(configBuffer));
				}
			}
			ConfigCoopTaskConfigByID.LogPair.Clear();
			ConfigCoopTaskConfigByID.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCoopTaskConfigByID.HandleId, 1, p0Id, ConfigCoopTaskConfigByID.LogPair) || ConfigCommon.Step(ConfigCoopTaskConfigByID.HandleId, true, ConfigCoopTaskConfigByID.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCoopTaskConfigByID.HandleId, ConfigCoopTaskConfigByID.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCoopTaskConfigByID.HandleId, 0, ConfigCoopTaskConfigByID.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCoopTaskConfigByID.HandleId, ConfigCoopTaskConfigByID.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CoopTaskConfig rootAsCoopTaskConfig = CoopTaskConfig.GetRootAsCoopTaskConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CoopTaskConfigByID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCoopTaskConfigByID.HandleId, ConfigCoopTaskConfigByID.LogPair);
			return new CoopTaskConfig?(rootAsCoopTaskConfig);
		}

		// Token: 0x04000B7C RID: 2940
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000B7D RID: 2941
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000B7E RID: 2942
		private const string TABLE = "CoopTaskConfig";

		// Token: 0x04000B7F RID: 2943
		private const string COMMAND = "select BinData from `CoopTaskConfig` where Id=?";

		// Token: 0x04000B80 RID: 2944
		private const string KEY_PREFIX = "CoopTaskConfigByID";

		// Token: 0x04000B81 RID: 2945
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B82 RID: 2946
		private static int HandleId;
	}
}
