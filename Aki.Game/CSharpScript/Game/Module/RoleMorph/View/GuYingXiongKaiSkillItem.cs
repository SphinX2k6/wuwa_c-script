using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleMorph.View
{
	// Token: 0x02003D30 RID: 15664
	public class GuYingXiongKaiSkillItem : UiPanelBase
	{
		// Token: 0x060281FF RID: 164351 RVA: 0x00B3B30C File Offset: 0x00B3950C
		[NullableContext(1)]
		public void RefreshByMoveType(int index, EInputAxis inputAxis, float inputValue, Action<int> onPressCallback)
		{
			this.Index = index;
			this.InputAxis = inputAxis;
			this.InputValue = inputValue;
			this.OnPressCallback = onPressCallback;
		}

		// Token: 0x06028200 RID: 164352 RVA: 0x00B3B32C File Offset: 0x00B3952C
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

		// Token: 0x06028201 RID: 164353 RVA: 0x00B3B374 File Offset: 0x00B39574
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Bind(new Action(this.OnButtonPressed));
			button.OnPointUpCallBack.Bind(new Action(this.OnButtonReleased));
			button.OnPointCancelCallBack.Bind(new Action(this.OnButtonReleased));
		}

		// Token: 0x06028202 RID: 164354 RVA: 0x00B3B3D2 File Offset: 0x00B395D2
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			this.IsPress = false;
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Unbind();
			button.OnPointUpCallBack.Unbind();
			button.OnPointCancelCallBack.Unbind();
		}

		// Token: 0x06028203 RID: 164355 RVA: 0x00B3B408 File Offset: 0x00B39608
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

		// Token: 0x06028204 RID: 164356 RVA: 0x00B3B43E File Offset: 0x00B3963E
		private void OnButtonReleased()
		{
			this.IsPress = false;
			InputController.Instance.InputAxis(this.InputAxis, 0f, true);
		}

		// Token: 0x06028205 RID: 164357 RVA: 0x00B3B45D File Offset: 0x00B3965D
		public void Tick(float delta)
		{
			if (!this.IsPress)
			{
				return;
			}
			InputController.Instance.InputAxis(this.InputAxis, this.InputValue, true);
		}

		// Token: 0x06028206 RID: 164358 RVA: 0x00B3B47F File Offset: 0x00B3967F
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

		// Token: 0x04015CEA RID: 89322
		private int Index;

		// Token: 0x04015CEB RID: 89323
		private bool IsPress;

		// Token: 0x04015CEC RID: 89324
		private EInputAxis InputAxis = EInputAxis.None;

		// Token: 0x04015CED RID: 89325
		private float InputValue;

		// Token: 0x04015CEE RID: 89326
		[Nullable(2)]
		private Action<int> OnPressCallback;

		// Token: 0x0200990B RID: 39179
		private enum EChildType
		{
			// Token: 0x0402FBD1 RID: 195537
			BtnClick
		}
	}
}
