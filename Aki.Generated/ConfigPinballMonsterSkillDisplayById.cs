using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000724 RID: 1828
	public class ConfigPinballMonsterSkillDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AE8 RID: 10984 RVA: 0x0014BEE8 File Offset: 0x0014A0E8
		static ConfigPinballMonsterSkillDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterSkillDisplayById.CreateStaticDefaultValue), new Action(ConfigPinballMonsterSkillDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x0014BF08 File Offset: 0x0014A108
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

		// Token: 0x06002AEA RID: 10986 RVA: 0x0014BF87 File Offset: 0x0014A187
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterSkillDisplayById.LogPair = null;
			ConfigPinballMonsterSkillDisplayById.HandleId = 0;
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x0014BF95 File Offset: 0x0014A195
		public static void Init()
		{
			ConfigPinballMonsterSkillDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterSkillDisplayById.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonsterSkillDisplay` where Id=?");
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x0014BFB0 File Offset: 0x0014A1B0
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

		// Token: 0x040031E2 RID: 12770
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031E3 RID: 12771
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x040031E4 RID: 12772
		private const string TABLE = "PinballMonsterSkillDisplay";

		// Token: 0x040031E5 RID: 12773
		private const string COMMAND = "select BinData from `PinballMonsterSkillDisplay` where Id=?";

		// Token: 0x040031E6 RID: 12774
		private const string KEY_PREFIX = "PinballMonsterSkillDisplayById";

		// Token: 0x040031E7 RID: 12775
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031E8 RID: 12776
		private static int HandleId;
	}
}
