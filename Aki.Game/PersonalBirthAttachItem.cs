using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Personal;
using UnrealEngine;

// Token: 0x020023C3 RID: 9155
[NullableContext(2)]
[Nullable(0)]
public class PersonalBirthAttachItem : AutoAttachItem<int>
{
	// Token: 0x060124E3 RID: 74979 RVA: 0x00482354 File Offset: 0x00480554
	public PersonalBirthAttachItem(AActor uiItem = null) : base(uiItem)
	{
	}

	// Token: 0x060124E4 RID: 74980 RVA: 0x00482383 File Offset: 0x00480583
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060124E5 RID: 74981 RVA: 0x004823A6 File Offset: 0x004805A6
	protected override void OnBeforeDestroy()
	{
		this.Num = null;
	}

	// Token: 0x060124E6 RID: 74982 RVA: 0x004823B4 File Offset: 0x004805B4
	protected override void OnRefreshItem(int data)
	{
		this.Num = new int?(data);
		base.GetText(0).SetText(PersonalConfig.Instance.GetBirthLocalText(data, this.DateType), true);
	}

	// Token: 0x060124E7 RID: 74983 RVA: 0x004823E0 File Offset: 0x004805E0
	protected override void OnMoveItem()
	{
		float currentMovePercentage = base.GetCurrentMovePercentage();
		double num = MathUtils.Instance.Lerp(1.0, 0.5, (double)currentMovePercentage);
		this.Scale.X = 1f;
		this.Scale.Y = 1f;
		this.Scale.Z = 1f;
		this.RootItem.SetUIItemScale(this.Scale);
		base.GetText(0).SetAlpha((float)num);
	}

	// Token: 0x060124E8 RID: 74984 RVA: 0x00482462 File Offset: 0x00480662
	[NullableContext(1)]
	public void BindOnSelected(Action<int> onSelected)
	{
		this.OnSelectedCallback = onSelected;
	}

	// Token: 0x060124E9 RID: 74985 RVA: 0x0048246B File Offset: 0x0048066B
	public override void OnSelect()
	{
		if (this.OnSelectedCallback != null)
		{
			this.OnSelectedCallback(this.Num.Value);
		}
	}

	// Token: 0x060124EA RID: 74986 RVA: 0x0048248B File Offset: 0x0048068B
	protected override void OnUnSelect()
	{
	}

	// Token: 0x060124EB RID: 74987 RVA: 0x0048248D File Offset: 0x0048068D
	public void SetDateType(EBirthDateType dateType)
	{
		this.DateType = dateType;
	}

	// Token: 0x04008A47 RID: 35399
	private FVector Scale = new FVector(0f, 0f, 0f);

	// Token: 0x04008A48 RID: 35400
	private int? Num = new int?(0);

	// Token: 0x04008A49 RID: 35401
	private Action<int> OnSelectedCallback;

	// Token: 0x04008A4A RID: 35402
	private EBirthDateType DateType;
}
