using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000739 RID: 1849
	public class ConfigPinballMonsterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B66 RID: 11110 RVA: 0x0015228C File Offset: 0x0015048C
		static ConfigPinballMonsterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterById.CreateStaticDefaultValue), new Action(ConfigPinballMonsterById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x001522AC File Offset: 0x001504AC
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballMonsterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballMonsterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "PinballMonster"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballMonster` where Id=?")
			});
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x0015232B File Offset: 0x0015052B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterById.LogPair = null;
			ConfigPinballMonsterById.HandleId = 0;
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x00152339 File Offset: 0x00150539
		public static void Init()
		{
			ConfigPinballMonsterById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterById.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonster` where Id=?");
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00152354 File Offset: 0x00150554
		public static PinballMonster? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballMonsterById.HandleId, ConfigPinballMonsterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballMonster?(PinballMonster.GetRootAsPinballMonster(configBuffer));
				}
			}
			ConfigPinballMonsterById.LogPair.Clear();
			ConfigPinballMonsterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballMonsterById.HandleId, 1, p0Id, ConfigPinballMonsterById.LogPair) || ConfigCommon.Step(ConfigPinballMonsterById.HandleId, true, ConfigPinballMonsterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballMonsterById.HandleId, ConfigPinballMonsterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballMonsterById.HandleId, 0, ConfigPinballMonsterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballMonsterById.HandleId, ConfigPinballMonsterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballMonster rootAsPinballMonster = PinballMonster.GetRootAsPinballMonster(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballMonsterById.HandleId, ConfigPinballMonsterById.LogPair);
			return new PinballMonster?(rootAsPinballMonster);
		}

		// Token: 0x04003275 RID: 12917
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003276 RID: 12918
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x04003277 RID: 12919
		private const string TABLE = "PinballMonster";

		// Token: 0x04003278 RID: 12920
		private const string COMMAND = "select BinData from `PinballMonster` where Id=?";

		// Token: 0x04003279 RID: 12921
		private const string KEY_PREFIX = "PinballMonsterById";

		// Token: 0x0400327A RID: 12922
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400327B RID: 12923
		private static int HandleId;
	}
}
