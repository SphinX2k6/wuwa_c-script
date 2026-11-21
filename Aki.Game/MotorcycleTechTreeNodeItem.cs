using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001727 RID: 5927
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeNodeItem : GridProxyAbstract<MotorTechTreeNode>
{
	// Token: 0x0600E657 RID: 58967 RVA: 0x004396F0 File Offset: 0x004378F0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTechTreeNodeClick))
		};
	}

	// Token: 0x0600E658 RID: 58968 RVA: 0x004397F1 File Offset: 0x004379F1
	protected override void OnStart()
	{
		this.LevelLayout = new GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint>(base.GetHorizontalLayout(8), new Func<MotorcycleTechTreeLevelItem>(this.InitLevelItem), null, false, true);
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600E659 RID: 58969 RVA: 0x00439828 File Offset: 0x00437A28
	protected override void OnBeforeShow()
	{
		if (this.Node != null)
		{
			this.SeqPlayer.StopSequenceByKey("Start", false, false);
			this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
	}

	// Token: 0x0600E65A RID: 58970 RVA: 0x0043986C File Offset: 0x00437A6C
	public void PlayNodeSequence()
	{
		if (this.HasPlayedSequence)
		{
			return;
		}
		this.SeqPlayer.StopSequenceByKey("Start", false, false);
		this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		this.HasPlayedSequence = true;
	}

	// Token: 0x0600E65B RID: 58971 RVA: 0x004398B8 File Offset: 0x00437AB8
	public void RefreshNodeData(MotorTechTreeNode treeNode)
	{
		if (treeNode == null)
		{
			return;
		}
		this.Node = treeNode;
		MotorTech? motorTechConfig = MotorConfig.Instance.GetMotorTechConfig(treeNode.NodeId);
		if (motorTechConfig == null)
		{
			return;
		}
		EMotorTechTreeNodeStatus status = treeNode.Status;
		bool flag = status == EMotorTechTreeNodeStatus.Lock;
		bool flag2 = status == EMotorTechTreeNodeStatus.Activated;
		bool flag3 = status == EMotorTechTreeNodeStatus.CanUnlock;
		bool flag4 = MotorcycleDevelopModel.Instance.IsPreNodeActivated(treeNode);
		bool uiactive = flag || !flag4;
		UUIItem item = base.GetItem(1);
		UUISprite sprite = base.GetSprite(2);
		UUITexture texture = base.GetTexture(3);
		UUIItem item2 = base.GetItem(6);
		item.SetUIActive(false);
		sprite.SetUIActive(false);
		UUIItem uuiitem = texture;
		bool bUseChangeColor = false;
		FColor? fcolor = new FColor?(texture.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		item2.SetUIActive(false);
		base.GetItem(4).SetUIActive(uiactive);
		base.GetItem(7).SetUIActive(uiactive);
		bool flag5 = MotorcycleDevelopModel.Instance.CanUpgradeNode(treeNode);
		if (flag3)
		{
			item.SetUIActive(true);
			sprite.SetUIActive(false);
			item2.SetUIActive(flag4 && flag5);
		}
		else if (flag2)
		{
			bool flag6 = treeNode.NodeLevel >= motorTechConfig.Value.GetTechLvArray().Length;
			item.SetUIActive(true);
			sprite.SetUIActive(true);
			UUIItem uuiitem2 = texture;
			bool bUseChangeColor2 = true;
			fcolor = new FColor?(texture.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			item2.SetUIActive(!flag6 && flag5);
		}
		int nodeLevel = treeNode.NodeLevel;
		List<IMotorTechLevelPoint> list = new List<IMotorTechLevelPoint>();
		for (int i = 0; i < motorTechConfig.Value.GetTechLvArray().Length; i++)
		{
			MotorTechLevelPoint item3 = new MotorTechLevelPoint
			{
				TargetLevel = i + 1,
				CurLevel = nodeLevel
			};
			list.Add(item3);
		}
		base.SetTextureByPath(motorTechConfig.Value.Icon, base.GetTexture(3), null, null);
		base.SetTextureByPath(motorTechConfig.Value.Icon, base.GetTexture(5), null, null);
		this.LevelLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600E65C RID: 58972 RVA: 0x00439ABC File Offset: 0x00437CBC
	[NullableContext(1)]
	public override void Refresh(MotorTechTreeNode data, bool isSelected, int gridIndex)
	{
		this.RefreshNodeData(data);
	}

	// Token: 0x0600E65D RID: 58973 RVA: 0x00439AC5 File Offset: 0x00437CC5
	[NullableContext(1)]
	private MotorcycleTechTreeLevelItem InitLevelItem()
	{
		return new MotorcycleTechTreeLevelItem();
	}

	// Token: 0x0600E65E RID: 58974 RVA: 0x00439ACC File Offset: 0x00437CCC
	public void SelectNode()
	{
		this.OnSelectTechTreeNode();
	}

	// Token: 0x0600E65F RID: 58975 RVA: 0x00439AD4 File Offset: 0x00437CD4
	private void OnTechTreeNodeClick(EToggleState toggleState)
	{
		this.OnSelectTechTreeNode();
	}

	// Token: 0x0600E660 RID: 58976 RVA: 0x00439ADC File Offset: 0x00437CDC
	private void OnSelectTechTreeNode()
	{
		Action<MotorTechTreeNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.Node, base.GetExtendToggle(0));
	}

	// Token: 0x04008387 RID: 33671
	public MotorTechTreeNode Node;

	// Token: 0x04008388 RID: 33672
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint> LevelLayout;

	// Token: 0x04008389 RID: 33673
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400838A RID: 33674
	private bool HasPlayedSequence;

	// Token: 0x0400838B RID: 33675
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<MotorTechTreeNode, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x02007908 RID: 30984
	[NullableContext(0)]
	private class EMotorTreeNodeItemComponent
	{
		// Token: 0x040273BF RID: 160703
		public const int TogItem = 0;

		// Token: 0x040273C0 RID: 160704
		public const int ActivateBgItem = 1;

		// Token: 0x040273C1 RID: 160705
		public const int SprActivate = 2;

		// Token: 0x040273C2 RID: 160706
		public const int TexIconActivate = 3;

		// Token: 0x040273C3 RID: 160707
		public const int LockBgItem = 4;

		// Token: 0x040273C4 RID: 160708
		public const int TexIconLock = 5;

		// Token: 0x040273C5 RID: 160709
		public const int RedDotItem = 6;

		// Token: 0x040273C6 RID: 160710
		public const int LockItem = 7;

		// Token: 0x040273C7 RID: 160711
		public const int LevelLayout = 8;
	}
}
