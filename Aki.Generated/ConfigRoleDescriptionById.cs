using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088F RID: 2191
	public class ConfigRoleDescriptionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600336C RID: 13164 RVA: 0x0017C185 File Offset: 0x0017A385
		static ConfigRoleDescriptionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDescriptionById.CreateStaticDefaultValue), new Action(ConfigRoleDescriptionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x0017C1A4 File Offset: 0x0017A3A4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDescriptionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDescriptionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledescription.db"),
				new ValueTuple<string, object>("文件", "j.角色介绍.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDescription"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDescription` where Id=?")
			});
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x0017C223 File Offset: 0x0017A423
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDescriptionById.LogPair = null;
			ConfigRoleDescriptionById.HandleId = 0;
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x0017C231 File Offset: 0x0017A431
		public static void Init()
		{
			ConfigRoleDescriptionById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDescriptionById.HandleId, "db_roledescription.db", "select BinData from `RoleDescription` where Id=?");
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x0017C24C File Offset: 0x0017A44C
		public static RoleDescription? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDescriptionById.HandleId, ConfigRoleDescriptionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDescriptionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDescription?(RoleDescription.GetRootAsRoleDescription(configBuffer));
				}
			}
			ConfigRoleDescriptionById.LogPair.Clear();
			ConfigRoleDescriptionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleDescriptionById.HandleId, 1, p0Id, ConfigRoleDescriptionById.LogPair) || ConfigCommon.Step(ConfigRoleDescriptionById.HandleId, true, ConfigRoleDescriptionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDescriptionById.HandleId, ConfigRoleDescriptionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDescriptionById.HandleId, 0, ConfigRoleDescriptionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDescriptionById.HandleId, ConfigRoleDescriptionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDescription rootAsRoleDescription = RoleDescription.GetRootAsRoleDescription(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDescriptionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDescriptionById.HandleId, ConfigRoleDescriptionById.LogPair);
			return new RoleDescription?(rootAsRoleDescription);
		}

		// Token: 0x04003BCF RID: 15311
		private const string DB = "db_roledescription.db";

		// Token: 0x04003BD0 RID: 15312
		private const string FILE = "j.角色介绍.xlsx";

		// Token: 0x04003BD1 RID: 15313
		private const string TABLE = "RoleDescription";

		// Token: 0x04003BD2 RID: 15314
		private const string COMMAND = "select BinData from `RoleDescription` where Id=?";

		// Token: 0x04003BD3 RID: 15315
		private const string KEY_PREFIX = "RoleDescriptionById";

		// Token: 0x04003BD4 RID: 15316
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BD5 RID: 15317
		private static int HandleId;
	}
}
