using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046E RID: 1134
	public class ConfigItemHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A9E RID: 6814 RVA: 0x000F3767 File Offset: 0x000F1967
		static ConfigItemHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemHandBookById.CreateStaticDefaultValue), new Action(ConfigItemHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x000F3788 File Offset: 0x000F1988
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

		// Token: 0x06001AA0 RID: 6816 RVA: 0x000F3807 File Offset: 0x000F1A07
		public static void ResetStaticDefaultValue()
		{
			ConfigItemHandBookById.LogPair = null;
			ConfigItemHandBookById.HandleId = 0;
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x000F3815 File Offset: 0x000F1A15
		public static void Init()
		{
			ConfigItemHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigItemHandBookById.HandleId, "db_handbook.db", "select BinData from `ItemHandBook` where Id=?");
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x000F3830 File Offset: 0x000F1A30
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

		// Token: 0x04001EE6 RID: 7910
		private const string DB = "db_handbook.db";

		// Token: 0x04001EE7 RID: 7911
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001EE8 RID: 7912
		private const string TABLE = "ItemHandBook";

		// Token: 0x04001EE9 RID: 7913
		private const string COMMAND = "select BinData from `ItemHandBook` where Id=?";

		// Token: 0x04001EEA RID: 7914
		private const string KEY_PREFIX = "ItemHandBookById";

		// Token: 0x04001EEB RID: 7915
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EEC RID: 7916
		private static int HandleId;
	}
}
