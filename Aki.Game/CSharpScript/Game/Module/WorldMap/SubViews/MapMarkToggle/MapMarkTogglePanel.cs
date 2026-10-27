using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02004806 RID: 18438
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkTogglePanel : WorldMapSecondaryUi
	{
		// Token: 0x06030472 RID: 197746 RVA: 0x00B32B25 File Offset: 0x00B30D25
		public override string GetResourceId()
		{
			return "UiView_MapPopupAssistant";
		}

		// Token: 0x06030473 RID: 197747 RVA: 0x00B32B2C File Offset: 0x00B30D2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030474 RID: 197748 RVA: 0x00B32BF8 File Offset: 0x00B30DF8
		protected override UniTask OnBeforeStartAsync()
		{
			MapMarkTogglePanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapMarkTogglePanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030475 RID: 197749 RVA: 0x00B32C3C File Offset: 0x00B30E3C
		protected override UniTask OnBeforeShowWorldMapSecondaryUiAsync(params object[] param)
		{
			MapMarkTogglePanel.<OnBeforeShowWorldMapSecondaryUiAsync>d__7 <OnBeforeShowWorldMapSecondaryUiAsync>d__;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>4__this = this;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.param = param;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>1__state = -1;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder.Start<MapMarkTogglePanel.<OnBeforeShowWorldMapSecondaryUiAsync>d__7>(ref <OnBeforeShowWorldMapSecondaryUiAsync>d__);
			return <OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030476 RID: 197750 RVA: 0x00B32C87 File Offset: 0x00B30E87
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
		}

		// Token: 0x06030477 RID: 197751 RVA: 0x00B32C89 File Offset: 0x00B30E89
		protected override void OnCloseWorldMapSecondaryUi()
		{
		}

		// Token: 0x06030478 RID: 197752 RVA: 0x00B32C8B File Offset: 0x00B30E8B
		protected override void OnBeforeDestroy()
		{
			this.PopupCaption = null;
			this.MarkToggleLayout = null;
		}

		// Token: 0x06030479 RID: 197753 RVA: 0x00B32C9B File Offset: 0x00B30E9B
		protected override bool GetNeedBgItem()
		{
			return true;
		}

		// Token: 0x0603047A RID: 197754 RVA: 0x00B32CA0 File Offset: 0x00B30EA0
		private IMapMarkToggleItemData[] GetMarkToggleDataList()
		{
			List<IMapMarkToggleItemData> list = new List<IMapMarkToggleItemData>();
			list.Add(new MapMarkToggleItemData
			{
				NameId = "CustomMark_Text",
				GetToggleResultCallback = new Func<EToggleState>(this.GetCustomMarkToggleState),
				SetToggleStateCallback = new Func<EToggleState, bool>(this.SetCustomMarkToggleState)
			});
			list.Add(new MapMarkToggleItemData
			{
				NameId = "CompletedGamePlayPoints_Text",
				GetToggleResultCallback = new Func<EToggleState>(this.GetFinishedPlayPointToggleState),
				SetToggleStateCallback = new Func<EToggleState, bool>(this.SetFinishedPlayPointToggleState)
			});
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				return (from data in list
				where data.ShowInRecallInstance.GetValueOrDefault()
				select data).ToArray<IMapMarkToggleItemData>();
			}
			return list.ToArray();
		}

		// Token: 0x0603047B RID: 197755 RVA: 0x00B32D64 File Offset: 0x00B30F64
		private EToggleState GetCustomMarkToggleState()
		{
			if (!WorldMapModel.Instance.CustomMarksIsShow)
			{
				return EToggleState.ETT_UnChecked;
			}
			return EToggleState.ETT_Checked;
		}

		// Token: 0x0603047C RID: 197756 RVA: 0x00B32D75 File Offset: 0x00B30F75
		private bool SetCustomMarkToggleState(EToggleState state)
		{
			return WorldMapModel.Instance.SetCustomMarksShow(state == EToggleState.ETT_Checked);
		}

		// Token: 0x0603047D RID: 197757 RVA: 0x00B32D85 File Offset: 0x00B30F85
		private EToggleState GetFinishedPlayPointToggleState()
		{
			if (!WorldMapModel.Instance.CompletedPlayPointMarkIsShow)
			{
				return EToggleState.ETT_UnChecked;
			}
			return EToggleState.ETT_Checked;
		}

		// Token: 0x0603047E RID: 197758 RVA: 0x00B32D96 File Offset: 0x00B30F96
		private bool SetFinishedPlayPointToggleState(EToggleState state)
		{
			return WorldMapModel.Instance.SetCompletedPlayPointMarkShow(state == EToggleState.ETT_Checked);
		}

		// Token: 0x0603047F RID: 197759 RVA: 0x00B32DA8 File Offset: 0x00B30FA8
		private IMapMarkProgressItemData[] GetMarkProgressDataList()
		{
			return new IMapMarkProgressItemData[]
			{
				new MapMarkProgressItemData
				{
					NameId = "GamePadMark_Text",
					Progress = WorldMapModel.Instance.JoystickClickMultiplier,
					ProgressMax = ConfigCommonParamById.GetFloatConfig("MapJoystickClickMaxMultiplier").GetValueOrDefault(),
					ProgressMin = 0f,
					SetProgressCallback = new Action<float>(this.SetJoystickClickMultiplier)
				}
			};
		}

		// Token: 0x06030480 RID: 197760 RVA: 0x00B32E13 File Offset: 0x00B31013
		private void SetJoystickClickMultiplier(float progress)
		{
			WorldMapModel.Instance.SetJoystickClickMultiplier(progress);
		}

		// Token: 0x04019FB3 RID: 106419
		[Nullable(2)]
		private PopupCaptionItem PopupCaption;

		// Token: 0x04019FB4 RID: 106420
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapMarkToggleItem, IMapMarkToggleItemData> MarkToggleLayout;

		// Token: 0x04019FB5 RID: 106421
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapMarkProgressItem, IMapMarkProgressItemData> MarkProgressLayout;

		// Token: 0x0200AAD5 RID: 43733
		[NullableContext(0)]
		public static class EChildType
		{
			// Token: 0x04033F3F RID: 212799
			public const int ItemCaption = 0;

			// Token: 0x04033F40 RID: 212800
			public const int VerticalLayoutNote = 1;

			// Token: 0x04033F41 RID: 212801
			public const int ItemMarkToggle = 2;

			// Token: 0x04033F42 RID: 212802
			public const int VerticalLayoutProgress = 3;

			// Token: 0x04033F43 RID: 212803
			public const int PanelProgress = 4;
		}
	}
}
