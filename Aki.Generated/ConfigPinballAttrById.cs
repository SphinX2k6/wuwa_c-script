using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070A RID: 1802
	public class ConfigPinballAttrById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A4C RID: 10828 RVA: 0x0014872B File Offset: 0x0014692B
		static ConfigPinballAttrById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballAttrById.CreateStaticDefaultValue), new Action(ConfigPinballAttrById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x0014874C File Offset: 0x0014694C
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

		// Token: 0x06002A4E RID: 10830 RVA: 0x001487CB File Offset: 0x001469CB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballAttrById.LogPair = null;
			ConfigPinballAttrById.HandleId = 0;
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x001487D9 File Offset: 0x001469D9
		public static void Init()
		{
			ConfigPinballAttrById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballAttrById.HandleId, "db_pinballbattle.db", "select BinData from `PinballAttr` where Id=?");
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x001487F4 File Offset: 0x001469F4
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

		// Token: 0x0400312C RID: 12588
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400312D RID: 12589
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x0400312E RID: 12590
		private const string TABLE = "PinballAttr";

		// Token: 0x0400312F RID: 12591
		private const string COMMAND = "select BinData from `PinballAttr` where Id=?";

		// Token: 0x04003130 RID: 12592
		private const string KEY_PREFIX = "PinballAttrById";

		// Token: 0x04003131 RID: 12593
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003132 RID: 12594
		private static int HandleId;
	}
}
