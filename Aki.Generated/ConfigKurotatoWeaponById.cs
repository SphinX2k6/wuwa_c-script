using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C3 RID: 1219
	public class ConfigKurotatoWeaponById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C9D RID: 7325 RVA: 0x000FAE93 File Offset: 0x000F9093
		static ConfigKurotatoWeaponById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponById.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x000FAEB4 File Offset: 0x000F90B4
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

		// Token: 0x06001C9F RID: 7327 RVA: 0x000FAF33 File Offset: 0x000F9133
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponById.LogPair = null;
			ConfigKurotatoWeaponById.HandleId = 0;
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x000FAF41 File Offset: 0x000F9141
		public static void Init()
		{
			ConfigKurotatoWeaponById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeapon` where Id=?");
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000FAF5C File Offset: 0x000F915C
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

		// Token: 0x04002139 RID: 8505
		private const string DB = "db_kurotato.db";

		// Token: 0x0400213A RID: 8506
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x0400213B RID: 8507
		private const string TABLE = "KurotatoWeapon";

		// Token: 0x0400213C RID: 8508
		private const string COMMAND = "select BinData from `KurotatoWeapon` where Id=?";

		// Token: 0x0400213D RID: 8509
		private const string KEY_PREFIX = "KurotatoWeaponById";

		// Token: 0x0400213E RID: 8510
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400213F RID: 8511
		private static int HandleId;
	}
}
