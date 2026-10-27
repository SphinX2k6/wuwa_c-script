using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D2 RID: 2514
	public class ConfigTermExplanationViewStyleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B00 RID: 15104 RVA: 0x001A762D File Offset: 0x001A582D
		static ConfigTermExplanationViewStyleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTermExplanationViewStyleById.CreateStaticDefaultValue), new Action(ConfigTermExplanationViewStyleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x001A764C File Offset: 0x001A584C
		public static void CreateStaticDefaultValue()
		{
			ConfigTermExplanationViewStyleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTermExplanationViewStyleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_termexplanationviewstyle.db"),
				new ValueTuple<string, object>("文件", "s.术语解释弹窗风格化.xlsx"),
				new ValueTuple<string, object>("表名", "TermExplanationViewStyle"),
				new ValueTuple<string, object>("语句", "select BinData from `TermExplanationViewStyle` where Id=?")
			});
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x001A76CB File Offset: 0x001A58CB
		public static void ResetStaticDefaultValue()
		{
			ConfigTermExplanationViewStyleById.LogPair = null;
			ConfigTermExplanationViewStyleById.HandleId = 0;
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x001A76D9 File Offset: 0x001A58D9
		public static void Init()
		{
			ConfigTermExplanationViewStyleById.HandleId = ConfigCommon.InitDataStatement(ConfigTermExplanationViewStyleById.HandleId, "db_termexplanationviewstyle.db", "select BinData from `TermExplanationViewStyle` where Id=?");
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x001A76F4 File Offset: 0x001A58F4
		public static TermExplanationViewStyle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTermExplanationViewStyleById.HandleId, ConfigTermExplanationViewStyleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TermExplanationViewStyleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TermExplanationViewStyle?(TermExplanationViewStyle.GetRootAsTermExplanationViewStyle(configBuffer));
				}
			}
			ConfigTermExplanationViewStyleById.LogPair.Clear();
			ConfigTermExplanationViewStyleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTermExplanationViewStyleById.HandleId, 1, p0Id, ConfigTermExplanationViewStyleById.LogPair) || ConfigCommon.Step(ConfigTermExplanationViewStyleById.HandleId, true, ConfigTermExplanationViewStyleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTermExplanationViewStyleById.HandleId, ConfigTermExplanationViewStyleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTermExplanationViewStyleById.HandleId, 0, ConfigTermExplanationViewStyleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTermExplanationViewStyleById.HandleId, ConfigTermExplanationViewStyleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TermExplanationViewStyle rootAsTermExplanationViewStyle = TermExplanationViewStyle.GetRootAsTermExplanationViewStyle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TermExplanationViewStyleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTermExplanationViewStyleById.HandleId, ConfigTermExplanationViewStyleById.LogPair);
			return new TermExplanationViewStyle?(rootAsTermExplanationViewStyle);
		}

		// Token: 0x040044A4 RID: 17572
		private const string DB = "db_termexplanationviewstyle.db";

		// Token: 0x040044A5 RID: 17573
		private const string FILE = "s.术语解释弹窗风格化.xlsx";

		// Token: 0x040044A6 RID: 17574
		private const string TABLE = "TermExplanationViewStyle";

		// Token: 0x040044A7 RID: 17575
		private const string COMMAND = "select BinData from `TermExplanationViewStyle` where Id=?";

		// Token: 0x040044A8 RID: 17576
		private const string KEY_PREFIX = "TermExplanationViewStyleById";

		// Token: 0x040044A9 RID: 17577
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044AA RID: 17578
		private static int HandleId;
	}
}
