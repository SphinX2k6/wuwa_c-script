using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001275 RID: 4725
[NullableContext(1)]
[Nullable(0)]
public class GreatSwordGoalItem : UiPanelBase, IGridProxy<TrialSubChallenge>
{
	// Token: 0x17001296 RID: 4758
	// (get) Token: 0x0600BADC RID: 47836 RVA: 0x00371A04 File Offset: 0x0036FC04
	// (set) Token: 0x0600BADD RID: 47837 RVA: 0x00371A0C File Offset: 0x0036FC0C
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

	// Token: 0x17001297 RID: 4759
	// (get) Token: 0x0600BADE RID: 47838 RVA: 0x00371A15 File Offset: 0x0036FC15
	// (set) Token: 0x0600BADF RID: 47839 RVA: 0x00371A1D File Offset: 0x0036FC1D
	public int GridIndex { get; set; }

	// Token: 0x17001298 RID: 4760
	// (get) Token: 0x0600BAE0 RID: 47840 RVA: 0x00371A26 File Offset: 0x0036FC26
	// (set) Token: 0x0600BAE1 RID: 47841 RVA: 0x00371A2E File Offset: 0x0036FC2E
	public int DisplayIndex { get; set; }

	// Token: 0x0600BAE2 RID: 47842 RVA: 0x00371A38 File Offset: 0x0036FC38
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x0600BAE3 RID: 47843 RVA: 0x00371A94 File Offset: 0x0036FC94
	public void Refresh(TrialSubChallenge data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Config.GoalText, Array.Empty<object>());
		base.GetSprite(1).SetUIActive(!data.Completed);
		base.GetSprite(2).SetUIActive(data.Completed);
	}

	// Token: 0x0600BAE4 RID: 47844 RVA: 0x00371AEC File Offset: 0x0036FCEC
	public void Clear()
	{
	}

	// Token: 0x0600BAE5 RID: 47845 RVA: 0x00371AEE File Offset: 0x0036FCEE
	public void OnSelected(bool isSelected)
	{
	}

	// Token: 0x0600BAE6 RID: 47846 RVA: 0x00371AF0 File Offset: 0x0036FCF0
	public void OnDeselected(bool isSelected)
	{
	}

	// Token: 0x0600BAE7 RID: 47847 RVA: 0x00371AF4 File Offset: 0x0036FCF4
	public object GetKey(TrialSubChallenge data, int index)
	{
		return data.Config.Id;
	}

	// Token: 0x04006BA8 RID: 27560
	private IGridProxy<TrialSubChallenge> GridProxyImplementation;
}
