using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02004EEA RID: 20202
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityTipsButton : UiPanelBase
	{
		// Token: 0x06032C84 RID: 208004 RVA: 0x00E42B73 File Offset: 0x00E40D73
		public ActivityTipsButton()
		{
			this.PermanentActivityHelpId = ConfigCommonParamById.GetIntConfig("PermanentActivityHelpId");
			this.ButtonFunction = new Action(this.PermanentActivityHelp);
		}

		// Token: 0x06032C85 RID: 208005 RVA: 0x00E42BA0 File Offset: 0x00E40DA0
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

		// Token: 0x06032C86 RID: 208006 RVA: 0x00E42C67 File Offset: 0x00E40E67
		private void PermanentActivityHelp()
		{
			if (this.PermanentActivityHelpId != null)
			{
				HelpController.Instance.OpenHelpById(this.PermanentActivityHelpId.Value);
			}
		}

		// Token: 0x06032C87 RID: 208007 RVA: 0x00E42C8B File Offset: 0x00E40E8B
		protected override void OnBeforeDestroy()
		{
			this.ButtonFunction = null;
		}

		// Token: 0x06032C88 RID: 208008 RVA: 0x00E42C94 File Offset: 0x00E40E94
		private void ButtonClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x06032C89 RID: 208009 RVA: 0x00E42CA6 File Offset: 0x00E40EA6
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06032C8A RID: 208010 RVA: 0x00E42CAF File Offset: 0x00E40EAF
		public void SetDefaultFunction()
		{
			this.ButtonFunction = new Action(this.PermanentActivityHelp);
		}

		// Token: 0x06032C8B RID: 208011 RVA: 0x00E42CC4 File Offset: 0x00E40EC4
		public void SetText(string text)
		{
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
		}

		// Token: 0x06032C8C RID: 208012 RVA: 0x00E42CE4 File Offset: 0x00E40EE4
		public void SetLocalTextNew(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
		}

		// Token: 0x0401AF62 RID: 110434
		private int? PermanentActivityHelpId;

		// Token: 0x0401AF63 RID: 110435
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x0200AC46 RID: 44102
		[NullableContext(0)]
		private class EButtonItemDefine
		{
			// Token: 0x040354D7 RID: 218327
			public const int Button = 0;

			// Token: 0x040354D8 RID: 218328
			public const int Sprite = 1;

			// Token: 0x040354D9 RID: 218329
			public const int Text = 2;
		}
	}
}
