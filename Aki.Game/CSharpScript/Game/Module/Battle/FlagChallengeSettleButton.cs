using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C22 RID: 19490
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeSettleButton : UiPanelBase
	{
		// Token: 0x060309E6 RID: 199142 RVA: 0x00D8D5F0 File Offset: 0x00D8B7F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060309E7 RID: 199143 RVA: 0x00D8D6D8 File Offset: 0x00D8B8D8
		protected override void OnBeforeShow()
		{
			base.GetText(0).SetText(string.Empty, true);
			base.GetText(2).SetText(string.Empty, true);
		}

		// Token: 0x060309E8 RID: 199144 RVA: 0x00D8D700 File Offset: 0x00D8B900
		public UniTask InitializeAsync(AActor rootActor, Action onClickCall)
		{
			FlagChallengeSettleButton.<InitializeAsync>d__4 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.rootActor = rootActor;
			<InitializeAsync>d__.onClickCall = onClickCall;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<FlagChallengeSettleButton.<InitializeAsync>d__4>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060309E9 RID: 199145 RVA: 0x00D8D753 File Offset: 0x00D8B953
		private void OnClickedButton()
		{
			Action onClickEvent = this.OnClickEvent;
			if (onClickEvent == null)
			{
				return;
			}
			onClickEvent();
		}

		// Token: 0x060309EA RID: 199146 RVA: 0x00D8D765 File Offset: 0x00D8B965
		public void SetFloatText(string textId, params object[] args)
		{
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
		}

		// Token: 0x060309EB RID: 199147 RVA: 0x00D8D787 File Offset: 0x00D8B987
		public void SetBtnTextNew(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x04019BA5 RID: 105381
		[Nullable(2)]
		private Action OnClickEvent;

		// Token: 0x0200A845 RID: 43077
		[NullableContext(0)]
		private enum ESettleButtonType
		{
			// Token: 0x04033FAB RID: 212907
			ButtonText,
			// Token: 0x04033FAC RID: 212908
			DescriptionItem,
			// Token: 0x04033FAD RID: 212909
			DescriptionText,
			// Token: 0x04033FAE RID: 212910
			Button
		}
	}
}
