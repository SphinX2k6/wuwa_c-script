using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F5 RID: 1781
	public class ConfigPhotographHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029CE RID: 10702 RVA: 0x001491AB File Offset: 0x001473AB
		static ConfigPhotographHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotographHandBookById.CreateStaticDefaultValue), new Action(ConfigPhotographHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x001491CC File Offset: 0x001473CC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotographHandBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotographHandBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhotographHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotographHandBook` where Id = ?")
			});
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x0014924B File Offset: 0x0014744B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotographHandBookById.LogPair = null;
			ConfigPhotographHandBookById.HandleId = 0;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00149259 File Offset: 0x00147459
		public static void Init()
		{
			ConfigPhotographHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotographHandBookById.HandleId, "db_handbook.db", "select BinData from `PhotographHandBook` where Id = ?");
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00149274 File Offset: 0x00147474
		public static PhotographHandBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotographHandBookById.HandleId, ConfigPhotographHandBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotographHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotographHandBook?(PhotographHandBook.GetRootAsPhotographHandBook(configBuffer));
				}
			}
			ConfigPhotographHandBookById.LogPair.Clear();
			ConfigPhotographHandBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotographHandBookById.HandleId, 1, p0Id, ConfigPhotographHandBookById.LogPair) || ConfigCommon.Step(ConfigPhotographHandBookById.HandleId, true, ConfigPhotographHandBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotographHandBookById.HandleId, ConfigPhotographHandBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotographHandBookById.HandleId, 0, ConfigPhotographHandBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotographHandBookById.HandleId, ConfigPhotographHandBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotographHandBook rootAsPhotographHandBook = PhotographHandBook.GetRootAsPhotographHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotographHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotographHandBookById.HandleId, ConfigPhotographHandBookById.LogPair);
			return new PhotographHandBook?(rootAsPhotographHandBook);
		}

		// Token: 0x04003099 RID: 12441
		private const string DB = "db_handbook.db";

		// Token: 0x0400309A RID: 12442
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400309B RID: 12443
		private const string TABLE = "PhotographHandBook";

		// Token: 0x0400309C RID: 12444
		private const string COMMAND = "select BinData from `PhotographHandBook` where Id = ?";

		// Token: 0x0400309D RID: 12445
		private const string KEY_PREFIX = "PhotographHandBookById";

		// Token: 0x0400309E RID: 12446
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400309F RID: 12447
		private static int HandleId;
	}
}
