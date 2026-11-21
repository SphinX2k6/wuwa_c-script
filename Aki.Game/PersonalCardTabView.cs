using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020018B3 RID: 6323
public class PersonalCardTabView : UiTabViewBase
{
	// Token: 0x0600F9E9 RID: 63977 RVA: 0x00490DDE File Offset: 0x0048EFDE
	protected override void OnStart()
	{
		if (this.PersonalCardComponent == null)
		{
			this.PersonalCardComponent = new PersonalCardComponent(this.RootItem, true, this.ExtraParams as PersonalInfoData);
		}
	}

	// Token: 0x0600F9EA RID: 63978 RVA: 0x00490E05 File Offset: 0x0048F005
	protected override void OnBeforeDestroy()
	{
		if (this.PersonalCardComponent != null)
		{
			this.PersonalCardComponent.Destroy(null);
			this.PersonalCardComponent = null;
		}
	}

	// Token: 0x04008BC7 RID: 35783
	[Nullable(2)]
	private PersonalCardComponent PersonalCardComponent;
}
