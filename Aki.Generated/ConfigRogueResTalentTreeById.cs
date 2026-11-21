using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000876 RID: 2166
	public class ConfigRogueResTalentTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032D6 RID: 13014 RVA: 0x0017C5B7 File Offset: 0x0017A7B7
		static ConfigRogueResTalentTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTalentTreeById.CreateStaticDefaultValue), new Action(ConfigRogueResTalentTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x0017C5D8 File Offset: 0x0017A7D8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResTalentTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResTalentTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResTalentTree` where Id=?")
			});
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x0017C657 File Offset: 0x0017A857
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTalentTreeById.LogPair = null;
			ConfigRogueResTalentTreeById.HandleId = 0;
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x0017C665 File Offset: 0x0017A865
		public static void Init()
		{
			ConfigRogueResTalentTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTalentTreeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTalentTree` where Id=?");
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x0017C680 File Offset: 0x0017A880
		public static RogueResTalentTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResTalentTreeById.HandleId, ConfigRogueResTalentTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResTalentTree?(RogueResTalentTree.GetRootAsRogueResTalentTree(configBuffer));
				}
			}
			ConfigRogueResTalentTreeById.LogPair.Clear();
			ConfigRogueResTalentTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResTalentTreeById.HandleId, 1, p0Id, ConfigRogueResTalentTreeById.LogPair) || ConfigCommon.Step(ConfigRogueResTalentTreeById.HandleId, true, ConfigRogueResTalentTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResTalentTreeById.HandleId, ConfigRogueResTalentTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResTalentTreeById.HandleId, 0, ConfigRogueResTalentTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResTalentTreeById.HandleId, ConfigRogueResTalentTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResTalentTree rootAsRogueResTalentTree = RogueResTalentTree.GetRootAsRogueResTalentTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResTalentTreeById.HandleId, ConfigRogueResTalentTreeById.LogPair);
			return new RogueResTalentTree?(rootAsRogueResTalentTree);
		}

		// Token: 0x04003B20 RID: 15136
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B21 RID: 15137
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B22 RID: 15138
		private const string TABLE = "RogueResTalentTree";

		// Token: 0x04003B23 RID: 15139
		private const string COMMAND = "select BinData from `RogueResTalentTree` where Id=?";

		// Token: 0x04003B24 RID: 15140
		private const string KEY_PREFIX = "RogueResTalentTreeById";

		// Token: 0x04003B25 RID: 15141
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B26 RID: 15142
		private static int HandleId;
	}
}
