using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000232 RID: 562
	public class ConfigDrinksRoleInviteById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D30 RID: 3376 RVA: 0x000A416F File Offset: 0x000A236F
		static ConfigDrinksRoleInviteById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksRoleInviteById.CreateStaticDefaultValue), new Action(ConfigDrinksRoleInviteById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x000A4190 File Offset: 0x000A2390
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

		// Token: 0x06000D32 RID: 3378 RVA: 0x000A420F File Offset: 0x000A240F
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksRoleInviteById.LogPair = null;
			ConfigDrinksRoleInviteById.HandleId = 0;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x000A421D File Offset: 0x000A241D
		public static void Init()
		{
			ConfigDrinksRoleInviteById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksRoleInviteById.HandleId, "db_drinks.db", "select BinData from `DrinksRoleInvite` where Id=?");
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x000A4238 File Offset: 0x000A2438
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

		// Token: 0x04000F42 RID: 3906
		private const string DB = "db_drinks.db";

		// Token: 0x04000F43 RID: 3907
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F44 RID: 3908
		private const string TABLE = "DrinksRoleInvite";

		// Token: 0x04000F45 RID: 3909
		private const string COMMAND = "select BinData from `DrinksRoleInvite` where Id=?";

		// Token: 0x04000F46 RID: 3910
		private const string KEY_PREFIX = "DrinksRoleInviteById";

		// Token: 0x04000F47 RID: 3911
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F48 RID: 3912
		private static int HandleId;
	}
}
