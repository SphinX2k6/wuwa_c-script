using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DCE RID: 19918
	public class SpecialEnergyBarLinNai : SpecialEnergyBarBase
	{
		// Token: 0x0603215D RID: 205149 RVA: 0x00E07870 File Offset: 0x00E05A70
		protected override void OnRegisterComponent()
		{
			Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
			dictionary[0] = typeof(UUITexture);
			dictionary[23] = typeof(UUITexture);
			dictionary[1] = typeof(UUIArtText);
			dictionary[2] = typeof(UUIArtText);
			dictionary[6] = typeof(UUISliderComponent);
			Dictionary<int, Type> dictionary2 = dictionary;
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 39; i++)
			{
				Type type;
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, dictionary2.TryGetValue(i, out type) ? type : typeof(UUIItem)));
			}
		}

		// Token: 0x0603215E RID: 205150 RVA: 0x00E0791C File Offset: 0x00E05B1C
		protected override void OnInitData()
		{
			base.OnInitData();
			this.ConfigList.Add(this.Config);
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(150901));
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(150902));
		}

		// Token: 0x0603215F RID: 205151 RVA: 0x00E07980 File Offset: 0x00E05B80
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.AttributeChanged1));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy3, new Action<EAttributeType, float, float>(this.AttributeChanged2));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLinNai.SkateTag, new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLinNai.EnergyTag, new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLinNai.SubSpeedTag, new BaseTagComponent.TTagSwitchedCallback(this.OnSpeedTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLinNai.MoveTag, new BaseTagComponent.TTagSwitchedCallback(this.OnSpeedTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLinNai.Life6Tag, new BaseTagComponent.TTagSwitchedCallback(this.OnSpeedTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLinNai.EKeyCooldownTag, new BaseTagComponent.TTagSwitchedCallback(this.OnEkeyTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLinNai.EKeyHighlightTag, new BaseTagComponent.TTagSwitchedCallback(this.OnBtnTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLinNai.EKeyActiveTag, new BaseTagComponent.TTagSwitchedCallback(this.OnBtnTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLinNai.SpaceHighlightTag, new BaseTagComponent.TTagSwitchedCallback(this.OnBtnSpaceStateChanged));
		}

		// Token: 0x06032160 RID: 205152 RVA: 0x00E07A8C File Offset: 0x00E05C8C
		private void AttributeChanged1(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.UpdateEnergyValue(newValue);
			float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy1Max);
			if ((double)(Math.Abs(newValue - oldValue) / currentValue) > 0.3)
			{
				this.NeedleFx.ForceTo(newValue / currentValue);
				this.IsEnergySpeedDirty = true;
				return;
			}
			if ((this.CurState == SpecialEnergyBarLinNai.EState.EnergyState && (double)Math.Abs(this.NeedleFx.Get() - newValue / currentValue) > 0.2) || (this.CurState == SpecialEnergyBarLinNai.EState.JumpState && (double)Math.Abs(this.NeedleFx.Get() - newValue / currentValue) > 0.1))
			{
				this.NeedleFx.ForceTo(newValue / currentValue);
				this.IsEnergySpeedDirty = true;
			}
		}

		// Token: 0x06032161 RID: 205153 RVA: 0x00E07B41 File Offset: 0x00E05D41
		private void AttributeChanged2(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.UpdateJumpValue(new float?(newValue));
		}

		// Token: 0x06032162 RID: 205154 RVA: 0x00E07B4F File Offset: 0x00E05D4F
		private void OnTagChanged(int tagId, bool tagExist)
		{
			this.RefreshState(false);
		}

		// Token: 0x06032163 RID: 205155 RVA: 0x00E07B58 File Offset: 0x00E05D58
		private void OnBtnSpaceStateChanged(int tagId, bool tagExist)
		{
			this.SwitchKeyItem();
		}

		// Token: 0x06032164 RID: 205156 RVA: 0x00E07B60 File Offset: 0x00E05D60
		private void OnBtnTagChanged(int tagId, bool tagExist)
		{
			this.SwitchKeyItem();
		}

		// Token: 0x06032165 RID: 205157 RVA: 0x00E07B68 File Offset: 0x00E05D68
		private void OnEkeyTagChanged(int tagId, bool tagExist)
		{
			this.RefreshInCdFx(true);
		}

		// Token: 0x06032166 RID: 205158 RVA: 0x00E07B74 File Offset: 0x00E05D74
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLinNai.<OnBeforeStartAsync>d__49 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLinNai.<OnBeforeStartAsync>d__49>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032167 RID: 205159 RVA: 0x00E07BB8 File Offset: 0x00E05DB8
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarLinNai.<InitBarItem>d__50 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLinNai.<InitBarItem>d__50>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032168 RID: 205160 RVA: 0x00E07BFC File Offset: 0x00E05DFC
		protected override void OnStart()
		{
			base.OnStart();
			for (int i = 24; i <= 38; i++)
			{
				base.InitTweenAnim(i);
			}
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			this.DurationC2A = (int)(((tweenAnimPlayer != null) ? tweenAnimPlayer.GetDuration(30) : 0.3f) * 1000f);
		}

		// Token: 0x06032169 RID: 205161 RVA: 0x00E07C4C File Offset: 0x00E05E4C
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			this.RefreshState(true);
			this.RefreshInCdFx(true);
			if (this.CurState == SpecialEnergyBarLinNai.EState.PaintState)
			{
				float percent = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2) / this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2Max);
				this.UpdatePaintPercent(percent);
				return;
			}
			this.UpdateJumpValue(null);
			this.UpdateEnergySpeed();
			this.TickEnergyPercent(0f);
		}

		// Token: 0x0603216A RID: 205162 RVA: 0x00E07CB9 File Offset: 0x00E05EB9
		protected override void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(true);
			}
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603216B RID: 205163 RVA: 0x00E07CD4 File Offset: 0x00E05ED4
		protected override void OnBarPercentChanged()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.UpdatePaintPercent(curPercent);
		}

		// Token: 0x0603216C RID: 205164 RVA: 0x00E07CF4 File Offset: 0x00E05EF4
		private void RefreshState(bool isStart = false)
		{
			if (this.TagComponent.HasTag(SpecialEnergyBarLinNai.EnergyTag))
			{
				this.SetState(SpecialEnergyBarLinNai.EState.EnergyState, isStart);
				return;
			}
			if (this.TagComponent.HasTag(SpecialEnergyBarLinNai.SkateTag))
			{
				this.SetState(SpecialEnergyBarLinNai.EState.JumpState, isStart);
				return;
			}
			this.SetState(SpecialEnergyBarLinNai.EState.PaintState, isStart);
		}

		// Token: 0x0603216D RID: 205165 RVA: 0x00E07D34 File Offset: 0x00E05F34
		private void SetState(SpecialEnergyBarLinNai.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			SpecialEnergyBarLinNai.EState curState = this.CurState;
			this.CurState = state;
			this.LastPaintPercent = 0f;
			float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy1);
			float currentValue2 = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy1Max);
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.StopAll();
			}
			bool flag = state == SpecialEnergyBarLinNai.EState.PaintState;
			base.GetArtText(2).SetUIActive(!flag);
			switch (state)
			{
			case SpecialEnergyBarLinNai.EState.PaintState:
			{
				this.PlayedStartA = false;
				float currentValue3 = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2);
				float inValue = currentValue3 / this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2Max);
				base.GetSlider(6).SetValue(inValue, true);
				base.GetArtText(1).SetText("000");
				if (curState == SpecialEnergyBarLinNai.EState.JumpState)
				{
					base.PlayTweenAnim(30);
					if (currentValue3 > 0f)
					{
						this.TimerStartA = TimerSystem.Instance.Delay(delegate(float _)
						{
							this.TimerStartA = null;
							if (state == SpecialEnergyBarLinNai.EState.PaintState)
							{
								this.PlayedStartA = true;
								this.PlayTweenAnim(24);
							}
						}, (float)this.DurationC2A, null, null, true, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
					}
				}
				else if (currentValue3 > 0f)
				{
					this.PlayedStartA = true;
					base.PlayTweenAnim(24);
				}
				break;
			}
			case SpecialEnergyBarLinNai.EState.EnergyState:
				this.NeedleFx.SetCurrent(currentValue / currentValue2);
				this.IsEnergySpeedDirty = true;
				base.PlayTweenAnim(25);
				break;
			case SpecialEnergyBarLinNai.EState.JumpState:
				this.NeedleFx.SetCurrent(currentValue / currentValue2);
				this.IsEnergySpeedDirty = true;
				base.PlayTweenAnim((curState == SpecialEnergyBarLinNai.EState.PaintState) ? 36 : 26);
				break;
			}
			this.UpdateJumpValueState();
			this.RefreshInCdFx(false);
			this.SwitchKeyItem();
		}

		// Token: 0x0603216E RID: 205166 RVA: 0x00E07EF0 File Offset: 0x00E060F0
		private void RefreshInCdFx(bool force = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			bool flag = tagComponent != null && tagComponent.HasTag(SpecialEnergyBarLinNai.EKeyCooldownTag);
			if (force || this.IsInCdFx != flag)
			{
				base.PlayTweenAnim(flag ? 38 : 37);
			}
			this.IsInCdFx = flag;
		}

		// Token: 0x0603216F RID: 205167 RVA: 0x00E07F37 File Offset: 0x00E06137
		internal bool Internal_GetKeyEnable()
		{
			return this.GetKeyEnable();
		}

		// Token: 0x06032170 RID: 205168 RVA: 0x00E07F40 File Offset: 0x00E06140
		protected override bool GetKeyEnable()
		{
			if (this.CurState == SpecialEnergyBarLinNai.EState.PaintState)
			{
				return base.GetKeyEnable();
			}
			return this.CurState == SpecialEnergyBarLinNai.EState.EnergyState || this.TagComponent.HasTag(SpecialEnergyBarLinNai.SpaceHighlightTag) || this.TagComponent.HasTag(SpecialEnergyBarLinNai.EKeyHighlightTag) || this.TagComponent.HasTag(SpecialEnergyBarLinNai.EKeyActiveTag);
		}

		// Token: 0x06032171 RID: 205169 RVA: 0x00E07FA0 File Offset: 0x00E061A0
		private void SwitchKeyItem()
		{
			if (this.CurState != SpecialEnergyBarLinNai.EState.JumpState)
			{
				SpecialEnergyBarLinNaiSlot barSlot = this.BarSlot;
				if (barSlot != null)
				{
					barSlot.SwitchKeyItem(this.ConfigList[0], false);
				}
				if (this.CurState == SpecialEnergyBarLinNai.EState.EnergyState)
				{
					SpecialEnergyBarLinNaiSlot barSlot2 = this.BarSlot;
					if (barSlot2 == null)
					{
						return;
					}
					barSlot2.RefreshKeyEnable(true, true);
				}
				return;
			}
			if (this.TagComponent.HasTag(SpecialEnergyBarLinNai.EKeyHighlightTag) || this.TagComponent.HasTag(SpecialEnergyBarLinNai.EKeyActiveTag))
			{
				SpecialEnergyBarLinNaiSlot barSlot3 = this.BarSlot;
				if (barSlot3 != null)
				{
					barSlot3.SwitchKeyItem(this.ConfigList[2], true);
				}
				SpecialEnergyBarLinNaiSlot barSlot4 = this.BarSlot;
				if (barSlot4 == null)
				{
					return;
				}
				barSlot4.RefreshKeyEnable(true, true);
				return;
			}
			else
			{
				SpecialEnergyBarLinNaiSlot barSlot5 = this.BarSlot;
				if (barSlot5 != null)
				{
					barSlot5.SwitchKeyItem(this.ConfigList[1], true);
				}
				SpecialEnergyBarLinNaiSlot barSlot6 = this.BarSlot;
				if (barSlot6 == null)
				{
					return;
				}
				barSlot6.RefreshKeyEnable(this.TagComponent.HasTag(SpecialEnergyBarLinNai.SpaceHighlightTag), true);
				return;
			}
		}

		// Token: 0x06032172 RID: 205170 RVA: 0x00E08088 File Offset: 0x00E06288
		private void UpdatePaintPercent(float percent)
		{
			if (this.CurState != SpecialEnergyBarLinNai.EState.EnergyState || percent == 0f)
			{
				base.GetSlider(6).SetValue(percent, true);
			}
			if (this.CurState == SpecialEnergyBarLinNai.EState.PaintState)
			{
				if (this.LastPaintPercent < 1f && percent >= 1f)
				{
					base.PlayTweenAnim(32);
				}
				else if (!this.PlayedStartA && this.TimerStartA == null)
				{
					this.PlayedStartA = true;
					base.PlayTweenAnim(24);
				}
			}
			this.LastPaintPercent = percent;
		}

		// Token: 0x06032173 RID: 205171 RVA: 0x00E0810C File Offset: 0x00E0630C
		private void OnSpeedTagChanged(int tagId, bool tagExist)
		{
			if (tagId == SpecialEnergyBarLinNai.MoveTag && this.TagComponent.HasTag(SpecialEnergyBarLinNai.DashTag))
			{
				if (!tagExist)
				{
					this.PendingMoveFlag = true;
					this.TimerMoveFlag = TimerSystem.Instance.Delay(delegate(float _)
					{
						this.TimerMoveFlag = null;
						this.PendingMoveFlag = false;
						this.IsEnergySpeedDirty = true;
					}, 50f, null, null, true, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
				}
				else
				{
					this.PendingMoveFlag = false;
				}
			}
			this.IsEnergySpeedDirty = true;
		}

		// Token: 0x06032174 RID: 205172 RVA: 0x00E0817C File Offset: 0x00E0637C
		private void UpdateEnergySpeed()
		{
			this.IsEnergySpeedDirty = false;
			if (this.CurState == SpecialEnergyBarLinNai.EState.EnergyState)
			{
				Buff? config = ConfigBuffById.GetConfig(this.TagComponent.HasTag(SpecialEnergyBarLinNai.Life6Tag) ? 15090000129L : 15090000104L, true);
				int num = (config != null) ? config.GetValueOrDefault().ModifierMagnitude(0) : 0;
				if ((float)Math.Abs(num) > 1E-45f)
				{
					float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy1Max);
					this.NeedleFx.SetSpeed((float)num / currentValue / 0.2f, true);
				}
				else
				{
					this.NeedleFx.SetSpeed(0.7f, true);
				}
				this.FixEnergyValue();
				return;
			}
			if (this.CurState == SpecialEnergyBarLinNai.EState.JumpState)
			{
				long num2 = 0L;
				bool flag = this.TagComponent.HasTag(SpecialEnergyBarLinNai.MoveTag) || this.PendingMoveFlag;
				bool flag2 = this.TagComponent.HasTag(SpecialEnergyBarLinNai.SubSpeedTag);
				if (flag && flag2)
				{
					this.FixEnergyValue();
					this.NeedleFx.SetSpeed(0f, false);
				}
				else if (flag)
				{
					num2 = (this.TagComponent.HasTag(SpecialEnergyBarLinNai.Life6Tag) ? 15090000149L : 15090000142L);
				}
				else if (flag2)
				{
					num2 = (this.TagComponent.HasTag(SpecialEnergyBarLinNai.Life6Tag) ? 15090000148L : 15090000141L);
				}
				else
				{
					this.FixEnergyValue();
					this.NeedleFx.SetSpeed(0f, false);
				}
				if (num2 != 0L)
				{
					Buff? config = ConfigBuffById.GetConfig(num2, true);
					int num3 = (config != null) ? config.GetValueOrDefault().ModifierMagnitude(0) : 0;
					if (num3 != 0)
					{
						float v = (float)num3 / 0.2f / this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy1Max);
						this.NeedleFx.SetTargetMode(false);
						this.NeedleFx.SetSpeed(v, false);
						return;
					}
					this.FixEnergyValue();
				}
			}
		}

		// Token: 0x06032175 RID: 205173 RVA: 0x00E08370 File Offset: 0x00E06570
		private void FixEnergyValue()
		{
			float targetEnergyPct = this.TargetEnergyPct;
			this.NeedleFx.SetTargetMode(true);
			this.NeedleFx.ResetTarget(targetEnergyPct, null);
		}

		// Token: 0x06032176 RID: 205174 RVA: 0x00E083A8 File Offset: 0x00E065A8
		private void UpdateEnergyValue(float curr)
		{
			float targetEnergyPct = curr / this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy1Max);
			if (this.NeedleFx.IsDone())
			{
				this.NeedleFx.Restart();
			}
			this.TargetEnergyPct = targetEnergyPct;
			if (this.CurState == SpecialEnergyBarLinNai.EState.EnergyState)
			{
				this.FixEnergyValue();
			}
		}

		// Token: 0x06032177 RID: 205175 RVA: 0x00E083F4 File Offset: 0x00E065F4
		private void TickEnergyPercent(float delta)
		{
			if (this.CurState == SpecialEnergyBarLinNai.EState.PaintState)
			{
				return;
			}
			if (this.IsEnergySpeedDirty)
			{
				this.UpdateEnergySpeed();
			}
			if (!this.NeedleFx.IsDone())
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				float num = (buffComponent != null) ? buffComponent.GetTimeScale() : 1f;
				this.NeedleFx.Tick(delta * 0.001f * num);
				float num2 = this.NeedleFx.Get();
				num2 = MathCommon.Clamp(num2, 0f, 1f);
				float num3 = MathCommon.Lerp(0.437f, 0.562f, num2);
				if (num3 >= 0.562f)
				{
					num3 = 0.58f;
				}
				base.GetTexture(0).SetFillAmount(num3);
				base.GetTexture(23).SetFillAmount(num3);
				FRotator frotator = new FRotator
				{
					Yaw = MathCommon.Lerp(15f, -15f, num2)
				};
				base.GetItem(18).SetUIRelativeRotation(frotator);
				int num4 = (int)Math.Floor((double)(this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy1Max) / 100f * num2));
				base.GetArtText(1).SetText(num4.ToString().PadLeft(3, '0'));
				base.GetArtText(2).SetText(num4.ToString());
				if (this.TargetEnergyPct >= 1f && this.NeedleFx.IsDone() && this.CurState == SpecialEnergyBarLinNai.EState.EnergyState)
				{
					base.PlayTweenAnim(31);
				}
				if (this.CurState == SpecialEnergyBarLinNai.EState.EnergyState)
				{
					num2 = 1f - num2;
					float curPercent = this.PercentMachine.GetCurPercent();
					if ((double)Math.Abs(num2 - curPercent) > 0.2)
					{
						num2 = MathCommon.Clamp(num2, curPercent - 0.2f, curPercent + 0.2f);
					}
					base.GetSlider(6).SetValue(num2, true);
				}
			}
		}

		// Token: 0x06032178 RID: 205176 RVA: 0x00E085AC File Offset: 0x00E067AC
		private void UpdateJumpValue(float? value = null)
		{
			float num = value ?? this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy3);
			if (this.CurState == SpecialEnergyBarLinNai.EState.JumpState)
			{
				for (int i = 1; i <= 3; i++)
				{
					int num3;
					if ((float)i <= num)
					{
						int num2;
						if (!this.LastJumpValueMap.TryGetValue(i, out num2) || num2 != 1)
						{
							this.LastJumpValueMap[i] = 1;
							base.PlayTweenAnim(this.JumpAnimAddMap[i]);
						}
					}
					else if (!this.LastJumpValueMap.TryGetValue(i, out num3) || num3 != -1)
					{
						this.LastJumpValueMap[i] = -1;
						base.PlayTweenAnim(this.JumpAnimReduceMap[i]);
					}
				}
				return;
			}
			for (int j = 1; j <= 3; j++)
			{
				int num4;
				if (!this.LastJumpValueMap.TryGetValue(j, out num4) || num4 != -1)
				{
					this.LastJumpValueMap[j] = -1;
					base.PlayTweenAnim(this.JumpAnimReduceMap[j]);
				}
			}
		}

		// Token: 0x06032179 RID: 205177 RVA: 0x00E086A8 File Offset: 0x00E068A8
		private void UpdateJumpValueState()
		{
			this.UpdateJumpValue(null);
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(this.CurState == SpecialEnergyBarLinNai.EState.JumpState);
			}
			UUIItem item2 = base.GetItem(12);
			if (item2 != null)
			{
				item2.SetUIActive(this.CurState == SpecialEnergyBarLinNai.EState.JumpState);
			}
			UUIItem item3 = base.GetItem(14);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(this.CurState == SpecialEnergyBarLinNai.EState.JumpState);
		}

		// Token: 0x0603217A RID: 205178 RVA: 0x00E08717 File Offset: 0x00E06917
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarLinNaiSlot barSlot = this.BarSlot;
			if (barSlot != null)
			{
				barSlot.Tick(delta);
			}
			this.TickEnergyPercent(delta);
		}

		// Token: 0x0603217B RID: 205179 RVA: 0x00E0873C File Offset: 0x00E0693C
		protected override void OnBeforeDestroy()
		{
			if (this.TimerStartA != null)
			{
				TimerSystem.Instance.Remove(this.TimerStartA);
				this.TimerStartA = null;
			}
			if (this.TimerMoveFlag != null)
			{
				TimerSystem.Instance.Remove(this.TimerMoveFlag);
				this.TimerMoveFlag = null;
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0401A86C RID: 108652
		private const EAttributeType PAINT_ATTR_ID = EAttributeType.SpecialEnergy2;

		// Token: 0x0401A86D RID: 108653
		private const EAttributeType PAINT_MAX_ATTR_ID = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401A86E RID: 108654
		private const EAttributeType ENERGY_ATTR_ID = EAttributeType.SpecialEnergy1;

		// Token: 0x0401A86F RID: 108655
		private const EAttributeType ENERGY_MAX_ATTR_ID = EAttributeType.SpecialEnergy1Max;

		// Token: 0x0401A870 RID: 108656
		private const EAttributeType JUMP_ATTR_ID = EAttributeType.SpecialEnergy3;

		// Token: 0x0401A871 RID: 108657
		private const int SPACEBTN_CONFIG = 150901;

		// Token: 0x0401A872 RID: 108658
		private const int E_SPACEBTN_CONFIG = 150902;

		// Token: 0x0401A873 RID: 108659
		private const float ENERGY_DELTA_SEC = 0.2f;

		// Token: 0x0401A874 RID: 108660
		private const int CHECK_LOST_MOVETAG = 50;

		// Token: 0x0401A875 RID: 108661
		[StaticVariableRuleIgnore]
		private static readonly int MoveTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.加速度值0"];

		// Token: 0x0401A876 RID: 108662
		[StaticVariableRuleIgnore]
		private static readonly int DashTag = GameplayTagDefine.EGameplayTagId["行为状态.动作状态.冲刺"];

		// Token: 0x0401A877 RID: 108663
		[StaticVariableRuleIgnore]
		private static readonly int SubSpeedTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.减速度值0"];

		// Token: 0x0401A878 RID: 108664
		[StaticVariableRuleIgnore]
		private static readonly int Life6Tag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.共鸣.共鸣6"];

		// Token: 0x0401A879 RID: 108665
		[StaticVariableRuleIgnore]
		private static readonly int SkateTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.轮滑状态"];

		// Token: 0x0401A87A RID: 108666
		[StaticVariableRuleIgnore]
		private static readonly int EnergyTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.轮滑蓄力"];

		// Token: 0x0401A87B RID: 108667
		[StaticVariableRuleIgnore]
		private static readonly int EKeyCooldownTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.下砸冷却"];

		// Token: 0x0401A87C RID: 108668
		[StaticVariableRuleIgnore]
		private static readonly int EKeyHighlightTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.飞跃下砸按钮高亮"];

		// Token: 0x0401A87D RID: 108669
		[StaticVariableRuleIgnore]
		private static readonly int EKeyActiveTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.激活飞跃下砸标记"];

		// Token: 0x0401A87E RID: 108670
		[StaticVariableRuleIgnore]
		private static readonly int SpaceHighlightTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.常态.跳跃按钮高亮"];

		// Token: 0x0401A87F RID: 108671
		[Nullable(2)]
		private SpecialEnergyBarLinNaiSlot BarSlot;

		// Token: 0x0401A880 RID: 108672
		private SpecialEnergyBarLinNai.EState CurState;

		// Token: 0x0401A881 RID: 108673
		[Nullable(1)]
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401A882 RID: 108674
		private int DurationC2A = 300;

		// Token: 0x0401A883 RID: 108675
		[Nullable(2)]
		private TimerHandle TimerStartA;

		// Token: 0x0401A884 RID: 108676
		private bool PlayedStartA;

		// Token: 0x0401A885 RID: 108677
		private float LastPaintPercent;

		// Token: 0x0401A886 RID: 108678
		private float TargetEnergyPct;

		// Token: 0x0401A887 RID: 108679
		[Nullable(1)]
		private readonly SpecialEnergyBarLinNai.NeedleNumber NeedleFx = new SpecialEnergyBarLinNai.NeedleNumber();

		// Token: 0x0401A888 RID: 108680
		private bool IsEnergySpeedDirty;

		// Token: 0x0401A889 RID: 108681
		private bool PendingMoveFlag;

		// Token: 0x0401A88A RID: 108682
		[Nullable(2)]
		private TimerHandle TimerMoveFlag;

		// Token: 0x0401A88B RID: 108683
		[Nullable(1)]
		private readonly Dictionary<int, int> LastJumpValueMap = new Dictionary<int, int>();

		// Token: 0x0401A88C RID: 108684
		[Nullable(1)]
		private readonly Dictionary<int, int> JumpAnimAddMap = new Dictionary<int, int>
		{
			{
				1,
				27
			},
			{
				2,
				28
			},
			{
				3,
				29
			}
		};

		// Token: 0x0401A88D RID: 108685
		[Nullable(1)]
		private readonly Dictionary<int, int> JumpAnimReduceMap = new Dictionary<int, int>
		{
			{
				1,
				33
			},
			{
				2,
				34
			},
			{
				3,
				35
			}
		};

		// Token: 0x0401A88E RID: 108686
		private bool IsInCdFx;

		// Token: 0x0200AB25 RID: 43813
		private class NeedleNumber
		{
			// Token: 0x06046958 RID: 289112 RVA: 0x0154A1BA File Offset: 0x015483BA
			public void SetTargetMode(bool b)
			{
				this.IsTargetMode = b;
			}

			// Token: 0x06046959 RID: 289113 RVA: 0x0154A1C4 File Offset: 0x015483C4
			public void ResetTarget(float t1, float? t2 = null)
			{
				this.TargetIndex = 0;
				this.Targets.Clear();
				this.Targets.Add(t1);
				if (t2 != null)
				{
					this.Targets.Add(t2.Value);
				}
				this.SpeedInner = Math.Abs(this.SpeedInner);
			}

			// Token: 0x17007A05 RID: 31237
			// (get) Token: 0x0604695A RID: 289114 RVA: 0x0154A21B File Offset: 0x0154841B
			public float Speed
			{
				get
				{
					return this.SpeedInner;
				}
			}

			// Token: 0x0604695B RID: 289115 RVA: 0x0154A224 File Offset: 0x01548424
			public void SetSpeed(float v, bool force = false)
			{
				if (this.IsTargetMode)
				{
					v = Math.Abs(v);
				}
				this.SpeedNext = v;
				if (force || !this.IsTargetMode || (this.IsTargetMode && (this.IsDone() || v != 0f)))
				{
					this.SpeedInner = v;
				}
			}

			// Token: 0x0604695C RID: 289116 RVA: 0x0154A272 File Offset: 0x01548472
			public void SetCurrent(float v)
			{
				this.NeedUpdate = (this.Current != v);
				this.Current = v;
			}

			// Token: 0x0604695D RID: 289117 RVA: 0x0154A290 File Offset: 0x01548490
			public void ForceTo(float v)
			{
				this.SetCurrent(v);
				if (this.IsTargetMode)
				{
					this.ResetTarget(v, null);
				}
			}

			// Token: 0x0604695E RID: 289118 RVA: 0x0154A2BC File Offset: 0x015484BC
			public void Restart()
			{
				if (!this.IsTargetMode)
				{
					this.SetCurrent(MathCommon.Clamp(this.Current, 0f, 1f));
				}
			}

			// Token: 0x0604695F RID: 289119 RVA: 0x0154A2E4 File Offset: 0x015484E4
			public bool IsDone()
			{
				if (this.IsTargetMode)
				{
					return !this.NeedUpdate && this.TargetIndex >= this.Targets.Count;
				}
				return !this.NeedUpdate && (this.SpeedInner == 0f || this.Current < 0f || this.Current > 1f);
			}

			// Token: 0x06046960 RID: 289120 RVA: 0x0154A350 File Offset: 0x01548550
			public void Tick(float delta)
			{
				if (this.IsTargetMode)
				{
					if (this.TargetIndex >= this.Targets.Count)
					{
						return;
					}
					float num = this.Targets[this.TargetIndex];
					int num2 = Math.Sign(num - this.Current);
					this.Current += (float)num2 * this.SpeedInner * delta;
					if ((num2 > 0 && this.Current >= num) || (num2 < 0 && this.Current <= num))
					{
						this.Current = num;
						this.SpeedInner = this.SpeedNext;
						this.TargetIndex++;
					}
				}
				else
				{
					this.Current += this.SpeedInner * delta;
				}
				this.NeedUpdate = false;
			}

			// Token: 0x06046961 RID: 289121 RVA: 0x0154A40D File Offset: 0x0154860D
			public float Get()
			{
				return this.Current;
			}

			// Token: 0x04034EC7 RID: 216775
			private bool IsTargetMode = true;

			// Token: 0x04034EC8 RID: 216776
			private float Current;

			// Token: 0x04034EC9 RID: 216777
			[Nullable(1)]
			private readonly List<float> Targets = new List<float>();

			// Token: 0x04034ECA RID: 216778
			private int TargetIndex;

			// Token: 0x04034ECB RID: 216779
			private float SpeedInner = 1f;

			// Token: 0x04034ECC RID: 216780
			private float SpeedNext = 1f;

			// Token: 0x04034ECD RID: 216781
			private bool NeedUpdate;
		}

		// Token: 0x0200AB26 RID: 43814
		private enum EState
		{
			// Token: 0x04034ECF RID: 216783
			PaintState,
			// Token: 0x04034ED0 RID: 216784
			EnergyState,
			// Token: 0x04034ED1 RID: 216785
			JumpState
		}

		// Token: 0x0200AB27 RID: 43815
		private enum EChildType
		{
			// Token: 0x04034ED3 RID: 216787
			RechareBar,
			// Token: 0x04034ED4 RID: 216788
			ArtTxtBlack,
			// Token: 0x04034ED5 RID: 216789
			ArtTxtLight,
			// Token: 0x04034ED6 RID: 216790
			PnlLight,
			// Token: 0x04034ED7 RID: 216791
			PnlWheel,
			// Token: 0x04034ED8 RID: 216792
			SlotBarItem,
			// Token: 0x04034ED9 RID: 216793
			SubWheel,
			// Token: 0x04034EDA RID: 216794
			SubWheelBgL,
			// Token: 0x04034EDB RID: 216795
			SubWheelBgR,
			// Token: 0x04034EDC RID: 216796
			PnlSlot1,
			// Token: 0x04034EDD RID: 216797
			PnlSlot1Hor1,
			// Token: 0x04034EDE RID: 216798
			PnlSlot1Hor1Dot,
			// Token: 0x04034EDF RID: 216799
			PnlSlot1Hor2,
			// Token: 0x04034EE0 RID: 216800
			PnlSlot1Hor2Dot,
			// Token: 0x04034EE1 RID: 216801
			PnlSlot1Hor3,
			// Token: 0x04034EE2 RID: 216802
			PnlSlot1Hor3Dot,
			// Token: 0x04034EE3 RID: 216803
			SprLine1,
			// Token: 0x04034EE4 RID: 216804
			SprLine2,
			// Token: 0x04034EE5 RID: 216805
			PnlNeedle,
			// Token: 0x04034EE6 RID: 216806
			FxSprLine1,
			// Token: 0x04034EE7 RID: 216807
			FxSprLine2,
			// Token: 0x04034EE8 RID: 216808
			FxNiaJump1,
			// Token: 0x04034EE9 RID: 216809
			FxNiaJump2,
			// Token: 0x04034EEA RID: 216810
			RechareBarBg,
			// Token: 0x04034EEB RID: 216811
			AnimStartA,
			// Token: 0x04034EEC RID: 216812
			AnimStartB,
			// Token: 0x04034EED RID: 216813
			AnimStartC,
			// Token: 0x04034EEE RID: 216814
			AnimNl1,
			// Token: 0x04034EEF RID: 216815
			AnimNl2,
			// Token: 0x04034EF0 RID: 216816
			AnimNl3,
			// Token: 0x04034EF1 RID: 216817
			AnimStartC2A,
			// Token: 0x04034EF2 RID: 216818
			AnimBMax,
			// Token: 0x04034EF3 RID: 216819
			AnimAMax,
			// Token: 0x04034EF4 RID: 216820
			AnimNlOut1,
			// Token: 0x04034EF5 RID: 216821
			AnimNlOut2,
			// Token: 0x04034EF6 RID: 216822
			AnimNlOut3,
			// Token: 0x04034EF7 RID: 216823
			AnimStartA2C,
			// Token: 0x04034EF8 RID: 216824
			AnimEKeyIn,
			// Token: 0x04034EF9 RID: 216825
			AnimEKeyOut,
			// Token: 0x04034EFA RID: 216826
			MaxCount
		}

		// Token: 0x0200AB28 RID: 43816
		private enum EEnergySpeedPhase2 : long
		{
			// Token: 0x04034EFC RID: 216828
			Life0 = 15090000104L,
			// Token: 0x04034EFD RID: 216829
			Life6 = 15090000129L
		}

		// Token: 0x0200AB29 RID: 43817
		private enum EEnergySpeedPhase3 : long
		{
			// Token: 0x04034EFF RID: 216831
			Life0Sub = 15090000141L,
			// Token: 0x04034F00 RID: 216832
			Life0Add,
			// Token: 0x04034F01 RID: 216833
			Life6Sub = 15090000148L,
			// Token: 0x04034F02 RID: 216834
			Life6Add
		}
	}
}
