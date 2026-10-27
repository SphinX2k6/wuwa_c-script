using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000025 RID: 37
	public class ConfigAbyssRoleLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000DE RID: 222 RVA: 0x0005EB67 File Offset: 0x0005CD67
		static ConfigAbyssRoleLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRoleLevelById.CreateStaticDefaultValue), new Action(ConfigAbyssRoleLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0005EB88 File Offset: 0x0005CD88
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRoleLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRoleLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoleLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoleLevel` where Id=?")
			});
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0005EC07 File Offset: 0x0005CE07
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRoleLevelById.LogPair = null;
			ConfigAbyssRoleLevelById.HandleId = 0;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0005EC15 File Offset: 0x0005CE15
		public static void Init()
		{
			ConfigAbyssRoleLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRoleLevelById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssRoleLevel` where Id=?");
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0005EC30 File Offset: 0x0005CE30
		public static AbyssRoleLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRoleLevelById.HandleId, ConfigAbyssRoleLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRoleLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssRoleLevel?(AbyssRoleLevel.GetRootAsAbyssRoleLevel(configBuffer));
				}
			}
			ConfigAbyssRoleLevelById.LogPair.Clear();
			ConfigAbyssRoleLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssRoleLevelById.HandleId, 1, p0Id, ConfigAbyssRoleLevelById.LogPair) || ConfigCommon.Step(ConfigAbyssRoleLevelById.HandleId, true, ConfigAbyssRoleLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssRoleLevelById.HandleId, ConfigAbyssRoleLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRoleLevelById.HandleId, 0, ConfigAbyssRoleLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssRoleLevelById.HandleId, ConfigAbyssRoleLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssRoleLevel rootAsAbyssRoleLevel = AbyssRoleLevel.GetRootAsAbyssRoleLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRoleLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssRoleLevelById.HandleId, ConfigAbyssRoleLevelById.LogPair);
			return new AbyssRoleLevel?(rootAsAbyssRoleLevel);
		}

		// Token: 0x040000E7 RID: 231
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000E8 RID: 232
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000E9 RID: 233
		private const string TABLE = "AbyssRoleLevel";

		// Token: 0x040000EA RID: 234
		private const string COMMAND = "select BinData from `AbyssRoleLevel` where Id=?";

		// Token: 0x040000EB RID: 235
		private const string KEY_PREFIX = "AbyssRoleLevelById";

		// Token: 0x040000EC RID: 236
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000ED RID: 237
		private static int HandleId;
	}
}
