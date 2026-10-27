using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000615 RID: 1557
	public class ConfigNounHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600248E RID: 9358 RVA: 0x0012843B File Offset: 0x0012663B
		static ConfigNounHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNounHandBookById.CreateStaticDefaultValue), new Action(ConfigNounHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0012845C File Offset: 0x0012665C
		public static void CreateStaticDefaultValue()
		{
			ConfigNounHandBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNounHandBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "NounHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `NounHandBook` where Id=?")
			});
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x001284DB File Offset: 0x001266DB
		public static void ResetStaticDefaultValue()
		{
			ConfigNounHandBookById.LogPair = null;
			ConfigNounHandBookById.HandleId = 0;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x001284E9 File Offset: 0x001266E9
		public static void Init()
		{
			ConfigNounHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigNounHandBookById.HandleId, "db_handbook.db", "select BinData from `NounHandBook` where Id=?");
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00128504 File Offset: 0x00126704
		public static NounHandBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNounHandBookById.HandleId, ConfigNounHandBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NounHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NounHandBook?(NounHandBook.GetRootAsNounHandBook(configBuffer));
				}
			}
			ConfigNounHandBookById.LogPair.Clear();
			ConfigNounHandBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNounHandBookById.HandleId, 1, p0Id, ConfigNounHandBookById.LogPair) || ConfigCommon.Step(ConfigNounHandBookById.HandleId, true, ConfigNounHandBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNounHandBookById.HandleId, ConfigNounHandBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNounHandBookById.HandleId, 0, ConfigNounHandBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNounHandBookById.HandleId, ConfigNounHandBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NounHandBook rootAsNounHandBook = NounHandBook.GetRootAsNounHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NounHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNounHandBookById.HandleId, ConfigNounHandBookById.LogPair);
			return new NounHandBook?(rootAsNounHandBook);
		}

		// Token: 0x04002A79 RID: 10873
		private const string DB = "db_handbook.db";

		// Token: 0x04002A7A RID: 10874
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002A7B RID: 10875
		private const string TABLE = "NounHandBook";

		// Token: 0x04002A7C RID: 10876
		private const string COMMAND = "select BinData from `NounHandBook` where Id=?";

		// Token: 0x04002A7D RID: 10877
		private const string KEY_PREFIX = "NounHandBookById";

		// Token: 0x04002A7E RID: 10878
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A7F RID: 10879
		private static int HandleId;
	}
}
