using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022E RID: 558
	public class ConfigDrinksParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D18 RID: 3352 RVA: 0x000A3914 File Offset: 0x000A1B14
		static ConfigDrinksParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksParamById.CreateStaticDefaultValue), new Action(ConfigDrinksParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000A3934 File Offset: 0x000A1B34
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksParam"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksParam` where Id=?")
			});
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000A39B3 File Offset: 0x000A1BB3
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksParamById.LogPair = null;
			ConfigDrinksParamById.HandleId = 0;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000A39C1 File Offset: 0x000A1BC1
		public static void Init()
		{
			ConfigDrinksParamById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksParamById.HandleId, "db_drinks.db", "select BinData from `DrinksParam` where Id=?");
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x000A39DC File Offset: 0x000A1BDC
		public static DrinksParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksParamById.HandleId, ConfigDrinksParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksParam?(DrinksParam.GetRootAsDrinksParam(configBuffer));
				}
			}
			ConfigDrinksParamById.LogPair.Clear();
			ConfigDrinksParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksParamById.HandleId, 1, p0Id, ConfigDrinksParamById.LogPair) || ConfigCommon.Step(ConfigDrinksParamById.HandleId, true, ConfigDrinksParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksParamById.HandleId, ConfigDrinksParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksParamById.HandleId, 0, ConfigDrinksParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksParamById.HandleId, ConfigDrinksParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksParam rootAsDrinksParam = DrinksParam.GetRootAsDrinksParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksParamById.HandleId, ConfigDrinksParamById.LogPair);
			return new DrinksParam?(rootAsDrinksParam);
		}

		// Token: 0x04000F26 RID: 3878
		private const string DB = "db_drinks.db";

		// Token: 0x04000F27 RID: 3879
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F28 RID: 3880
		private const string TABLE = "DrinksParam";

		// Token: 0x04000F29 RID: 3881
		private const string COMMAND = "select BinData from `DrinksParam` where Id=?";

		// Token: 0x04000F2A RID: 3882
		private const string KEY_PREFIX = "DrinksParamById";

		// Token: 0x04000F2B RID: 3883
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F2C RID: 3884
		private static int HandleId;
	}
}
