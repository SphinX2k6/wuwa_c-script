using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BA RID: 442
	public class ConfigCoopTaskConfigByID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A5F RID: 2655 RVA: 0x00097BA7 File Offset: 0x00095DA7
		static ConfigCoopTaskConfigByID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopTaskConfigByID.CreateStaticDefaultValue), new Action(ConfigCoopTaskConfigByID.ResetStaticDefaultValue));
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00097BC8 File Offset: 0x00095DC8
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

		// Token: 0x06000A61 RID: 2657 RVA: 0x00097C47 File Offset: 0x00095E47
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopTaskConfigByID.LogPair = null;
			ConfigCoopTaskConfigByID.HandleId = 0;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00097C55 File Offset: 0x00095E55
		public static void Init()
		{
			ConfigCoopTaskConfigByID.HandleId = ConfigCommon.InitDataStatement(ConfigCoopTaskConfigByID.HandleId, "db_cooprolelevel.db", "select BinData from `CoopTaskConfig` where Id=?");
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00097C70 File Offset: 0x00095E70
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

		// Token: 0x04000BFA RID: 3066
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000BFB RID: 3067
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000BFC RID: 3068
		private const string TABLE = "CoopTaskConfig";

		// Token: 0x04000BFD RID: 3069
		private const string COMMAND = "select BinData from `CoopTaskConfig` where Id=?";

		// Token: 0x04000BFE RID: 3070
		private const string KEY_PREFIX = "CoopTaskConfigByID";

		// Token: 0x04000BFF RID: 3071
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C00 RID: 3072
		private static int HandleId;
	}
}
