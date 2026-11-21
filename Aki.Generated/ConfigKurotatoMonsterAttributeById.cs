using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B9 RID: 1209
	public class ConfigKurotatoMonsterAttributeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C61 RID: 7265 RVA: 0x000FD554 File Offset: 0x000FB754
		static ConfigKurotatoMonsterAttributeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterAttributeById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterAttributeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000FD574 File Offset: 0x000FB774
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

		// Token: 0x06001C63 RID: 7267 RVA: 0x000FD5F3 File Offset: 0x000FB7F3
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterAttributeById.LogPair = null;
			ConfigKurotatoMonsterAttributeById.HandleId = 0;
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x000FD601 File Offset: 0x000FB801
		public static void Init()
		{
			ConfigKurotatoMonsterAttributeById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterAttributeById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterAttribute` where Id=?");
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x000FD61C File Offset: 0x000FB81C
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

		// Token: 0x040020F3 RID: 8435
		private const string DB = "db_kurotato.db";

		// Token: 0x040020F4 RID: 8436
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x040020F5 RID: 8437
		private const string TABLE = "KurotatoMonsterAttribute";

		// Token: 0x040020F6 RID: 8438
		private const string COMMAND = "select BinData from `KurotatoMonsterAttribute` where Id=?";

		// Token: 0x040020F7 RID: 8439
		private const string KEY_PREFIX = "KurotatoMonsterAttributeById";

		// Token: 0x040020F8 RID: 8440
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020F9 RID: 8441
		private static int HandleId;
	}
}
