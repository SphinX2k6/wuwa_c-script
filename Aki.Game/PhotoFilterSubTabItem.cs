using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A57 RID: 6743
public class PhotoFilterSubTabItem : GridProxyAbstract<PhotoSubTab>
{
	// Token: 0x06010A4F RID: 68175 RVA: 0x004DEBA0 File Offset: 0x004DCDA0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06010A50 RID: 68176 RVA: 0x004DEC07 File Offset: 0x004DCE07
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06010A51 RID: 68177 RVA: 0x004DEC18 File Offset: 0x004DCE18
	public override void Refresh(PhotoSubTab data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.SetSpriteByPath(data.Icon, base.GetSprite(1), false, null, null);
	}

	// Token: 0x06010A52 RID: 68178 RVA: 0x004DEC4B File Offset: 0x004DCE4B
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06010A53 RID: 68179 RVA: 0x004DEC62 File Offset: 0x004DCE62
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010A54 RID: 68180 RVA: 0x004DEC79 File Offset: 0x004DCE79
	[NullableContext(1)]
	public override object GetKey(PhotoSubTab data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06010A55 RID: 68181 RVA: 0x004DEC87 File Offset: 0x004DCE87
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnSubTabClick(this.Data);
	}

	// Token: 0x0400931F RID: 37663
	private PhotoSubTab Data;

	// Token: 0x04009320 RID: 37664
	[Nullable(1)]
	public Action<PhotoSubTab> OnSubTabClick = delegate(PhotoSubTab data)
	{
	};

	// Token: 0x02007CD6 RID: 31958
	private enum EComponents
	{
		// Token: 0x040286D4 RID: 165588
		ToggleTab,
		// Token: 0x040286D5 RID: 165589
		SpriteIcon
	}
}
