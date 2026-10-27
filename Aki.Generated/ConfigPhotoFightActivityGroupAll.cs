using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D2 RID: 1746
	public class ConfigPhotoFightActivityGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028FC RID: 10492 RVA: 0x00141280 File Offset: 0x0013F480
		static ConfigPhotoFightActivityGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightActivityGroupAll.CreateStaticDefaultValue), new Action(ConfigPhotoFightActivityGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x001412A0 File Offset: 0x0013F4A0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightActivityGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightActivityGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightActivityGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightActivityGroup`")
			});
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x0014131F File Offset: 0x0013F51F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightActivityGroupAll.LogPair = null;
			ConfigPhotoFightActivityGroupAll.HandleId = 0;
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x0014132D File Offset: 0x0013F52D
		public static void Init()
		{
			ConfigPhotoFightActivityGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightActivityGroupAll.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightActivityGroup`");
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00141348 File Offset: 0x0013F548
		[NullableContext(2)]
		public static IReadOnlyList<PhotoFightActivityGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightActivityGroupAll.HandleId, ConfigPhotoFightActivityGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoFightActivityGroup> readOnlyList = (IReadOnlyList<PhotoFightActivityGroup>)ConfigCommon.GetConfig("PhotoFightActivityGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoFightActivityGroup> list = new List<PhotoFightActivityGroup>();
			while (ConfigCommon.Step(ConfigPhotoFightActivityGroupAll.HandleId, false, ConfigPhotoFightActivityGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightActivityGroupAll.HandleId, 0, ConfigPhotoFightActivityGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoFightActivityGroupAll.HandleId, ConfigPhotoFightActivityGroupAll.LogPair);
					return null;
				}
				PhotoFightActivityGroup rootAsPhotoFightActivityGroup = PhotoFightActivityGroup.GetRootAsPhotoFightActivityGroup(new ByteBuffer(item2));
				list.Add(rootAsPhotoFightActivityGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoFightActivityGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoFightActivityGroupAll.HandleId, ConfigPhotoFightActivityGroupAll.LogPair);
			return list;
		}

		// Token: 0x04002FA4 RID: 12196
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04002FA5 RID: 12197
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04002FA6 RID: 12198
		private const string TABLE = "PhotoFightActivityGroup";

		// Token: 0x04002FA7 RID: 12199
		private const string COMMAND = "select BinData from `PhotoFightActivityGroup`";

		// Token: 0x04002FA8 RID: 12200
		private const string KEY_PREFIX = "PhotoFightActivityGroupAll";

		// Token: 0x04002FA9 RID: 12201
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FAA RID: 12202
		private static int HandleId;
	}
}
