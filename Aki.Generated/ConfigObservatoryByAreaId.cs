using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000638 RID: 1592
	public class ConfigObservatoryByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002560 RID: 9568 RVA: 0x00130733 File Offset: 0x0012E933
		static ConfigObservatoryByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigObservatoryByAreaId.CreateStaticDefaultValue), new Action(ConfigObservatoryByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00130754 File Offset: 0x0012E954
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

		// Token: 0x06002562 RID: 9570 RVA: 0x001307D3 File Offset: 0x0012E9D3
		public static void ResetStaticDefaultValue()
		{
			ConfigObservatoryByAreaId.LogPair = null;
			ConfigObservatoryByAreaId.HandleId = 0;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x001307E1 File Offset: 0x0012E9E1
		public static void Init()
		{
			ConfigObservatoryByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigObservatoryByAreaId.HandleId, "db_weather.db", "select BinData from `Observatory` where AreaId=?");
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x001307FC File Offset: 0x0012E9FC
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

		// Token: 0x04002B6E RID: 11118
		private const string DB = "db_weather.db";

		// Token: 0x04002B6F RID: 11119
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x04002B70 RID: 11120
		private const string TABLE = "Observatory";

		// Token: 0x04002B71 RID: 11121
		private const string COMMAND = "select BinData from `Observatory` where AreaId=?";

		// Token: 0x04002B72 RID: 11122
		private const string KEY_PREFIX = "ObservatoryByAreaId";

		// Token: 0x04002B73 RID: 11123
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B74 RID: 11124
		private static int HandleId;
	}
}
