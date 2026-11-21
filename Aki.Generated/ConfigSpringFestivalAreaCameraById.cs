using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4D RID: 2637
	public class ConfigSpringFestivalAreaCameraById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DE2 RID: 15842 RVA: 0x001BA6DC File Offset: 0x001B88DC
		static ConfigSpringFestivalAreaCameraById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAreaCameraById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAreaCameraById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x001BA6FC File Offset: 0x001B88FC
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalAreaCameraById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalAreaCameraById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalAreaCamera"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalAreaCamera` where Id=?")
			});
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x001BA77B File Offset: 0x001B897B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAreaCameraById.LogPair = null;
			ConfigSpringFestivalAreaCameraById.HandleId = 0;
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x001BA789 File Offset: 0x001B8989
		public static void Init()
		{
			ConfigSpringFestivalAreaCameraById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAreaCameraById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalAreaCamera` where Id=?");
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x001BA7A4 File Offset: 0x001B89A4
		public static SpringFestivalAreaCamera? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalAreaCameraById.HandleId, ConfigSpringFestivalAreaCameraById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalAreaCameraById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalAreaCamera?(SpringFestivalAreaCamera.GetRootAsSpringFestivalAreaCamera(configBuffer));
				}
			}
			ConfigSpringFestivalAreaCameraById.LogPair.Clear();
			ConfigSpringFestivalAreaCameraById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalAreaCameraById.HandleId, 1, p0Id, ConfigSpringFestivalAreaCameraById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalAreaCameraById.HandleId, true, ConfigSpringFestivalAreaCameraById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalAreaCameraById.HandleId, ConfigSpringFestivalAreaCameraById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalAreaCameraById.HandleId, 0, ConfigSpringFestivalAreaCameraById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalAreaCameraById.HandleId, ConfigSpringFestivalAreaCameraById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalAreaCamera rootAsSpringFestivalAreaCamera = SpringFestivalAreaCamera.GetRootAsSpringFestivalAreaCamera(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalAreaCameraById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalAreaCameraById.HandleId, ConfigSpringFestivalAreaCameraById.LogPair);
			return new SpringFestivalAreaCamera?(rootAsSpringFestivalAreaCamera);
		}

		// Token: 0x04004801 RID: 18433
		private const string DB = "db_spring26.db";

		// Token: 0x04004802 RID: 18434
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004803 RID: 18435
		private const string TABLE = "SpringFestivalAreaCamera";

		// Token: 0x04004804 RID: 18436
		private const string COMMAND = "select BinData from `SpringFestivalAreaCamera` where Id=?";

		// Token: 0x04004805 RID: 18437
		private const string KEY_PREFIX = "SpringFestivalAreaCameraById";

		// Token: 0x04004806 RID: 18438
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004807 RID: 18439
		private static int HandleId;
	}
}
