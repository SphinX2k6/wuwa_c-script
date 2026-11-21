using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000712 RID: 1810
	public class ConfigPhotoSubTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A7C RID: 10876 RVA: 0x0014D01B File Offset: 0x0014B21B
		static ConfigPhotoSubTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSubTabById.CreateStaticDefaultValue), new Action(ConfigPhotoSubTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x0014D03C File Offset: 0x0014B23C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSubTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSubTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSubTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSubTab` where Id=?")
			});
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x0014D0BB File Offset: 0x0014B2BB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSubTabById.LogPair = null;
			ConfigPhotoSubTabById.HandleId = 0;
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x0014D0C9 File Offset: 0x0014B2C9
		public static void Init()
		{
			ConfigPhotoSubTabById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSubTabById.HandleId, "db_photonew.db", "select BinData from `PhotoSubTab` where Id=?");
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x0014D0E4 File Offset: 0x0014B2E4
		public static PhotoSubTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSubTabById.HandleId, ConfigPhotoSubTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSubTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoSubTab?(PhotoSubTab.GetRootAsPhotoSubTab(configBuffer));
				}
			}
			ConfigPhotoSubTabById.LogPair.Clear();
			ConfigPhotoSubTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoSubTabById.HandleId, 1, p0Id, ConfigPhotoSubTabById.LogPair) || ConfigCommon.Step(ConfigPhotoSubTabById.HandleId, true, ConfigPhotoSubTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoSubTabById.HandleId, ConfigPhotoSubTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSubTabById.HandleId, 0, ConfigPhotoSubTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoSubTabById.HandleId, ConfigPhotoSubTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoSubTab rootAsPhotoSubTab = PhotoSubTab.GetRootAsPhotoSubTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSubTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoSubTabById.HandleId, ConfigPhotoSubTabById.LogPair);
			return new PhotoSubTab?(rootAsPhotoSubTab);
		}

		// Token: 0x04003164 RID: 12644
		private const string DB = "db_photonew.db";

		// Token: 0x04003165 RID: 12645
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003166 RID: 12646
		private const string TABLE = "PhotoSubTab";

		// Token: 0x04003167 RID: 12647
		private const string COMMAND = "select BinData from `PhotoSubTab` where Id=?";

		// Token: 0x04003168 RID: 12648
		private const string KEY_PREFIX = "PhotoSubTabById";

		// Token: 0x04003169 RID: 12649
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400316A RID: 12650
		private static int HandleId;
	}
}
