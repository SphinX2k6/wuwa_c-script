using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FB RID: 1787
	public class ConfigPhotoSubTabByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029F2 RID: 10738 RVA: 0x001467E8 File Offset: 0x001449E8
		static ConfigPhotoSubTabByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSubTabByType.CreateStaticDefaultValue), new Action(ConfigPhotoSubTabByType.ResetStaticDefaultValue));
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00146808 File Offset: 0x00144A08
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

		// Token: 0x060029F4 RID: 10740 RVA: 0x00146887 File Offset: 0x00144A87
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSubTabByType.LogPair = null;
			ConfigPhotoSubTabByType.HandleId = 0;
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x00146895 File Offset: 0x00144A95
		public static void Init()
		{
			ConfigPhotoSubTabByType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSubTabByType.HandleId, "db_photonew.db", "select BinData from `PhotoSubTab` where Type=?");
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x001468B0 File Offset: 0x00144AB0
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

		// Token: 0x040030C3 RID: 12483
		private const string DB = "db_photonew.db";

		// Token: 0x040030C4 RID: 12484
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030C5 RID: 12485
		private const string TABLE = "PhotoSubTab";

		// Token: 0x040030C6 RID: 12486
		private const string COMMAND = "select BinData from `PhotoSubTab` where Type=?";

		// Token: 0x040030C7 RID: 12487
		private const string KEY_PREFIX = "PhotoSubTabByType";

		// Token: 0x040030C8 RID: 12488
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030C9 RID: 12489
		private static int HandleId;
	}
}
