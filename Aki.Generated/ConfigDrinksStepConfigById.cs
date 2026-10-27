using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000234 RID: 564
	public class ConfigDrinksStepConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D3C RID: 3388 RVA: 0x000A4600 File Offset: 0x000A2800
		static ConfigDrinksStepConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksStepConfigById.CreateStaticDefaultValue), new Action(ConfigDrinksStepConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x000A4620 File Offset: 0x000A2820
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

		// Token: 0x06000D3E RID: 3390 RVA: 0x000A469F File Offset: 0x000A289F
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksStepConfigById.LogPair = null;
			ConfigDrinksStepConfigById.HandleId = 0;
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x000A46AD File Offset: 0x000A28AD
		public static void Init()
		{
			ConfigDrinksStepConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksStepConfigById.HandleId, "db_drinks.db", "select BinData from `DrinksStepConfig` where Id=?");
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x000A46C8 File Offset: 0x000A28C8
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

		// Token: 0x04000F50 RID: 3920
		private const string DB = "db_drinks.db";

		// Token: 0x04000F51 RID: 3921
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F52 RID: 3922
		private const string TABLE = "DrinksStepConfig";

		// Token: 0x04000F53 RID: 3923
		private const string COMMAND = "select BinData from `DrinksStepConfig` where Id=?";

		// Token: 0x04000F54 RID: 3924
		private const string KEY_PREFIX = "DrinksStepConfigById";

		// Token: 0x04000F55 RID: 3925
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F56 RID: 3926
		private static int HandleId;
	}
}
