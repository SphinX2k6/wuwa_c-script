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
	// Token: 0x02003EBD RID: 16061
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattlePhantomSelectView : UiViewBase
	{
		// Token: 0x06028C10 RID: 166928 RVA: 0x00B6EDCE File Offset: 0x00B6CFCE
		public RogueBattlePhantomSelectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028C11 RID: 166929 RVA: 0x00B6EDD8 File Offset: 0x00B6CFD8
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

		// Token: 0x06028C12 RID: 166930 RVA: 0x00B6EE6C File Offset: 0x00B6D06C
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

		// Token: 0x06028C13 RID: 166931 RVA: 0x00B6EED4 File Offset: 0x00B6D0D4
		private RogueBattlePhantomItem CreatePhantomItem()
		{
			return new RogueBattlePhantomItem
			{
				SelectCallBack = new Action<int?>(this.OnSelectPhantom)
			};
		}

		// Token: 0x06028C14 RID: 166932 RVA: 0x00B6EEF0 File Offset: 0x00B6D0F0
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

		// Token: 0x06028C15 RID: 166933 RVA: 0x00B6EF4C File Offset: 0x00B6D14C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattlePhantomSelectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattlePhantomSelectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040162A2 RID: 90786
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<RogueBattlePhantomItem, RogueResGainData> PhantomLayout;

		// Token: 0x040162A3 RID: 90787
		[Nullable(2)]
		public RogueBattleElementPanel ElementInfoPanel;

		// Token: 0x040162A4 RID: 90788
		[Nullable(2)]
		public RogueBattleTopPanel CaptionItem;
	}
}
