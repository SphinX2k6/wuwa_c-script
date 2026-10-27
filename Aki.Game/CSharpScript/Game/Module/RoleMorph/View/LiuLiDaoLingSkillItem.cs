using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleMorph.View
{
	// Token: 0x02004D69 RID: 19817
	public class LiuLiDaoLingSkillItem : UiPanelBase
	{
		// Token: 0x060333A8 RID: 209832 RVA: 0x00BF28BF File Offset: 0x00BF0ABF
		[NullableContext(1)]
		public void RefreshByMoveType(int index, EInputAxis inputAxis, float inputValue, Action<int> onPressCallback)
		{
			this.Index = index;
			this.InputAxis = inputAxis;
			this.InputValue = inputValue;
			this.OnPressCallback = onPressCallback;
		}

		// Token: 0x060333A9 RID: 209833 RVA: 0x00BF28E0 File Offset: 0x00BF0AE0
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

		// Token: 0x060333AA RID: 209834 RVA: 0x00BF2928 File Offset: 0x00BF0B28
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Bind(new Action(this.OnButtonPressed));
			button.OnPointUpCallBack.Bind(new Action(this.OnButtonReleased));
			button.OnPointCancelCallBack.Bind(new Action(this.OnButtonReleased));
		}

		// Token: 0x060333AB RID: 209835 RVA: 0x00BF2986 File Offset: 0x00BF0B86
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			this.IsPress = false;
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Unbind();
			button.OnPointUpCallBack.Unbind();
			button.OnPointCancelCallBack.Unbind();
		}

		// Token: 0x060333AC RID: 209836 RVA: 0x00BF29BC File Offset: 0x00BF0BBC
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

		// Token: 0x060333AD RID: 209837 RVA: 0x00BF29F2 File Offset: 0x00BF0BF2
		private void OnButtonReleased()
		{
			this.IsPress = false;
			InputController.Instance.InputAxis(this.InputAxis, 0f, true);
		}

		// Token: 0x060333AE RID: 209838 RVA: 0x00BF2A11 File Offset: 0x00BF0C11
		public void Tick(float delta)
		{
			if (!this.IsPress)
			{
				return;
			}
			InputController.Instance.InputAxis(this.InputAxis, this.InputValue, true);
		}

		// Token: 0x060333AF RID: 209839 RVA: 0x00BF2A33 File Offset: 0x00BF0C33
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

		// Token: 0x0401B323 RID: 111395
		private int Index;

		// Token: 0x0401B324 RID: 111396
		private bool IsPress;

		// Token: 0x0401B325 RID: 111397
		private EInputAxis InputAxis = EInputAxis.None;

		// Token: 0x0401B326 RID: 111398
		private float InputValue;

		// Token: 0x0401B327 RID: 111399
		[Nullable(2)]
		private Action<int> OnPressCallback;

		// Token: 0x0200AEDE RID: 44766
		private enum EChildType
		{
			// Token: 0x040351C3 RID: 217539
			BtnClick
		}
	}
}
