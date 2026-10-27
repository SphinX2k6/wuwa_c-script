using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020021BA RID: 8634
public class LordGymUnlockTipView : UiViewBase
{
	// Token: 0x06010CD6 RID: 68822 RVA: 0x00414CD1 File Offset: 0x00412ED1
	[NullableContext(1)]
	public LordGymUnlockTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010CD7 RID: 68823 RVA: 0x00414CDA File Offset: 0x00412EDA
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06010CD8 RID: 68824 RVA: 0x00414D00 File Offset: 0x00412F00
	protected override void OnBeforeShow()
	{
		int lordId = (int)this.OpenParam;
		this.RefreshLord(lordId);
	}

	// Token: 0x06010CD9 RID: 68825 RVA: 0x00414D20 File Offset: 0x00412F20
	private void RefreshLord(int lordId)
	{
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(lordId);
		if (lordGymConfig == null)
		{
			return;
		}
		LordGym value = lordGymConfig.Value;
		if (value.Version == 2)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Text_LordGymNewDifficultyUnlock_Text", Array.Empty<object>());
		}
		else if (value.Version == 3)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Text_LordGymNewDifficultyUnlock_Text", Array.Empty<object>());
		}
		else
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(value.GymTitle, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "LordGymUnLock", new <>z__ReadOnlySingleElementList<object>(localTextNew ?? ""));
		}
		if (!LordGymModel.Instance.GetLordGymHasRead(lordId))
		{
			LordGymController.Instance.ReadLordGym(lordId);
		}
	}

	// Token: 0x06010CDA RID: 68826 RVA: 0x00414DE5 File Offset: 0x00412FE5
	protected override void OnAfterPlayStartSequence()
	{
		base.CloseMe(null);
	}

	// Token: 0x02008704 RID: 34564
	private class EComponents
	{
		// Token: 0x0402BEA3 RID: 179875
		public const int UnLockText = 0;
	}
}
