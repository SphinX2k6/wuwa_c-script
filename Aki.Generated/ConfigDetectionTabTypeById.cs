using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000200 RID: 512
	public class ConfigDetectionTabTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C03 RID: 3075 RVA: 0x0009D8C0 File Offset: 0x0009BAC0
		static ConfigDetectionTabTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDetectionTabTypeById.CreateStaticDefaultValue), new Action(ConfigDetectionTabTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0009D8E0 File Offset: 0x0009BAE0
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

		// Token: 0x06000C05 RID: 3077 RVA: 0x0009D95F File Offset: 0x0009BB5F
		public static void ResetStaticDefaultValue()
		{
			ConfigDetectionTabTypeById.LogPair = null;
			ConfigDetectionTabTypeById.HandleId = 0;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0009D96D File Offset: 0x0009BB6D
		public static void Init()
		{
			ConfigDetectionTabTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigDetectionTabTypeById.HandleId, "db_adventure_detect.db", "select BinData from `DetectionTabType` where Id=?");
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0009D988 File Offset: 0x0009BB88
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

		// Token: 0x04000DE4 RID: 3556
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000DE5 RID: 3557
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000DE6 RID: 3558
		private const string TABLE = "DetectionTabType";

		// Token: 0x04000DE7 RID: 3559
		private const string COMMAND = "select BinData from `DetectionTabType` where Id=?";

		// Token: 0x04000DE8 RID: 3560
		private const string KEY_PREFIX = "DetectionTabTypeById";

		// Token: 0x04000DE9 RID: 3561
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DEA RID: 3562
		private static int HandleId;
	}
}
