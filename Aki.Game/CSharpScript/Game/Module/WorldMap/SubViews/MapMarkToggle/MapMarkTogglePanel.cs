using System;
using System.Collections.Generic;
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
	// Token: 0x02003737 RID: 14135
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkTogglePanel : WorldMapSecondaryUi
	{
		// Token: 0x06024C42 RID: 150594 RVA: 0x00A62A8D File Offset: 0x00A60C8D
		public override string GetResourceId()
		{
			return "UiView_MapPopupAssistant";
		}

		// Token: 0x06024C43 RID: 150595 RVA: 0x00A62A94 File Offset: 0x00A60C94
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

		// Token: 0x06024C44 RID: 150596 RVA: 0x00A62B60 File Offset: 0x00A60D60
		protected override UniTask OnBeforeStartAsync()
		{
			MapMarkTogglePanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapMarkTogglePanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024C45 RID: 150597 RVA: 0x00A62BA4 File Offset: 0x00A60DA4
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

		// Token: 0x06024C46 RID: 150598 RVA: 0x00A62BEF File Offset: 0x00A60DEF
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
		}

		// Token: 0x06024C47 RID: 150599 RVA: 0x00A62BF1 File Offset: 0x00A60DF1
		protected override void OnCloseWorldMapSecondaryUi()
		{
		}

		// Token: 0x06024C48 RID: 150600 RVA: 0x00A62BF3 File Offset: 0x00A60DF3
		protected override void OnBeforeDestroy()
		{
			this.PopupCaption = null;
			this.MarkToggleLayout = null;
		}

		// Token: 0x06024C49 RID: 150601 RVA: 0x00A62C03 File Offset: 0x00A60E03
		protected override bool GetNeedBgItem()
		{
			return true;
		}

		// Token: 0x06024C4A RID: 150602 RVA: 0x00A62C08 File Offset: 0x00A60E08
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
				return NoLinq.WhereToArray<IMapMarkToggleItemData>(list, (IMapMarkToggleItemData data) => data.ShowInRecallInstance.GetValueOrDefault());
			}
			return list.ToArray();
		}

		// Token: 0x06024C4B RID: 150603 RVA: 0x00A62CC7 File Offset: 0x00A60EC7
		private EToggleState GetCustomMarkToggleState()
		{
			if (!WorldMapModel.Instance.CustomMarksIsShow)
			{
				return EToggleState.ETT_UnChecked;
			}
			return EToggleState.ETT_Checked;
		}

		// Token: 0x06024C4C RID: 150604 RVA: 0x00A62CD8 File Offset: 0x00A60ED8
		private bool SetCustomMarkToggleState(EToggleState state)
		{
			return WorldMapModel.Instance.SetCustomMarksShow(state == EToggleState.ETT_Checked);
		}

		// Token: 0x06024C4D RID: 150605 RVA: 0x00A62CE8 File Offset: 0x00A60EE8
		private EToggleState GetFinishedPlayPointToggleState()
		{
			if (!WorldMapModel.Instance.CompletedPlayPointMarkIsShow)
			{
				return EToggleState.ETT_UnChecked;
			}
			return EToggleState.ETT_Checked;
		}

		// Token: 0x06024C4E RID: 150606 RVA: 0x00A62CF9 File Offset: 0x00A60EF9
		private bool SetFinishedPlayPointToggleState(EToggleState state)
		{
			return WorldMapModel.Instance.SetCompletedPlayPointMarkShow(state == EToggleState.ETT_Checked);
		}

		// Token: 0x06024C4F RID: 150607 RVA: 0x00A62D0C File Offset: 0x00A60F0C
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

		// Token: 0x06024C50 RID: 150608 RVA: 0x00A62D77 File Offset: 0x00A60F77
		private void SetJoystickClickMultiplier(float progress)
		{
			WorldMapModel.Instance.SetJoystickClickMultiplier(progress);
		}

		// Token: 0x04014667 RID: 83559
		[Nullable(2)]
		private PopupCaptionItem PopupCaption;

		// Token: 0x04014668 RID: 83560
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapMarkToggleItem, IMapMarkToggleItemData> MarkToggleLayout;

		// Token: 0x04014669 RID: 83561
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapMarkProgressItem, IMapMarkProgressItemData> MarkProgressLayout;

		// Token: 0x02009486 RID: 38022
		[NullableContext(0)]
		public static class EChildType
		{
			// Token: 0x0402E6C2 RID: 190146
			public const int ItemCaption = 0;

			// Token: 0x0402E6C3 RID: 190147
			public const int VerticalLayoutNote = 1;

			// Token: 0x0402E6C4 RID: 190148
			public const int ItemMarkToggle = 2;

			// Token: 0x0402E6C5 RID: 190149
			public const int VerticalLayoutProgress = 3;

			// Token: 0x0402E6C6 RID: 190150
			public const int PanelProgress = 4;
		}
	}
}
