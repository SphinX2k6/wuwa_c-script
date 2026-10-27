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
	// Token: 0x02005C42 RID: 23618
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeSettleButton : UiPanelBase
	{
		// Token: 0x0603BA9B RID: 244379 RVA: 0x00E3D280 File Offset: 0x00E3B480
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

		// Token: 0x0603BA9C RID: 244380 RVA: 0x00E3D368 File Offset: 0x00E3B568
		protected override void OnBeforeShow()
		{
			base.GetText(0).SetText(string.Empty, true);
			base.GetText(2).SetText(string.Empty, true);
		}

		// Token: 0x0603BA9D RID: 244381 RVA: 0x00E3D390 File Offset: 0x00E3B590
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

		// Token: 0x0603BA9E RID: 244382 RVA: 0x00E3D3E3 File Offset: 0x00E3B5E3
		private void OnClickedButton()
		{
			Action onClickEvent = this.OnClickEvent;
			if (onClickEvent == null)
			{
				return;
			}
			onClickEvent();
		}

		// Token: 0x0603BA9F RID: 244383 RVA: 0x00E3D3F5 File Offset: 0x00E3B5F5
		public void SetFloatText(string textId, params object[] args)
		{
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
		}

		// Token: 0x0603BAA0 RID: 244384 RVA: 0x00E3D417 File Offset: 0x00E3B617
		public void SetBtnTextNew(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x0401F0F4 RID: 127220
		[Nullable(2)]
		private Action OnClickEvent;

		// Token: 0x0200BE3D RID: 48701
		[NullableContext(0)]
		private enum ESettleButtonType
		{
			// Token: 0x040395E8 RID: 234984
			ButtonText,
			// Token: 0x040395E9 RID: 234985
			DescriptionItem,
			// Token: 0x040395EA RID: 234986
			DescriptionText,
			// Token: 0x040395EB RID: 234987
			Button
		}
	}
}
