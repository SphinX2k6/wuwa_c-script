using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006311 RID: 25361
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballRoleHeadItem : GridProxyAbstract<IPinballRoleHeadItemData>
	{
		// Token: 0x0603FCE4 RID: 261348 RVA: 0x00F6FB2C File Offset: 0x00F6DD2C
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FCE5 RID: 261349 RVA: 0x00F6FC56 File Offset: 0x00F6DE56
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChangeInternal));
		}

		// Token: 0x0603FCE6 RID: 261350 RVA: 0x00F6FC78 File Offset: 0x00F6DE78
		public override void Refresh(IPinballRoleHeadItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshSelectState(true);
			this.RefreshHeadTexture();
			this.RefreshLockState();
			this.RefreshTrailState();
			if (this.Data.NeedRedDot)
			{
				this.UnBindRedDot();
				this.BindRedDot();
				return;
			}
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603FCE7 RID: 261351 RVA: 0x00F6FCD4 File Offset: 0x00F6DED4
		public void RefreshSelectState(bool bJumpToLastFrame)
		{
			IPinballRoleHeadItemData data = this.Data;
			EToggleState state = (data != null && data.IsSelected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, bJumpToLastFrame);
		}

		// Token: 0x0603FCE8 RID: 261352 RVA: 0x00F6FD0C File Offset: 0x00F6DF0C
		public void RefreshHeadTexture()
		{
			if (this.Data == null)
			{
				return;
			}
			string middleIcon = this.Data.RoleConfig.MiddleIcon;
			base.SetTextureByPath(middleIcon, base.GetTexture(1), null, null);
			base.SetTextureByPath(middleIcon, base.GetTexture(2), null, null);
		}

		// Token: 0x0603FCE9 RID: 261353 RVA: 0x00F6FD68 File Offset: 0x00F6DF68
		public void RefreshLockState()
		{
			if (this.Data == null)
			{
				return;
			}
			bool isLocked = this.Data.IsLocked;
			base.GetItem(3).SetUIActive(isLocked);
			UUITexture texture = base.GetTexture(1);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = isLocked;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			UUITexture texture2 = base.GetTexture(2);
			UUIItem uuiitem2 = texture2;
			bool bUseChangeColor2 = isLocked;
			fcolor = new FColor?(texture2.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		}

		// Token: 0x0603FCEA RID: 261354 RVA: 0x00F6FDD1 File Offset: 0x00F6DFD1
		public void RefreshTrailState()
		{
			if (this.Data == null)
			{
				return;
			}
			base.GetItem(5).SetUIActive(this.Data.IsTrail);
		}

		// Token: 0x0603FCEB RID: 261355 RVA: 0x00F6FDF4 File Offset: 0x00F6DFF4
		public void BindRedDot()
		{
			if (this.Data == null)
			{
				return;
			}
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotPinballRole, base.GetItem(4), null, this.Data.RoleConfig.Id);
		}

		// Token: 0x0603FCEC RID: 261356 RVA: 0x00F6FE34 File Offset: 0x00F6E034
		public void UnBindRedDot()
		{
			if (this.Data == null)
			{
				return;
			}
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPinballRole, base.GetItem(4), 0);
		}

		// Token: 0x0603FCED RID: 261357 RVA: 0x00F6FE56 File Offset: 0x00F6E056
		private bool CanExecuteChangeInternal()
		{
			return this.Data != null && (base.GetExtendToggle(0).GetToggleState() != EToggleState.ETT_Checked || !this.Data.IsSelected);
		}

		// Token: 0x0603FCEE RID: 261358 RVA: 0x00F6FE81 File Offset: 0x00F6E081
		private void OnToggleStateChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<IPinballRoleHeadItemData> onSelectCallBack = this.OnSelectCallBack;
				if (onSelectCallBack == null)
				{
					return;
				}
				onSelectCallBack(this.Data);
			}
		}

		// Token: 0x0603FCEF RID: 261359 RVA: 0x00F6FE9D File Offset: 0x00F6E09D
		protected override void OnDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0603FCF0 RID: 261360 RVA: 0x00F6FEA8 File Offset: 0x00F6E0A8
		public override object GetKey(IPinballRoleHeadItemData data, int displayIndex)
		{
			return data.RoleConfig.Id;
		}

		// Token: 0x040214C3 RID: 136387
		[Nullable(2)]
		private IPinballRoleHeadItemData Data;

		// Token: 0x040214C4 RID: 136388
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IPinballRoleHeadItemData> OnSelectCallBack;

		// Token: 0x0200C505 RID: 50437
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B75D RID: 243549
			ItemToggle,
			// Token: 0x0403B75E RID: 243550
			UnSelectedHeadTexture,
			// Token: 0x0403B75F RID: 243551
			SelectedHeadTexture,
			// Token: 0x0403B760 RID: 243552
			LockItem,
			// Token: 0x0403B761 RID: 243553
			RedDotItem,
			// Token: 0x0403B762 RID: 243554
			TrailItem
		}
	}
}
