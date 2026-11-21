using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D9 RID: 1241
	public class ConfigKurotatoWeaponById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D21 RID: 7457 RVA: 0x001015E7 File Offset: 0x000FF7E7
		static ConfigKurotatoWeaponById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponById.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00101608 File Offset: 0x000FF808
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWeaponById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWeaponById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_武器.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWeapon"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWeapon` where Id=?")
			});
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00101687 File Offset: 0x000FF887
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponById.LogPair = null;
			ConfigKurotatoWeaponById.HandleId = 0;
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00101695 File Offset: 0x000FF895
		public static void Init()
		{
			ConfigKurotatoWeaponById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeapon` where Id=?");
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x001016B0 File Offset: 0x000FF8B0
		public static KurotatoWeapon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWeaponById.HandleId, ConfigKurotatoWeaponById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWeaponById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoWeapon?(KurotatoWeapon.GetRootAsKurotatoWeapon(configBuffer));
				}
			}
			ConfigKurotatoWeaponById.LogPair.Clear();
			ConfigKurotatoWeaponById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoWeaponById.HandleId, 1, p0Id, ConfigKurotatoWeaponById.LogPair) || ConfigCommon.Step(ConfigKurotatoWeaponById.HandleId, true, ConfigKurotatoWeaponById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoWeaponById.HandleId, ConfigKurotatoWeaponById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWeaponById.HandleId, 0, ConfigKurotatoWeaponById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoWeaponById.HandleId, ConfigKurotatoWeaponById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoWeapon rootAsKurotatoWeapon = KurotatoWeapon.GetRootAsKurotatoWeapon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWeaponById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoWeaponById.HandleId, ConfigKurotatoWeaponById.LogPair);
			return new KurotatoWeapon?(rootAsKurotatoWeapon);
		}

		// Token: 0x040021D3 RID: 8659
		private const string DB = "db_kurotato.db";

		// Token: 0x040021D4 RID: 8660
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x040021D5 RID: 8661
		private const string TABLE = "KurotatoWeapon";

		// Token: 0x040021D6 RID: 8662
		private const string COMMAND = "select BinData from `KurotatoWeapon` where Id=?";

		// Token: 0x040021D7 RID: 8663
		private const string KEY_PREFIX = "KurotatoWeaponById";

		// Token: 0x040021D8 RID: 8664
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021D9 RID: 8665
		private static int HandleId;
	}
}
