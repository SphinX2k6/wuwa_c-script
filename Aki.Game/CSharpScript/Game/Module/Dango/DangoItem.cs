using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02004ABB RID: 19131
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DangoItem : GridProxyAbstract<DangoAbyssDefine.DangoListRoleData>
	{
		// Token: 0x0602FDE3 RID: 196067 RVA: 0x00D5BF98 File Offset: 0x00D5A198
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
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

		// Token: 0x0602FDE4 RID: 196068 RVA: 0x00D5C0C2 File Offset: 0x00D5A2C2
		private void OnToggleClick(EToggleState toggleState)
		{
			this.CurrentData.OnClickCallBack(this.CurrentData);
		}

		// Token: 0x0602FDE5 RID: 196069 RVA: 0x00D5C0DC File Offset: 0x00D5A2DC
		[NullableContext(1)]
		public override void Refresh(DangoAbyssDefine.DangoListRoleData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			bool flag = this.ViewModel.GetDangoId() == this.CurrentData.Id;
			bool ifLock = data.Data.GetIfLock();
			EToggleState state = flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
			base.GetItem(5).SetUIActive(ifLock);
			base.GetItem(4).SetUIActive(!ifLock);
			base.GetItem(2).SetUIActive(ifLock);
			UUITexture texture = base.GetTexture(1);
			base.SetTextureByPath(data.Data.GetTexture(), texture, null, null);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = ifLock;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			this.BindRedDot();
		}

		// Token: 0x0602FDE6 RID: 196070 RVA: 0x00D5C198 File Offset: 0x00D5A398
		private void BindRedDot()
		{
			this.UnBindRedDot();
			if (!this.HasBindRedDot && this.CurrentData != null)
			{
				UUIItem item = base.GetItem(3);
				RedDotController.Instance.BindRedDot(ERedDotName.RedDotDangoRole, item, null, this.CurrentData.Id);
			}
		}

		// Token: 0x0602FDE7 RID: 196071 RVA: 0x00D5C1E0 File Offset: 0x00D5A3E0
		private void UnBindRedDot()
		{
			this.HasBindRedDot = false;
			if (this.HasBindRedDot && this.CurrentData != null)
			{
				UUIItem item = base.GetItem(3);
				RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotDangoRole, item, this.CurrentData.Id);
			}
		}

		// Token: 0x0602FDE8 RID: 196072 RVA: 0x00D5C227 File Offset: 0x00D5A427
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x04019698 RID: 104088
		private DangoAbyssDefine.DangoListRoleData CurrentData;

		// Token: 0x04019699 RID: 104089
		public PluginEquipViewModel ViewModel;

		// Token: 0x0401969A RID: 104090
		private bool HasBindRedDot;

		// Token: 0x0200A73F RID: 42815
		[NullableContext(0)]
		private class EDangoItemComponent
		{
			// Token: 0x04033AD5 RID: 211669
			public const int Toggle = 0;

			// Token: 0x04033AD6 RID: 211670
			public const int Texture = 1;

			// Token: 0x04033AD7 RID: 211671
			public const int LockItem = 2;

			// Token: 0x04033AD8 RID: 211672
			public const int ItemRedDot = 3;

			// Token: 0x04033AD9 RID: 211673
			public const int PanelUnlock = 4;

			// Token: 0x04033ADA RID: 211674
			public const int PanelLock = 5;
		}
	}
}
