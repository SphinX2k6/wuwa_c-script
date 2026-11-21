using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013E RID: 318
	public class ConfigBulletPreloadByActorBlueprintAndBulletId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000775 RID: 1909 RVA: 0x000876ED File Offset: 0x000858ED
		static ConfigBulletPreloadByActorBlueprintAndBulletId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBulletPreloadByActorBlueprintAndBulletId.CreateStaticDefaultValue), new Action(ConfigBulletPreloadByActorBlueprintAndBulletId.ResetStaticDefaultValue));
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0008770C File Offset: 0x0008590C
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

		// Token: 0x06000777 RID: 1911 RVA: 0x0008778B File Offset: 0x0008598B
		public static void ResetStaticDefaultValue()
		{
			ConfigBulletPreloadByActorBlueprintAndBulletId.LogPair = null;
			ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId = 0;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00087799 File Offset: 0x00085999
		public static void Init()
		{
			ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId = ConfigCommon.InitDataStatement(ConfigBulletPreloadByActorBlueprintAndBulletId.HandleId, "db_bullet_preload.db", "select BinData from `BulletPreload` where ActorBlueprint=? AND BulletId=?");
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000877B4 File Offset: 0x000859B4
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

		// Token: 0x04000896 RID: 2198
		private const string DB = "db_bullet_preload.db";

		// Token: 0x04000897 RID: 2199
		private const string FILE = "Preload/BulletPreload.csv";

		// Token: 0x04000898 RID: 2200
		private const string TABLE = "BulletPreload";

		// Token: 0x04000899 RID: 2201
		private const string COMMAND = "select BinData from `BulletPreload` where ActorBlueprint=? AND BulletId=?";

		// Token: 0x0400089A RID: 2202
		private const string KEY_PREFIX = "BulletPreloadByActorBlueprintAndBulletId";

		// Token: 0x0400089B RID: 2203
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400089C RID: 2204
		private static int HandleId;
	}
}
