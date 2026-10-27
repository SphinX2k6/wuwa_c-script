using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000104 RID: 260
	public class ConfigBookItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x0007C1E9 File Offset: 0x0007A3E9
		static ConfigBookItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBookItemById.CreateStaticDefaultValue), new Action(ConfigBookItemById.ResetStaticDefaultValue));
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0007C208 File Offset: 0x0007A408
		public static void CreateStaticDefaultValue()
		{
			ConfigBookItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBookItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_brochure.db"),
				new ValueTuple<string, object>("文件", "c.册子玩法.xlsx"),
				new ValueTuple<string, object>("表名", "BookItem"),
				new ValueTuple<string, object>("语句", "select BinData from `BookItem` where Id=?")
			});
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0007C287 File Offset: 0x0007A487
		public static void ResetStaticDefaultValue()
		{
			ConfigBookItemById.LogPair = null;
			ConfigBookItemById.HandleId = 0;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0007C295 File Offset: 0x0007A495
		public static void Init()
		{
			ConfigBookItemById.HandleId = ConfigCommon.InitDataStatement(ConfigBookItemById.HandleId, "db_brochure.db", "select BinData from `BookItem` where Id=?");
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0007C2B0 File Offset: 0x0007A4B0
		public static BookItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBookItemById.HandleId, ConfigBookItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BookItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BookItem?(BookItem.GetRootAsBookItem(configBuffer));
				}
			}
			ConfigBookItemById.LogPair.Clear();
			ConfigBookItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBookItemById.HandleId, 1, p0Id, ConfigBookItemById.LogPair) || ConfigCommon.Step(ConfigBookItemById.HandleId, true, ConfigBookItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBookItemById.HandleId, ConfigBookItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBookItemById.HandleId, 0, ConfigBookItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBookItemById.HandleId, ConfigBookItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BookItem rootAsBookItem = BookItem.GetRootAsBookItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BookItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBookItemById.HandleId, ConfigBookItemById.LogPair);
			return new BookItem?(rootAsBookItem);
		}

		// Token: 0x04000700 RID: 1792
		private const string DB = "db_brochure.db";

		// Token: 0x04000701 RID: 1793
		private const string FILE = "c.册子玩法.xlsx";

		// Token: 0x04000702 RID: 1794
		private const string TABLE = "BookItem";

		// Token: 0x04000703 RID: 1795
		private const string COMMAND = "select BinData from `BookItem` where Id=?";

		// Token: 0x04000704 RID: 1796
		private const string KEY_PREFIX = "BookItemById";

		// Token: 0x04000705 RID: 1797
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000706 RID: 1798
		private static int HandleId;
	}
}
