using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047D RID: 1149
	public class ConfigKeyExclusiveTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AF8 RID: 6904 RVA: 0x000F5660 File Offset: 0x000F3860
		static ConfigKeyExclusiveTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeyExclusiveTypeById.CreateStaticDefaultValue), new Action(ConfigKeyExclusiveTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000F5680 File Offset: 0x000F3880
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

		// Token: 0x06001AFA RID: 6906 RVA: 0x000F56FF File Offset: 0x000F38FF
		public static void ResetStaticDefaultValue()
		{
			ConfigKeyExclusiveTypeById.LogPair = null;
			ConfigKeyExclusiveTypeById.HandleId = 0;
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000F570D File Offset: 0x000F390D
		public static void Init()
		{
			ConfigKeyExclusiveTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigKeyExclusiveTypeById.HandleId, "db_menu.db", "select BinData from `KeyExclusiveType` where Id=?");
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x000F5728 File Offset: 0x000F3928
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

		// Token: 0x04001F4F RID: 8015
		private const string DB = "db_menu.db";

		// Token: 0x04001F50 RID: 8016
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001F51 RID: 8017
		private const string TABLE = "KeyExclusiveType";

		// Token: 0x04001F52 RID: 8018
		private const string COMMAND = "select BinData from `KeyExclusiveType` where Id=?";

		// Token: 0x04001F53 RID: 8019
		private const string KEY_PREFIX = "KeyExclusiveTypeById";

		// Token: 0x04001F54 RID: 8020
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F55 RID: 8021
		private static int HandleId;
	}
}
