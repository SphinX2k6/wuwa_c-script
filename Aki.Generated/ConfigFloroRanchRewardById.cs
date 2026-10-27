using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000323 RID: 803
	public class ConfigFloroRanchRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012D7 RID: 4823 RVA: 0x000C3E8B File Offset: 0x000C208B
		static ConfigFloroRanchRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRewardById.CreateStaticDefaultValue), new Action(ConfigFloroRanchRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000C3EAC File Offset: 0x000C20AC
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchReward"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchReward` where Id=?")
			});
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000C3F2B File Offset: 0x000C212B
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRewardById.LogPair = null;
			ConfigFloroRanchRewardById.HandleId = 0;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000C3F39 File Offset: 0x000C2139
		public static void Init()
		{
			ConfigFloroRanchRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRewardById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchReward` where Id=?");
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x000C3F54 File Offset: 0x000C2154
		public static FloroRanchReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchRewardById.HandleId, ConfigFloroRanchRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchReward?(FloroRanchReward.GetRootAsFloroRanchReward(configBuffer));
				}
			}
			ConfigFloroRanchRewardById.LogPair.Clear();
			ConfigFloroRanchRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchRewardById.HandleId, 1, p0Id, ConfigFloroRanchRewardById.LogPair) || ConfigCommon.Step(ConfigFloroRanchRewardById.HandleId, true, ConfigFloroRanchRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchRewardById.HandleId, ConfigFloroRanchRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchRewardById.HandleId, 0, ConfigFloroRanchRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchRewardById.HandleId, ConfigFloroRanchRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchReward rootAsFloroRanchReward = FloroRanchReward.GetRootAsFloroRanchReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchRewardById.HandleId, ConfigFloroRanchRewardById.LogPair);
			return new FloroRanchReward?(rootAsFloroRanchReward);
		}

		// Token: 0x040015D9 RID: 5593
		private const string DB = "db_flororanch.db";

		// Token: 0x040015DA RID: 5594
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015DB RID: 5595
		private const string TABLE = "FloroRanchReward";

		// Token: 0x040015DC RID: 5596
		private const string COMMAND = "select BinData from `FloroRanchReward` where Id=?";

		// Token: 0x040015DD RID: 5597
		private const string KEY_PREFIX = "FloroRanchRewardById";

		// Token: 0x040015DE RID: 5598
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015DF RID: 5599
		private static int HandleId;
	}
}
