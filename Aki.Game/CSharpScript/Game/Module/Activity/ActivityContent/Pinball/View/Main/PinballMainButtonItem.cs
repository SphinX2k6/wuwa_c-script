using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052AE RID: 21166
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballMainButtonItem : UiPanelBase
	{
		// Token: 0x06034ADE RID: 215774 RVA: 0x00EBB3CC File Offset: 0x00EB95CC
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

		// Token: 0x06034ADF RID: 215775 RVA: 0x00EBB494 File Offset: 0x00EB9694
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

		// Token: 0x06034AE0 RID: 215776 RVA: 0x00EBB534 File Offset: 0x00EB9734
		public void SetButtonState()
		{
			bool flag = FunctionModel.Instance.IsOpen(this.FunctionId);
			bool flag2 = this.ShowCallback == null || this.ShowCallback();
			base.SetUiActive(flag && flag2);
		}

		// Token: 0x06034AE1 RID: 215777 RVA: 0x00EBB572 File Offset: 0x00EB9772
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

		// Token: 0x06034AE2 RID: 215778 RVA: 0x00EBB5A8 File Offset: 0x00EB97A8
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

		// Token: 0x06034AE3 RID: 215779 RVA: 0x00EBB5F9 File Offset: 0x00EB97F9
		public void BindRedDot()
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.BindRedDot(this.RedDotName.Value, base.GetItem(1), null, 0);
			}
		}

		// Token: 0x06034AE4 RID: 215780 RVA: 0x00EBB626 File Offset: 0x00EB9826
		public void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(1), 0);
			}
		}

		// Token: 0x06034AE5 RID: 215781 RVA: 0x00EBB652 File Offset: 0x00EB9852
		public void Clear()
		{
			this.ClickCallBack = null;
			this.ShowRedDotCallback = null;
			this.SetTextCallback = null;
			this.ShowCallback = null;
			this.UnBindRedDot();
		}

		// Token: 0x06034AE6 RID: 215782 RVA: 0x00EBB676 File Offset: 0x00EB9876
		private void ButtonClick()
		{
			Action clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack();
		}

		// Token: 0x0401BE62 RID: 114274
		private int FunctionId;

		// Token: 0x0401BE63 RID: 114275
		private ERedDotName? RedDotName;

		// Token: 0x0401BE64 RID: 114276
		private Action ClickCallBack;

		// Token: 0x0401BE65 RID: 114277
		private Func<bool> ShowRedDotCallback;

		// Token: 0x0401BE66 RID: 114278
		private Action<UUIText> SetTextCallback;

		// Token: 0x0401BE67 RID: 114279
		private Func<bool> ShowCallback;

		// Token: 0x0200AF11 RID: 44817
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036183 RID: 221571
			Button,
			// Token: 0x04036184 RID: 221572
			RedDotItem,
			// Token: 0x04036185 RID: 221573
			TxtProgress
		}
	}
}
