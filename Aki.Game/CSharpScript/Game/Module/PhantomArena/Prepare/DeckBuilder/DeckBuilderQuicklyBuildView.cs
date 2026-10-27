using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020051A2 RID: 20898
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderQuicklyBuildView : UiViewBase
	{
		// Token: 0x0603577C RID: 219004 RVA: 0x00CA8426 File Offset: 0x00CA6626
		public DeckBuilderQuicklyBuildView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603577D RID: 219005 RVA: 0x00CA843C File Offset: 0x00CA663C
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

		// Token: 0x0603577E RID: 219006 RVA: 0x00CA84E7 File Offset: 0x00CA66E7
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
		}

		// Token: 0x0603577F RID: 219007 RVA: 0x00CA8505 File Offset: 0x00CA6705
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
		}

		// Token: 0x06035780 RID: 219008 RVA: 0x00CA8524 File Offset: 0x00CA6724
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderQuicklyBuildView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderQuicklyBuildView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035781 RID: 219009 RVA: 0x00CA8567 File Offset: 0x00CA6767
		protected void SelectDeckByIndex(int index)
		{
			this.DeckLayout.SelectGridProxy(index, false);
		}

		// Token: 0x06035782 RID: 219010 RVA: 0x00CA8576 File Offset: 0x00CA6776
		private DeckBuilderQuicklyBuildItem CreateDeckItem()
		{
			return new DeckBuilderQuicklyBuildItem
			{
				OnToggleStateChange = new Action<int>(this.OnItemToggleStateChange)
			};
		}

		// Token: 0x06035783 RID: 219011 RVA: 0x00CA858F File Offset: 0x00CA678F
		private void OnItemToggleStateChange(int gridIndex)
		{
			this.SelectDeckByIndex(gridIndex);
		}

		// Token: 0x06035784 RID: 219012 RVA: 0x00CA8598 File Offset: 0x00CA6798
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

		// Token: 0x06035785 RID: 219013 RVA: 0x00CA85EC File Offset: 0x00CA67EC
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

		// Token: 0x06035786 RID: 219014 RVA: 0x00CA866D File Offset: 0x00CA686D
		private void OnPhantomArenaCardUnlock(int cardId)
		{
			this.DeckLayout.GetLayoutItemList().ToList<DeckBuilderQuicklyBuildItem>().ForEach(delegate(DeckBuilderQuicklyBuildItem item)
			{
				item.RefreshCountText();
			});
		}

		// Token: 0x06035787 RID: 219015 RVA: 0x00CA86A4 File Offset: 0x00CA68A4
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

		// Token: 0x0401C66B RID: 116331
		[Nullable(2)]
		private IDeckBuilderQuicklyBuildViewData Data;

		// Token: 0x0401C66C RID: 116332
		protected List<DeckInfo> DeckList = new List<DeckInfo>();

		// Token: 0x0401C66D RID: 116333
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<DeckBuilderQuicklyBuildItem, DeckInfo> DeckLayout;

		// Token: 0x0200B310 RID: 45840
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036458 RID: 222296
			public const int DeckLayout = 0;

			// Token: 0x04036459 RID: 222297
			public const int DeckGridItem = 1;

			// Token: 0x0403645A RID: 222298
			public const int CheckButton = 2;

			// Token: 0x0403645B RID: 222299
			public const int ConfirmButton = 3;
		}
	}
}
