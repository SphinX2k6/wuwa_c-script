using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020030AE RID: 12462
[NullableContext(1)]
[Nullable(0)]
public class CfgInputActiveCondition
{
	// Token: 0x170024AD RID: 9389
	// (get) Token: 0x0601AB32 RID: 109362 RVA: 0x0073149C File Offset: 0x0072F69C
	// (set) Token: 0x0601AB33 RID: 109363 RVA: 0x007314A4 File Offset: 0x0072F6A4
	public EInputActiveConditionType ConditionType { get; set; }

	// Token: 0x170024AE RID: 9390
	// (get) Token: 0x0601AB34 RID: 109364 RVA: 0x007314AD File Offset: 0x0072F6AD
	// (set) Token: 0x0601AB35 RID: 109365 RVA: 0x007314B5 File Offset: 0x0072F6B5
	public ESkillBehaviorComparisonLogic ComparisonLogic { get; set; }

	// Token: 0x170024AF RID: 9391
	// (get) Token: 0x0601AB36 RID: 109366 RVA: 0x007314BE File Offset: 0x0072F6BE
	// (set) Token: 0x0601AB37 RID: 109367 RVA: 0x007314C6 File Offset: 0x0072F6C6
	public float Value { get; set; }

	// Token: 0x170024B0 RID: 9392
	// (get) Token: 0x0601AB38 RID: 109368 RVA: 0x007314CF File Offset: 0x0072F6CF
	// (set) Token: 0x0601AB39 RID: 109369 RVA: 0x007314D7 File Offset: 0x0072F6D7
	public float RangeL { get; set; }

	// Token: 0x170024B1 RID: 9393
	// (get) Token: 0x0601AB3A RID: 109370 RVA: 0x007314E0 File Offset: 0x0072F6E0
	// (set) Token: 0x0601AB3B RID: 109371 RVA: 0x007314E8 File Offset: 0x0072F6E8
	public float RangeR { get; set; }

	// Token: 0x170024B2 RID: 9394
	// (get) Token: 0x0601AB3C RID: 109372 RVA: 0x007314F1 File Offset: 0x0072F6F1
	// (set) Token: 0x0601AB3D RID: 109373 RVA: 0x007314F9 File Offset: 0x0072F6F9
	public EAttributeType AttributeId1 { get; set; }

	// Token: 0x170024B3 RID: 9395
	// (get) Token: 0x0601AB3E RID: 109374 RVA: 0x00731502 File Offset: 0x0072F702
	// (set) Token: 0x0601AB3F RID: 109375 RVA: 0x0073150A File Offset: 0x0072F70A
	public EAttributeType AttributeId2 { get; set; }

	// Token: 0x170024B4 RID: 9396
	// (get) Token: 0x0601AB40 RID: 109376 RVA: 0x00731513 File Offset: 0x0072F713
	// (set) Token: 0x0601AB41 RID: 109377 RVA: 0x0073151B File Offset: 0x0072F71B
	public int AttributeRate { get; set; }

	// Token: 0x170024B5 RID: 9397
	// (get) Token: 0x0601AB42 RID: 109378 RVA: 0x00731524 File Offset: 0x0072F724
	// (set) Token: 0x0601AB43 RID: 109379 RVA: 0x0073152C File Offset: 0x0072F72C
	public IList<int> TagToCheck { get; set; }

	// Token: 0x170024B6 RID: 9398
	// (get) Token: 0x0601AB44 RID: 109380 RVA: 0x00731535 File Offset: 0x0072F735
	// (set) Token: 0x0601AB45 RID: 109381 RVA: 0x0073153D File Offset: 0x0072F73D
	public bool AnyTag { get; set; }

	// Token: 0x170024B7 RID: 9399
	// (get) Token: 0x0601AB46 RID: 109382 RVA: 0x00731546 File Offset: 0x0072F746
	// (set) Token: 0x0601AB47 RID: 109383 RVA: 0x0073154E File Offset: 0x0072F74E
	public bool Reverse { get; set; }

	// Token: 0x0601AB48 RID: 109384 RVA: 0x00731558 File Offset: 0x0072F758
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
