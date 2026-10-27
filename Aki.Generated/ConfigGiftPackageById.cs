using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039B RID: 923
	public class ConfigGiftPackageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015A9 RID: 5545 RVA: 0x000D413F File Offset: 0x000D233F
		static ConfigGiftPackageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiftPackageById.CreateStaticDefaultValue), new Action(ConfigGiftPackageById.ResetStaticDefaultValue));
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x000D4160 File Offset: 0x000D2360
		public static void CreateStaticDefaultValue()
		{
			ConfigGiftPackageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiftPackageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giftpackage.db"),
				new ValueTuple<string, object>("文件", "l.礼包.xlsx"),
				new ValueTuple<string, object>("表名", "GiftPackage"),
				new ValueTuple<string, object>("语句", "select BinData from `GiftPackage` where Id=?")
			});
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x000D41DF File Offset: 0x000D23DF
		public static void ResetStaticDefaultValue()
		{
			ConfigGiftPackageById.LogPair = null;
			ConfigGiftPackageById.HandleId = 0;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x000D41ED File Offset: 0x000D23ED
		public static void Init()
		{
			ConfigGiftPackageById.HandleId = ConfigCommon.InitDataStatement(ConfigGiftPackageById.HandleId, "db_giftpackage.db", "select BinData from `GiftPackage` where Id=?");
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x000D4208 File Offset: 0x000D2408
		public static GiftPackage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiftPackageById.HandleId, ConfigGiftPackageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiftPackageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiftPackage?(GiftPackage.GetRootAsGiftPackage(configBuffer));
				}
			}
			ConfigGiftPackageById.LogPair.Clear();
			ConfigGiftPackageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiftPackageById.HandleId, 1, p0Id, ConfigGiftPackageById.LogPair) || ConfigCommon.Step(ConfigGiftPackageById.HandleId, true, ConfigGiftPackageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiftPackageById.HandleId, ConfigGiftPackageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiftPackageById.HandleId, 0, ConfigGiftPackageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiftPackageById.HandleId, ConfigGiftPackageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiftPackage rootAsGiftPackage = GiftPackage.GetRootAsGiftPackage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiftPackageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiftPackageById.HandleId, ConfigGiftPackageById.LogPair);
			return new GiftPackage?(rootAsGiftPackage);
		}

		// Token: 0x04001921 RID: 6433
		private const string DB = "db_giftpackage.db";

		// Token: 0x04001922 RID: 6434
		private const string FILE = "l.礼包.xlsx";

		// Token: 0x04001923 RID: 6435
		private const string TABLE = "GiftPackage";

		// Token: 0x04001924 RID: 6436
		private const string COMMAND = "select BinData from `GiftPackage` where Id=?";

		// Token: 0x04001925 RID: 6437
		private const string KEY_PREFIX = "GiftPackageById";

		// Token: 0x04001926 RID: 6438
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001927 RID: 6439
		private static int HandleId;
	}
}
