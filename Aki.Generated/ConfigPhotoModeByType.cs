using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000700 RID: 1792
	public class ConfigPhotoModeByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A10 RID: 10768 RVA: 0x0014A888 File Offset: 0x00148A88
		static ConfigPhotoModeByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoModeByType.CreateStaticDefaultValue), new Action(ConfigPhotoModeByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x0014A8A8 File Offset: 0x00148AA8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoModeByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoModeByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMode"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMode` where Type=?")
			});
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x0014A927 File Offset: 0x00148B27
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoModeByType.LogPair = null;
			ConfigPhotoModeByType.HandleId = 0;
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x0014A935 File Offset: 0x00148B35
		public static void Init()
		{
			ConfigPhotoModeByType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoModeByType.HandleId, "db_photonew.db", "select BinData from `PhotoMode` where Type=?");
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x0014A950 File Offset: 0x00148B50
		public static PhotoMode? GetConfig(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoModeByType.HandleId, ConfigPhotoModeByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoModeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoMode?(PhotoMode.GetRootAsPhotoMode(configBuffer));
				}
			}
			ConfigPhotoModeByType.LogPair.Clear();
			ConfigPhotoModeByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigPhotoModeByType.HandleId, 1, p0Type, ConfigPhotoModeByType.LogPair) || ConfigCommon.Step(ConfigPhotoModeByType.HandleId, true, ConfigPhotoModeByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoModeByType.HandleId, ConfigPhotoModeByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoModeByType.HandleId, 0, ConfigPhotoModeByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoModeByType.HandleId, ConfigPhotoModeByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoMode rootAsPhotoMode = PhotoMode.GetRootAsPhotoMode(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoModeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoModeByType.HandleId, ConfigPhotoModeByType.LogPair);
			return new PhotoMode?(rootAsPhotoMode);
		}

		// Token: 0x040030E6 RID: 12518
		private const string DB = "db_photonew.db";

		// Token: 0x040030E7 RID: 12519
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030E8 RID: 12520
		private const string TABLE = "PhotoMode";

		// Token: 0x040030E9 RID: 12521
		private const string COMMAND = "select BinData from `PhotoMode` where Type=?";

		// Token: 0x040030EA RID: 12522
		private const string KEY_PREFIX = "PhotoModeByType";

		// Token: 0x040030EB RID: 12523
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030EC RID: 12524
		private static int HandleId;
	}
}
