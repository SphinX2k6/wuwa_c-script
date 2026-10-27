using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012F RID: 303
	public class ConfigBulletPreloadByActorBlueprintAndBulletId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x00081D89 File Offset: 0x0007FF89
		static ConfigBulletPreloadByActorBlueprintAndBulletId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBulletPreloadByActorBlueprintAndBulletId.CreateStaticDefaultValue), new Action(ConfigBulletPreloadByActorBlueprintAndBulletId.ResetStaticDefaultValue));
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00081DA8 File Offset: 0x0007FFA8
		public static void CreateStaticDefaultValue()
		{
			ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bullet_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/BulletPreload.csv"),
				new ValueTuple<string, object>("表名", "BulletPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `BulletPreload` where ActorBlueprint=? AND BulletId=?")
			});
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00081E27 File Offset: 0x00080027
		public static void ResetStaticDefaultValue()
		{
			ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair = null;
			ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId = 0;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00081E35 File Offset: 0x00080035
		public static void Init()
		{
			ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId = ConfigCommon.InitDataStatement(ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId, "db_bullet_preload.db", "select BinData from `BulletPreload` where ActorBlueprint=? AND BulletId=?");
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00081E50 File Offset: 0x00080050
		public static BulletPreload? GetConfig(string p0ActorBlueprint, long p1BulletId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId, ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BulletPreloadByActorBlueprintAndBulletId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0ActorBlueprint);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p1BulletId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BulletPreload?(BulletPreload.GetRootAsBulletPreload(configBuffer));
				}
			}
			ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair.Clear();
			ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair.Add(new ValueTuple<string, object>("ActorBlueprint", p0ActorBlueprint));
			ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair.Add(new ValueTuple<string, object>("BulletId", p1BulletId));
			if (!ConfigCommon.BindString(ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId, 1, p0ActorBlueprint, ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair) || !ConfigCommon.BindBigInt(ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId, 2, p1BulletId, ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair) || ConfigCommon.Step(ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId, true, ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId, ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId, 0, ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId, ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BulletPreload rootAsBulletPreload = BulletPreload.GetRootAsBulletPreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BulletPreloadByActorBlueprintAndBulletId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0ActorBlueprint);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p1BulletId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId, ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair);
			return new BulletPreload?(rootAsBulletPreload);
		}

		// Token: 0x0400082D RID: 2093
		private const string DB = "db_bullet_preload.db";

		// Token: 0x0400082E RID: 2094
		private const string FILE = "Preload/BulletPreload.csv";

		// Token: 0x0400082F RID: 2095
		private const string TABLE = "BulletPreload";

		// Token: 0x04000830 RID: 2096
		private const string COMMAND = "select BinData from `BulletPreload` where ActorBlueprint=? AND BulletId=?";

		// Token: 0x04000831 RID: 2097
		private const string KEY_PREFIX = "BulletPreloadByActorBlueprintAndBulletId";

		// Token: 0x04000832 RID: 2098
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000833 RID: 2099
		private static int HandleId;
	}
}
