using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D7 RID: 1239
	public class ConfigKurotatoWeaponBuildById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x00101167 File Offset: 0x000FF367
		static ConfigKurotatoWeaponBuildById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponBuildById.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponBuildById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00101188 File Offset: 0x000FF388
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

		// Token: 0x06001D17 RID: 7447 RVA: 0x00101207 File Offset: 0x000FF407
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponBuildById.LogPair = null;
			ConfigKurotatoWeaponBuildById.HandleId = 0;
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00101215 File Offset: 0x000FF415
		public static void Init()
		{
			ConfigKurotatoWeaponBuildById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponBuildById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeaponBuild` where Id=?");
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00101230 File Offset: 0x000FF430
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

		// Token: 0x040021C5 RID: 8645
		private const string DB = "db_kurotato.db";

		// Token: 0x040021C6 RID: 8646
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x040021C7 RID: 8647
		private const string TABLE = "KurotatoWeaponBuild";

		// Token: 0x040021C8 RID: 8648
		private const string COMMAND = "select BinData from `KurotatoWeaponBuild` where Id=?";

		// Token: 0x040021C9 RID: 8649
		private const string KEY_PREFIX = "KurotatoWeaponBuildById";

		// Token: 0x040021CA RID: 8650
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021CB RID: 8651
		private static int HandleId;
	}
}
