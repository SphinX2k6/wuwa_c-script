using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000212 RID: 530
	public class ConfigDetectionTabTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C6F RID: 3183 RVA: 0x000A37F8 File Offset: 0x000A19F8
		static ConfigDetectionTabTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDetectionTabTypeById.CreateStaticDefaultValue), new Action(ConfigDetectionTabTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x000A3818 File Offset: 0x000A1A18
		public static void CreateStaticDefaultValue()
		{
			ConfigDetectionTabTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDetectionTabTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "DetectionTabType"),
				new ValueTuple<string, object>("语句", "select BinData from `DetectionTabType` where Id=?")
			});
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000A3897 File Offset: 0x000A1A97
		public static void ResetStaticDefaultValue()
		{
			ConfigDetectionTabTypeById.LogPair = null;
			ConfigDetectionTabTypeById.HandleId = 0;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000A38A5 File Offset: 0x000A1AA5
		public static void Init()
		{
			ConfigDetectionTabTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigDetectionTabTypeById.HandleId, "db_adventure_detect.db", "select BinData from `DetectionTabType` where Id=?");
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000A38C0 File Offset: 0x000A1AC0
		public static DetectionTabType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDetectionTabTypeById.HandleId, ConfigDetectionTabTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DetectionTabTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DetectionTabType?(DetectionTabType.GetRootAsDetectionTabType(configBuffer));
				}
			}
			ConfigDetectionTabTypeById.LogPair.Clear();
			ConfigDetectionTabTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDetectionTabTypeById.HandleId, 1, p0Id, ConfigDetectionTabTypeById.LogPair) || ConfigCommon.Step(ConfigDetectionTabTypeById.HandleId, true, ConfigDetectionTabTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDetectionTabTypeById.HandleId, ConfigDetectionTabTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDetectionTabTypeById.HandleId, 0, ConfigDetectionTabTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDetectionTabTypeById.HandleId, ConfigDetectionTabTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DetectionTabType rootAsDetectionTabType = DetectionTabType.GetRootAsDetectionTabType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DetectionTabTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDetectionTabTypeById.HandleId, ConfigDetectionTabTypeById.LogPair);
			return new DetectionTabType?(rootAsDetectionTabType);
		}

		// Token: 0x04000E62 RID: 3682
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000E63 RID: 3683
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000E64 RID: 3684
		private const string TABLE = "DetectionTabType";

		// Token: 0x04000E65 RID: 3685
		private const string COMMAND = "select BinData from `DetectionTabType` where Id=?";

		// Token: 0x04000E66 RID: 3686
		private const string KEY_PREFIX = "DetectionTabTypeById";

		// Token: 0x04000E67 RID: 3687
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E68 RID: 3688
		private static int HandleId;
	}
}
