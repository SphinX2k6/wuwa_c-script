using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069C RID: 1692
	public class ConfigPhantomHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027B8 RID: 10168 RVA: 0x0013A38F File Offset: 0x0013858F
		static ConfigPhantomHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomHandBookById.CreateStaticDefaultValue), new Action(ConfigPhantomHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x0013A3B0 File Offset: 0x001385B0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomHandBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomHandBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomHandBook` where Id=?")
			});
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x0013A42F File Offset: 0x0013862F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomHandBookById.LogPair = null;
			ConfigPhantomHandBookById.HandleId = 0;
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x0013A43D File Offset: 0x0013863D
		public static void Init()
		{
			ConfigPhantomHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomHandBookById.HandleId, "db_handbook.db", "select BinData from `PhantomHandBook` where Id=?");
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0013A458 File Offset: 0x00138658
		public static PhantomHandBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomHandBookById.HandleId, ConfigPhantomHandBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomHandBook?(PhantomHandBook.GetRootAsPhantomHandBook(configBuffer));
				}
			}
			ConfigPhantomHandBookById.LogPair.Clear();
			ConfigPhantomHandBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomHandBookById.HandleId, 1, p0Id, ConfigPhantomHandBookById.LogPair) || ConfigCommon.Step(ConfigPhantomHandBookById.HandleId, true, ConfigPhantomHandBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomHandBookById.HandleId, ConfigPhantomHandBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomHandBookById.HandleId, 0, ConfigPhantomHandBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomHandBookById.HandleId, ConfigPhantomHandBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomHandBook rootAsPhantomHandBook = PhantomHandBook.GetRootAsPhantomHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomHandBookById.HandleId, ConfigPhantomHandBookById.LogPair);
			return new PhantomHandBook?(rootAsPhantomHandBook);
		}

		// Token: 0x04002E2A RID: 11818
		private const string DB = "db_handbook.db";

		// Token: 0x04002E2B RID: 11819
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002E2C RID: 11820
		private const string TABLE = "PhantomHandBook";

		// Token: 0x04002E2D RID: 11821
		private const string COMMAND = "select BinData from `PhantomHandBook` where Id=?";

		// Token: 0x04002E2E RID: 11822
		private const string KEY_PREFIX = "PhantomHandBookById";

		// Token: 0x04002E2F RID: 11823
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E30 RID: 11824
		private static int HandleId;
	}
}
