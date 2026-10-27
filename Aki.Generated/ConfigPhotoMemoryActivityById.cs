using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E1 RID: 1761
	public class ConfigPhotoMemoryActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002956 RID: 10582 RVA: 0x00142F8C File Offset: 0x0014118C
		static ConfigPhotoMemoryActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMemoryActivityById.CreateStaticDefaultValue), new Action(ConfigPhotoMemoryActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x00142FAC File Offset: 0x001411AC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMemoryActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMemoryActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fragmentmemory.db"),
				new ValueTuple<string, object>("文件", "j.记忆手册活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMemoryActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMemoryActivity` where Id=?")
			});
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x0014302B File Offset: 0x0014122B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMemoryActivityById.LogPair = null;
			ConfigPhotoMemoryActivityById.HandleId = 0;
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x00143039 File Offset: 0x00141239
		public static void Init()
		{
			ConfigPhotoMemoryActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMemoryActivityById.HandleId, "db_fragmentmemory.db", "select BinData from `PhotoMemoryActivity` where Id=?");
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x00143054 File Offset: 0x00141254
		public static PhotoMemoryActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMemoryActivityById.HandleId, ConfigPhotoMemoryActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMemoryActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoMemoryActivity?(PhotoMemoryActivity.GetRootAsPhotoMemoryActivity(configBuffer));
				}
			}
			ConfigPhotoMemoryActivityById.LogPair.Clear();
			ConfigPhotoMemoryActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoMemoryActivityById.HandleId, 1, p0Id, ConfigPhotoMemoryActivityById.LogPair) || ConfigCommon.Step(ConfigPhotoMemoryActivityById.HandleId, true, ConfigPhotoMemoryActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoMemoryActivityById.HandleId, ConfigPhotoMemoryActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMemoryActivityById.HandleId, 0, ConfigPhotoMemoryActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoMemoryActivityById.HandleId, ConfigPhotoMemoryActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoMemoryActivity rootAsPhotoMemoryActivity = PhotoMemoryActivity.GetRootAsPhotoMemoryActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMemoryActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoMemoryActivityById.HandleId, ConfigPhotoMemoryActivityById.LogPair);
			return new PhotoMemoryActivity?(rootAsPhotoMemoryActivity);
		}

		// Token: 0x0400300D RID: 12301
		private const string DB = "db_fragmentmemory.db";

		// Token: 0x0400300E RID: 12302
		private const string FILE = "j.记忆手册活动.xlsx";

		// Token: 0x0400300F RID: 12303
		private const string TABLE = "PhotoMemoryActivity";

		// Token: 0x04003010 RID: 12304
		private const string COMMAND = "select BinData from `PhotoMemoryActivity` where Id=?";

		// Token: 0x04003011 RID: 12305
		private const string KEY_PREFIX = "PhotoMemoryActivityById";

		// Token: 0x04003012 RID: 12306
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003013 RID: 12307
		private static int HandleId;
	}
}
