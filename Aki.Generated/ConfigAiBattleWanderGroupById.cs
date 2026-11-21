using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008B RID: 139
	public class ConfigAiBattleWanderGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000342 RID: 834 RVA: 0x0006F608 File Offset: 0x0006D808
		static ConfigAiBattleWanderGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiBattleWanderGroupById.CreateStaticDefaultValue), new Action(ConfigAiBattleWanderGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0006F628 File Offset: 0x0006D828
		public static void CreateStaticDefaultValue()
		{
			ConfigAiBattleWanderGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiBattleWanderGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI战斗游荡.xlsx"),
				new ValueTuple<string, object>("表名", "AiBattleWanderGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `AiBattleWanderGroup` where Id=?")
			});
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0006F6A7 File Offset: 0x0006D8A7
		public static void ResetStaticDefaultValue()
		{
			ConfigAiBattleWanderGroupById.LogPair = null;
			ConfigAiBattleWanderGroupById.HandleId = 0;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0006F6B5 File Offset: 0x0006D8B5
		public static void Init()
		{
			ConfigAiBattleWanderGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigAiBattleWanderGroupById.HandleId, "db_ai.db", "select BinData from `AiBattleWanderGroup` where Id=?");
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0006F6D0 File Offset: 0x0006D8D0
		public static AiBattleWanderGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiBattleWanderGroupById.HandleId, ConfigAiBattleWanderGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBattleWanderGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiBattleWanderGroup?(AiBattleWanderGroup.GetRootAsAiBattleWanderGroup(configBuffer));
				}
			}
			ConfigAiBattleWanderGroupById.LogPair.Clear();
			ConfigAiBattleWanderGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiBattleWanderGroupById.HandleId, 1, p0Id, ConfigAiBattleWanderGroupById.LogPair) || ConfigCommon.Step(ConfigAiBattleWanderGroupById.HandleId, true, ConfigAiBattleWanderGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiBattleWanderGroupById.HandleId, ConfigAiBattleWanderGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiBattleWanderGroupById.HandleId, 0, ConfigAiBattleWanderGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiBattleWanderGroupById.HandleId, ConfigAiBattleWanderGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiBattleWanderGroup rootAsAiBattleWanderGroup = AiBattleWanderGroup.GetRootAsAiBattleWanderGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBattleWanderGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiBattleWanderGroupById.HandleId, ConfigAiBattleWanderGroupById.LogPair);
			return new AiBattleWanderGroup?(rootAsAiBattleWanderGroup);
		}

		// Token: 0x040003B1 RID: 945
		private const string DB = "db_ai.db";

		// Token: 0x040003B2 RID: 946
		private const string FILE = "a.AI战斗游荡.xlsx";

		// Token: 0x040003B3 RID: 947
		private const string TABLE = "AiBattleWanderGroup";

		// Token: 0x040003B4 RID: 948
		private const string COMMAND = "select BinData from `AiBattleWanderGroup` where Id=?";

		// Token: 0x040003B5 RID: 949
		private const string KEY_PREFIX = "AiBattleWanderGroupById";

		// Token: 0x040003B6 RID: 950
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003B7 RID: 951
		private static int HandleId;
	}
}
