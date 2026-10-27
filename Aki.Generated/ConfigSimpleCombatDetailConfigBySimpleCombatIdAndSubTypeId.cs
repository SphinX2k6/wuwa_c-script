using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200092F RID: 2351
	public class ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600372D RID: 14125 RVA: 0x00191528 File Offset: 0x0018F728
		static ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.CreateStaticDefaultValue), new Action(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00191548 File Offset: 0x0018F748
		public static void CreateStaticDefaultValue()
		{
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_simplecombatdetailconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/s.SimpleCombat配置/*.csv*"),
				new ValueTuple<string, object>("表名", "SimpleCombatDetailConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `SimpleCombatDetailConfig` where SimpleCombatId=? and SubTypeId=?")
			});
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x001915C7 File Offset: 0x0018F7C7
		public static void ResetStaticDefaultValue()
		{
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair = null;
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId = 0;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x001915D5 File Offset: 0x0018F7D5
		public static void Init()
		{
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId, "db_simplecombatdetailconfig.db", "select BinData from `SimpleCombatDetailConfig` where SimpleCombatId=? and SubTypeId=?");
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x001915F0 File Offset: 0x0018F7F0
		public static SimpleCombatDetailConfig? GetConfig(int p0SimpleCombatId, int p1SubTypeId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId, ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SimpleCombatId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1SubTypeId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SimpleCombatDetailConfig?(SimpleCombatDetailConfig.GetRootAsSimpleCombatDetailConfig(configBuffer));
				}
			}
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair.Clear();
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair.Add(new ValueTuple<string, object>("SimpleCombatId", p0SimpleCombatId));
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair.Add(new ValueTuple<string, object>("SubTypeId", p1SubTypeId));
			if (!ConfigCommon.BindInt(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId, 1, p0SimpleCombatId, ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair) || !ConfigCommon.BindInt(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId, 2, p1SubTypeId, ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair) || ConfigCommon.Step(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId, true, ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId, ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId, 0, ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId, ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SimpleCombatDetailConfig rootAsSimpleCombatDetailConfig = SimpleCombatDetailConfig.GetRootAsSimpleCombatDetailConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SimpleCombatId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1SubTypeId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId, ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair);
			return new SimpleCombatDetailConfig?(rootAsSimpleCombatDetailConfig);
		}

		// Token: 0x0400402F RID: 16431
		private const string DB = "db_simplecombatdetailconfig.db";

		// Token: 0x04004030 RID: 16432
		private const string FILE = "k.可视化编辑/c.Csv/s.SimpleCombat配置/*.csv*";

		// Token: 0x04004031 RID: 16433
		private const string TABLE = "SimpleCombatDetailConfig";

		// Token: 0x04004032 RID: 16434
		private const string COMMAND = "select BinData from `SimpleCombatDetailConfig` where SimpleCombatId=? and SubTypeId=?";

		// Token: 0x04004033 RID: 16435
		private const string KEY_PREFIX = "SimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId";

		// Token: 0x04004034 RID: 16436
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004035 RID: 16437
		private static int HandleId;
	}
}
