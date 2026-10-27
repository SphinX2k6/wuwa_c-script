using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C6 RID: 1734
	public class ConfigPhotoAtmosphereAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028B4 RID: 10420 RVA: 0x0013FA10 File Offset: 0x0013DC10
		static ConfigPhotoAtmosphereAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoAtmosphereAll.CreateStaticDefaultValue), new Action(ConfigPhotoAtmosphereAll.ResetStaticDefaultValue));
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x0013FA30 File Offset: 0x0013DC30
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

		// Token: 0x060028B6 RID: 10422 RVA: 0x0013FAAF File Offset: 0x0013DCAF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoAtmosphereAll.LogPair = null;
			ConfigPhotoAtmosphereAll.HandleId = 0;
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0013FABD File Offset: 0x0013DCBD
		public static void Init()
		{
			ConfigPhotoAtmosphereAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoAtmosphereAll.HandleId, "db_photonew.db", "select BinData from `PhotoAtmosphere`");
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x0013FAD8 File Offset: 0x0013DCD8
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

		// Token: 0x04002F50 RID: 12112
		private const string DB = "db_photonew.db";

		// Token: 0x04002F51 RID: 12113
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04002F52 RID: 12114
		private const string TABLE = "PhotoAtmosphere";

		// Token: 0x04002F53 RID: 12115
		private const string COMMAND = "select BinData from `PhotoAtmosphere`";

		// Token: 0x04002F54 RID: 12116
		private const string KEY_PREFIX = "PhotoAtmosphereAll";

		// Token: 0x04002F55 RID: 12117
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F56 RID: 12118
		private static int HandleId;
	}
}
