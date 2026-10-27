using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C9 RID: 1737
	public class ConfigPhotoCollectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028C6 RID: 10438 RVA: 0x0013FF7F File Offset: 0x0013E17F
		static ConfigPhotoCollectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoCollectionById.CreateStaticDefaultValue), new Action(ConfigPhotoCollectionById.ResetStaticDefaultValue));
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0013FFA0 File Offset: 0x0013E1A0
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

		// Token: 0x060028C8 RID: 10440 RVA: 0x0014001F File Offset: 0x0013E21F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoCollectionById.LogPair = null;
			ConfigPhotoCollectionById.HandleId = 0;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0014002D File Offset: 0x0013E22D
		public static void Init()
		{
			ConfigPhotoCollectionById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoCollectionById.HandleId, "db_photocollection.db", "select BinData from `PhotoCollection` where Id=?");
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00140048 File Offset: 0x0013E248
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

		// Token: 0x04002F65 RID: 12133
		private const string DB = "db_photocollection.db";

		// Token: 0x04002F66 RID: 12134
		private const string FILE = "j.技能采集配置.xlsx";

		// Token: 0x04002F67 RID: 12135
		private const string TABLE = "PhotoCollection";

		// Token: 0x04002F68 RID: 12136
		private const string COMMAND = "select BinData from `PhotoCollection` where Id=?";

		// Token: 0x04002F69 RID: 12137
		private const string KEY_PREFIX = "PhotoCollectionById";

		// Token: 0x04002F6A RID: 12138
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F6B RID: 12139
		private static int HandleId;
	}
}
