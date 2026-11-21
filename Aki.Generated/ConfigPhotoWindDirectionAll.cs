using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200071C RID: 1820
	public class ConfigPhotoWindDirectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AB8 RID: 10936 RVA: 0x0014E4C0 File Offset: 0x0014C6C0
		static ConfigPhotoWindDirectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoWindDirectionAll.CreateStaticDefaultValue), new Action(ConfigPhotoWindDirectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0014E4E0 File Offset: 0x0014C6E0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoWindDirectionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoWindDirectionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoWindDirection"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoWindDirection`")
			});
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x0014E55F File Offset: 0x0014C75F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoWindDirectionAll.LogPair = null;
			ConfigPhotoWindDirectionAll.HandleId = 0;
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0014E56D File Offset: 0x0014C76D
		public static void Init()
		{
			ConfigPhotoWindDirectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoWindDirectionAll.HandleId, "db_photonew.db", "select BinData from `PhotoWindDirection`");
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x0014E588 File Offset: 0x0014C788
		[NullableContext(2)]
		public static IReadOnlyList<PhotoWindDirection> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoWindDirectionAll.HandleId, ConfigPhotoWindDirectionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoWindDirection> readOnlyList = (IReadOnlyList<PhotoWindDirection>)ConfigCommon.GetConfig("PhotoWindDirectionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoWindDirection> list = new List<PhotoWindDirection>();
			while (ConfigCommon.Step(ConfigPhotoWindDirectionAll.HandleId, false, ConfigPhotoWindDirectionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoWindDirectionAll.HandleId, 0, ConfigPhotoWindDirectionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoWindDirectionAll.HandleId, ConfigPhotoWindDirectionAll.LogPair);
					return null;
				}
				PhotoWindDirection rootAsPhotoWindDirection = PhotoWindDirection.GetRootAsPhotoWindDirection(new ByteBuffer(item2));
				list.Add(rootAsPhotoWindDirection);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoWindDirectionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoWindDirectionAll.HandleId, ConfigPhotoWindDirectionAll.LogPair);
			return list;
		}

		// Token: 0x040031AA RID: 12714
		private const string DB = "db_photonew.db";

		// Token: 0x040031AB RID: 12715
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040031AC RID: 12716
		private const string TABLE = "PhotoWindDirection";

		// Token: 0x040031AD RID: 12717
		private const string COMMAND = "select BinData from `PhotoWindDirection`";

		// Token: 0x040031AE RID: 12718
		private const string KEY_PREFIX = "PhotoWindDirectionAll";

		// Token: 0x040031AF RID: 12719
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031B0 RID: 12720
		private static int HandleId;
	}
}
