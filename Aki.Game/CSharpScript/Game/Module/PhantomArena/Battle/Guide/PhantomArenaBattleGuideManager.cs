using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.View;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052AF RID: 21167
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleGuideManager
	{
		// Token: 0x0603626E RID: 221806 RVA: 0x00CCFB8E File Offset: 0x00CCDD8E
		public PhantomArenaBattleGuideManager(PhantomArenaBattleProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0603626F RID: 221807 RVA: 0x00CCFB9D File Offset: 0x00CCDD9D
		public void RegisterGuideInterface(IPhantomArenaGuideFunc guideInterface)
		{
			this.GuideInterface = guideInterface;
		}

		// Token: 0x06036270 RID: 221808 RVA: 0x00CCFBA8 File Offset: 0x00CCDDA8
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

		// Token: 0x06036271 RID: 221809 RVA: 0x00CCFC4C File Offset: 0x00CCDE4C
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

		// Token: 0x06036272 RID: 221810 RVA: 0x00CCFCB0 File Offset: 0x00CCDEB0
		public bool CheckInGuideAndShowTips()
		{
			if (this.InGuiding)
			{
				this.ShowGuideTips();
				return true;
			}
			return false;
		}

		// Token: 0x06036273 RID: 221811 RVA: 0x00CCFCC4 File Offset: 0x00CCDEC4
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

		// Token: 0x06036274 RID: 221812 RVA: 0x00CCFD6C File Offset: 0x00CCDF6C
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

		// Token: 0x06036275 RID: 221813 RVA: 0x00CCFD91 File Offset: 0x00CCDF91
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

		// Token: 0x06036276 RID: 221814 RVA: 0x00CCFDB7 File Offset: 0x00CCDFB7
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

		// Token: 0x170082EE RID: 33518
		// (get) Token: 0x06036277 RID: 221815 RVA: 0x00CCFDE6 File Offset: 0x00CCDFE6
		public bool InGuiding
		{
			get
			{
				return this.CurrentGuideData != null || this.HasNextGuide;
			}
		}

		// Token: 0x06036278 RID: 221816 RVA: 0x00CCFDF8 File Offset: 0x00CCDFF8
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

		// Token: 0x0401CA73 RID: 117363
		private IPhantomArenaTabViewModelBase CurrentGuideData;

		// Token: 0x0401CA74 RID: 117364
		private IPhantomArenaGuideFunc GuideInterface;

		// Token: 0x0401CA75 RID: 117365
		private bool HasNextGuide;

		// Token: 0x0401CA76 RID: 117366
		protected PhantomArenaBattleProxy Proxy;
	}
}
