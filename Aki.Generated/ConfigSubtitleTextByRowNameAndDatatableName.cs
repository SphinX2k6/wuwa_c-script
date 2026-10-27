using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000993 RID: 2451
	public class ConfigSubtitleTextByRowNameAndDatatableName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003986 RID: 14726 RVA: 0x0019EC08 File Offset: 0x0019CE08
		static ConfigSubtitleTextByRowNameAndDatatableName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSubtitleTextByRowNameAndDatatableName.CreateStaticDefaultValue), new Action(ConfigSubtitleTextByRowNameAndDatatableName.ResetStaticDefaultValue));
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x0019EC28 File Offset: 0x0019CE28
		public static void CreateStaticDefaultValue()
		{
			ConfigSubtitleTextByRowNameAndDatatableName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSubtitleTextByRowNameAndDatatableName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_subtitle_text.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/j.剧情/字幕*"),
				new ValueTuple<string, object>("表名", "SubtitleText"),
				new ValueTuple<string, object>("语句", "select BinData from `SubtitleText` where RowName = ? AND DatatableName = ?")
			});
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x0019ECA7 File Offset: 0x0019CEA7
		public static void ResetStaticDefaultValue()
		{
			ConfigSubtitleTextByRowNameAndDatatableName.LogPair = null;
			ConfigSubtitleTextByRowNameAndDatatableName.HandleId = 0;
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x0019ECB5 File Offset: 0x0019CEB5
		public static void Init()
		{
			ConfigSubtitleTextByRowNameAndDatatableName.HandleId = ConfigCommon.InitDataStatement(ConfigSubtitleTextByRowNameAndDatatableName.HandleId, "db_subtitle_text.db", "select BinData from `SubtitleText` where RowName = ? AND DatatableName = ?");
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x0019ECD0 File Offset: 0x0019CED0
		public static SubtitleText? GetConfig(int p0RowName, string p1DatatableName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSubtitleTextByRowNameAndDatatableName.HandleId, ConfigSubtitleTextByRowNameAndDatatableName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SubtitleTextByRowNameAndDatatableName");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RowName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1DatatableName);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SubtitleText?(SubtitleText.GetRootAsSubtitleText(configBuffer));
				}
			}
			ConfigSubtitleTextByRowNameAndDatatableName.LogPair.Clear();
			ConfigSubtitleTextByRowNameAndDatatableName.LogPair.Add(new ValueTuple<string, object>("RowName", p0RowName));
			ConfigSubtitleTextByRowNameAndDatatableName.LogPair.Add(new ValueTuple<string, object>("DatatableName", p1DatatableName));
			if (!ConfigCommon.BindInt(ConfigSubtitleTextByRowNameAndDatatableName.HandleId, 1, p0RowName, ConfigSubtitleTextByRowNameAndDatatableName.LogPair) || !ConfigCommon.BindString(ConfigSubtitleTextByRowNameAndDatatableName.HandleId, 2, p1DatatableName, ConfigSubtitleTextByRowNameAndDatatableName.LogPair) || ConfigCommon.Step(ConfigSubtitleTextByRowNameAndDatatableName.HandleId, true, ConfigSubtitleTextByRowNameAndDatatableName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSubtitleTextByRowNameAndDatatableName.HandleId, ConfigSubtitleTextByRowNameAndDatatableName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSubtitleTextByRowNameAndDatatableName.HandleId, 0, ConfigSubtitleTextByRowNameAndDatatableName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSubtitleTextByRowNameAndDatatableName.HandleId, ConfigSubtitleTextByRowNameAndDatatableName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SubtitleText rootAsSubtitleText = SubtitleText.GetRootAsSubtitleText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SubtitleTextByRowNameAndDatatableName");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RowName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1DatatableName);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSubtitleTextByRowNameAndDatatableName.HandleId, ConfigSubtitleTextByRowNameAndDatatableName.LogPair);
			return new SubtitleText?(rootAsSubtitleText);
		}

		// Token: 0x040042EB RID: 17131
		private const string DB = "db_subtitle_text.db";

		// Token: 0x040042EC RID: 17132
		private const string FILE = "k.可视化编辑/j.剧情/字幕*";

		// Token: 0x040042ED RID: 17133
		private const string TABLE = "SubtitleText";

		// Token: 0x040042EE RID: 17134
		private const string COMMAND = "select BinData from `SubtitleText` where RowName = ? AND DatatableName = ?";

		// Token: 0x040042EF RID: 17135
		private const string KEY_PREFIX = "SubtitleTextByRowNameAndDatatableName";

		// Token: 0x040042F0 RID: 17136
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042F1 RID: 17137
		private static int HandleId;
	}
}
