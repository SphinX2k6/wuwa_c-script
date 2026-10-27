using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000895 RID: 2197
	public class ConfigRoleDevelopTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003390 RID: 13200 RVA: 0x0017CDBB File Offset: 0x0017AFBB
		static ConfigRoleDevelopTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevelopTypeById.CreateStaticDefaultValue), new Action(ConfigRoleDevelopTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x0017CDDC File Offset: 0x0017AFDC
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

		// Token: 0x06003392 RID: 13202 RVA: 0x0017CE5B File Offset: 0x0017B05B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevelopTypeById.LogPair = null;
			ConfigRoleDevelopTypeById.HandleId = 0;
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x0017CE69 File Offset: 0x0017B069
		public static void Init()
		{
			ConfigRoleDevelopTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevelopTypeById.HandleId, "db_moonchasing.db", "select BinData from `RoleDevelopType` where Id=?");
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x0017CE84 File Offset: 0x0017B084
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

		// Token: 0x04003BF9 RID: 15353
		private const string DB = "db_moonchasing.db";

		// Token: 0x04003BFA RID: 15354
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04003BFB RID: 15355
		private const string TABLE = "RoleDevelopType";

		// Token: 0x04003BFC RID: 15356
		private const string COMMAND = "select BinData from `RoleDevelopType` where Id=?";

		// Token: 0x04003BFD RID: 15357
		private const string KEY_PREFIX = "RoleDevelopTypeById";

		// Token: 0x04003BFE RID: 15358
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BFF RID: 15359
		private static int HandleId;
	}
}
