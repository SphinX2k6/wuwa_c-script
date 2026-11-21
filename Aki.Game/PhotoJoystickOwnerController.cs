using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiNavigation;

// Token: 0x02001A8E RID: 6798
[NullableContext(2)]
[Nullable(0)]
public class PhotoJoystickOwnerController
{
	// Token: 0x17001952 RID: 6482
	// (get) Token: 0x06010D1B RID: 68891 RVA: 0x004EED57 File Offset: 0x004ECF57
	// (set) Token: 0x06010D1C RID: 68892 RVA: 0x004EED5F File Offset: 0x004ECF5F
	public EPhotoJoystickOwner Current { get; private set; }

	// Token: 0x06010D1D RID: 68893 RVA: 0x004EED68 File Offset: 0x004ECF68
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

	// Token: 0x06010D1E RID: 68894 RVA: 0x004EEDDA File Offset: 0x004ECFDA
	public void Release(EPhotoJoystickOwner from)
	{
		if (this.Current != from)
		{
			return;
		}
		this.Request(EPhotoJoystickOwner.CameraMove, false);
		this.RestoreOccupyPrevFocus();
	}

	// Token: 0x06010D1F RID: 68895 RVA: 0x004EEDF8 File Offset: 0x004ECFF8
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

	// Token: 0x06010D20 RID: 68896 RVA: 0x004EEE34 File Offset: 0x004ED034
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

	// Token: 0x06010D21 RID: 68897 RVA: 0x004EEE6C File Offset: 0x004ED06C
	public void InitNavigationFocusState()
	{
		this.LastFocusInNavGroup = PhotoJoystickOwnerController.IsFocusInNavGroup();
	}

	// Token: 0x06010D22 RID: 68898 RVA: 0x004EEE7C File Offset: 0x004ED07C
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

	// Token: 0x06010D23 RID: 68899 RVA: 0x004EEEBC File Offset: 0x004ED0BC
	private bool CanEnter(EPhotoJoystickOwner next)
	{
		if (next != EPhotoJoystickOwner.Sticker)
		{
			return next != EPhotoJoystickOwner.Cursor || this.Current != EPhotoJoystickOwner.Navigation;
		}
		return this.Current != EPhotoJoystickOwner.Cursor;
	}

	// Token: 0x040094A6 RID: 38054
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly HashSet<string> NavGroupNameSet = new HashSet<string>
	{
		"Group1",
		"Group2",
		"GroupFilter",
		"GroupSlider"
	};

	// Token: 0x040094A8 RID: 38056
	public Action<EPhotoJoystickOwner, EPhotoJoystickOwner> OnOwnerChanged;

	// Token: 0x040094A9 RID: 38057
	private bool LastFocusInNavGroup;

	// Token: 0x040094AA RID: 38058
	private TsUiNavigationBehaviorListener OccupyPrevFocusListener;
}
