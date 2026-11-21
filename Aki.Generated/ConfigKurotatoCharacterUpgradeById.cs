using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A1 RID: 1185
	public class ConfigKurotatoCharacterUpgradeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BD0 RID: 7120 RVA: 0x000FA0F7 File Offset: 0x000F82F7
		static ConfigKurotatoCharacterUpgradeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoCharacterUpgradeById.CreateStaticDefaultValue), new Action(ConfigKurotatoCharacterUpgradeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000FA118 File Offset: 0x000F8318
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoCharacterUpgradeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoCharacterUpgradeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_角色.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoCharacterUpgrade"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoCharacterUpgrade` where Id=?")
			});
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000FA197 File Offset: 0x000F8397
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoCharacterUpgradeById.LogPair = null;
			ConfigKurotatoCharacterUpgradeById.HandleId = 0;
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x000FA1A5 File Offset: 0x000F83A5
		public static void Init()
		{
			ConfigKurotatoCharacterUpgradeById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoCharacterUpgradeById.HandleId, "db_kurotato.db", "select BinData from `KurotatoCharacterUpgrade` where Id=?");
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x000FA1C0 File Offset: 0x000F83C0
		public static KurotatoCharacterUpgrade? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoCharacterUpgradeById.HandleId, ConfigKurotatoCharacterUpgradeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoCharacterUpgradeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoCharacterUpgrade?(KurotatoCharacterUpgrade.GetRootAsKurotatoCharacterUpgrade(configBuffer));
				}
			}
			ConfigKurotatoCharacterUpgradeById.LogPair.Clear();
			ConfigKurotatoCharacterUpgradeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoCharacterUpgradeById.HandleId, 1, p0Id, ConfigKurotatoCharacterUpgradeById.LogPair) || ConfigCommon.Step(ConfigKurotatoCharacterUpgradeById.HandleId, true, ConfigKurotatoCharacterUpgradeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoCharacterUpgradeById.HandleId, ConfigKurotatoCharacterUpgradeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoCharacterUpgradeById.HandleId, 0, ConfigKurotatoCharacterUpgradeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoCharacterUpgradeById.HandleId, ConfigKurotatoCharacterUpgradeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoCharacterUpgrade rootAsKurotatoCharacterUpgrade = KurotatoCharacterUpgrade.GetRootAsKurotatoCharacterUpgrade(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoCharacterUpgradeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoCharacterUpgradeById.HandleId, ConfigKurotatoCharacterUpgradeById.LogPair);
			return new KurotatoCharacterUpgrade?(rootAsKurotatoCharacterUpgrade);
		}

		// Token: 0x0400204B RID: 8267
		private const string DB = "db_kurotato.db";

		// Token: 0x0400204C RID: 8268
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x0400204D RID: 8269
		private const string TABLE = "KurotatoCharacterUpgrade";

		// Token: 0x0400204E RID: 8270
		private const string COMMAND = "select BinData from `KurotatoCharacterUpgrade` where Id=?";

		// Token: 0x0400204F RID: 8271
		private const string KEY_PREFIX = "KurotatoCharacterUpgradeById";

		// Token: 0x04002050 RID: 8272
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002051 RID: 8273
		private static int HandleId;
	}
}
