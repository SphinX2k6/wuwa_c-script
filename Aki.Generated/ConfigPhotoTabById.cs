using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000715 RID: 1813
	public class ConfigPhotoTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A8E RID: 10894 RVA: 0x0014D63F File Offset: 0x0014B83F
		static ConfigPhotoTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTabById.CreateStaticDefaultValue), new Action(ConfigPhotoTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x0014D660 File Offset: 0x0014B860
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoTab` where Id=?")
			});
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x0014D6DF File Offset: 0x0014B8DF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTabById.LogPair = null;
			ConfigPhotoTabById.HandleId = 0;
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x0014D6ED File Offset: 0x0014B8ED
		public static void Init()
		{
			ConfigPhotoTabById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTabById.HandleId, "db_photonew.db", "select BinData from `PhotoTab` where Id=?");
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0014D708 File Offset: 0x0014B908
		public static PhotoTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoTabById.HandleId, ConfigPhotoTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoTab?(PhotoTab.GetRootAsPhotoTab(configBuffer));
				}
			}
			ConfigPhotoTabById.LogPair.Clear();
			ConfigPhotoTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoTabById.HandleId, 1, p0Id, ConfigPhotoTabById.LogPair) || ConfigCommon.Step(ConfigPhotoTabById.HandleId, true, ConfigPhotoTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoTabById.HandleId, ConfigPhotoTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoTabById.HandleId, 0, ConfigPhotoTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoTabById.HandleId, ConfigPhotoTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoTab rootAsPhotoTab = PhotoTab.GetRootAsPhotoTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoTabById.HandleId, ConfigPhotoTabById.LogPair);
			return new PhotoTab?(rootAsPhotoTab);
		}

		// Token: 0x04003179 RID: 12665
		private const string DB = "db_photonew.db";

		// Token: 0x0400317A RID: 12666
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x0400317B RID: 12667
		private const string TABLE = "PhotoTab";

		// Token: 0x0400317C RID: 12668
		private const string COMMAND = "select BinData from `PhotoTab` where Id=?";

		// Token: 0x0400317D RID: 12669
		private const string KEY_PREFIX = "PhotoTabById";

		// Token: 0x0400317E RID: 12670
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400317F RID: 12671
		private static int HandleId;
	}
}
