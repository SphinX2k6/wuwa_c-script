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
	// Token: 0x02004B66 RID: 19302
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseSettleButton : UiPanelBase
	{
		// Token: 0x06031F97 RID: 204695 RVA: 0x00B9942C File Offset: 0x00B9762C
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

		// Token: 0x06031F98 RID: 204696 RVA: 0x00B99514 File Offset: 0x00B97714
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

		// Token: 0x06031F99 RID: 204697 RVA: 0x00B99567 File Offset: 0x00B97767
		public void SetBtnTextById(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x06031F9A RID: 204698 RVA: 0x00B9957C File Offset: 0x00B9777C
		public void SetFloatText(string textId, params string[] args)
		{
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
		}

		// Token: 0x06031F9B RID: 204699 RVA: 0x00B9959E File Offset: 0x00B9779E
		private void OnClickedButton()
		{
			Action onClickEvent = this.OnClickEvent;
			if (onClickEvent == null)
			{
				return;
			}
			onClickEvent();
		}

		// Token: 0x0401AA44 RID: 109124
		[Nullable(2)]
		private Action OnClickEvent;

		// Token: 0x0200ACFC RID: 44284
		[NullableContext(0)]
		private class ESettleButton
		{
			// Token: 0x040348F6 RID: 215286
			public const int ButtonText = 0;

			// Token: 0x040348F7 RID: 215287
			public const int DescriptionItem = 1;

			// Token: 0x040348F8 RID: 215288
			public const int DescriptionText = 2;

			// Token: 0x040348F9 RID: 215289
			public const int Button = 3;
		}
	}
}
