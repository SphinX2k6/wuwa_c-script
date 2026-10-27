using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022F RID: 559
	public class ConfigDrinksRequireListById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D1E RID: 3358 RVA: 0x000A3B5C File Offset: 0x000A1D5C
		static ConfigDrinksRequireListById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksRequireListById.CreateStaticDefaultValue), new Action(ConfigDrinksRequireListById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x000A3B7C File Offset: 0x000A1D7C
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

		// Token: 0x06000D20 RID: 3360 RVA: 0x000A3BFB File Offset: 0x000A1DFB
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksRequireListById.LogPair = null;
			ConfigDrinksRequireListById.HandleId = 0;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000A3C09 File Offset: 0x000A1E09
		public static void Init()
		{
			ConfigDrinksRequireListById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksRequireListById.HandleId, "db_drinks.db", "select BinData from `DrinksRequireList` where Id=?");
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x000A3C24 File Offset: 0x000A1E24
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

		// Token: 0x04000F2D RID: 3885
		private const string DB = "db_drinks.db";

		// Token: 0x04000F2E RID: 3886
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F2F RID: 3887
		private const string TABLE = "DrinksRequireList";

		// Token: 0x04000F30 RID: 3888
		private const string COMMAND = "select BinData from `DrinksRequireList` where Id=?";

		// Token: 0x04000F31 RID: 3889
		private const string KEY_PREFIX = "DrinksRequireListById";

		// Token: 0x04000F32 RID: 3890
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F33 RID: 3891
		private static int HandleId;
	}
}
