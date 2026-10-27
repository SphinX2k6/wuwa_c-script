using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Map.View.BaseMap;

namespace CSharpScript.Game.Module.Map.Mark.Debug
{
	// Token: 0x020054C6 RID: 21702
	[NullableContext(1)]
	[Nullable(0)]
	public static class MapDebugger
	{
		// Token: 0x06037682 RID: 226946 RVA: 0x00D287B2 File Offset: 0x00D269B2
		private static string DumpMarkItem(BaseMap map, MarkItem markItem)
		{
			return string.Empty;
		}

		// Token: 0x06037683 RID: 226947 RVA: 0x00D287B9 File Offset: 0x00D269B9
		public static string DumpMarkItemForUi(BaseMap map, MarkItem markItem)
		{
			return string.Empty;
		}

		// Token: 0x06037684 RID: 226948 RVA: 0x00D287C0 File Offset: 0x00D269C0
		[Conditional("DEBUG")]
		public static void PrintMarkItemDumpInfo(BaseMap map, MarkItem markItem)
		{
		}

		// Token: 0x06037685 RID: 226949 RVA: 0x00D287C4 File Offset: 0x00D269C4
		public static void PrintTrackDataInfo(string title, ITrackData data)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("------------------------追踪信息Start--------------------");
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("TrackSource:");
			appendInterpolatedStringHandler.AppendFormatted<ETrackSource>(data.TrackSource);
			stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("MarkType:");
			appendInterpolatedStringHandler.AppendFormatted<EMarkType?>(data.MarkType);
			stringBuilder4.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("TrackId:");
			appendInterpolatedStringHandler.AppendFormatted<int>(data.Id);
			stringBuilder5.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder6 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("IconPath:");
			appendInterpolatedStringHandler.AppendFormatted(data.IconPath);
			stringBuilder6.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder7 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("TrackTarget:");
			appendInterpolatedStringHandler.AppendFormatted<TTrackTarget>(data.TrackTarget);
			stringBuilder7.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder8 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("TrackInstanceId:");
			appendInterpolatedStringHandler.AppendFormatted<int?>(data.TrackInstanceId);
			stringBuilder8.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder9 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(24, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("TrackAutoCancelDistance:");
			appendInterpolatedStringHandler.AppendFormatted<float?>(data.TrackAutoCancelDistance);
			stringBuilder9.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder10 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("IsSubTrack:");
			appendInterpolatedStringHandler.AppendFormatted<bool?>(data.IsSubTrack);
			stringBuilder10.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder11 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("TrackHideDis:");
			appendInterpolatedStringHandler.AppendFormatted<float?>(data.TrackHideDis);
			stringBuilder11.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder12 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("ShowGroupId:");
			appendInterpolatedStringHandler.AppendFormatted<int?>(data.ShowGroupId);
			stringBuilder12.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder13 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("TrackType:");
			appendInterpolatedStringHandler.AppendFormatted<ETrackType?>(data.TrackType);
			stringBuilder13.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder14 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("AutoHideTrack:");
			appendInterpolatedStringHandler.AppendFormatted<bool?>(data.AutoHideTrack);
			stringBuilder14.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder15 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("PrefabPath:");
			appendInterpolatedStringHandler.AppendFormatted(data.PrefabPath);
			stringBuilder15.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder16 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(7, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("Offset:");
			appendInterpolatedStringHandler.AppendFormatted<Vector>(data.Offset);
			stringBuilder16.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder17 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("IsInTrackRange:");
			appendInterpolatedStringHandler.AppendFormatted<bool?>(data.IsInTrackRange);
			stringBuilder17.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder18 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(7, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("AreaId:");
			appendInterpolatedStringHandler.AppendFormatted<int?>(data.AreaId);
			stringBuilder18.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder19 = stringBuilder2;
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendLiteral("MultiMapId:");
			appendInterpolatedStringHandler.AppendFormatted<int?>(data.MultiMapId);
			stringBuilder19.AppendLine(ref appendInterpolatedStringHandler);
			stringBuilder.AppendLine("------------------------追踪信息End------------------");
			string item = stringBuilder.ToString();
			ELogAuthor author = ELogAuthor.LRX;
			string message = "地图调试信息->" + title;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("追踪信息", item);
			MapLogger.Warn(author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}
}
