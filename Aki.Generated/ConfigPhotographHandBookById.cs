using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DD RID: 1757
	public class ConfigPhotographHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600293E RID: 10558 RVA: 0x0014272F File Offset: 0x0014092F
		static ConfigPhotographHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotographHandBookById.CreateStaticDefaultValue), new Action(ConfigPhotographHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x00142750 File Offset: 0x00140950
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

		// Token: 0x06002940 RID: 10560 RVA: 0x001427CF File Offset: 0x001409CF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotographHandBookById.LogPair = null;
			ConfigPhotographHandBookById.HandleId = 0;
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x001427DD File Offset: 0x001409DD
		public static void Init()
		{
			ConfigPhotographHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotographHandBookById.HandleId, "db_handbook.db", "select BinData from `PhotographHandBook` where Id = ?");
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x001427F8 File Offset: 0x001409F8
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

		// Token: 0x04002FF1 RID: 12273
		private const string DB = "db_handbook.db";

		// Token: 0x04002FF2 RID: 12274
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002FF3 RID: 12275
		private const string TABLE = "PhotographHandBook";

		// Token: 0x04002FF4 RID: 12276
		private const string COMMAND = "select BinData from `PhotographHandBook` where Id = ?";

		// Token: 0x04002FF5 RID: 12277
		private const string KEY_PREFIX = "PhotographHandBookById";

		// Token: 0x04002FF6 RID: 12278
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FF7 RID: 12279
		private static int HandleId;
	}
}
