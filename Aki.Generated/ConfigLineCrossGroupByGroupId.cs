using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DA RID: 1242
	public class ConfigLineCrossGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D27 RID: 7463 RVA: 0x000FDF90 File Offset: 0x000FC190
		static ConfigLineCrossGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLineCrossGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigLineCrossGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x000FDFB0 File Offset: 0x000FC1B0
		public static void CreateStaticDefaultValue()
		{
			ConfigLineCrossGroupByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLineCrossGroupByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_linecross.db"),
				new ValueTuple<string, object>("文件", "s.十字连线.xlsx"),
				new ValueTuple<string, object>("表名", "LineCrossGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `LineCrossGroup` where GroupId=?")
			});
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x000FE02F File Offset: 0x000FC22F
		public static void ResetStaticDefaultValue()
		{
			ConfigLineCrossGroupByGroupId.LogPair = null;
			ConfigLineCrossGroupByGroupId.HandleId = 0;
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x000FE03D File Offset: 0x000FC23D
		public static void Init()
		{
			ConfigLineCrossGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigLineCrossGroupByGroupId.HandleId, "db_linecross.db", "select BinData from `LineCrossGroup` where GroupId=?");
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x000FE058 File Offset: 0x000FC258
		public static LineCrossGroup? GetConfig(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLineCrossGroupByGroupId.HandleId, ConfigLineCrossGroupByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LineCrossGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LineCrossGroup?(LineCrossGroup.GetRootAsLineCrossGroup(configBuffer));
				}
			}
			ConfigLineCrossGroupByGroupId.LogPair.Clear();
			ConfigLineCrossGroupByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigLineCrossGroupByGroupId.HandleId, 1, p0GroupId, ConfigLineCrossGroupByGroupId.LogPair) || ConfigCommon.Step(ConfigLineCrossGroupByGroupId.HandleId, true, ConfigLineCrossGroupByGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLineCrossGroupByGroupId.HandleId, ConfigLineCrossGroupByGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLineCrossGroupByGroupId.HandleId, 0, ConfigLineCrossGroupByGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLineCrossGroupByGroupId.HandleId, ConfigLineCrossGroupByGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LineCrossGroup rootAsLineCrossGroup = LineCrossGroup.GetRootAsLineCrossGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LineCrossGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLineCrossGroupByGroupId.HandleId, ConfigLineCrossGroupByGroupId.LogPair);
			return new LineCrossGroup?(rootAsLineCrossGroup);
		}

		// Token: 0x040021DA RID: 8666
		private const string DB = "db_linecross.db";

		// Token: 0x040021DB RID: 8667
		private const string FILE = "s.十字连线.xlsx";

		// Token: 0x040021DC RID: 8668
		private const string TABLE = "LineCrossGroup";

		// Token: 0x040021DD RID: 8669
		private const string COMMAND = "select BinData from `LineCrossGroup` where GroupId=?";

		// Token: 0x040021DE RID: 8670
		private const string KEY_PREFIX = "LineCrossGroupByGroupId";

		// Token: 0x040021DF RID: 8671
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021E0 RID: 8672
		private static int HandleId;
	}
}
