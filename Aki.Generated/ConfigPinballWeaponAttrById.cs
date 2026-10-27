using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000736 RID: 1846
	public class ConfigPinballWeaponAttrById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B54 RID: 11092 RVA: 0x0014E5FF File Offset: 0x0014C7FF
		static ConfigPinballWeaponAttrById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponAttrById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponAttrById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x0014E620 File Offset: 0x0014C820
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

		// Token: 0x06002B56 RID: 11094 RVA: 0x0014E69F File Offset: 0x0014C89F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponAttrById.LogPair = null;
			ConfigPinballWeaponAttrById.HandleId = 0;
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x0014E6AD File Offset: 0x0014C8AD
		public static void Init()
		{
			ConfigPinballWeaponAttrById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponAttrById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponAttr` where Id=?");
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x0014E6C8 File Offset: 0x0014C8C8
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

		// Token: 0x04003260 RID: 12896
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003261 RID: 12897
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x04003262 RID: 12898
		private const string TABLE = "PinballWeaponAttr";

		// Token: 0x04003263 RID: 12899
		private const string COMMAND = "select BinData from `PinballWeaponAttr` where Id=?";

		// Token: 0x04003264 RID: 12900
		private const string KEY_PREFIX = "PinballWeaponAttrById";

		// Token: 0x04003265 RID: 12901
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003266 RID: 12902
		private static int HandleId;
	}
}
