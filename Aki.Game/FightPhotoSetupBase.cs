using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;

// Token: 0x02001AA9 RID: 6825
public abstract class FightPhotoSetupBase : UiPanelBase
{
	// Token: 0x06010E56 RID: 69206 RVA: 0x004F4E3F File Offset: 0x004F303F
	public void Initialize(int configId)
	{
		this.SetupConfig = PhotographConfig.Instance.GetFightPhotoSetupConfigById(configId);
		this.Refresh();
	}

	// Token: 0x06010E57 RID: 69207
	public abstract void Refresh();

	// Token: 0x06010E58 RID: 69208 RVA: 0x004F4E58 File Offset: 0x004F3058
	protected void OnSetupValueChange(int value)
	{
		PhotographController.SetFightPhotographSetupOption((EFightPhotoSetupOptionType)this.SetupConfig.Value.Id, value, false);
		if (this.SetupConfig.Value.IsLocalStorage)
		{
			Dictionary<int, int> dictionary = LocalStorage.GetGlobal<Dictionary<int, int>>(ELocalStorageGlobalKey.FightPhotographSetupOption, null) ?? new Dictionary<int, int>();
			dictionary[this.SetupConfig.Value.Id] = value;
			LocalStorage.SetGlobal<Dictionary<int, int>>(ELocalStorageGlobalKey.FightPhotographSetupOption, dictionary);
		}
	}

	// Token: 0x0400952D RID: 38189
	protected FightPhotoSetup? SetupConfig;
}
