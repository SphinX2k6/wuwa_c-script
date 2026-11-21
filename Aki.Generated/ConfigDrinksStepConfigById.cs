using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000246 RID: 582
	public class ConfigDrinksStepConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DA8 RID: 3496 RVA: 0x000AA538 File Offset: 0x000A8738
		static ConfigDrinksStepConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksStepConfigById.CreateStaticDefaultValue), new Action(ConfigDrinksStepConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000AA558 File Offset: 0x000A8758
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksStepConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksStepConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksStepConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksStepConfig` where Id=?")
			});
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000AA5D7 File Offset: 0x000A87D7
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksStepConfigById.LogPair = null;
			ConfigDrinksStepConfigById.HandleId = 0;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000AA5E5 File Offset: 0x000A87E5
		public static void Init()
		{
			ConfigDrinksStepConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksStepConfigById.HandleId, "db_drinks.db", "select BinData from `DrinksStepConfig` where Id=?");
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000AA600 File Offset: 0x000A8800
		public static DrinksStepConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksStepConfigById.HandleId, ConfigDrinksStepConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksStepConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksStepConfig?(DrinksStepConfig.GetRootAsDrinksStepConfig(configBuffer));
				}
			}
			ConfigDrinksStepConfigById.LogPair.Clear();
			ConfigDrinksStepConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksStepConfigById.HandleId, 1, p0Id, ConfigDrinksStepConfigById.LogPair) || ConfigCommon.Step(ConfigDrinksStepConfigById.HandleId, true, ConfigDrinksStepConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksStepConfigById.HandleId, ConfigDrinksStepConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksStepConfigById.HandleId, 0, ConfigDrinksStepConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksStepConfigById.HandleId, ConfigDrinksStepConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksStepConfig rootAsDrinksStepConfig = DrinksStepConfig.GetRootAsDrinksStepConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksStepConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksStepConfigById.HandleId, ConfigDrinksStepConfigById.LogPair);
			return new DrinksStepConfig?(rootAsDrinksStepConfig);
		}

		// Token: 0x04000FCE RID: 4046
		private const string DB = "db_drinks.db";

		// Token: 0x04000FCF RID: 4047
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000FD0 RID: 4048
		private const string TABLE = "DrinksStepConfig";

		// Token: 0x04000FD1 RID: 4049
		private const string COMMAND = "select BinData from `DrinksStepConfig` where Id=?";

		// Token: 0x04000FD2 RID: 4050
		private const string KEY_PREFIX = "DrinksStepConfigById";

		// Token: 0x04000FD3 RID: 4051
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FD4 RID: 4052
		private static int HandleId;
	}
}
