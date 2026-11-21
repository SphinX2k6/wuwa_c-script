using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000113 RID: 275
	public class ConfigBookItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x00081B4D File Offset: 0x0007FD4D
		static ConfigBookItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBookItemById.CreateStaticDefaultValue), new Action(ConfigBookItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00081B6C File Offset: 0x0007FD6C
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

		// Token: 0x06000675 RID: 1653 RVA: 0x00081BEB File Offset: 0x0007FDEB
		public static void ResetStaticDefaultValue()
		{
			ConfigBookItemById.LogPair = null;
			ConfigBookItemById.HandleId = 0;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00081BF9 File Offset: 0x0007FDF9
		public static void Init()
		{
			ConfigBookItemById.HandleId = ConfigCommon.InitDataStatement(ConfigBookItemById.HandleId, "db_brochure.db", "select BinData from `BookItem` where Id=?");
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00081C14 File Offset: 0x0007FE14
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

		// Token: 0x04000769 RID: 1897
		private const string DB = "db_brochure.db";

		// Token: 0x0400076A RID: 1898
		private const string FILE = "c.册子玩法.xlsx";

		// Token: 0x0400076B RID: 1899
		private const string TABLE = "BookItem";

		// Token: 0x0400076C RID: 1900
		private const string COMMAND = "select BinData from `BookItem` where Id=?";

		// Token: 0x0400076D RID: 1901
		private const string KEY_PREFIX = "BookItemById";

		// Token: 0x0400076E RID: 1902
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400076F RID: 1903
		private static int HandleId;
	}
}
