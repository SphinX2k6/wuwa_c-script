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
	// Token: 0x02005DE9 RID: 24041
	public class SpecialEnergyBarLinNai : SpecialEnergyBarBase
	{
		// Token: 0x0603D1CE RID: 250318 RVA: 0x00EB6334 File Offset: 0x00EB4534
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

		// Token: 0x0603D1CF RID: 250319 RVA: 0x00EB63E0 File Offset: 0x00EB45E0
		protected override void OnInitData()
		{
			base.OnInitData();
			this.ConfigList.Add(this.Config);
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(150901));
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(150902));
		}

		// Token: 0x0603D1D0 RID: 250320 RVA: 0x00EB6444 File Offset: 0x00EB4644
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

		// Token: 0x0603D1D1 RID: 250321 RVA: 0x00EB6550 File Offset: 0x00EB4750
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

		// Token: 0x0603D1D2 RID: 250322 RVA: 0x00EB6605 File Offset: 0x00EB4805
		private void AttributeChanged2(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.UpdateJumpValue(new float?(newValue));
		}

		// Token: 0x0603D1D3 RID: 250323 RVA: 0x00EB6613 File Offset: 0x00EB4813
		private void OnTagChanged(int tagId, bool tagExist)
		{
			this.RefreshState(false);
		}

		// Token: 0x0603D1D4 RID: 250324 RVA: 0x00EB661C File Offset: 0x00EB481C
		private void OnBtnSpaceStateChanged(int tagId, bool tagExist)
		{
			this.SwitchKeyItem();
		}

		// Token: 0x0603D1D5 RID: 250325 RVA: 0x00EB6624 File Offset: 0x00EB4824
		private void OnBtnTagChanged(int tagId, bool tagExist)
		{
			this.SwitchKeyItem();
		}

		// Token: 0x0603D1D6 RID: 250326 RVA: 0x00EB662C File Offset: 0x00EB482C
		private void OnEkeyTagChanged(int tagId, bool tagExist)
		{
			this.RefreshInCdFx(true);
		}

		// Token: 0x0603D1D7 RID: 250327 RVA: 0x00EB6638 File Offset: 0x00EB4838
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLinNai.<OnBeforeStartAsync>d__49 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLinNai.<OnBeforeStartAsync>d__49>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D1D8 RID: 250328 RVA: 0x00EB667C File Offset: 0x00EB487C
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarLinNai.<InitBarItem>d__50 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLinNai.<InitBarItem>d__50>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D1D9 RID: 250329 RVA: 0x00EB66C0 File Offset: 0x00EB48C0
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

		// Token: 0x0603D1DA RID: 250330 RVA: 0x00EB6710 File Offset: 0x00EB4910
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

		// Token: 0x0603D1DB RID: 250331 RVA: 0x00EB677D File Offset: 0x00EB497D
		protected override void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(true);
			}
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D1DC RID: 250332 RVA: 0x00EB6798 File Offset: 0x00EB4998
		protected override void OnBarPercentChanged()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.UpdatePaintPercent(curPercent);
		}

		// Token: 0x0603D1DD RID: 250333 RVA: 0x00EB67B8 File Offset: 0x00EB49B8
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

		// Token: 0x0603D1DE RID: 250334 RVA: 0x00EB67F8 File Offset: 0x00EB49F8
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

		// Token: 0x0603D1DF RID: 250335 RVA: 0x00EB69B4 File Offset: 0x00EB4BB4
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

		// Token: 0x0603D1E0 RID: 250336 RVA: 0x00EB69FB File Offset: 0x00EB4BFB
		internal bool Internal_GetKeyEnable()
		{
			return this.GetKeyEnable();
		}

		// Token: 0x0603D1E1 RID: 250337 RVA: 0x00EB6A04 File Offset: 0x00EB4C04
		protected override bool GetKeyEnable()
		{
			if (this.CurState == SpecialEnergyBarLinNai.EState.PaintState)
			{
				return base.GetKeyEnable();
			}
			return this.CurState == SpecialEnergyBarLinNai.EState.EnergyState || this.TagComponent.HasTag(SpecialEnergyBarLinNai.SpaceHighlightTag) || this.TagComponent.HasTag(SpecialEnergyBarLinNai.EKeyHighlightTag) || this.TagComponent.HasTag(SpecialEnergyBarLinNai.EKeyActiveTag);
		}

		// Token: 0x0603D1E2 RID: 250338 RVA: 0x00EB6A64 File Offset: 0x00EB4C64
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

		// Token: 0x0603D1E3 RID: 250339 RVA: 0x00EB6B4C File Offset: 0x00EB4D4C
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

		// Token: 0x0603D1E4 RID: 250340 RVA: 0x00EB6BD0 File Offset: 0x00EB4DD0
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

		// Token: 0x0603D1E5 RID: 250341 RVA: 0x00EB6C40 File Offset: 0x00EB4E40
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

		// Token: 0x0603D1E6 RID: 250342 RVA: 0x00EB6E34 File Offset: 0x00EB5034
		private void FixEnergyValue()
		{
			float targetEnergyPct = this.TargetEnergyPct;
			this.NeedleFx.SetTargetMode(true);
			this.NeedleFx.ResetTarget(targetEnergyPct, null);
		}

		// Token: 0x0603D1E7 RID: 250343 RVA: 0x00EB6E6C File Offset: 0x00EB506C
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

		// Token: 0x0603D1E8 RID: 250344 RVA: 0x00EB6EB8 File Offset: 0x00EB50B8
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

		// Token: 0x0603D1E9 RID: 250345 RVA: 0x00EB7070 File Offset: 0x00EB5270
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

		// Token: 0x0603D1EA RID: 250346 RVA: 0x00EB716C File Offset: 0x00EB536C
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

		// Token: 0x0603D1EB RID: 250347 RVA: 0x00EB71DB File Offset: 0x00EB53DB
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

		// Token: 0x0603D1EC RID: 250348 RVA: 0x00EB7200 File Offset: 0x00EB5400
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

		// Token: 0x0401FDA5 RID: 130469
		private const EAttributeType PAINT_ATTR_ID = EAttributeType.SpecialEnergy2;

		// Token: 0x0401FDA6 RID: 130470
		private const EAttributeType PAINT_MAX_ATTR_ID = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401FDA7 RID: 130471
		private const EAttributeType ENERGY_ATTR_ID = EAttributeType.SpecialEnergy1;

		// Token: 0x0401FDA8 RID: 130472
		private const EAttributeType ENERGY_MAX_ATTR_ID = EAttributeType.SpecialEnergy1Max;

		// Token: 0x0401FDA9 RID: 130473
		private const EAttributeType JUMP_ATTR_ID = EAttributeType.SpecialEnergy3;

		// Token: 0x0401FDAA RID: 130474
		private const int SPACEBTN_CONFIG = 150901;

		// Token: 0x0401FDAB RID: 130475
		private const int E_SPACEBTN_CONFIG = 150902;

		// Token: 0x0401FDAC RID: 130476
		private const float ENERGY_DELTA_SEC = 0.2f;

		// Token: 0x0401FDAD RID: 130477
		private const int CHECK_LOST_MOVETAG = 50;

		// Token: 0x0401FDAE RID: 130478
		[StaticVariableRuleIgnore]
		private static readonly int MoveTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.加速度值0"];

		// Token: 0x0401FDAF RID: 130479
		[StaticVariableRuleIgnore]
		private static readonly int DashTag = GameplayTagDefine.EGameplayTagId["行为状态.动作状态.冲刺"];

		// Token: 0x0401FDB0 RID: 130480
		[StaticVariableRuleIgnore]
		private static readonly int SubSpeedTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.减速度值0"];

		// Token: 0x0401FDB1 RID: 130481
		[StaticVariableRuleIgnore]
		private static readonly int Life6Tag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.共鸣.共鸣6"];

		// Token: 0x0401FDB2 RID: 130482
		[StaticVariableRuleIgnore]
		private static readonly int SkateTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.轮滑状态"];

		// Token: 0x0401FDB3 RID: 130483
		[StaticVariableRuleIgnore]
		private static readonly int EnergyTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.轮滑蓄力"];

		// Token: 0x0401FDB4 RID: 130484
		[StaticVariableRuleIgnore]
		private static readonly int EKeyCooldownTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.下砸冷却"];

		// Token: 0x0401FDB5 RID: 130485
		[StaticVariableRuleIgnore]
		private static readonly int EKeyHighlightTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.飞跃下砸按钮高亮"];

		// Token: 0x0401FDB6 RID: 130486
		[StaticVariableRuleIgnore]
		private static readonly int EKeyActiveTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.激活飞跃下砸标记"];

		// Token: 0x0401FDB7 RID: 130487
		[StaticVariableRuleIgnore]
		private static readonly int SpaceHighlightTag = GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.常态.跳跃按钮高亮"];

		// Token: 0x0401FDB8 RID: 130488
		[Nullable(2)]
		private SpecialEnergyBarLinNaiSlot BarSlot;

		// Token: 0x0401FDB9 RID: 130489
		private SpecialEnergyBarLinNai.EState CurState;

		// Token: 0x0401FDBA RID: 130490
		[Nullable(1)]
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401FDBB RID: 130491
		private int DurationC2A = 300;

		// Token: 0x0401FDBC RID: 130492
		[Nullable(2)]
		private TimerHandle TimerStartA;

		// Token: 0x0401FDBD RID: 130493
		private bool PlayedStartA;

		// Token: 0x0401FDBE RID: 130494
		private float LastPaintPercent;

		// Token: 0x0401FDBF RID: 130495
		private float TargetEnergyPct;

		// Token: 0x0401FDC0 RID: 130496
		[Nullable(1)]
		private readonly SpecialEnergyBarLinNai.NeedleNumber NeedleFx = new SpecialEnergyBarLinNai.NeedleNumber();

		// Token: 0x0401FDC1 RID: 130497
		private bool IsEnergySpeedDirty;

		// Token: 0x0401FDC2 RID: 130498
		private bool PendingMoveFlag;

		// Token: 0x0401FDC3 RID: 130499
		[Nullable(2)]
		private TimerHandle TimerMoveFlag;

		// Token: 0x0401FDC4 RID: 130500
		[Nullable(1)]
		private readonly Dictionary<int, int> LastJumpValueMap = new Dictionary<int, int>();

		// Token: 0x0401FDC5 RID: 130501
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

		// Token: 0x0401FDC6 RID: 130502
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

		// Token: 0x0401FDC7 RID: 130503
		private bool IsInCdFx;

		// Token: 0x0200C116 RID: 49430
		private class NeedleNumber
		{
			// Token: 0x0605040B RID: 328715 RVA: 0x015908BE File Offset: 0x0158EABE
			public void SetTargetMode(bool b)
			{
				this.IsTargetMode = b;
			}

			// Token: 0x0605040C RID: 328716 RVA: 0x015908C8 File Offset: 0x0158EAC8
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

			// Token: 0x1700A268 RID: 41576
			// (get) Token: 0x0605040D RID: 328717 RVA: 0x0159091F File Offset: 0x0158EB1F
			public float Speed
			{
				get
				{
					return this.SpeedInner;
				}
			}

			// Token: 0x0605040E RID: 328718 RVA: 0x01590928 File Offset: 0x0158EB28
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

			// Token: 0x0605040F RID: 328719 RVA: 0x01590976 File Offset: 0x0158EB76
			public void SetCurrent(float v)
			{
				this.NeedUpdate = (this.Current != v);
				this.Current = v;
			}

			// Token: 0x06050410 RID: 328720 RVA: 0x01590994 File Offset: 0x0158EB94
			public void ForceTo(float v)
			{
				this.SetCurrent(v);
				if (this.IsTargetMode)
				{
					this.ResetTarget(v, null);
				}
			}

			// Token: 0x06050411 RID: 328721 RVA: 0x015909C0 File Offset: 0x0158EBC0
			public void Restart()
			{
				if (!this.IsTargetMode)
				{
					this.SetCurrent(MathCommon.Clamp(this.Current, 0f, 1f));
				}
			}

			// Token: 0x06050412 RID: 328722 RVA: 0x015909E8 File Offset: 0x0158EBE8
			public bool IsDone()
			{
				if (this.IsTargetMode)
				{
					return !this.NeedUpdate && this.TargetIndex >= this.Targets.Count;
				}
				return !this.NeedUpdate && (this.SpeedInner == 0f || this.Current < 0f || this.Current > 1f);
			}

			// Token: 0x06050413 RID: 328723 RVA: 0x01590A54 File Offset: 0x0158EC54
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

			// Token: 0x06050414 RID: 328724 RVA: 0x01590B11 File Offset: 0x0158ED11
			public float Get()
			{
				return this.Current;
			}

			// Token: 0x0403A4D5 RID: 238805
			private bool IsTargetMode = true;

			// Token: 0x0403A4D6 RID: 238806
			private float Current;

			// Token: 0x0403A4D7 RID: 238807
			[Nullable(1)]
			private readonly List<float> Targets = new List<float>();

			// Token: 0x0403A4D8 RID: 238808
			private int TargetIndex;

			// Token: 0x0403A4D9 RID: 238809
			private float SpeedInner = 1f;

			// Token: 0x0403A4DA RID: 238810
			private float SpeedNext = 1f;

			// Token: 0x0403A4DB RID: 238811
			private bool NeedUpdate;
		}

		// Token: 0x0200C117 RID: 49431
		private enum EState
		{
			// Token: 0x0403A4DD RID: 238813
			PaintState,
			// Token: 0x0403A4DE RID: 238814
			EnergyState,
			// Token: 0x0403A4DF RID: 238815
			JumpState
		}

		// Token: 0x0200C118 RID: 49432
		private enum EChildType
		{
			// Token: 0x0403A4E1 RID: 238817
			RechareBar,
			// Token: 0x0403A4E2 RID: 238818
			ArtTxtBlack,
			// Token: 0x0403A4E3 RID: 238819
			ArtTxtLight,
			// Token: 0x0403A4E4 RID: 238820
			PnlLight,
			// Token: 0x0403A4E5 RID: 238821
			PnlWheel,
			// Token: 0x0403A4E6 RID: 238822
			SlotBarItem,
			// Token: 0x0403A4E7 RID: 238823
			SubWheel,
			// Token: 0x0403A4E8 RID: 238824
			SubWheelBgL,
			// Token: 0x0403A4E9 RID: 238825
			SubWheelBgR,
			// Token: 0x0403A4EA RID: 238826
			PnlSlot1,
			// Token: 0x0403A4EB RID: 238827
			PnlSlot1Hor1,
			// Token: 0x0403A4EC RID: 238828
			PnlSlot1Hor1Dot,
			// Token: 0x0403A4ED RID: 238829
			PnlSlot1Hor2,
			// Token: 0x0403A4EE RID: 238830
			PnlSlot1Hor2Dot,
			// Token: 0x0403A4EF RID: 238831
			PnlSlot1Hor3,
			// Token: 0x0403A4F0 RID: 238832
			PnlSlot1Hor3Dot,
			// Token: 0x0403A4F1 RID: 238833
			SprLine1,
			// Token: 0x0403A4F2 RID: 238834
			SprLine2,
			// Token: 0x0403A4F3 RID: 238835
			PnlNeedle,
			// Token: 0x0403A4F4 RID: 238836
			FxSprLine1,
			// Token: 0x0403A4F5 RID: 238837
			FxSprLine2,
			// Token: 0x0403A4F6 RID: 238838
			FxNiaJump1,
			// Token: 0x0403A4F7 RID: 238839
			FxNiaJump2,
			// Token: 0x0403A4F8 RID: 238840
			RechareBarBg,
			// Token: 0x0403A4F9 RID: 238841
			AnimStartA,
			// Token: 0x0403A4FA RID: 238842
			AnimStartB,
			// Token: 0x0403A4FB RID: 238843
			AnimStartC,
			// Token: 0x0403A4FC RID: 238844
			AnimNl1,
			// Token: 0x0403A4FD RID: 238845
			AnimNl2,
			// Token: 0x0403A4FE RID: 238846
			AnimNl3,
			// Token: 0x0403A4FF RID: 238847
			AnimStartC2A,
			// Token: 0x0403A500 RID: 238848
			AnimBMax,
			// Token: 0x0403A501 RID: 238849
			AnimAMax,
			// Token: 0x0403A502 RID: 238850
			AnimNlOut1,
			// Token: 0x0403A503 RID: 238851
			AnimNlOut2,
			// Token: 0x0403A504 RID: 238852
			AnimNlOut3,
			// Token: 0x0403A505 RID: 238853
			AnimStartA2C,
			// Token: 0x0403A506 RID: 238854
			AnimEKeyIn,
			// Token: 0x0403A507 RID: 238855
			AnimEKeyOut,
			// Token: 0x0403A508 RID: 238856
			MaxCount
		}

		// Token: 0x0200C119 RID: 49433
		private enum EEnergySpeedPhase2 : long
		{
			// Token: 0x0403A50A RID: 238858
			Life0 = 15090000104L,
			// Token: 0x0403A50B RID: 238859
			Life6 = 15090000129L
		}

		// Token: 0x0200C11A RID: 49434
		private enum EEnergySpeedPhase3 : long
		{
			// Token: 0x0403A50D RID: 238861
			Life0Sub = 15090000141L,
			// Token: 0x0403A50E RID: 238862
			Life0Add,
			// Token: 0x0403A50F RID: 238863
			Life6Sub = 15090000148L,
			// Token: 0x0403A510 RID: 238864
			Life6Add
		}
	}
}
