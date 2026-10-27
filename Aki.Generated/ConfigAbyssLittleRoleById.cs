using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000018 RID: 24
	public class ConfigAbyssLittleRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0005D207 File Offset: 0x0005B407
		static ConfigAbyssLittleRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssLittleRoleById.CreateStaticDefaultValue), new Action(ConfigAbyssLittleRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0005D228 File Offset: 0x0005B428
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssLittleRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssLittleRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssLittleRole"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssLittleRole` where Id=?")
			});
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0005D2A7 File Offset: 0x0005B4A7
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssLittleRoleById.LogPair = null;
			ConfigAbyssLittleRoleById.HandleId = 0;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0005D2B5 File Offset: 0x0005B4B5
		public static void Init()
		{
			ConfigAbyssLittleRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssLittleRoleById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssLittleRole` where Id=?");
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0005D2D0 File Offset: 0x0005B4D0
		public static AbyssLittleRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssLittleRoleById.HandleId, ConfigAbyssLittleRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssLittleRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssLittleRole?(AbyssLittleRole.GetRootAsAbyssLittleRole(configBuffer));
				}
			}
			ConfigAbyssLittleRoleById.LogPair.Clear();
			ConfigAbyssLittleRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssLittleRoleById.HandleId, 1, p0Id, ConfigAbyssLittleRoleById.LogPair) || ConfigCommon.Step(ConfigAbyssLittleRoleById.HandleId, true, ConfigAbyssLittleRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssLittleRoleById.HandleId, ConfigAbyssLittleRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssLittleRoleById.HandleId, 0, ConfigAbyssLittleRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssLittleRoleById.HandleId, ConfigAbyssLittleRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssLittleRole rootAsAbyssLittleRole = AbyssLittleRole.GetRootAsAbyssLittleRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssLittleRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssLittleRoleById.HandleId, ConfigAbyssLittleRoleById.LogPair);
			return new AbyssLittleRole?(rootAsAbyssLittleRole);
		}

		// Token: 0x0400008C RID: 140
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x0400008D RID: 141
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x0400008E RID: 142
		private const string TABLE = "AbyssLittleRole";

		// Token: 0x0400008F RID: 143
		private const string COMMAND = "select BinData from `AbyssLittleRole` where Id=?";

		// Token: 0x04000090 RID: 144
		private const string KEY_PREFIX = "AbyssLittleRoleById";

		// Token: 0x04000091 RID: 145
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000092 RID: 146
		private static int HandleId;
	}
}
