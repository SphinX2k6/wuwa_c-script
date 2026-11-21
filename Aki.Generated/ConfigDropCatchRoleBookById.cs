using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024F RID: 591
	public class ConfigDropCatchRoleBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DDE RID: 3550 RVA: 0x000AB793 File Offset: 0x000A9993
		static ConfigDropCatchRoleBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchRoleBookById.CreateStaticDefaultValue), new Action(ConfigDropCatchRoleBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x000AB7B4 File Offset: 0x000A99B4
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

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000AB833 File Offset: 0x000A9A33
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchRoleBookById.LogPair = null;
			ConfigDropCatchRoleBookById.HandleId = 0;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000AB841 File Offset: 0x000A9A41
		public static void Init()
		{
			ConfigDropCatchRoleBookById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchRoleBookById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchRoleBook` where Id=?");
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000AB85C File Offset: 0x000A9A5C
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

		// Token: 0x0400100D RID: 4109
		private const string DB = "db_dropcatch.db";

		// Token: 0x0400100E RID: 4110
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x0400100F RID: 4111
		private const string TABLE = "DropCatchRoleBook";

		// Token: 0x04001010 RID: 4112
		private const string COMMAND = "select BinData from `DropCatchRoleBook` where Id=?";

		// Token: 0x04001011 RID: 4113
		private const string KEY_PREFIX = "DropCatchRoleBookById";

		// Token: 0x04001012 RID: 4114
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001013 RID: 4115
		private static int HandleId;
	}
}
