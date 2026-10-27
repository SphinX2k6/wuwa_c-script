using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common.Item
{
	// Token: 0x020056A0 RID: 22176
	[NullableContext(1)]
	[Nullable(0)]
	public class ManufactureMaterialDynamicItem : UiPanelBase, IDynamicScrollBaseItem<ISingleItemInfo>
	{
		// Token: 0x060386DC RID: 231132 RVA: 0x00D65C00 File Offset: 0x00D63E00
		public UniTask Init(UUIItem actor)
		{
			ManufactureMaterialDynamicItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ManufactureMaterialDynamicItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060386DD RID: 231133 RVA: 0x00D65C4C File Offset: 0x00D63E4C
		public FVector2D GetItemSize(ISingleItemInfo data)
		{
			if (this.ItemSizeVector == null)
			{
				this.ItemSizeVector = new Vector2D();
			}
			UUIItem rootItem = base.GetRootItem();
			this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.ItemSizeVector.ToUeVector2D(false);
		}

		// Token: 0x060386DE RID: 231134 RVA: 0x00D65C98 File Offset: 0x00D63E98
		public void ClearItem()
		{
		}

		// Token: 0x0401DA2F RID: 121391
		[Nullable(2)]
		private Vector2D ItemSizeVector;
	}
}
