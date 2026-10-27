using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x02006330 RID: 25392
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballMainButtonItem : UiPanelBase
	{
		// Token: 0x0603FE1D RID: 261661 RVA: 0x00F74470 File Offset: 0x00F72670
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FE1E RID: 261662 RVA: 0x00F74538 File Offset: 0x00F72738
		[NullableContext(1)]
		public void SetConfigData(IPinballMainButtonConfig config)
		{
			if (config.FunctionId != null)
			{
				this.FunctionId = config.FunctionId.Value;
			}
			if (config.ShowRedDot != null)
			{
				this.ShowRedDotCallback = config.ShowRedDot;
			}
			if (config.SetTextCallback != null)
			{
				this.SetTextCallback = config.SetTextCallback;
			}
			if (config.OnClickCallback != null)
			{
				this.ClickCallBack = config.OnClickCallback;
			}
			if (config.ShowCallback != null)
			{
				this.ShowCallback = config.ShowCallback;
			}
			if (config.RedDotName != null)
			{
				this.RedDotName = config.RedDotName;
			}
		}

		// Token: 0x0603FE1F RID: 261663 RVA: 0x00F745D8 File Offset: 0x00F727D8
		public void SetButtonState()
		{
			bool flag = FunctionModel.Instance.IsOpen(this.FunctionId);
			bool flag2 = this.ShowCallback == null || this.ShowCallback();
			base.SetUiActive(flag && flag2);
		}

		// Token: 0x0603FE20 RID: 261664 RVA: 0x00F74616 File Offset: 0x00F72816
		public void SetProgressText()
		{
			if (this.SetTextCallback != null)
			{
				this.SetTextCallback(base.GetText(2));
				return;
			}
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText("", true);
		}

		// Token: 0x0603FE21 RID: 261665 RVA: 0x00F7464C File Offset: 0x00F7284C
		public void SetRedDot()
		{
			if (this.ShowRedDotCallback == null)
			{
				if (this.RedDotName == null)
				{
					UUIItem item = base.GetItem(1);
					if (item == null)
					{
						return;
					}
					item.SetUIActive(false);
				}
				return;
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(this.ShowRedDotCallback());
		}

		// Token: 0x0603FE22 RID: 261666 RVA: 0x00F7469D File Offset: 0x00F7289D
		public void BindRedDot()
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.BindRedDot(this.RedDotName.Value, base.GetItem(1), null, 0);
			}
		}

		// Token: 0x0603FE23 RID: 261667 RVA: 0x00F746CA File Offset: 0x00F728CA
		public void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(1), 0);
			}
		}

		// Token: 0x0603FE24 RID: 261668 RVA: 0x00F746F6 File Offset: 0x00F728F6
		public void Clear()
		{
			this.ClickCallBack = null;
			this.ShowRedDotCallback = null;
			this.SetTextCallback = null;
			this.ShowCallback = null;
			this.UnBindRedDot();
		}

		// Token: 0x0603FE25 RID: 261669 RVA: 0x00F7471A File Offset: 0x00F7291A
		private void ButtonClick()
		{
			Action clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack();
		}

		// Token: 0x04021533 RID: 136499
		private int FunctionId;

		// Token: 0x04021534 RID: 136500
		private ERedDotName? RedDotName;

		// Token: 0x04021535 RID: 136501
		private Action ClickCallBack;

		// Token: 0x04021536 RID: 136502
		private Func<bool> ShowRedDotCallback;

		// Token: 0x04021537 RID: 136503
		private Action<UUIText> SetTextCallback;

		// Token: 0x04021538 RID: 136504
		private Func<bool> ShowCallback;

		// Token: 0x0200C52A RID: 50474
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B821 RID: 243745
			Button,
			// Token: 0x0403B822 RID: 243746
			RedDotItem,
			// Token: 0x0403B823 RID: 243747
			TxtProgress
		}
	}
}
