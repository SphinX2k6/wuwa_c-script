using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A0 RID: 1440
	public class ConfigMotorFightBuffGateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021CD RID: 8653 RVA: 0x0011C14C File Offset: 0x0011A34C
		static ConfigMotorFightBuffGateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightBuffGateById.CreateStaticDefaultValue), new Action(ConfigMotorFightBuffGateById.ResetStaticDefaultValue));
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0011C16C File Offset: 0x0011A36C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightBuffGateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightBuffGateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightBuffGate"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightBuffGate` where Id=?")
			});
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0011C1EB File Offset: 0x0011A3EB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightBuffGateById.LogPair = null;
			ConfigMotorFightBuffGateById.HandleId = 0;
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x0011C1F9 File Offset: 0x0011A3F9
		public static void Init()
		{
			ConfigMotorFightBuffGateById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightBuffGateById.HandleId, "db_motorfight.db", "select BinData from `MotorFightBuffGate` where Id=?");
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x0011C214 File Offset: 0x0011A414
		public static MotorFightBuffGate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightBuffGateById.HandleId, ConfigMotorFightBuffGateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightBuffGateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightBuffGate?(MotorFightBuffGate.GetRootAsMotorFightBuffGate(configBuffer));
				}
			}
			ConfigMotorFightBuffGateById.LogPair.Clear();
			ConfigMotorFightBuffGateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightBuffGateById.HandleId, 1, p0Id, ConfigMotorFightBuffGateById.LogPair) || ConfigCommon.Step(ConfigMotorFightBuffGateById.HandleId, true, ConfigMotorFightBuffGateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightBuffGateById.HandleId, ConfigMotorFightBuffGateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightBuffGateById.HandleId, 0, ConfigMotorFightBuffGateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightBuffGateById.HandleId, ConfigMotorFightBuffGateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightBuffGate rootAsMotorFightBuffGate = MotorFightBuffGate.GetRootAsMotorFightBuffGate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightBuffGateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightBuffGateById.HandleId, ConfigMotorFightBuffGateById.LogPair);
			return new MotorFightBuffGate?(rootAsMotorFightBuffGate);
		}

		// Token: 0x04002744 RID: 10052
		private const string DB = "db_motorfight.db";

		// Token: 0x04002745 RID: 10053
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x04002746 RID: 10054
		private const string TABLE = "MotorFightBuffGate";

		// Token: 0x04002747 RID: 10055
		private const string COMMAND = "select BinData from `MotorFightBuffGate` where Id=?";

		// Token: 0x04002748 RID: 10056
		private const string KEY_PREFIX = "MotorFightBuffGateById";

		// Token: 0x04002749 RID: 10057
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400274A RID: 10058
		private static int HandleId;
	}
}
