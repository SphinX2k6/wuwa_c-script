using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023F RID: 575
	public class ConfigDrinksOrnamentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D7E RID: 3454 RVA: 0x000A9603 File Offset: 0x000A7803
		static ConfigDrinksOrnamentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksOrnamentById.CreateStaticDefaultValue), new Action(ConfigDrinksOrnamentById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x000A9624 File Offset: 0x000A7824
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

		// Token: 0x06000D80 RID: 3456 RVA: 0x000A96A3 File Offset: 0x000A78A3
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksOrnamentById.LogPair = null;
			ConfigDrinksOrnamentById.HandleId = 0;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x000A96B1 File Offset: 0x000A78B1
		public static void Init()
		{
			ConfigDrinksOrnamentById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksOrnamentById.HandleId, "db_drinks.db", "select BinData from `DrinksOrnament` where Id=?");
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x000A96CC File Offset: 0x000A78CC
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

		// Token: 0x04000F9D RID: 3997
		private const string DB = "db_drinks.db";

		// Token: 0x04000F9E RID: 3998
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F9F RID: 3999
		private const string TABLE = "DrinksOrnament";

		// Token: 0x04000FA0 RID: 4000
		private const string COMMAND = "select BinData from `DrinksOrnament` where Id=?";

		// Token: 0x04000FA1 RID: 4001
		private const string KEY_PREFIX = "DrinksOrnamentById";

		// Token: 0x04000FA2 RID: 4002
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FA3 RID: 4003
		private static int HandleId;
	}
}
