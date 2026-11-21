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
	// Token: 0x02004BF5 RID: 19445
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingSettleButton : UiPanelBase
	{
		// Token: 0x06030862 RID: 198754 RVA: 0x00D84F9C File Offset: 0x00D8319C
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

		// Token: 0x06030863 RID: 198755 RVA: 0x00D85084 File Offset: 0x00D83284
		protected override void OnBeforeShow()
		{
			base.GetText(0).SetText("", true);
			base.GetText(2).SetText("", true);
		}

		// Token: 0x06030864 RID: 198756 RVA: 0x00D850AC File Offset: 0x00D832AC
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

		// Token: 0x06030865 RID: 198757 RVA: 0x00D850FF File Offset: 0x00D832FF
		private void OnClickedButton()
		{
			Action onClickEvent = this.OnClickEvent;
			if (onClickEvent == null)
			{
				return;
			}
			onClickEvent();
		}

		// Token: 0x06030866 RID: 198758 RVA: 0x00D85111 File Offset: 0x00D83311
		public void SetFloatText(string textId, params string[] args)
		{
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
		}

		// Token: 0x06030867 RID: 198759 RVA: 0x00D85133 File Offset: 0x00D83333
		public void SetBtnTextNew(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x04019AFB RID: 105211
		[Nullable(2)]
		private Action OnClickEvent;

		// Token: 0x0200A807 RID: 43015
		[NullableContext(0)]
		private enum EBossPilingButton
		{
			// Token: 0x04033E61 RID: 212577
			ButtonText,
			// Token: 0x04033E62 RID: 212578
			DescriptionItem,
			// Token: 0x04033E63 RID: 212579
			DescriptionText,
			// Token: 0x04033E64 RID: 212580
			Button
		}
	}
}
