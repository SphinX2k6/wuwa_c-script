using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E5 RID: 1765
	public class ConfigPhotoMemoryTopicById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600296E RID: 10606 RVA: 0x001437E7 File Offset: 0x001419E7
		static ConfigPhotoMemoryTopicById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMemoryTopicById.CreateStaticDefaultValue), new Action(ConfigPhotoMemoryTopicById.ResetStaticDefaultValue));
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00143808 File Offset: 0x00141A08
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMemoryTopicById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMemoryTopicById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fragmentmemory.db"),
				new ValueTuple<string, object>("文件", "j.记忆手册.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMemoryTopic"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMemoryTopic` where Id=?")
			});
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00143887 File Offset: 0x00141A87
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMemoryTopicById.LogPair = null;
			ConfigPhotoMemoryTopicById.HandleId = 0;
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00143895 File Offset: 0x00141A95
		public static void Init()
		{
			ConfigPhotoMemoryTopicById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMemoryTopicById.HandleId, "db_fragmentmemory.db", "select BinData from `PhotoMemoryTopic` where Id=?");
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x001438B0 File Offset: 0x00141AB0
		public static PhotoMemoryTopic? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMemoryTopicById.HandleId, ConfigPhotoMemoryTopicById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMemoryTopicById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoMemoryTopic?(PhotoMemoryTopic.GetRootAsPhotoMemoryTopic(configBuffer));
				}
			}
			ConfigPhotoMemoryTopicById.LogPair.Clear();
			ConfigPhotoMemoryTopicById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoMemoryTopicById.HandleId, 1, p0Id, ConfigPhotoMemoryTopicById.LogPair) || ConfigCommon.Step(ConfigPhotoMemoryTopicById.HandleId, true, ConfigPhotoMemoryTopicById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoMemoryTopicById.HandleId, ConfigPhotoMemoryTopicById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMemoryTopicById.HandleId, 0, ConfigPhotoMemoryTopicById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoMemoryTopicById.HandleId, ConfigPhotoMemoryTopicById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoMemoryTopic rootAsPhotoMemoryTopic = PhotoMemoryTopic.GetRootAsPhotoMemoryTopic(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMemoryTopicById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoMemoryTopicById.HandleId, ConfigPhotoMemoryTopicById.LogPair);
			return new PhotoMemoryTopic?(rootAsPhotoMemoryTopic);
		}

		// Token: 0x04003029 RID: 12329
		private const string DB = "db_fragmentmemory.db";

		// Token: 0x0400302A RID: 12330
		private const string FILE = "j.记忆手册.xlsx";

		// Token: 0x0400302B RID: 12331
		private const string TABLE = "PhotoMemoryTopic";

		// Token: 0x0400302C RID: 12332
		private const string COMMAND = "select BinData from `PhotoMemoryTopic` where Id=?";

		// Token: 0x0400302D RID: 12333
		private const string KEY_PREFIX = "PhotoMemoryTopicById";

		// Token: 0x0400302E RID: 12334
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400302F RID: 12335
		private static int HandleId;
	}
}
