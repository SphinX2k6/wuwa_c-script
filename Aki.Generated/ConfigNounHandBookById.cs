using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062D RID: 1581
	public class ConfigNounHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600251E RID: 9502 RVA: 0x0012EEB7 File Offset: 0x0012D0B7
		static ConfigNounHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNounHandBookById.CreateStaticDefaultValue), new Action(ConfigNounHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0012EED8 File Offset: 0x0012D0D8
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

		// Token: 0x06002520 RID: 9504 RVA: 0x0012EF57 File Offset: 0x0012D157
		public static void ResetStaticDefaultValue()
		{
			ConfigNounHandBookById.LogPair = null;
			ConfigNounHandBookById.HandleId = 0;
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x0012EF65 File Offset: 0x0012D165
		public static void Init()
		{
			ConfigNounHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigNounHandBookById.HandleId, "db_handbook.db", "select BinData from `NounHandBook` where Id=?");
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x0012EF80 File Offset: 0x0012D180
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

		// Token: 0x04002B21 RID: 11041
		private const string DB = "db_handbook.db";

		// Token: 0x04002B22 RID: 11042
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002B23 RID: 11043
		private const string TABLE = "NounHandBook";

		// Token: 0x04002B24 RID: 11044
		private const string COMMAND = "select BinData from `NounHandBook` where Id=?";

		// Token: 0x04002B25 RID: 11045
		private const string KEY_PREFIX = "NounHandBookById";

		// Token: 0x04002B26 RID: 11046
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B27 RID: 11047
		private static int HandleId;
	}
}
