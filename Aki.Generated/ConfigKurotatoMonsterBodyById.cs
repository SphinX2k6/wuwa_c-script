using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A4 RID: 1188
	public class ConfigKurotatoMonsterBodyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BE3 RID: 7139 RVA: 0x000F7048 File Offset: 0x000F5248
		static ConfigKurotatoMonsterBodyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterBodyById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterBodyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x000F7068 File Offset: 0x000F5268
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

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000F70E7 File Offset: 0x000F52E7
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterBodyById.LogPair = null;
			ConfigKurotatoMonsterBodyById.HandleId = 0;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000F70F5 File Offset: 0x000F52F5
		public static void Init()
		{
			ConfigKurotatoMonsterBodyById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterBodyById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterBody` where Id=?");
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x000F7110 File Offset: 0x000F5310
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

		// Token: 0x04002060 RID: 8288
		private const string DB = "db_kurotato.db";

		// Token: 0x04002061 RID: 8289
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x04002062 RID: 8290
		private const string TABLE = "KurotatoMonsterBody";

		// Token: 0x04002063 RID: 8291
		private const string COMMAND = "select BinData from `KurotatoMonsterBody` where Id=?";

		// Token: 0x04002064 RID: 8292
		private const string KEY_PREFIX = "KurotatoMonsterBodyById";

		// Token: 0x04002065 RID: 8293
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002066 RID: 8294
		private static int HandleId;
	}
}
