using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B1 RID: 2225
	public class ConfigRoleDevelopTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003438 RID: 13368 RVA: 0x001840A3 File Offset: 0x001822A3
		static ConfigRoleDevelopTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevelopTypeById.CreateStaticDefaultValue), new Action(ConfigRoleDevelopTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x001840C4 File Offset: 0x001822C4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevelopTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevelopTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevelopType"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevelopType` where Id=?")
			});
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x00184143 File Offset: 0x00182343
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevelopTypeById.LogPair = null;
			ConfigRoleDevelopTypeById.HandleId = 0;
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00184151 File Offset: 0x00182351
		public static void Init()
		{
			ConfigRoleDevelopTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevelopTypeById.HandleId, "db_moonchasing.db", "select BinData from `RoleDevelopType` where Id=?");
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x0018416C File Offset: 0x0018236C
		public static RoleDevelopType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevelopTypeById.HandleId, ConfigRoleDevelopTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevelopTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevelopType?(RoleDevelopType.GetRootAsRoleDevelopType(configBuffer));
				}
			}
			ConfigRoleDevelopTypeById.LogPair.Clear();
			ConfigRoleDevelopTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleDevelopTypeById.HandleId, 1, p0Id, ConfigRoleDevelopTypeById.LogPair) || ConfigCommon.Step(ConfigRoleDevelopTypeById.HandleId, true, ConfigRoleDevelopTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevelopTypeById.HandleId, ConfigRoleDevelopTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevelopTypeById.HandleId, 0, ConfigRoleDevelopTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevelopTypeById.HandleId, ConfigRoleDevelopTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevelopType rootAsRoleDevelopType = RoleDevelopType.GetRootAsRoleDevelopType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevelopTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevelopTypeById.HandleId, ConfigRoleDevelopTypeById.LogPair);
			return new RoleDevelopType?(rootAsRoleDevelopType);
		}

		// Token: 0x04003CBD RID: 15549
		private const string DB = "db_moonchasing.db";

		// Token: 0x04003CBE RID: 15550
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04003CBF RID: 15551
		private const string TABLE = "RoleDevelopType";

		// Token: 0x04003CC0 RID: 15552
		private const string COMMAND = "select BinData from `RoleDevelopType` where Id=?";

		// Token: 0x04003CC1 RID: 15553
		private const string KEY_PREFIX = "RoleDevelopTypeById";

		// Token: 0x04003CC2 RID: 15554
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CC3 RID: 15555
		private static int HandleId;
	}
}
