using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000711 RID: 1809
	public class ConfigPinballCommonItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A76 RID: 10870 RVA: 0x00149670 File Offset: 0x00147870
		static ConfigPinballCommonItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballCommonItemById.CreateStaticDefaultValue), new Action(ConfigPinballCommonItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00149690 File Offset: 0x00147890
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballCommonItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballCommonItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_机关.xlsx"),
				new ValueTuple<string, object>("表名", "PinballCommonItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballCommonItem` where Id=?")
			});
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x0014970F File Offset: 0x0014790F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballCommonItemById.LogPair = null;
			ConfigPinballCommonItemById.HandleId = 0;
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x0014971D File Offset: 0x0014791D
		public static void Init()
		{
			ConfigPinballCommonItemById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballCommonItemById.HandleId, "db_pinballbattle.db", "select BinData from `PinballCommonItem` where Id=?");
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x00149738 File Offset: 0x00147938
		public static PinballCommonItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballCommonItemById.HandleId, ConfigPinballCommonItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballCommonItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballCommonItem?(PinballCommonItem.GetRootAsPinballCommonItem(configBuffer));
				}
			}
			ConfigPinballCommonItemById.LogPair.Clear();
			ConfigPinballCommonItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballCommonItemById.HandleId, 1, p0Id, ConfigPinballCommonItemById.LogPair) || ConfigCommon.Step(ConfigPinballCommonItemById.HandleId, true, ConfigPinballCommonItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballCommonItemById.HandleId, ConfigPinballCommonItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballCommonItemById.HandleId, 0, ConfigPinballCommonItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballCommonItemById.HandleId, ConfigPinballCommonItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballCommonItem rootAsPinballCommonItem = PinballCommonItem.GetRootAsPinballCommonItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballCommonItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballCommonItemById.HandleId, ConfigPinballCommonItemById.LogPair);
			return new PinballCommonItem?(rootAsPinballCommonItem);
		}

		// Token: 0x0400315D RID: 12637
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400315E RID: 12638
		private const string FILE = "x.星弹奇游_机关.xlsx";

		// Token: 0x0400315F RID: 12639
		private const string TABLE = "PinballCommonItem";

		// Token: 0x04003160 RID: 12640
		private const string COMMAND = "select BinData from `PinballCommonItem` where Id=?";

		// Token: 0x04003161 RID: 12641
		private const string KEY_PREFIX = "PinballCommonItemById";

		// Token: 0x04003162 RID: 12642
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003163 RID: 12643
		private static int HandleId;
	}
}
