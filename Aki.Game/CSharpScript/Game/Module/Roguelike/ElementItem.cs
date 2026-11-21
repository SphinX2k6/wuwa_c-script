using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D9C RID: 15772
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ElementItem : GridProxyAbstract<ElementInfo>
	{
		// Token: 0x06028539 RID: 165177 RVA: 0x00B4BA33 File Offset: 0x00B49C33
		public override void Refresh(ElementInfo data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x0602853A RID: 165178 RVA: 0x00B4BA3C File Offset: 0x00B49C3C
		public void Update(ElementInfo elementInfo)
		{
			this.ElementInfo = elementInfo;
			this.RefreshPanel();
		}

		// Token: 0x0602853B RID: 165179 RVA: 0x00B4BA4C File Offset: 0x00B49C4C
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

		// Token: 0x0602853C RID: 165180 RVA: 0x00B4BAB8 File Offset: 0x00B49CB8
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

		// Token: 0x04015EA5 RID: 89765
		private ElementInfo ElementInfo;

		// Token: 0x04015EA6 RID: 89766
		private CommonElementItem CommonElementItem;

		// Token: 0x02009981 RID: 39297
		[NullableContext(0)]
		private class EElementItemCom
		{
			// Token: 0x0402FDDB RID: 196059
			public const int CommonElementItem = 0;

			// Token: 0x0402FDDC RID: 196060
			public const int CountText = 1;
		}
	}
}
