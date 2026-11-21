using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093D RID: 2365
	public class ConfigRoverRogueRoleEnhanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003781 RID: 14209 RVA: 0x001963F3 File Offset: 0x001945F3
		static ConfigRoverRogueRoleEnhanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoleEnhanceById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoleEnhanceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x00196414 File Offset: 0x00194614
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRoleEnhanceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRoleEnhanceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueRoleEnhance"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueRoleEnhance` where Id=?")
			});
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x00196493 File Offset: 0x00194693
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoleEnhanceById.LogPair = null;
			ConfigRoverRogueRoleEnhanceById.HandleId = 0;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x001964A1 File Offset: 0x001946A1
		public static void Init()
		{
			ConfigRoverRogueRoleEnhanceById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoleEnhanceById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoleEnhance` where Id=?");
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x001964BC File Offset: 0x001946BC
		public static RoverRogueRoleEnhance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRoleEnhanceById.HandleId, ConfigRoverRogueRoleEnhanceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoleEnhanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueRoleEnhance?(RoverRogueRoleEnhance.GetRootAsRoverRogueRoleEnhance(configBuffer));
				}
			}
			ConfigRoverRogueRoleEnhanceById.LogPair.Clear();
			ConfigRoverRogueRoleEnhanceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueRoleEnhanceById.HandleId, 1, p0Id, ConfigRoverRogueRoleEnhanceById.LogPair) || ConfigCommon.Step(ConfigRoverRogueRoleEnhanceById.HandleId, true, ConfigRoverRogueRoleEnhanceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoleEnhanceById.HandleId, ConfigRoverRogueRoleEnhanceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRoleEnhanceById.HandleId, 0, ConfigRoverRogueRoleEnhanceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoleEnhanceById.HandleId, ConfigRoverRogueRoleEnhanceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueRoleEnhance rootAsRoverRogueRoleEnhance = RoverRogueRoleEnhance.GetRootAsRoverRogueRoleEnhance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoleEnhanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueRoleEnhanceById.HandleId, ConfigRoverRogueRoleEnhanceById.LogPair);
			return new RoverRogueRoleEnhance?(rootAsRoverRogueRoleEnhance);
		}

		// Token: 0x04004091 RID: 16529
		private const string DB = "db_roverlike.db";

		// Token: 0x04004092 RID: 16530
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04004093 RID: 16531
		private const string TABLE = "RoverRogueRoleEnhance";

		// Token: 0x04004094 RID: 16532
		private const string COMMAND = "select BinData from `RoverRogueRoleEnhance` where Id=?";

		// Token: 0x04004095 RID: 16533
		private const string KEY_PREFIX = "RoverRogueRoleEnhanceById";

		// Token: 0x04004096 RID: 16534
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004097 RID: 16535
		private static int HandleId;
	}
}
