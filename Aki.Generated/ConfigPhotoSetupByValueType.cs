using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F6 RID: 1782
	public class ConfigPhotoSetupByValueType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029D4 RID: 10708 RVA: 0x00145DE8 File Offset: 0x00143FE8
		static ConfigPhotoSetupByValueType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSetupByValueType.CreateStaticDefaultValue), new Action(ConfigPhotoSetupByValueType.ResetStaticDefaultValue));
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00145E08 File Offset: 0x00144008
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSetupByValueType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSetupByValueType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSetup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSetup` where ValueType=?")
			});
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00145E87 File Offset: 0x00144087
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSetupByValueType.LogPair = null;
			ConfigPhotoSetupByValueType.HandleId = 0;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x00145E95 File Offset: 0x00144095
		public static void Init()
		{
			ConfigPhotoSetupByValueType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSetupByValueType.HandleId, "db_photograph.db", "select BinData from `PhotoSetup` where ValueType=?");
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00145EB0 File Offset: 0x001440B0
		public static PhotoSetup? GetConfig(int p0ValueType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSetupByValueType.HandleId, ConfigPhotoSetupByValueType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSetupByValueType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ValueType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoSetup?(PhotoSetup.GetRootAsPhotoSetup(configBuffer));
				}
			}
			ConfigPhotoSetupByValueType.LogPair.Clear();
			ConfigPhotoSetupByValueType.LogPair.Add(new ValueTuple<string, object>("ValueType", p0ValueType));
			if (!ConfigCommon.BindInt(ConfigPhotoSetupByValueType.HandleId, 1, p0ValueType, ConfigPhotoSetupByValueType.LogPair) || ConfigCommon.Step(ConfigPhotoSetupByValueType.HandleId, true, ConfigPhotoSetupByValueType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoSetupByValueType.HandleId, ConfigPhotoSetupByValueType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSetupByValueType.HandleId, 0, ConfigPhotoSetupByValueType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoSetupByValueType.HandleId, ConfigPhotoSetupByValueType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoSetup rootAsPhotoSetup = PhotoSetup.GetRootAsPhotoSetup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSetupByValueType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ValueType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoSetupByValueType.HandleId, ConfigPhotoSetupByValueType.LogPair);
			return new PhotoSetup?(rootAsPhotoSetup);
		}

		// Token: 0x040030A0 RID: 12448
		private const string DB = "db_photograph.db";

		// Token: 0x040030A1 RID: 12449
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x040030A2 RID: 12450
		private const string TABLE = "PhotoSetup";

		// Token: 0x040030A3 RID: 12451
		private const string COMMAND = "select BinData from `PhotoSetup` where ValueType=?";

		// Token: 0x040030A4 RID: 12452
		private const string KEY_PREFIX = "PhotoSetupByValueType";

		// Token: 0x040030A5 RID: 12453
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030A6 RID: 12454
		private static int HandleId;
	}
}
