using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000486 RID: 1158
	public class ConfigKeyTypeByTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B2E RID: 6958 RVA: 0x000F694F File Offset: 0x000F4B4F
		static ConfigKeyTypeByTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeyTypeByTypeId.CreateStaticDefaultValue), new Action(ConfigKeyTypeByTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x000F6970 File Offset: 0x000F4B70
		public static void CreateStaticDefaultValue()
		{
			ConfigKeyTypeByTypeId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKeyTypeByTypeId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "KeyType"),
				new ValueTuple<string, object>("语句", "select BinData from `KeyType` where TypeId=?")
			});
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x000F69EF File Offset: 0x000F4BEF
		public static void ResetStaticDefaultValue()
		{
			ConfigKeyTypeByTypeId.LogPair = null;
			ConfigKeyTypeByTypeId.HandleId = 0;
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x000F69FD File Offset: 0x000F4BFD
		public static void Init()
		{
			ConfigKeyTypeByTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigKeyTypeByTypeId.HandleId, "db_menu.db", "select BinData from `KeyType` where TypeId=?");
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x000F6A18 File Offset: 0x000F4C18
		public static KeyType? GetConfig(int p0TypeId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKeyTypeByTypeId.HandleId, ConfigKeyTypeByTypeId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KeyTypeByTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KeyType?(KeyType.GetRootAsKeyType(configBuffer));
				}
			}
			ConfigKeyTypeByTypeId.LogPair.Clear();
			ConfigKeyTypeByTypeId.LogPair.Add(new ValueTuple<string, object>("TypeId", p0TypeId));
			if (!ConfigCommon.BindInt(ConfigKeyTypeByTypeId.HandleId, 1, p0TypeId, ConfigKeyTypeByTypeId.LogPair) || ConfigCommon.Step(ConfigKeyTypeByTypeId.HandleId, true, ConfigKeyTypeByTypeId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKeyTypeByTypeId.HandleId, ConfigKeyTypeByTypeId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKeyTypeByTypeId.HandleId, 0, ConfigKeyTypeByTypeId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKeyTypeByTypeId.HandleId, ConfigKeyTypeByTypeId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KeyType rootAsKeyType = KeyType.GetRootAsKeyType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KeyTypeByTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKeyTypeByTypeId.HandleId, ConfigKeyTypeByTypeId.LogPair);
			return new KeyType?(rootAsKeyType);
		}

		// Token: 0x04001F8E RID: 8078
		private const string DB = "db_menu.db";

		// Token: 0x04001F8F RID: 8079
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001F90 RID: 8080
		private const string TABLE = "KeyType";

		// Token: 0x04001F91 RID: 8081
		private const string COMMAND = "select BinData from `KeyType` where TypeId=?";

		// Token: 0x04001F92 RID: 8082
		private const string KEY_PREFIX = "KeyTypeByTypeId";

		// Token: 0x04001F93 RID: 8083
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F94 RID: 8084
		private static int HandleId;
	}
}
