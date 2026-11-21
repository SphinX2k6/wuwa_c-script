using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B1 RID: 1201
	public class ConfigKurotatoLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C31 RID: 7217 RVA: 0x000FC443 File Offset: 0x000FA643
		static ConfigKurotatoLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelById.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000FC464 File Offset: 0x000FA664
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLevel` where Id=?")
			});
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x000FC4E3 File Offset: 0x000FA6E3
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelById.LogPair = null;
			ConfigKurotatoLevelById.HandleId = 0;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000FC4F1 File Offset: 0x000FA6F1
		public static void Init()
		{
			ConfigKurotatoLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelById.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevel` where Id=?");
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x000FC50C File Offset: 0x000FA70C
		public static KurotatoLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLevelById.HandleId, ConfigKurotatoLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoLevel?(KurotatoLevel.GetRootAsKurotatoLevel(configBuffer));
				}
			}
			ConfigKurotatoLevelById.LogPair.Clear();
			ConfigKurotatoLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoLevelById.HandleId, 1, p0Id, ConfigKurotatoLevelById.LogPair) || ConfigCommon.Step(ConfigKurotatoLevelById.HandleId, true, ConfigKurotatoLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoLevelById.HandleId, ConfigKurotatoLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLevelById.HandleId, 0, ConfigKurotatoLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoLevelById.HandleId, ConfigKurotatoLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoLevel rootAsKurotatoLevel = KurotatoLevel.GetRootAsKurotatoLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoLevelById.HandleId, ConfigKurotatoLevelById.LogPair);
			return new KurotatoLevel?(rootAsKurotatoLevel);
		}

		// Token: 0x040020BB RID: 8379
		private const string DB = "db_kurotato.db";

		// Token: 0x040020BC RID: 8380
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040020BD RID: 8381
		private const string TABLE = "KurotatoLevel";

		// Token: 0x040020BE RID: 8382
		private const string COMMAND = "select BinData from `KurotatoLevel` where Id=?";

		// Token: 0x040020BF RID: 8383
		private const string KEY_PREFIX = "KurotatoLevelById";

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
