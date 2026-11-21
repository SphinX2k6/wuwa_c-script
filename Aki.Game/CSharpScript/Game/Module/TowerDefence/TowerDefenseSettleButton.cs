using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B0E RID: 15118
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseSettleButton : UiPanelBase
	{
		// Token: 0x06026D26 RID: 159014 RVA: 0x00ADD668 File Offset: 0x00ADB868
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

		// Token: 0x06026D27 RID: 159015 RVA: 0x00ADD750 File Offset: 0x00ADB950
		public UniTask InitializeAsync(AActor rootActor, Action onClick)
		{
			TowerDefenseSettleButton.<InitializeAsync>d__2 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.rootActor = rootActor;
			<InitializeAsync>d__.onClick = onClick;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<TowerDefenseSettleButton.<InitializeAsync>d__2>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026D28 RID: 159016 RVA: 0x00ADD7A3 File Offset: 0x00ADB9A3
		public void SetBtnTextById(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x06026D29 RID: 159017 RVA: 0x00ADD7B8 File Offset: 0x00ADB9B8
		public void SetFloatText(string textId, params string[] args)
		{
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
		}

		// Token: 0x06026D2A RID: 159018 RVA: 0x00ADD7DA File Offset: 0x00ADB9DA
		private void OnClickedButton()
		{
			Action onClickEvent = this.OnClickEvent;
			if (onClickEvent == null)
			{
				return;
			}
			onClickEvent();
		}

		// Token: 0x04015396 RID: 86934
		[Nullable(2)]
		private Action OnClickEvent;

		// Token: 0x0200971B RID: 38683
		[NullableContext(0)]
		private class ESettleButton
		{
			// Token: 0x0402F29F RID: 193183
			public const int ButtonText = 0;

			// Token: 0x0402F2A0 RID: 193184
			public const int DescriptionItem = 1;

			// Token: 0x0402F2A1 RID: 193185
			public const int DescriptionText = 2;

			// Token: 0x0402F2A2 RID: 193186
			public const int Button = 3;
		}
	}
}
