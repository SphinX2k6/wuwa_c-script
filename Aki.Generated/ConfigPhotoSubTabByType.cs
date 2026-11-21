using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000713 RID: 1811
	public class ConfigPhotoSubTabByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A82 RID: 10882 RVA: 0x0014D264 File Offset: 0x0014B464
		static ConfigPhotoSubTabByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSubTabByType.CreateStaticDefaultValue), new Action(ConfigPhotoSubTabByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x0014D284 File Offset: 0x0014B484
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSubTabByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSubTabByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSubTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSubTab` where Type=?")
			});
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x0014D303 File Offset: 0x0014B503
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSubTabByType.LogPair = null;
			ConfigPhotoSubTabByType.HandleId = 0;
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x0014D311 File Offset: 0x0014B511
		public static void Init()
		{
			ConfigPhotoSubTabByType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSubTabByType.HandleId, "db_photonew.db", "select BinData from `PhotoSubTab` where Type=?");
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x0014D32C File Offset: 0x0014B52C
		public static PhotoSubTab? GetConfig(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSubTabByType.HandleId, ConfigPhotoSubTabByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSubTabByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoSubTab?(PhotoSubTab.GetRootAsPhotoSubTab(configBuffer));
				}
			}
			ConfigPhotoSubTabByType.LogPair.Clear();
			ConfigPhotoSubTabByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigPhotoSubTabByType.HandleId, 1, p0Type, ConfigPhotoSubTabByType.LogPair) || ConfigCommon.Step(ConfigPhotoSubTabByType.HandleId, true, ConfigPhotoSubTabByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoSubTabByType.HandleId, ConfigPhotoSubTabByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSubTabByType.HandleId, 0, ConfigPhotoSubTabByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoSubTabByType.HandleId, ConfigPhotoSubTabByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoSubTab rootAsPhotoSubTab = PhotoSubTab.GetRootAsPhotoSubTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSubTabByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoSubTabByType.HandleId, ConfigPhotoSubTabByType.LogPair);
			return new PhotoSubTab?(rootAsPhotoSubTab);
		}

		// Token: 0x0400316B RID: 12651
		private const string DB = "db_photonew.db";

		// Token: 0x0400316C RID: 12652
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x0400316D RID: 12653
		private const string TABLE = "PhotoSubTab";

		// Token: 0x0400316E RID: 12654
		private const string COMMAND = "select BinData from `PhotoSubTab` where Type=?";

		// Token: 0x0400316F RID: 12655
		private const string KEY_PREFIX = "PhotoSubTabByType";

		// Token: 0x04003170 RID: 12656
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003171 RID: 12657
		private static int HandleId;
	}
}
