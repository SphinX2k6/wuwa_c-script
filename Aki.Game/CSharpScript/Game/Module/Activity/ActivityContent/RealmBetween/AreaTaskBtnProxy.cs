using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006295 RID: 25237
	[NullableContext(1)]
	[Nullable(0)]
	public class AreaTaskBtnProxy : UiPanelBase
	{
		// Token: 0x0603F7F5 RID: 260085 RVA: 0x00F5A380 File Offset: 0x00F58580
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
			};
		}

		// Token: 0x0603F7F6 RID: 260086 RVA: 0x00F5A3E7 File Offset: 0x00F585E7
		private void OnClick()
		{
			Action clickFn = this.ClickFn;
			if (clickFn == null)
			{
				return;
			}
			clickFn();
		}

		// Token: 0x0603F7F7 RID: 260087 RVA: 0x00F5A3F9 File Offset: 0x00F585F9
		public void SetClickFunction(Action fn)
		{
			this.ClickFn = fn;
		}

		// Token: 0x0603F7F8 RID: 260088 RVA: 0x00F5A402 File Offset: 0x00F58602
		public void SetText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x0603F7F9 RID: 260089 RVA: 0x00F5A417 File Offset: 0x00F58617
		public void SetTextById(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x0603F7FA RID: 260090 RVA: 0x00F5A42C File Offset: 0x00F5862C
		public void SetBtnUiActive(bool value)
		{
			base.SetUiActive(value);
		}

		// Token: 0x04021311 RID: 135953
		[Nullable(2)]
		private Action ClickFn;
	}
}
