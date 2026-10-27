using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DD3 RID: 19923
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ElementItem : GridProxyAbstract<ElementInfo>
	{
		// Token: 0x060336CC RID: 210636 RVA: 0x00C024DB File Offset: 0x00C006DB
		public override void Refresh(ElementInfo data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x060336CD RID: 210637 RVA: 0x00C024E4 File Offset: 0x00C006E4
		public void Update(ElementInfo elementInfo)
		{
			this.ElementInfo = elementInfo;
			this.RefreshPanel();
		}

		// Token: 0x060336CE RID: 210638 RVA: 0x00C024F4 File Offset: 0x00C006F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060336CF RID: 210639 RVA: 0x00C02560 File Offset: 0x00C00760
		private void RefreshPanel()
		{
			if (!string.IsNullOrEmpty(this.ElementInfo.Name))
			{
				base.GetText(1).ShowTextNew(this.ElementInfo.Name);
			}
			else
			{
				UUIText text = base.GetText(1);
				UUIItem uuiitem = text;
				bool isPreview = this.ElementInfo.IsPreview;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(isPreview, fcolor);
				text.SetText(this.ElementInfo.Count.ToString(), true);
			}
			if (this.CommonElementItem == null)
			{
				this.CommonElementItem = new CommonElementItem();
				this.CommonElementItem.Update(this.ElementInfo.ElementId);
				this.CommonElementItem.CreateThenShowByActorAsync(base.GetItem(0).GetOwner()).ContinueWith(delegate()
				{
					CommonElementItem commonElementItem = this.CommonElementItem;
					if (commonElementItem == null)
					{
						return;
					}
					commonElementItem.RefreshPanel();
				});
				return;
			}
			this.CommonElementItem.Update(this.ElementInfo.ElementId);
			this.CommonElementItem.RefreshPanel();
		}

		// Token: 0x0401B4D2 RID: 111826
		private ElementInfo ElementInfo;

		// Token: 0x0401B4D3 RID: 111827
		private CommonElementItem CommonElementItem;

		// Token: 0x0200AF4C RID: 44876
		[NullableContext(0)]
		private class EElementItemCom
		{
			// Token: 0x040353A6 RID: 218022
			public const int CommonElementItem = 0;

			// Token: 0x040353A7 RID: 218023
			public const int CountText = 1;
		}
	}
}
