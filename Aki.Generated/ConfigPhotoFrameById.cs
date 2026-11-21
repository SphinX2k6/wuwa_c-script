using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F3 RID: 1779
	public class ConfigPhotoFrameById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029C2 RID: 10690 RVA: 0x00148DCF File Offset: 0x00146FCF
		static ConfigPhotoFrameById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFrameById.CreateStaticDefaultValue), new Action(ConfigPhotoFrameById.ResetStaticDefaultValue));
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x00148DF0 File Offset: 0x00146FF0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFrameById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFrameById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFrame"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFrame` where Id=?")
			});
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x00148E6F File Offset: 0x0014706F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFrameById.LogPair = null;
			ConfigPhotoFrameById.HandleId = 0;
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x00148E7D File Offset: 0x0014707D
		public static void Init()
		{
			ConfigPhotoFrameById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFrameById.HandleId, "db_photonew.db", "select BinData from `PhotoFrame` where Id=?");
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x00148E98 File Offset: 0x00147098
		public static PhotoFrame? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFrameById.HandleId, ConfigPhotoFrameById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFrameById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoFrame?(PhotoFrame.GetRootAsPhotoFrame(configBuffer));
				}
			}
			ConfigPhotoFrameById.LogPair.Clear();
			ConfigPhotoFrameById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoFrameById.HandleId, 1, p0Id, ConfigPhotoFrameById.LogPair) || ConfigCommon.Step(ConfigPhotoFrameById.HandleId, true, ConfigPhotoFrameById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoFrameById.HandleId, ConfigPhotoFrameById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFrameById.HandleId, 0, ConfigPhotoFrameById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoFrameById.HandleId, ConfigPhotoFrameById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoFrame rootAsPhotoFrame = PhotoFrame.GetRootAsPhotoFrame(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFrameById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoFrameById.HandleId, ConfigPhotoFrameById.LogPair);
			return new PhotoFrame?(rootAsPhotoFrame);
		}

		// Token: 0x0400308B RID: 12427
		private const string DB = "db_photonew.db";

		// Token: 0x0400308C RID: 12428
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x0400308D RID: 12429
		private const string TABLE = "PhotoFrame";

		// Token: 0x0400308E RID: 12430
		private const string COMMAND = "select BinData from `PhotoFrame` where Id=?";

		// Token: 0x0400308F RID: 12431
		private const string KEY_PREFIX = "PhotoFrameById";

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
