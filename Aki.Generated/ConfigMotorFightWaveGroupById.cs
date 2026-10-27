using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A2 RID: 1442
	public class ConfigMotorFightWaveGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021D9 RID: 8665 RVA: 0x00118FA4 File Offset: 0x001171A4
		static ConfigMotorFightWaveGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightWaveGroupById.CreateStaticDefaultValue), new Action(ConfigMotorFightWaveGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00118FC4 File Offset: 0x001171C4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightWaveGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightWaveGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightWaveGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightWaveGroup` where GroupId=?")
			});
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00119043 File Offset: 0x00117243
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightWaveGroupById.LogPair = null;
			ConfigMotorFightWaveGroupById.HandleId = 0;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x00119051 File Offset: 0x00117251
		public static void Init()
		{
			ConfigMotorFightWaveGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightWaveGroupById.HandleId, "db_motorfight.db", "select BinData from `MotorFightWaveGroup` where GroupId=?");
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0011906C File Offset: 0x0011726C
		public static MotorFightWaveGroup? GetConfig(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightWaveGroupById.HandleId, ConfigMotorFightWaveGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightWaveGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightWaveGroup?(MotorFightWaveGroup.GetRootAsMotorFightWaveGroup(configBuffer));
				}
			}
			ConfigMotorFightWaveGroupById.LogPair.Clear();
			ConfigMotorFightWaveGroupById.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigMotorFightWaveGroupById.HandleId, 1, p0GroupId, ConfigMotorFightWaveGroupById.LogPair) || ConfigCommon.Step(ConfigMotorFightWaveGroupById.HandleId, true, ConfigMotorFightWaveGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightWaveGroupById.HandleId, ConfigMotorFightWaveGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightWaveGroupById.HandleId, 0, ConfigMotorFightWaveGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightWaveGroupById.HandleId, ConfigMotorFightWaveGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightWaveGroup rootAsMotorFightWaveGroup = MotorFightWaveGroup.GetRootAsMotorFightWaveGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightWaveGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightWaveGroupById.HandleId, ConfigMotorFightWaveGroupById.LogPair);
			return new MotorFightWaveGroup?(rootAsMotorFightWaveGroup);
		}

		// Token: 0x04002752 RID: 10066
		private const string DB = "db_motorfight.db";

		// Token: 0x04002753 RID: 10067
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x04002754 RID: 10068
		private const string TABLE = "MotorFightWaveGroup";

		// Token: 0x04002755 RID: 10069
		private const string COMMAND = "select BinData from `MotorFightWaveGroup` where GroupId=?";

		// Token: 0x04002756 RID: 10070
		private const string KEY_PREFIX = "MotorFightWaveGroupById";

		// Token: 0x04002757 RID: 10071
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002758 RID: 10072
		private static int HandleId;
	}
}
