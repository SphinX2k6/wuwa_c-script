using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003D3 RID: 979
[NullableContext(1)]
[Nullable(0)]
public class AchievementDataDynItem : UiPanelBase, IDynamicScrollBaseItem<AchievementData>
{
	// Token: 0x0600357F RID: 13695 RVA: 0x0013A5AC File Offset: 0x001387AC
	public UniTask Init(UUIItem actor)
	{
		AchievementDataDynItem.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementDataDynItem.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06003580 RID: 13696 RVA: 0x0013A5F8 File Offset: 0x001387F8
	public FVector2D GetItemSize(AchievementData data)
	{
		if (this.ItemSizeVector == null)
		{
			this.ItemSizeVector = Vector2D.Create();
		}
		UUIItem rootItem = base.GetRootItem();
		this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		return this.ItemSizeVector.ToUeVector2D(false);
	}

	// Token: 0x06003581 RID: 13697 RVA: 0x0013A644 File Offset: 0x00138844
	public void ClearItem()
	{
	}

	// Token: 0x04002D16 RID: 11542
	[Nullable(2)]
	private Vector2D ItemSizeVector;
}
