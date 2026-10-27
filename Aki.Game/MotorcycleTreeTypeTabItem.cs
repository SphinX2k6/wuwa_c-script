using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002267 RID: 8807
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTreeTypeTabItem : CommonTabItemBase
{
	// Token: 0x060112F3 RID: 70387 RVA: 0x004302EC File Offset: 0x0042E4EC
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

	// Token: 0x060112F4 RID: 70388 RVA: 0x004303C1 File Offset: 0x0042E5C1
	protected override void OnStart()
	{
		base.OnStart();
		this.SeqPlayer = new LevelSequencePlayer(base.GetItem(6));
	}

	// Token: 0x060112F5 RID: 70389 RVA: 0x004303DC File Offset: 0x0042E5DC
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

	// Token: 0x060112F6 RID: 70390 RVA: 0x004304B7 File Offset: 0x0042E6B7
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

	// Token: 0x060112F7 RID: 70391 RVA: 0x004304E4 File Offset: 0x0042E6E4
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x060112F8 RID: 70392 RVA: 0x004304E6 File Offset: 0x0042E6E6
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, bFire, false, true);
	}

	// Token: 0x060112F9 RID: 70393 RVA: 0x004304F8 File Offset: 0x0042E6F8
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x060112FA RID: 70394 RVA: 0x00430504 File Offset: 0x0042E704
	public void BindRedDot(ERedDotName redDotName, int treeType)
	{
		this.UnBindRedDot();
		UUIItem item = base.GetItem(4);
		this.RedDotName = new ERedDotName?(redDotName);
		this.TreeType = treeType;
		RedDotController.Instance.BindRedDot(redDotName, item, null, treeType);
	}

	// Token: 0x060112FB RID: 70395 RVA: 0x00430540 File Offset: 0x0042E740
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(4), this.TreeType);
			this.RedDotName = null;
			this.TreeType = 0;
		}
	}

	// Token: 0x060112FC RID: 70396 RVA: 0x00430590 File Offset: 0x0042E790
	public void BindNewRedDot(ERedDotName redDotName, int treeType)
	{
		this.UnBindNewRedDot();
		UUIItem item = base.GetItem(5);
		this.NewRedDotName = new ERedDotName?(redDotName);
		this.NewTreeType = treeType;
		RedDotController.Instance.BindRedDot(redDotName, item, null, treeType);
	}

	// Token: 0x060112FD RID: 70397 RVA: 0x004305CC File Offset: 0x0042E7CC
	public void UnBindNewRedDot()
	{
		if (this.NewRedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.NewRedDotName.Value, base.GetItem(5), this.NewTreeType);
			this.NewRedDotName = null;
			this.NewTreeType = 0;
		}
	}

	// Token: 0x040082CB RID: 33483
	private ERedDotName? RedDotName;

	// Token: 0x040082CC RID: 33484
	private ERedDotName? NewRedDotName;

	// Token: 0x040082CD RID: 33485
	private int TreeType;

	// Token: 0x040082CE RID: 33486
	private int NewTreeType;

	// Token: 0x040082CF RID: 33487
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0200878D RID: 34701
	[NullableContext(0)]
	private class EMotorTreeTypeTabItemComponent
	{
		// Token: 0x0402C0E9 RID: 180457
		public const int TogItem = 0;

		// Token: 0x0402C0EA RID: 180458
		public const int TexIcon = 1;

		// Token: 0x0402C0EB RID: 180459
		public const int TxtName = 2;

		// Token: 0x0402C0EC RID: 180460
		public const int FinishItem = 3;

		// Token: 0x0402C0ED RID: 180461
		public const int RedDotItem = 4;

		// Token: 0x0402C0EE RID: 180462
		public const int NewItem = 5;

		// Token: 0x0402C0EF RID: 180463
		public const int NewSeqItem = 6;
	}
}
