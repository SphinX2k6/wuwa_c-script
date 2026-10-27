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
	// Token: 0x0200590D RID: 22797
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureSettleViewButton : UiPanelBase
	{
		// Token: 0x06039E3D RID: 237117 RVA: 0x00DC0088 File Offset: 0x00DBE288
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

		// Token: 0x06039E3E RID: 237118 RVA: 0x00DC0194 File Offset: 0x00DBE394
		protected override UniTask OnBeforeStartAsync()
		{
			InfrastructureSettleViewButton.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrastructureSettleViewButton.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039E3F RID: 237119 RVA: 0x00DC01D8 File Offset: 0x00DBE3D8
		protected override void OnStart()
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(true);
			this.LeftButton.SetLocalTextNew("JijianTask_CompleteButton", Array.Empty<object>());
		}

		// Token: 0x06039E40 RID: 237120 RVA: 0x00DC0214 File Offset: 0x00DBE414
		private void OnClickedLeftButton(int _)
		{
			Action onClickLeftEvent = this.OnClickLeftEvent;
			if (onClickLeftEvent == null)
			{
				return;
			}
			onClickLeftEvent();
		}

		// Token: 0x06039E41 RID: 237121 RVA: 0x00DC0226 File Offset: 0x00DBE426
		private void OnClickedButton()
		{
			Action onClickEvent = this.OnClickEvent;
			if (onClickEvent == null)
			{
				return;
			}
			onClickEvent();
		}

		// Token: 0x06039E42 RID: 237122 RVA: 0x00DC0238 File Offset: 0x00DBE438
		public void SetBtnText(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(0), textId, args);
		}

		// Token: 0x06039E43 RID: 237123 RVA: 0x00DC024D File Offset: 0x00DBE44D
		public void HideFloatText()
		{
			base.GetText(2).SetUIActive(false);
		}

		// Token: 0x06039E44 RID: 237124 RVA: 0x00DC025C File Offset: 0x00DBE45C
		public void SetOnClickEvent(Action onClickEvent)
		{
			this.OnClickEvent = onClickEvent;
		}

		// Token: 0x06039E45 RID: 237125 RVA: 0x00DC0265 File Offset: 0x00DBE465
		public void SetOnClickLeftEvent(Action onClickLeftEvent)
		{
			this.OnClickLeftEvent = onClickLeftEvent;
		}

		// Token: 0x0401E311 RID: 123665
		private Action OnClickEvent;

		// Token: 0x0401E312 RID: 123666
		private Action OnClickLeftEvent;

		// Token: 0x0401E313 RID: 123667
		private ButtonItem LeftButton = new ButtonItem(null);

		// Token: 0x0200BB7A RID: 47994
		[NullableContext(0)]
		private class ESimpleButtonChildType
		{
			// Token: 0x0403896D RID: 231789
			public const int ButtonText = 0;

			// Token: 0x0403896E RID: 231790
			public const int DescriptionItem = 1;

			// Token: 0x0403896F RID: 231791
			public const int DescriptionText = 2;

			// Token: 0x04038970 RID: 231792
			public const int Button = 3;

			// Token: 0x04038971 RID: 231793
			public const int LeftButton = 4;
		}
	}
}
