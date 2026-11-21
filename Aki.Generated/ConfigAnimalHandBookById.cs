using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009F RID: 159
	public class ConfigAnimalHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003BA RID: 954 RVA: 0x000721EF File Offset: 0x000703EF
		static ConfigAnimalHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnimalHandBookById.CreateStaticDefaultValue), new Action(ConfigAnimalHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00072210 File Offset: 0x00070410
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

		// Token: 0x060003BC RID: 956 RVA: 0x0007228F File Offset: 0x0007048F
		public static void ResetStaticDefaultValue()
		{
			ConfigAnimalHandBookById.LogPair = null;
			ConfigAnimalHandBookById.HandleId = 0;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0007229D File Offset: 0x0007049D
		public static void Init()
		{
			ConfigAnimalHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigAnimalHandBookById.HandleId, "db_handbook.db", "select BinData from `AnimalHandBook` where Id=?");
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000722B8 File Offset: 0x000704B8
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

		// Token: 0x0400043D RID: 1085
		private const string DB = "db_handbook.db";

		// Token: 0x0400043E RID: 1086
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400043F RID: 1087
		private const string TABLE = "AnimalHandBook";

		// Token: 0x04000440 RID: 1088
		private const string COMMAND = "select BinData from `AnimalHandBook` where Id=?";

		// Token: 0x04000441 RID: 1089
		private const string KEY_PREFIX = "AnimalHandBookById";

		// Token: 0x04000442 RID: 1090
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000443 RID: 1091
		private static int HandleId;
	}
}
