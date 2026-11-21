using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CB RID: 715
	public class ConfigFavorRoleInfoByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010C7 RID: 4295 RVA: 0x000BBD00 File Offset: 0x000B9F00
		static ConfigFavorRoleInfoByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorRoleInfoByRoleId.CreateStaticDefaultValue), new Action(ConfigFavorRoleInfoByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x000BBD20 File Offset: 0x000B9F20
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

		// Token: 0x060010C9 RID: 4297 RVA: 0x000BBD9F File Offset: 0x000B9F9F
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorRoleInfoByRoleId.LogPair = null;
			ConfigFavorRoleInfoByRoleId.HandleId = 0;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x000BBDAD File Offset: 0x000B9FAD
		public static void Init()
		{
			ConfigFavorRoleInfoByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigFavorRoleInfoByRoleId.HandleId, "db_favor.db", "select BinData from `FavorRoleInfo` where RoleId=?");
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x000BBDC8 File Offset: 0x000B9FC8
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

		// Token: 0x04001371 RID: 4977
		private const string DB = "db_favor.db";

		// Token: 0x04001372 RID: 4978
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x04001373 RID: 4979
		private const string TABLE = "FavorRoleInfo";

		// Token: 0x04001374 RID: 4980
		private const string COMMAND = "select BinData from `FavorRoleInfo` where RoleId=?";

		// Token: 0x04001375 RID: 4981
		private const string KEY_PREFIX = "FavorRoleInfoByRoleId";

		// Token: 0x04001376 RID: 4982
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001377 RID: 4983
		private static int HandleId;
	}
}
