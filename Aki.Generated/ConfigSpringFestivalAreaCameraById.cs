using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000978 RID: 2424
	public class ConfigSpringFestivalAreaCameraById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038E4 RID: 14564 RVA: 0x0019B348 File Offset: 0x00199548
		static ConfigSpringFestivalAreaCameraById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAreaCameraById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAreaCameraById.ResetStaticDefaultValue));
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x0019B368 File Offset: 0x00199568
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

		// Token: 0x060038E6 RID: 14566 RVA: 0x0019B3E7 File Offset: 0x001995E7
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAreaCameraById.LogPair = null;
			ConfigSpringFestivalAreaCameraById.HandleId = 0;
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0019B3F5 File Offset: 0x001995F5
		public static void Init()
		{
			ConfigSpringFestivalAreaCameraById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAreaCameraById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalAreaCamera` where Id=?");
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0019B410 File Offset: 0x00199610
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

		// Token: 0x0400422E RID: 16942
		private const string DB = "db_spring26.db";

		// Token: 0x0400422F RID: 16943
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004230 RID: 16944
		private const string TABLE = "SpringFestivalAreaCamera";

		// Token: 0x04004231 RID: 16945
		private const string COMMAND = "select BinData from `SpringFestivalAreaCamera` where Id=?";

		// Token: 0x04004232 RID: 16946
		private const string KEY_PREFIX = "SpringFestivalAreaCameraById";

		// Token: 0x04004233 RID: 16947
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004234 RID: 16948
		private static int HandleId;
	}
}
