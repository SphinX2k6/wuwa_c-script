using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant
{
	// Token: 0x02005495 RID: 21653
	[NullableContext(1)]
	[Nullable(0)]
	public class MapSoundBoxSfxMgr
	{
		// Token: 0x06037528 RID: 226600 RVA: 0x00D225B4 File Offset: 0x00D207B4
		public unsafe void OnMarkItemBecomeVisible(MarkItem markItem, Vector playerLocation)
		{
			if (markItem.MarkType != EMarkType.SoundBox && markItem.MarkType != EMarkType.CalmingWindBell)
			{
				return;
			}
			int markId = markItem.MarkId;
			if (TeleportModel.Instance.IsTeleport)
			{
				WorldMapModel.Instance.SetPlaySoundMarkSfxForbidden(markId, false);
				return;
			}
			double num = Vector.DistSquared(playerLocation, markItem.WorldPosition);
			if (num >= 434850976.0)
			{
				return;
			}
			bool flag = WorldMapModel.Instance.IsSoundMarkSfxForbidden(markId);
			bool flag2 = WorldMapModel.Instance.IsSoundMarkSfxCoolingDown(markId);
			WorldMapModel.Instance.SetPlaySoundMarkSfxForbidden(markId, true);
			if (!flag && !flag2)
			{
				ELogAuthor author = ELogAuthor.LYX;
				string message = "[地图系统] 地图声匣子音效 播放 ->OnMarkItemBecomeVisible And PlaySfx";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MarkId", markId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("distSquare", num);
				MapLogger.Debug(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				WorldMapModel.Instance.RecordPlaySoundMarkSfx(markId);
				AudioSystem.Instance.PostEvent("play_ui_find_shengxia");
			}
		}

		// Token: 0x06037529 RID: 226601 RVA: 0x00D226B0 File Offset: 0x00D208B0
		public void OnMarkItemBecomeInvisible(MarkItem markItem)
		{
			int markId = markItem.MarkId;
			if (markItem.MarkType != EMarkType.SoundBox && markItem.MarkType != EMarkType.CalmingWindBell)
			{
				return;
			}
			ELogAuthor author = ELogAuthor.LYX;
			string message = "[地图系统] 地图声匣子音效 ->OnMarkItemBecomeInvisible";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", markId);
			MapLogger.Debug(author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			WorldMapModel.Instance.SetPlaySoundMarkSfxForbidden(markId, false);
		}

		// Token: 0x0401D246 RID: 119366
		public const float SOUND_MARK_INRANGE_DISTANCE_SQUARE = 434850980f;
	}
}
