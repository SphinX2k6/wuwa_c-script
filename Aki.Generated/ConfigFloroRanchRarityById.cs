using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000336 RID: 822
	public class ConfigFloroRanchRarityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001349 RID: 4937 RVA: 0x000C9F17 File Offset: 0x000C8117
		static ConfigFloroRanchRarityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRarityById.CreateStaticDefaultValue), new Action(ConfigFloroRanchRarityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x000C9F38 File Offset: 0x000C8138
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchRarityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchRarityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchRarity"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchRarity` where Id=?")
			});
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x000C9FB7 File Offset: 0x000C81B7
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRarityById.LogPair = null;
			ConfigFloroRanchRarityById.HandleId = 0;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x000C9FC5 File Offset: 0x000C81C5
		public static void Init()
		{
			ConfigFloroRanchRarityById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRarityById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchRarity` where Id=?");
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000C9FE0 File Offset: 0x000C81E0
		public static FloroRanchRarity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchRarityById.HandleId, ConfigFloroRanchRarityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRarityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchRarity?(FloroRanchRarity.GetRootAsFloroRanchRarity(configBuffer));
				}
			}
			ConfigFloroRanchRarityById.LogPair.Clear();
			ConfigFloroRanchRarityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchRarityById.HandleId, 1, p0Id, ConfigFloroRanchRarityById.LogPair) || ConfigCommon.Step(ConfigFloroRanchRarityById.HandleId, true, ConfigFloroRanchRarityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchRarityById.HandleId, ConfigFloroRanchRarityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchRarityById.HandleId, 0, ConfigFloroRanchRarityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchRarityById.HandleId, ConfigFloroRanchRarityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchRarity rootAsFloroRanchRarity = FloroRanchRarity.GetRootAsFloroRanchRarity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRarityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchRarityById.HandleId, ConfigFloroRanchRarityById.LogPair);
			return new FloroRanchRarity?(rootAsFloroRanchRarity);
		}

		// Token: 0x0400165E RID: 5726
		private const string DB = "db_flororanch.db";

		// Token: 0x0400165F RID: 5727
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001660 RID: 5728
		private const string TABLE = "FloroRanchRarity";

		// Token: 0x04001661 RID: 5729
		private const string COMMAND = "select BinData from `FloroRanchRarity` where Id=?";

		// Token: 0x04001662 RID: 5730
		private const string KEY_PREFIX = "FloroRanchRarityById";

		// Token: 0x04001663 RID: 5731
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001664 RID: 5732
		private static int HandleId;
	}
}
