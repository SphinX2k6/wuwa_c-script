using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A68 RID: 2664
	public class ConfigSubtitleTextByRowNameAndDatatableName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E84 RID: 16004 RVA: 0x001BDF9C File Offset: 0x001BC19C
		static ConfigSubtitleTextByRowNameAndDatatableName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSubtitleTextByRowNameAndDatatableName.CreateStaticDefaultValue), new Action(ConfigSubtitleTextByRowNameAndDatatableName.ResetStaticDefaultValue));
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x001BDFBC File Offset: 0x001BC1BC
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

		// Token: 0x06003E86 RID: 16006 RVA: 0x001BE03B File Offset: 0x001BC23B
		public static void ResetStaticDefaultValue()
		{
			ConfigSubtitleTextByRowNameAndDatatableName.LogPair = null;
			ConfigSubtitleTextByRowNameAndDatatableName.HandleId = 0;
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x001BE049 File Offset: 0x001BC249
		public static void Init()
		{
			ConfigSubtitleTextByRowNameAndDatatableName.HandleId = ConfigCommon.InitDataStatement(ConfigSubtitleTextByRowNameAndDatatableName.HandleId, "db_subtitle_text.db", "select BinData from `SubtitleText` where RowName = ? AND DatatableName = ?");
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x001BE064 File Offset: 0x001BC264
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

		// Token: 0x040048BE RID: 18622
		private const string DB = "db_subtitle_text.db";

		// Token: 0x040048BF RID: 18623
		private const string FILE = "k.可视化编辑/j.剧情/字幕*";

		// Token: 0x040048C0 RID: 18624
		private const string TABLE = "SubtitleText";

		// Token: 0x040048C1 RID: 18625
		private const string COMMAND = "select BinData from `SubtitleText` where RowName = ? AND DatatableName = ?";

		// Token: 0x040048C2 RID: 18626
		private const string KEY_PREFIX = "SubtitleTextByRowNameAndDatatableName";

		// Token: 0x040048C3 RID: 18627
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048C4 RID: 18628
		private static int HandleId;
	}
}
