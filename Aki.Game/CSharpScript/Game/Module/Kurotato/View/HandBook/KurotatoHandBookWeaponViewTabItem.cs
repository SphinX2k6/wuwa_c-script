using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.HandBook
{
	// Token: 0x0200473F RID: 18239
	public class KurotatoHandBookWeaponViewTabItem : GridProxyAbstract<EKurotatoCardType>
	{
		// Token: 0x0602DC97 RID: 187543 RVA: 0x00CCFF04 File Offset: 0x00CCE104
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

		// Token: 0x0602DC98 RID: 187544 RVA: 0x00CCFFCC File Offset: 0x00CCE1CC
		public override void Refresh(EKurotatoCardType tabType, bool isSelected, int gridIndex)
		{
			this.TabType = tabType;
			string textStringId = KurotatoDefine.KurotatoHandBookTabName[tabType];
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
			this.UnBindRedDot();
			this.BindRedDot();
		}

		// Token: 0x0602DC99 RID: 187545 RVA: 0x00CD000F File Offset: 0x00CCE20F
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0602DC9A RID: 187546 RVA: 0x00CD0018 File Offset: 0x00CCE218
		private void BindRedDot()
		{
			ERedDotName name = (this.TabType == EKurotatoCardType.Weapon) ? ERedDotName.RedDotKurotatoWeapon : ERedDotName.RedDotKurotatoProp;
			RedDotController.Instance.BindRedDot(name, base.GetItem(2), null, 0);
		}

		// Token: 0x0602DC9B RID: 187547 RVA: 0x00CD0050 File Offset: 0x00CCE250
		private void UnBindRedDot()
		{
			ERedDotName name = (this.TabType == EKurotatoCardType.Weapon) ? ERedDotName.RedDotKurotatoWeapon : ERedDotName.RedDotKurotatoProp;
			RedDotController.Instance.UnBindRedDot(name);
		}

		// Token: 0x0602DC9C RID: 187548 RVA: 0x00CD0080 File Offset: 0x00CCE280
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x0602DC9D RID: 187549 RVA: 0x00CD00A6 File Offset: 0x00CCE2A6
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x0602DC9E RID: 187550 RVA: 0x00CD00AF File Offset: 0x00CCE2AF
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x0602DC9F RID: 187551 RVA: 0x00CD00B8 File Offset: 0x00CCE2B8
		private void OnClickToggle(EToggleState state)
		{
			Action<EKurotatoCardType> onToggleCallBack = this.OnToggleCallBack;
			if (onToggleCallBack == null)
			{
				return;
			}
			onToggleCallBack(this.TabType);
		}

		// Token: 0x040187A4 RID: 100260
		private EKurotatoCardType TabType;

		// Token: 0x040187A5 RID: 100261
		[Nullable(2)]
		public Action<EKurotatoCardType> OnToggleCallBack;

		// Token: 0x0200A38B RID: 41867
		private enum EComponents
		{
			// Token: 0x04032B2B RID: 207659
			ToggleRoot,
			// Token: 0x04032B2C RID: 207660
			TextTabName,
			// Token: 0x04032B2D RID: 207661
			ItemRedDot
		}
	}
}
