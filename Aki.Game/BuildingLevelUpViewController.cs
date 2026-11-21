using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020007A8 RID: 1960
[NullableContext(1)]
[Nullable(0)]
public class BuildingLevelUpViewController
{
	// Token: 0x060059D2 RID: 22994 RVA: 0x001D2DED File Offset: 0x001D0FED
	public void RegisterView(BuildingLevelUpView view)
	{
		this.View = view;
		this.Model = (BuildingLevelUpViewModel)view.OpenParam;
	}

	// Token: 0x060059D3 RID: 22995 RVA: 0x001D2E08 File Offset: 0x001D1008
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

	// Token: 0x060059D4 RID: 22996 RVA: 0x001D2E9C File Offset: 0x001D109C
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

	// Token: 0x060059D5 RID: 22997 RVA: 0x001D2F04 File Offset: 0x001D1104
	public void UnlockRelease()
	{
		UiBehaviorLevelSequence uiViewSequence = this.View.UiViewSequence;
		if (uiViewSequence.HasSequenceNameInPlaying("Press"))
		{
			uiViewSequence.ChangePlaybackDirection("Press");
		}
		this.IsUnlockPress = false;
	}

	// Token: 0x060059D6 RID: 22998 RVA: 0x001D2F3C File Offset: 0x001D113C
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

	// Token: 0x060059D7 RID: 22999 RVA: 0x001D2FBC File Offset: 0x001D11BC
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

	// Token: 0x04003CB4 RID: 15540
	private const int ADD_STEP = 800;

	// Token: 0x04003CB5 RID: 15541
	private const int REDUCE_STEP = 800;

	// Token: 0x04003CB6 RID: 15542
	private BuildingLevelUpView View;

	// Token: 0x04003CB7 RID: 15543
	private BuildingLevelUpViewModel Model;

	// Token: 0x04003CB8 RID: 15544
	private bool IsUnlockPress;

	// Token: 0x04003CB9 RID: 15545
	private float FillAmount;
}
