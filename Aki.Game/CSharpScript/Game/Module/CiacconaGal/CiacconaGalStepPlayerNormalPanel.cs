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
	// Token: 0x02005BD8 RID: 23512
	[NullableContext(2)]
	[Nullable(0)]
	public class CiacconaGalStepPlayerNormalPanel : UiPanelBase
	{
		// Token: 0x0603B705 RID: 243461 RVA: 0x00E2C6EC File Offset: 0x00E2A8EC
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

		// Token: 0x0603B706 RID: 243462 RVA: 0x00E2C778 File Offset: 0x00E2A978
		protected override void OnStart()
		{
			this.ScrollComponent = base.GetScrollViewWithScrollbar(0);
			this.ScrollView = new GenericScrollViewNew<CiacconaGalStepItemContainer, CiacconaGalStepData>(this.ScrollComponent, new Func<CiacconaGalStepItemContainer>(this.GetStepItemContainer), null, false, null);
			this.ScrollComponent.OnScrollViewDownUpCallback.Bind(new Action<ULGUIPointerEventData>(this.OnScrollViewPointerUp));
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603B707 RID: 243463 RVA: 0x00E2C7E0 File Offset: 0x00E2A9E0
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalStepPlayerNormalPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalStepPlayerNormalPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B708 RID: 243464 RVA: 0x00E2C824 File Offset: 0x00E2AA24
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

		// Token: 0x0603B709 RID: 243465 RVA: 0x00E2C8B2 File Offset: 0x00E2AAB2
		public void Refresh()
		{
			this.RefreshImp().Forget();
		}

		// Token: 0x0603B70A RID: 243466 RVA: 0x00E2C8C0 File Offset: 0x00E2AAC0
		public void PlayStart()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603B70B RID: 243467 RVA: 0x00E2C8F0 File Offset: 0x00E2AAF0
		public UniTask PlayCloseAsync()
		{
			CiacconaGalStepPlayerNormalPanel.<PlayCloseAsync>d__12 <PlayCloseAsync>d__;
			<PlayCloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseAsync>d__.<>4__this = this;
			<PlayCloseAsync>d__.<>1__state = -1;
			<PlayCloseAsync>d__.<>t__builder.Start<CiacconaGalStepPlayerNormalPanel.<PlayCloseAsync>d__12>(ref <PlayCloseAsync>d__);
			return <PlayCloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B70C RID: 243468 RVA: 0x00E2C934 File Offset: 0x00E2AB34
		private UniTask RefreshImp()
		{
			CiacconaGalStepPlayerNormalPanel.<RefreshImp>d__13 <RefreshImp>d__;
			<RefreshImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshImp>d__.<>4__this = this;
			<RefreshImp>d__.<>1__state = -1;
			<RefreshImp>d__.<>t__builder.Start<CiacconaGalStepPlayerNormalPanel.<RefreshImp>d__13>(ref <RefreshImp>d__);
			return <RefreshImp>d__.<>t__builder.Task;
		}

		// Token: 0x0603B70D RID: 243469 RVA: 0x00E2C977 File Offset: 0x00E2AB77
		[NullableContext(1)]
		private CiacconaGalStepItemContainer GetStepItemContainer()
		{
			return new CiacconaGalStepItemContainer();
		}

		// Token: 0x0603B70E RID: 243470 RVA: 0x00E2C980 File Offset: 0x00E2AB80
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

		// Token: 0x0603B70F RID: 243471 RVA: 0x00E2C9B4 File Offset: 0x00E2ABB4
		private void OnScrollTweenStart()
		{
			UUIScrollViewWithScrollbarComponent scrollComponent = this.ScrollComponent;
			if (scrollComponent == null)
			{
				return;
			}
			scrollComponent.ContentUIItem.Get().SetBubbleUpToParent(false);
		}

		// Token: 0x0603B710 RID: 243472 RVA: 0x00E2C9E0 File Offset: 0x00E2ABE0
		private void OnScrollTweenEnd()
		{
			UUIScrollViewWithScrollbarComponent scrollComponent = this.ScrollComponent;
			if (scrollComponent == null)
			{
				return;
			}
			scrollComponent.ContentUIItem.Get().SetBubbleUpToParent(true);
		}

		// Token: 0x0603B711 RID: 243473 RVA: 0x00E2CA0C File Offset: 0x00E2AC0C
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

		// Token: 0x0401EF8A RID: 126858
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<CiacconaGalStepItemContainer, CiacconaGalStepData> ScrollView;

		// Token: 0x0401EF8B RID: 126859
		private UUIScrollViewWithScrollbarComponent ScrollComponent;

		// Token: 0x0401EF8C RID: 126860
		private CiacconaGalFinishBtnItem BtnFinish;

		// Token: 0x0401EF8D RID: 126861
		private TimerHandle ScrollDelayTimerHandle;

		// Token: 0x0401EF8E RID: 126862
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200BDB3 RID: 48563
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04039356 RID: 234326
			public const int ScrollView = 0;

			// Token: 0x04039357 RID: 234327
			public const int LayoutContent = 1;

			// Token: 0x04039358 RID: 234328
			public const int ItemBtnFinish = 2;
		}
	}
}
