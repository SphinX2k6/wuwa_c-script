using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097A RID: 2426
	public class ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038EF RID: 14575 RVA: 0x0019E748 File Offset: 0x0019C948
		static ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.CreateStaticDefaultValue), new Action(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x0019E768 File Offset: 0x0019C968
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

		// Token: 0x060038F1 RID: 14577 RVA: 0x0019E7E7 File Offset: 0x0019C9E7
		public static void ResetStaticDefaultValue()
		{
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.LogPair = null;
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId = 0;
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x0019E7F5 File Offset: 0x0019C9F5
		public static void Init()
		{
			ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigSimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId.HandleId, "db_simplecombatdetailconfig.db", "select BinData from `SimpleCombatDetailConfig` where SimpleCombatId=? and SubTypeId=?");
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x0019E810 File Offset: 0x0019CA10
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

		// Token: 0x0400423C RID: 16956
		private const string DB = "db_simplecombatdetailconfig.db";

		// Token: 0x0400423D RID: 16957
		private const string FILE = "k.可视化编辑/c.Csv/s.SimpleCombat配置/*.csv*";

		// Token: 0x0400423E RID: 16958
		private const string TABLE = "SimpleCombatDetailConfig";

		// Token: 0x0400423F RID: 16959
		private const string COMMAND = "select BinData from `SimpleCombatDetailConfig` where SimpleCombatId=? and SubTypeId=?";

		// Token: 0x04004240 RID: 16960
		private const string KEY_PREFIX = "SimpleCombatDetailConfigBySimpleCombatIdAndSubTypeId";

		// Token: 0x04004241 RID: 16961
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004242 RID: 16962
		private static int HandleId;
	}
}
