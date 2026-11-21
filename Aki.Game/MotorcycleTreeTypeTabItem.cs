using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200174B RID: 5963
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTreeTypeTabItem : CommonTabItemBase
{
	// Token: 0x0600E789 RID: 59273 RVA: 0x0043CEF8 File Offset: 0x0043B0F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600E78A RID: 59274 RVA: 0x0043CFCD File Offset: 0x0043B1CD
	protected override void OnStart()
	{
		base.OnStart();
		this.SeqPlayer = new LevelSequencePlayer(base.GetItem(6));
	}

	// Token: 0x0600E78B RID: 59275 RVA: 0x0043CFE8 File Offset: 0x0043B1E8
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		MotorcycleTreeTypeTabItemData motorcycleTreeTypeTabItemData = data as MotorcycleTreeTypeTabItemData;
		int treeType = motorcycleTreeTypeTabItemData.TreeType;
		bool isFinish = motorcycleTreeTypeTabItemData.IsFinish;
		bool flag = MotorcycleDevelopModel.Instance.RedDotHasNewTechTree(treeType);
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(treeType);
		if (motorTechTreeConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), motorTechTreeConfig.Value.Name, Array.Empty<object>());
		base.SetTextureByPath(motorTechTreeConfig.Value.Icon, base.GetTexture(1), null, null);
		base.GetItem(3).SetUIActive(isFinish);
		base.GetItem(6).SetUIActive(flag);
		if (flag)
		{
			this.SeqPlayer.StopSequenceByKey("Loop", false, false);
			this.SeqPlayer.PlayLevelSequenceByName("Loop", false, null, false);
		}
	}

	// Token: 0x0600E78C RID: 59276 RVA: 0x0043D0C3 File Offset: 0x0043B2C3
	private void OnClickToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		Action<int> selectedCallBack = this.SelectedCallBack;
		if (selectedCallBack != null)
		{
			selectedCallBack(base.GridIndex);
		}
		base.GetItem(6).SetUIActive(false);
	}

	// Token: 0x0600E78D RID: 59277 RVA: 0x0043D0F0 File Offset: 0x0043B2F0
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x0600E78E RID: 59278 RVA: 0x0043D0F2 File Offset: 0x0043B2F2
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, bFire, false, true);
	}

	// Token: 0x0600E78F RID: 59279 RVA: 0x0043D104 File Offset: 0x0043B304
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600E790 RID: 59280 RVA: 0x0043D110 File Offset: 0x0043B310
	public void BindRedDot(ERedDotName redDotName, int treeType)
	{
		this.UnBindRedDot();
		UUIItem item = base.GetItem(4);
		this.RedDotName = new ERedDotName?(redDotName);
		this.TreeType = treeType;
		RedDotController.Instance.BindRedDot(redDotName, item, null, treeType);
	}

	// Token: 0x0600E791 RID: 59281 RVA: 0x0043D14C File Offset: 0x0043B34C
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(4), this.TreeType);
			this.RedDotName = null;
			this.TreeType = 0;
		}
	}

	// Token: 0x0600E792 RID: 59282 RVA: 0x0043D19C File Offset: 0x0043B39C
	public void BindNewRedDot(ERedDotName redDotName, int treeType)
	{
		this.UnBindNewRedDot();
		UUIItem item = base.GetItem(5);
		this.NewRedDotName = new ERedDotName?(redDotName);
		this.NewTreeType = treeType;
		RedDotController.Instance.BindRedDot(redDotName, item, null, treeType);
	}

	// Token: 0x0600E793 RID: 59283 RVA: 0x0043D1D8 File Offset: 0x0043B3D8
	public void UnBindNewRedDot()
	{
		if (this.NewRedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.NewRedDotName.Value, base.GetItem(5), this.NewTreeType);
			this.NewRedDotName = null;
			this.NewTreeType = 0;
		}
	}

	// Token: 0x04008409 RID: 33801
	private ERedDotName? RedDotName;

	// Token: 0x0400840A RID: 33802
	private ERedDotName? NewRedDotName;

	// Token: 0x0400840B RID: 33803
	private int TreeType;

	// Token: 0x0400840C RID: 33804
	private int NewTreeType;

	// Token: 0x0400840D RID: 33805
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x02007916 RID: 30998
	[NullableContext(0)]
	private class EMotorTreeTypeTabItemComponent
	{
		// Token: 0x04027401 RID: 160769
		public const int TogItem = 0;

		// Token: 0x04027402 RID: 160770
		public const int TexIcon = 1;

		// Token: 0x04027403 RID: 160771
		public const int TxtName = 2;

		// Token: 0x04027404 RID: 160772
		public const int FinishItem = 3;

		// Token: 0x04027405 RID: 160773
		public const int RedDotItem = 4;

		// Token: 0x04027406 RID: 160774
		public const int NewItem = 5;

		// Token: 0x04027407 RID: 160775
		public const int NewSeqItem = 6;
	}
}
