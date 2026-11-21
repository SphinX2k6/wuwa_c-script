using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Personal;
using UnrealEngine;

// Token: 0x020018A8 RID: 6312
[NullableContext(2)]
[Nullable(0)]
public class PersonalBirthAttachItem : AutoAttachItem<int>
{
	// Token: 0x0600F995 RID: 63893 RVA: 0x0048F853 File Offset: 0x0048DA53
	public PersonalBirthAttachItem(AActor uiItem = null) : base(uiItem)
	{
	}

	// Token: 0x0600F996 RID: 63894 RVA: 0x0048F882 File Offset: 0x0048DA82
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600F997 RID: 63895 RVA: 0x0048F8A5 File Offset: 0x0048DAA5
	protected override void OnBeforeDestroy()
	{
		this.Num = null;
	}

	// Token: 0x0600F998 RID: 63896 RVA: 0x0048F8B3 File Offset: 0x0048DAB3
	protected override void OnRefreshItem(int data)
	{
		this.Num = new int?(data);
		base.GetText(0).SetText(PersonalConfig.Instance.GetBirthLocalText(data, this.DateType), true);
	}

	// Token: 0x0600F999 RID: 63897 RVA: 0x0048F8E0 File Offset: 0x0048DAE0
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

	// Token: 0x0600F99A RID: 63898 RVA: 0x0048F962 File Offset: 0x0048DB62
	[NullableContext(1)]
	public void BindOnSelected(Action<int> onSelected)
	{
		this.OnSelectedCallback = onSelected;
	}

	// Token: 0x0600F99B RID: 63899 RVA: 0x0048F96B File Offset: 0x0048DB6B
	public override void OnSelect()
	{
		if (this.OnSelectedCallback != null)
		{
			this.OnSelectedCallback(this.Num.Value);
		}
	}

	// Token: 0x0600F99C RID: 63900 RVA: 0x0048F98B File Offset: 0x0048DB8B
	protected override void OnUnSelect()
	{
	}

	// Token: 0x0600F99D RID: 63901 RVA: 0x0048F98D File Offset: 0x0048DB8D
	public void SetDateType(EBirthDateType dateType)
	{
		this.DateType = dateType;
	}

	// Token: 0x04008B8E RID: 35726
	private FVector Scale = new FVector(0f, 0f, 0f);

	// Token: 0x04008B8F RID: 35727
	private int? Num = new int?(0);

	// Token: 0x04008B90 RID: 35728
	private Action<int> OnSelectedCallback;

	// Token: 0x04008B91 RID: 35729
	private EBirthDateType DateType;
}
