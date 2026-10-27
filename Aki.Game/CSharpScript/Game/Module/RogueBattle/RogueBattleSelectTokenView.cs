using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EFF RID: 20223
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleSelectTokenView : UiViewBase
	{
		// Token: 0x06033DD5 RID: 212437 RVA: 0x00C267A9 File Offset: 0x00C249A9
		public RogueBattleSelectTokenView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033DD6 RID: 212438 RVA: 0x00C267B4 File Offset: 0x00C249B4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnBtnConfirm)),
				new ValueTuple<int, Delegate>(6, new Action(this.OnBtnRefresh))
			};
		}

		// Token: 0x06033DD7 RID: 212439 RVA: 0x00C268D0 File Offset: 0x00C24AD0
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleSelectTokenView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSelectTokenView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033DD8 RID: 212440 RVA: 0x00C26914 File Offset: 0x00C24B14
		private void RefreshTokenLayout()
		{
			SelectViewOp selectViewOp = ((MapRogueOpSelectView)MapRogueModel.Instance.GetOpData((int)this.OpenParam)).Data.SelectViewOp;
			RepeatedField<RogueResGainData> repeatedField;
			if (selectViewOp == null)
			{
				repeatedField = null;
			}
			else
			{
				RogueResOption rogueResOption = selectViewOp.RogueResOption;
				repeatedField = ((rogueResOption != null) ? rogueResOption.RogueResGainDatas : null);
			}
			RepeatedField<RogueResGainData> repeatedField2 = repeatedField;
			if (repeatedField2 != null)
			{
				GenericLayout<RogueBattleTokenItem, RogueResGainData> tokenLayout = this.TokenLayout;
				if (tokenLayout == null)
				{
					return;
				}
				tokenLayout.RefreshByData(repeatedField2.ToList<RogueResGainData>(), null, false);
			}
		}

		// Token: 0x06033DD9 RID: 212441 RVA: 0x00C2697C File Offset: 0x00C24B7C
		private void OnBtnConfirm()
		{
			int selectedGridIndex = this.TokenLayout.GetSelectedGridIndex();
			if (selectedGridIndex < 0)
			{
				return;
			}
			((MapRogueOpSelectView)MapRogueModel.Instance.GetOpData((int)this.OpenParam)).Select(selectedGridIndex);
		}

		// Token: 0x06033DDA RID: 212442 RVA: 0x00C269BA File Offset: 0x00C24BBA
		private void OnBtnRefresh()
		{
		}

		// Token: 0x06033DDB RID: 212443 RVA: 0x00C269BC File Offset: 0x00C24BBC
		private void OnClickDetail()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueBattleSummary, null, null);
		}

		// Token: 0x06033DDC RID: 212444 RVA: 0x00C269CF File Offset: 0x00C24BCF
		private RogueBattleTokenItem CreateTokenItem()
		{
			return new RogueBattleTokenItem
			{
				OnClickHandle = new Action<int?>(this.OnSelectToken)
			};
		}

		// Token: 0x06033DDD RID: 212445 RVA: 0x00C269E8 File Offset: 0x00C24BE8
		private void OnSelectToken(int? index)
		{
			if (index == null)
			{
				GenericLayout<RogueBattleTokenItem, RogueResGainData> tokenLayout = this.TokenLayout;
				if (tokenLayout != null)
				{
					tokenLayout.DeselectCurrentGridProxy();
				}
				base.GetButton(5).SetSelfInteractive(false);
			}
			else
			{
				base.GetButton(5).SetSelfInteractive(true);
				GenericLayout<RogueBattleTokenItem, RogueResGainData> tokenLayout2 = this.TokenLayout;
				if (tokenLayout2 != null)
				{
					tokenLayout2.SelectGridProxy(index.Value, false);
				}
			}
			EventSystem.Instance.Emit(EEventName.RogueBattleSelectOptionPreview);
		}

		// Token: 0x0401B903 RID: 112899
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleTokenItem, RogueResGainData> TokenLayout;

		// Token: 0x0401B904 RID: 112900
		[Nullable(2)]
		private RogueBattleTopPanel CaptionComponent;
	}
}
