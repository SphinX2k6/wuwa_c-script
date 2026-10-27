using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AD3 RID: 19155
	public class TrapDefenseTalentTreeDetailPanel : UiPanelBase
	{
		// Token: 0x060319D7 RID: 203223 RVA: 0x00B822C0 File Offset: 0x00B804C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060319D8 RID: 203224 RVA: 0x00B823B0 File Offset: 0x00B805B0
		public void Refresh()
		{
			TrapDefenseTalentTreeNodeData selectedNode = TrapDefenseModel.Instance.ViewModelTalentTree.SelectedNode;
			if (selectedNode == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), selectedNode.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), TrapDefenseDefine.trapDefenseTalentTreeTypeNames[selectedNode.Type], Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), selectedNode.Desc, Array.Empty<object>());
			this.SetSpriteByPath(selectedNode.IconBig, base.GetSprite(2), false, null, null);
		}

		// Token: 0x0200AC4D RID: 44109
		private class EComponentDefine
		{
			// Token: 0x040345B6 RID: 214454
			public const int TextName = 0;

			// Token: 0x040345B7 RID: 214455
			public const int TextType = 1;

			// Token: 0x040345B8 RID: 214456
			public const int SpriteIcon = 2;

			// Token: 0x040345B9 RID: 214457
			public const int Layout = 3;

			// Token: 0x040345BA RID: 214458
			public const int ItemDesc = 4;

			// Token: 0x040345BB RID: 214459
			public const int TextDesc = 5;
		}
	}
}
