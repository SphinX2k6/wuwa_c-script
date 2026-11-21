using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FD RID: 1789
	public class ConfigPhotoMemoryTopicById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029FE RID: 10750 RVA: 0x0014A263 File Offset: 0x00148463
		static ConfigPhotoMemoryTopicById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMemoryTopicById.CreateStaticDefaultValue), new Action(ConfigPhotoMemoryTopicById.ResetStaticDefaultValue));
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x0014A284 File Offset: 0x00148484
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

		// Token: 0x06002A00 RID: 10752 RVA: 0x0014A303 File Offset: 0x00148503
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMemoryTopicById.LogPair = null;
			ConfigPhotoMemoryTopicById.HandleId = 0;
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x0014A311 File Offset: 0x00148511
		public static void Init()
		{
			ConfigPhotoMemoryTopicById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMemoryTopicById.HandleId, "db_fragmentmemory.db", "select BinData from `PhotoMemoryTopic` where Id=?");
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x0014A32C File Offset: 0x0014852C
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

		// Token: 0x040030D1 RID: 12497
		private const string DB = "db_fragmentmemory.db";

		// Token: 0x040030D2 RID: 12498
		private const string FILE = "j.记忆手册.xlsx";

		// Token: 0x040030D3 RID: 12499
		private const string TABLE = "PhotoMemoryTopic";

		// Token: 0x040030D4 RID: 12500
		private const string COMMAND = "select BinData from `PhotoMemoryTopic` where Id=?";

		// Token: 0x040030D5 RID: 12501
		private const string KEY_PREFIX = "PhotoMemoryTopicById";

		// Token: 0x040030D6 RID: 12502
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030D7 RID: 12503
		private static int HandleId;
	}
}
