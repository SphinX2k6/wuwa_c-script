using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070C RID: 1804
	public class ConfigPhotoSetupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A58 RID: 10840 RVA: 0x0014C488 File Offset: 0x0014A688
		static ConfigPhotoSetupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSetupAll.CreateStaticDefaultValue), new Action(ConfigPhotoSetupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x0014C4A8 File Offset: 0x0014A6A8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSetupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSetupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSetup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSetup`")
			});
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x0014C527 File Offset: 0x0014A727
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSetupAll.LogPair = null;
			ConfigPhotoSetupAll.HandleId = 0;
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x0014C535 File Offset: 0x0014A735
		public static void Init()
		{
			ConfigPhotoSetupAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSetupAll.HandleId, "db_photograph.db", "select BinData from `PhotoSetup`");
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x0014C550 File Offset: 0x0014A750
		[NullableContext(2)]
		public static IReadOnlyList<PhotoSetup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSetupAll.HandleId, ConfigPhotoSetupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoSetup> readOnlyList = (IReadOnlyList<PhotoSetup>)ConfigCommon.GetConfig("PhotoSetupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoSetup> list = new List<PhotoSetup>();
			while (ConfigCommon.Step(ConfigPhotoSetupAll.HandleId, false, ConfigPhotoSetupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSetupAll.HandleId, 0, ConfigPhotoSetupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoSetupAll.HandleId, ConfigPhotoSetupAll.LogPair);
					return null;
				}
				PhotoSetup rootAsPhotoSetup = PhotoSetup.GetRootAsPhotoSetup(new ByteBuffer(item2));
				list.Add(rootAsPhotoSetup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoSetupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoSetupAll.HandleId, ConfigPhotoSetupAll.LogPair);
			return list;
		}

		// Token: 0x0400313A RID: 12602
		private const string DB = "db_photograph.db";

		// Token: 0x0400313B RID: 12603
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x0400313C RID: 12604
		private const string TABLE = "PhotoSetup";

		// Token: 0x0400313D RID: 12605
		private const string COMMAND = "select BinData from `PhotoSetup`";

		// Token: 0x0400313E RID: 12606
		private const string KEY_PREFIX = "PhotoSetupAll";

		// Token: 0x0400313F RID: 12607
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003140 RID: 12608
		private static int HandleId;
	}
}
