using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.View;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x0200427F RID: 17023
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleGuideManager
	{
		// Token: 0x0602B169 RID: 176489 RVA: 0x00C1D2B6 File Offset: 0x00C1B4B6
		public PhantomArenaBattleGuideManager(PhantomArenaBattleProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0602B16A RID: 176490 RVA: 0x00C1D2C5 File Offset: 0x00C1B4C5
		public void RegisterGuideInterface(IPhantomArenaGuideFunc guideInterface)
		{
			this.GuideInterface = guideInterface;
		}

		// Token: 0x0602B16B RID: 176491 RVA: 0x00C1D2D0 File Offset: 0x00C1B4D0
		public unsafe void RegisterBehaviorTreeGuideData(BvbPlayerOperationConstraint param)
		{
			EBvbPlayerOperationType type = param.EnableOperation.Type;
			this.CurrentGuideData = PhantomArenaBattleGuideFactory.GetGuideData(type, param);
			this.HasNextGuide = !param.IsTheLast.GetValueOrDefault();
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "行为引导操作限制";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HasNextGuide", this.HasNextGuide);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602B16C RID: 176492 RVA: 0x00C1D374 File Offset: 0x00C1B574
		public bool CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType type, params object[] params_)
		{
			if (this.CurrentGuideData == null && !this.HasNextGuide)
			{
				return true;
			}
			if (this.CurrentGuideData == null && this.HasNextGuide)
			{
				this.ShowGuideTips();
				return false;
			}
			if (this.CurrentGuideData.Type != type)
			{
				this.ShowGuideTips();
				return false;
			}
			if (!this.CurrentGuideData.CheckCanExecute(params_))
			{
				this.ShowGuideTips();
				return false;
			}
			return true;
		}

		// Token: 0x0602B16D RID: 176493 RVA: 0x00C1D3D8 File Offset: 0x00C1B5D8
		public bool CheckInGuideAndShowTips()
		{
			if (this.InGuiding)
			{
				this.ShowGuideTips();
				return true;
			}
			return false;
		}

		// Token: 0x0602B16E RID: 176494 RVA: 0x00C1D3EC File Offset: 0x00C1B5EC
		public unsafe void FinishCurrentGuide()
		{
			if (this.CurrentGuideData != null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "行为引导操作限制完成";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", this.CurrentGuideData.Type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HasNextGuide", this.HasNextGuide);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.CurrentGuideData = null;
				if (this.GuideInterface != null)
				{
					this.GuideInterface.FinishCurrentGuide();
					this.GuideInterface = null;
				}
			}
		}

		// Token: 0x0602B16F RID: 176495 RVA: 0x00C1D494 File Offset: 0x00C1B694
		public void TryExitCurrentGuide()
		{
			if (this.CurrentGuideData == null)
			{
				return;
			}
			if (this.GuideInterface != null)
			{
				this.GuideInterface.ExitCurrentGuide();
				this.GuideInterface = null;
			}
		}

		// Token: 0x0602B170 RID: 176496 RVA: 0x00C1D4B9 File Offset: 0x00C1B6B9
		public void TryCacheGuideData(EBvbPlayerOperationType type, params object[] params_)
		{
			if (this.CurrentGuideData == null)
			{
				return;
			}
			if (this.CurrentGuideData.Type != type)
			{
				return;
			}
			this.CurrentGuideData.CacheGuideData(params_);
		}

		// Token: 0x0602B171 RID: 176497 RVA: 0x00C1D4DF File Offset: 0x00C1B6DF
		public void TryFinishGuideByType(EBvbPlayerOperationType type, params object[] params_)
		{
			if (this.CurrentGuideData == null)
			{
				return;
			}
			if (this.CurrentGuideData.Type != type)
			{
				return;
			}
			if (!this.CurrentGuideData.CheckCanFinishGuide(params_))
			{
				return;
			}
			this.FinishCurrentGuide();
		}

		// Token: 0x170056AE RID: 22190
		// (get) Token: 0x0602B172 RID: 176498 RVA: 0x00C1D50E File Offset: 0x00C1B70E
		public bool InGuiding
		{
			get
			{
				return this.CurrentGuideData != null || this.HasNextGuide;
			}
		}

		// Token: 0x0602B173 RID: 176499 RVA: 0x00C1D520 File Offset: 0x00C1B720
		public void ShowGuideTips()
		{
			if (this.CurrentGuideData != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(this.CurrentGuideData.Tips, Array.Empty<object>());
				return;
			}
			if (this.HasNextGuide)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Text_BvBPlayerOperationForbidden_Text", Array.Empty<object>());
			}
		}

		// Token: 0x040174A8 RID: 95400
		private IPhantomArenaTabViewModelBase CurrentGuideData;

		// Token: 0x040174A9 RID: 95401
		private IPhantomArenaGuideFunc GuideInterface;

		// Token: 0x040174AA RID: 95402
		private bool HasNextGuide;

		// Token: 0x040174AB RID: 95403
		protected PhantomArenaBattleProxy Proxy;
	}
}
