using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000097 RID: 151
	public class ConfigAnimalHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600038A RID: 906 RVA: 0x0006D93B File Offset: 0x0006BB3B
		static ConfigAnimalHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnimalHandBookById.CreateStaticDefaultValue), new Action(ConfigAnimalHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0006D95C File Offset: 0x0006BB5C
		public static void CreateStaticDefaultValue()
		{
			ConfigAnimalHandBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAnimalHandBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "AnimalHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `AnimalHandBook` where Id=?")
			});
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0006D9DB File Offset: 0x0006BBDB
		public static void ResetStaticDefaultValue()
		{
			ConfigAnimalHandBookById.LogPair = null;
			ConfigAnimalHandBookById.HandleId = 0;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0006D9E9 File Offset: 0x0006BBE9
		public static void Init()
		{
			ConfigAnimalHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigAnimalHandBookById.HandleId, "db_handbook.db", "select BinData from `AnimalHandBook` where Id=?");
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0006DA04 File Offset: 0x0006BC04
		public static AnimalHandBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAnimalHandBookById.HandleId, ConfigAnimalHandBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AnimalHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AnimalHandBook?(AnimalHandBook.GetRootAsAnimalHandBook(configBuffer));
				}
			}
			ConfigAnimalHandBookById.LogPair.Clear();
			ConfigAnimalHandBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAnimalHandBookById.HandleId, 1, p0Id, ConfigAnimalHandBookById.LogPair) || ConfigCommon.Step(ConfigAnimalHandBookById.HandleId, true, ConfigAnimalHandBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAnimalHandBookById.HandleId, ConfigAnimalHandBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAnimalHandBookById.HandleId, 0, ConfigAnimalHandBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAnimalHandBookById.HandleId, ConfigAnimalHandBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AnimalHandBook rootAsAnimalHandBook = AnimalHandBook.GetRootAsAnimalHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AnimalHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAnimalHandBookById.HandleId, ConfigAnimalHandBookById.LogPair);
			return new AnimalHandBook?(rootAsAnimalHandBook);
		}

		// Token: 0x04000405 RID: 1029
		private const string DB = "db_handbook.db";

		// Token: 0x04000406 RID: 1030
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04000407 RID: 1031
		private const string TABLE = "AnimalHandBook";

		// Token: 0x04000408 RID: 1032
		private const string COMMAND = "select BinData from `AnimalHandBook` where Id=?";

		// Token: 0x04000409 RID: 1033
		private const string KEY_PREFIX = "AnimalHandBookById";

		// Token: 0x0400040A RID: 1034
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400040B RID: 1035
		private static int HandleId;
	}
}
