using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023D RID: 573
	public class ConfigDropCatchRoleBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D72 RID: 3442 RVA: 0x000A585B File Offset: 0x000A3A5B
		static ConfigDropCatchRoleBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchRoleBookById.CreateStaticDefaultValue), new Action(ConfigDropCatchRoleBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x000A587C File Offset: 0x000A3A7C
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchRoleBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchRoleBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchRoleBook"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchRoleBook` where Id=?")
			});
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000A58FB File Offset: 0x000A3AFB
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchRoleBookById.LogPair = null;
			ConfigDropCatchRoleBookById.HandleId = 0;
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000A5909 File Offset: 0x000A3B09
		public static void Init()
		{
			ConfigDropCatchRoleBookById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchRoleBookById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchRoleBook` where Id=?");
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x000A5924 File Offset: 0x000A3B24
		public static DropCatchRoleBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchRoleBookById.HandleId, ConfigDropCatchRoleBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchRoleBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DropCatchRoleBook?(DropCatchRoleBook.GetRootAsDropCatchRoleBook(configBuffer));
				}
			}
			ConfigDropCatchRoleBookById.LogPair.Clear();
			ConfigDropCatchRoleBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDropCatchRoleBookById.HandleId, 1, p0Id, ConfigDropCatchRoleBookById.LogPair) || ConfigCommon.Step(ConfigDropCatchRoleBookById.HandleId, true, ConfigDropCatchRoleBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDropCatchRoleBookById.HandleId, ConfigDropCatchRoleBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchRoleBookById.HandleId, 0, ConfigDropCatchRoleBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDropCatchRoleBookById.HandleId, ConfigDropCatchRoleBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DropCatchRoleBook rootAsDropCatchRoleBook = DropCatchRoleBook.GetRootAsDropCatchRoleBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchRoleBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDropCatchRoleBookById.HandleId, ConfigDropCatchRoleBookById.LogPair);
			return new DropCatchRoleBook?(rootAsDropCatchRoleBook);
		}

		// Token: 0x04000F8F RID: 3983
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000F90 RID: 3984
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000F91 RID: 3985
		private const string TABLE = "DropCatchRoleBook";

		// Token: 0x04000F92 RID: 3986
		private const string COMMAND = "select BinData from `DropCatchRoleBook` where Id=?";

		// Token: 0x04000F93 RID: 3987
		private const string KEY_PREFIX = "DropCatchRoleBookById";

		// Token: 0x04000F94 RID: 3988
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F95 RID: 3989
		private static int HandleId;
	}
}
