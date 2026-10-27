using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E9 RID: 1769
	public class ConfigPhotoMontageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002986 RID: 10630 RVA: 0x00144054 File Offset: 0x00142254
		static ConfigPhotoMontageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageById.CreateStaticDefaultValue), new Action(ConfigPhotoMontageById.ResetStaticDefaultValue));
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00144074 File Offset: 0x00142274
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMontageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMontageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMontage` where Id=?")
			});
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x001440F3 File Offset: 0x001422F3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageById.LogPair = null;
			ConfigPhotoMontageById.HandleId = 0;
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00144101 File Offset: 0x00142301
		public static void Init()
		{
			ConfigPhotoMontageById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageById.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where Id=?");
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x0014411C File Offset: 0x0014231C
		public static PhotoMontage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMontageById.HandleId, ConfigPhotoMontageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoMontage?(PhotoMontage.GetRootAsPhotoMontage(configBuffer));
				}
			}
			ConfigPhotoMontageById.LogPair.Clear();
			ConfigPhotoMontageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoMontageById.HandleId, 1, p0Id, ConfigPhotoMontageById.LogPair) || ConfigCommon.Step(ConfigPhotoMontageById.HandleId, true, ConfigPhotoMontageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoMontageById.HandleId, ConfigPhotoMontageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMontageById.HandleId, 0, ConfigPhotoMontageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoMontageById.HandleId, ConfigPhotoMontageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoMontage rootAsPhotoMontage = PhotoMontage.GetRootAsPhotoMontage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMontageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoMontageById.HandleId, ConfigPhotoMontageById.LogPair);
			return new PhotoMontage?(rootAsPhotoMontage);
		}

		// Token: 0x04003045 RID: 12357
		private const string DB = "db_photograph.db";

		// Token: 0x04003046 RID: 12358
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04003047 RID: 12359
		private const string TABLE = "PhotoMontage";

		// Token: 0x04003048 RID: 12360
		private const string COMMAND = "select BinData from `PhotoMontage` where Id=?";

		// Token: 0x04003049 RID: 12361
		private const string KEY_PREFIX = "PhotoMontageById";

		// Token: 0x0400304A RID: 12362
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400304B RID: 12363
		private static int HandleId;
	}
}
