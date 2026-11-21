using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000753 RID: 1875
	public class ConfigPinballWeaponTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C02 RID: 11266 RVA: 0x00155BE4 File Offset: 0x00153DE4
		static ConfigPinballWeaponTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponTypeById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x00155C04 File Offset: 0x00153E04
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballWeaponTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballWeaponTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_武器.xlsx"),
				new ValueTuple<string, object>("表名", "PinballWeaponType"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballWeaponType` where Id=?")
			});
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00155C83 File Offset: 0x00153E83
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponTypeById.LogPair = null;
			ConfigPinballWeaponTypeById.HandleId = 0;
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00155C91 File Offset: 0x00153E91
		public static void Init()
		{
			ConfigPinballWeaponTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponTypeById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponType` where Id=?");
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00155CAC File Offset: 0x00153EAC
		public static PinballWeaponType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballWeaponTypeById.HandleId, ConfigPinballWeaponTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballWeaponType?(PinballWeaponType.GetRootAsPinballWeaponType(configBuffer));
				}
			}
			ConfigPinballWeaponTypeById.LogPair.Clear();
			ConfigPinballWeaponTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballWeaponTypeById.HandleId, 1, p0Id, ConfigPinballWeaponTypeById.LogPair) || ConfigCommon.Step(ConfigPinballWeaponTypeById.HandleId, true, ConfigPinballWeaponTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballWeaponTypeById.HandleId, ConfigPinballWeaponTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballWeaponTypeById.HandleId, 0, ConfigPinballWeaponTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballWeaponTypeById.HandleId, ConfigPinballWeaponTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballWeaponType rootAsPinballWeaponType = PinballWeaponType.GetRootAsPinballWeaponType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballWeaponTypeById.HandleId, ConfigPinballWeaponTypeById.LogPair);
			return new PinballWeaponType?(rootAsPinballWeaponType);
		}

		// Token: 0x0400332B RID: 13099
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400332C RID: 13100
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x0400332D RID: 13101
		private const string TABLE = "PinballWeaponType";

		// Token: 0x0400332E RID: 13102
		private const string COMMAND = "select BinData from `PinballWeaponType` where Id=?";

		// Token: 0x0400332F RID: 13103
		private const string KEY_PREFIX = "PinballWeaponTypeById";

		// Token: 0x04003330 RID: 13104
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003331 RID: 13105
		private static int HandleId;
	}
}
