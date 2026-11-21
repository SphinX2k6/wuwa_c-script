using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000841 RID: 2113
	public class ConfigRogueHotEntryGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003198 RID: 12696 RVA: 0x00175320 File Offset: 0x00173520
		static ConfigRogueHotEntryGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueHotEntryGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigRogueHotEntryGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x00175340 File Offset: 0x00173540
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueHotEntryGroupByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueHotEntryGroupByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽经典复开.xlsx"),
				new ValueTuple<string, object>("表名", "RogueHotEntryGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueHotEntryGroup` where GroupId=?")
			});
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x001753BF File Offset: 0x001735BF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueHotEntryGroupByGroupId.LogPair = null;
			ConfigRogueHotEntryGroupByGroupId.HandleId = 0;
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x001753CD File Offset: 0x001735CD
		public static void Init()
		{
			ConfigRogueHotEntryGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueHotEntryGroupByGroupId.HandleId, "db_rogue.db", "select BinData from `RogueHotEntryGroup` where GroupId=?");
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x001753E8 File Offset: 0x001735E8
		public static RogueHotEntryGroup? GetConfig(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueHotEntryGroupByGroupId.HandleId, ConfigRogueHotEntryGroupByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueHotEntryGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueHotEntryGroup?(RogueHotEntryGroup.GetRootAsRogueHotEntryGroup(configBuffer));
				}
			}
			ConfigRogueHotEntryGroupByGroupId.LogPair.Clear();
			ConfigRogueHotEntryGroupByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigRogueHotEntryGroupByGroupId.HandleId, 1, p0GroupId, ConfigRogueHotEntryGroupByGroupId.LogPair) || ConfigCommon.Step(ConfigRogueHotEntryGroupByGroupId.HandleId, true, ConfigRogueHotEntryGroupByGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueHotEntryGroupByGroupId.HandleId, ConfigRogueHotEntryGroupByGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueHotEntryGroupByGroupId.HandleId, 0, ConfigRogueHotEntryGroupByGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueHotEntryGroupByGroupId.HandleId, ConfigRogueHotEntryGroupByGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueHotEntryGroup rootAsRogueHotEntryGroup = RogueHotEntryGroup.GetRootAsRogueHotEntryGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueHotEntryGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueHotEntryGroupByGroupId.HandleId, ConfigRogueHotEntryGroupByGroupId.LogPair);
			return new RogueHotEntryGroup?(rootAsRogueHotEntryGroup);
		}

		// Token: 0x040039AD RID: 14765
		private const string DB = "db_rogue.db";

		// Token: 0x040039AE RID: 14766
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x040039AF RID: 14767
		private const string TABLE = "RogueHotEntryGroup";

		// Token: 0x040039B0 RID: 14768
		private const string COMMAND = "select BinData from `RogueHotEntryGroup` where GroupId=?";

		// Token: 0x040039B1 RID: 14769
		private const string KEY_PREFIX = "RogueHotEntryGroupByGroupId";

		// Token: 0x040039B2 RID: 14770
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039B3 RID: 14771
		private static int HandleId;
	}
}
