using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020016FA RID: 5882
[NullableContext(1)]
[Nullable(0)]
public class SpecialEnergyBarFeiXue : SpecialEnergyBarBase
{
	// Token: 0x0600A8A9 RID: 43177 RVA: 0x0025EE08 File Offset: 0x0025D008
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUITexture)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem))
		};
	}

	// Token: 0x0600A8AA RID: 43178 RVA: 0x0025F0B2 File Offset: 0x0025D2B2
	protected override void OnInitData()
	{
		this.NormalConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(110802);
		this.MorphConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(110803);
	}

	// Token: 0x0600A8AB RID: 43179 RVA: 0x0025F0E8 File Offset: 0x0025D2E8
	protected override UniTask OnBeforeStartAsync()
	{
		SpecialEnergyBarFeiXue.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarFeiXue.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A8AC RID: 43180 RVA: 0x0025F12C File Offset: 0x0025D32C
	protected UniTask InitBarItem()
	{
		SpecialEnergyBarFeiXue.<InitBarItem>d__24 <InitBarItem>d__;
		<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBarItem>d__.<>4__this = this;
		<InitBarItem>d__.<>1__state = -1;
		<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarFeiXue.<InitBarItem>d__24>(ref <InitBarItem>d__);
		return <InitBarItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A8AD RID: 43181 RVA: 0x0025F170 File Offset: 0x0025D370
	protected UniTask InitKeyItemExtra(UUIItem keyItemContainer)
	{
		SpecialEnergyBarFeiXue.<InitKeyItemExtra>d__25 <InitKeyItemExtra>d__;
		<InitKeyItemExtra>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitKeyItemExtra>d__.<>4__this = this;
		<InitKeyItemExtra>d__.keyItemContainer = keyItemContainer;
		<InitKeyItemExtra>d__.<>1__state = -1;
		<InitKeyItemExtra>d__.<>t__builder.Start<SpecialEnergyBarFeiXue.<InitKeyItemExtra>d__25>(ref <InitKeyItemExtra>d__);
		return <InitKeyItemExtra>d__.<>t__builder.Task;
	}

	// Token: 0x0600A8AE RID: 43182 RVA: 0x0025F1BC File Offset: 0x0025D3BC
	protected override void OnStart()
	{
		base.InitTweenAnim(21);
		base.InitTweenAnim(22);
		base.InitTweenAnim(23);
		base.InitTweenAnim(24);
		base.InitTweenAnim(25);
		base.InitTweenAnim(26);
		base.InitTweenAnim(27);
		base.InitTweenAnim(28);
		if (this.TagComponent != null)
		{
			this.IsMorph = this.TagComponent.HasTag(SpecialEnergyBarFeiXue.MorphTagId);
			this.SwordTagLevel = 0;
			for (int i = SpecialEnergyBarFeiXue.SwordTagIds.Length - 1; i >= 0; i--)
			{
				if (this.TagComponent.HasTag(SpecialEnergyBarFeiXue.SwordTagIds[i]))
				{
					this.SwordTagLevel = i + 1;
					break;
				}
			}
			this.NormalStampTagCount = this.TagComponent.GetTagCount(SpecialEnergyBarFeiXue.StampTagId);
		}
		else
		{
			this.IsMorph = false;
			this.SwordTagLevel = 0;
			this.NormalStampTagCount = 0;
		}
		this.RefreshMorphState(true);
		this.RefreshSwordState(-1, true);
		this.RefreshBarPercent(true);
	}

	// Token: 0x0600A8AF RID: 43183 RVA: 0x0025F2A4 File Offset: 0x0025D4A4
	protected override void AddEvents()
	{
		base.AddEvents();
		base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarFeiXue.MorphTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnMorphTagChange));
		foreach (int tagId in SpecialEnergyBarFeiXue.SwordTagIds)
		{
			base.ListenForTagAddOrRemoveChanged(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSwordTagChange));
		}
		base.ListenForTagCountChanged(SpecialEnergyBarFeiXue.StampTagId, new BaseTagComponent.TTagChangedCallback(this.OnStampTagCountChange));
	}

	// Token: 0x0600A8B0 RID: 43184 RVA: 0x0025F310 File Offset: 0x0025D510
	private void OnNormalFullStateChanged(bool isFull)
	{
		if (isFull)
		{
			base.StopTweenAnim(22);
			base.PlayTweenAnim(21);
			return;
		}
		base.StopTweenAnim(21);
		base.PlayTweenAnim(22);
	}

	// Token: 0x0600A8B1 RID: 43185 RVA: 0x0025F336 File Offset: 0x0025D536
	private void OnMorphTagChange(int tagId, bool tagExist)
	{
		if (this.IsMorph == tagExist)
		{
			return;
		}
		this.IsMorph = tagExist;
		this.RefreshMorphState(false);
	}

	// Token: 0x0600A8B2 RID: 43186 RVA: 0x0025F350 File Offset: 0x0025D550
	private void OnSwordTagChange(int tagId, bool tagExist)
	{
		int num = 0;
		for (int i = SpecialEnergyBarFeiXue.SwordTagIds.Length - 1; i >= 0; i--)
		{
			if (this.TagComponent.HasTag(SpecialEnergyBarFeiXue.SwordTagIds[i]))
			{
				num = i + 1;
				break;
			}
		}
		if (num == this.SwordTagLevel)
		{
			return;
		}
		int swordTagLevel = this.SwordTagLevel;
		this.SwordTagLevel = num;
		this.RefreshSwordState(swordTagLevel, false);
	}

	// Token: 0x0600A8B3 RID: 43187 RVA: 0x0025F3AD File Offset: 0x0025D5AD
	private void OnStampTagCountChange(int count, int tagId, int exactTagId, int oldCount)
	{
		if (this.NormalStampTagCount == count)
		{
			return;
		}
		this.NormalStampTagCount = count;
		this.StampStateDirty = true;
	}

	// Token: 0x0600A8B4 RID: 43188 RVA: 0x0025F3C7 File Offset: 0x0025D5C7
	protected override void OnBarPercentChanged()
	{
		this.RefreshBarPercent(false);
	}

	// Token: 0x0600A8B5 RID: 43189 RVA: 0x0025F3D0 File Offset: 0x0025D5D0
	private void RefreshBarPercent(bool isStart = false)
	{
		float curPercent = this.PercentMachine.GetCurPercent();
		base.GetSprite(10).SetFillAmount(curPercent);
		float inYaw = -8.85f + 17.7f * curPercent;
		UUIItem item = base.GetItem(17);
		FRotator frotator = new FRotator(0f, inYaw, 0f);
		item.SetUIRelativeRotation(frotator);
		item.SetUIActive(curPercent > 0f && curPercent < 1f);
		int num = (int)Math.Floor((double)(curPercent * 3f));
		if (this.TotalStampTagCount != num || isStart)
		{
			this.TotalStampTagCount = num;
			this.StampStateDirty = true;
		}
		this.RefreshKeyEnable(isStart);
	}

	// Token: 0x0600A8B6 RID: 43190 RVA: 0x0025F472 File Offset: 0x0025D672
	protected override void OnKeyEnableChanged()
	{
		this.RefreshKeyEnable(false);
	}

	// Token: 0x0600A8B7 RID: 43191 RVA: 0x0025F47C File Offset: 0x0025D67C
	private void RefreshKeyEnable(bool isStart = false)
	{
		bool keyEnable = this.GetKeyEnable();
		SpecialEnergyBarKeyItem keyItem = this.KeyItem;
		if (keyItem == null)
		{
			return;
		}
		keyItem.RefreshKeyEnable(keyEnable, isStart);
	}

	// Token: 0x0600A8B8 RID: 43192 RVA: 0x0025F4A2 File Offset: 0x0025D6A2
	private void RefreshMorphState(bool isStart = false)
	{
		base.GetItem(0).SetUIActive(!this.IsMorph);
		base.GetItem(4).SetUIActive(this.IsMorph);
	}

	// Token: 0x0600A8B9 RID: 43193 RVA: 0x0025F4CC File Offset: 0x0025D6CC
	private void RefreshSwordState(int lastSwordTagLevel, bool isStart = false)
	{
		bool flag = this.SwordTagLevel >= 3;
		if (this.IsMaxSwordTagLevel != flag || isStart)
		{
			this.IsMaxSwordTagLevel = flag;
			base.GetItem(18).SetUIActive(!flag);
			base.GetItem(19).SetUIActive(flag);
			if (flag)
			{
				base.GetTexture(20).SetCustomMaterialScalarParameter(this.NameFlntensity, 0.3f);
				base.GetItem(5).SetUIActive(true);
				base.StopTweenAnim(28);
				base.PlayTweenAnim(27);
			}
			else
			{
				base.GetTexture(20).SetCustomMaterialScalarParameter(this.NameFlntensity, 0f);
				if (isStart)
				{
					base.GetItem(5).SetUIActive(false);
				}
				base.StopTweenAnim(27);
				base.PlayTweenAnim(28);
			}
		}
		if (this.LastSwordTagAnim >= 0)
		{
			base.StopTweenAnim(this.LastSwordTagAnim);
		}
		if (isStart)
		{
			base.GetItem(7).SetUIActive(this.SwordTagLevel == 1);
			base.GetItem(8).SetUIActive(this.SwordTagLevel == 2);
			base.GetItem(9).SetUIActive(this.SwordTagLevel == 3);
			base.GetItem(11).SetUIActive(this.SwordTagLevel == 3);
		}
		else
		{
			base.GetItem(7).SetUIActive(this.SwordTagLevel == 1 || this.SwordTagLevel == 2);
			base.GetItem(8).SetUIActive(this.SwordTagLevel == 2 || this.SwordTagLevel == 3);
			base.GetItem(9).SetUIActive(this.SwordTagLevel == 3 || this.SwordTagLevel == 0);
			base.GetItem(11).SetUIActive(this.SwordTagLevel == 3 || this.SwordTagLevel == 0);
		}
		this.LastSwordTagAnim = (int)SpecialEnergyBarFeiXue.SwordAnimList[this.SwordTagLevel];
		if (this.LastSwordTagAnim >= 0)
		{
			base.PlayTweenAnim(this.LastSwordTagAnim);
		}
	}

	// Token: 0x0600A8BA RID: 43194 RVA: 0x0025F6B4 File Offset: 0x0025D8B4
	private void RefreshStampState()
	{
		int num = Math.Max(0, this.TotalStampTagCount - this.NormalStampTagCount);
		int num2 = this.TotalStampTagCount - num;
		for (int i = 0; i < num; i++)
		{
			this.StampItemList[i].SetState(1, false);
		}
		for (int j = num; j < this.TotalStampTagCount; j++)
		{
			this.StampItemList[j].SetState(2, this.LastNormalStampCount == num2);
		}
		for (int k = this.TotalStampTagCount; k < this.StampItemList.Count; k++)
		{
			this.StampItemList[k].SetState(0, false);
		}
		this.LastNormalStampCount = num2;
	}

	// Token: 0x0600A8BB RID: 43195 RVA: 0x0025F763 File Offset: 0x0025D963
	public override void Tick(float delta)
	{
		base.Tick(delta);
		SpecialEnergyBarFeiXueSlot barItemNormal = this.BarItemNormal;
		if (barItemNormal != null)
		{
			barItemNormal.Tick(delta);
		}
		if (this.StampStateDirty)
		{
			this.RefreshStampState();
			this.StampStateDirty = false;
		}
	}

	// Token: 0x04004CF1 RID: 19697
	private const int NormalConfigId = 110802;

	// Token: 0x04004CF2 RID: 19698
	private const int MorphConfigId = 110803;

	// Token: 0x04004CF3 RID: 19699
	private static readonly int MorphTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.状态标识.神刀解放"];

	// Token: 0x04004CF4 RID: 19700
	[StaticVariableRuleIgnore]
	private static readonly int[] SwordTagIds = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.1层印记"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.2层印记"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.3层印记"]
	};

	// Token: 0x04004CF5 RID: 19701
	private static readonly int StampTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.居合叠层"];

	// Token: 0x04004CF6 RID: 19702
	[StaticVariableRuleIgnore]
	private static readonly SpecialEnergyBarFeiXue.EChildType[] SwordAnimList = new SpecialEnergyBarFeiXue.EChildType[]
	{
		SpecialEnergyBarFeiXue.EChildType.AnimSwordN,
		SpecialEnergyBarFeiXue.EChildType.AnimSwordA,
		SpecialEnergyBarFeiXue.EChildType.AnimSwordB,
		SpecialEnergyBarFeiXue.EChildType.AnimSwordC
	};

	// Token: 0x04004CF7 RID: 19703
	[Nullable(2)]
	private SpecialEnergyBarInfo NormalConfig;

	// Token: 0x04004CF8 RID: 19704
	[Nullable(2)]
	private SpecialEnergyBarInfo MorphConfig;

	// Token: 0x04004CF9 RID: 19705
	[Nullable(2)]
	private SpecialEnergyBarFeiXueSlot BarItemNormal;

	// Token: 0x04004CFA RID: 19706
	[Nullable(2)]
	private SpecialEnergyBarKeyItem ExtraKeyItem;

	// Token: 0x04004CFB RID: 19707
	private bool IsMorph;

	// Token: 0x04004CFC RID: 19708
	private int SwordTagLevel;

	// Token: 0x04004CFD RID: 19709
	private bool IsMaxSwordTagLevel;

	// Token: 0x04004CFE RID: 19710
	private int LastSwordTagAnim = -1;

	// Token: 0x04004CFF RID: 19711
	private int NormalStampTagCount;

	// Token: 0x04004D00 RID: 19712
	private int LastNormalStampCount;

	// Token: 0x04004D01 RID: 19713
	private int TotalStampTagCount;

	// Token: 0x04004D02 RID: 19714
	private readonly List<SpecialEnergyBarFeiXueStampItem> StampItemList = new List<SpecialEnergyBarFeiXueStampItem>();

	// Token: 0x04004D03 RID: 19715
	private readonly FName NameFlntensity = FNameUtil.GetDynamicFName("Flntensity").Value;

	// Token: 0x04004D04 RID: 19716
	private bool StampStateDirty;

	// Token: 0x02007CB9 RID: 31929
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028E88 RID: 167560
		NormalItem,
		// Token: 0x04028E89 RID: 167561
		NormalBgItem,
		// Token: 0x04028E8A RID: 167562
		NormalFullBgItem,
		// Token: 0x04028E8B RID: 167563
		NormalSlotBarItem,
		// Token: 0x04028E8C RID: 167564
		MorphItem,
		// Token: 0x04028E8D RID: 167565
		MorphDotItem,
		// Token: 0x04028E8E RID: 167566
		MorphBgItemEmpty,
		// Token: 0x04028E8F RID: 167567
		MorphBgItemStack1,
		// Token: 0x04028E90 RID: 167568
		MorphBgItemStack2,
		// Token: 0x04028E91 RID: 167569
		MorphBgItemStack3,
		// Token: 0x04028E92 RID: 167570
		MorphBarSprite,
		// Token: 0x04028E93 RID: 167571
		MorphPetalItem,
		// Token: 0x04028E94 RID: 167572
		MorphStampItemContainer,
		// Token: 0x04028E95 RID: 167573
		MorphStampItem1,
		// Token: 0x04028E96 RID: 167574
		MorphStampItem2,
		// Token: 0x04028E97 RID: 167575
		MorphStampItem3,
		// Token: 0x04028E98 RID: 167576
		MorphPingItem,
		// Token: 0x04028E99 RID: 167577
		MorphRotaItem,
		// Token: 0x04028E9A RID: 167578
		KeyItem,
		// Token: 0x04028E9B RID: 167579
		KeyItemExtra,
		// Token: 0x04028E9C RID: 167580
		TexPattern,
		// Token: 0x04028E9D RID: 167581
		AnimArrowGlow,
		// Token: 0x04028E9E RID: 167582
		AnimArrowRes,
		// Token: 0x04028E9F RID: 167583
		AnimSwordA,
		// Token: 0x04028EA0 RID: 167584
		AnimSwordB,
		// Token: 0x04028EA1 RID: 167585
		AnimSwordC,
		// Token: 0x04028EA2 RID: 167586
		AnimSwordN,
		// Token: 0x04028EA3 RID: 167587
		AnimPdGlow,
		// Token: 0x04028EA4 RID: 167588
		AnimPdNum
	}
}
