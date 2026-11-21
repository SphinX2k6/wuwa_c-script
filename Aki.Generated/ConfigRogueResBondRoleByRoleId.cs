using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000851 RID: 2129
	public class ConfigRogueResBondRoleByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031F8 RID: 12792 RVA: 0x001775D7 File Offset: 0x001757D7
		static ConfigRogueResBondRoleByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBondRoleByRoleId.CreateStaticDefaultValue), new Action(ConfigRogueResBondRoleByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x001775F8 File Offset: 0x001757F8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResBondRoleByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResBondRoleByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResBondRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResBondRole` where RoleId=?")
			});
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x00177677 File Offset: 0x00175877
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBondRoleByRoleId.LogPair = null;
			ConfigRogueResBondRoleByRoleId.HandleId = 0;
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00177685 File Offset: 0x00175885
		public static void Init()
		{
			ConfigRogueResBondRoleByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBondRoleByRoleId.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBondRole` where RoleId=?");
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x001776A0 File Offset: 0x001758A0
		public static RogueResBondRole? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResBondRoleByRoleId.HandleId, ConfigRogueResBondRoleByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBondRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResBondRole?(RogueResBondRole.GetRootAsRogueResBondRole(configBuffer));
				}
			}
			ConfigRogueResBondRoleByRoleId.LogPair.Clear();
			ConfigRogueResBondRoleByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRogueResBondRoleByRoleId.HandleId, 1, p0RoleId, ConfigRogueResBondRoleByRoleId.LogPair) || ConfigCommon.Step(ConfigRogueResBondRoleByRoleId.HandleId, true, ConfigRogueResBondRoleByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResBondRoleByRoleId.HandleId, ConfigRogueResBondRoleByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResBondRoleByRoleId.HandleId, 0, ConfigRogueResBondRoleByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResBondRoleByRoleId.HandleId, ConfigRogueResBondRoleByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResBondRole rootAsRogueResBondRole = RogueResBondRole.GetRootAsRogueResBondRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBondRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResBondRoleByRoleId.HandleId, ConfigRogueResBondRoleByRoleId.LogPair);
			return new RogueResBondRole?(rootAsRogueResBondRole);
		}

		// Token: 0x04003A1D RID: 14877
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A1E RID: 14878
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A1F RID: 14879
		private const string TABLE = "RogueResBondRole";

		// Token: 0x04003A20 RID: 14880
		private const string COMMAND = "select BinData from `RogueResBondRole` where RoleId=?";

		// Token: 0x04003A21 RID: 14881
		private const string KEY_PREFIX = "RogueResBondRoleByRoleId";

		// Token: 0x04003A22 RID: 14882
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A23 RID: 14883
		private static int HandleId;
	}
}
