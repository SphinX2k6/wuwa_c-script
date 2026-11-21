using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000240 RID: 576
	public class ConfigDrinksParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D84 RID: 3460 RVA: 0x000A984C File Offset: 0x000A7A4C
		static ConfigDrinksParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksParamById.CreateStaticDefaultValue), new Action(ConfigDrinksParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x000A986C File Offset: 0x000A7A6C
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

		// Token: 0x06000D86 RID: 3462 RVA: 0x000A98EB File Offset: 0x000A7AEB
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksParamById.LogPair = null;
			ConfigDrinksParamById.HandleId = 0;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x000A98F9 File Offset: 0x000A7AF9
		public static void Init()
		{
			ConfigDrinksParamById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksParamById.HandleId, "db_drinks.db", "select BinData from `DrinksParam` where Id=?");
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x000A9914 File Offset: 0x000A7B14
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

		// Token: 0x04000FA4 RID: 4004
		private const string DB = "db_drinks.db";

		// Token: 0x04000FA5 RID: 4005
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000FA6 RID: 4006
		private const string TABLE = "DrinksParam";

		// Token: 0x04000FA7 RID: 4007
		private const string COMMAND = "select BinData from `DrinksParam` where Id=?";

		// Token: 0x04000FA8 RID: 4008
		private const string KEY_PREFIX = "DrinksParamById";

		// Token: 0x04000FA9 RID: 4009
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FAA RID: 4010
		private static int HandleId;
	}
}
