using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DAD RID: 19885
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarAiMiSi : SpecialEnergyBarBase
	{
		// Token: 0x06031F9E RID: 204702 RVA: 0x00DFC548 File Offset: 0x00DFA748
		protected unsafe override void OnRegisterComponent()
		{
			int num = 26;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031F9F RID: 204703 RVA: 0x00DFC8DB File Offset: 0x00DFAADB
		protected override void OnInitData()
		{
			this.SubConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(121001);
			this.MaxAttributeId = (EAttributeType)this.SubConfig.MaxAttributeId;
			this.AttributeId = (EAttributeType)this.SubConfig.AttributeId;
		}

		// Token: 0x06031FA0 RID: 204704 RVA: 0x00DFC91C File Offset: 0x00DFAB1C
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(this.SubConfig.KeyEnableTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSubTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarAiMiSi.modeTag, new BaseTagComponent.TTagSwitchedCallback(this.OnModeTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarAiMiSi.burstTag, new BaseTagComponent.TTagSwitchedCallback(this.OnBurstTagChange));
		}

		// Token: 0x06031FA1 RID: 204705 RVA: 0x00DFC97A File Offset: 0x00DFAB7A
		private void OnSubTagChange(int tagId, bool tagExist)
		{
			this.ShowSubBar = tagExist;
			this.RefreshSubBar();
		}

		// Token: 0x06031FA2 RID: 204706 RVA: 0x00DFC989 File Offset: 0x00DFAB89
		private void OnModeTagChange(int tagId, bool tagExist)
		{
			this.ModeOneTag = tagExist;
			this.RefreshEffectColor();
		}

		// Token: 0x06031FA3 RID: 204707 RVA: 0x00DFC998 File Offset: 0x00DFAB98
		private void OnBurstTagChange(int tagId, bool tagExist)
		{
			if (this.BurstTag == tagExist)
			{
				return;
			}
			this.BurstTag = tagExist;
			this.RefreshBurstState();
		}

		// Token: 0x06031FA4 RID: 204708 RVA: 0x00DFC9B4 File Offset: 0x00DFABB4
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarAiMiSi.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarAiMiSi.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031FA5 RID: 204709 RVA: 0x00DFC9F8 File Offset: 0x00DFABF8
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarAiMiSi.<InitBarItem>d__27 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarAiMiSi.<InitBarItem>d__27>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031FA6 RID: 204710 RVA: 0x00DFCA3C File Offset: 0x00DFAC3C
		[NullableContext(1)]
		protected override UniTask InitKeyItem(UUIItem keyItemContainer)
		{
			SpecialEnergyBarAiMiSi.<InitKeyItem>d__28 <InitKeyItem>d__;
			<InitKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitKeyItem>d__.<>4__this = this;
			<InitKeyItem>d__.keyItemContainer = keyItemContainer;
			<InitKeyItem>d__.<>1__state = -1;
			<InitKeyItem>d__.<>t__builder.Start<SpecialEnergyBarAiMiSi.<InitKeyItem>d__28>(ref <InitKeyItem>d__);
			return <InitKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031FA7 RID: 204711 RVA: 0x00DFCA88 File Offset: 0x00DFAC88
		protected override void OnStart()
		{
			for (SpecialEnergyBarAiMiSi.EChildType echildType = SpecialEnergyBarAiMiSi.EChildType.AniDefault; echildType <= SpecialEnergyBarAiMiSi.EChildType.AniStarReset; echildType++)
			{
				base.InitTweenAnim((int)echildType);
			}
			this.TexStarBgList.Clear();
			this.StarItemList.Clear();
			for (int i = 0; i < 4; i++)
			{
				this.TexStarBgList.Add(base.GetTexture(17 + i));
				this.StarItemList.Add(base.GetItem(21 + i));
			}
			base.PlayTweenAnim(4);
			this.TexProgress = base.GetTexture(3);
			this.RefreshState(true);
			this.RefreshBuffPercent(true);
			this.RefreshStar(true);
		}

		// Token: 0x06031FA8 RID: 204712 RVA: 0x00DFCB1E File Offset: 0x00DFAD1E
		protected override void OnBeforeDestroy()
		{
			this.StopDelayResetStar();
			base.OnBeforeDestroy();
		}

		// Token: 0x06031FA9 RID: 204713 RVA: 0x00DFCB2C File Offset: 0x00DFAD2C
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(13);
			base.ClearAllTweenAnim();
		}

		// Token: 0x06031FAA RID: 204714 RVA: 0x00DFCB3C File Offset: 0x00DFAD3C
		private void RefreshBuffPercent(bool isStart = false)
		{
			if (this.TexProgress == null)
			{
				return;
			}
			float num = 0f;
			bool bPlay = false;
			if (this.ShowSubBar)
			{
				if (this.Buff != null)
				{
					CharacterBuffComponent buffComponent = this.BuffComponent;
					if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
					{
						goto IL_41;
					}
				}
				this.RefreshBuff();
				IL_41:
				if (this.Buff != null)
				{
					num = this.Buff.GetRemainDuration() / this.Buff.Duration;
					bPlay = (this.Buff.GetRemainDuration() < this.SubConfig.ExtraFloatParams[0]);
				}
			}
			this.PlayWarnAnim(bPlay);
			if (num == this.SubBarPercent && !isStart)
			{
				return;
			}
			this.SubBarPercent = num;
			this.TexProgress.SetFillAmount(num);
		}

		// Token: 0x06031FAB RID: 204715 RVA: 0x00DFCBF0 File Offset: 0x00DFADF0
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(13);
				return;
			}
			base.StopTweenAnim(13);
			base.PlayTweenAnim(14);
		}

		// Token: 0x06031FAC RID: 204716 RVA: 0x00DFCC20 File Offset: 0x00DFAE20
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			this.ShowSubBar = (tagComponent != null && tagComponent.HasTag(this.SubConfig.KeyEnableTagId));
			BaseTagComponent tagComponent2 = this.TagComponent;
			this.ModeOneTag = (tagComponent2 != null && tagComponent2.HasTag(SpecialEnergyBarAiMiSi.modeTag));
			BaseTagComponent tagComponent3 = this.TagComponent;
			this.BurstTag = (tagComponent3 != null && tagComponent3.HasTag(SpecialEnergyBarAiMiSi.burstTag));
			this.RefreshSubBar();
			this.RefreshEffectColor();
			this.RefreshBurstState();
		}

		// Token: 0x06031FAD RID: 204717 RVA: 0x00DFCC9C File Offset: 0x00DFAE9C
		private void RefreshSubBar()
		{
			this.Buff = null;
			if (this.ShowSubBar)
			{
				base.StopTweenAnim(12);
				base.StopTweenAnim(15);
				base.PlayTweenAnim(11);
				return;
			}
			base.StopTweenAnim(11);
			if (this.IsPlayBurstAnim)
			{
				this.IsPlayBurstAnim = false;
				base.StopTweenAnim(10);
				base.PlayTweenAnim(15);
				base.PlayTweenAnim(12);
				return;
			}
			base.PlayTweenAnim(12);
		}

		// Token: 0x06031FAE RID: 204718 RVA: 0x00DFCD09 File Offset: 0x00DFAF09
		private void RefreshEffectColor()
		{
			SpecialEnergyBarAiMiSiSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal == null)
			{
				return;
			}
			barItemNormal.SetBarColor((!this.ModeOneTag) ? 1 : 0);
		}

		// Token: 0x06031FAF RID: 204719 RVA: 0x00DFCD24 File Offset: 0x00DFAF24
		private void RefreshBurstState()
		{
			if (this.BurstTag)
			{
				this.IsPlayBurstAnim = true;
				base.PlayTweenAnim(10);
			}
			UUIItem item = base.GetItem(25);
			if (item != null)
			{
				item.SetUIActive(this.BurstTag);
			}
			SpecialEnergyBarAiMiSiSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal == null)
			{
				return;
			}
			barItemNormal.SetKeyVisible(!this.BurstTag);
		}

		// Token: 0x06031FB0 RID: 204720 RVA: 0x00DFCD7C File Offset: 0x00DFAF7C
		private void RefreshStar(bool isStart = false)
		{
			int num = (int)MathF.Round(this.PercentMachine.GetTargetPercent() * 4f);
			if (this.StarNum == num && !isStart)
			{
				return;
			}
			if (num <= 0)
			{
				if (isStart)
				{
					this.ResetStarImmediately();
				}
				else
				{
					if (this.StarNum >= 4 && this.IsPlayBurstAnim)
					{
						base.PlayTweenAnim(5);
					}
					else
					{
						base.PlayTweenAnim(16);
					}
					this.IsPlayAniStarReset = true;
					this.DelayResetStar();
				}
			}
			else if (num > this.StarNum)
			{
				if (this.IsPlayAniStarReset)
				{
					this.IsPlayAniStarReset = false;
					base.StopTweenAnim(16);
				}
				if (this.StarNum <= 0)
				{
					this.ResetStarImmediately();
				}
				for (int i = this.StarNum; i < num; i++)
				{
					base.PlayTweenAnim(6 + i);
				}
			}
			else
			{
				this.ResetStarImmediately();
				for (int j = 0; j < num; j++)
				{
					base.PlayTweenAnim(6 + j);
				}
			}
			this.StarNum = num;
		}

		// Token: 0x06031FB1 RID: 204721 RVA: 0x00DFCE5E File Offset: 0x00DFB05E
		private void DelayResetStar()
		{
			this.StopDelayResetStar();
			this.DelayResetStarTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ResetStar();
				this.DelayResetStarTimer = null;
			}, 250f, null, null, true, 1f);
		}

		// Token: 0x06031FB2 RID: 204722 RVA: 0x00DFCE8F File Offset: 0x00DFB08F
		private void StopDelayResetStar()
		{
			if (this.DelayResetStarTimer != null)
			{
				if (TimerSystem.Instance.Has(this.DelayResetStarTimer))
				{
					TimerSystem.Instance.Remove(this.DelayResetStarTimer);
				}
				this.DelayResetStarTimer = null;
			}
		}

		// Token: 0x06031FB3 RID: 204723 RVA: 0x00DFCEC3 File Offset: 0x00DFB0C3
		private void ResetStarImmediately()
		{
			this.StopDelayResetStar();
			this.ResetStar();
		}

		// Token: 0x06031FB4 RID: 204724 RVA: 0x00DFCED4 File Offset: 0x00DFB0D4
		private void ResetStar()
		{
			foreach (UUIItem uuiitem in this.StarItemList)
			{
				uuiitem.SetUIActive(false);
			}
			foreach (UUITexture uuitexture in this.TexStarBgList)
			{
				uuitexture.SetAlpha(1f);
			}
		}

		// Token: 0x06031FB5 RID: 204725 RVA: 0x00DFCF6C File Offset: 0x00DFB16C
		protected override void OnBarPercentChanged()
		{
			this.RefreshStar(false);
		}

		// Token: 0x06031FB6 RID: 204726 RVA: 0x00DFCF75 File Offset: 0x00DFB175
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarAiMiSiSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal != null)
			{
				barItemNormal.Tick(delta);
			}
			this.RefreshBuffPercent(false);
		}

		// Token: 0x06031FB7 RID: 204727 RVA: 0x00DFCF98 File Offset: 0x00DFB198
		private void RefreshBuff()
		{
			SpecialEnergyBarInfo subConfig = this.SubConfig;
			bool flag;
			if (subConfig == null)
			{
				flag = false;
			}
			else
			{
				long buffId = subConfig.BuffId;
				flag = true;
			}
			if (flag)
			{
				if (this.Buff == null)
				{
					CharacterBuffComponent buffComponent = this.BuffComponent;
					this.Buff = ((buffComponent != null) ? buffComponent.GetBuffById(this.SubConfig.BuffId) : null);
				}
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x0401A749 RID: 108361
		private const int SUB_CONFIG_ID = 121001;

		// Token: 0x0401A74A RID: 108362
		[StaticVariableRuleIgnore]
		private static readonly int modeTag = GameplayTagDefine.EGameplayTagId["角色.Common.双模式.模式1"];

		// Token: 0x0401A74B RID: 108363
		[StaticVariableRuleIgnore]
		private static readonly int burstTag = GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.炮大招激活"];

		// Token: 0x0401A74C RID: 108364
		private SpecialEnergyBarInfo SubConfig;

		// Token: 0x0401A74D RID: 108365
		private SpecialEnergyBarAiMiSiSlot BarItemNormal;

		// Token: 0x0401A74E RID: 108366
		private IActiveBuff Buff;

		// Token: 0x0401A74F RID: 108367
		private int BuffHandle;

		// Token: 0x0401A750 RID: 108368
		private bool ShowSubBar;

		// Token: 0x0401A751 RID: 108369
		private float SubBarPercent = -1f;

		// Token: 0x0401A752 RID: 108370
		private UUITexture TexProgress;

		// Token: 0x0401A753 RID: 108371
		private bool IsPlayWarnAnim;

		// Token: 0x0401A754 RID: 108372
		private int StarNum;

		// Token: 0x0401A755 RID: 108373
		private bool ModeOneTag;

		// Token: 0x0401A756 RID: 108374
		private bool BurstTag;

		// Token: 0x0401A757 RID: 108375
		private bool IsPlayBurstAnim;

		// Token: 0x0401A758 RID: 108376
		[Nullable(1)]
		private readonly List<UUITexture> TexStarBgList = new List<UUITexture>();

		// Token: 0x0401A759 RID: 108377
		[Nullable(1)]
		private readonly List<UUIItem> StarItemList = new List<UUIItem>();

		// Token: 0x0401A75A RID: 108378
		private bool IsPlayAniStarReset;

		// Token: 0x0401A75B RID: 108379
		private TimerHandle DelayResetStarTimer;

		// Token: 0x0200AADA RID: 43738
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034C9C RID: 216220
			SlotBarItemNormal,
			// Token: 0x04034C9D RID: 216221
			NormalItem,
			// Token: 0x04034C9E RID: 216222
			MorphItem,
			// Token: 0x04034C9F RID: 216223
			TexProgress,
			// Token: 0x04034CA0 RID: 216224
			AniDefault,
			// Token: 0x04034CA1 RID: 216225
			AniCharge0,
			// Token: 0x04034CA2 RID: 216226
			AniCharge1,
			// Token: 0x04034CA3 RID: 216227
			AniCharge2,
			// Token: 0x04034CA4 RID: 216228
			AniCharge3,
			// Token: 0x04034CA5 RID: 216229
			AniCharge4,
			// Token: 0x04034CA6 RID: 216230
			AniBurst,
			// Token: 0x04034CA7 RID: 216231
			AniMorphIn,
			// Token: 0x04034CA8 RID: 216232
			AniMorphOut,
			// Token: 0x04034CA9 RID: 216233
			AniWarning,
			// Token: 0x04034CAA RID: 216234
			AniWarningReset,
			// Token: 0x04034CAB RID: 216235
			AniMorphBurstOut,
			// Token: 0x04034CAC RID: 216236
			AniStarReset,
			// Token: 0x04034CAD RID: 216237
			TexStarBg1,
			// Token: 0x04034CAE RID: 216238
			TexStarBg2,
			// Token: 0x04034CAF RID: 216239
			TexStarBg3,
			// Token: 0x04034CB0 RID: 216240
			TexStarBg4,
			// Token: 0x04034CB1 RID: 216241
			StarItem1,
			// Token: 0x04034CB2 RID: 216242
			StarItem2,
			// Token: 0x04034CB3 RID: 216243
			StarItem3,
			// Token: 0x04034CB4 RID: 216244
			StarItem4,
			// Token: 0x04034CB5 RID: 216245
			KeyNode
		}
	}
}
