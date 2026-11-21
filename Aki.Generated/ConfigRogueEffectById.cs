using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083E RID: 2110
	public class ConfigRogueEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003186 RID: 12678 RVA: 0x00174C48 File Offset: 0x00172E48
		static ConfigRogueEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueEffectById.CreateStaticDefaultValue), new Action(ConfigRogueEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x00174C68 File Offset: 0x00172E68
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueEffect` where Id=?")
			});
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x00174CE7 File Offset: 0x00172EE7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueEffectById.LogPair = null;
			ConfigRogueEffectById.HandleId = 0;
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x00174CF5 File Offset: 0x00172EF5
		public static void Init()
		{
			ConfigRogueEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueEffectById.HandleId, "db_rogue.db", "select BinData from `RogueEffect` where Id=?");
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x00174D10 File Offset: 0x00172F10
		public static RogueEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueEffectById.HandleId, ConfigRogueEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueEffect?(RogueEffect.GetRootAsRogueEffect(configBuffer));
				}
			}
			ConfigRogueEffectById.LogPair.Clear();
			ConfigRogueEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueEffectById.HandleId, 1, p0Id, ConfigRogueEffectById.LogPair) || ConfigCommon.Step(ConfigRogueEffectById.HandleId, true, ConfigRogueEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueEffectById.HandleId, ConfigRogueEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueEffectById.HandleId, 0, ConfigRogueEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueEffectById.HandleId, ConfigRogueEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueEffect rootAsRogueEffect = RogueEffect.GetRootAsRogueEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueEffectById.HandleId, ConfigRogueEffectById.LogPair);
			return new RogueEffect?(rootAsRogueEffect);
		}

		// Token: 0x04003998 RID: 14744
		private const string DB = "db_rogue.db";

		// Token: 0x04003999 RID: 14745
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x0400399A RID: 14746
		private const string TABLE = "RogueEffect";

		// Token: 0x0400399B RID: 14747
		private const string COMMAND = "select BinData from `RogueEffect` where Id=?";

		// Token: 0x0400399C RID: 14748
		private const string KEY_PREFIX = "RogueEffectById";

		// Token: 0x0400399D RID: 14749
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400399E RID: 14750
		private static int HandleId;
	}
}
