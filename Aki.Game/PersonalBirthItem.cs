using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020018AA RID: 6314
[NullableContext(1)]
[Nullable(0)]
public class PersonalBirthItem : AutoAttachExhibitionItemAbstract
{
	// Token: 0x0600F99E RID: 63902 RVA: 0x0048F996 File Offset: 0x0048DB96
	public PersonalBirthItem(AActor uiActor) : base(uiActor)
	{
	}

	// Token: 0x0600F99F RID: 63903 RVA: 0x0048F9B9 File Offset: 0x0048DBB9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600F9A0 RID: 63904 RVA: 0x0048F9DC File Offset: 0x0048DBDC
	protected override void OnBeforeDestroy()
	{
		this.Num = null;
	}

	// Token: 0x0600F9A1 RID: 63905 RVA: 0x0048F9EA File Offset: 0x0048DBEA
	public void RefreshItem()
	{
		this.Num = new int?(this.Dates[base.GetShowItemIndex()]);
		base.GetText(0).SetText(this.Num.ToString(), true);
	}

	// Token: 0x0600F9A2 RID: 63906 RVA: 0x0048FA26 File Offset: 0x0048DC26
	public override void SetData(object dates)
	{
		this.Dates = (List<int>)dates;
	}

	// Token: 0x0600F9A3 RID: 63907 RVA: 0x0048FA34 File Offset: 0x0048DC34
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

	// Token: 0x0600F9A4 RID: 63908 RVA: 0x0048FADE File Offset: 0x0048DCDE
	public void BindOnSelected(Action<int> onSelected)
	{
		this.OnSelectedCallback = onSelected;
	}

	// Token: 0x0600F9A5 RID: 63909 RVA: 0x0048FAE7 File Offset: 0x0048DCE7
	public override void OnSelect()
	{
		if (this.OnSelectedCallback != null)
		{
			this.OnSelectedCallback(this.Num.Value);
		}
	}

	// Token: 0x04008B94 RID: 35732
	[Nullable(2)]
	public List<int> Dates;

	// Token: 0x04008B95 RID: 35733
	private FVector Scale = new FVector(0f, 0f, 0f);

	// Token: 0x04008B96 RID: 35734
	private int? Num;

	// Token: 0x04008B97 RID: 35735
	[Nullable(2)]
	private Action<int> OnSelectedCallback;
}
