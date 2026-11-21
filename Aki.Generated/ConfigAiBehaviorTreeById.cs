using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008C RID: 140
	public class ConfigAiBehaviorTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000348 RID: 840 RVA: 0x0006F850 File Offset: 0x0006DA50
		static ConfigAiBehaviorTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiBehaviorTreeById.CreateStaticDefaultValue), new Action(ConfigAiBehaviorTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0006F870 File Offset: 0x0006DA70
		public static void CreateStaticDefaultValue()
		{
			ConfigAiBehaviorTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiBehaviorTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_aibehaviortree.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.AI行为树/*.csv*"),
				new ValueTuple<string, object>("表名", "AiBehaviorTree"),
				new ValueTuple<string, object>("语句", "select BinData from `AiBehaviorTree` where Id=?")
			});
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0006F8EF File Offset: 0x0006DAEF
		public static void ResetStaticDefaultValue()
		{
			ConfigAiBehaviorTreeById.LogPair = null;
			ConfigAiBehaviorTreeById.HandleId = 0;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0006F8FD File Offset: 0x0006DAFD
		public static void Init()
		{
			ConfigAiBehaviorTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigAiBehaviorTreeById.HandleId, "db_aibehaviortree.db", "select BinData from `AiBehaviorTree` where Id=?");
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0006F918 File Offset: 0x0006DB18
		public static AiBehaviorTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiBehaviorTreeById.HandleId, ConfigAiBehaviorTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBehaviorTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiBehaviorTree?(AiBehaviorTree.GetRootAsAiBehaviorTree(configBuffer));
				}
			}
			ConfigAiBehaviorTreeById.LogPair.Clear();
			ConfigAiBehaviorTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiBehaviorTreeById.HandleId, 1, p0Id, ConfigAiBehaviorTreeById.LogPair) || ConfigCommon.Step(ConfigAiBehaviorTreeById.HandleId, true, ConfigAiBehaviorTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiBehaviorTreeById.HandleId, ConfigAiBehaviorTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiBehaviorTreeById.HandleId, 0, ConfigAiBehaviorTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiBehaviorTreeById.HandleId, ConfigAiBehaviorTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiBehaviorTree rootAsAiBehaviorTree = AiBehaviorTree.GetRootAsAiBehaviorTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBehaviorTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiBehaviorTreeById.HandleId, ConfigAiBehaviorTreeById.LogPair);
			return new AiBehaviorTree?(rootAsAiBehaviorTree);
		}

		// Token: 0x040003B8 RID: 952
		private const string DB = "db_aibehaviortree.db";

		// Token: 0x040003B9 RID: 953
		private const string FILE = "k.可视化编辑/c.Csv/a.AI行为树/*.csv*";

		// Token: 0x040003BA RID: 954
		private const string TABLE = "AiBehaviorTree";

		// Token: 0x040003BB RID: 955
		private const string COMMAND = "select BinData from `AiBehaviorTree` where Id=?";

		// Token: 0x040003BC RID: 956
		private const string KEY_PREFIX = "AiBehaviorTreeById";

		// Token: 0x040003BD RID: 957
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003BE RID: 958
		private static int HandleId;
	}
}
