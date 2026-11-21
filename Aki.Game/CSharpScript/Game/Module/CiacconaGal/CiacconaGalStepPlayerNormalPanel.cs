using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BB8 RID: 19384
	[NullableContext(2)]
	[Nullable(0)]
	public class CiacconaGalStepPlayerNormalPanel : UiPanelBase
	{
		// Token: 0x06030650 RID: 198224 RVA: 0x00D7C9F4 File Offset: 0x00D7ABF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030651 RID: 198225 RVA: 0x00D7CA80 File Offset: 0x00D7AC80
		protected override void OnStart()
		{
			this.ScrollComponent = base.GetScrollViewWithScrollbar(0);
			this.ScrollView = new GenericScrollViewNew<CiacconaGalStepItemContainer, CiacconaGalStepData>(this.ScrollComponent, new Func<CiacconaGalStepItemContainer>(this.GetStepItemContainer), null, false, null);
			this.ScrollComponent.OnScrollViewDownUpCallback.Bind(new Action<ULGUIPointerEventData>(this.OnScrollViewPointerUp));
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06030652 RID: 198226 RVA: 0x00D7CAE8 File Offset: 0x00D7ACE8
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalStepPlayerNormalPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalStepPlayerNormalPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030653 RID: 198227 RVA: 0x00D7CB2C File Offset: 0x00D7AD2C
		protected override void OnBeforeDestroy()
		{
			if (this.ScrollComponent != null)
			{
				this.ScrollComponent.OnScrollViewDownUpCallback.Unbind();
				if (this.ScrollComponent.Tweener != null)
				{
					this.ScrollComponent.Tweener.OnStartCallBack.Unbind();
					this.ScrollComponent.Tweener.OnCompleteCallBack.Unbind();
				}
			}
			if (this.ScrollDelayTimerHandle != null && TimerSystem.Instance.Has(this.ScrollDelayTimerHandle))
			{
				TimerSystem.Instance.Remove(this.ScrollDelayTimerHandle);
				this.ScrollDelayTimerHandle = null;
			}
		}

		// Token: 0x06030654 RID: 198228 RVA: 0x00D7CBBA File Offset: 0x00D7ADBA
		public void Refresh()
		{
			this.RefreshImp().Forget();
		}

		// Token: 0x06030655 RID: 198229 RVA: 0x00D7CBC8 File Offset: 0x00D7ADC8
		public void PlayStart()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06030656 RID: 198230 RVA: 0x00D7CBF8 File Offset: 0x00D7ADF8
		public UniTask PlayCloseAsync()
		{
			CiacconaGalStepPlayerNormalPanel.<PlayCloseAsync>d__12 <PlayCloseAsync>d__;
			<PlayCloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseAsync>d__.<>4__this = this;
			<PlayCloseAsync>d__.<>1__state = -1;
			<PlayCloseAsync>d__.<>t__builder.Start<CiacconaGalStepPlayerNormalPanel.<PlayCloseAsync>d__12>(ref <PlayCloseAsync>d__);
			return <PlayCloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030657 RID: 198231 RVA: 0x00D7CC3C File Offset: 0x00D7AE3C
		private UniTask RefreshImp()
		{
			CiacconaGalStepPlayerNormalPanel.<RefreshImp>d__13 <RefreshImp>d__;
			<RefreshImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshImp>d__.<>4__this = this;
			<RefreshImp>d__.<>1__state = -1;
			<RefreshImp>d__.<>t__builder.Start<CiacconaGalStepPlayerNormalPanel.<RefreshImp>d__13>(ref <RefreshImp>d__);
			return <RefreshImp>d__.<>t__builder.Task;
		}

		// Token: 0x06030658 RID: 198232 RVA: 0x00D7CC7F File Offset: 0x00D7AE7F
		[NullableContext(1)]
		private CiacconaGalStepItemContainer GetStepItemContainer()
		{
			return new CiacconaGalStepItemContainer();
		}

		// Token: 0x06030659 RID: 198233 RVA: 0x00D7CC88 File Offset: 0x00D7AE88
		private void OnScrollViewPointerUp(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			if (eventData.dragComponent == null)
			{
				CiacconaGalController.Instance.GalPlayer.OnClick(null);
			}
		}

		// Token: 0x0603065A RID: 198234 RVA: 0x00D7CCBC File Offset: 0x00D7AEBC
		private void OnScrollTweenStart()
		{
			UUIScrollViewWithScrollbarComponent scrollComponent = this.ScrollComponent;
			if (scrollComponent == null)
			{
				return;
			}
			scrollComponent.ContentUIItem.Get().SetBubbleUpToParent(false);
		}

		// Token: 0x0603065B RID: 198235 RVA: 0x00D7CCE8 File Offset: 0x00D7AEE8
		private void OnScrollTweenEnd()
		{
			UUIScrollViewWithScrollbarComponent scrollComponent = this.ScrollComponent;
			if (scrollComponent == null)
			{
				return;
			}
			scrollComponent.ContentUIItem.Get().SetBubbleUpToParent(true);
		}

		// Token: 0x0603065C RID: 198236 RVA: 0x00D7CD14 File Offset: 0x00D7AF14
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "ChoicesSelect" || a == "FirstChoice")
			{
				foreach (CiacconaGalStepItemContainer ciacconaGalStepItemContainer in this.ScrollView.GetScrollItemList())
				{
					UUIItem[] guideUiItemAndUiItemForShowEx = ciacconaGalStepItemContainer.GetGuideUiItemAndUiItemForShowEx(configParams);
					if (guideUiItemAndUiItemForShowEx != null)
					{
						return guideUiItemAndUiItemForShowEx;
					}
				}
			}
			return null;
		}

		// Token: 0x04019A3B RID: 105019
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<CiacconaGalStepItemContainer, CiacconaGalStepData> ScrollView;

		// Token: 0x04019A3C RID: 105020
		private UUIScrollViewWithScrollbarComponent ScrollComponent;

		// Token: 0x04019A3D RID: 105021
		private CiacconaGalFinishBtnItem BtnFinish;

		// Token: 0x04019A3E RID: 105022
		private TimerHandle ScrollDelayTimerHandle;

		// Token: 0x04019A3F RID: 105023
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200A7BC RID: 42940
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033D1B RID: 212251
			public const int ScrollView = 0;

			// Token: 0x04033D1C RID: 212252
			public const int LayoutContent = 1;

			// Token: 0x04033D1D RID: 212253
			public const int ItemBtnFinish = 2;
		}
	}
}
