using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant
{
	// Token: 0x02004478 RID: 17528
	[NullableContext(1)]
	[Nullable(0)]
	public class MapSoundBoxSfxMgr
	{
		// Token: 0x0602C47E RID: 181374 RVA: 0x00C72170 File Offset: 0x00C70370
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

		// Token: 0x0602C47F RID: 181375 RVA: 0x00C7226C File Offset: 0x00C7046C
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

		// Token: 0x04017CE2 RID: 97506
		public const float SOUND_MARK_INRANGE_DISTANCE_SQUARE = 434850980f;
	}
}
