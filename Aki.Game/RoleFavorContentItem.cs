using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200284E RID: 10318
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleFavorContentItem : GridProxyAbstract<RoleFavorContentDataBase>
{
	// Token: 0x0601545F RID: 87135 RVA: 0x0055F7B0 File Offset: 0x0055D9B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnToggleClick)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnButtonClick))
		};
	}

	// Token: 0x06015460 RID: 87136 RVA: 0x0055F8A0 File Offset: 0x0055DAA0
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(4);
		this.Button = base.GetButton(6);
		UUIButtonComponent button = this.Button;
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06015461 RID: 87137 RVA: 0x0055F8E5 File Offset: 0x0055DAE5
	[NullableContext(1)]
	public override void Refresh(RoleFavorContentDataBase data, bool isSelected, int gridIndex)
	{
		this.ContentData = data;
		base.GridIndex = gridIndex;
		base.DisplayIndex = gridIndex;
		this.RefreshContentItem();
	}

	// Token: 0x06015462 RID: 87138 RVA: 0x0055F904 File Offset: 0x0055DB04
	public void RefreshContentItem()
	{
		switch (this.ContentData.FavorContentType)
		{
		case EFavorContentType.Voice:
			this.InitVoiceInfo();
			if (this.Toggle != null)
			{
				this.Toggle.bToggleOnSelect = false;
				return;
			}
			break;
		case EFavorContentType.ExperienceFile:
		case EFavorContentType.ExperienceStory:
			this.InitExperienceInfo();
			return;
		case EFavorContentType.Action:
			this.InitActionInfo();
			if (this.Toggle != null)
			{
				this.Toggle.bToggleOnSelect = false;
				return;
			}
			break;
		case EFavorContentType.PreciousItem:
			this.InitPreciousItem();
			break;
		default:
			return;
		}
	}

	// Token: 0x06015463 RID: 87139 RVA: 0x0055F97B File Offset: 0x0055DB7B
	[NullableContext(1)]
	public void BindToggleFunction(TRoleFavorContentItemToggleFunction toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06015464 RID: 87140 RVA: 0x0055F984 File Offset: 0x0055DB84
	[NullableContext(1)]
	public void BindButtonFunction(TRoleFavorContentItemButtonFunction buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x06015465 RID: 87141 RVA: 0x0055F990 File Offset: 0x0055DB90
	private void OnToggleClick(EToggleState state)
	{
		if (this.ToggleFunction != null)
		{
			bool flag = state == EToggleState.ETT_Checked;
			UUIButtonComponent button = this.Button;
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag);
			}
			this.ToggleFunction(flag, this.ContentData, this);
		}
	}

	// Token: 0x06015466 RID: 87142 RVA: 0x0055F9DC File Offset: 0x0055DBDC
	private void OnButtonClick()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction(this.ContentData, this);
		}
	}

	// Token: 0x06015467 RID: 87143 RVA: 0x0055F9F8 File Offset: 0x0055DBF8
	private void InitRoleBaseInfo()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(3), "FavorBaseInfo", Array.Empty<object>());
		this.SetLockItemActive(false);
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.FavorItemStatus = new EFavorItemStatus?(EFavorItemStatus.ItemUnLocked);
	}

	// Token: 0x06015468 RID: 87144 RVA: 0x0055FA48 File Offset: 0x0055DC48
	private void InitRolePowerFile()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(3), "FavorPowerFile", Array.Empty<object>());
		this.SetLockItemActive(false);
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.FavorItemStatus = new EFavorItemStatus?(EFavorItemStatus.ItemUnLocked);
	}

	// Token: 0x06015469 RID: 87145 RVA: 0x0055FA98 File Offset: 0x0055DC98
	private void InitExperienceInfo()
	{
		RoleFavorRoleInfoContentData roleFavorRoleInfoContentData = this.ContentData as RoleFavorRoleInfoContentData;
		if (roleFavorRoleInfoContentData == null)
		{
			this.InitRoleExperience();
			return;
		}
		EFavorExperienceSubType favorExperienceSubType = roleFavorRoleInfoContentData.FavorExperienceSubType;
		if (favorExperienceSubType == EFavorExperienceSubType.RoleBaseInfo)
		{
			this.InitRoleBaseInfo();
			return;
		}
		if (favorExperienceSubType == EFavorExperienceSubType.RolePowerFile)
		{
			this.InitRolePowerFile();
			return;
		}
		this.InitRoleExperience();
	}

	// Token: 0x0601546A RID: 87146 RVA: 0x0055FAE0 File Offset: 0x0055DCE0
	private void InitRoleExperience()
	{
		RoleFavorStoryContentData roleFavorStoryContentData = this.ContentData as RoleFavorStoryContentData;
		if (roleFavorStoryContentData == null)
		{
			return;
		}
		this.InitLockState();
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(roleFavorStoryContentData.Title, true);
		}
		this.RefreshRedDot();
	}

	// Token: 0x0601546B RID: 87147 RVA: 0x0055FB24 File Offset: 0x0055DD24
	private void InitActionInfo()
	{
		RoleFavorActionContentData roleFavorActionContentData = this.ContentData as RoleFavorActionContentData;
		if (roleFavorActionContentData == null)
		{
			return;
		}
		this.InitLockState();
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(roleFavorActionContentData.Title, true);
		}
		if (this.FavorItemStatus.GetValueOrDefault() == EFavorItemStatus.ItemUnLocked)
		{
			this.SetPlayerState(EFavorPlayerStatus.Stop);
		}
		this.InitMontageCompletedFunction();
		this.RefreshRedDot();
	}

	// Token: 0x0601546C RID: 87148 RVA: 0x0055FB84 File Offset: 0x0055DD84
	private void InitVoiceInfo()
	{
		RoleFavorVoiceContentData roleFavorVoiceContentData = this.ContentData as RoleFavorVoiceContentData;
		if (roleFavorVoiceContentData == null)
		{
			return;
		}
		this.InitLockState();
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(roleFavorVoiceContentData.Title, true);
		}
		EFavorItemStatus? favorItemStatus = this.FavorItemStatus;
		EFavorItemStatus efavorItemStatus = EFavorItemStatus.ItemLocked;
		if (!(favorItemStatus.GetValueOrDefault() == efavorItemStatus & favorItemStatus != null))
		{
			this.SetPlayerState(EFavorPlayerStatus.Stop);
		}
		this.InitAudioCompletedFunction();
		this.RefreshRedDot();
	}

	// Token: 0x0601546D RID: 87149 RVA: 0x0055FBF0 File Offset: 0x0055DDF0
	private void InitPreciousItem()
	{
		RoleFavorPreciousItemContentData roleFavorPreciousItemContentData = this.ContentData as RoleFavorPreciousItemContentData;
		if (roleFavorPreciousItemContentData == null)
		{
			return;
		}
		this.InitLockState();
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(roleFavorPreciousItemContentData.Title, true);
		}
		if (this.FavorItemStatus.GetValueOrDefault() != EFavorItemStatus.ItemUnLocked)
		{
			LguiUtil.Instance.SetLocalText(text, "Unknown", Array.Empty<object>());
		}
		this.RefreshRedDot();
	}

	// Token: 0x0601546E RID: 87150 RVA: 0x0055FC54 File Offset: 0x0055DE54
	private void InitMontageCompletedFunction()
	{
		if (this.OnMontageCompleted == null)
		{
			this.OnMontageCompleted = delegate(UAnimMontage montage, bool bInterrupted)
			{
				if (bInterrupted)
				{
					return;
				}
				this.EndPlay();
			};
		}
	}

	// Token: 0x0601546F RID: 87151 RVA: 0x0055FC70 File Offset: 0x0055DE70
	private void InitAudioCompletedFunction()
	{
		if (this.CloseAudioDelegate == null)
		{
			this.CloseAudioDelegate = DelegateUtils.ToManualReleaseDelegate<FOnAkPostEventCallback>(new Action<EAkCallbackType, UAkCallbackInfo>(this.EndPlayDelegate));
		}
	}

	// Token: 0x06015470 RID: 87152 RVA: 0x0055FC94 File Offset: 0x0055DE94
	protected override void OnBeforeDestroy()
	{
		this.ContentData = null;
		this.Toggle = null;
		this.Button = null;
		this.ToggleFunction = null;
		this.ButtonFunction = null;
		this.CurPlayerStatus = EFavorPlayerStatus.Stop;
		this.FavorItemStatus = new EFavorItemStatus?(EFavorItemStatus.ItemLocked);
		if (this.CloseAudioDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<EAkCallbackType, UAkCallbackInfo>(this.EndPlayDelegate));
			this.CloseAudioDelegate = null;
		}
		if (this.OnMontageCompleted != null)
		{
			this.OnMontageCompleted = null;
		}
	}

	// Token: 0x06015471 RID: 87153 RVA: 0x0055FD08 File Offset: 0x0055DF08
	private void InitLockState()
	{
		EFavorContentType favorContentType = this.ContentData.FavorContentType;
		int configId = this.ContentData.ConfigId;
		if (favorContentType == EFavorContentType.Action)
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.ContentData.RoleId);
			if (roleInstanceById == null)
			{
				return;
			}
			MotionModel.EMotionState roleMotionState = MotionModel.Instance.GetRoleMotionState(roleInstanceById.GetRoleId(), configId);
			this.FavorItemStatus = new EFavorItemStatus?((EFavorItemStatus)roleMotionState);
			this.SetLockItemActive(this.FavorItemStatus.GetValueOrDefault() != EFavorItemStatus.ItemUnLocked);
			return;
		}
		else
		{
			RoleInstance roleInstanceById2 = RoleModel.Instance.GetRoleInstanceById(this.ContentData.RoleId);
			if (roleInstanceById2 == null)
			{
				return;
			}
			EFavorItemStatus favorItemState = roleInstanceById2.GetFavorData().GetFavorItemState(configId, favorContentType);
			this.SetLockItemActive(favorItemState == EFavorItemStatus.ItemLocked);
			this.FavorItemStatus = new EFavorItemStatus?(favorItemState);
			return;
		}
	}

	// Token: 0x06015472 RID: 87154 RVA: 0x0055FDC5 File Offset: 0x0055DFC5
	public void SetLockItemActive(bool active)
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(active);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(2);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(false);
	}

	// Token: 0x06015473 RID: 87155 RVA: 0x0055FE00 File Offset: 0x0055E000
	private void SetPlayerState(EFavorPlayerStatus playerStatus)
	{
		if (this.ContentData == null)
		{
			return;
		}
		EFavorContentType favorContentType = this.ContentData.FavorContentType;
		if (favorContentType != EFavorContentType.Action && favorContentType != EFavorContentType.Voice)
		{
			return;
		}
		EFavorItemStatus? favorItemStatus = this.FavorItemStatus;
		EFavorItemStatus efavorItemStatus = EFavorItemStatus.ItemLocked;
		if (favorItemStatus.GetValueOrDefault() == efavorItemStatus & favorItemStatus != null)
		{
			return;
		}
		this.CurPlayerStatus = playerStatus;
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(playerStatus == EFavorPlayerStatus.Play);
		}
		UUIItem item3 = base.GetItem(2);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(playerStatus == EFavorPlayerStatus.Stop);
	}

	// Token: 0x06015474 RID: 87156 RVA: 0x0055FE8D File Offset: 0x0055E08D
	public EFavorPlayerStatus GetCurVoiceState()
	{
		return this.CurPlayerStatus;
	}

	// Token: 0x06015475 RID: 87157 RVA: 0x0055FE95 File Offset: 0x0055E095
	public void EndPlayDelegate(EAkCallbackType type, UAkCallbackInfo info)
	{
		if (type == EAkCallbackType.EndOfEvent)
		{
			this.EndPlay();
		}
	}

	// Token: 0x06015476 RID: 87158 RVA: 0x0055FEA0 File Offset: 0x0055E0A0
	public void EndPlay()
	{
		this.SetPlayerState(EFavorPlayerStatus.Stop);
	}

	// Token: 0x06015477 RID: 87159 RVA: 0x0055FEA9 File Offset: 0x0055E0A9
	public void StartPlay()
	{
		this.SetPlayerState(EFavorPlayerStatus.Play);
	}

	// Token: 0x06015478 RID: 87160 RVA: 0x0055FEB2 File Offset: 0x0055E0B2
	public void SetToggleState(EToggleState state)
	{
		if (this.Toggle != null)
		{
			this.Toggle.SetToggleState(state, false, false, false);
		}
	}

	// Token: 0x06015479 RID: 87161 RVA: 0x0055FECC File Offset: 0x0055E0CC
	public void SetButtonActive(bool active)
	{
		if (this.Button != null)
		{
			this.Button.RootUIComp.Get().SetUIActive(active);
		}
	}

	// Token: 0x0601547A RID: 87162 RVA: 0x0055FEFC File Offset: 0x0055E0FC
	private void RefreshRedDot()
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.ContentData.RoleId);
		if (roleInstanceById == null)
		{
			return;
		}
		RoleFavorData favorData = roleInstanceById.GetFavorData();
		EFavorItemStatus efavorItemStatus;
		if (this.ContentData.FavorContentType == EFavorContentType.Action)
		{
			efavorItemStatus = (EFavorItemStatus)MotionModel.Instance.GetRoleMotionState(roleInstanceById.GetRoleId(), this.ContentData.ConfigId);
		}
		else
		{
			efavorItemStatus = favorData.GetFavorItemState(this.ContentData.ConfigId, this.ContentData.FavorContentType);
		}
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(efavorItemStatus == EFavorItemStatus.ItemCanUnLock);
	}

	// Token: 0x04009ED3 RID: 40659
	public RoleFavorContentDataBase ContentData;

	// Token: 0x04009ED4 RID: 40660
	private UUIExtendToggle Toggle;

	// Token: 0x04009ED5 RID: 40661
	private UUIButtonComponent Button;

	// Token: 0x04009ED6 RID: 40662
	private TRoleFavorContentItemToggleFunction ToggleFunction;

	// Token: 0x04009ED7 RID: 40663
	private TRoleFavorContentItemButtonFunction ButtonFunction;

	// Token: 0x04009ED8 RID: 40664
	private EFavorPlayerStatus CurPlayerStatus = EFavorPlayerStatus.Stop;

	// Token: 0x04009ED9 RID: 40665
	private EFavorItemStatus? FavorItemStatus;

	// Token: 0x04009EDA RID: 40666
	[Nullable(1)]
	public FOnAkPostEventCallback CloseAudioDelegate;

	// Token: 0x04009EDB RID: 40667
	public Action<UAnimMontage, bool> OnMontageCompleted;

	// Token: 0x02008E85 RID: 36485
	[NullableContext(0)]
	private enum ERoleFavorContentItemDefine
	{
		// Token: 0x0402E391 RID: 189329
		LockItem,
		// Token: 0x0402E392 RID: 189330
		PlayVoiceItem,
		// Token: 0x0402E393 RID: 189331
		StopVoiceItem,
		// Token: 0x0402E394 RID: 189332
		TitleText,
		// Token: 0x0402E395 RID: 189333
		Toggle,
		// Token: 0x0402E396 RID: 189334
		RedDot,
		// Token: 0x0402E397 RID: 189335
		Button
	}
}
