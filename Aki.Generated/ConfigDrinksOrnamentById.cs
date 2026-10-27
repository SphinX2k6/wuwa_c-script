using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022D RID: 557
	public class ConfigDrinksOrnamentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D12 RID: 3346 RVA: 0x000A36CB File Offset: 0x000A18CB
		static ConfigDrinksOrnamentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksOrnamentById.CreateStaticDefaultValue), new Action(ConfigDrinksOrnamentById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x000A36EC File Offset: 0x000A18EC
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksOrnamentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksOrnamentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksOrnament"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksOrnament` where Id=?")
			});
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000A376B File Offset: 0x000A196B
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksOrnamentById.LogPair = null;
			ConfigDrinksOrnamentById.HandleId = 0;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000A3779 File Offset: 0x000A1979
		public static void Init()
		{
			ConfigDrinksOrnamentById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksOrnamentById.HandleId, "db_drinks.db", "select BinData from `DrinksOrnament` where Id=?");
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000A3794 File Offset: 0x000A1994
		public static DrinksOrnament? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksOrnamentById.HandleId, ConfigDrinksOrnamentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksOrnamentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksOrnament?(DrinksOrnament.GetRootAsDrinksOrnament(configBuffer));
				}
			}
			ConfigDrinksOrnamentById.LogPair.Clear();
			ConfigDrinksOrnamentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksOrnamentById.HandleId, 1, p0Id, ConfigDrinksOrnamentById.LogPair) || ConfigCommon.Step(ConfigDrinksOrnamentById.HandleId, true, ConfigDrinksOrnamentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksOrnamentById.HandleId, ConfigDrinksOrnamentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksOrnamentById.HandleId, 0, ConfigDrinksOrnamentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksOrnamentById.HandleId, ConfigDrinksOrnamentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksOrnament rootAsDrinksOrnament = DrinksOrnament.GetRootAsDrinksOrnament(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksOrnamentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksOrnamentById.HandleId, ConfigDrinksOrnamentById.LogPair);
			return new DrinksOrnament?(rootAsDrinksOrnament);
		}

		// Token: 0x04000F1F RID: 3871
		private const string DB = "db_drinks.db";

		// Token: 0x04000F20 RID: 3872
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F21 RID: 3873
		private const string TABLE = "DrinksOrnament";

		// Token: 0x04000F22 RID: 3874
		private const string COMMAND = "select BinData from `DrinksOrnament` where Id=?";

		// Token: 0x04000F23 RID: 3875
		private const string KEY_PREFIX = "DrinksOrnamentById";

		// Token: 0x04000F24 RID: 3876
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F25 RID: 3877
		private static int HandleId;
	}
}
