using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000339 RID: 825
	public class ConfigFlowTemplateDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x000C6B11 File Offset: 0x000C4D11
		static ConfigFlowTemplateDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlowTemplateDataById.CreateStaticDefaultValue), new Action(ConfigFlowTemplateDataById.ResetStaticDefaultValue));
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000C6B30 File Offset: 0x000C4D30
		public static void CreateStaticDefaultValue()
		{
			ConfigFlowTemplateDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlowTemplateDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flowtemplatedata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/CameraTemplate/FlowTemplateCamera.csv"),
				new ValueTuple<string, object>("表名", "FlowTemplateData"),
				new ValueTuple<string, object>("语句", "select BinData from `FlowTemplateData` where Id=?")
			});
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000C6BAF File Offset: 0x000C4DAF
		public static void ResetStaticDefaultValue()
		{
			ConfigFlowTemplateDataById.LogPair = null;
			ConfigFlowTemplateDataById.HandleId = 0;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x000C6BBD File Offset: 0x000C4DBD
		public static void Init()
		{
			ConfigFlowTemplateDataById.HandleId = ConfigCommon.InitDataStatement(ConfigFlowTemplateDataById.HandleId, "db_flowtemplatedata.db", "select BinData from `FlowTemplateData` where Id=?");
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000C6BD8 File Offset: 0x000C4DD8
		public static FlowTemplateData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlowTemplateDataById.HandleId, ConfigFlowTemplateDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlowTemplateDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlowTemplateData?(FlowTemplateData.GetRootAsFlowTemplateData(configBuffer));
				}
			}
			ConfigFlowTemplateDataById.LogPair.Clear();
			ConfigFlowTemplateDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlowTemplateDataById.HandleId, 1, p0Id, ConfigFlowTemplateDataById.LogPair) || ConfigCommon.Step(ConfigFlowTemplateDataById.HandleId, true, ConfigFlowTemplateDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlowTemplateDataById.HandleId, ConfigFlowTemplateDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlowTemplateDataById.HandleId, 0, ConfigFlowTemplateDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlowTemplateDataById.HandleId, ConfigFlowTemplateDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlowTemplateData rootAsFlowTemplateData = FlowTemplateData.GetRootAsFlowTemplateData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlowTemplateDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlowTemplateDataById.HandleId, ConfigFlowTemplateDataById.LogPair);
			return new FlowTemplateData?(rootAsFlowTemplateData);
		}

		// Token: 0x04001673 RID: 5747
		private const string DB = "db_flowtemplatedata.db";

		// Token: 0x04001674 RID: 5748
		private const string FILE = "UniverseEditor/CameraTemplate/FlowTemplateCamera.csv";

		// Token: 0x04001675 RID: 5749
		private const string TABLE = "FlowTemplateData";

		// Token: 0x04001676 RID: 5750
		private const string COMMAND = "select BinData from `FlowTemplateData` where Id=?";

		// Token: 0x04001677 RID: 5751
		private const string KEY_PREFIX = "FlowTemplateDataById";

		// Token: 0x04001678 RID: 5752
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001679 RID: 5753
		private static int HandleId;
	}
}
