using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02005C15 RID: 23573
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingSettleButton : UiPanelBase
	{
		// Token: 0x0603B917 RID: 243991 RVA: 0x00E34C40 File Offset: 0x00E32E40
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

		// Token: 0x0603B918 RID: 243992 RVA: 0x00E34D28 File Offset: 0x00E32F28
		protected override void OnBeforeShow()
		{
			base.GetText(0).SetText("", true);
			base.GetText(2).SetText("", true);
		}

		// Token: 0x0603B919 RID: 243993 RVA: 0x00E34D50 File Offset: 0x00E32F50
		public UniTask InitializeAsync(AActor rootActor, Action onClickCall)
		{
			BossPilingSettleButton.<InitializeAsync>d__4 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.rootActor = rootActor;
			<InitializeAsync>d__.onClickCall = onClickCall;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BossPilingSettleButton.<InitializeAsync>d__4>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B91A RID: 243994 RVA: 0x00E34DA3 File Offset: 0x00E32FA3
		private void OnClickedButton()
		{
			Action onClickEvent = this.OnClickEvent;
			if (onClickEvent == null)
			{
				return;
			}
			onClickEvent();
		}

		// Token: 0x0603B91B RID: 243995 RVA: 0x00E34DB5 File Offset: 0x00E32FB5
		public void SetFloatText(string textId, params string[] args)
		{
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
		}

		// Token: 0x0603B91C RID: 243996 RVA: 0x00E34DD7 File Offset: 0x00E32FD7
		public void SetBtnTextNew(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x0401F04A RID: 127050
		[Nullable(2)]
		private Action OnClickEvent;

		// Token: 0x0200BDFF RID: 48639
		[NullableContext(0)]
		private enum EBossPilingButton
		{
			// Token: 0x0403949E RID: 234654
			ButtonText,
			// Token: 0x0403949F RID: 234655
			DescriptionItem,
			// Token: 0x040394A0 RID: 234656
			DescriptionText,
			// Token: 0x040394A1 RID: 234657
			Button
		}
	}
}
