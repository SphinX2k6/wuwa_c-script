using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070E RID: 1806
	public class ConfigPhotoSetupByValueType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A64 RID: 10852 RVA: 0x0014C864 File Offset: 0x0014AA64
		static ConfigPhotoSetupByValueType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSetupByValueType.CreateStaticDefaultValue), new Action(ConfigPhotoSetupByValueType.ResetStaticDefaultValue));
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x0014C884 File Offset: 0x0014AA84
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

		// Token: 0x06002A66 RID: 10854 RVA: 0x0014C903 File Offset: 0x0014AB03
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSetupByValueType.LogPair = null;
			ConfigPhotoSetupByValueType.HandleId = 0;
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x0014C911 File Offset: 0x0014AB11
		public static void Init()
		{
			ConfigPhotoSetupByValueType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSetupByValueType.HandleId, "db_photograph.db", "select BinData from `PhotoSetup` where ValueType=?");
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x0014C92C File Offset: 0x0014AB2C
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

		// Token: 0x04003148 RID: 12616
		private const string DB = "db_photograph.db";

		// Token: 0x04003149 RID: 12617
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x0400314A RID: 12618
		private const string TABLE = "PhotoSetup";

		// Token: 0x0400314B RID: 12619
		private const string COMMAND = "select BinData from `PhotoSetup` where ValueType=?";

		// Token: 0x0400314C RID: 12620
		private const string KEY_PREFIX = "PhotoSetupByValueType";

		// Token: 0x0400314D RID: 12621
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400314E RID: 12622
		private static int HandleId;
	}
}
