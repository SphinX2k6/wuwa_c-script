using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x0200472E RID: 18222
	public class KurotatoLevelItem : SyncGridProxyAbstract<int>
	{
		// Token: 0x0602DC2A RID: 187434 RVA: 0x00CCD644 File Offset: 0x00CCB844
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DC2B RID: 187435 RVA: 0x00CCD770 File Offset: 0x00CCB970
		public override void Refresh(int data)
		{
			this.Id = data;
			KurotatoLevelData kurotatoLevelData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoLevelData(this.Id);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(kurotatoLevelData.Number, true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), kurotatoLevelData.Name, Array.Empty<object>());
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(kurotatoLevelData.IsFinished);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(!kurotatoLevelData.IsUnLock);
			}
			bool flag = this.IsSelected(this.Id);
			EToggleState state = flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
			if (flag)
			{
				kurotatoLevelData.ReadRedDot();
			}
			UUIItem item3 = base.GetItem(5);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(kurotatoLevelData.HasRedDot);
		}

		// Token: 0x0602DC2C RID: 187436 RVA: 0x00CCD84B File Offset: 0x00CCBA4B
		private void OnToggleClick(EToggleState state)
		{
			this.OnClickCb(this.Id);
		}

		// Token: 0x04018757 RID: 100183
		public int Id;

		// Token: 0x04018758 RID: 100184
		[Nullable(1)]
		public Action<int> OnClickCb = delegate(int _)
		{
		};

		// Token: 0x04018759 RID: 100185
		[Nullable(1)]
		public Func<int, bool> IsSelected = (int _) => false;

		// Token: 0x0200A36D RID: 41837
		private enum EComponents
		{
			// Token: 0x04032AB9 RID: 207545
			ToggleRoot,
			// Token: 0x04032ABA RID: 207546
			TextLevelNum,
			// Token: 0x04032ABB RID: 207547
			TextLevelName,
			// Token: 0x04032ABC RID: 207548
			ItemFinishPanel,
			// Token: 0x04032ABD RID: 207549
			ItemLockPanel,
			// Token: 0x04032ABE RID: 207550
			ItemRedDot
		}
	}
}
