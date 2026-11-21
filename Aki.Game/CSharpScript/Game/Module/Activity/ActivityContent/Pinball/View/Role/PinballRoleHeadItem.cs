using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x0200528F RID: 21135
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballRoleHeadItem : GridProxyAbstract<IPinballRoleHeadItemData>
	{
		// Token: 0x060349A5 RID: 215461 RVA: 0x00EB6A88 File Offset: 0x00EB4C88
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

		// Token: 0x060349A6 RID: 215462 RVA: 0x00EB6BB2 File Offset: 0x00EB4DB2
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChangeInternal));
		}

		// Token: 0x060349A7 RID: 215463 RVA: 0x00EB6BD4 File Offset: 0x00EB4DD4
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

		// Token: 0x060349A8 RID: 215464 RVA: 0x00EB6C30 File Offset: 0x00EB4E30
		public void RefreshSelectState(bool bJumpToLastFrame)
		{
			IPinballRoleHeadItemData data = this.Data;
			EToggleState state = (data != null && data.IsSelected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, bJumpToLastFrame);
		}

		// Token: 0x060349A9 RID: 215465 RVA: 0x00EB6C68 File Offset: 0x00EB4E68
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

		// Token: 0x060349AA RID: 215466 RVA: 0x00EB6CC4 File Offset: 0x00EB4EC4
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

		// Token: 0x060349AB RID: 215467 RVA: 0x00EB6D2D File Offset: 0x00EB4F2D
		public void RefreshTrailState()
		{
			if (this.Data == null)
			{
				return;
			}
			base.GetItem(5).SetUIActive(this.Data.IsTrail);
		}

		// Token: 0x060349AC RID: 215468 RVA: 0x00EB6D50 File Offset: 0x00EB4F50
		public void BindRedDot()
		{
			if (this.Data == null)
			{
				return;
			}
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotPinballRole, base.GetItem(4), null, this.Data.RoleConfig.Id);
		}

		// Token: 0x060349AD RID: 215469 RVA: 0x00EB6D90 File Offset: 0x00EB4F90
		public void UnBindRedDot()
		{
			if (this.Data == null)
			{
				return;
			}
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPinballRole, base.GetItem(4), 0);
		}

		// Token: 0x060349AE RID: 215470 RVA: 0x00EB6DB2 File Offset: 0x00EB4FB2
		private bool CanExecuteChangeInternal()
		{
			return this.Data != null && (base.GetExtendToggle(0).GetToggleState() != EToggleState.ETT_Checked || !this.Data.IsSelected);
		}

		// Token: 0x060349AF RID: 215471 RVA: 0x00EB6DDD File Offset: 0x00EB4FDD
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

		// Token: 0x060349B0 RID: 215472 RVA: 0x00EB6DF9 File Offset: 0x00EB4FF9
		protected override void OnDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x060349B1 RID: 215473 RVA: 0x00EB6E04 File Offset: 0x00EB5004
		public override object GetKey(IPinballRoleHeadItemData data, int displayIndex)
		{
			return data.RoleConfig.Id;
		}

		// Token: 0x0401BDF2 RID: 114162
		[Nullable(2)]
		private IPinballRoleHeadItemData Data;

		// Token: 0x0401BDF3 RID: 114163
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IPinballRoleHeadItemData> OnSelectCallBack;

		// Token: 0x0200AEEC RID: 44780
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040360BF RID: 221375
			ItemToggle,
			// Token: 0x040360C0 RID: 221376
			UnSelectedHeadTexture,
			// Token: 0x040360C1 RID: 221377
			SelectedHeadTexture,
			// Token: 0x040360C2 RID: 221378
			LockItem,
			// Token: 0x040360C3 RID: 221379
			RedDotItem,
			// Token: 0x040360C4 RID: 221380
			TrailItem
		}
	}
}
