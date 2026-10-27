using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleMorph.View
{
	// Token: 0x02004D67 RID: 19815
	public class GuYingXiongKaiSkillItem : UiPanelBase
	{
		// Token: 0x06033391 RID: 209809 RVA: 0x00BF20E8 File Offset: 0x00BF02E8
		[NullableContext(1)]
		public void RefreshByMoveType(int index, EInputAxis inputAxis, float inputValue, Action<int> onPressCallback)
		{
			this.Index = index;
			this.InputAxis = inputAxis;
			this.InputValue = inputValue;
			this.OnPressCallback = onPressCallback;
		}

		// Token: 0x06033392 RID: 209810 RVA: 0x00BF2108 File Offset: 0x00BF0308
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033393 RID: 209811 RVA: 0x00BF2150 File Offset: 0x00BF0350
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Bind(new Action(this.OnButtonPressed));
			button.OnPointUpCallBack.Bind(new Action(this.OnButtonReleased));
			button.OnPointCancelCallBack.Bind(new Action(this.OnButtonReleased));
		}

		// Token: 0x06033394 RID: 209812 RVA: 0x00BF21AE File Offset: 0x00BF03AE
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			this.IsPress = false;
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Unbind();
			button.OnPointUpCallBack.Unbind();
			button.OnPointCancelCallBack.Unbind();
		}

		// Token: 0x06033395 RID: 209813 RVA: 0x00BF21E4 File Offset: 0x00BF03E4
		private void OnButtonPressed()
		{
			this.IsPress = true;
			InputController.Instance.InputAxis(this.InputAxis, this.InputValue, true);
			Action<int> onPressCallback = this.OnPressCallback;
			if (onPressCallback == null)
			{
				return;
			}
			onPressCallback(this.Index);
		}

		// Token: 0x06033396 RID: 209814 RVA: 0x00BF221A File Offset: 0x00BF041A
		private void OnButtonReleased()
		{
			this.IsPress = false;
			InputController.Instance.InputAxis(this.InputAxis, 0f, true);
		}

		// Token: 0x06033397 RID: 209815 RVA: 0x00BF2239 File Offset: 0x00BF0439
		public void Tick(float delta)
		{
			if (!this.IsPress)
			{
				return;
			}
			InputController.Instance.InputAxis(this.InputAxis, this.InputValue, true);
		}

		// Token: 0x06033398 RID: 209816 RVA: 0x00BF225B File Offset: 0x00BF045B
		public void Press(bool isPress)
		{
			if (isPress == this.IsPress)
			{
				return;
			}
			if (isPress)
			{
				this.OnButtonPressed();
				return;
			}
			this.OnButtonReleased();
		}

		// Token: 0x0401B318 RID: 111384
		private int Index;

		// Token: 0x0401B319 RID: 111385
		private bool IsPress;

		// Token: 0x0401B31A RID: 111386
		private EInputAxis InputAxis = EInputAxis.None;

		// Token: 0x0401B31B RID: 111387
		private float InputValue;

		// Token: 0x0401B31C RID: 111388
		[Nullable(2)]
		private Action<int> OnPressCallback;

		// Token: 0x0200AED8 RID: 44760
		private enum EChildType
		{
			// Token: 0x040351A0 RID: 217504
			BtnClick
		}
	}
}
