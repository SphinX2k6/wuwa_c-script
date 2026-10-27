using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FF RID: 511
	public class ConfigDetectionDropDownTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BFD RID: 3069 RVA: 0x0009D678 File Offset: 0x0009B878
		static ConfigDetectionDropDownTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDetectionDropDownTypeById.CreateStaticDefaultValue), new Action(ConfigDetectionDropDownTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0009D698 File Offset: 0x0009B898
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

		// Token: 0x06000BFF RID: 3071 RVA: 0x0009D717 File Offset: 0x0009B917
		public static void ResetStaticDefaultValue()
		{
			ConfigDetectionDropDownTypeById.LogPair = null;
			ConfigDetectionDropDownTypeById.HandleId = 0;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0009D725 File Offset: 0x0009B925
		public static void Init()
		{
			ConfigDetectionDropDownTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigDetectionDropDownTypeById.HandleId, "db_adventure_detect.db", "select BinData from `DetectionDropDownType` where Id=?");
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0009D740 File Offset: 0x0009B940
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

		// Token: 0x04000DDD RID: 3549
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000DDE RID: 3550
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000DDF RID: 3551
		private const string TABLE = "DetectionDropDownType";

		// Token: 0x04000DE0 RID: 3552
		private const string COMMAND = "select BinData from `DetectionDropDownType` where Id=?";

		// Token: 0x04000DE1 RID: 3553
		private const string KEY_PREFIX = "DetectionDropDownTypeById";

		// Token: 0x04000DE2 RID: 3554
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DE3 RID: 3555
		private static int HandleId;
	}
}
