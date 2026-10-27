using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E4 RID: 2276
	public class ConfigRoverRogueEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600356B RID: 13675 RVA: 0x001874D4 File Offset: 0x001856D4
		static ConfigRoverRogueEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueEffectById.CreateStaticDefaultValue), new Action(ConfigRoverRogueEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x001874F4 File Offset: 0x001856F4
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

		// Token: 0x0600356D RID: 13677 RVA: 0x00187573 File Offset: 0x00185773
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueEffectById.LogPair = null;
			ConfigRoverRogueEffectById.HandleId = 0;
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x00187581 File Offset: 0x00185781
		public static void Init()
		{
			ConfigRoverRogueEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueEffectById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueEffect` where Id=?");
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x0018759C File Offset: 0x0018579C
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

		// Token: 0x04003E22 RID: 15906
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E23 RID: 15907
		private const string FILE = "f.俯视肉鸽_效果.xlsx";

		// Token: 0x04003E24 RID: 15908
		private const string TABLE = "RoverRogueEffect";

		// Token: 0x04003E25 RID: 15909
		private const string COMMAND = "select BinData from `RoverRogueEffect` where Id=?";

		// Token: 0x04003E26 RID: 15910
		private const string KEY_PREFIX = "RoverRogueEffectById";

		// Token: 0x04003E27 RID: 15911
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E28 RID: 15912
		private static int HandleId;
	}
}
