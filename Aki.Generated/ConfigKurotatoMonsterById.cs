using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A5 RID: 1189
	public class ConfigKurotatoMonsterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BE9 RID: 7145 RVA: 0x000F7290 File Offset: 0x000F5490
		static ConfigKurotatoMonsterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x000F72B0 File Offset: 0x000F54B0
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoMonsterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoMonsterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoMonster"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoMonster` where Id=?")
			});
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x000F732F File Offset: 0x000F552F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterById.LogPair = null;
			ConfigKurotatoMonsterById.HandleId = 0;
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x000F733D File Offset: 0x000F553D
		public static void Init()
		{
			ConfigKurotatoMonsterById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonster` where Id=?");
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x000F7358 File Offset: 0x000F5558
		public static KurotatoMonster? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoMonsterById.HandleId, ConfigKurotatoMonsterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoMonster?(KurotatoMonster.GetRootAsKurotatoMonster(configBuffer));
				}
			}
			ConfigKurotatoMonsterById.LogPair.Clear();
			ConfigKurotatoMonsterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoMonsterById.HandleId, 1, p0Id, ConfigKurotatoMonsterById.LogPair) || ConfigCommon.Step(ConfigKurotatoMonsterById.HandleId, true, ConfigKurotatoMonsterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterById.HandleId, ConfigKurotatoMonsterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoMonsterById.HandleId, 0, ConfigKurotatoMonsterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterById.HandleId, ConfigKurotatoMonsterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoMonster rootAsKurotatoMonster = KurotatoMonster.GetRootAsKurotatoMonster(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoMonsterById.HandleId, ConfigKurotatoMonsterById.LogPair);
			return new KurotatoMonster?(rootAsKurotatoMonster);
		}

		// Token: 0x04002067 RID: 8295
		private const string DB = "db_kurotato.db";

		// Token: 0x04002068 RID: 8296
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x04002069 RID: 8297
		private const string TABLE = "KurotatoMonster";

		// Token: 0x0400206A RID: 8298
		private const string COMMAND = "select BinData from `KurotatoMonster` where Id=?";

		// Token: 0x0400206B RID: 8299
		private const string KEY_PREFIX = "KurotatoMonsterById";

		// Token: 0x0400206C RID: 8300
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400206D RID: 8301
		private static int HandleId;
	}
}
