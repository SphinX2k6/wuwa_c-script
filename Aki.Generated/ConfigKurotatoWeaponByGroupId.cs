using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D8 RID: 1240
	public class ConfigKurotatoWeaponByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D1B RID: 7451 RVA: 0x001013B0 File Offset: 0x000FF5B0
		static ConfigKurotatoWeaponByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponByGroupId.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x001013D0 File Offset: 0x000FF5D0
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWeaponByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWeaponByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_武器.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWeapon"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWeapon` where GroupId=?")
			});
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0010144F File Offset: 0x000FF64F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponByGroupId.LogPair = null;
			ConfigKurotatoWeaponByGroupId.HandleId = 0;
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0010145D File Offset: 0x000FF65D
		public static void Init()
		{
			ConfigKurotatoWeaponByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponByGroupId.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeapon` where GroupId=?");
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00101478 File Offset: 0x000FF678
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoWeapon> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWeaponByGroupId.HandleId, ConfigKurotatoWeaponByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWeaponByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<KurotatoWeapon> readOnlyList = (IReadOnlyList<KurotatoWeapon>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKurotatoWeaponByGroupId.LogPair.Clear();
			ConfigKurotatoWeaponByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigKurotatoWeaponByGroupId.HandleId, 1, p0GroupId, ConfigKurotatoWeaponByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigKurotatoWeaponByGroupId.HandleId, ConfigKurotatoWeaponByGroupId.LogPair);
				return null;
			}
			List<KurotatoWeapon> list = new List<KurotatoWeapon>();
			while (ConfigCommon.Step(ConfigKurotatoWeaponByGroupId.HandleId, false, ConfigKurotatoWeaponByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWeaponByGroupId.HandleId, 0, ConfigKurotatoWeaponByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoWeaponByGroupId.HandleId, ConfigKurotatoWeaponByGroupId.LogPair);
					return null;
				}
				KurotatoWeapon rootAsKurotatoWeapon = KurotatoWeapon.GetRootAsKurotatoWeapon(new ByteBuffer(item2));
				list.Add(rootAsKurotatoWeapon);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWeaponByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoWeaponByGroupId.HandleId, ConfigKurotatoWeaponByGroupId.LogPair);
			return list;
		}

		// Token: 0x040021CC RID: 8652
		private const string DB = "db_kurotato.db";

		// Token: 0x040021CD RID: 8653
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x040021CE RID: 8654
		private const string TABLE = "KurotatoWeapon";

		// Token: 0x040021CF RID: 8655
		private const string COMMAND = "select BinData from `KurotatoWeapon` where GroupId=?";

		// Token: 0x040021D0 RID: 8656
		private const string KEY_PREFIX = "KurotatoWeaponByGroupId";

		// Token: 0x040021D1 RID: 8657
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021D2 RID: 8658
		private static int HandleId;
	}
}
