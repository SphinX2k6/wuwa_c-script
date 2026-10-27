using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000620 RID: 1568
	public class ConfigObservatoryByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024D0 RID: 9424 RVA: 0x00129CB7 File Offset: 0x00127EB7
		static ConfigObservatoryByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigObservatoryByAreaId.CreateStaticDefaultValue), new Action(ConfigObservatoryByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00129CD8 File Offset: 0x00127ED8
		public static void CreateStaticDefaultValue()
		{
			ConfigObservatoryByAreaId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigObservatoryByAreaId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weather.db"),
				new ValueTuple<string, object>("文件", "t.天气系统.xlsx"),
				new ValueTuple<string, object>("表名", "Observatory"),
				new ValueTuple<string, object>("语句", "select BinData from `Observatory` where AreaId=?")
			});
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00129D57 File Offset: 0x00127F57
		public static void ResetStaticDefaultValue()
		{
			ConfigObservatoryByAreaId.LogPair = null;
			ConfigObservatoryByAreaId.HandleId = 0;
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00129D65 File Offset: 0x00127F65
		public static void Init()
		{
			ConfigObservatoryByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigObservatoryByAreaId.HandleId, "db_weather.db", "select BinData from `Observatory` where AreaId=?");
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00129D80 File Offset: 0x00127F80
		public static Observatory? GetConfig(int p0AreaId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigObservatoryByAreaId.HandleId, ConfigObservatoryByAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ObservatoryByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Observatory?(Observatory.GetRootAsObservatory(configBuffer));
				}
			}
			ConfigObservatoryByAreaId.LogPair.Clear();
			ConfigObservatoryByAreaId.LogPair.Add(new ValueTuple<string, object>("AreaId", p0AreaId));
			if (!ConfigCommon.BindInt(ConfigObservatoryByAreaId.HandleId, 1, p0AreaId, ConfigObservatoryByAreaId.LogPair) || ConfigCommon.Step(ConfigObservatoryByAreaId.HandleId, true, ConfigObservatoryByAreaId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigObservatoryByAreaId.HandleId, ConfigObservatoryByAreaId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigObservatoryByAreaId.HandleId, 0, ConfigObservatoryByAreaId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigObservatoryByAreaId.HandleId, ConfigObservatoryByAreaId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Observatory rootAsObservatory = Observatory.GetRootAsObservatory(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ObservatoryByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigObservatoryByAreaId.HandleId, ConfigObservatoryByAreaId.LogPair);
			return new Observatory?(rootAsObservatory);
		}

		// Token: 0x04002AC6 RID: 10950
		private const string DB = "db_weather.db";

		// Token: 0x04002AC7 RID: 10951
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x04002AC8 RID: 10952
		private const string TABLE = "Observatory";

		// Token: 0x04002AC9 RID: 10953
		private const string COMMAND = "select BinData from `Observatory` where AreaId=?";

		// Token: 0x04002ACA RID: 10954
		private const string KEY_PREFIX = "ObservatoryByAreaId";

		// Token: 0x04002ACB RID: 10955
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ACC RID: 10956
		private static int HandleId;
	}
}
