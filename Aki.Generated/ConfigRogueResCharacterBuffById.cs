using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000837 RID: 2103
	public class ConfigRogueResCharacterBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600315C RID: 12636 RVA: 0x00170780 File Offset: 0x0016E980
		static ConfigRogueResCharacterBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCharacterBuffById.CreateStaticDefaultValue), new Action(ConfigRogueResCharacterBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x001707A0 File Offset: 0x0016E9A0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResCharacterBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResCharacterBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResCharacterBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResCharacterBuff` where Id=?")
			});
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x0017081F File Offset: 0x0016EA1F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCharacterBuffById.LogPair = null;
			ConfigRogueResCharacterBuffById.HandleId = 0;
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0017082D File Offset: 0x0016EA2D
		public static void Init()
		{
			ConfigRogueResCharacterBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCharacterBuffById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCharacterBuff` where Id=?");
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00170848 File Offset: 0x0016EA48
		public static RogueResCharacterBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResCharacterBuffById.HandleId, ConfigRogueResCharacterBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCharacterBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResCharacterBuff?(RogueResCharacterBuff.GetRootAsRogueResCharacterBuff(configBuffer));
				}
			}
			ConfigRogueResCharacterBuffById.LogPair.Clear();
			ConfigRogueResCharacterBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResCharacterBuffById.HandleId, 1, p0Id, ConfigRogueResCharacterBuffById.LogPair) || ConfigCommon.Step(ConfigRogueResCharacterBuffById.HandleId, true, ConfigRogueResCharacterBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResCharacterBuffById.HandleId, ConfigRogueResCharacterBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResCharacterBuffById.HandleId, 0, ConfigRogueResCharacterBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResCharacterBuffById.HandleId, ConfigRogueResCharacterBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResCharacterBuff rootAsRogueResCharacterBuff = RogueResCharacterBuff.GetRootAsRogueResCharacterBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCharacterBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResCharacterBuffById.HandleId, ConfigRogueResCharacterBuffById.LogPair);
			return new RogueResCharacterBuff?(rootAsRogueResCharacterBuff);
		}

		// Token: 0x04003967 RID: 14695
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003968 RID: 14696
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003969 RID: 14697
		private const string TABLE = "RogueResCharacterBuff";

		// Token: 0x0400396A RID: 14698
		private const string COMMAND = "select BinData from `RogueResCharacterBuff` where Id=?";

		// Token: 0x0400396B RID: 14699
		private const string KEY_PREFIX = "RogueResCharacterBuffById";

		// Token: 0x0400396C RID: 14700
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400396D RID: 14701
		private static int HandleId;
	}
}
