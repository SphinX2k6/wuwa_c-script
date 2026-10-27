using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020012F4 RID: 4852
[NullableContext(1)]
[Nullable(0)]
public class BuildingLevelUpViewController
{
	// Token: 0x06008637 RID: 34359 RVA: 0x001C9F81 File Offset: 0x001C8181
	public void RegisterView(BuildingLevelUpView view)
	{
		this.View = view;
		this.Model = (BuildingLevelUpViewModel)view.OpenParam;
	}

	// Token: 0x06008638 RID: 34360 RVA: 0x001C9F9C File Offset: 0x001C819C
	public void Start()
	{
		if (!this.Model.IsLevelUp)
		{
			this.View.InitUnlock(this.Model.BuildingId);
			this.View.UiViewSequence.StartSequenceName = "Build";
			return;
		}
		this.View.InitLevelUp(this.Model.BuildingId);
		this.View.ShowLevelUp();
		this.View.FinishLevelUp(this.Model.BuildingId);
		this.View.UiViewSequence.StartSequenceName = "LevelUp";
	}

	// Token: 0x06008639 RID: 34361 RVA: 0x001CA030 File Offset: 0x001C8230
	public void UnlockPress()
	{
		UiBehaviorLevelSequence uiViewSequence = this.View.UiViewSequence;
		if (uiViewSequence.HasSequenceNameInPlaying("Press"))
		{
			uiViewSequence.ChangePlaybackDirection("Press");
		}
		else
		{
			this.View.UiViewSequence.PlaySequence("Press", false, null);
			this.View.PlayBuildingLoopSequence(true);
		}
		this.IsUnlockPress = true;
	}

	// Token: 0x0600863A RID: 34362 RVA: 0x001CA098 File Offset: 0x001C8298
	public void UnlockRelease()
	{
		UiBehaviorLevelSequence uiViewSequence = this.View.UiViewSequence;
		if (uiViewSequence.HasSequenceNameInPlaying("Press"))
		{
			uiViewSequence.ChangePlaybackDirection("Press");
		}
		this.IsUnlockPress = false;
	}

	// Token: 0x0600863B RID: 34363 RVA: 0x001CA0D0 File Offset: 0x001C82D0
	public void CloseSelf()
	{
		if (!this.Model.IsLevelUp)
		{
			MoonChasingController.Instance.BuildingBuildFlowRequest(this.Model.BuildingId, delegate(bool success)
			{
				if (success)
				{
					this.View.UiViewSequence.CloseSequenceName = "Close02";
					UiManager.Instance.ResetToBattleView(null);
					return;
				}
				this.View.CloseMe(null);
			});
			return;
		}
		MoonChasingPopularityUpData popularityUpData = MoonChasingBuildingModel.Instance.GetPopularityUpData();
		if (popularityUpData == null)
		{
			this.View.CloseMe(null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BusinessTipsPopularityUpView, popularityUpData, delegate(bool _, int _)
		{
			this.View.CloseMe(null);
		});
		MoonChasingBuildingModel.Instance.SetPopularityUpData(null);
	}

	// Token: 0x0600863C RID: 34364 RVA: 0x001CA150 File Offset: 0x001C8350
	public void Tick(float delta)
	{
		if (this.Model.IsLevelUp)
		{
			return;
		}
		if (this.FillAmount >= 1f)
		{
			return;
		}
		if (this.IsUnlockPress)
		{
			this.FillAmount = MathUtils.Instance.Clamp(this.FillAmount + delta / 800f, 0f, 1f);
		}
		else
		{
			this.FillAmount = MathUtils.Instance.Clamp(this.FillAmount - delta / 800f, 0f, 1f);
		}
		this.View.SetFillAmount(this.FillAmount);
		if (this.FillAmount >= 1f)
		{
			this.View.ShowUnlock();
			this.View.FinishUnlock(this.Model.BuildingId);
			this.View.UiViewSequence.StopPrevSequence(false, true);
			this.View.UiViewSequence.PlaySequence("Select", false, null);
			this.View.PlayBuildingLoopSequence(false);
		}
		if (this.FillAmount <= 0f)
		{
			this.View.PlayBuildingLoopSequence(false);
		}
	}

	// Token: 0x04003C1C RID: 15388
	private const int ADD_STEP = 800;

	// Token: 0x04003C1D RID: 15389
	private const int REDUCE_STEP = 800;

	// Token: 0x04003C1E RID: 15390
	private BuildingLevelUpView View;

	// Token: 0x04003C1F RID: 15391
	private BuildingLevelUpViewModel Model;

	// Token: 0x04003C20 RID: 15392
	private bool IsUnlockPress;

	// Token: 0x04003C21 RID: 15393
	private float FillAmount;
}
