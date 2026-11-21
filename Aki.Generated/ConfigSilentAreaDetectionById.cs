using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000979 RID: 2425
	public class ConfigSilentAreaDetectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038E9 RID: 14569 RVA: 0x0019E4FF File Offset: 0x0019C6FF
		static ConfigSilentAreaDetectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSilentAreaDetectionById.CreateStaticDefaultValue), new Action(ConfigSilentAreaDetectionById.ResetStaticDefaultValue));
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x0019E520 File Offset: 0x0019C720
		public static void CreateStaticDefaultValue()
		{
			ConfigSilentAreaDetectionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSilentAreaDetectionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "SilentAreaDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `SilentAreaDetection` where id=?")
			});
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x0019E59F File Offset: 0x0019C79F
		public static void ResetStaticDefaultValue()
		{
			ConfigSilentAreaDetectionById.LogPair = null;
			ConfigSilentAreaDetectionById.HandleId = 0;
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x0019E5AD File Offset: 0x0019C7AD
		public static void Init()
		{
			ConfigSilentAreaDetectionById.HandleId = ConfigCommon.InitDataStatement(ConfigSilentAreaDetectionById.HandleId, "db_adventure_detect.db", "select BinData from `SilentAreaDetection` where id=?");
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x0019E5C8 File Offset: 0x0019C7C8
		public static SilentAreaDetection? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSilentAreaDetectionById.HandleId, ConfigSilentAreaDetectionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SilentAreaDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SilentAreaDetection?(SilentAreaDetection.GetRootAsSilentAreaDetection(configBuffer));
				}
			}
			ConfigSilentAreaDetectionById.LogPair.Clear();
			ConfigSilentAreaDetectionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSilentAreaDetectionById.HandleId, 1, p0Id, ConfigSilentAreaDetectionById.LogPair) || ConfigCommon.Step(ConfigSilentAreaDetectionById.HandleId, true, ConfigSilentAreaDetectionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSilentAreaDetectionById.HandleId, ConfigSilentAreaDetectionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSilentAreaDetectionById.HandleId, 0, ConfigSilentAreaDetectionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSilentAreaDetectionById.HandleId, ConfigSilentAreaDetectionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SilentAreaDetection rootAsSilentAreaDetection = SilentAreaDetection.GetRootAsSilentAreaDetection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SilentAreaDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSilentAreaDetectionById.HandleId, ConfigSilentAreaDetectionById.LogPair);
			return new SilentAreaDetection?(rootAsSilentAreaDetection);
		}

		// Token: 0x04004235 RID: 16949
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04004236 RID: 16950
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04004237 RID: 16951
		private const string TABLE = "SilentAreaDetection";

		// Token: 0x04004238 RID: 16952
		private const string COMMAND = "select BinData from `SilentAreaDetection` where id=?";

		// Token: 0x04004239 RID: 16953
		private const string KEY_PREFIX = "SilentAreaDetectionById";

		// Token: 0x0400423A RID: 16954
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400423B RID: 16955
		private static int HandleId;
	}
}
