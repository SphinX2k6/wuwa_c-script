using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleMorph.View
{
	// Token: 0x02003D32 RID: 15666
	public class LiuLiDaoLingSkillItem : UiPanelBase
	{
		// Token: 0x06028216 RID: 164374 RVA: 0x00B3BAE3 File Offset: 0x00B39CE3
		[NullableContext(1)]
		public void RefreshByMoveType(int index, EInputAxis inputAxis, float inputValue, Action<int> onPressCallback)
		{
			this.Index = index;
			this.InputAxis = inputAxis;
			this.InputValue = inputValue;
			this.OnPressCallback = onPressCallback;
		}

		// Token: 0x06028217 RID: 164375 RVA: 0x00B3BB04 File Offset: 0x00B39D04
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

		// Token: 0x06028218 RID: 164376 RVA: 0x00B3BB4C File Offset: 0x00B39D4C
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Bind(new Action(this.OnButtonPressed));
			button.OnPointUpCallBack.Bind(new Action(this.OnButtonReleased));
			button.OnPointCancelCallBack.Bind(new Action(this.OnButtonReleased));
		}

		// Token: 0x06028219 RID: 164377 RVA: 0x00B3BBAA File Offset: 0x00B39DAA
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			this.IsPress = false;
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Unbind();
			button.OnPointUpCallBack.Unbind();
			button.OnPointCancelCallBack.Unbind();
		}

		// Token: 0x0602821A RID: 164378 RVA: 0x00B3BBE0 File Offset: 0x00B39DE0
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

		// Token: 0x0602821B RID: 164379 RVA: 0x00B3BC16 File Offset: 0x00B39E16
		private void OnButtonReleased()
		{
			this.IsPress = false;
			InputController.Instance.InputAxis(this.InputAxis, 0f, true);
		}

		// Token: 0x0602821C RID: 164380 RVA: 0x00B3BC35 File Offset: 0x00B39E35
		public void Tick(float delta)
		{
			if (!this.IsPress)
			{
				return;
			}
			InputController.Instance.InputAxis(this.InputAxis, this.InputValue, true);
		}

		// Token: 0x0602821D RID: 164381 RVA: 0x00B3BC57 File Offset: 0x00B39E57
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

		// Token: 0x04015CF5 RID: 89333
		private int Index;

		// Token: 0x04015CF6 RID: 89334
		private bool IsPress;

		// Token: 0x04015CF7 RID: 89335
		private EInputAxis InputAxis = EInputAxis.None;

		// Token: 0x04015CF8 RID: 89336
		private float InputValue;

		// Token: 0x04015CF9 RID: 89337
		[Nullable(2)]
		private Action<int> OnPressCallback;

		// Token: 0x02009911 RID: 39185
		private enum EChildType
		{
			// Token: 0x0402FBF4 RID: 195572
			BtnClick
		}
	}
}
