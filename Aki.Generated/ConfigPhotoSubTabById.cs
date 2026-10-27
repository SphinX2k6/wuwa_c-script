using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FA RID: 1786
	public class ConfigPhotoSubTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029EC RID: 10732 RVA: 0x0014659F File Offset: 0x0014479F
		static ConfigPhotoSubTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSubTabById.CreateStaticDefaultValue), new Action(ConfigPhotoSubTabById.ResetStaticDefaultValue));
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x001465C0 File Offset: 0x001447C0
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

		// Token: 0x060029EE RID: 10734 RVA: 0x0014663F File Offset: 0x0014483F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSubTabById.LogPair = null;
			ConfigPhotoSubTabById.HandleId = 0;
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x0014664D File Offset: 0x0014484D
		public static void Init()
		{
			ConfigPhotoSubTabById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSubTabById.HandleId, "db_photonew.db", "select BinData from `PhotoSubTab` where Id=?");
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00146668 File Offset: 0x00144868
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

		// Token: 0x040030BC RID: 12476
		private const string DB = "db_photonew.db";

		// Token: 0x040030BD RID: 12477
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030BE RID: 12478
		private const string TABLE = "PhotoSubTab";

		// Token: 0x040030BF RID: 12479
		private const string COMMAND = "select BinData from `PhotoSubTab` where Id=?";

		// Token: 0x040030C0 RID: 12480
		private const string KEY_PREFIX = "PhotoSubTabById";

		// Token: 0x040030C1 RID: 12481
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030C2 RID: 12482
		private static int HandleId;
	}
}
