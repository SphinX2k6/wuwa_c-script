using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F1E RID: 3870
[NullableContext(1)]
[Nullable(0)]
public class AchievementDataDynItem : UiPanelBase, IDynamicScrollBaseItem<AchievementData>
{
	// Token: 0x060061E7 RID: 25063 RVA: 0x00131C88 File Offset: 0x0012FE88
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

	// Token: 0x060061E8 RID: 25064 RVA: 0x00131CD4 File Offset: 0x0012FED4
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

	// Token: 0x060061E9 RID: 25065 RVA: 0x00131D20 File Offset: 0x0012FF20
	public void ClearItem()
	{
	}

	// Token: 0x04002C7D RID: 11389
	[Nullable(2)]
	private Vector2D ItemSizeVector;
}
