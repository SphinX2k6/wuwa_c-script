using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000211 RID: 529
	public class ConfigDetectionDropDownTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C69 RID: 3177 RVA: 0x000A35B0 File Offset: 0x000A17B0
		static ConfigDetectionDropDownTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDetectionDropDownTypeById.CreateStaticDefaultValue), new Action(ConfigDetectionDropDownTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000A35D0 File Offset: 0x000A17D0
		public static void CreateStaticDefaultValue()
		{
			ConfigDetectionDropDownTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDetectionDropDownTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "DetectionDropDownType"),
				new ValueTuple<string, object>("语句", "select BinData from `DetectionDropDownType` where Id=?")
			});
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x000A364F File Offset: 0x000A184F
		public static void ResetStaticDefaultValue()
		{
			ConfigDetectionDropDownTypeById.LogPair = null;
			ConfigDetectionDropDownTypeById.HandleId = 0;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000A365D File Offset: 0x000A185D
		public static void Init()
		{
			ConfigDetectionDropDownTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigDetectionDropDownTypeById.HandleId, "db_adventure_detect.db", "select BinData from `DetectionDropDownType` where Id=?");
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000A3678 File Offset: 0x000A1878
		public static DetectionDropDownType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDetectionDropDownTypeById.HandleId, ConfigDetectionDropDownTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DetectionDropDownTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DetectionDropDownType?(DetectionDropDownType.GetRootAsDetectionDropDownType(configBuffer));
				}
			}
			ConfigDetectionDropDownTypeById.LogPair.Clear();
			ConfigDetectionDropDownTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDetectionDropDownTypeById.HandleId, 1, p0Id, ConfigDetectionDropDownTypeById.LogPair) || ConfigCommon.Step(ConfigDetectionDropDownTypeById.HandleId, true, ConfigDetectionDropDownTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDetectionDropDownTypeById.HandleId, ConfigDetectionDropDownTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDetectionDropDownTypeById.HandleId, 0, ConfigDetectionDropDownTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDetectionDropDownTypeById.HandleId, ConfigDetectionDropDownTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DetectionDropDownType rootAsDetectionDropDownType = DetectionDropDownType.GetRootAsDetectionDropDownType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DetectionDropDownTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDetectionDropDownTypeById.HandleId, ConfigDetectionDropDownTypeById.LogPair);
			return new DetectionDropDownType?(rootAsDetectionDropDownType);
		}

		// Token: 0x04000E5B RID: 3675
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000E5C RID: 3676
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000E5D RID: 3677
		private const string TABLE = "DetectionDropDownType";

		// Token: 0x04000E5E RID: 3678
		private const string COMMAND = "select BinData from `DetectionDropDownType` where Id=?";

		// Token: 0x04000E5F RID: 3679
		private const string KEY_PREFIX = "DetectionDropDownTypeById";

		// Token: 0x04000E60 RID: 3680
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E61 RID: 3681
		private static int HandleId;
	}
}
