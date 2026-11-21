using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BA RID: 1210
	public class ConfigKurotatoMonsterBodyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C67 RID: 7271 RVA: 0x000FD79C File Offset: 0x000FB99C
		static ConfigKurotatoMonsterBodyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterBodyById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterBodyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x000FD7BC File Offset: 0x000FB9BC
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoMonsterBodyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoMonsterBodyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoMonsterBody"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoMonsterBody` where Id=?")
			});
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x000FD83B File Offset: 0x000FBA3B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterBodyById.LogPair = null;
			ConfigKurotatoMonsterBodyById.HandleId = 0;
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x000FD849 File Offset: 0x000FBA49
		public static void Init()
		{
			ConfigKurotatoMonsterBodyById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterBodyById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterBody` where Id=?");
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x000FD864 File Offset: 0x000FBA64
		public static KurotatoMonsterBody? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoMonsterBodyById.HandleId, ConfigKurotatoMonsterBodyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterBodyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoMonsterBody?(KurotatoMonsterBody.GetRootAsKurotatoMonsterBody(configBuffer));
				}
			}
			ConfigKurotatoMonsterBodyById.LogPair.Clear();
			ConfigKurotatoMonsterBodyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoMonsterBodyById.HandleId, 1, p0Id, ConfigKurotatoMonsterBodyById.LogPair) || ConfigCommon.Step(ConfigKurotatoMonsterBodyById.HandleId, true, ConfigKurotatoMonsterBodyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterBodyById.HandleId, ConfigKurotatoMonsterBodyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoMonsterBodyById.HandleId, 0, ConfigKurotatoMonsterBodyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterBodyById.HandleId, ConfigKurotatoMonsterBodyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoMonsterBody rootAsKurotatoMonsterBody = KurotatoMonsterBody.GetRootAsKurotatoMonsterBody(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterBodyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoMonsterBodyById.HandleId, ConfigKurotatoMonsterBodyById.LogPair);
			return new KurotatoMonsterBody?(rootAsKurotatoMonsterBody);
		}

		// Token: 0x040020FA RID: 8442
		private const string DB = "db_kurotato.db";

		// Token: 0x040020FB RID: 8443
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x040020FC RID: 8444
		private const string TABLE = "KurotatoMonsterBody";

		// Token: 0x040020FD RID: 8445
		private const string COMMAND = "select BinData from `KurotatoMonsterBody` where Id=?";

		// Token: 0x040020FE RID: 8446
		private const string KEY_PREFIX = "KurotatoMonsterBodyById";

		// Token: 0x040020FF RID: 8447
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002100 RID: 8448
		private static int HandleId;
	}
}
