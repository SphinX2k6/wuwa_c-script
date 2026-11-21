using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042F4 RID: 17140
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueButtonItemA : UiPanelBase
	{
		// Token: 0x0602B5CA RID: 177610 RVA: 0x00C2F994 File Offset: 0x00C2DB94
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

		// Token: 0x0602B5CB RID: 177611 RVA: 0x00C2FA40 File Offset: 0x00C2DC40
		public void BindRedDot(ERedDotName redDotName, int? uid = null)
		{
			this.RedDotName = new ERedDotName?(redDotName);
			UUIItem item = base.GetItem(3);
			RedDotController.Instance.BindRedDot(redDotName, item, null, uid.GetValueOrDefault());
		}

		// Token: 0x0602B5CC RID: 177612 RVA: 0x00C2FA78 File Offset: 0x00C2DC78
		public void UnBindRedDot()
		{
			if (this.RedDotName == null)
			{
				return;
			}
			UUIItem item = base.GetItem(3);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
		}

		// Token: 0x0602B5CD RID: 177613 RVA: 0x00C2FAB4 File Offset: 0x00C2DCB4
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

		// Token: 0x0602B5CE RID: 177614 RVA: 0x00C2FAE7 File Offset: 0x00C2DCE7
		public void SetName(string name)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(name, true);
		}

		// Token: 0x0602B5CF RID: 177615 RVA: 0x00C2FAFC File Offset: 0x00C2DCFC
		public void SetNum(string num)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(num, true);
		}

		// Token: 0x0602B5D0 RID: 177616 RVA: 0x00C2FB11 File Offset: 0x00C2DD11
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

		// Token: 0x0602B5D1 RID: 177617 RVA: 0x00C2FB39 File Offset: 0x00C2DD39
		public void SetOnClickCall(Action cb)
		{
			this.OnClickCall = cb;
		}

		// Token: 0x0602B5D2 RID: 177618 RVA: 0x00C2FB42 File Offset: 0x00C2DD42
		private void OnClick()
		{
			this.OnClickCall();
		}

		// Token: 0x04017690 RID: 95888
		private Action OnClickCall = delegate()
		{
		};

		// Token: 0x04017691 RID: 95889
		private ERedDotName? RedDotName;
	}
}
