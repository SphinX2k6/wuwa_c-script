using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FD RID: 1789
	public class ConfigPhotoTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029FE RID: 10750 RVA: 0x00146BC3 File Offset: 0x00144DC3
		static ConfigPhotoTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTabById.CreateStaticDefaultValue), new Action(ConfigPhotoTabById.ResetStaticDefaultValue));
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00146BE4 File Offset: 0x00144DE4
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

		// Token: 0x06002A00 RID: 10752 RVA: 0x00146C63 File Offset: 0x00144E63
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTabById.LogPair = null;
			ConfigPhotoTabById.HandleId = 0;
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x00146C71 File Offset: 0x00144E71
		public static void Init()
		{
			ConfigPhotoTabById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTabById.HandleId, "db_photonew.db", "select BinData from `PhotoTab` where Id=?");
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00146C8C File Offset: 0x00144E8C
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

		// Token: 0x040030D1 RID: 12497
		private const string DB = "db_photonew.db";

		// Token: 0x040030D2 RID: 12498
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030D3 RID: 12499
		private const string TABLE = "PhotoTab";

		// Token: 0x040030D4 RID: 12500
		private const string COMMAND = "select BinData from `PhotoTab` where Id=?";

		// Token: 0x040030D5 RID: 12501
		private const string KEY_PREFIX = "PhotoTabById";

		// Token: 0x040030D6 RID: 12502
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030D7 RID: 12503
		private static int HandleId;
	}
}
