using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000722 RID: 1826
	public class ConfigPinballAttrById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002ADC RID: 10972 RVA: 0x0014F1A7 File Offset: 0x0014D3A7
		static ConfigPinballAttrById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballAttrById.CreateStaticDefaultValue), new Action(ConfigPinballAttrById.ResetStaticDefaultValue));
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x0014F1C8 File Offset: 0x0014D3C8
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballAttrById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballAttrById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_局内.xlsx"),
				new ValueTuple<string, object>("表名", "PinballAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballAttr` where Id=?")
			});
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x0014F247 File Offset: 0x0014D447
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballAttrById.LogPair = null;
			ConfigPinballAttrById.HandleId = 0;
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x0014F255 File Offset: 0x0014D455
		public static void Init()
		{
			ConfigPinballAttrById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballAttrById.HandleId, "db_pinballbattle.db", "select BinData from `PinballAttr` where Id=?");
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x0014F270 File Offset: 0x0014D470
		public static PinballAttr? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballAttrById.HandleId, ConfigPinballAttrById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballAttrById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballAttr?(PinballAttr.GetRootAsPinballAttr(configBuffer));
				}
			}
			ConfigPinballAttrById.LogPair.Clear();
			ConfigPinballAttrById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballAttrById.HandleId, 1, p0Id, ConfigPinballAttrById.LogPair) || ConfigCommon.Step(ConfigPinballAttrById.HandleId, true, ConfigPinballAttrById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballAttrById.HandleId, ConfigPinballAttrById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballAttrById.HandleId, 0, ConfigPinballAttrById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballAttrById.HandleId, ConfigPinballAttrById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballAttr rootAsPinballAttr = PinballAttr.GetRootAsPinballAttr(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballAttrById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballAttrById.HandleId, ConfigPinballAttrById.LogPair);
			return new PinballAttr?(rootAsPinballAttr);
		}

		// Token: 0x040031D4 RID: 12756
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031D5 RID: 12757
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x040031D6 RID: 12758
		private const string TABLE = "PinballAttr";

		// Token: 0x040031D7 RID: 12759
		private const string COMMAND = "select BinData from `PinballAttr` where Id=?";

		// Token: 0x040031D8 RID: 12760
		private const string KEY_PREFIX = "PinballAttrById";

		// Token: 0x040031D9 RID: 12761
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031DA RID: 12762
		private static int HandleId;
	}
}
