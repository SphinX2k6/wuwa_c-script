using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073B RID: 1851
	public class ConfigPinballWeaponTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B72 RID: 11122 RVA: 0x0014F168 File Offset: 0x0014D368
		static ConfigPinballWeaponTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponTypeById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x0014F188 File Offset: 0x0014D388
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

		// Token: 0x06002B74 RID: 11124 RVA: 0x0014F207 File Offset: 0x0014D407
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponTypeById.LogPair = null;
			ConfigPinballWeaponTypeById.HandleId = 0;
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x0014F215 File Offset: 0x0014D415
		public static void Init()
		{
			ConfigPinballWeaponTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponTypeById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponType` where Id=?");
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x0014F230 File Offset: 0x0014D430
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

		// Token: 0x04003283 RID: 12931
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003284 RID: 12932
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x04003285 RID: 12933
		private const string TABLE = "PinballWeaponType";

		// Token: 0x04003286 RID: 12934
		private const string COMMAND = "select BinData from `PinballWeaponType` where Id=?";

		// Token: 0x04003287 RID: 12935
		private const string KEY_PREFIX = "PinballWeaponTypeById";

		// Token: 0x04003288 RID: 12936
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003289 RID: 12937
		private static int HandleId;
	}
}
