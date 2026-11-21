using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F0 RID: 1264
	public class ConfigLineCrossGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DAB RID: 7595 RVA: 0x001046E4 File Offset: 0x001028E4
		static ConfigLineCrossGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLineCrossGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigLineCrossGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00104704 File Offset: 0x00102904
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

		// Token: 0x06001DAD RID: 7597 RVA: 0x00104783 File Offset: 0x00102983
		public static void ResetStaticDefaultValue()
		{
			ConfigLineCrossGroupByGroupId.LogPair = null;
			ConfigLineCrossGroupByGroupId.HandleId = 0;
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00104791 File Offset: 0x00102991
		public static void Init()
		{
			ConfigLineCrossGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigLineCrossGroupByGroupId.HandleId, "db_linecross.db", "select BinData from `LineCrossGroup` where GroupId=?");
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x001047AC File Offset: 0x001029AC
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

		// Token: 0x04002274 RID: 8820
		private const string DB = "db_linecross.db";

		// Token: 0x04002275 RID: 8821
		private const string FILE = "s.十字连线.xlsx";

		// Token: 0x04002276 RID: 8822
		private const string TABLE = "LineCrossGroup";

		// Token: 0x04002277 RID: 8823
		private const string COMMAND = "select BinData from `LineCrossGroup` where GroupId=?";

		// Token: 0x04002278 RID: 8824
		private const string KEY_PREFIX = "LineCrossGroupByGroupId";

		// Token: 0x04002279 RID: 8825
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400227A RID: 8826
		private static int HandleId;
	}
}
