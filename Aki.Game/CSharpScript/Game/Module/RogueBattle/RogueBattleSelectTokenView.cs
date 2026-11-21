using System;
using System.Collections.Generic;
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
	// Token: 0x02003EC8 RID: 16072
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleSelectTokenView : UiViewBase
	{
		// Token: 0x06028C40 RID: 166976 RVA: 0x00B6FD51 File Offset: 0x00B6DF51
		public RogueBattleSelectTokenView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028C41 RID: 166977 RVA: 0x00B6FD5C File Offset: 0x00B6DF5C
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

		// Token: 0x06028C42 RID: 166978 RVA: 0x00B6FE78 File Offset: 0x00B6E078
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleSelectTokenView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSelectTokenView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028C43 RID: 166979 RVA: 0x00B6FEBC File Offset: 0x00B6E0BC
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
				tokenLayout.RefreshByData(repeatedField2, null, false);
			}
		}

		// Token: 0x06028C44 RID: 166980 RVA: 0x00B6FF1C File Offset: 0x00B6E11C
		private void OnBtnConfirm()
		{
			int selectedGridIndex = this.TokenLayout.GetSelectedGridIndex();
			if (selectedGridIndex < 0)
			{
				return;
			}
			((MapRogueOpSelectView)MapRogueModel.Instance.GetOpData((int)this.OpenParam)).Select(selectedGridIndex);
		}

		// Token: 0x06028C45 RID: 166981 RVA: 0x00B6FF5A File Offset: 0x00B6E15A
		private void OnBtnRefresh()
		{
		}

		// Token: 0x06028C46 RID: 166982 RVA: 0x00B6FF5C File Offset: 0x00B6E15C
		private void OnClickDetail()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueBattleSummary, null, null);
		}

		// Token: 0x06028C47 RID: 166983 RVA: 0x00B6FF6F File Offset: 0x00B6E16F
		private RogueBattleTokenItem CreateTokenItem()
		{
			return new RogueBattleTokenItem
			{
				OnClickHandle = new Action<int?>(this.OnSelectToken)
			};
		}

		// Token: 0x06028C48 RID: 166984 RVA: 0x00B6FF88 File Offset: 0x00B6E188
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

		// Token: 0x040162D6 RID: 90838
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleTokenItem, RogueResGainData> TokenLayout;

		// Token: 0x040162D7 RID: 90839
		[Nullable(2)]
		private RogueBattleTopPanel CaptionComponent;
	}
}
