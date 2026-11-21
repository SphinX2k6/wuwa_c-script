using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DE RID: 1758
	public class ConfigPhotoAtmosphereAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002944 RID: 10564 RVA: 0x0014648C File Offset: 0x0014468C
		static ConfigPhotoAtmosphereAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoAtmosphereAll.CreateStaticDefaultValue), new Action(ConfigPhotoAtmosphereAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x001464AC File Offset: 0x001446AC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoAtmosphereAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoAtmosphereAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoAtmosphere"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoAtmosphere`")
			});
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x0014652B File Offset: 0x0014472B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoAtmosphereAll.LogPair = null;
			ConfigPhotoAtmosphereAll.HandleId = 0;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00146539 File Offset: 0x00144739
		public static void Init()
		{
			ConfigPhotoAtmosphereAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoAtmosphereAll.HandleId, "db_photonew.db", "select BinData from `PhotoAtmosphere`");
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00146554 File Offset: 0x00144754
		[NullableContext(2)]
		public static IReadOnlyList<PhotoAtmosphere> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoAtmosphereAll.HandleId, ConfigPhotoAtmosphereAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoAtmosphere> readOnlyList = (IReadOnlyList<PhotoAtmosphere>)ConfigCommon.GetConfig("PhotoAtmosphereAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoAtmosphere> list = new List<PhotoAtmosphere>();
			while (ConfigCommon.Step(ConfigPhotoAtmosphereAll.HandleId, false, ConfigPhotoAtmosphereAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoAtmosphereAll.HandleId, 0, ConfigPhotoAtmosphereAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoAtmosphereAll.HandleId, ConfigPhotoAtmosphereAll.LogPair);
					return null;
				}
				PhotoAtmosphere rootAsPhotoAtmosphere = PhotoAtmosphere.GetRootAsPhotoAtmosphere(new ByteBuffer(item2));
				list.Add(rootAsPhotoAtmosphere);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoAtmosphereAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoAtmosphereAll.HandleId, ConfigPhotoAtmosphereAll.LogPair);
			return list;
		}

		// Token: 0x04002FF8 RID: 12280
		private const string DB = "db_photonew.db";

		// Token: 0x04002FF9 RID: 12281
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04002FFA RID: 12282
		private const string TABLE = "PhotoAtmosphere";

		// Token: 0x04002FFB RID: 12283
		private const string COMMAND = "select BinData from `PhotoAtmosphere`";

		// Token: 0x04002FFC RID: 12284
		private const string KEY_PREFIX = "PhotoAtmosphereAll";

		// Token: 0x04002FFD RID: 12285
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FFE RID: 12286
		private static int HandleId;
	}
}
