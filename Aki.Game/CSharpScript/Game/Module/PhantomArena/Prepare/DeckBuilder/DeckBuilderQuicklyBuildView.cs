using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckDetail;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004172 RID: 16754
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderQuicklyBuildView : UiViewBase
	{
		// Token: 0x0602A677 RID: 173687 RVA: 0x00BF5A42 File Offset: 0x00BF3C42
		public DeckBuilderQuicklyBuildView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602A678 RID: 173688 RVA: 0x00BF5A58 File Offset: 0x00BF3C58
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnConfirmButtonClick)),
				new ValueTuple<int, Delegate>(2, new Action(this.OnCheckButtonClick))
			};
		}

		// Token: 0x0602A679 RID: 173689 RVA: 0x00BF5B03 File Offset: 0x00BF3D03
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
		}

		// Token: 0x0602A67A RID: 173690 RVA: 0x00BF5B21 File Offset: 0x00BF3D21
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
		}

		// Token: 0x0602A67B RID: 173691 RVA: 0x00BF5B40 File Offset: 0x00BF3D40
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderQuicklyBuildView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderQuicklyBuildView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A67C RID: 173692 RVA: 0x00BF5B83 File Offset: 0x00BF3D83
		protected void SelectDeckByIndex(int index)
		{
			this.DeckLayout.SelectGridProxy(index, false);
		}

		// Token: 0x0602A67D RID: 173693 RVA: 0x00BF5B92 File Offset: 0x00BF3D92
		private DeckBuilderQuicklyBuildItem CreateDeckItem()
		{
			return new DeckBuilderQuicklyBuildItem
			{
				OnToggleStateChange = new Action<int>(this.OnItemToggleStateChange)
			};
		}

		// Token: 0x0602A67E RID: 173694 RVA: 0x00BF5BAB File Offset: 0x00BF3DAB
		private void OnItemToggleStateChange(int gridIndex)
		{
			this.SelectDeckByIndex(gridIndex);
		}

		// Token: 0x0602A67F RID: 173695 RVA: 0x00BF5BB4 File Offset: 0x00BF3DB4
		private void OnConfirmButtonClick()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomArenaQuicklyBuildConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				int selectedGridIndex = this.DeckLayout.GetSelectedGridIndex();
				if (selectedGridIndex < 0)
				{
					return;
				}
				DeckInfo obj = this.DeckList[selectedGridIndex];
				IDeckBuilderQuicklyBuildViewData data = this.Data;
				if (data != null)
				{
					data.ConfirmCallback(obj);
				}
				base.CloseMe(null);
			};
			bool isNew = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(this.Data.ActivityId);
			PhantomArenaController.Instance.OpenPhantomArenaConfirmBoxView(confirmBoxDataNew, isNew);
		}

		// Token: 0x0602A680 RID: 173696 RVA: 0x00BF5C08 File Offset: 0x00BF3E08
		private void OnCheckButtonClick()
		{
			int selectedGridIndex = this.DeckLayout.GetSelectedGridIndex();
			if (selectedGridIndex < 0)
			{
				return;
			}
			DeckInfo deckInfo = this.DeckList[selectedGridIndex];
			PhantomArenaDeckDetailViewData param = new PhantomArenaDeckDetailViewData
			{
				DeckInfo = deckInfo,
				ShowLocked = true,
				ActivityId = this.Data.ActivityId
			};
			EUiViewName name = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(this.Data.ActivityId) ? EUiViewName.PhantomArenaDeckDetailViewNew : EUiViewName.PhantomArenaDeckDetailView;
			UiManager.Instance.OpenView(name, param, null);
		}

		// Token: 0x0602A681 RID: 173697 RVA: 0x00BF5C8C File Offset: 0x00BF3E8C
		private void OnPhantomArenaCardUnlock(int cardId)
		{
			foreach (DeckBuilderQuicklyBuildItem deckBuilderQuicklyBuildItem in this.DeckLayout.GetLayoutItemList())
			{
				deckBuilderQuicklyBuildItem.RefreshCountText();
			}
		}

		// Token: 0x0602A682 RID: 173698 RVA: 0x00BF5CE4 File Offset: 0x00BF3EE4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "Group"))
			{
				return null;
			}
			int index = int.Parse(configParams[1]);
			GenericLayout<DeckBuilderQuicklyBuildItem, DeckInfo> deckLayout = this.DeckLayout;
			UUIItem uuiitem;
			if (deckLayout == null)
			{
				uuiitem = null;
			}
			else
			{
				DeckBuilderQuicklyBuildItem layoutItemByIndex = deckLayout.GetLayoutItemByIndex(index);
				uuiitem = ((layoutItemByIndex != null) ? layoutItemByIndex.GetRootItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}

		// Token: 0x040170A0 RID: 94368
		[Nullable(2)]
		private IDeckBuilderQuicklyBuildViewData Data;

		// Token: 0x040170A1 RID: 94369
		protected List<DeckInfo> DeckList = new List<DeckInfo>();

		// Token: 0x040170A2 RID: 94370
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<DeckBuilderQuicklyBuildItem, DeckInfo> DeckLayout;

		// Token: 0x02009D49 RID: 40265
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030EAD RID: 200365
			public const int DeckLayout = 0;

			// Token: 0x04030EAE RID: 200366
			public const int DeckGridItem = 1;

			// Token: 0x04030EAF RID: 200367
			public const int CheckButton = 2;

			// Token: 0x04030EB0 RID: 200368
			public const int ConfirmButton = 3;
		}
	}
}
