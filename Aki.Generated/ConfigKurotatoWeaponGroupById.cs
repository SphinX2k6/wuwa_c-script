using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DB RID: 1243
	public class ConfigKurotatoWeaponGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D2D RID: 7469 RVA: 0x001019C3 File Offset: 0x000FFBC3
		static ConfigKurotatoWeaponGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponGroupById.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x001019E4 File Offset: 0x000FFBE4
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWeaponGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWeaponGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_武器.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWeaponGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWeaponGroup` where Id=?")
			});
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00101A63 File Offset: 0x000FFC63
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponGroupById.LogPair = null;
			ConfigKurotatoWeaponGroupById.HandleId = 0;
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00101A71 File Offset: 0x000FFC71
		public static void Init()
		{
			ConfigKurotatoWeaponGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponGroupById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeaponGroup` where Id=?");
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00101A8C File Offset: 0x000FFC8C
		public static KurotatoWeaponGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWeaponGroupById.HandleId, ConfigKurotatoWeaponGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWeaponGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoWeaponGroup?(KurotatoWeaponGroup.GetRootAsKurotatoWeaponGroup(configBuffer));
				}
			}
			ConfigKurotatoWeaponGroupById.LogPair.Clear();
			ConfigKurotatoWeaponGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoWeaponGroupById.HandleId, 1, p0Id, ConfigKurotatoWeaponGroupById.LogPair) || ConfigCommon.Step(ConfigKurotatoWeaponGroupById.HandleId, true, ConfigKurotatoWeaponGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoWeaponGroupById.HandleId, ConfigKurotatoWeaponGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWeaponGroupById.HandleId, 0, ConfigKurotatoWeaponGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoWeaponGroupById.HandleId, ConfigKurotatoWeaponGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoWeaponGroup rootAsKurotatoWeaponGroup = KurotatoWeaponGroup.GetRootAsKurotatoWeaponGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWeaponGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoWeaponGroupById.HandleId, ConfigKurotatoWeaponGroupById.LogPair);
			return new KurotatoWeaponGroup?(rootAsKurotatoWeaponGroup);
		}

		// Token: 0x040021E1 RID: 8673
		private const string DB = "db_kurotato.db";

		// Token: 0x040021E2 RID: 8674
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x040021E3 RID: 8675
		private const string TABLE = "KurotatoWeaponGroup";

		// Token: 0x040021E4 RID: 8676
		private const string COMMAND = "select BinData from `KurotatoWeaponGroup` where Id=?";

		// Token: 0x040021E5 RID: 8677
		private const string KEY_PREFIX = "KurotatoWeaponGroupById";

		// Token: 0x040021E6 RID: 8678
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021E7 RID: 8679
		private static int HandleId;
	}
}
