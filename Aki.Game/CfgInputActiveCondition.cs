using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002605 RID: 9733
[NullableContext(1)]
[Nullable(0)]
public class CfgInputActiveCondition
{
	// Token: 0x17002630 RID: 9776
	// (get) Token: 0x06018540 RID: 99648 RVA: 0x0075699C File Offset: 0x00754B9C
	// (set) Token: 0x06018541 RID: 99649 RVA: 0x007569A4 File Offset: 0x00754BA4
	public EInputActiveConditionType ConditionType { get; set; }

	// Token: 0x17002631 RID: 9777
	// (get) Token: 0x06018542 RID: 99650 RVA: 0x007569AD File Offset: 0x00754BAD
	// (set) Token: 0x06018543 RID: 99651 RVA: 0x007569B5 File Offset: 0x00754BB5
	public ESkillBehaviorComparisonLogic ComparisonLogic { get; set; }

	// Token: 0x17002632 RID: 9778
	// (get) Token: 0x06018544 RID: 99652 RVA: 0x007569BE File Offset: 0x00754BBE
	// (set) Token: 0x06018545 RID: 99653 RVA: 0x007569C6 File Offset: 0x00754BC6
	public float Value { get; set; }

	// Token: 0x17002633 RID: 9779
	// (get) Token: 0x06018546 RID: 99654 RVA: 0x007569CF File Offset: 0x00754BCF
	// (set) Token: 0x06018547 RID: 99655 RVA: 0x007569D7 File Offset: 0x00754BD7
	public float RangeL { get; set; }

	// Token: 0x17002634 RID: 9780
	// (get) Token: 0x06018548 RID: 99656 RVA: 0x007569E0 File Offset: 0x00754BE0
	// (set) Token: 0x06018549 RID: 99657 RVA: 0x007569E8 File Offset: 0x00754BE8
	public float RangeR { get; set; }

	// Token: 0x17002635 RID: 9781
	// (get) Token: 0x0601854A RID: 99658 RVA: 0x007569F1 File Offset: 0x00754BF1
	// (set) Token: 0x0601854B RID: 99659 RVA: 0x007569F9 File Offset: 0x00754BF9
	public EAttributeType AttributeId1 { get; set; }

	// Token: 0x17002636 RID: 9782
	// (get) Token: 0x0601854C RID: 99660 RVA: 0x00756A02 File Offset: 0x00754C02
	// (set) Token: 0x0601854D RID: 99661 RVA: 0x00756A0A File Offset: 0x00754C0A
	public EAttributeType AttributeId2 { get; set; }

	// Token: 0x17002637 RID: 9783
	// (get) Token: 0x0601854E RID: 99662 RVA: 0x00756A13 File Offset: 0x00754C13
	// (set) Token: 0x0601854F RID: 99663 RVA: 0x00756A1B File Offset: 0x00754C1B
	public int AttributeRate { get; set; }

	// Token: 0x17002638 RID: 9784
	// (get) Token: 0x06018550 RID: 99664 RVA: 0x00756A24 File Offset: 0x00754C24
	// (set) Token: 0x06018551 RID: 99665 RVA: 0x00756A2C File Offset: 0x00754C2C
	public IList<int> TagToCheck { get; set; }

	// Token: 0x17002639 RID: 9785
	// (get) Token: 0x06018552 RID: 99666 RVA: 0x00756A35 File Offset: 0x00754C35
	// (set) Token: 0x06018553 RID: 99667 RVA: 0x00756A3D File Offset: 0x00754C3D
	public bool AnyTag { get; set; }

	// Token: 0x1700263A RID: 9786
	// (get) Token: 0x06018554 RID: 99668 RVA: 0x00756A46 File Offset: 0x00754C46
	// (set) Token: 0x06018555 RID: 99669 RVA: 0x00756A4E File Offset: 0x00754C4E
	public bool Reverse { get; set; }

	// Token: 0x06018556 RID: 99670 RVA: 0x00756A58 File Offset: 0x00754C58
	public CfgInputActiveCondition(SInputActiveCondition ueCondition)
	{
		this.ConditionType = ueCondition.ConditionType;
		this.ComparisonLogic = ueCondition.ComparisonLogic;
		this.Value = ueCondition.Value;
		this.RangeL = ueCondition.RangeL;
		this.RangeR = ueCondition.RangeR;
		this.AttributeId1 = (EAttributeType)ueCondition.AttributeId1;
		this.AttributeId2 = (EAttributeType)ueCondition.AttributeId2;
		this.AttributeRate = ueCondition.AttributeRate;
		this.TagToCheck = GameplayTagUtils.ConvertFromUeContainer(ueCondition.TagToCheck);
		this.AnyTag = ueCondition.AnyTag;
		this.Reverse = ueCondition.Reverse;
	}
}
