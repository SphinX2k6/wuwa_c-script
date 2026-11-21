using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074E RID: 1870
	public class ConfigPinballWeaponAttrById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BE4 RID: 11236 RVA: 0x0015507B File Offset: 0x0015327B
		static ConfigPinballWeaponAttrById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponAttrById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponAttrById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x0015509C File Offset: 0x0015329C
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballWeaponAttrById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballWeaponAttrById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_武器.xlsx"),
				new ValueTuple<string, object>("表名", "PinballWeaponAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballWeaponAttr` where Id=?")
			});
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x0015511B File Offset: 0x0015331B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponAttrById.LogPair = null;
			ConfigPinballWeaponAttrById.HandleId = 0;
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x00155129 File Offset: 0x00153329
		public static void Init()
		{
			ConfigPinballWeaponAttrById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponAttrById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponAttr` where Id=?");
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00155144 File Offset: 0x00153344
		public static PinballWeaponAttr? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballWeaponAttrById.HandleId, ConfigPinballWeaponAttrById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponAttrById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballWeaponAttr?(PinballWeaponAttr.GetRootAsPinballWeaponAttr(configBuffer));
				}
			}
			ConfigPinballWeaponAttrById.LogPair.Clear();
			ConfigPinballWeaponAttrById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballWeaponAttrById.HandleId, 1, p0Id, ConfigPinballWeaponAttrById.LogPair) || ConfigCommon.Step(ConfigPinballWeaponAttrById.HandleId, true, ConfigPinballWeaponAttrById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballWeaponAttrById.HandleId, ConfigPinballWeaponAttrById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballWeaponAttrById.HandleId, 0, ConfigPinballWeaponAttrById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballWeaponAttrById.HandleId, ConfigPinballWeaponAttrById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballWeaponAttr rootAsPinballWeaponAttr = PinballWeaponAttr.GetRootAsPinballWeaponAttr(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponAttrById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballWeaponAttrById.HandleId, ConfigPinballWeaponAttrById.LogPair);
			return new PinballWeaponAttr?(rootAsPinballWeaponAttr);
		}

		// Token: 0x04003308 RID: 13064
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003309 RID: 13065
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x0400330A RID: 13066
		private const string TABLE = "PinballWeaponAttr";

		// Token: 0x0400330B RID: 13067
		private const string COMMAND = "select BinData from `PinballWeaponAttr` where Id=?";

		// Token: 0x0400330C RID: 13068
		private const string KEY_PREFIX = "PinballWeaponAttrById";

		// Token: 0x0400330D RID: 13069
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400330E RID: 13070
		private static int HandleId;
	}
}
