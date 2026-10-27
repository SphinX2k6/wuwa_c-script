using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048B RID: 1163
	public class ConfigKurotatoCharacterUpgradeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B4C RID: 6988 RVA: 0x000F39A3 File Offset: 0x000F1BA3
		static ConfigKurotatoCharacterUpgradeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoCharacterUpgradeById.CreateStaticDefaultValue), new Action(ConfigKurotatoCharacterUpgradeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x000F39C4 File Offset: 0x000F1BC4
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

		// Token: 0x06001B4E RID: 6990 RVA: 0x000F3A43 File Offset: 0x000F1C43
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoCharacterUpgradeById.LogPair = null;
			ConfigKurotatoCharacterUpgradeById.HandleId = 0;
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x000F3A51 File Offset: 0x000F1C51
		public static void Init()
		{
			ConfigKurotatoCharacterUpgradeById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoCharacterUpgradeById.HandleId, "db_kurotato.db", "select BinData from `KurotatoCharacterUpgrade` where Id=?");
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x000F3A6C File Offset: 0x000F1C6C
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

		// Token: 0x04001FB1 RID: 8113
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FB2 RID: 8114
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x04001FB3 RID: 8115
		private const string TABLE = "KurotatoCharacterUpgrade";

		// Token: 0x04001FB4 RID: 8116
		private const string COMMAND = "select BinData from `KurotatoCharacterUpgrade` where Id=?";

		// Token: 0x04001FB5 RID: 8117
		private const string KEY_PREFIX = "KurotatoCharacterUpgradeById";

		// Token: 0x04001FB6 RID: 8118
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FB7 RID: 8119
		private static int HandleId;
	}
}
