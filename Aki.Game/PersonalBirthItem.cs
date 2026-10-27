using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023C5 RID: 9157
[NullableContext(1)]
[Nullable(0)]
public class PersonalBirthItem : AutoAttachExhibitionItemAbstract
{
	// Token: 0x060124EC RID: 74988 RVA: 0x00482496 File Offset: 0x00480696
	public PersonalBirthItem(AActor uiActor) : base(uiActor)
	{
	}

	// Token: 0x060124ED RID: 74989 RVA: 0x004824B9 File Offset: 0x004806B9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060124EE RID: 74990 RVA: 0x004824DC File Offset: 0x004806DC
	protected override void OnBeforeDestroy()
	{
		this.Num = null;
	}

	// Token: 0x060124EF RID: 74991 RVA: 0x004824EA File Offset: 0x004806EA
	public void RefreshItem()
	{
		this.Num = new int?(this.Dates[base.GetShowItemIndex()]);
		base.GetText(0).SetText(this.Num.ToString(), true);
	}

	// Token: 0x060124F0 RID: 74992 RVA: 0x00482526 File Offset: 0x00480726
	public override void SetData(object dates)
	{
		this.Dates = (List<int>)dates;
	}

	// Token: 0x060124F1 RID: 74993 RVA: 0x00482534 File Offset: 0x00480734
	public override void OnMoveItem(float vector)
	{
		float height = base.GetAttachItem().ExhibitionView.ItemActor.GetHeight();
		float num = Math.Abs(base.GetRootItem().GetAnchorOffsetY()) / (height / 2f);
		double num2 = MathUtils.Instance.Lerp(1.0, 0.5, (double)num);
		this.Scale.X = 1f;
		this.Scale.Y = 1f;
		this.Scale.Z = 1f;
		this.RootItem.SetUIItemScale(this.Scale);
		base.GetText(0).SetAlpha((float)num2);
	}

	// Token: 0x060124F2 RID: 74994 RVA: 0x004825DE File Offset: 0x004807DE
	public void BindOnSelected(Action<int> onSelected)
	{
		this.OnSelectedCallback = onSelected;
	}

	// Token: 0x060124F3 RID: 74995 RVA: 0x004825E7 File Offset: 0x004807E7
	public override void OnSelect()
	{
		if (this.OnSelectedCallback != null)
		{
			this.OnSelectedCallback(this.Num.Value);
		}
	}

	// Token: 0x04008A4D RID: 35405
	[Nullable(2)]
	public List<int> Dates;

	// Token: 0x04008A4E RID: 35406
	private FVector Scale = new FVector(0f, 0f, 0f);

	// Token: 0x04008A4F RID: 35407
	private int? Num;

	// Token: 0x04008A50 RID: 35408
	[Nullable(2)]
	private Action<int> OnSelectedCallback;
}
