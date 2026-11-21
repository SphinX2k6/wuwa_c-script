using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.TipsTalk
{
	// Token: 0x02003FD7 RID: 16343
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotBattleTopRightTipsView : PlotTipsViewBase
	{
		// Token: 0x060295AD RID: 169389 RVA: 0x00BA4C9D File Offset: 0x00BA2E9D
		public PlotBattleTopRightTipsView()
		{
			this.ResourceId = "UiItem_MainTalk";
		}

		// Token: 0x060295AE RID: 169390 RVA: 0x00BA4CB0 File Offset: 0x00BA2EB0
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

		// Token: 0x060295AF RID: 169391 RVA: 0x00BA4D5C File Offset: 0x00BA2F5C
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

		// Token: 0x060295B0 RID: 169392 RVA: 0x00BA4E54 File Offset: 0x00BA3054
		protected override void OnAfterShow()
		{
			bool isHang = base.IsHang;
			base.OnAfterShow();
			if (this.TweenInComp != null && !isHang)
			{
				this.TweenInComp.Play();
			}
		}

		// Token: 0x060295B1 RID: 169393 RVA: 0x00BA4E84 File Offset: 0x00BA3084
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

		// Token: 0x060295B2 RID: 169394 RVA: 0x00BA4ED0 File Offset: 0x00BA30D0
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

		// Token: 0x060295B3 RID: 169395 RVA: 0x00BA4F28 File Offset: 0x00BA3128
		private void OnTweenOutEndDelegate()
		{
			this.TweenOutPromise.SetResult(true);
			this.TweenOutPromise = null;
		}

		// Token: 0x060295B4 RID: 169396 RVA: 0x00BA4F40 File Offset: 0x00BA3140
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

		// Token: 0x040168D4 RID: 92372
		private ULGUIPlayTweenComponent TweenInComp;

		// Token: 0x040168D5 RID: 92373
		private ULGUIPlayTweenComponent TweenOutComp;

		// Token: 0x040168D6 RID: 92374
		private FLGUIPlayTweenCompleteDynamicDelegate TweenOutEndDelegate;

		// Token: 0x040168D7 RID: 92375
		private FLGUIDelegateHandleWrapper TweenOutEndDelegateWrapper;

		// Token: 0x040168D8 RID: 92376
		private CustomPromise<bool> TweenOutPromise;

		// Token: 0x02009B78 RID: 39800
		[NullableContext(0)]
		private static class EChildCom
		{
			// Token: 0x040306E2 RID: 198370
			public const int Icon = 0;

			// Token: 0x040306E3 RID: 198371
			public const int Text = 1;

			// Token: 0x040306E4 RID: 198372
			public const int TweenIn = 2;

			// Token: 0x040306E5 RID: 198373
			public const int TweenOut = 3;
		}
	}
}
