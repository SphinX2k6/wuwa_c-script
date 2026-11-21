using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200092F RID: 2351
	public class ConfigRoverRogueEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600372D RID: 14125 RVA: 0x001946F4 File Offset: 0x001928F4
		static ConfigRoverRogueEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueEffectById.CreateStaticDefaultValue), new Action(ConfigRoverRogueEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00194714 File Offset: 0x00192914
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_效果.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueEffect` where Id=?")
			});
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00194793 File Offset: 0x00192993
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueEffectById.LogPair = null;
			ConfigRoverRogueEffectById.HandleId = 0;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x001947A1 File Offset: 0x001929A1
		public static void Init()
		{
			ConfigRoverRogueEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueEffectById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueEffect` where Id=?");
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x001947BC File Offset: 0x001929BC
		public static RoverRogueEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueEffectById.HandleId, ConfigRoverRogueEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueEffect?(RoverRogueEffect.GetRootAsRoverRogueEffect(configBuffer));
				}
			}
			ConfigRoverRogueEffectById.LogPair.Clear();
			ConfigRoverRogueEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueEffectById.HandleId, 1, p0Id, ConfigRoverRogueEffectById.LogPair) || ConfigCommon.Step(ConfigRoverRogueEffectById.HandleId, true, ConfigRoverRogueEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueEffectById.HandleId, ConfigRoverRogueEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueEffectById.HandleId, 0, ConfigRoverRogueEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueEffectById.HandleId, ConfigRoverRogueEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueEffect rootAsRoverRogueEffect = RoverRogueEffect.GetRootAsRoverRogueEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueEffectById.HandleId, ConfigRoverRogueEffectById.LogPair);
			return new RoverRogueEffect?(rootAsRoverRogueEffect);
		}

		// Token: 0x0400402F RID: 16431
		private const string DB = "db_roverlike.db";

		// Token: 0x04004030 RID: 16432
		private const string FILE = "f.俯视肉鸽_效果.xlsx";

		// Token: 0x04004031 RID: 16433
		private const string TABLE = "RoverRogueEffect";

		// Token: 0x04004032 RID: 16434
		private const string COMMAND = "select BinData from `RoverRogueEffect` where Id=?";

		// Token: 0x04004033 RID: 16435
		private const string KEY_PREFIX = "RoverRogueEffectById";

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
