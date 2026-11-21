using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000729 RID: 1833
	public class ConfigPinballCommonItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B06 RID: 11014 RVA: 0x001500EC File Offset: 0x0014E2EC
		static ConfigPinballCommonItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballCommonItemById.CreateStaticDefaultValue), new Action(ConfigPinballCommonItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x0015010C File Offset: 0x0014E30C
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

		// Token: 0x06002B08 RID: 11016 RVA: 0x0015018B File Offset: 0x0014E38B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballCommonItemById.LogPair = null;
			ConfigPinballCommonItemById.HandleId = 0;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00150199 File Offset: 0x0014E399
		public static void Init()
		{
			ConfigPinballCommonItemById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballCommonItemById.HandleId, "db_pinballbattle.db", "select BinData from `PinballCommonItem` where Id=?");
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x001501B4 File Offset: 0x0014E3B4
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

		// Token: 0x04003205 RID: 12805
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003206 RID: 12806
		private const string FILE = "x.星弹奇游_机关.xlsx";

		// Token: 0x04003207 RID: 12807
		private const string TABLE = "PinballCommonItem";

		// Token: 0x04003208 RID: 12808
		private const string COMMAND = "select BinData from `PinballCommonItem` where Id=?";

		// Token: 0x04003209 RID: 12809
		private const string KEY_PREFIX = "PinballCommonItemById";

		// Token: 0x0400320A RID: 12810
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400320B RID: 12811
		private static int HandleId;
	}
}
