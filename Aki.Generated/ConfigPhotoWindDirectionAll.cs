using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000704 RID: 1796
	public class ConfigPhotoWindDirectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A28 RID: 10792 RVA: 0x00147A44 File Offset: 0x00145C44
		static ConfigPhotoWindDirectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoWindDirectionAll.CreateStaticDefaultValue), new Action(ConfigPhotoWindDirectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00147A64 File Offset: 0x00145C64
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

		// Token: 0x06002A2A RID: 10794 RVA: 0x00147AE3 File Offset: 0x00145CE3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoWindDirectionAll.LogPair = null;
			ConfigPhotoWindDirectionAll.HandleId = 0;
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00147AF1 File Offset: 0x00145CF1
		public static void Init()
		{
			ConfigPhotoWindDirectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoWindDirectionAll.HandleId, "db_photonew.db", "select BinData from `PhotoWindDirection`");
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00147B0C File Offset: 0x00145D0C
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

		// Token: 0x04003102 RID: 12546
		private const string DB = "db_photonew.db";

		// Token: 0x04003103 RID: 12547
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003104 RID: 12548
		private const string TABLE = "PhotoWindDirection";

		// Token: 0x04003105 RID: 12549
		private const string COMMAND = "select BinData from `PhotoWindDirection`";

		// Token: 0x04003106 RID: 12550
		private const string KEY_PREFIX = "PhotoWindDirectionAll";

		// Token: 0x04003107 RID: 12551
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003108 RID: 12552
		private static int HandleId;
	}
}
