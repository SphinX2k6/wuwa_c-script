using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005326 RID: 21286
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueButtonItemCollection : UiPanelBase
	{
		// Token: 0x060366D8 RID: 222936 RVA: 0x00CE21AC File Offset: 0x00CE03AC
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

		// Token: 0x060366D9 RID: 222937 RVA: 0x00CE226C File Offset: 0x00CE046C
		public void BindRedDot(ERedDotName redDotName, int? uid = null)
		{
			this.RedDotName = new ERedDotName?(redDotName);
			UUIItem item = base.GetItem(3);
			RedDotController.Instance.BindRedDot(redDotName, item, null, uid.GetValueOrDefault());
		}

		// Token: 0x060366DA RID: 222938 RVA: 0x00CE22A4 File Offset: 0x00CE04A4
		public void UnBindRedDot()
		{
			if (this.RedDotName == null)
			{
				return;
			}
			UUIItem item = base.GetItem(3);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
		}

		// Token: 0x060366DB RID: 222939 RVA: 0x00CE22E0 File Offset: 0x00CE04E0
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

		// Token: 0x060366DC RID: 222940 RVA: 0x00CE2313 File Offset: 0x00CE0513
		public void SetName(string name)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(name, true);
		}

		// Token: 0x060366DD RID: 222941 RVA: 0x00CE2328 File Offset: 0x00CE0528
		public void SetNum(string num)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(num, true);
		}

		// Token: 0x060366DE RID: 222942 RVA: 0x00CE233D File Offset: 0x00CE053D
		public void SetOnClickCall(Action cb)
		{
			this.OnClickCall = cb;
		}

		// Token: 0x060366DF RID: 222943 RVA: 0x00CE2346 File Offset: 0x00CE0546
		public void SetButtonDone(bool isDone)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isDone);
		}

		// Token: 0x060366E0 RID: 222944 RVA: 0x00CE235A File Offset: 0x00CE055A
		private void OnClick()
		{
			this.OnClickCall();
		}

		// Token: 0x0401CC63 RID: 117859
		private Action OnClickCall = delegate()
		{
		};

		// Token: 0x0401CC64 RID: 117860
		private ERedDotName? RedDotName;
	}
}
