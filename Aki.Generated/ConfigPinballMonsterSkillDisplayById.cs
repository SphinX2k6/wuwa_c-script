using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073C RID: 1852
	public class ConfigPinballMonsterSkillDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B78 RID: 11128 RVA: 0x00152964 File Offset: 0x00150B64
		static ConfigPinballMonsterSkillDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterSkillDisplayById.CreateStaticDefaultValue), new Action(ConfigPinballMonsterSkillDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00152984 File Offset: 0x00150B84
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballMonsterSkillDisplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballMonsterSkillDisplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "PinballMonsterSkillDisplay"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballMonsterSkillDisplay` where Id=?")
			});
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00152A03 File Offset: 0x00150C03
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterSkillDisplayById.LogPair = null;
			ConfigPinballMonsterSkillDisplayById.HandleId = 0;
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x00152A11 File Offset: 0x00150C11
		public static void Init()
		{
			ConfigPinballMonsterSkillDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterSkillDisplayById.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonsterSkillDisplay` where Id=?");
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00152A2C File Offset: 0x00150C2C
		public static PinballMonsterSkillDisplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballMonsterSkillDisplayById.HandleId, ConfigPinballMonsterSkillDisplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterSkillDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballMonsterSkillDisplay?(PinballMonsterSkillDisplay.GetRootAsPinballMonsterSkillDisplay(configBuffer));
				}
			}
			ConfigPinballMonsterSkillDisplayById.LogPair.Clear();
			ConfigPinballMonsterSkillDisplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballMonsterSkillDisplayById.HandleId, 1, p0Id, ConfigPinballMonsterSkillDisplayById.LogPair) || ConfigCommon.Step(ConfigPinballMonsterSkillDisplayById.HandleId, true, ConfigPinballMonsterSkillDisplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballMonsterSkillDisplayById.HandleId, ConfigPinballMonsterSkillDisplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballMonsterSkillDisplayById.HandleId, 0, ConfigPinballMonsterSkillDisplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballMonsterSkillDisplayById.HandleId, ConfigPinballMonsterSkillDisplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballMonsterSkillDisplay rootAsPinballMonsterSkillDisplay = PinballMonsterSkillDisplay.GetRootAsPinballMonsterSkillDisplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterSkillDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballMonsterSkillDisplayById.HandleId, ConfigPinballMonsterSkillDisplayById.LogPair);
			return new PinballMonsterSkillDisplay?(rootAsPinballMonsterSkillDisplay);
		}

		// Token: 0x0400328A RID: 12938
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400328B RID: 12939
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x0400328C RID: 12940
		private const string TABLE = "PinballMonsterSkillDisplay";

		// Token: 0x0400328D RID: 12941
		private const string COMMAND = "select BinData from `PinballMonsterSkillDisplay` where Id=?";

		// Token: 0x0400328E RID: 12942
		private const string KEY_PREFIX = "PinballMonsterSkillDisplayById";

		// Token: 0x0400328F RID: 12943
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003290 RID: 12944
		private static int HandleId;
	}
}
