using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013D RID: 317
	public class ConfigBulletPreloadByActorBlueprint : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x00087509 File Offset: 0x00085709
		static ConfigBulletPreloadByActorBlueprint()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBulletPreloadByActorBlueprint.CreateStaticDefaultValue), new Action(ConfigBulletPreloadByActorBlueprint.ResetStaticDefaultValue));
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00087528 File Offset: 0x00085728
		public static void CreateStaticDefaultValue()
		{
			ConfigBulletPreloadByActorBlueprint.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBulletPreloadByActorBlueprint.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bullet_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/BulletPreload.csv"),
				new ValueTuple<string, object>("表名", "BulletPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `BulletPreload` where ActorBlueprint=?")
			});
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000875A7 File Offset: 0x000857A7
		public static void ResetStaticDefaultValue()
		{
			ConfigBulletPreloadByActorBlueprint.LogPair = null;
			ConfigBulletPreloadByActorBlueprint.HandleId = 0;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000875B5 File Offset: 0x000857B5
		public static void Init()
		{
			ConfigBulletPreloadByActorBlueprint.HandleId = ConfigCommon.InitDataStatement(ConfigBulletPreloadByActorBlueprint.HandleId, "db_bullet_preload.db", "select BinData from `BulletPreload` where ActorBlueprint=?");
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000875D0 File Offset: 0x000857D0
		[return: Nullable(2)]
		public static IReadOnlyList<BulletPreload> GetConfigList(string p0ActorBlueprint, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBulletPreloadByActorBlueprint.HandleId, ConfigBulletPreloadByActorBlueprint.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BulletPreload> readOnlyList = (IReadOnlyList<BulletPreload>)ConfigCommon.GetConfig("BulletPreloadByActorBlueprint#" + p0ActorBlueprint);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBulletPreloadByActorBlueprint.LogPair.Clear();
			ConfigBulletPreloadByActorBlueprint.LogPair.Add(new ValueTuple<string, object>("ActorBlueprint", p0ActorBlueprint));
			if (!ConfigCommon.BindString(ConfigBulletPreloadByActorBlueprint.HandleId, 1, p0ActorBlueprint, ConfigBulletPreloadByActorBlueprint.LogPair))
			{
				ConfigCommon.Reset(ConfigBulletPreloadByActorBlueprint.HandleId, ConfigBulletPreloadByActorBlueprint.LogPair);
				return null;
			}
			List<BulletPreload> list = new List<BulletPreload>();
			while (ConfigCommon.Step(ConfigBulletPreloadByActorBlueprint.HandleId, false, ConfigBulletPreloadByActorBlueprint.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBulletPreloadByActorBlueprint.HandleId, 0, ConfigBulletPreloadByActorBlueprint.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBulletPreloadByActorBlueprint.HandleId, ConfigBulletPreloadByActorBlueprint.LogPair);
					return null;
				}
				BulletPreload rootAsBulletPreload = BulletPreload.GetRootAsBulletPreload(new ByteBuffer(item2));
				list.Add(rootAsBulletPreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BulletPreloadByActorBlueprint#" + p0ActorBlueprint, list, list.Count);
			}
			ConfigCommon.Reset(ConfigBulletPreloadByActorBlueprint.HandleId, ConfigBulletPreloadByActorBlueprint.LogPair);
			return list;
		}

		// Token: 0x0400088F RID: 2191
		private const string DB = "db_bullet_preload.db";

		// Token: 0x04000890 RID: 2192
		private const string FILE = "Preload/BulletPreload.csv";

		// Token: 0x04000891 RID: 2193
		private const string TABLE = "BulletPreload";

		// Token: 0x04000892 RID: 2194
		private const string COMMAND = "select BinData from `BulletPreload` where ActorBlueprint=?";

		// Token: 0x04000893 RID: 2195
		private const string KEY_PREFIX = "BulletPreloadByActorBlueprint";

		// Token: 0x04000894 RID: 2196
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000895 RID: 2197
		private static int HandleId;
	}
}
