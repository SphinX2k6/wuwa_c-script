using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000877 RID: 2167
	public class ConfigRogueResTalentTreeDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032DC RID: 13020 RVA: 0x0017C800 File Offset: 0x0017AA00
		static ConfigRogueResTalentTreeDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTalentTreeDescById.CreateStaticDefaultValue), new Action(ConfigRogueResTalentTreeDescById.ResetStaticDefaultValue));
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x0017C820 File Offset: 0x0017AA20
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResTalentTreeDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResTalentTreeDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResTalentTreeDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResTalentTreeDesc` where Id=?")
			});
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x0017C89F File Offset: 0x0017AA9F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTalentTreeDescById.LogPair = null;
			ConfigRogueResTalentTreeDescById.HandleId = 0;
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x0017C8AD File Offset: 0x0017AAAD
		public static void Init()
		{
			ConfigRogueResTalentTreeDescById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTalentTreeDescById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTalentTreeDesc` where Id=?");
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x0017C8C8 File Offset: 0x0017AAC8
		public static RogueResTalentTreeDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResTalentTreeDescById.HandleId, ConfigRogueResTalentTreeDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTalentTreeDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResTalentTreeDesc?(RogueResTalentTreeDesc.GetRootAsRogueResTalentTreeDesc(configBuffer));
				}
			}
			ConfigRogueResTalentTreeDescById.LogPair.Clear();
			ConfigRogueResTalentTreeDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResTalentTreeDescById.HandleId, 1, p0Id, ConfigRogueResTalentTreeDescById.LogPair) || ConfigCommon.Step(ConfigRogueResTalentTreeDescById.HandleId, true, ConfigRogueResTalentTreeDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResTalentTreeDescById.HandleId, ConfigRogueResTalentTreeDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResTalentTreeDescById.HandleId, 0, ConfigRogueResTalentTreeDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResTalentTreeDescById.HandleId, ConfigRogueResTalentTreeDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResTalentTreeDesc rootAsRogueResTalentTreeDesc = RogueResTalentTreeDesc.GetRootAsRogueResTalentTreeDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTalentTreeDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResTalentTreeDescById.HandleId, ConfigRogueResTalentTreeDescById.LogPair);
			return new RogueResTalentTreeDesc?(rootAsRogueResTalentTreeDesc);
		}

		// Token: 0x04003B27 RID: 15143
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B28 RID: 15144
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B29 RID: 15145
		private const string TABLE = "RogueResTalentTreeDesc";

		// Token: 0x04003B2A RID: 15146
		private const string COMMAND = "select BinData from `RogueResTalentTreeDesc` where Id=?";

		// Token: 0x04003B2B RID: 15147
		private const string KEY_PREFIX = "RogueResTalentTreeDescById";

		// Token: 0x04003B2C RID: 15148
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B2D RID: 15149
		private static int HandleId;
	}
}
