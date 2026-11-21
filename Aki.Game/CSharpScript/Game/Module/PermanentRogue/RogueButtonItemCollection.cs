using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042F6 RID: 17142
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueButtonItemCollection : UiPanelBase
	{
		// Token: 0x0602B5D4 RID: 177620 RVA: 0x00C2FB7C File Offset: 0x00C2DD7C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
			};
		}

		// Token: 0x0602B5D5 RID: 177621 RVA: 0x00C2FC3C File Offset: 0x00C2DE3C
		public void BindRedDot(ERedDotName redDotName, int? uid = null)
		{
			this.RedDotName = new ERedDotName?(redDotName);
			UUIItem item = base.GetItem(3);
			RedDotController.Instance.BindRedDot(redDotName, item, null, uid.GetValueOrDefault());
		}

		// Token: 0x0602B5D6 RID: 177622 RVA: 0x00C2FC74 File Offset: 0x00C2DE74
		public void UnBindRedDot()
		{
			if (this.RedDotName == null)
			{
				return;
			}
			UUIItem item = base.GetItem(3);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
		}

		// Token: 0x0602B5D7 RID: 177623 RVA: 0x00C2FCB0 File Offset: 0x00C2DEB0
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

		// Token: 0x0602B5D8 RID: 177624 RVA: 0x00C2FCE3 File Offset: 0x00C2DEE3
		public void SetName(string name)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(name, true);
		}

		// Token: 0x0602B5D9 RID: 177625 RVA: 0x00C2FCF8 File Offset: 0x00C2DEF8
		public void SetNum(string num)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(num, true);
		}

		// Token: 0x0602B5DA RID: 177626 RVA: 0x00C2FD0D File Offset: 0x00C2DF0D
		public void SetOnClickCall(Action cb)
		{
			this.OnClickCall = cb;
		}

		// Token: 0x0602B5DB RID: 177627 RVA: 0x00C2FD16 File Offset: 0x00C2DF16
		public void SetButtonDone(bool isDone)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isDone);
		}

		// Token: 0x0602B5DC RID: 177628 RVA: 0x00C2FD2A File Offset: 0x00C2DF2A
		private void OnClick()
		{
			this.OnClickCall();
		}

		// Token: 0x04017699 RID: 95897
		private Action OnClickCall = delegate()
		{
		};

		// Token: 0x0401769A RID: 95898
		private ERedDotName? RedDotName;
	}
}
