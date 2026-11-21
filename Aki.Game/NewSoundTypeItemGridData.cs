using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000B66 RID: 2918
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class NewSoundTypeItemGridData : MultiTemplateGridDataBase<INewSoundTypeItemData, NewSoundTypeItem>
{
	// Token: 0x06007977 RID: 31095 RVA: 0x0025A82F File Offset: 0x00258A2F
	public NewSoundTypeItemGridData(INewSoundTypeItemData data, Action<int, UUIExtendToggle> toggleFunc, Func<int, bool> canToggleChange)
	{
		base.Data = data;
		this.ToggleFunc = toggleFunc;
		this.CanToggleChange = canToggleChange;
	}

	// Token: 0x06007978 RID: 31096 RVA: 0x0025A84C File Offset: 0x00258A4C
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x06007979 RID: 31097 RVA: 0x0025A84F File Offset: 0x00258A4F
	public override NewSoundTypeItem CreateProxy()
	{
		NewSoundTypeItem newSoundTypeItem = new NewSoundTypeItem();
		newSoundTypeItem.BindOnToggleFunc(this.ToggleFunc);
		newSoundTypeItem.BindCanToggleExecuteChange(this.CanToggleChange);
		return newSoundTypeItem;
	}

	// Token: 0x04004B81 RID: 19329
	private Action<int, UUIExtendToggle> ToggleFunc;

	// Token: 0x04004B82 RID: 19330
	private Func<int, bool> CanToggleChange;
}
