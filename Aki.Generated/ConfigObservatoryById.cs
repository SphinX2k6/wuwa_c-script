using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000621 RID: 1569
	public class ConfigObservatoryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024D6 RID: 9430 RVA: 0x00129F00 File Offset: 0x00128100
		static ConfigObservatoryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigObservatoryById.CreateStaticDefaultValue), new Action(ConfigObservatoryById.ResetStaticDefaultValue));
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00129F20 File Offset: 0x00128120
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

		// Token: 0x060024D8 RID: 9432 RVA: 0x00129F9F File Offset: 0x0012819F
		public static void ResetStaticDefaultValue()
		{
			ConfigObservatoryById.LogPair = null;
			ConfigObservatoryById.HandleId = 0;
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00129FAD File Offset: 0x001281AD
		public static void Init()
		{
			ConfigObservatoryById.HandleId = ConfigCommon.InitDataStatement(ConfigObservatoryById.HandleId, "db_weather.db", "select BinData from `Observatory` where Id=?");
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00129FC8 File Offset: 0x001281C8
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

		// Token: 0x04002ACD RID: 10957
		private const string DB = "db_weather.db";

		// Token: 0x04002ACE RID: 10958
		private const string FILE = "t.天气系统.xlsx";

		// Token: 0x04002ACF RID: 10959
		private const string TABLE = "Observatory";

		// Token: 0x04002AD0 RID: 10960
		private const string COMMAND = "select BinData from `Observatory` where Id=?";

		// Token: 0x04002AD1 RID: 10961
		private const string KEY_PREFIX = "ObservatoryById";

		// Token: 0x04002AD2 RID: 10962
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AD3 RID: 10963
		private static int HandleId;
	}
}
