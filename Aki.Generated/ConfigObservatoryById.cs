using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000639 RID: 1593
	public class ConfigObservatoryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002566 RID: 9574 RVA: 0x0013097C File Offset: 0x0012EB7C
		static ConfigObservatoryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigObservatoryById.CreateStaticDefaultValue), new Action(ConfigObservatoryById.ResetStaticDefaultValue));
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0013099C File Offset: 0x0012EB9C
		public static void CreateStaticDefaultValue()
		{
			ConfigObservatoryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigObservatoryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weather.db"),
				new ValueTuple<string, object>("文件", "t.天气系统.xlsx"),
				new ValueTuple<string, object>("表名", "Observatory"),
				new ValueTuple<string, object>("语句", "select BinData from `Observatory` where Id=?")
			});
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x00130A1B File Offset: 0x0012EC1B
		public static void ResetStaticDefaultValue()
		{
			ConfigObservatoryById.LogPair = null;
			ConfigObservatoryById.HandleId = 0;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00130A29 File Offset: 0x0012EC29
		public static void Init()
		{
			ConfigObservatoryById.HandleId = ConfigCommon.InitDataStatement(ConfigObservatoryById.HandleId, "db_weather.db", "select BinData from `Observatory` where Id=?");
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00130A44 File Offset: 0x0012EC44
		public static Observatory? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigObservatoryById.HandleId, ConfigObservatoryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ObservatoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Observatory?(Observatory.GetRootAsObservatory(configBuffer));
				}
			}
			ConfigObservatoryById.LogPair.Clear();
			ConfigObservatoryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigObservatoryById.HandleId, 1, p0Id, ConfigObservatoryById.LogPair) || ConfigCommon.Step(ConfigObservatoryById.HandleId, true, ConfigObservatoryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigObservatoryById.HandleId, ConfigObservatoryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigObservatoryById.HandleId, 0, ConfigObservatoryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigObservatoryById.HandleId, ConfigObservatoryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Observatory rootAsObservatory = Observatory.GetRootAsObservatory(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ObservatoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigObservatoryById.HandleId, ConfigObservatoryById.LogPair);
			return new Observatory?(rootAsObservatory);
		}

		// Token: 0x04002B75 RID: 11125
		private const string DB = "db_weather.db";

		// Token: 0x04002B76 RID: 11126
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x04002B77 RID: 11127
		private const string TABLE = "Observatory";

		// Token: 0x04002B78 RID: 11128
		private const string COMMAND = "select BinData from `Observatory` where Id=?";

		// Token: 0x04002B79 RID: 11129
		private const string KEY_PREFIX = "ObservatoryById";

		// Token: 0x04002B7A RID: 11130
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B7B RID: 11131
		private static int HandleId;
	}
}
