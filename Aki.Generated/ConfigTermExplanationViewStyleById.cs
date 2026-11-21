using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA7 RID: 2727
	public class ConfigTermExplanationViewStyleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FFE RID: 16382 RVA: 0x001C69C1 File Offset: 0x001C4BC1
		static ConfigTermExplanationViewStyleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTermExplanationViewStyleById.CreateStaticDefaultValue), new Action(ConfigTermExplanationViewStyleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x001C69E0 File Offset: 0x001C4BE0
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

		// Token: 0x06004000 RID: 16384 RVA: 0x001C6A5F File Offset: 0x001C4C5F
		public static void ResetStaticDefaultValue()
		{
			ConfigTermExplanationViewStyleById.LogPair = null;
			ConfigTermExplanationViewStyleById.HandleId = 0;
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x001C6A6D File Offset: 0x001C4C6D
		public static void Init()
		{
			ConfigTermExplanationViewStyleById.HandleId = ConfigCommon.InitDataStatement(ConfigTermExplanationViewStyleById.HandleId, "db_termexplanationviewstyle.db", "select BinData from `TermExplanationViewStyle` where Id=?");
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x001C6A88 File Offset: 0x001C4C88
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

		// Token: 0x04004A77 RID: 19063
		private const string DB = "db_termexplanationviewstyle.db";

		// Token: 0x04004A78 RID: 19064
		private const string FILE = "s.术语解释弹窗风格化.xlsx";

		// Token: 0x04004A79 RID: 19065
		private const string TABLE = "TermExplanationViewStyle";

		// Token: 0x04004A7A RID: 19066
		private const string COMMAND = "select BinData from `TermExplanationViewStyle` where Id=?";

		// Token: 0x04004A7B RID: 19067
		private const string KEY_PREFIX = "TermExplanationViewStyleById";

		// Token: 0x04004A7C RID: 19068
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A7D RID: 19069
		private static int HandleId;
	}
}
