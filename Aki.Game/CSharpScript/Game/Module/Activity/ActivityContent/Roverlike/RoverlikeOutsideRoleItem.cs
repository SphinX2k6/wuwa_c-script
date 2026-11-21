using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050A2 RID: 20642
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeOutsideRoleItem : GridProxyAbstract<RoverlikeOutsideRoleData>
	{
		// Token: 0x06033AC0 RID: 211648 RVA: 0x00E762B4 File Offset: 0x00E744B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033AC1 RID: 211649 RVA: 0x00E7639C File Offset: 0x00E7459C
		public override void Refresh(RoverlikeOutsideRoleData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			base.GridIndex = gridIndex;
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				if (!string.IsNullOrEmpty(data.IconPath))
				{
					base.SetTextureByPath(data.IconPath, texture, null, null);
				}
				UUIItem uuiitem = texture;
				bool bUseChangeColor = !data.Unlocked;
				FColor? fcolor = new FColor?(texture.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!data.Unlocked);
			}
			Func<RoverlikeOutsideRoleData, int, bool> getHasRedDot = this.GetHasRedDot;
			bool uiactive = (getHasRedDot != null) ? getHasRedDot(data, gridIndex) : data.HasRedDot;
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive);
			}
			Func<RoverlikeOutsideRoleData, int, bool> isGridSelected = this.IsGridSelected;
			bool flag = (isGridSelected != null) ? isGridSelected(data, gridIndex) : isSelected;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033AC2 RID: 211650 RVA: 0x00E7647D File Offset: 0x00E7467D
		public override void Clear()
		{
			this.CurrentData = null;
		}

		// Token: 0x06033AC3 RID: 211651 RVA: 0x00E76486 File Offset: 0x00E74686
		public override object GetKey(RoverlikeOutsideRoleData data, int displayIndex)
		{
			return data.RoleId;
		}

		// Token: 0x06033AC4 RID: 211652 RVA: 0x00E76494 File Offset: 0x00E74694
		private void OnToggleStateChanged(EToggleState state)
		{
			if (this.CurrentData == null)
			{
				return;
			}
			if (state != EToggleState.ETT_Checked)
			{
				Func<RoverlikeOutsideRoleData, int, bool> isGridSelected = this.IsGridSelected;
				if (isGridSelected != null && isGridSelected(this.CurrentData, base.GridIndex))
				{
					UUIExtendToggle extendToggle = base.GetExtendToggle(0);
					if (extendToggle == null)
					{
						return;
					}
					extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				}
				return;
			}
			Action<RoverlikeOutsideRoleData, int> onClickCb = this.OnClickCb;
			if (onClickCb == null)
			{
				return;
			}
			onClickCb(this.CurrentData, base.GridIndex);
		}

		// Token: 0x0401B66C RID: 112236
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoverlikeOutsideRoleData, int> OnClickCb;

		// Token: 0x0401B66D RID: 112237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeOutsideRoleData, int, bool> IsGridSelected;

		// Token: 0x0401B66E RID: 112238
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeOutsideRoleData, int, bool> GetHasRedDot;

		// Token: 0x0401B66F RID: 112239
		[Nullable(2)]
		private RoverlikeOutsideRoleData CurrentData;

		// Token: 0x0200AD67 RID: 44391
		[NullableContext(0)]
		private enum EOutsideRoleComponents
		{
			// Token: 0x04035953 RID: 219475
			TogRole,
			// Token: 0x04035954 RID: 219476
			TexIcon,
			// Token: 0x04035955 RID: 219477
			PnlLock,
			// Token: 0x04035956 RID: 219478
			PnlRedDot
		}
	}
}
