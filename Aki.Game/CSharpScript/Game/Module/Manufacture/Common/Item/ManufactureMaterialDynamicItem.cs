using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common.Item
{
	// Token: 0x02004676 RID: 18038
	[NullableContext(1)]
	[Nullable(0)]
	public class ManufactureMaterialDynamicItem : UiPanelBase, IDynamicScrollBaseItem<ISingleItemInfo>
	{
		// Token: 0x0602D5D9 RID: 185817 RVA: 0x00CB3D50 File Offset: 0x00CB1F50
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

		// Token: 0x0602D5DA RID: 185818 RVA: 0x00CB3D9C File Offset: 0x00CB1F9C
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

		// Token: 0x0602D5DB RID: 185819 RVA: 0x00CB3DE8 File Offset: 0x00CB1FE8
		public void ClearItem()
		{
		}

		// Token: 0x040184BA RID: 99514
		[Nullable(2)]
		private Vector2D ItemSizeVector;
	}
}
