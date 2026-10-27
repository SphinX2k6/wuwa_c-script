using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B6 RID: 694
	public class ConfigFavorRoleInfoByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001049 RID: 4169 RVA: 0x000B57F4 File Offset: 0x000B39F4
		static ConfigFavorRoleInfoByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorRoleInfoByRoleId.CreateStaticDefaultValue), new Action(ConfigFavorRoleInfoByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x000B5814 File Offset: 0x000B3A14
		public static void CreateStaticDefaultValue()
		{
			ConfigFavorRoleInfoByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFavorRoleInfoByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_favor.db"),
				new ValueTuple<string, object>("文件", "h.好感度.xlsx"),
				new ValueTuple<string, object>("表名", "FavorRoleInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `FavorRoleInfo` where RoleId=?")
			});
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x000B5893 File Offset: 0x000B3A93
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorRoleInfoByRoleId.LogPair = null;
			ConfigFavorRoleInfoByRoleId.HandleId = 0;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x000B58A1 File Offset: 0x000B3AA1
		public static void Init()
		{
			ConfigFavorRoleInfoByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigFavorRoleInfoByRoleId.HandleId, "db_favor.db", "select BinData from `FavorRoleInfo` where RoleId=?");
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x000B58BC File Offset: 0x000B3ABC
		public static FavorRoleInfo? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFavorRoleInfoByRoleId.HandleId, ConfigFavorRoleInfoByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorRoleInfoByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FavorRoleInfo?(FavorRoleInfo.GetRootAsFavorRoleInfo(configBuffer));
				}
			}
			ConfigFavorRoleInfoByRoleId.LogPair.Clear();
			ConfigFavorRoleInfoByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigFavorRoleInfoByRoleId.HandleId, 1, p0RoleId, ConfigFavorRoleInfoByRoleId.LogPair) || ConfigCommon.Step(ConfigFavorRoleInfoByRoleId.HandleId, true, ConfigFavorRoleInfoByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFavorRoleInfoByRoleId.HandleId, ConfigFavorRoleInfoByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFavorRoleInfoByRoleId.HandleId, 0, ConfigFavorRoleInfoByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFavorRoleInfoByRoleId.HandleId, ConfigFavorRoleInfoByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FavorRoleInfo rootAsFavorRoleInfo = FavorRoleInfo.GetRootAsFavorRoleInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorRoleInfoByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFavorRoleInfoByRoleId.HandleId, ConfigFavorRoleInfoByRoleId.LogPair);
			return new FavorRoleInfo?(rootAsFavorRoleInfo);
		}

		// Token: 0x040012DE RID: 4830
		private const string DB = "db_favor.db";

		// Token: 0x040012DF RID: 4831
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x040012E0 RID: 4832
		private const string TABLE = "FavorRoleInfo";

		// Token: 0x040012E1 RID: 4833
		private const string COMMAND = "select BinData from `FavorRoleInfo` where RoleId=?";

		// Token: 0x040012E2 RID: 4834
		private const string KEY_PREFIX = "FavorRoleInfoByRoleId";

		// Token: 0x040012E3 RID: 4835
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012E4 RID: 4836
		private static int HandleId;
	}
}
