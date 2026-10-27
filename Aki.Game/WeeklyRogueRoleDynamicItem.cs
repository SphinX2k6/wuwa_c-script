using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D3A RID: 11578
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueRoleDynamicItem : UiPanelBase, IDynamicScrollBaseItem<IWeeklyRogueRoleGroupInfo>
{
	// Token: 0x0601856E RID: 99694 RVA: 0x00632154 File Offset: 0x00630354
	public UniTask Init(UUIItem actor)
	{
		WeeklyRogueRoleDynamicItem.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<WeeklyRogueRoleDynamicItem.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0601856F RID: 99695 RVA: 0x006321A0 File Offset: 0x006303A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x06018570 RID: 99696 RVA: 0x00632254 File Offset: 0x00630454
	public FVector2D GetItemSize(IWeeklyRogueRoleGroupInfo data)
	{
		if (this.ItemSizeVector == null)
		{
			this.ItemSizeVector = Vector2D.Create();
		}
		if (data.IsTitleType)
		{
			UUIItem item = base.GetItem(2);
			this.ItemSizeVector.Set((double)item.GetWidth(), (double)item.GetHeight());
			return this.ItemSizeVector.ToUeVector2D(false);
		}
		TWeakObjectPtr<UUIItem> rootUIComp = base.GetGridLayout(0).RootUIComp;
		this.ItemSizeVector.Set((double)rootUIComp.Get().GetWidth(), (double)rootUIComp.Get().GetHeight());
		return this.ItemSizeVector.ToUeVector2D(false);
	}

	// Token: 0x06018571 RID: 99697 RVA: 0x006322E8 File Offset: 0x006304E8
	public void ClearItem()
	{
	}

	// Token: 0x0400B4B8 RID: 46264
	[Nullable(2)]
	private Vector2D ItemSizeVector;
}
