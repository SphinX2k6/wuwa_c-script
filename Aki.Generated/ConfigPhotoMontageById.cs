using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000701 RID: 1793
	public class ConfigPhotoMontageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A16 RID: 10774 RVA: 0x0014AAD0 File Offset: 0x00148CD0
		static ConfigPhotoMontageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMontageById.CreateStaticDefaultValue), new Action(ConfigPhotoMontageById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x0014AAF0 File Offset: 0x00148CF0
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

		// Token: 0x06002A18 RID: 10776 RVA: 0x0014AB6F File Offset: 0x00148D6F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMontageById.LogPair = null;
			ConfigPhotoMontageById.HandleId = 0;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x0014AB7D File Offset: 0x00148D7D
		public static void Init()
		{
			ConfigPhotoMontageById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMontageById.HandleId, "db_photograph.db", "select BinData from `PhotoMontage` where Id=?");
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x0014AB98 File Offset: 0x00148D98
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

		// Token: 0x040030ED RID: 12525
		private const string DB = "db_photograph.db";

		// Token: 0x040030EE RID: 12526
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x040030EF RID: 12527
		private const string TABLE = "PhotoMontage";

		// Token: 0x040030F0 RID: 12528
		private const string COMMAND = "select BinData from `PhotoMontage` where Id=?";

		// Token: 0x040030F1 RID: 12529
		private const string KEY_PREFIX = "PhotoMontageById";

		// Token: 0x040030F2 RID: 12530
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030F3 RID: 12531
		private static int HandleId;
	}
}
