using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C2 RID: 1218
	public class ConfigKurotatoWeaponByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C97 RID: 7319 RVA: 0x000FAC5C File Offset: 0x000F8E5C
		static ConfigKurotatoWeaponByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponByGroupId.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x000FAC7C File Offset: 0x000F8E7C
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

		// Token: 0x06001C99 RID: 7321 RVA: 0x000FACFB File Offset: 0x000F8EFB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponByGroupId.LogPair = null;
			ConfigKurotatoWeaponByGroupId.HandleId = 0;
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x000FAD09 File Offset: 0x000F8F09
		public static void Init()
		{
			ConfigKurotatoWeaponByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponByGroupId.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeapon` where GroupId=?");
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x000FAD24 File Offset: 0x000F8F24
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

		// Token: 0x04002132 RID: 8498
		private const string DB = "db_kurotato.db";

		// Token: 0x04002133 RID: 8499
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x04002134 RID: 8500
		private const string TABLE = "KurotatoWeapon";

		// Token: 0x04002135 RID: 8501
		private const string COMMAND = "select BinData from `KurotatoWeapon` where GroupId=?";

		// Token: 0x04002136 RID: 8502
		private const string KEY_PREFIX = "KurotatoWeaponByGroupId";

		// Token: 0x04002137 RID: 8503
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002138 RID: 8504
		private static int HandleId;
	}
}
