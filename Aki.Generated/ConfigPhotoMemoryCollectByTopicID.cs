using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E3 RID: 1763
	public class ConfigPhotoMemoryCollectByTopicID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002962 RID: 10594 RVA: 0x0014341C File Offset: 0x0014161C
		static ConfigPhotoMemoryCollectByTopicID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMemoryCollectByTopicID.CreateStaticDefaultValue), new Action(ConfigPhotoMemoryCollectByTopicID.ResetStaticDefaultValue));
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x0014343C File Offset: 0x0014163C
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

		// Token: 0x06002964 RID: 10596 RVA: 0x001434BB File Offset: 0x001416BB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMemoryCollectByTopicID.LogPair = null;
			ConfigPhotoMemoryCollectByTopicID.HandleId = 0;
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x001434C9 File Offset: 0x001416C9
		public static void Init()
		{
			ConfigPhotoMemoryCollectByTopicID.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMemoryCollectByTopicID.HandleId, "db_fragmentmemory.db", "select BinData from `PhotoMemoryCollect` where TopicID=?");
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x001434E4 File Offset: 0x001416E4
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

		// Token: 0x0400301B RID: 12315
		private const string DB = "db_fragmentmemory.db";

		// Token: 0x0400301C RID: 12316
		private const string FILE = "j.记忆手册.xlsx";

		// Token: 0x0400301D RID: 12317
		private const string TABLE = "PhotoMemoryCollect";

		// Token: 0x0400301E RID: 12318
		private const string COMMAND = "select BinData from `PhotoMemoryCollect` where TopicID=?";

		// Token: 0x0400301F RID: 12319
		private const string KEY_PREFIX = "PhotoMemoryCollectByTopicID";

		// Token: 0x04003020 RID: 12320
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003021 RID: 12321
		private static int HandleId;
	}
}
