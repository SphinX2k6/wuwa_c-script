using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D1B RID: 15643
	public class RoleDevelopSelectTargetHintItem : UiPanelBase, IGridProxy<RoleDevelopSelectTargetHintItemData>
	{
		// Token: 0x060280C7 RID: 164039 RVA: 0x00B372F8 File Offset: 0x00B354F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060280C8 RID: 164040 RVA: 0x00B37364 File Offset: 0x00B35564
		[NullableContext(1)]
		public void Refresh(RoleDevelopSelectTargetHintItemData data, bool isSelected, int gridIndex)
		{
			UUITexture texture = base.GetTexture(0);
			UUIText text = base.GetText(1);
			base.SetTextureShowUntilLoaded(UiResourceConfig.Instance.GetResourcePath(data.IconKey), texture, null);
			LguiUtil.Instance.SetLocalTextNew(text, data.DescKey, Array.Empty<object>());
		}

		// Token: 0x17005212 RID: 21010
		// (get) Token: 0x060280C9 RID: 164041 RVA: 0x00B373AF File Offset: 0x00B355AF
		// (set) Token: 0x060280CA RID: 164042 RVA: 0x00B373B7 File Offset: 0x00B355B7
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<RoleDevelopSelectTargetHintItemData>, RoleDevelopSelectTargetHintItemData> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x17005213 RID: 21011
		// (get) Token: 0x060280CB RID: 164043 RVA: 0x00B373C0 File Offset: 0x00B355C0
		// (set) Token: 0x060280CC RID: 164044 RVA: 0x00B373C8 File Offset: 0x00B355C8
		public int GridIndex { get; set; }

		// Token: 0x17005214 RID: 21012
		// (get) Token: 0x060280CD RID: 164045 RVA: 0x00B373D1 File Offset: 0x00B355D1
		// (set) Token: 0x060280CE RID: 164046 RVA: 0x00B373D9 File Offset: 0x00B355D9
		public int DisplayIndex { get; set; }

		// Token: 0x060280CF RID: 164047 RVA: 0x00B373E2 File Offset: 0x00B355E2
		public void Clear()
		{
		}

		// Token: 0x060280D0 RID: 164048 RVA: 0x00B373E4 File Offset: 0x00B355E4
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060280D1 RID: 164049 RVA: 0x00B373E6 File Offset: 0x00B355E6
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x060280D2 RID: 164050 RVA: 0x00B373E8 File Offset: 0x00B355E8
		[NullableContext(1)]
		public object GetKey(RoleDevelopSelectTargetHintItemData data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x020098FB RID: 39163
		private enum EComponentType
		{
			// Token: 0x0402FB8F RID: 195471
			IconTexture,
			// Token: 0x0402FB90 RID: 195472
			DescText
		}
	}
}
