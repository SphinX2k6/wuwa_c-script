using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000467 RID: 1127
	public class ConfigKeyExclusiveTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A74 RID: 6772 RVA: 0x000EEF0C File Offset: 0x000ED10C
		static ConfigKeyExclusiveTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeyExclusiveTypeById.CreateStaticDefaultValue), new Action(ConfigKeyExclusiveTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x000EEF2C File Offset: 0x000ED12C
		public static void CreateStaticDefaultValue()
		{
			ConfigKeyExclusiveTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKeyExclusiveTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "KeyExclusiveType"),
				new ValueTuple<string, object>("语句", "select BinData from `KeyExclusiveType` where Id=?")
			});
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x000EEFAB File Offset: 0x000ED1AB
		public static void ResetStaticDefaultValue()
		{
			ConfigKeyExclusiveTypeById.LogPair = null;
			ConfigKeyExclusiveTypeById.HandleId = 0;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x000EEFB9 File Offset: 0x000ED1B9
		public static void Init()
		{
			ConfigKeyExclusiveTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigKeyExclusiveTypeById.HandleId, "db_menu.db", "select BinData from `KeyExclusiveType` where Id=?");
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x000EEFD4 File Offset: 0x000ED1D4
		public static KeyExclusiveType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKeyExclusiveTypeById.HandleId, ConfigKeyExclusiveTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KeyExclusiveTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KeyExclusiveType?(KeyExclusiveType.GetRootAsKeyExclusiveType(configBuffer));
				}
			}
			ConfigKeyExclusiveTypeById.LogPair.Clear();
			ConfigKeyExclusiveTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKeyExclusiveTypeById.HandleId, 1, p0Id, ConfigKeyExclusiveTypeById.LogPair) || ConfigCommon.Step(ConfigKeyExclusiveTypeById.HandleId, true, ConfigKeyExclusiveTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKeyExclusiveTypeById.HandleId, ConfigKeyExclusiveTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKeyExclusiveTypeById.HandleId, 0, ConfigKeyExclusiveTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKeyExclusiveTypeById.HandleId, ConfigKeyExclusiveTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KeyExclusiveType rootAsKeyExclusiveType = KeyExclusiveType.GetRootAsKeyExclusiveType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KeyExclusiveTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKeyExclusiveTypeById.HandleId, ConfigKeyExclusiveTypeById.LogPair);
			return new KeyExclusiveType?(rootAsKeyExclusiveType);
		}

		// Token: 0x04001EB5 RID: 7861
		private const string DB = "db_menu.db";

		// Token: 0x04001EB6 RID: 7862
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001EB7 RID: 7863
		private const string TABLE = "KeyExclusiveType";

		// Token: 0x04001EB8 RID: 7864
		private const string COMMAND = "select BinData from `KeyExclusiveType` where Id=?";

		// Token: 0x04001EB9 RID: 7865
		private const string KEY_PREFIX = "KeyExclusiveTypeById";

		// Token: 0x04001EBA RID: 7866
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EBB RID: 7867
		private static int HandleId;
	}
}
