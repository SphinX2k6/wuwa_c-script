using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070B RID: 1803
	public class ConfigPhotoSelfieMontageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A52 RID: 10834 RVA: 0x0014C23F File Offset: 0x0014A43F
		static ConfigPhotoSelfieMontageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSelfieMontageById.CreateStaticDefaultValue), new Action(ConfigPhotoSelfieMontageById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x0014C260 File Offset: 0x0014A460
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

		// Token: 0x06002A54 RID: 10836 RVA: 0x0014C2DF File Offset: 0x0014A4DF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSelfieMontageById.LogPair = null;
			ConfigPhotoSelfieMontageById.HandleId = 0;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x0014C2ED File Offset: 0x0014A4ED
		public static void Init()
		{
			ConfigPhotoSelfieMontageById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSelfieMontageById.HandleId, "db_photonew.db", "select BinData from `PhotoSelfieMontage` where Id=?");
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x0014C308 File Offset: 0x0014A508
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

		// Token: 0x04003133 RID: 12595
		private const string DB = "db_photonew.db";

		// Token: 0x04003134 RID: 12596
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003135 RID: 12597
		private const string TABLE = "PhotoSelfieMontage";

		// Token: 0x04003136 RID: 12598
		private const string COMMAND = "select BinData from `PhotoSelfieMontage` where Id=?";

		// Token: 0x04003137 RID: 12599
		private const string KEY_PREFIX = "PhotoSelfieMontageById";

		// Token: 0x04003138 RID: 12600
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003139 RID: 12601
		private static int HandleId;
	}
}
