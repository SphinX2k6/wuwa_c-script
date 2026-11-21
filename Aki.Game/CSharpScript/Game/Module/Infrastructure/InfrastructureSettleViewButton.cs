using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048E6 RID: 18662
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureSettleViewButton : UiPanelBase
	{
		// Token: 0x0602ED60 RID: 191840 RVA: 0x00D0F380 File Offset: 0x00D0D580
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602ED61 RID: 191841 RVA: 0x00D0F48C File Offset: 0x00D0D68C
		protected override UniTask OnBeforeStartAsync()
		{
			InfrastructureSettleViewButton.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrastructureSettleViewButton.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED62 RID: 191842 RVA: 0x00D0F4D0 File Offset: 0x00D0D6D0
		protected override void OnStart()
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(true);
			this.LeftButton.SetLocalTextNew("JijianTask_CompleteButton", Array.Empty<object>());
		}

		// Token: 0x0602ED63 RID: 191843 RVA: 0x00D0F50C File Offset: 0x00D0D70C
		private void OnClickedLeftButton(int _)
		{
			Action onClickLeftEvent = this.OnClickLeftEvent;
			if (onClickLeftEvent == null)
			{
				return;
			}
			onClickLeftEvent();
		}

		// Token: 0x0602ED64 RID: 191844 RVA: 0x00D0F51E File Offset: 0x00D0D71E
		private void OnClickedButton()
		{
			Action onClickEvent = this.OnClickEvent;
			if (onClickEvent == null)
			{
				return;
			}
			onClickEvent();
		}

		// Token: 0x0602ED65 RID: 191845 RVA: 0x00D0F530 File Offset: 0x00D0D730
		public void SetBtnText(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(0), textId, args);
		}

		// Token: 0x0602ED66 RID: 191846 RVA: 0x00D0F545 File Offset: 0x00D0D745
		public void HideFloatText()
		{
			base.GetText(2).SetUIActive(false);
		}

		// Token: 0x0602ED67 RID: 191847 RVA: 0x00D0F554 File Offset: 0x00D0D754
		public void SetOnClickEvent(Action onClickEvent)
		{
			this.OnClickEvent = onClickEvent;
		}

		// Token: 0x0602ED68 RID: 191848 RVA: 0x00D0F55D File Offset: 0x00D0D75D
		public void SetOnClickLeftEvent(Action onClickLeftEvent)
		{
			this.OnClickLeftEvent = onClickLeftEvent;
		}

		// Token: 0x04018DAE RID: 101806
		private Action OnClickEvent;

		// Token: 0x04018DAF RID: 101807
		private Action OnClickLeftEvent;

		// Token: 0x04018DB0 RID: 101808
		private ButtonItem LeftButton = new ButtonItem(null);

		// Token: 0x0200A58A RID: 42378
		[NullableContext(0)]
		private class ESimpleButtonChildType
		{
			// Token: 0x04033355 RID: 209749
			public const int ButtonText = 0;

			// Token: 0x04033356 RID: 209750
			public const int DescriptionItem = 1;

			// Token: 0x04033357 RID: 209751
			public const int DescriptionText = 2;

			// Token: 0x04033358 RID: 209752
			public const int Button = 3;

			// Token: 0x04033359 RID: 209753
			public const int LeftButton = 4;
		}
	}
}
