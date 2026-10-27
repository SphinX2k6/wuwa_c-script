using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D52 RID: 19794
	public class RoleDevelopSelectTargetHintItem : UiPanelBase, IGridProxy<RoleDevelopSelectTargetHintItemData>
	{
		// Token: 0x0603325D RID: 209501 RVA: 0x00BEDCF0 File Offset: 0x00BEBEF0
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

		// Token: 0x0603325E RID: 209502 RVA: 0x00BEDD5C File Offset: 0x00BEBF5C
		[NullableContext(1)]
		public void Refresh(RoleDevelopSelectTargetHintItemData data, bool isSelected, int gridIndex)
		{
			UUITexture texture = base.GetTexture(0);
			UUIText text = base.GetText(1);
			base.SetTextureShowUntilLoaded(UiResourceConfig.Instance.GetResourcePath(data.IconKey), texture, null);
			LguiUtil.Instance.SetLocalTextNew(text, data.DescKey, Array.Empty<object>());
		}

		// Token: 0x17007E62 RID: 32354
		// (get) Token: 0x0603325F RID: 209503 RVA: 0x00BEDDA7 File Offset: 0x00BEBFA7
		// (set) Token: 0x06033260 RID: 209504 RVA: 0x00BEDDAF File Offset: 0x00BEBFAF
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

		// Token: 0x17007E63 RID: 32355
		// (get) Token: 0x06033261 RID: 209505 RVA: 0x00BEDDB8 File Offset: 0x00BEBFB8
		// (set) Token: 0x06033262 RID: 209506 RVA: 0x00BEDDC0 File Offset: 0x00BEBFC0
		public int GridIndex { get; set; }

		// Token: 0x17007E64 RID: 32356
		// (get) Token: 0x06033263 RID: 209507 RVA: 0x00BEDDC9 File Offset: 0x00BEBFC9
		// (set) Token: 0x06033264 RID: 209508 RVA: 0x00BEDDD1 File Offset: 0x00BEBFD1
		public int DisplayIndex { get; set; }

		// Token: 0x06033265 RID: 209509 RVA: 0x00BEDDDA File Offset: 0x00BEBFDA
		public void Clear()
		{
		}

		// Token: 0x06033266 RID: 209510 RVA: 0x00BEDDDC File Offset: 0x00BEBFDC
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06033267 RID: 209511 RVA: 0x00BEDDDE File Offset: 0x00BEBFDE
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06033268 RID: 209512 RVA: 0x00BEDDE0 File Offset: 0x00BEBFE0
		[NullableContext(1)]
		public object GetKey(RoleDevelopSelectTargetHintItemData data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0200AEC7 RID: 44743
		public static class EComponentType
		{
			// Token: 0x04035161 RID: 217441
			public const int IconTexture = 0;

			// Token: 0x04035162 RID: 217442
			public const int DescText = 1;
		}
	}
}
