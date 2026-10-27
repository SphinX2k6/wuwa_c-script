using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200222F RID: 8751
public class AreaSwitchGroupItem : UiPanelBase
{
	// Token: 0x06011133 RID: 69939 RVA: 0x004299CC File Offset: 0x00427BCC
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

	// Token: 0x06011134 RID: 69940 RVA: 0x00429A78 File Offset: 0x00427C78
	[NullableContext(1)]
	public void RefreshAreaList(List<int> areaIdList, int selectAreaId)
	{
		this.AreaIdList = areaIdList;
		int num = areaIdList.IndexOf(selectAreaId);
		this.SelectAreaIndex = ((num >= 0) ? num : 0);
		this.Refresh();
	}

	// Token: 0x06011135 RID: 69941 RVA: 0x00429AA8 File Offset: 0x00427CA8
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

	// Token: 0x06011136 RID: 69942 RVA: 0x00429B33 File Offset: 0x00427D33
	private void OnClickLastBtn()
	{
		this.SelectAreaIndex--;
		if (this.SelectAreaIndex < 0)
		{
			this.SelectAreaIndex = this.AreaIdList.Count - 1;
		}
		this.Refresh();
	}

	// Token: 0x06011137 RID: 69943 RVA: 0x00429B65 File Offset: 0x00427D65
	private void OnClickNextBtn()
	{
		this.SelectAreaIndex++;
		if (this.SelectAreaIndex >= this.AreaIdList.Count)
		{
			this.SelectAreaIndex = 0;
		}
		this.Refresh();
	}

	// Token: 0x04008218 RID: 33304
	[Nullable(1)]
	private List<int> AreaIdList = new List<int>();

	// Token: 0x04008219 RID: 33305
	private int SelectAreaIndex;

	// Token: 0x0400821A RID: 33306
	[Nullable(2)]
	public Action<int> OnSwitchCallBack;

	// Token: 0x0200875D RID: 34653
	private class EComponents
	{
		// Token: 0x0402C007 RID: 180231
		public const int SpriteIcon = 0;

		// Token: 0x0402C008 RID: 180232
		public const int TxtTitle = 1;

		// Token: 0x0402C009 RID: 180233
		public const int BtnLast = 2;

		// Token: 0x0402C00A RID: 180234
		public const int BtnNext = 3;
	}
}
