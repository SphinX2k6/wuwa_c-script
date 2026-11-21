using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CD RID: 1229
	public class ConfigKurotatoStructureById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CD9 RID: 7385 RVA: 0x000FFE1C File Offset: 0x000FE01C
		static ConfigKurotatoStructureById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoStructureById.CreateStaticDefaultValue), new Action(ConfigKurotatoStructureById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000FFE3C File Offset: 0x000FE03C
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoStructureById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoStructureById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_机关.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoStructure"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoStructure` where Id=?")
			});
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x000FFEBB File Offset: 0x000FE0BB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoStructureById.LogPair = null;
			ConfigKurotatoStructureById.HandleId = 0;
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000FFEC9 File Offset: 0x000FE0C9
		public static void Init()
		{
			ConfigKurotatoStructureById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoStructureById.HandleId, "db_kurotato.db", "select BinData from `KurotatoStructure` where Id=?");
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000FFEE4 File Offset: 0x000FE0E4
		public static KurotatoStructure? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoStructureById.HandleId, ConfigKurotatoStructureById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoStructureById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoStructure?(KurotatoStructure.GetRootAsKurotatoStructure(configBuffer));
				}
			}
			ConfigKurotatoStructureById.LogPair.Clear();
			ConfigKurotatoStructureById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoStructureById.HandleId, 1, p0Id, ConfigKurotatoStructureById.LogPair) || ConfigCommon.Step(ConfigKurotatoStructureById.HandleId, true, ConfigKurotatoStructureById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoStructureById.HandleId, ConfigKurotatoStructureById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoStructureById.HandleId, 0, ConfigKurotatoStructureById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoStructureById.HandleId, ConfigKurotatoStructureById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoStructure rootAsKurotatoStructure = KurotatoStructure.GetRootAsKurotatoStructure(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoStructureById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoStructureById.HandleId, ConfigKurotatoStructureById.LogPair);
			return new KurotatoStructure?(rootAsKurotatoStructure);
		}

		// Token: 0x0400217F RID: 8575
		private const string DB = "db_kurotato.db";

		// Token: 0x04002180 RID: 8576
		private const string FILE = "t.土豆兄弟_机关.xlsx";

		// Token: 0x04002181 RID: 8577
		private const string TABLE = "KurotatoStructure";

		// Token: 0x04002182 RID: 8578
		private const string COMMAND = "select BinData from `KurotatoStructure` where Id=?";

		// Token: 0x04002183 RID: 8579
		private const string KEY_PREFIX = "KurotatoStructureById";

		// Token: 0x04002184 RID: 8580
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002185 RID: 8581
		private static int HandleId;
	}
}
