using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B4 RID: 1716
	public class ConfigPhantomHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002848 RID: 10312 RVA: 0x00140E0B File Offset: 0x0013F00B
		static ConfigPhantomHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomHandBookById.CreateStaticDefaultValue), new Action(ConfigPhantomHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00140E2C File Offset: 0x0013F02C
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

		// Token: 0x0600284A RID: 10314 RVA: 0x00140EAB File Offset: 0x0013F0AB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomHandBookById.LogPair = null;
			ConfigPhantomHandBookById.HandleId = 0;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00140EB9 File Offset: 0x0013F0B9
		public static void Init()
		{
			ConfigPhantomHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomHandBookById.HandleId, "db_handbook.db", "select BinData from `PhantomHandBook` where Id=?");
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00140ED4 File Offset: 0x0013F0D4
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

		// Token: 0x04002ED2 RID: 11986
		private const string DB = "db_handbook.db";

		// Token: 0x04002ED3 RID: 11987
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002ED4 RID: 11988
		private const string TABLE = "PhantomHandBook";

		// Token: 0x04002ED5 RID: 11989
		private const string COMMAND = "select BinData from `PhantomHandBook` where Id=?";

		// Token: 0x04002ED6 RID: 11990
		private const string KEY_PREFIX = "PhantomHandBookById";

		// Token: 0x04002ED7 RID: 11991
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ED8 RID: 11992
		private static int HandleId;
	}
}
