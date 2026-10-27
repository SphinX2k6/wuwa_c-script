using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;

// Token: 0x020025BE RID: 9662
public abstract class FightPhotoSetupBase : UiPanelBase
{
	// Token: 0x06013976 RID: 80246 RVA: 0x004E623F File Offset: 0x004E443F
	public void Initialize(int configId)
	{
		this.SetupConfig = PhotographConfig.Instance.GetFightPhotoSetupConfigById(configId);
		this.Refresh();
	}

	// Token: 0x06013977 RID: 80247
	public abstract void Refresh();

	// Token: 0x06013978 RID: 80248 RVA: 0x004E6258 File Offset: 0x004E4458
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

	// Token: 0x040093D7 RID: 37847
	protected FightPhotoSetup? SetupConfig;
}
