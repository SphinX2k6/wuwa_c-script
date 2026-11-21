using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B1 RID: 945
	public class ConfigGiftPackageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600162D RID: 5677 RVA: 0x000DA893 File Offset: 0x000D8A93
		static ConfigGiftPackageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiftPackageById.CreateStaticDefaultValue), new Action(ConfigGiftPackageById.ResetStaticDefaultValue));
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000DA8B4 File Offset: 0x000D8AB4
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

		// Token: 0x0600162F RID: 5679 RVA: 0x000DA933 File Offset: 0x000D8B33
		public static void ResetStaticDefaultValue()
		{
			ConfigGiftPackageById.LogPair = null;
			ConfigGiftPackageById.HandleId = 0;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000DA941 File Offset: 0x000D8B41
		public static void Init()
		{
			ConfigGiftPackageById.HandleId = ConfigCommon.InitDataStatement(ConfigGiftPackageById.HandleId, "db_giftpackage.db", "select BinData from `GiftPackage` where Id=?");
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x000DA95C File Offset: 0x000D8B5C
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

		// Token: 0x040019BB RID: 6587
		private const string DB = "db_giftpackage.db";

		// Token: 0x040019BC RID: 6588
		private const string FILE = "l.礼包.xlsx";

		// Token: 0x040019BD RID: 6589
		private const string TABLE = "GiftPackage";

		// Token: 0x040019BE RID: 6590
		private const string COMMAND = "select BinData from `GiftPackage` where Id=?";

		// Token: 0x040019BF RID: 6591
		private const string KEY_PREFIX = "GiftPackageById";

		// Token: 0x040019C0 RID: 6592
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019C1 RID: 6593
		private static int HandleId;
	}
}
