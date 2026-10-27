using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005F03 RID: 24323
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityTipsButton : UiPanelBase
	{
		// Token: 0x0603DCE9 RID: 253161 RVA: 0x00EF0E6B File Offset: 0x00EEF06B
		public ActivityTipsButton()
		{
			this.PermanentActivityHelpId = ConfigCommonParamById.GetIntConfig("PermanentActivityHelpId");
			this.ButtonFunction = new Action(this.PermanentActivityHelp);
		}

		// Token: 0x0603DCEA RID: 253162 RVA: 0x00EF0E98 File Offset: 0x00EEF098
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
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

		// Token: 0x0603DCEB RID: 253163 RVA: 0x00EF0F5F File Offset: 0x00EEF15F
		private void PermanentActivityHelp()
		{
			if (this.PermanentActivityHelpId != null)
			{
				HelpController.Instance.OpenHelpById(this.PermanentActivityHelpId.Value);
			}
		}

		// Token: 0x0603DCEC RID: 253164 RVA: 0x00EF0F83 File Offset: 0x00EEF183
		protected override void OnBeforeDestroy()
		{
			this.ButtonFunction = null;
		}

		// Token: 0x0603DCED RID: 253165 RVA: 0x00EF0F8C File Offset: 0x00EEF18C
		private void ButtonClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x0603DCEE RID: 253166 RVA: 0x00EF0F9E File Offset: 0x00EEF19E
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x0603DCEF RID: 253167 RVA: 0x00EF0FA7 File Offset: 0x00EEF1A7
		public void SetDefaultFunction()
		{
			this.ButtonFunction = new Action(this.PermanentActivityHelp);
		}

		// Token: 0x0603DCF0 RID: 253168 RVA: 0x00EF0FBC File Offset: 0x00EEF1BC
		public void SetText(string text)
		{
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
		}

		// Token: 0x0603DCF1 RID: 253169 RVA: 0x00EF0FDC File Offset: 0x00EEF1DC
		public void SetLocalTextNew(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
		}

		// Token: 0x04020490 RID: 132240
		private int? PermanentActivityHelpId;

		// Token: 0x04020491 RID: 132241
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x0200C239 RID: 49721
		[NullableContext(0)]
		private class EButtonItemDefine
		{
			// Token: 0x0403AAE5 RID: 240357
			public const int Button = 0;

			// Token: 0x0403AAE6 RID: 240358
			public const int Sprite = 1;

			// Token: 0x0403AAE7 RID: 240359
			public const int Text = 2;
		}
	}
}
