using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000458 RID: 1112
	public class ConfigItemHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A1A RID: 6682 RVA: 0x000ED013 File Offset: 0x000EB213
		static ConfigItemHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemHandBookById.CreateStaticDefaultValue), new Action(ConfigItemHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x000ED034 File Offset: 0x000EB234
		public static void CreateStaticDefaultValue()
		{
			ConfigItemHandBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemHandBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ItemHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemHandBook` where Id=?")
			});
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x000ED0B3 File Offset: 0x000EB2B3
		public static void ResetStaticDefaultValue()
		{
			ConfigItemHandBookById.LogPair = null;
			ConfigItemHandBookById.HandleId = 0;
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000ED0C1 File Offset: 0x000EB2C1
		public static void Init()
		{
			ConfigItemHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigItemHandBookById.HandleId, "db_handbook.db", "select BinData from `ItemHandBook` where Id=?");
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000ED0DC File Offset: 0x000EB2DC
		public static ItemHandBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemHandBookById.HandleId, ConfigItemHandBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemHandBook?(ItemHandBook.GetRootAsItemHandBook(configBuffer));
				}
			}
			ConfigItemHandBookById.LogPair.Clear();
			ConfigItemHandBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigItemHandBookById.HandleId, 1, p0Id, ConfigItemHandBookById.LogPair) || ConfigCommon.Step(ConfigItemHandBookById.HandleId, true, ConfigItemHandBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemHandBookById.HandleId, ConfigItemHandBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemHandBookById.HandleId, 0, ConfigItemHandBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemHandBookById.HandleId, ConfigItemHandBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemHandBook rootAsItemHandBook = ItemHandBook.GetRootAsItemHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemHandBookById.HandleId, ConfigItemHandBookById.LogPair);
			return new ItemHandBook?(rootAsItemHandBook);
		}

		// Token: 0x04001E4C RID: 7756
		private const string DB = "db_handbook.db";

		// Token: 0x04001E4D RID: 7757
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001E4E RID: 7758
		private const string TABLE = "ItemHandBook";

		// Token: 0x04001E4F RID: 7759
		private const string COMMAND = "select BinData from `ItemHandBook` where Id=?";

		// Token: 0x04001E50 RID: 7760
		private const string KEY_PREFIX = "ItemHandBookById";

		// Token: 0x04001E51 RID: 7761
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E52 RID: 7762
		private static int HandleId;
	}
}
