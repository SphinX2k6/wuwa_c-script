using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034E RID: 846
	public class ConfigFlowTemplateDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013D9 RID: 5081 RVA: 0x000CD01D File Offset: 0x000CB21D
		static ConfigFlowTemplateDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlowTemplateDataById.CreateStaticDefaultValue), new Action(ConfigFlowTemplateDataById.ResetStaticDefaultValue));
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x000CD03C File Offset: 0x000CB23C
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

		// Token: 0x060013DB RID: 5083 RVA: 0x000CD0BB File Offset: 0x000CB2BB
		public static void ResetStaticDefaultValue()
		{
			ConfigFlowTemplateDataById.LogPair = null;
			ConfigFlowTemplateDataById.HandleId = 0;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x000CD0C9 File Offset: 0x000CB2C9
		public static void Init()
		{
			ConfigFlowTemplateDataById.HandleId = ConfigCommon.InitDataStatement(ConfigFlowTemplateDataById.HandleId, "db_flowtemplatedata.db", "select BinData from `FlowTemplateData` where Id=?");
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x000CD0E4 File Offset: 0x000CB2E4
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

		// Token: 0x04001706 RID: 5894
		private const string DB = "db_flowtemplatedata.db";

		// Token: 0x04001707 RID: 5895
		private const string FILE = "UniverseEditor/CameraTemplate/FlowTemplateCamera.csv";

		// Token: 0x04001708 RID: 5896
		private const string TABLE = "FlowTemplateData";

		// Token: 0x04001709 RID: 5897
		private const string COMMAND = "select BinData from `FlowTemplateData` where Id=?";

		// Token: 0x0400170A RID: 5898
		private const string KEY_PREFIX = "FlowTemplateDataById";

		// Token: 0x0400170B RID: 5899
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400170C RID: 5900
		private static int HandleId;
	}
}
