using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x02005757 RID: 22359
	public class KurotatoLevelItem : SyncGridProxyAbstract<int>
	{
		// Token: 0x06038D1A RID: 232730 RVA: 0x00D7EC6C File Offset: 0x00D7CE6C
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

		// Token: 0x06038D1B RID: 232731 RVA: 0x00D7ED98 File Offset: 0x00D7CF98
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

		// Token: 0x06038D1C RID: 232732 RVA: 0x00D7EE73 File Offset: 0x00D7D073
		private void OnToggleClick(EToggleState state)
		{
			this.OnClickCb(this.Id);
		}

		// Token: 0x0401DCC1 RID: 122049
		public int Id;

		// Token: 0x0401DCC2 RID: 122050
		[Nullable(1)]
		public Action<int> OnClickCb = delegate(int _)
		{
		};

		// Token: 0x0401DCC3 RID: 122051
		[Nullable(1)]
		public Func<int, bool> IsSelected = (int _) => false;

		// Token: 0x0200B94F RID: 47439
		private enum EComponents
		{
			// Token: 0x040380B3 RID: 229555
			ToggleRoot,
			// Token: 0x040380B4 RID: 229556
			TextLevelNum,
			// Token: 0x040380B5 RID: 229557
			TextLevelName,
			// Token: 0x040380B6 RID: 229558
			ItemFinishPanel,
			// Token: 0x040380B7 RID: 229559
			ItemLockPanel,
			// Token: 0x040380B8 RID: 229560
			ItemRedDot
		}
	}
}
