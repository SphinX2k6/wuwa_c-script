using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000470 RID: 1136
	public class ConfigKeyTypeByTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AAA RID: 6826 RVA: 0x000F01FB File Offset: 0x000EE3FB
		static ConfigKeyTypeByTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeyTypeByTypeId.CreateStaticDefaultValue), new Action(ConfigKeyTypeByTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000F021C File Offset: 0x000EE41C
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

		// Token: 0x06001AAC RID: 6828 RVA: 0x000F029B File Offset: 0x000EE49B
		public static void ResetStaticDefaultValue()
		{
			ConfigKeyTypeByTypeId.LogPair = null;
			ConfigKeyTypeByTypeId.HandleId = 0;
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000F02A9 File Offset: 0x000EE4A9
		public static void Init()
		{
			ConfigKeyTypeByTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigKeyTypeByTypeId.HandleId, "db_menu.db", "select BinData from `KeyType` where TypeId=?");
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000F02C4 File Offset: 0x000EE4C4
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

		// Token: 0x04001EF4 RID: 7924
		private const string DB = "db_menu.db";

		// Token: 0x04001EF5 RID: 7925
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001EF6 RID: 7926
		private const string TABLE = "KeyType";

		// Token: 0x04001EF7 RID: 7927
		private const string COMMAND = "select BinData from `KeyType` where TypeId=?";

		// Token: 0x04001EF8 RID: 7928
		private const string KEY_PREFIX = "KeyTypeByTypeId";

		// Token: 0x04001EF9 RID: 7929
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EFA RID: 7930
		private static int HandleId;
	}
}
