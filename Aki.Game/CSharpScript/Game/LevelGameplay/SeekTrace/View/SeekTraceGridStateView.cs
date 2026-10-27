using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02006A64 RID: 27236
	public class SeekTraceGridStateView : UiPanelBase, IGridProxy<ESeekTraceGridStateViewType>
	{
		// Token: 0x1700991F RID: 39199
		// (get) Token: 0x06043B7B RID: 277371 RVA: 0x0109382D File Offset: 0x01091A2D
		// (set) Token: 0x06043B7C RID: 277372 RVA: 0x01093835 File Offset: 0x01091A35
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

		// Token: 0x17009920 RID: 39200
		// (get) Token: 0x06043B7D RID: 277373 RVA: 0x0109383E File Offset: 0x01091A3E
		// (set) Token: 0x06043B7E RID: 277374 RVA: 0x01093846 File Offset: 0x01091A46
		public int GridIndex { get; set; }

		// Token: 0x17009921 RID: 39201
		// (get) Token: 0x06043B7F RID: 277375 RVA: 0x0109384F File Offset: 0x01091A4F
		// (set) Token: 0x06043B80 RID: 277376 RVA: 0x01093857 File Offset: 0x01091A57
		public int DisplayIndex { get; set; }

		// Token: 0x06043B81 RID: 277377 RVA: 0x01093860 File Offset: 0x01091A60
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06043B82 RID: 277378 RVA: 0x0109389C File Offset: 0x01091A9C
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

		// Token: 0x06043B83 RID: 277379 RVA: 0x01093935 File Offset: 0x01091B35
		public void Clear()
		{
		}

		// Token: 0x06043B84 RID: 277380 RVA: 0x01093937 File Offset: 0x01091B37
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06043B85 RID: 277381 RVA: 0x01093939 File Offset: 0x01091B39
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06043B86 RID: 277382 RVA: 0x0109393B File Offset: 0x01091B3B
		[NullableContext(2)]
		public object GetKey(ESeekTraceGridStateViewType data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x0200CB84 RID: 52100
		public enum EComponentType
		{
			// Token: 0x0403D714 RID: 251668
			StateSprite,
			// Token: 0x0403D715 RID: 251669
			LightSprite
		}
	}
}
