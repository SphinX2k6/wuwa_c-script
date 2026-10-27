using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A3 RID: 1187
	public class ConfigKurotatoMonsterAttributeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BDD RID: 7133 RVA: 0x000F6E00 File Offset: 0x000F5000
		static ConfigKurotatoMonsterAttributeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterAttributeById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterAttributeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x000F6E20 File Offset: 0x000F5020
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoMonsterAttributeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoMonsterAttributeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoMonsterAttribute"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoMonsterAttribute` where Id=?")
			});
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x000F6E9F File Offset: 0x000F509F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterAttributeById.LogPair = null;
			ConfigKurotatoMonsterAttributeById.HandleId = 0;
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x000F6EAD File Offset: 0x000F50AD
		public static void Init()
		{
			ConfigKurotatoMonsterAttributeById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterAttributeById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterAttribute` where Id=?");
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x000F6EC8 File Offset: 0x000F50C8
		public static KurotatoMonsterAttribute? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoMonsterAttributeById.HandleId, ConfigKurotatoMonsterAttributeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterAttributeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoMonsterAttribute?(KurotatoMonsterAttribute.GetRootAsKurotatoMonsterAttribute(configBuffer));
				}
			}
			ConfigKurotatoMonsterAttributeById.LogPair.Clear();
			ConfigKurotatoMonsterAttributeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoMonsterAttributeById.HandleId, 1, p0Id, ConfigKurotatoMonsterAttributeById.LogPair) || ConfigCommon.Step(ConfigKurotatoMonsterAttributeById.HandleId, true, ConfigKurotatoMonsterAttributeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterAttributeById.HandleId, ConfigKurotatoMonsterAttributeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoMonsterAttributeById.HandleId, 0, ConfigKurotatoMonsterAttributeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterAttributeById.HandleId, ConfigKurotatoMonsterAttributeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoMonsterAttribute rootAsKurotatoMonsterAttribute = KurotatoMonsterAttribute.GetRootAsKurotatoMonsterAttribute(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterAttributeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoMonsterAttributeById.HandleId, ConfigKurotatoMonsterAttributeById.LogPair);
			return new KurotatoMonsterAttribute?(rootAsKurotatoMonsterAttribute);
		}

		// Token: 0x04002059 RID: 8281
		private const string DB = "db_kurotato.db";

		// Token: 0x0400205A RID: 8282
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x0400205B RID: 8283
		private const string TABLE = "KurotatoMonsterAttribute";

		// Token: 0x0400205C RID: 8284
		private const string COMMAND = "select BinData from `KurotatoMonsterAttribute` where Id=?";

		// Token: 0x0400205D RID: 8285
		private const string KEY_PREFIX = "KurotatoMonsterAttributeById";

		// Token: 0x0400205E RID: 8286
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400205F RID: 8287
		private static int HandleId;
	}
}
