using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.TipsTalk
{
	// Token: 0x0200500D RID: 20493
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotBattleTopRightTipsView : PlotTipsViewBase
	{
		// Token: 0x0603470A RID: 214794 RVA: 0x00C5979D File Offset: 0x00C5799D
		public PlotBattleTopRightTipsView()
		{
			this.ResourceId = "UiItem_MainTalk";
		}

		// Token: 0x0603470B RID: 214795 RVA: 0x00C597B0 File Offset: 0x00C579B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603470C RID: 214796 RVA: 0x00C5985C File Offset: 0x00C57A5C
		protected override void OnInit()
		{
			this.IconItem = base.GetTexture(0);
			this.SubtitleItem = base.GetText(1);
			this.IconItem.GetParentAsUIItem().SetUIItemAlpha(0f);
			this.SubtitleItem.GetParentAsUIItem().SetUIItemAlpha(0f);
			this.TweenInComp = (base.GetItem(2).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			if (this.TweenInComp != null)
			{
				this.TweenInComp.Stop();
			}
			this.TweenOutComp = (base.GetItem(3).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			if (this.TweenOutComp != null)
			{
				this.TweenOutComp.Stop();
				this.TweenOutEndDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(new Action(this.OnTweenOutEndDelegate));
				this.TweenOutEndDelegateWrapper = this.TweenOutComp.GetPlayTween().RegisterOnComplete(this.TweenOutEndDelegate);
			}
		}

		// Token: 0x0603470D RID: 214797 RVA: 0x00C59954 File Offset: 0x00C57B54
		protected override void OnAfterShow()
		{
			bool isHang = base.IsHang;
			base.OnAfterShow();
			if (this.TweenInComp != null && !isHang)
			{
				this.TweenInComp.Play();
			}
		}

		// Token: 0x0603470E RID: 214798 RVA: 0x00C59984 File Offset: 0x00C57B84
		protected override UniTask OnHideAsyncImplementImplement()
		{
			if (this.TweenOutComp != null && !base.IsHang)
			{
				this.TweenOutPromise = new CustomPromise<bool>();
				this.TweenOutComp.Play();
				return this.TweenOutPromise.Promise.AsUniTask();
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x0603470F RID: 214799 RVA: 0x00C599D0 File Offset: 0x00C57BD0
		protected override void OnBeforeDestroy()
		{
			if (this.TweenOutEndDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnTweenOutEndDelegate));
				this.TweenOutEndDelegate = null;
			}
			if (this.TweenOutEndDelegateWrapper != null)
			{
				this.TweenOutComp.GetPlayTween().UnregisterOnComplete(this.TweenOutEndDelegateWrapper);
				this.TweenOutEndDelegateWrapper = null;
			}
		}

		// Token: 0x06034710 RID: 214800 RVA: 0x00C59A28 File Offset: 0x00C57C28
		private void OnTweenOutEndDelegate()
		{
			this.TweenOutPromise.SetResult(true);
			this.TweenOutPromise = null;
		}

		// Token: 0x06034711 RID: 214801 RVA: 0x00C59A40 File Offset: 0x00C57C40
		protected override UUIItem GetParentItem()
		{
			EUiViewName? viewName = base.GetViewName();
			if (viewName != null)
			{
				UiViewBase viewByName = UiManager.Instance.GetViewByName(viewName.Value);
				if (viewByName != null)
				{
					return viewByName.GetRootItem();
				}
			}
			return base.GetParentItem();
		}

		// Token: 0x0401BEEB RID: 114411
		private ULGUIPlayTweenComponent TweenInComp;

		// Token: 0x0401BEEC RID: 114412
		private ULGUIPlayTweenComponent TweenOutComp;

		// Token: 0x0401BEED RID: 114413
		private FLGUIPlayTweenCompleteDynamicDelegate TweenOutEndDelegate;

		// Token: 0x0401BEEE RID: 114414
		private FLGUIDelegateHandleWrapper TweenOutEndDelegateWrapper;

		// Token: 0x0401BEEF RID: 114415
		private CustomPromise<bool> TweenOutPromise;

		// Token: 0x0200B140 RID: 45376
		[NullableContext(0)]
		private static class EChildCom
		{
			// Token: 0x04035C9A RID: 220314
			public const int Icon = 0;

			// Token: 0x04035C9B RID: 220315
			public const int Text = 1;

			// Token: 0x04035C9C RID: 220316
			public const int TweenIn = 2;

			// Token: 0x04035C9D RID: 220317
			public const int TweenOut = 3;
		}
	}
}
