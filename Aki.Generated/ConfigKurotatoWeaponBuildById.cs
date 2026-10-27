using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C1 RID: 1217
	public class ConfigKurotatoWeaponBuildById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C91 RID: 7313 RVA: 0x000FAA13 File Offset: 0x000F8C13
		static ConfigKurotatoWeaponBuildById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponBuildById.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponBuildById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x000FAA34 File Offset: 0x000F8C34
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWeaponBuildById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWeaponBuildById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_武器.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWeaponBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWeaponBuild` where Id=?")
			});
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x000FAAB3 File Offset: 0x000F8CB3
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponBuildById.LogPair = null;
			ConfigKurotatoWeaponBuildById.HandleId = 0;
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x000FAAC1 File Offset: 0x000F8CC1
		public static void Init()
		{
			ConfigKurotatoWeaponBuildById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponBuildById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeaponBuild` where Id=?");
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x000FAADC File Offset: 0x000F8CDC
		public static KurotatoWeaponBuild? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWeaponBuildById.HandleId, ConfigKurotatoWeaponBuildById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWeaponBuildById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoWeaponBuild?(KurotatoWeaponBuild.GetRootAsKurotatoWeaponBuild(configBuffer));
				}
			}
			ConfigKurotatoWeaponBuildById.LogPair.Clear();
			ConfigKurotatoWeaponBuildById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoWeaponBuildById.HandleId, 1, p0Id, ConfigKurotatoWeaponBuildById.LogPair) || ConfigCommon.Step(ConfigKurotatoWeaponBuildById.HandleId, true, ConfigKurotatoWeaponBuildById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoWeaponBuildById.HandleId, ConfigKurotatoWeaponBuildById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWeaponBuildById.HandleId, 0, ConfigKurotatoWeaponBuildById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoWeaponBuildById.HandleId, ConfigKurotatoWeaponBuildById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoWeaponBuild rootAsKurotatoWeaponBuild = KurotatoWeaponBuild.GetRootAsKurotatoWeaponBuild(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWeaponBuildById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoWeaponBuildById.HandleId, ConfigKurotatoWeaponBuildById.LogPair);
			return new KurotatoWeaponBuild?(rootAsKurotatoWeaponBuild);
		}

		// Token: 0x0400212B RID: 8491
		private const string DB = "db_kurotato.db";

		// Token: 0x0400212C RID: 8492
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x0400212D RID: 8493
		private const string TABLE = "KurotatoWeaponBuild";

		// Token: 0x0400212E RID: 8494
		private const string COMMAND = "select BinData from `KurotatoWeaponBuild` where Id=?";

		// Token: 0x0400212F RID: 8495
		private const string KEY_PREFIX = "KurotatoWeaponBuildById";

		// Token: 0x04002130 RID: 8496
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002131 RID: 8497
		private static int HandleId;
	}
}
