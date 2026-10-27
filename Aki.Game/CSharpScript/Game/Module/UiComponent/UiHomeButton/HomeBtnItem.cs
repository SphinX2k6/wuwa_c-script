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
	// Token: 0x02004A0B RID: 18955
	public class HomeBtnItem : UiPanelBase
	{
		// Token: 0x06031309 RID: 201481 RVA: 0x00B68988 File Offset: 0x00B66B88
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

		// Token: 0x0603130A RID: 201482 RVA: 0x00B68A30 File Offset: 0x00B66C30
		protected override UniTask OnBeforeStartAsync()
		{
			HomeBtnItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HomeBtnItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603130B RID: 201483 RVA: 0x00B68A73 File Offset: 0x00B66C73
		[NullableContext(1)]
		public void SetFunction(Action callback)
		{
			this.CallBack = callback;
		}

		// Token: 0x0603130C RID: 201484 RVA: 0x00B68A7C File Offset: 0x00B66C7C
		private void OnButtonClick()
		{
			Action callBack = this.CallBack;
			if (callBack == null)
			{
				return;
			}
			callBack();
		}

		// Token: 0x0603130D RID: 201485 RVA: 0x00B68A8E File Offset: 0x00B66C8E
		public void SetHomeBtnStyle(int id)
		{
			this.HomeBtnStyle = new int?(id);
		}

		// Token: 0x0603130E RID: 201486 RVA: 0x00B68A9C File Offset: 0x00B66C9C
		public void SetSnapSize(bool snap)
		{
			this.SnapSize = snap;
		}

		// Token: 0x0401A4F2 RID: 107762
		[Nullable(2)]
		private Action CallBack;

		// Token: 0x0401A4F3 RID: 107763
		private int? HomeBtnStyle;

		// Token: 0x0401A4F4 RID: 107764
		private bool SnapSize;

		// Token: 0x0200ABC7 RID: 43975
		private enum EComponent
		{
			// Token: 0x04034363 RID: 213859
			Btn,
			// Token: 0x04034364 RID: 213860
			Img
		}
	}
}
