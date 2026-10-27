using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005324 RID: 21284
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueButtonItemA : UiPanelBase
	{
		// Token: 0x060366CE RID: 222926 RVA: 0x00CE1FC4 File Offset: 0x00CE01C4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
			};
		}

		// Token: 0x060366CF RID: 222927 RVA: 0x00CE2070 File Offset: 0x00CE0270
		public void BindRedDot(ERedDotName redDotName, int? uid = null)
		{
			this.RedDotName = new ERedDotName?(redDotName);
			UUIItem item = base.GetItem(3);
			RedDotController.Instance.BindRedDot(redDotName, item, null, uid.GetValueOrDefault());
		}

		// Token: 0x060366D0 RID: 222928 RVA: 0x00CE20A8 File Offset: 0x00CE02A8
		public void UnBindRedDot()
		{
			if (this.RedDotName == null)
			{
				return;
			}
			UUIItem item = base.GetItem(3);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
		}

		// Token: 0x060366D1 RID: 222929 RVA: 0x00CE20E4 File Offset: 0x00CE02E4
		public void SetNameById(string name)
		{
			TextConfig instance = TextConfig.Instance;
			string newText = (instance != null) ? instance.GetTextById(name) : null;
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x060366D2 RID: 222930 RVA: 0x00CE2117 File Offset: 0x00CE0317
		public void SetName(string name)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(name, true);
		}

		// Token: 0x060366D3 RID: 222931 RVA: 0x00CE212C File Offset: 0x00CE032C
		public void SetNum(string num)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(num, true);
		}

		// Token: 0x060366D4 RID: 222932 RVA: 0x00CE2141 File Offset: 0x00CE0341
		public void SetLimitTime(string time)
		{
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(time, true);
		}

		// Token: 0x060366D5 RID: 222933 RVA: 0x00CE2169 File Offset: 0x00CE0369
		public void SetOnClickCall(Action cb)
		{
			this.OnClickCall = cb;
		}

		// Token: 0x060366D6 RID: 222934 RVA: 0x00CE2172 File Offset: 0x00CE0372
		private void OnClick()
		{
			this.OnClickCall();
		}

		// Token: 0x0401CC5A RID: 117850
		private Action OnClickCall = delegate()
		{
		};

		// Token: 0x0401CC5B RID: 117851
		private ERedDotName? RedDotName;
	}
}
