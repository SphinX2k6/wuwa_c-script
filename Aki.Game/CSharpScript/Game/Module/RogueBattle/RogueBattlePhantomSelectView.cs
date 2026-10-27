using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EF4 RID: 20212
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattlePhantomSelectView : UiViewBase
	{
		// Token: 0x06033DA5 RID: 212389 RVA: 0x00C25826 File Offset: 0x00C23A26
		public RogueBattlePhantomSelectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033DA6 RID: 212390 RVA: 0x00C25830 File Offset: 0x00C23A30
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnBtnConfirm))
			};
		}

		// Token: 0x06033DA7 RID: 212391 RVA: 0x00C258C4 File Offset: 0x00C23AC4
		private void OnBtnConfirm()
		{
			GenericLayout<RogueBattlePhantomItem, RogueResGainData> phantomLayout = this.PhantomLayout;
			int? num = (phantomLayout != null) ? new int?(phantomLayout.GetSelectedGridIndex()) : null;
			if (num != null && num.Value > 0)
			{
				return;
			}
			RogueBattleController.Instance.SelectTokenRequest(num.Value).ContinueWith(delegate()
			{
				base.CloseMe(null);
			}).Forget();
		}

		// Token: 0x06033DA8 RID: 212392 RVA: 0x00C2592C File Offset: 0x00C23B2C
		private RogueBattlePhantomItem CreatePhantomItem()
		{
			return new RogueBattlePhantomItem
			{
				SelectCallBack = new Action<int?>(this.OnSelectPhantom)
			};
		}

		// Token: 0x06033DA9 RID: 212393 RVA: 0x00C25948 File Offset: 0x00C23B48
		private void OnSelectPhantom(int? index)
		{
			if (index == null)
			{
				GenericLayout<RogueBattlePhantomItem, RogueResGainData> phantomLayout = this.PhantomLayout;
				if (phantomLayout != null)
				{
					phantomLayout.DeselectCurrentGridProxy();
				}
				base.GetButton(2).SetSelfInteractive(false);
				return;
			}
			base.GetButton(2).SetSelfInteractive(true);
			GenericLayout<RogueBattlePhantomItem, RogueResGainData> phantomLayout2 = this.PhantomLayout;
			if (phantomLayout2 == null)
			{
				return;
			}
			phantomLayout2.SelectGridProxy(index.Value, false);
		}

		// Token: 0x06033DAA RID: 212394 RVA: 0x00C259A4 File Offset: 0x00C23BA4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattlePhantomSelectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattlePhantomSelectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B8CF RID: 112847
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<RogueBattlePhantomItem, RogueResGainData> PhantomLayout;

		// Token: 0x0401B8D0 RID: 112848
		[Nullable(2)]
		public RogueBattleElementPanel ElementInfoPanel;

		// Token: 0x0401B8D1 RID: 112849
		[Nullable(2)]
		public RogueBattleTopPanel CaptionItem;
	}
}
