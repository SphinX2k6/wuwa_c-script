using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020023CE RID: 9166
public class PersonalCardTabView : UiTabViewBase
{
	// Token: 0x06012537 RID: 75063 RVA: 0x004838DE File Offset: 0x00481ADE
	protected override void OnStart()
	{
		if (this.PersonalCardComponent == null)
		{
			this.PersonalCardComponent = new PersonalCardComponent(this.RootItem, true, this.ExtraParams as PersonalInfoData);
		}
	}

	// Token: 0x06012538 RID: 75064 RVA: 0x00483905 File Offset: 0x00481B05
	protected override void OnBeforeDestroy()
	{
		if (this.PersonalCardComponent != null)
		{
			this.PersonalCardComponent.Destroy(null);
			this.PersonalCardComponent = null;
		}
	}

	// Token: 0x04008A80 RID: 35456
	[Nullable(2)]
	private PersonalCardComponent PersonalCardComponent;
}
