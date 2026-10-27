using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A9 RID: 1193
	public class ConfigKurotatoMonsterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C01 RID: 7169 RVA: 0x000F7AFC File Offset: 0x000F5CFC
		static ConfigKurotatoMonsterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterTypeById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000F7B1C File Offset: 0x000F5D1C
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoMonsterTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoMonsterTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoMonsterType"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoMonsterType` where Id=?")
			});
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x000F7B9B File Offset: 0x000F5D9B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterTypeById.LogPair = null;
			ConfigKurotatoMonsterTypeById.HandleId = 0;
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000F7BA9 File Offset: 0x000F5DA9
		public static void Init()
		{
			ConfigKurotatoMonsterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterTypeById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterType` where Id=?");
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000F7BC4 File Offset: 0x000F5DC4
		public static KurotatoMonsterType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoMonsterTypeById.HandleId, ConfigKurotatoMonsterTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoMonsterType?(KurotatoMonsterType.GetRootAsKurotatoMonsterType(configBuffer));
				}
			}
			ConfigKurotatoMonsterTypeById.LogPair.Clear();
			ConfigKurotatoMonsterTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoMonsterTypeById.HandleId, 1, p0Id, ConfigKurotatoMonsterTypeById.LogPair) || ConfigCommon.Step(ConfigKurotatoMonsterTypeById.HandleId, true, ConfigKurotatoMonsterTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterTypeById.HandleId, ConfigKurotatoMonsterTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoMonsterTypeById.HandleId, 0, ConfigKurotatoMonsterTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterTypeById.HandleId, ConfigKurotatoMonsterTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoMonsterType rootAsKurotatoMonsterType = KurotatoMonsterType.GetRootAsKurotatoMonsterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoMonsterTypeById.HandleId, ConfigKurotatoMonsterTypeById.LogPair);
			return new KurotatoMonsterType?(rootAsKurotatoMonsterType);
		}

		// Token: 0x04002083 RID: 8323
		private const string DB = "db_kurotato.db";

		// Token: 0x04002084 RID: 8324
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x04002085 RID: 8325
		private const string TABLE = "KurotatoMonsterType";

		// Token: 0x04002086 RID: 8326
		private const string COMMAND = "select BinData from `KurotatoMonsterType` where Id=?";

		// Token: 0x04002087 RID: 8327
		private const string KEY_PREFIX = "KurotatoMonsterTypeById";

		// Token: 0x04002088 RID: 8328
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002089 RID: 8329
		private static int HandleId;
	}
}
