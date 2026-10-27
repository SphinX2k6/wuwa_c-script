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
	// Token: 0x02005DC9 RID: 24009
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarAiMiSi : SpecialEnergyBarBase
	{
		// Token: 0x0603D027 RID: 249895 RVA: 0x00EAB654 File Offset: 0x00EA9854
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

		// Token: 0x0603D028 RID: 249896 RVA: 0x00EAB9E7 File Offset: 0x00EA9BE7
		protected override void OnInitData()
		{
			this.SubConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(121001);
			this.MaxAttributeId = (EAttributeType)this.SubConfig.MaxAttributeId;
			this.AttributeId = (EAttributeType)this.SubConfig.AttributeId;
		}

		// Token: 0x0603D029 RID: 249897 RVA: 0x00EABA28 File Offset: 0x00EA9C28
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(this.SubConfig.KeyEnableTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSubTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarAiMiSi.modeTag, new BaseTagComponent.TTagSwitchedCallback(this.OnModeTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarAiMiSi.burstTag, new BaseTagComponent.TTagSwitchedCallback(this.OnBurstTagChange));
		}

		// Token: 0x0603D02A RID: 249898 RVA: 0x00EABA86 File Offset: 0x00EA9C86
		private void OnSubTagChange(int tagId, bool tagExist)
		{
			this.ShowSubBar = tagExist;
			this.RefreshSubBar();
		}

		// Token: 0x0603D02B RID: 249899 RVA: 0x00EABA95 File Offset: 0x00EA9C95
		private void OnModeTagChange(int tagId, bool tagExist)
		{
			this.ModeOneTag = tagExist;
			this.RefreshEffectColor();
		}

		// Token: 0x0603D02C RID: 249900 RVA: 0x00EABAA4 File Offset: 0x00EA9CA4
		private void OnBurstTagChange(int tagId, bool tagExist)
		{
			if (this.BurstTag == tagExist)
			{
				return;
			}
			this.BurstTag = tagExist;
			this.RefreshBurstState();
		}

		// Token: 0x0603D02D RID: 249901 RVA: 0x00EABAC0 File Offset: 0x00EA9CC0
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarAiMiSi.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarAiMiSi.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D02E RID: 249902 RVA: 0x00EABB04 File Offset: 0x00EA9D04
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarAiMiSi.<InitBarItem>d__27 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarAiMiSi.<InitBarItem>d__27>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D02F RID: 249903 RVA: 0x00EABB48 File Offset: 0x00EA9D48
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

		// Token: 0x0603D030 RID: 249904 RVA: 0x00EABB94 File Offset: 0x00EA9D94
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

		// Token: 0x0603D031 RID: 249905 RVA: 0x00EABC2A File Offset: 0x00EA9E2A
		protected override void OnBeforeDestroy()
		{
			this.StopDelayResetStar();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603D032 RID: 249906 RVA: 0x00EABC38 File Offset: 0x00EA9E38
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(13);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D033 RID: 249907 RVA: 0x00EABC48 File Offset: 0x00EA9E48
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

		// Token: 0x0603D034 RID: 249908 RVA: 0x00EABCFC File Offset: 0x00EA9EFC
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

		// Token: 0x0603D035 RID: 249909 RVA: 0x00EABD2C File Offset: 0x00EA9F2C
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

		// Token: 0x0603D036 RID: 249910 RVA: 0x00EABDA8 File Offset: 0x00EA9FA8
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

		// Token: 0x0603D037 RID: 249911 RVA: 0x00EABE15 File Offset: 0x00EAA015
		private void RefreshEffectColor()
		{
			SpecialEnergyBarAiMiSiSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal == null)
			{
				return;
			}
			barItemNormal.SetBarColor((!this.ModeOneTag) ? 1 : 0);
		}

		// Token: 0x0603D038 RID: 249912 RVA: 0x00EABE30 File Offset: 0x00EAA030
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

		// Token: 0x0603D039 RID: 249913 RVA: 0x00EABE88 File Offset: 0x00EAA088
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

		// Token: 0x0603D03A RID: 249914 RVA: 0x00EABF6A File Offset: 0x00EAA16A
		private void DelayResetStar()
		{
			this.StopDelayResetStar();
			this.DelayResetStarTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ResetStar();
				this.DelayResetStarTimer = null;
			}, 250f, null, null, true, 1f);
		}

		// Token: 0x0603D03B RID: 249915 RVA: 0x00EABF9B File Offset: 0x00EAA19B
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

		// Token: 0x0603D03C RID: 249916 RVA: 0x00EABFCF File Offset: 0x00EAA1CF
		private void ResetStarImmediately()
		{
			this.StopDelayResetStar();
			this.ResetStar();
		}

		// Token: 0x0603D03D RID: 249917 RVA: 0x00EABFE0 File Offset: 0x00EAA1E0
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

		// Token: 0x0603D03E RID: 249918 RVA: 0x00EAC078 File Offset: 0x00EAA278
		protected override void OnBarPercentChanged()
		{
			this.RefreshStar(false);
		}

		// Token: 0x0603D03F RID: 249919 RVA: 0x00EAC081 File Offset: 0x00EAA281
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

		// Token: 0x0603D040 RID: 249920 RVA: 0x00EAC0A4 File Offset: 0x00EAA2A4
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

		// Token: 0x0401FC8C RID: 130188
		private const int SUB_CONFIG_ID = 121001;

		// Token: 0x0401FC8D RID: 130189
		[StaticVariableRuleIgnore]
		private static readonly int modeTag = GameplayTagDefine.EGameplayTagId["角色.Common.双模式.模式1"];

		// Token: 0x0401FC8E RID: 130190
		[StaticVariableRuleIgnore]
		private static readonly int burstTag = GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.炮大招激活"];

		// Token: 0x0401FC8F RID: 130191
		private SpecialEnergyBarInfo SubConfig;

		// Token: 0x0401FC90 RID: 130192
		private SpecialEnergyBarAiMiSiSlot BarItemNormal;

		// Token: 0x0401FC91 RID: 130193
		private IActiveBuff Buff;

		// Token: 0x0401FC92 RID: 130194
		private int BuffHandle;

		// Token: 0x0401FC93 RID: 130195
		private bool ShowSubBar;

		// Token: 0x0401FC94 RID: 130196
		private float SubBarPercent = -1f;

		// Token: 0x0401FC95 RID: 130197
		private UUITexture TexProgress;

		// Token: 0x0401FC96 RID: 130198
		private bool IsPlayWarnAnim;

		// Token: 0x0401FC97 RID: 130199
		private int StarNum;

		// Token: 0x0401FC98 RID: 130200
		private bool ModeOneTag;

		// Token: 0x0401FC99 RID: 130201
		private bool BurstTag;

		// Token: 0x0401FC9A RID: 130202
		private bool IsPlayBurstAnim;

		// Token: 0x0401FC9B RID: 130203
		[Nullable(1)]
		private readonly List<UUITexture> TexStarBgList = new List<UUITexture>();

		// Token: 0x0401FC9C RID: 130204
		[Nullable(1)]
		private readonly List<UUIItem> StarItemList = new List<UUIItem>();

		// Token: 0x0401FC9D RID: 130205
		private bool IsPlayAniStarReset;

		// Token: 0x0401FC9E RID: 130206
		private TimerHandle DelayResetStarTimer;

		// Token: 0x0200C0D1 RID: 49361
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A2CA RID: 238282
			SlotBarItemNormal,
			// Token: 0x0403A2CB RID: 238283
			NormalItem,
			// Token: 0x0403A2CC RID: 238284
			MorphItem,
			// Token: 0x0403A2CD RID: 238285
			TexProgress,
			// Token: 0x0403A2CE RID: 238286
			AniDefault,
			// Token: 0x0403A2CF RID: 238287
			AniCharge0,
			// Token: 0x0403A2D0 RID: 238288
			AniCharge1,
			// Token: 0x0403A2D1 RID: 238289
			AniCharge2,
			// Token: 0x0403A2D2 RID: 238290
			AniCharge3,
			// Token: 0x0403A2D3 RID: 238291
			AniCharge4,
			// Token: 0x0403A2D4 RID: 238292
			AniBurst,
			// Token: 0x0403A2D5 RID: 238293
			AniMorphIn,
			// Token: 0x0403A2D6 RID: 238294
			AniMorphOut,
			// Token: 0x0403A2D7 RID: 238295
			AniWarning,
			// Token: 0x0403A2D8 RID: 238296
			AniWarningReset,
			// Token: 0x0403A2D9 RID: 238297
			AniMorphBurstOut,
			// Token: 0x0403A2DA RID: 238298
			AniStarReset,
			// Token: 0x0403A2DB RID: 238299
			TexStarBg1,
			// Token: 0x0403A2DC RID: 238300
			TexStarBg2,
			// Token: 0x0403A2DD RID: 238301
			TexStarBg3,
			// Token: 0x0403A2DE RID: 238302
			TexStarBg4,
			// Token: 0x0403A2DF RID: 238303
			StarItem1,
			// Token: 0x0403A2E0 RID: 238304
			StarItem2,
			// Token: 0x0403A2E1 RID: 238305
			StarItem3,
			// Token: 0x0403A2E2 RID: 238306
			StarItem4,
			// Token: 0x0403A2E3 RID: 238307
			KeyNode
		}
	}
}
