using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001DC9 RID: 7625
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleFavorContentItem : GridProxyAbstract<RoleFavorContentDataBase>
{
	// Token: 0x06012E5D RID: 77405 RVA: 0x0058A50C File Offset: 0x0058870C
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

	// Token: 0x06012E5E RID: 77406 RVA: 0x0058A5FC File Offset: 0x005887FC
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

	// Token: 0x06012E5F RID: 77407 RVA: 0x0058A641 File Offset: 0x00588841
	[NullableContext(1)]
	public override void Refresh(RoleFavorContentDataBase data, bool isSelected, int gridIndex)
	{
		this.ContentData = data;
		base.GridIndex = gridIndex;
		base.DisplayIndex = gridIndex;
		this.RefreshContentItem();
	}

	// Token: 0x06012E60 RID: 77408 RVA: 0x0058A660 File Offset: 0x00588860
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

	// Token: 0x06012E61 RID: 77409 RVA: 0x0058A6D7 File Offset: 0x005888D7
	[NullableContext(1)]
	public void BindToggleFunction(TRoleFavorContentItemToggleFunction toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06012E62 RID: 77410 RVA: 0x0058A6E0 File Offset: 0x005888E0
	[NullableContext(1)]
	public void BindButtonFunction(TRoleFavorContentItemButtonFunction buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x06012E63 RID: 77411 RVA: 0x0058A6EC File Offset: 0x005888EC
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

	// Token: 0x06012E64 RID: 77412 RVA: 0x0058A738 File Offset: 0x00588938
	private void OnButtonClick()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction(this.ContentData, this);
		}
	}

	// Token: 0x06012E65 RID: 77413 RVA: 0x0058A754 File Offset: 0x00588954
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

	// Token: 0x06012E66 RID: 77414 RVA: 0x0058A7A4 File Offset: 0x005889A4
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

	// Token: 0x06012E67 RID: 77415 RVA: 0x0058A7F4 File Offset: 0x005889F4
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

	// Token: 0x06012E68 RID: 77416 RVA: 0x0058A83C File Offset: 0x00588A3C
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

	// Token: 0x06012E69 RID: 77417 RVA: 0x0058A880 File Offset: 0x00588A80
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

	// Token: 0x06012E6A RID: 77418 RVA: 0x0058A8E0 File Offset: 0x00588AE0
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

	// Token: 0x06012E6B RID: 77419 RVA: 0x0058A94C File Offset: 0x00588B4C
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

	// Token: 0x06012E6C RID: 77420 RVA: 0x0058A9B0 File Offset: 0x00588BB0
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

	// Token: 0x06012E6D RID: 77421 RVA: 0x0058A9CC File Offset: 0x00588BCC
	private void InitAudioCompletedFunction()
	{
		if (this.CloseAudioDelegate == null)
		{
			this.CloseAudioDelegate = DelegateUtils.ToManualReleaseDelegate<FOnAkPostEventCallback>(new Action<EAkCallbackType, UAkCallbackInfo>(this.EndPlayDelegate));
		}
	}

	// Token: 0x06012E6E RID: 77422 RVA: 0x0058A9F0 File Offset: 0x00588BF0
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

	// Token: 0x06012E6F RID: 77423 RVA: 0x0058AA64 File Offset: 0x00588C64
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

	// Token: 0x06012E70 RID: 77424 RVA: 0x0058AB21 File Offset: 0x00588D21
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

	// Token: 0x06012E71 RID: 77425 RVA: 0x0058AB5C File Offset: 0x00588D5C
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

	// Token: 0x06012E72 RID: 77426 RVA: 0x0058ABE9 File Offset: 0x00588DE9
	public EFavorPlayerStatus GetCurVoiceState()
	{
		return this.CurPlayerStatus;
	}

	// Token: 0x06012E73 RID: 77427 RVA: 0x0058ABF1 File Offset: 0x00588DF1
	public void EndPlayDelegate(EAkCallbackType type, UAkCallbackInfo info)
	{
		if (type == EAkCallbackType.EndOfEvent)
		{
			this.EndPlay();
		}
	}

	// Token: 0x06012E74 RID: 77428 RVA: 0x0058ABFC File Offset: 0x00588DFC
	public void EndPlay()
	{
		this.SetPlayerState(EFavorPlayerStatus.Stop);
	}

	// Token: 0x06012E75 RID: 77429 RVA: 0x0058AC05 File Offset: 0x00588E05
	public void StartPlay()
	{
		this.SetPlayerState(EFavorPlayerStatus.Play);
	}

	// Token: 0x06012E76 RID: 77430 RVA: 0x0058AC0E File Offset: 0x00588E0E
	public void SetToggleState(EToggleState state)
	{
		if (this.Toggle != null)
		{
			this.Toggle.SetToggleState(state, false, false, false);
		}
	}

	// Token: 0x06012E77 RID: 77431 RVA: 0x0058AC28 File Offset: 0x00588E28
	public void SetButtonActive(bool active)
	{
		if (this.Button != null)
		{
			this.Button.RootUIComp.Get().SetUIActive(active);
		}
	}

	// Token: 0x06012E78 RID: 77432 RVA: 0x0058AC58 File Offset: 0x00588E58
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

	// Token: 0x0400A2BC RID: 41660
	public RoleFavorContentDataBase ContentData;

	// Token: 0x0400A2BD RID: 41661
	private UUIExtendToggle Toggle;

	// Token: 0x0400A2BE RID: 41662
	private UUIButtonComponent Button;

	// Token: 0x0400A2BF RID: 41663
	private TRoleFavorContentItemToggleFunction ToggleFunction;

	// Token: 0x0400A2C0 RID: 41664
	private TRoleFavorContentItemButtonFunction ButtonFunction;

	// Token: 0x0400A2C1 RID: 41665
	private EFavorPlayerStatus CurPlayerStatus = EFavorPlayerStatus.Stop;

	// Token: 0x0400A2C2 RID: 41666
	private EFavorItemStatus? FavorItemStatus;

	// Token: 0x0400A2C3 RID: 41667
	[Nullable(1)]
	public FOnAkPostEventCallback CloseAudioDelegate;

	// Token: 0x0400A2C4 RID: 41668
	public Action<UAnimMontage, bool> OnMontageCompleted;

	// Token: 0x020080CB RID: 32971
	[NullableContext(0)]
	private enum ERoleFavorContentItemDefine
	{
		// Token: 0x04029A8B RID: 170635
		LockItem,
		// Token: 0x04029A8C RID: 170636
		PlayVoiceItem,
		// Token: 0x04029A8D RID: 170637
		StopVoiceItem,
		// Token: 0x04029A8E RID: 170638
		TitleText,
		// Token: 0x04029A8F RID: 170639
		Toggle,
		// Token: 0x04029A90 RID: 170640
		RedDot,
		// Token: 0x04029A91 RID: 170641
		Button
	}
}
