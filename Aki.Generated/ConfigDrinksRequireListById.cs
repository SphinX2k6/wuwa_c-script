using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000241 RID: 577
	public class ConfigDrinksRequireListById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D8A RID: 3466 RVA: 0x000A9A94 File Offset: 0x000A7C94
		static ConfigDrinksRequireListById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksRequireListById.CreateStaticDefaultValue), new Action(ConfigDrinksRequireListById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x000A9AB4 File Offset: 0x000A7CB4
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksRequireListById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksRequireListById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksRequireList"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksRequireList` where Id=?")
			});
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000A9B33 File Offset: 0x000A7D33
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksRequireListById.LogPair = null;
			ConfigDrinksRequireListById.HandleId = 0;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000A9B41 File Offset: 0x000A7D41
		public static void Init()
		{
			ConfigDrinksRequireListById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksRequireListById.HandleId, "db_drinks.db", "select BinData from `DrinksRequireList` where Id=?");
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000A9B5C File Offset: 0x000A7D5C
		public static DrinksRequireList? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksRequireListById.HandleId, ConfigDrinksRequireListById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksRequireListById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksRequireList?(DrinksRequireList.GetRootAsDrinksRequireList(configBuffer));
				}
			}
			ConfigDrinksRequireListById.LogPair.Clear();
			ConfigDrinksRequireListById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksRequireListById.HandleId, 1, p0Id, ConfigDrinksRequireListById.LogPair) || ConfigCommon.Step(ConfigDrinksRequireListById.HandleId, true, ConfigDrinksRequireListById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksRequireListById.HandleId, ConfigDrinksRequireListById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksRequireListById.HandleId, 0, ConfigDrinksRequireListById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksRequireListById.HandleId, ConfigDrinksRequireListById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksRequireList rootAsDrinksRequireList = DrinksRequireList.GetRootAsDrinksRequireList(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksRequireListById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksRequireListById.HandleId, ConfigDrinksRequireListById.LogPair);
			return new DrinksRequireList?(rootAsDrinksRequireList);
		}

		// Token: 0x04000FAB RID: 4011
		private const string DB = "db_drinks.db";

		// Token: 0x04000FAC RID: 4012
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000FAD RID: 4013
		private const string TABLE = "DrinksRequireList";

		// Token: 0x04000FAE RID: 4014
		private const string COMMAND = "select BinData from `DrinksRequireList` where Id=?";

		// Token: 0x04000FAF RID: 4015
		private const string KEY_PREFIX = "DrinksRequireListById";

		// Token: 0x04000FB0 RID: 4016
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FB1 RID: 4017
		private static int HandleId;
	}
}
