using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FB RID: 1787
	public class ConfigPhotoMemoryCollectByTopicID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029F2 RID: 10738 RVA: 0x00149E98 File Offset: 0x00148098
		static ConfigPhotoMemoryCollectByTopicID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMemoryCollectByTopicID.CreateStaticDefaultValue), new Action(ConfigPhotoMemoryCollectByTopicID.ResetStaticDefaultValue));
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00149EB8 File Offset: 0x001480B8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMemoryCollectByTopicID.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMemoryCollectByTopicID.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fragmentmemory.db"),
				new ValueTuple<string, object>("文件", "j.记忆手册.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMemoryCollect"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMemoryCollect` where TopicID=?")
			});
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x00149F37 File Offset: 0x00148137
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMemoryCollectByTopicID.LogPair = null;
			ConfigPhotoMemoryCollectByTopicID.HandleId = 0;
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x00149F45 File Offset: 0x00148145
		public static void Init()
		{
			ConfigPhotoMemoryCollectByTopicID.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMemoryCollectByTopicID.HandleId, "db_fragmentmemory.db", "select BinData from `PhotoMemoryCollect` where TopicID=?");
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00149F60 File Offset: 0x00148160
		[NullableContext(2)]
		public static IReadOnlyList<PhotoMemoryCollect> GetConfigList(int p0TopicID, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMemoryCollectByTopicID.HandleId, ConfigPhotoMemoryCollectByTopicID.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMemoryCollectByTopicID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TopicID);
				IReadOnlyList<PhotoMemoryCollect> readOnlyList = (IReadOnlyList<PhotoMemoryCollect>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoMemoryCollectByTopicID.LogPair.Clear();
			ConfigPhotoMemoryCollectByTopicID.LogPair.Add(new ValueTuple<string, object>("TopicID", p0TopicID));
			if (!ConfigCommon.BindInt(ConfigPhotoMemoryCollectByTopicID.HandleId, 1, p0TopicID, ConfigPhotoMemoryCollectByTopicID.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoMemoryCollectByTopicID.HandleId, ConfigPhotoMemoryCollectByTopicID.LogPair);
				return null;
			}
			List<PhotoMemoryCollect> list = new List<PhotoMemoryCollect>();
			while (ConfigCommon.Step(ConfigPhotoMemoryCollectByTopicID.HandleId, false, ConfigPhotoMemoryCollectByTopicID.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMemoryCollectByTopicID.HandleId, 0, ConfigPhotoMemoryCollectByTopicID.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoMemoryCollectByTopicID.HandleId, ConfigPhotoMemoryCollectByTopicID.LogPair);
					return null;
				}
				PhotoMemoryCollect rootAsPhotoMemoryCollect = PhotoMemoryCollect.GetRootAsPhotoMemoryCollect(new ByteBuffer(item2));
				list.Add(rootAsPhotoMemoryCollect);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMemoryCollectByTopicID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TopicID);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoMemoryCollectByTopicID.HandleId, ConfigPhotoMemoryCollectByTopicID.LogPair);
			return list;
		}

		// Token: 0x040030C3 RID: 12483
		private const string DB = "db_fragmentmemory.db";

		// Token: 0x040030C4 RID: 12484
		private const string FILE = "j.记忆手册.xlsx";

		// Token: 0x040030C5 RID: 12485
		private const string TABLE = "PhotoMemoryCollect";

		// Token: 0x040030C6 RID: 12486
		private const string COMMAND = "select BinData from `PhotoMemoryCollect` where TopicID=?";

		// Token: 0x040030C7 RID: 12487
		private const string KEY_PREFIX = "PhotoMemoryCollectByTopicID";

		// Token: 0x040030C8 RID: 12488
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030C9 RID: 12489
		private static int HandleId;
	}
}
