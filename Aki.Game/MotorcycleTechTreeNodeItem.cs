using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002243 RID: 8771
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeNodeItem : GridProxyAbstract<MotorTechTreeNode>
{
	// Token: 0x060111C1 RID: 70081 RVA: 0x0042CB4C File Offset: 0x0042AD4C
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

	// Token: 0x060111C2 RID: 70082 RVA: 0x0042CC4D File Offset: 0x0042AE4D
	protected override void OnStart()
	{
		this.LevelLayout = new GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint>(base.GetHorizontalLayout(8), new Func<MotorcycleTechTreeLevelItem>(this.InitLevelItem), null, false, true);
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060111C3 RID: 70083 RVA: 0x0042CC84 File Offset: 0x0042AE84
	protected override void OnBeforeShow()
	{
		if (this.Node != null)
		{
			this.SeqPlayer.StopSequenceByKey("Start", false, false);
			this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
	}

	// Token: 0x060111C4 RID: 70084 RVA: 0x0042CCC8 File Offset: 0x0042AEC8
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

	// Token: 0x060111C5 RID: 70085 RVA: 0x0042CD14 File Offset: 0x0042AF14
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

	// Token: 0x060111C6 RID: 70086 RVA: 0x0042CF18 File Offset: 0x0042B118
	[NullableContext(1)]
	public override void Refresh(MotorTechTreeNode data, bool isSelected, int gridIndex)
	{
		this.RefreshNodeData(data);
	}

	// Token: 0x060111C7 RID: 70087 RVA: 0x0042CF21 File Offset: 0x0042B121
	[NullableContext(1)]
	private MotorcycleTechTreeLevelItem InitLevelItem()
	{
		return new MotorcycleTechTreeLevelItem();
	}

	// Token: 0x060111C8 RID: 70088 RVA: 0x0042CF28 File Offset: 0x0042B128
	public void SelectNode()
	{
		this.OnSelectTechTreeNode();
	}

	// Token: 0x060111C9 RID: 70089 RVA: 0x0042CF30 File Offset: 0x0042B130
	private void OnTechTreeNodeClick(EToggleState toggleState)
	{
		this.OnSelectTechTreeNode();
	}

	// Token: 0x060111CA RID: 70090 RVA: 0x0042CF38 File Offset: 0x0042B138
	private void OnSelectTechTreeNode()
	{
		Action<MotorTechTreeNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.Node, base.GetExtendToggle(0));
	}

	// Token: 0x04008249 RID: 33353
	public MotorTechTreeNode Node;

	// Token: 0x0400824A RID: 33354
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeLevelItem, IMotorTechLevelPoint> LevelLayout;

	// Token: 0x0400824B RID: 33355
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400824C RID: 33356
	private bool HasPlayedSequence;

	// Token: 0x0400824D RID: 33357
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<MotorTechTreeNode, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x0200877F RID: 34687
	[NullableContext(0)]
	private class EMotorTreeNodeItemComponent
	{
		// Token: 0x0402C0A7 RID: 180391
		public const int TogItem = 0;

		// Token: 0x0402C0A8 RID: 180392
		public const int ActivateBgItem = 1;

		// Token: 0x0402C0A9 RID: 180393
		public const int SprActivate = 2;

		// Token: 0x0402C0AA RID: 180394
		public const int TexIconActivate = 3;

		// Token: 0x0402C0AB RID: 180395
		public const int LockBgItem = 4;

		// Token: 0x0402C0AC RID: 180396
		public const int TexIconLock = 5;

		// Token: 0x0402C0AD RID: 180397
		public const int RedDotItem = 6;

		// Token: 0x0402C0AE RID: 180398
		public const int LockItem = 7;

		// Token: 0x0402C0AF RID: 180399
		public const int LevelLayout = 8;
	}
}
