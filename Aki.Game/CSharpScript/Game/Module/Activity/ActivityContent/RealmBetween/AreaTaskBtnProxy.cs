using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02005213 RID: 21011
	[NullableContext(1)]
	[Nullable(0)]
	public class AreaTaskBtnProxy : UiPanelBase
	{
		// Token: 0x060344B6 RID: 214198 RVA: 0x00EA12DC File Offset: 0x00E9F4DC
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

		// Token: 0x060344B7 RID: 214199 RVA: 0x00EA1343 File Offset: 0x00E9F543
		private void OnClick()
		{
			Action clickFn = this.ClickFn;
			if (clickFn == null)
			{
				return;
			}
			clickFn();
		}

		// Token: 0x060344B8 RID: 214200 RVA: 0x00EA1355 File Offset: 0x00E9F555
		public void SetClickFunction(Action fn)
		{
			this.ClickFn = fn;
		}

		// Token: 0x060344B9 RID: 214201 RVA: 0x00EA135E File Offset: 0x00E9F55E
		public void SetText(string text)
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x060344BA RID: 214202 RVA: 0x00EA1373 File Offset: 0x00E9F573
		public void SetTextById(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x060344BB RID: 214203 RVA: 0x00EA1388 File Offset: 0x00E9F588
		public void SetBtnUiActive(bool value)
		{
			base.SetUiActive(value);
		}

		// Token: 0x0401BC40 RID: 113728
		[Nullable(2)]
		private Action ClickFn;
	}
}
