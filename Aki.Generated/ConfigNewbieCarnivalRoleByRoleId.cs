using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FA RID: 1530
	public class ConfigNewbieCarnivalRoleByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023EB RID: 9195 RVA: 0x001281B0 File Offset: 0x001263B0
		static ConfigNewbieCarnivalRoleByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCarnivalRoleByRoleId.CreateStaticDefaultValue), new Action(ConfigNewbieCarnivalRoleByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x001281D0 File Offset: 0x001263D0
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCarnivalRoleByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCarnivalRoleByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecarnival.db"),
				new ValueTuple<string, object>("文件", "x.新手嘉年华.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCarnivalRole"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCarnivalRole` where RoleId=?")
			});
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0012824F File Offset: 0x0012644F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCarnivalRoleByRoleId.LogPair = null;
			ConfigNewbieCarnivalRoleByRoleId.HandleId = 0;
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0012825D File Offset: 0x0012645D
		public static void Init()
		{
			ConfigNewbieCarnivalRoleByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCarnivalRoleByRoleId.HandleId, "db_newbiecarnival.db", "select BinData from `NewbieCarnivalRole` where RoleId=?");
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00128278 File Offset: 0x00126478
		public static NewbieCarnivalRole? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCarnivalRoleByRoleId.HandleId, ConfigNewbieCarnivalRoleByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieCarnivalRole?(NewbieCarnivalRole.GetRootAsNewbieCarnivalRole(configBuffer));
				}
			}
			ConfigNewbieCarnivalRoleByRoleId.LogPair.Clear();
			ConfigNewbieCarnivalRoleByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigNewbieCarnivalRoleByRoleId.HandleId, 1, p0RoleId, ConfigNewbieCarnivalRoleByRoleId.LogPair) || ConfigCommon.Step(ConfigNewbieCarnivalRoleByRoleId.HandleId, true, ConfigNewbieCarnivalRoleByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalRoleByRoleId.HandleId, ConfigNewbieCarnivalRoleByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCarnivalRoleByRoleId.HandleId, 0, ConfigNewbieCarnivalRoleByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalRoleByRoleId.HandleId, ConfigNewbieCarnivalRoleByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieCarnivalRole rootAsNewbieCarnivalRole = NewbieCarnivalRole.GetRootAsNewbieCarnivalRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieCarnivalRoleByRoleId.HandleId, ConfigNewbieCarnivalRoleByRoleId.LogPair);
			return new NewbieCarnivalRole?(rootAsNewbieCarnivalRole);
		}

		// Token: 0x040029BC RID: 10684
		private const string DB = "db_newbiecarnival.db";

		// Token: 0x040029BD RID: 10685
		private const string FILE = "x.新手嘉年华.xlsx";

		// Token: 0x040029BE RID: 10686
		private const string TABLE = "NewbieCarnivalRole";

		// Token: 0x040029BF RID: 10687
		private const string COMMAND = "select BinData from `NewbieCarnivalRole` where RoleId=?";

		// Token: 0x040029C0 RID: 10688
		private const string KEY_PREFIX = "NewbieCarnivalRoleByRoleId";

		// Token: 0x040029C1 RID: 10689
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029C2 RID: 10690
		private static int HandleId;
	}
}
