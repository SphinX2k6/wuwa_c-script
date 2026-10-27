using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiNavigation;

// Token: 0x020025A3 RID: 9635
[NullableContext(2)]
[Nullable(0)]
public class PhotoJoystickOwnerController
{
	// Token: 0x17001918 RID: 6424
	// (get) Token: 0x06013839 RID: 79929 RVA: 0x004E0223 File Offset: 0x004DE423
	// (set) Token: 0x0601383A RID: 79930 RVA: 0x004E022B File Offset: 0x004DE42B
	public EPhotoJoystickOwner Current { get; private set; }

	// Token: 0x0601383B RID: 79931 RVA: 0x004E0234 File Offset: 0x004DE434
	public bool Request(EPhotoJoystickOwner next, bool occupyNavigationFocus = false)
	{
		if (this.Current == next)
		{
			return true;
		}
		if (!this.CanEnter(next))
		{
			return false;
		}
		EPhotoJoystickOwner ephotoJoystickOwner = this.Current;
		this.Current = next;
		if (occupyNavigationFocus && ephotoJoystickOwner == EPhotoJoystickOwner.Navigation)
		{
			this.OccupyPrevFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			UiNavigationNewController.Instance.SwitchNavigationFocus(null);
			this.LastFocusInNavGroup = PhotoJoystickOwnerController.IsFocusInNavGroup();
		}
		Action<EPhotoJoystickOwner, EPhotoJoystickOwner> onOwnerChanged = this.OnOwnerChanged;
		if (onOwnerChanged != null)
		{
			onOwnerChanged(ephotoJoystickOwner, next);
		}
		return true;
	}

	// Token: 0x0601383C RID: 79932 RVA: 0x004E02A6 File Offset: 0x004DE4A6
	public void Release(EPhotoJoystickOwner from)
	{
		if (this.Current != from)
		{
			return;
		}
		this.Request(EPhotoJoystickOwner.CameraMove, false);
		this.RestoreOccupyPrevFocus();
	}

	// Token: 0x0601383D RID: 79933 RVA: 0x004E02C4 File Offset: 0x004DE4C4
	private void RestoreOccupyPrevFocus()
	{
		if (this.OccupyPrevFocusListener == null)
		{
			return;
		}
		TsUiNavigationBehaviorListener occupyPrevFocusListener = this.OccupyPrevFocusListener;
		this.OccupyPrevFocusListener = null;
		UiNavigationNewController.Instance.SwitchNavigationFocus(occupyPrevFocusListener);
		this.LastFocusInNavGroup = PhotoJoystickOwnerController.IsFocusInNavGroup();
	}

	// Token: 0x0601383E RID: 79934 RVA: 0x004E0300 File Offset: 0x004DE500
	public void OnNavigationFocusChanged()
	{
		bool flag = PhotoJoystickOwnerController.IsFocusInNavGroup();
		if (flag == this.LastFocusInNavGroup)
		{
			return;
		}
		this.LastFocusInNavGroup = flag;
		if (flag)
		{
			this.Request(EPhotoJoystickOwner.Navigation, false);
			return;
		}
		this.Release(EPhotoJoystickOwner.Navigation);
	}

	// Token: 0x0601383F RID: 79935 RVA: 0x004E0338 File Offset: 0x004DE538
	public void InitNavigationFocusState()
	{
		this.LastFocusInNavGroup = PhotoJoystickOwnerController.IsFocusInNavGroup();
	}

	// Token: 0x06013840 RID: 79936 RVA: 0x004E0348 File Offset: 0x004DE548
	public static bool IsFocusInNavGroup()
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
		string text;
		if (currentNavigationFocusListener == null)
		{
			text = null;
		}
		else
		{
			NavigationGroup navigationGroup = currentNavigationFocusListener.GetNavigationGroup();
			text = ((navigationGroup != null) ? navigationGroup.GroupName : null);
		}
		string text2 = text;
		return text2 != null && PhotoJoystickOwnerController.NavGroupNameSet.Contains(text2);
	}

	// Token: 0x06013841 RID: 79937 RVA: 0x004E0388 File Offset: 0x004DE588
	private bool CanEnter(EPhotoJoystickOwner next)
	{
		if (next != EPhotoJoystickOwner.Sticker)
		{
			return next != EPhotoJoystickOwner.Cursor || this.Current != EPhotoJoystickOwner.Navigation;
		}
		return this.Current != EPhotoJoystickOwner.Cursor;
	}

	// Token: 0x0400934E RID: 37710
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly HashSet<string> NavGroupNameSet = new HashSet<string>
	{
		"Group1",
		"Group2",
		"GroupFilter",
		"GroupSlider"
	};

	// Token: 0x04009350 RID: 37712
	public Action<EPhotoJoystickOwner, EPhotoJoystickOwner> OnOwnerChanged;

	// Token: 0x04009351 RID: 37713
	private bool LastFocusInNavGroup;

	// Token: 0x04009352 RID: 37714
	private TsUiNavigationBehaviorListener OccupyPrevFocusListener;
}
