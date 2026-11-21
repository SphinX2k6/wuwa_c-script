using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000244 RID: 580
	public class ConfigDrinksRoleInviteById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D9C RID: 3484 RVA: 0x000AA0A7 File Offset: 0x000A82A7
		static ConfigDrinksRoleInviteById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksRoleInviteById.CreateStaticDefaultValue), new Action(ConfigDrinksRoleInviteById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x000AA0C8 File Offset: 0x000A82C8
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksRoleInviteById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksRoleInviteById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksRoleInvite"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksRoleInvite` where Id=?")
			});
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x000AA147 File Offset: 0x000A8347
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksRoleInviteById.LogPair = null;
			ConfigDrinksRoleInviteById.HandleId = 0;
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000AA155 File Offset: 0x000A8355
		public static void Init()
		{
			ConfigDrinksRoleInviteById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksRoleInviteById.HandleId, "db_drinks.db", "select BinData from `DrinksRoleInvite` where Id=?");
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000AA170 File Offset: 0x000A8370
		public static DrinksRoleInvite? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksRoleInviteById.HandleId, ConfigDrinksRoleInviteById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksRoleInviteById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksRoleInvite?(DrinksRoleInvite.GetRootAsDrinksRoleInvite(configBuffer));
				}
			}
			ConfigDrinksRoleInviteById.LogPair.Clear();
			ConfigDrinksRoleInviteById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksRoleInviteById.HandleId, 1, p0Id, ConfigDrinksRoleInviteById.LogPair) || ConfigCommon.Step(ConfigDrinksRoleInviteById.HandleId, true, ConfigDrinksRoleInviteById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksRoleInviteById.HandleId, ConfigDrinksRoleInviteById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksRoleInviteById.HandleId, 0, ConfigDrinksRoleInviteById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksRoleInviteById.HandleId, ConfigDrinksRoleInviteById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksRoleInvite rootAsDrinksRoleInvite = DrinksRoleInvite.GetRootAsDrinksRoleInvite(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksRoleInviteById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksRoleInviteById.HandleId, ConfigDrinksRoleInviteById.LogPair);
			return new DrinksRoleInvite?(rootAsDrinksRoleInvite);
		}

		// Token: 0x04000FC0 RID: 4032
		private const string DB = "db_drinks.db";

		// Token: 0x04000FC1 RID: 4033
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000FC2 RID: 4034
		private const string TABLE = "DrinksRoleInvite";

		// Token: 0x04000FC3 RID: 4035
		private const string COMMAND = "select BinData from `DrinksRoleInvite` where Id=?";

		// Token: 0x04000FC4 RID: 4036
		private const string KEY_PREFIX = "DrinksRoleInviteById";

		// Token: 0x04000FC5 RID: 4037
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FC6 RID: 4038
		private static int HandleId;
	}
}
