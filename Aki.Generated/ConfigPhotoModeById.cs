using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FF RID: 1791
	public class ConfigPhotoModeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A0A RID: 10762 RVA: 0x0014A63F File Offset: 0x0014883F
		static ConfigPhotoModeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoModeById.CreateStaticDefaultValue), new Action(ConfigPhotoModeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x0014A660 File Offset: 0x00148860
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

		// Token: 0x06002A0C RID: 10764 RVA: 0x0014A6DF File Offset: 0x001488DF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoModeById.LogPair = null;
			ConfigPhotoModeById.HandleId = 0;
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x0014A6ED File Offset: 0x001488ED
		public static void Init()
		{
			ConfigPhotoModeById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoModeById.HandleId, "db_photonew.db", "select BinData from `PhotoMode` where Id=?");
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0014A708 File Offset: 0x00148908
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

		// Token: 0x040030DF RID: 12511
		private const string DB = "db_photonew.db";

		// Token: 0x040030E0 RID: 12512
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030E1 RID: 12513
		private const string TABLE = "PhotoMode";

		// Token: 0x040030E2 RID: 12514
		private const string COMMAND = "select BinData from `PhotoMode` where Id=?";

		// Token: 0x040030E3 RID: 12515
		private const string KEY_PREFIX = "PhotoModeById";

		// Token: 0x040030E4 RID: 12516
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030E5 RID: 12517
		private static int HandleId;
	}
}
