using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B1 RID: 1201
	public class ConfigKurotatoResAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C31 RID: 7217 RVA: 0x000F8A7F File Offset: 0x000F6C7F
		static ConfigKurotatoResAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoResAwardById.CreateStaticDefaultValue), new Action(ConfigKurotatoResAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000F8AA0 File Offset: 0x000F6CA0
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoResAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoResAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoResAward"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoResAward` where Id=?")
			});
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x000F8B1F File Offset: 0x000F6D1F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoResAwardById.LogPair = null;
			ConfigKurotatoResAwardById.HandleId = 0;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000F8B2D File Offset: 0x000F6D2D
		public static void Init()
		{
			ConfigKurotatoResAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoResAwardById.HandleId, "db_kurotato.db", "select BinData from `KurotatoResAward` where Id=?");
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x000F8B48 File Offset: 0x000F6D48
		public static KurotatoResAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoResAwardById.HandleId, ConfigKurotatoResAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoResAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoResAward?(KurotatoResAward.GetRootAsKurotatoResAward(configBuffer));
				}
			}
			ConfigKurotatoResAwardById.LogPair.Clear();
			ConfigKurotatoResAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoResAwardById.HandleId, 1, p0Id, ConfigKurotatoResAwardById.LogPair) || ConfigCommon.Step(ConfigKurotatoResAwardById.HandleId, true, ConfigKurotatoResAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoResAwardById.HandleId, ConfigKurotatoResAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoResAwardById.HandleId, 0, ConfigKurotatoResAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoResAwardById.HandleId, ConfigKurotatoResAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoResAward rootAsKurotatoResAward = KurotatoResAward.GetRootAsKurotatoResAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoResAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoResAwardById.HandleId, ConfigKurotatoResAwardById.LogPair);
			return new KurotatoResAward?(rootAsKurotatoResAward);
		}

		// Token: 0x040020BB RID: 8379
		private const string DB = "db_kurotato.db";

		// Token: 0x040020BC RID: 8380
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x040020BD RID: 8381
		private const string TABLE = "KurotatoResAward";

		// Token: 0x040020BE RID: 8382
		private const string COMMAND = "select BinData from `KurotatoResAward` where Id=?";

		// Token: 0x040020BF RID: 8383
		private const string KEY_PREFIX = "KurotatoResAwardById";

		// Token: 0x040020C0 RID: 8384
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020C1 RID: 8385
		private static int HandleId;
	}
}
