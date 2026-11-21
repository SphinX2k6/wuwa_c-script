using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02005BC1 RID: 23489
	public class SeekTraceGridStateView : UiPanelBase, IGridProxy<ESeekTraceGridStateViewType>
	{
		// Token: 0x17006E04 RID: 28164
		// (get) Token: 0x06039BC9 RID: 236489 RVA: 0x01038061 File Offset: 0x01036261
		// (set) Token: 0x06039BCA RID: 236490 RVA: 0x01038069 File Offset: 0x01036269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IScrollViewDelegate<IGridProxy<ESeekTraceGridStateViewType>, ESeekTraceGridStateViewType> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17006E05 RID: 28165
		// (get) Token: 0x06039BCB RID: 236491 RVA: 0x01038072 File Offset: 0x01036272
		// (set) Token: 0x06039BCC RID: 236492 RVA: 0x0103807A File Offset: 0x0103627A
		public int GridIndex { get; set; }

		// Token: 0x17006E06 RID: 28166
		// (get) Token: 0x06039BCD RID: 236493 RVA: 0x01038083 File Offset: 0x01036283
		// (set) Token: 0x06039BCE RID: 236494 RVA: 0x0103808B File Offset: 0x0103628B
		public int DisplayIndex { get; set; }

		// Token: 0x06039BCF RID: 236495 RVA: 0x01038094 File Offset: 0x01036294
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06039BD0 RID: 236496 RVA: 0x010380D0 File Offset: 0x010362D0
		public void Refresh(ESeekTraceGridStateViewType data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(0);
			UUIItem item2 = base.GetItem(1);
			switch (data)
			{
			case ESeekTraceGridStateViewType.None:
				item.SetUIActive(false);
				item2.SetUIActive(false);
				return;
			case ESeekTraceGridStateViewType.Light:
				item.SetUIActive(false);
				item2.SetUIActive(true);
				return;
			case ESeekTraceGridStateViewType.LightGreen:
			{
				item.SetUIActive(true);
				UUIItem uuiitem = item;
				bool bUseChangeColor = true;
				FColor? fcolor = new FColor?(item.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				item2.SetUIActive(true);
				return;
			}
			case ESeekTraceGridStateViewType.Red:
			{
				item.SetUIActive(true);
				UUIItem uuiitem2 = item;
				bool bUseChangeColor2 = false;
				FColor? fcolor = new FColor?(item.changeColor);
				uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
				item2.SetUIActive(false);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06039BD1 RID: 236497 RVA: 0x01038169 File Offset: 0x01036369
		public void Clear()
		{
		}

		// Token: 0x06039BD2 RID: 236498 RVA: 0x0103816B File Offset: 0x0103636B
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06039BD3 RID: 236499 RVA: 0x0103816D File Offset: 0x0103636D
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06039BD4 RID: 236500 RVA: 0x0103816F File Offset: 0x0103636F
		[NullableContext(2)]
		public object GetKey(ESeekTraceGridStateViewType data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x0200B763 RID: 46947
		public enum EComponentType
		{
			// Token: 0x04038AF6 RID: 232182
			StateSprite,
			// Token: 0x04038AF7 RID: 232183
			LightSprite
		}
	}
}
