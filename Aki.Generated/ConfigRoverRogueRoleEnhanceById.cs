using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F2 RID: 2290
	public class ConfigRoverRogueRoleEnhanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035BF RID: 13759 RVA: 0x001891D3 File Offset: 0x001873D3
		static ConfigRoverRogueRoleEnhanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoleEnhanceById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoleEnhanceById.ResetStaticDefaultValue));
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x001891F4 File Offset: 0x001873F4
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

		// Token: 0x060035C1 RID: 13761 RVA: 0x00189273 File Offset: 0x00187473
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoleEnhanceById.LogPair = null;
			ConfigRoverRogueRoleEnhanceById.HandleId = 0;
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00189281 File Offset: 0x00187481
		public static void Init()
		{
			ConfigRoverRogueRoleEnhanceById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoleEnhanceById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoleEnhance` where Id=?");
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x0018929C File Offset: 0x0018749C
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

		// Token: 0x04003E84 RID: 16004
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E85 RID: 16005
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04003E86 RID: 16006
		private const string TABLE = "RoverRogueRoleEnhance";

		// Token: 0x04003E87 RID: 16007
		private const string COMMAND = "select BinData from `RoverRogueRoleEnhance` where Id=?";

		// Token: 0x04003E88 RID: 16008
		private const string KEY_PREFIX = "RoverRogueRoleEnhanceById";

		// Token: 0x04003E89 RID: 16009
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E8A RID: 16010
		private static int HandleId;
	}
}
