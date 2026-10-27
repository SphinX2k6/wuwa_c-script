using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000977 RID: 2423
	public class ConfigSpringFestivalAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038DE RID: 14558 RVA: 0x0019B0FF File Offset: 0x001992FF
		static ConfigSpringFestivalAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAreaById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0019B120 File Offset: 0x00199320
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalArea"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalArea` where Id=?")
			});
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x0019B19F File Offset: 0x0019939F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAreaById.LogPair = null;
			ConfigSpringFestivalAreaById.HandleId = 0;
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0019B1AD File Offset: 0x001993AD
		public static void Init()
		{
			ConfigSpringFestivalAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAreaById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalArea` where Id=?");
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0019B1C8 File Offset: 0x001993C8
		public static SpringFestivalArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalAreaById.HandleId, ConfigSpringFestivalAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalArea?(SpringFestivalArea.GetRootAsSpringFestivalArea(configBuffer));
				}
			}
			ConfigSpringFestivalAreaById.LogPair.Clear();
			ConfigSpringFestivalAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalAreaById.HandleId, 1, p0Id, ConfigSpringFestivalAreaById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalAreaById.HandleId, true, ConfigSpringFestivalAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalAreaById.HandleId, ConfigSpringFestivalAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalAreaById.HandleId, 0, ConfigSpringFestivalAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalAreaById.HandleId, ConfigSpringFestivalAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalArea rootAsSpringFestivalArea = SpringFestivalArea.GetRootAsSpringFestivalArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalAreaById.HandleId, ConfigSpringFestivalAreaById.LogPair);
			return new SpringFestivalArea?(rootAsSpringFestivalArea);
		}

		// Token: 0x04004227 RID: 16935
		private const string DB = "db_spring26.db";

		// Token: 0x04004228 RID: 16936
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004229 RID: 16937
		private const string TABLE = "SpringFestivalArea";

		// Token: 0x0400422A RID: 16938
		private const string COMMAND = "select BinData from `SpringFestivalArea` where Id=?";

		// Token: 0x0400422B RID: 16939
		private const string KEY_PREFIX = "SpringFestivalAreaById";

		// Token: 0x0400422C RID: 16940
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400422D RID: 16941
		private static int HandleId;
	}
}
