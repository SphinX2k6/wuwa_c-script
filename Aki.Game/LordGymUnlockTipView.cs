using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200169E RID: 5790
public class LordGymUnlockTipView : UiViewBase
{
	// Token: 0x0600E167 RID: 57703 RVA: 0x004215B1 File Offset: 0x0041F7B1
	[NullableContext(1)]
	public LordGymUnlockTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E168 RID: 57704 RVA: 0x004215BA File Offset: 0x0041F7BA
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600E169 RID: 57705 RVA: 0x004215E0 File Offset: 0x0041F7E0
	protected override void OnBeforeShow()
	{
		int lordId = (int)this.OpenParam;
		this.RefreshLord(lordId);
	}

	// Token: 0x0600E16A RID: 57706 RVA: 0x00421600 File Offset: 0x0041F800
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

	// Token: 0x0600E16B RID: 57707 RVA: 0x004216C5 File Offset: 0x0041F8C5
	protected override void OnAfterPlayStartSequence()
	{
		base.CloseMe(null);
	}

	// Token: 0x0200788F RID: 30863
	private class EComponents
	{
		// Token: 0x040271C4 RID: 160196
		public const int UnLockText = 0;
	}
}
