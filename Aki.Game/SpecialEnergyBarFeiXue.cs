using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000BB2 RID: 2994
[NullableContext(1)]
[Nullable(0)]
public class SpecialEnergyBarFeiXue : SpecialEnergyBarBase
{
	// Token: 0x06007C89 RID: 31881 RVA: 0x00269224 File Offset: 0x00267424
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

	// Token: 0x06007C8A RID: 31882 RVA: 0x002694CE File Offset: 0x002676CE
	protected override void OnInitData()
	{
		this.NormalConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(110802);
		this.MorphConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(110803);
	}

	// Token: 0x06007C8B RID: 31883 RVA: 0x00269504 File Offset: 0x00267704
	protected override UniTask OnBeforeStartAsync()
	{
		SpecialEnergyBarFeiXue.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarFeiXue.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007C8C RID: 31884 RVA: 0x00269548 File Offset: 0x00267748
	protected UniTask InitBarItem()
	{
		SpecialEnergyBarFeiXue.<InitBarItem>d__24 <InitBarItem>d__;
		<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBarItem>d__.<>4__this = this;
		<InitBarItem>d__.<>1__state = -1;
		<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarFeiXue.<InitBarItem>d__24>(ref <InitBarItem>d__);
		return <InitBarItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007C8D RID: 31885 RVA: 0x0026958C File Offset: 0x0026778C
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

	// Token: 0x06007C8E RID: 31886 RVA: 0x002695D8 File Offset: 0x002677D8
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

	// Token: 0x06007C8F RID: 31887 RVA: 0x002696C0 File Offset: 0x002678C0
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

	// Token: 0x06007C90 RID: 31888 RVA: 0x0026972C File Offset: 0x0026792C
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

	// Token: 0x06007C91 RID: 31889 RVA: 0x00269752 File Offset: 0x00267952
	private void OnMorphTagChange(int tagId, bool tagExist)
	{
		if (this.IsMorph == tagExist)
		{
			return;
		}
		this.IsMorph = tagExist;
		this.RefreshMorphState(false);
	}

	// Token: 0x06007C92 RID: 31890 RVA: 0x0026976C File Offset: 0x0026796C
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

	// Token: 0x06007C93 RID: 31891 RVA: 0x002697C9 File Offset: 0x002679C9
	private void OnStampTagCountChange(int count, int tagId, int exactTagId, int oldCount)
	{
		if (this.NormalStampTagCount == count)
		{
			return;
		}
		this.NormalStampTagCount = count;
		this.StampStateDirty = true;
	}

	// Token: 0x06007C94 RID: 31892 RVA: 0x002697E3 File Offset: 0x002679E3
	protected override void OnBarPercentChanged()
	{
		this.RefreshBarPercent(false);
	}

	// Token: 0x06007C95 RID: 31893 RVA: 0x002697EC File Offset: 0x002679EC
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

	// Token: 0x06007C96 RID: 31894 RVA: 0x0026988E File Offset: 0x00267A8E
	protected override void OnKeyEnableChanged()
	{
		this.RefreshKeyEnable(false);
	}

	// Token: 0x06007C97 RID: 31895 RVA: 0x00269898 File Offset: 0x00267A98
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

	// Token: 0x06007C98 RID: 31896 RVA: 0x002698BE File Offset: 0x00267ABE
	private void RefreshMorphState(bool isStart = false)
	{
		base.GetItem(0).SetUIActive(!this.IsMorph);
		base.GetItem(4).SetUIActive(this.IsMorph);
	}

	// Token: 0x06007C99 RID: 31897 RVA: 0x002698E8 File Offset: 0x00267AE8
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

	// Token: 0x06007C9A RID: 31898 RVA: 0x00269AD0 File Offset: 0x00267CD0
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

	// Token: 0x06007C9B RID: 31899 RVA: 0x00269B7F File Offset: 0x00267D7F
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

	// Token: 0x04004D98 RID: 19864
	private const int NormalConfigId = 110802;

	// Token: 0x04004D99 RID: 19865
	private const int MorphConfigId = 110803;

	// Token: 0x04004D9A RID: 19866
	private static readonly int MorphTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.状态标识.神刀解放"];

	// Token: 0x04004D9B RID: 19867
	[StaticVariableRuleIgnore]
	private static readonly int[] SwordTagIds = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.1层印记"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.2层印记"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.3层印记"]
	};

	// Token: 0x04004D9C RID: 19868
	private static readonly int StampTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.居合叠层"];

	// Token: 0x04004D9D RID: 19869
	[StaticVariableRuleIgnore]
	private static readonly SpecialEnergyBarFeiXue.EChildType[] SwordAnimList = new SpecialEnergyBarFeiXue.EChildType[]
	{
		SpecialEnergyBarFeiXue.EChildType.AnimSwordN,
		SpecialEnergyBarFeiXue.EChildType.AnimSwordA,
		SpecialEnergyBarFeiXue.EChildType.AnimSwordB,
		SpecialEnergyBarFeiXue.EChildType.AnimSwordC
	};

	// Token: 0x04004D9E RID: 19870
	[Nullable(2)]
	private SpecialEnergyBarInfo NormalConfig;

	// Token: 0x04004D9F RID: 19871
	[Nullable(2)]
	private SpecialEnergyBarInfo MorphConfig;

	// Token: 0x04004DA0 RID: 19872
	[Nullable(2)]
	private SpecialEnergyBarFeiXueSlot BarItemNormal;

	// Token: 0x04004DA1 RID: 19873
	[Nullable(2)]
	private SpecialEnergyBarKeyItem ExtraKeyItem;

	// Token: 0x04004DA2 RID: 19874
	private bool IsMorph;

	// Token: 0x04004DA3 RID: 19875
	private int SwordTagLevel;

	// Token: 0x04004DA4 RID: 19876
	private bool IsMaxSwordTagLevel;

	// Token: 0x04004DA5 RID: 19877
	private int LastSwordTagAnim = -1;

	// Token: 0x04004DA6 RID: 19878
	private int NormalStampTagCount;

	// Token: 0x04004DA7 RID: 19879
	private int LastNormalStampCount;

	// Token: 0x04004DA8 RID: 19880
	private int TotalStampTagCount;

	// Token: 0x04004DA9 RID: 19881
	private readonly List<SpecialEnergyBarFeiXueStampItem> StampItemList = new List<SpecialEnergyBarFeiXueStampItem>();

	// Token: 0x04004DAA RID: 19882
	private readonly FName NameFlntensity = FNameUtil.GetDynamicFName("Flntensity").Value;

	// Token: 0x04004DAB RID: 19883
	private bool StampStateDirty;

	// Token: 0x02006E3E RID: 28222
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040241B1 RID: 147889
		NormalItem,
		// Token: 0x040241B2 RID: 147890
		NormalBgItem,
		// Token: 0x040241B3 RID: 147891
		NormalFullBgItem,
		// Token: 0x040241B4 RID: 147892
		NormalSlotBarItem,
		// Token: 0x040241B5 RID: 147893
		MorphItem,
		// Token: 0x040241B6 RID: 147894
		MorphDotItem,
		// Token: 0x040241B7 RID: 147895
		MorphBgItemEmpty,
		// Token: 0x040241B8 RID: 147896
		MorphBgItemStack1,
		// Token: 0x040241B9 RID: 147897
		MorphBgItemStack2,
		// Token: 0x040241BA RID: 147898
		MorphBgItemStack3,
		// Token: 0x040241BB RID: 147899
		MorphBarSprite,
		// Token: 0x040241BC RID: 147900
		MorphPetalItem,
		// Token: 0x040241BD RID: 147901
		MorphStampItemContainer,
		// Token: 0x040241BE RID: 147902
		MorphStampItem1,
		// Token: 0x040241BF RID: 147903
		MorphStampItem2,
		// Token: 0x040241C0 RID: 147904
		MorphStampItem3,
		// Token: 0x040241C1 RID: 147905
		MorphPingItem,
		// Token: 0x040241C2 RID: 147906
		MorphRotaItem,
		// Token: 0x040241C3 RID: 147907
		KeyItem,
		// Token: 0x040241C4 RID: 147908
		KeyItemExtra,
		// Token: 0x040241C5 RID: 147909
		TexPattern,
		// Token: 0x040241C6 RID: 147910
		AnimArrowGlow,
		// Token: 0x040241C7 RID: 147911
		AnimArrowRes,
		// Token: 0x040241C8 RID: 147912
		AnimSwordA,
		// Token: 0x040241C9 RID: 147913
		AnimSwordB,
		// Token: 0x040241CA RID: 147914
		AnimSwordC,
		// Token: 0x040241CB RID: 147915
		AnimSwordN,
		// Token: 0x040241CC RID: 147916
		AnimPdGlow,
		// Token: 0x040241CD RID: 147917
		AnimPdNum
	}
}
