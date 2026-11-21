using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiComponent.UiHomeButton
{
	// Token: 0x02003987 RID: 14727
	public class HomeBtnItem : UiPanelBase
	{
		// Token: 0x06025E59 RID: 155225 RVA: 0x00AA4190 File Offset: 0x00AA2390
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISpriteTransition));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06025E5A RID: 155226 RVA: 0x00AA4238 File Offset: 0x00AA2438
		protected override UniTask OnBeforeStartAsync()
		{
			HomeBtnItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HomeBtnItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025E5B RID: 155227 RVA: 0x00AA427B File Offset: 0x00AA247B
		[NullableContext(1)]
		public void SetFunction(Action callback)
		{
			this.CallBack = callback;
		}

		// Token: 0x06025E5C RID: 155228 RVA: 0x00AA4284 File Offset: 0x00AA2484
		private void OnButtonClick()
		{
			Action callBack = this.CallBack;
			if (callBack == null)
			{
				return;
			}
			callBack();
		}

		// Token: 0x06025E5D RID: 155229 RVA: 0x00AA4296 File Offset: 0x00AA2496
		public void SetHomeBtnStyle(int id)
		{
			this.HomeBtnStyle = new int?(id);
		}

		// Token: 0x06025E5E RID: 155230 RVA: 0x00AA42A4 File Offset: 0x00AA24A4
		public void SetSnapSize(bool snap)
		{
			this.SnapSize = snap;
		}

		// Token: 0x04014D78 RID: 85368
		[Nullable(2)]
		private Action CallBack;

		// Token: 0x04014D79 RID: 85369
		private int? HomeBtnStyle;

		// Token: 0x04014D7A RID: 85370
		private bool SnapSize;

		// Token: 0x020095D6 RID: 38358
		private enum EComponent
		{
			// Token: 0x0402ECE6 RID: 191718
			Btn,
			// Token: 0x0402ECE7 RID: 191719
			Img
		}
	}
}
