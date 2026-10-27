using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E7 RID: 1767
	public class ConfigPhotoModeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600297A RID: 10618 RVA: 0x00143BC3 File Offset: 0x00141DC3
		static ConfigPhotoModeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoModeById.CreateStaticDefaultValue), new Action(ConfigPhotoModeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00143BE4 File Offset: 0x00141DE4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoModeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoModeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMode"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMode` where Id=?")
			});
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00143C63 File Offset: 0x00141E63
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoModeById.LogPair = null;
			ConfigPhotoModeById.HandleId = 0;
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00143C71 File Offset: 0x00141E71
		public static void Init()
		{
			ConfigPhotoModeById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoModeById.HandleId, "db_photonew.db", "select BinData from `PhotoMode` where Id=?");
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x00143C8C File Offset: 0x00141E8C
		public static PhotoMode? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoModeById.HandleId, ConfigPhotoModeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoModeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoMode?(PhotoMode.GetRootAsPhotoMode(configBuffer));
				}
			}
			ConfigPhotoModeById.LogPair.Clear();
			ConfigPhotoModeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoModeById.HandleId, 1, p0Id, ConfigPhotoModeById.LogPair) || ConfigCommon.Step(ConfigPhotoModeById.HandleId, true, ConfigPhotoModeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoModeById.HandleId, ConfigPhotoModeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoModeById.HandleId, 0, ConfigPhotoModeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoModeById.HandleId, ConfigPhotoModeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoMode rootAsPhotoMode = PhotoMode.GetRootAsPhotoMode(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoModeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoModeById.HandleId, ConfigPhotoModeById.LogPair);
			return new PhotoMode?(rootAsPhotoMode);
		}

		// Token: 0x04003037 RID: 12343
		private const string DB = "db_photonew.db";

		// Token: 0x04003038 RID: 12344
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003039 RID: 12345
		private const string TABLE = "PhotoMode";

		// Token: 0x0400303A RID: 12346
		private const string COMMAND = "select BinData from `PhotoMode` where Id=?";

		// Token: 0x0400303B RID: 12347
		private const string KEY_PREFIX = "PhotoModeById";

		// Token: 0x0400303C RID: 12348
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400303D RID: 12349
		private static int HandleId;
	}
}
