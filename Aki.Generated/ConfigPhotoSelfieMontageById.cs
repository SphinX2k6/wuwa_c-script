using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F3 RID: 1779
	public class ConfigPhotoSelfieMontageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029C2 RID: 10690 RVA: 0x001457C3 File Offset: 0x001439C3
		static ConfigPhotoSelfieMontageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSelfieMontageById.CreateStaticDefaultValue), new Action(ConfigPhotoSelfieMontageById.ResetStaticDefaultValue));
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x001457E4 File Offset: 0x001439E4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSelfieMontageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSelfieMontageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSelfieMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSelfieMontage` where Id=?")
			});
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x00145863 File Offset: 0x00143A63
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSelfieMontageById.LogPair = null;
			ConfigPhotoSelfieMontageById.HandleId = 0;
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x00145871 File Offset: 0x00143A71
		public static void Init()
		{
			ConfigPhotoSelfieMontageById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSelfieMontageById.HandleId, "db_photonew.db", "select BinData from `PhotoSelfieMontage` where Id=?");
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x0014588C File Offset: 0x00143A8C
		public static PhotoSelfieMontage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSelfieMontageById.HandleId, ConfigPhotoSelfieMontageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSelfieMontageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoSelfieMontage?(PhotoSelfieMontage.GetRootAsPhotoSelfieMontage(configBuffer));
				}
			}
			ConfigPhotoSelfieMontageById.LogPair.Clear();
			ConfigPhotoSelfieMontageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoSelfieMontageById.HandleId, 1, p0Id, ConfigPhotoSelfieMontageById.LogPair) || ConfigCommon.Step(ConfigPhotoSelfieMontageById.HandleId, true, ConfigPhotoSelfieMontageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoSelfieMontageById.HandleId, ConfigPhotoSelfieMontageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSelfieMontageById.HandleId, 0, ConfigPhotoSelfieMontageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoSelfieMontageById.HandleId, ConfigPhotoSelfieMontageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoSelfieMontage rootAsPhotoSelfieMontage = PhotoSelfieMontage.GetRootAsPhotoSelfieMontage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSelfieMontageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoSelfieMontageById.HandleId, ConfigPhotoSelfieMontageById.LogPair);
			return new PhotoSelfieMontage?(rootAsPhotoSelfieMontage);
		}

		// Token: 0x0400308B RID: 12427
		private const string DB = "db_photonew.db";

		// Token: 0x0400308C RID: 12428
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x0400308D RID: 12429
		private const string TABLE = "PhotoSelfieMontage";

		// Token: 0x0400308E RID: 12430
		private const string COMMAND = "select BinData from `PhotoSelfieMontage` where Id=?";

		// Token: 0x0400308F RID: 12431
		private const string KEY_PREFIX = "PhotoSelfieMontageById";

		// Token: 0x04003090 RID: 12432
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003091 RID: 12433
		private static int HandleId;
	}
}
