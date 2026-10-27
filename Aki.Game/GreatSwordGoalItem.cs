using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DB3 RID: 7603
[NullableContext(1)]
[Nullable(0)]
public class GreatSwordGoalItem : UiPanelBase, IGridProxy<TrialSubChallenge>
{
	// Token: 0x1700126C RID: 4716
	// (get) Token: 0x0600E6BE RID: 59070 RVA: 0x00365DA4 File Offset: 0x00363FA4
	// (set) Token: 0x0600E6BF RID: 59071 RVA: 0x00365DAC File Offset: 0x00363FAC
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<TrialSubChallenge>, TrialSubChallenge> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x1700126D RID: 4717
	// (get) Token: 0x0600E6C0 RID: 59072 RVA: 0x00365DB5 File Offset: 0x00363FB5
	// (set) Token: 0x0600E6C1 RID: 59073 RVA: 0x00365DBD File Offset: 0x00363FBD
	public int GridIndex { get; set; }

	// Token: 0x1700126E RID: 4718
	// (get) Token: 0x0600E6C2 RID: 59074 RVA: 0x00365DC6 File Offset: 0x00363FC6
	// (set) Token: 0x0600E6C3 RID: 59075 RVA: 0x00365DCE File Offset: 0x00363FCE
	public int DisplayIndex { get; set; }

	// Token: 0x0600E6C4 RID: 59076 RVA: 0x00365DD8 File Offset: 0x00363FD8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x0600E6C5 RID: 59077 RVA: 0x00365E34 File Offset: 0x00364034
	public void Refresh(TrialSubChallenge data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Config.GoalText, Array.Empty<object>());
		base.GetSprite(1).SetUIActive(!data.Completed);
		base.GetSprite(2).SetUIActive(data.Completed);
	}

	// Token: 0x0600E6C6 RID: 59078 RVA: 0x00365E8C File Offset: 0x0036408C
	public void Clear()
	{
	}

	// Token: 0x0600E6C7 RID: 59079 RVA: 0x00365E8E File Offset: 0x0036408E
	public void OnSelected(bool isSelected)
	{
	}

	// Token: 0x0600E6C8 RID: 59080 RVA: 0x00365E90 File Offset: 0x00364090
	public void OnDeselected(bool isSelected)
	{
	}

	// Token: 0x0600E6C9 RID: 59081 RVA: 0x00365E94 File Offset: 0x00364094
	public object GetKey(TrialSubChallenge data, int index)
	{
		return data.Config.Id;
	}

	// Token: 0x04006AC7 RID: 27335
	private IGridProxy<TrialSubChallenge> GridProxyImplementation;
}
