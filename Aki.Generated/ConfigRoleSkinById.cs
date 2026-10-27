using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C7 RID: 2247
	public class ConfigRoleSkinById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034BD RID: 13501 RVA: 0x001835FB File Offset: 0x001817FB
		static ConfigRoleSkinById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinById.CreateStaticDefaultValue), new Action(ConfigRoleSkinById.ResetStaticDefaultValue));
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x0018361C File Offset: 0x0018181C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkin` where Id =?")
			});
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x0018369B File Offset: 0x0018189B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinById.LogPair = null;
			ConfigRoleSkinById.HandleId = 0;
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x001836A9 File Offset: 0x001818A9
		public static void Init()
		{
			ConfigRoleSkinById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinById.HandleId, "db_role.db", "select BinData from `RoleSkin` where Id =?");
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x001836C4 File Offset: 0x001818C4
		public static RoleSkin? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinById.HandleId, ConfigRoleSkinById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkin?(RoleSkin.GetRootAsRoleSkin(configBuffer));
				}
			}
			ConfigRoleSkinById.LogPair.Clear();
			ConfigRoleSkinById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleSkinById.HandleId, 1, p0Id, ConfigRoleSkinById.LogPair) || ConfigCommon.Step(ConfigRoleSkinById.HandleId, true, ConfigRoleSkinById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkinById.HandleId, ConfigRoleSkinById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinById.HandleId, 0, ConfigRoleSkinById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkinById.HandleId, ConfigRoleSkinById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkin rootAsRoleSkin = RoleSkin.GetRootAsRoleSkin(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkinById.HandleId, ConfigRoleSkinById.LogPair);
			return new RoleSkin?(rootAsRoleSkin);
		}

		// Token: 0x04003D57 RID: 15703
		private const string DB = "db_role.db";

		// Token: 0x04003D58 RID: 15704
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D59 RID: 15705
		private const string TABLE = "RoleSkin";

		// Token: 0x04003D5A RID: 15706
		private const string COMMAND = "select BinData from `RoleSkin` where Id =?";

		// Token: 0x04003D5B RID: 15707
		private const string KEY_PREFIX = "RoleSkinById";

		// Token: 0x04003D5C RID: 15708
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D5D RID: 15709
		private static int HandleId;
	}
}
