using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.HandBook
{
	// Token: 0x02005768 RID: 22376
	public class KurotatoHandBookWeaponViewTabItem : GridProxyAbstract<EKurotatoCardType>
	{
		// Token: 0x06038D87 RID: 232839 RVA: 0x00D81408 File Offset: 0x00D7F608
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038D88 RID: 232840 RVA: 0x00D814D0 File Offset: 0x00D7F6D0
		public override void Refresh(EKurotatoCardType tabType, bool isSelected, int gridIndex)
		{
			this.TabType = tabType;
			string textStringId = KurotatoDefine.KurotatoHandBookTabName[tabType];
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
			this.UnBindRedDot();
			this.BindRedDot();
		}

		// Token: 0x06038D89 RID: 232841 RVA: 0x00D81513 File Offset: 0x00D7F713
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06038D8A RID: 232842 RVA: 0x00D8151C File Offset: 0x00D7F71C
		private void BindRedDot()
		{
			ERedDotName name = (this.TabType == EKurotatoCardType.Weapon) ? ERedDotName.RedDotKurotatoWeapon : ERedDotName.RedDotKurotatoProp;
			RedDotController.Instance.BindRedDot(name, base.GetItem(2), null, 0);
		}

		// Token: 0x06038D8B RID: 232843 RVA: 0x00D81554 File Offset: 0x00D7F754
		private void UnBindRedDot()
		{
			ERedDotName name = (this.TabType == EKurotatoCardType.Weapon) ? ERedDotName.RedDotKurotatoWeapon : ERedDotName.RedDotKurotatoProp;
			RedDotController.Instance.UnBindRedDot(name);
		}

		// Token: 0x06038D8C RID: 232844 RVA: 0x00D81584 File Offset: 0x00D7F784
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x06038D8D RID: 232845 RVA: 0x00D815AA File Offset: 0x00D7F7AA
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06038D8E RID: 232846 RVA: 0x00D815B3 File Offset: 0x00D7F7B3
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x06038D8F RID: 232847 RVA: 0x00D815BC File Offset: 0x00D7F7BC
		private void OnClickToggle(EToggleState state)
		{
			Action<EKurotatoCardType> onToggleCallBack = this.OnToggleCallBack;
			if (onToggleCallBack == null)
			{
				return;
			}
			onToggleCallBack(this.TabType);
		}

		// Token: 0x0401DD0E RID: 122126
		private EKurotatoCardType TabType;

		// Token: 0x0401DD0F RID: 122127
		[Nullable(2)]
		public Action<EKurotatoCardType> OnToggleCallBack;

		// Token: 0x0200B971 RID: 47473
		private enum EComponents
		{
			// Token: 0x04038131 RID: 229681
			ToggleRoot,
			// Token: 0x04038132 RID: 229682
			TextTabName,
			// Token: 0x04038133 RID: 229683
			ItemRedDot
		}
	}
}
