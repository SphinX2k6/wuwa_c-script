using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B7 RID: 1207
	public class ConfigKurotatoStructureById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C55 RID: 7253 RVA: 0x000F96C8 File Offset: 0x000F78C8
		static ConfigKurotatoStructureById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoStructureById.CreateStaticDefaultValue), new Action(ConfigKurotatoStructureById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000F96E8 File Offset: 0x000F78E8
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

		// Token: 0x06001C57 RID: 7255 RVA: 0x000F9767 File Offset: 0x000F7967
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoStructureById.LogPair = null;
			ConfigKurotatoStructureById.HandleId = 0;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x000F9775 File Offset: 0x000F7975
		public static void Init()
		{
			ConfigKurotatoStructureById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoStructureById.HandleId, "db_kurotato.db", "select BinData from `KurotatoStructure` where Id=?");
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x000F9790 File Offset: 0x000F7990
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

		// Token: 0x040020E5 RID: 8421
		private const string DB = "db_kurotato.db";

		// Token: 0x040020E6 RID: 8422
		private const string FILE = "t.土豆兄弟_机关.xlsx";

		// Token: 0x040020E7 RID: 8423
		private const string TABLE = "KurotatoStructure";

		// Token: 0x040020E8 RID: 8424
		private const string COMMAND = "select BinData from `KurotatoStructure` where Id=?";

		// Token: 0x040020E9 RID: 8425
		private const string KEY_PREFIX = "KurotatoStructureById";

		// Token: 0x040020EA RID: 8426
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020EB RID: 8427
		private static int HandleId;
	}
}
