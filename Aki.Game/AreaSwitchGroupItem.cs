using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001713 RID: 5907
public class AreaSwitchGroupItem : UiPanelBase
{
	// Token: 0x0600E5C9 RID: 58825 RVA: 0x00436570 File Offset: 0x00434770
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickLastBtn)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickNextBtn))
		};
	}

	// Token: 0x0600E5CA RID: 58826 RVA: 0x0043661C File Offset: 0x0043481C
	[NullableContext(1)]
	public void RefreshAreaList(List<int> areaIdList, int selectAreaId)
	{
		this.AreaIdList = areaIdList;
		int num = areaIdList.IndexOf(selectAreaId);
		this.SelectAreaIndex = ((num >= 0) ? num : 0);
		this.Refresh();
	}

	// Token: 0x0600E5CB RID: 58827 RVA: 0x0043664C File Offset: 0x0043484C
	private void Refresh()
	{
		int num = this.AreaIdList[this.SelectAreaIndex];
		MotorRoleCategory? config = ConfigMotorRoleCategoryById.GetConfig(num, true);
		if (config == null)
		{
			return;
		}
		MotorRoleCategory valueOrDefault = config.GetValueOrDefault();
		MotorRoleCategory motorRoleCategory = valueOrDefault;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), motorRoleCategory.RegionName, Array.Empty<object>());
		this.SetSpriteByPath(motorRoleCategory.Icon, base.GetSprite(0), false, null, null);
		Action<int> onSwitchCallBack = this.OnSwitchCallBack;
		if (onSwitchCallBack == null)
		{
			return;
		}
		onSwitchCallBack(num);
	}

	// Token: 0x0600E5CC RID: 58828 RVA: 0x004366D7 File Offset: 0x004348D7
	private void OnClickLastBtn()
	{
		this.SelectAreaIndex--;
		if (this.SelectAreaIndex < 0)
		{
			this.SelectAreaIndex = this.AreaIdList.Count - 1;
		}
		this.Refresh();
	}

	// Token: 0x0600E5CD RID: 58829 RVA: 0x00436709 File Offset: 0x00434909
	private void OnClickNextBtn()
	{
		this.SelectAreaIndex++;
		if (this.SelectAreaIndex >= this.AreaIdList.Count)
		{
			this.SelectAreaIndex = 0;
		}
		this.Refresh();
	}

	// Token: 0x04008356 RID: 33622
	[Nullable(1)]
	private List<int> AreaIdList = new List<int>();

	// Token: 0x04008357 RID: 33623
	private int SelectAreaIndex;

	// Token: 0x04008358 RID: 33624
	[Nullable(2)]
	public Action<int> OnSwitchCallBack;

	// Token: 0x020078E6 RID: 30950
	private class EComponents
	{
		// Token: 0x0402731F RID: 160543
		public const int SpriteIcon = 0;

		// Token: 0x04027320 RID: 160544
		public const int TxtTitle = 1;

		// Token: 0x04027321 RID: 160545
		public const int BtnLast = 2;

		// Token: 0x04027322 RID: 160546
		public const int BtnNext = 3;
	}
}
