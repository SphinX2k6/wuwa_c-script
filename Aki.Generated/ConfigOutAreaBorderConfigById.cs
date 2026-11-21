using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064A RID: 1610
	public class ConfigOutAreaBorderConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025CC RID: 9676 RVA: 0x00132D58 File Offset: 0x00130F58
		static ConfigOutAreaBorderConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOutAreaBorderConfigById.CreateStaticDefaultValue), new Action(ConfigOutAreaBorderConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00132D78 File Offset: 0x00130F78
		public static void CreateStaticDefaultValue()
		{
			ConfigOutAreaBorderConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOutAreaBorderConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_outareaborderconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/q.区域出界效果/*.csv*"),
				new ValueTuple<string, object>("表名", "OutAreaBorderConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `OutAreaBorderConfig` where Id = ?")
			});
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00132DF7 File Offset: 0x00130FF7
		public static void ResetStaticDefaultValue()
		{
			ConfigOutAreaBorderConfigById.LogPair = null;
			ConfigOutAreaBorderConfigById.HandleId = 0;
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x00132E05 File Offset: 0x00131005
		public static void Init()
		{
			ConfigOutAreaBorderConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigOutAreaBorderConfigById.HandleId, "db_outareaborderconfig.db", "select BinData from `OutAreaBorderConfig` where Id = ?");
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00132E20 File Offset: 0x00131020
		public static OutAreaBorderConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOutAreaBorderConfigById.HandleId, ConfigOutAreaBorderConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OutAreaBorderConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new OutAreaBorderConfig?(OutAreaBorderConfig.GetRootAsOutAreaBorderConfig(configBuffer));
				}
			}
			ConfigOutAreaBorderConfigById.LogPair.Clear();
			ConfigOutAreaBorderConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOutAreaBorderConfigById.HandleId, 1, p0Id, ConfigOutAreaBorderConfigById.LogPair) || ConfigCommon.Step(ConfigOutAreaBorderConfigById.HandleId, true, ConfigOutAreaBorderConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOutAreaBorderConfigById.HandleId, ConfigOutAreaBorderConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOutAreaBorderConfigById.HandleId, 0, ConfigOutAreaBorderConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOutAreaBorderConfigById.HandleId, ConfigOutAreaBorderConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OutAreaBorderConfig rootAsOutAreaBorderConfig = OutAreaBorderConfig.GetRootAsOutAreaBorderConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OutAreaBorderConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOutAreaBorderConfigById.HandleId, ConfigOutAreaBorderConfigById.LogPair);
			return new OutAreaBorderConfig?(rootAsOutAreaBorderConfig);
		}

		// Token: 0x04002BEC RID: 11244
		private const string DB = "db_outareaborderconfig.db";

		// Token: 0x04002BED RID: 11245
		private const string FILE = "k.可视化编辑/c.Csv/q.区域出界效果/*.csv*";

		// Token: 0x04002BEE RID: 11246
		private const string TABLE = "OutAreaBorderConfig";

		// Token: 0x04002BEF RID: 11247
		private const string COMMAND = "select BinData from `OutAreaBorderConfig` where Id = ?";

		// Token: 0x04002BF0 RID: 11248
		private const string KEY_PREFIX = "OutAreaBorderConfigById";

		// Token: 0x04002BF1 RID: 11249
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BF2 RID: 11250
		private static int HandleId;
	}
}
