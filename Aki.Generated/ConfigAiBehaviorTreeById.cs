using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000084 RID: 132
	public class ConfigAiBehaviorTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000318 RID: 792 RVA: 0x0006AF9C File Offset: 0x0006919C
		static ConfigAiBehaviorTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiBehaviorTreeById.CreateStaticDefaultValue), new Action(ConfigAiBehaviorTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0006AFBC File Offset: 0x000691BC
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

		// Token: 0x0600031A RID: 794 RVA: 0x0006B03B File Offset: 0x0006923B
		public static void ResetStaticDefaultValue()
		{
			ConfigAiBehaviorTreeById.LogPair = null;
			ConfigAiBehaviorTreeById.HandleId = 0;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0006B049 File Offset: 0x00069249
		public static void Init()
		{
			ConfigAiBehaviorTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigAiBehaviorTreeById.HandleId, "db_aibehaviortree.db", "select BinData from `AiBehaviorTree` where Id=?");
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0006B064 File Offset: 0x00069264
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

		// Token: 0x04000380 RID: 896
		private const string DB = "db_aibehaviortree.db";

		// Token: 0x04000381 RID: 897
		private const string FILE = "k.可视化编辑/c.Csv/a.AI行为树/*.csv*";

		// Token: 0x04000382 RID: 898
		private const string TABLE = "AiBehaviorTree";

		// Token: 0x04000383 RID: 899
		private const string COMMAND = "select BinData from `AiBehaviorTree` where Id=?";

		// Token: 0x04000384 RID: 900
		private const string KEY_PREFIX = "AiBehaviorTreeById";

		// Token: 0x04000385 RID: 901
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000386 RID: 902
		private static int HandleId;
	}
}
