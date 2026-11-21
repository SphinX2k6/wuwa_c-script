using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E1 RID: 1761
	public class ConfigPhotoCollectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002956 RID: 10582 RVA: 0x001469FB File Offset: 0x00144BFB
		static ConfigPhotoCollectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoCollectionById.CreateStaticDefaultValue), new Action(ConfigPhotoCollectionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x00146A1C File Offset: 0x00144C1C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoCollectionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoCollectionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photocollection.db"),
				new ValueTuple<string, object>("文件", "j.技能采集配置.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoCollection"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoCollection` where Id=?")
			});
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x00146A9B File Offset: 0x00144C9B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoCollectionById.LogPair = null;
			ConfigPhotoCollectionById.HandleId = 0;
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x00146AA9 File Offset: 0x00144CA9
		public static void Init()
		{
			ConfigPhotoCollectionById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoCollectionById.HandleId, "db_photocollection.db", "select BinData from `PhotoCollection` where Id=?");
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x00146AC4 File Offset: 0x00144CC4
		public static PhotoCollection? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoCollectionById.HandleId, ConfigPhotoCollectionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoCollectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoCollection?(PhotoCollection.GetRootAsPhotoCollection(configBuffer));
				}
			}
			ConfigPhotoCollectionById.LogPair.Clear();
			ConfigPhotoCollectionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoCollectionById.HandleId, 1, p0Id, ConfigPhotoCollectionById.LogPair) || ConfigCommon.Step(ConfigPhotoCollectionById.HandleId, true, ConfigPhotoCollectionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoCollectionById.HandleId, ConfigPhotoCollectionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoCollectionById.HandleId, 0, ConfigPhotoCollectionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoCollectionById.HandleId, ConfigPhotoCollectionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoCollection rootAsPhotoCollection = PhotoCollection.GetRootAsPhotoCollection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoCollectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoCollectionById.HandleId, ConfigPhotoCollectionById.LogPair);
			return new PhotoCollection?(rootAsPhotoCollection);
		}

		// Token: 0x0400300D RID: 12301
		private const string DB = "db_photocollection.db";

		// Token: 0x0400300E RID: 12302
		private const string FILE = "j.技能采集配置.xlsx";

		// Token: 0x0400300F RID: 12303
		private const string TABLE = "PhotoCollection";

		// Token: 0x04003010 RID: 12304
		private const string COMMAND = "select BinData from `PhotoCollection` where Id=?";

		// Token: 0x04003011 RID: 12305
		private const string KEY_PREFIX = "PhotoCollectionById";

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
