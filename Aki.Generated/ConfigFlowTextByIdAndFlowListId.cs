using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033A RID: 826
	public class ConfigFlowTextByIdAndFlowListId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001361 RID: 4961 RVA: 0x000C6D58 File Offset: 0x000C4F58
		static ConfigFlowTextByIdAndFlowListId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlowTextByIdAndFlowListId.CreateStaticDefaultValue), new Action(ConfigFlowTextByIdAndFlowListId.ResetStaticDefaultValue));
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x000C6D78 File Offset: 0x000C4F78
		public static void CreateStaticDefaultValue()
		{
			ConfigFlowTextByIdAndFlowListId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlowTextByIdAndFlowListId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flow_text.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/j.剧情/Text_剧情*"),
				new ValueTuple<string, object>("表名", "FlowText"),
				new ValueTuple<string, object>("语句", "select BinData from `FlowText` where Id=? AND FlowListId=?")
			});
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x000C6DF7 File Offset: 0x000C4FF7
		public static void ResetStaticDefaultValue()
		{
			ConfigFlowTextByIdAndFlowListId.LogPair = null;
			ConfigFlowTextByIdAndFlowListId.HandleId = 0;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000C6E05 File Offset: 0x000C5005
		public static void Init()
		{
			ConfigFlowTextByIdAndFlowListId.HandleId = ConfigCommon.InitDataStatement(ConfigFlowTextByIdAndFlowListId.HandleId, "db_flow_text.db", "select BinData from `FlowText` where Id=? AND FlowListId=?");
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x000C6E20 File Offset: 0x000C5020
		public static FlowText? GetConfig(int p0Id, string p1FlowListId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlowTextByIdAndFlowListId.HandleId, ConfigFlowTextByIdAndFlowListId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FlowTextByIdAndFlowListId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1FlowListId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlowText?(FlowText.GetRootAsFlowText(configBuffer));
				}
			}
			ConfigFlowTextByIdAndFlowListId.LogPair.Clear();
			ConfigFlowTextByIdAndFlowListId.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigFlowTextByIdAndFlowListId.LogPair.Add(new ValueTuple<string, object>("FlowListId", p1FlowListId));
			if (!ConfigCommon.BindInt(ConfigFlowTextByIdAndFlowListId.HandleId, 1, p0Id, ConfigFlowTextByIdAndFlowListId.LogPair) || !ConfigCommon.BindString(ConfigFlowTextByIdAndFlowListId.HandleId, 2, p1FlowListId, ConfigFlowTextByIdAndFlowListId.LogPair) || ConfigCommon.Step(ConfigFlowTextByIdAndFlowListId.HandleId, true, ConfigFlowTextByIdAndFlowListId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlowTextByIdAndFlowListId.HandleId, ConfigFlowTextByIdAndFlowListId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlowTextByIdAndFlowListId.HandleId, 0, ConfigFlowTextByIdAndFlowListId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlowTextByIdAndFlowListId.HandleId, ConfigFlowTextByIdAndFlowListId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlowText rootAsFlowText = FlowText.GetRootAsFlowText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FlowTextByIdAndFlowListId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1FlowListId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlowTextByIdAndFlowListId.HandleId, ConfigFlowTextByIdAndFlowListId.LogPair);
			return new FlowText?(rootAsFlowText);
		}

		// Token: 0x0400167A RID: 5754
		private const string DB = "db_flow_text.db";

		// Token: 0x0400167B RID: 5755
		private const string FILE = "k.可视化编辑/j.剧情/Text_剧情*";

		// Token: 0x0400167C RID: 5756
		private const string TABLE = "FlowText";

		// Token: 0x0400167D RID: 5757
		private const string COMMAND = "select BinData from `FlowText` where Id=? AND FlowListId=?";

		// Token: 0x0400167E RID: 5758
		private const string KEY_PREFIX = "FlowTextByIdAndFlowListId";

		// Token: 0x0400167F RID: 5759
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001680 RID: 5760
		private static int HandleId;
	}
}
