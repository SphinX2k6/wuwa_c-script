using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020016AE RID: 5806
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class NewSoundTypeItemGridData : MultiTemplateGridDataBase<INewSoundTypeItemData, NewSoundTypeItem>
{
	// Token: 0x0600A597 RID: 42391 RVA: 0x0025041B File Offset: 0x0024E61B
	public NewSoundTypeItemGridData(INewSoundTypeItemData data, Action<int, UUIExtendToggle> toggleFunc, Func<int, bool> canToggleChange)
	{
		base.Data = data;
		this.ToggleFunc = toggleFunc;
		this.CanToggleChange = canToggleChange;
	}

	// Token: 0x0600A598 RID: 42392 RVA: 0x00250438 File Offset: 0x0024E638
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x0600A599 RID: 42393 RVA: 0x0025043B File Offset: 0x0024E63B
	public override NewSoundTypeItem CreateProxy()
	{
		NewSoundTypeItem newSoundTypeItem = new NewSoundTypeItem();
		newSoundTypeItem.BindOnToggleFunc(this.ToggleFunc);
		newSoundTypeItem.BindCanToggleExecuteChange(this.CanToggleChange);
		return newSoundTypeItem;
	}

	// Token: 0x04004ADA RID: 19162
	private Action<int, UUIExtendToggle> ToggleFunc;

	// Token: 0x04004ADB RID: 19163
	private Func<int, bool> CanToggleChange;
}
