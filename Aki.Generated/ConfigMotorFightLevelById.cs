using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A7 RID: 1447
	public class ConfigMotorFightLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021F7 RID: 8695 RVA: 0x0011D06F File Offset: 0x0011B26F
		static ConfigMotorFightLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightLevelById.CreateStaticDefaultValue), new Action(ConfigMotorFightLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x0011D090 File Offset: 0x0011B290
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightLevel` where Id=?")
			});
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x0011D10F File Offset: 0x0011B30F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightLevelById.LogPair = null;
			ConfigMotorFightLevelById.HandleId = 0;
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x0011D11D File Offset: 0x0011B31D
		public static void Init()
		{
			ConfigMotorFightLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightLevelById.HandleId, "db_motorfight.db", "select BinData from `MotorFightLevel` where Id=?");
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x0011D138 File Offset: 0x0011B338
		public static MotorFightLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightLevelById.HandleId, ConfigMotorFightLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightLevel?(MotorFightLevel.GetRootAsMotorFightLevel(configBuffer));
				}
			}
			ConfigMotorFightLevelById.LogPair.Clear();
			ConfigMotorFightLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightLevelById.HandleId, 1, p0Id, ConfigMotorFightLevelById.LogPair) || ConfigCommon.Step(ConfigMotorFightLevelById.HandleId, true, ConfigMotorFightLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightLevelById.HandleId, ConfigMotorFightLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightLevelById.HandleId, 0, ConfigMotorFightLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightLevelById.HandleId, ConfigMotorFightLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightLevel rootAsMotorFightLevel = MotorFightLevel.GetRootAsMotorFightLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightLevelById.HandleId, ConfigMotorFightLevelById.LogPair);
			return new MotorFightLevel?(rootAsMotorFightLevel);
		}

		// Token: 0x04002775 RID: 10101
		private const string DB = "db_motorfight.db";

		// Token: 0x04002776 RID: 10102
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002777 RID: 10103
		private const string TABLE = "MotorFightLevel";

		// Token: 0x04002778 RID: 10104
		private const string COMMAND = "select BinData from `MotorFightLevel` where Id=?";

		// Token: 0x04002779 RID: 10105
		private const string KEY_PREFIX = "MotorFightLevelById";

		// Token: 0x0400277A RID: 10106
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400277B RID: 10107
		private static int HandleId;
	}
}
