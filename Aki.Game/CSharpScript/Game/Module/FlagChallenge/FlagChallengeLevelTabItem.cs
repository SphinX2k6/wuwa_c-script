using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A44 RID: 19012
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeLevelTabItem : GridProxyAbstract<FlagChallengeLevelData>
	{
		// Token: 0x0602F9AF RID: 194991 RVA: 0x00D46F54 File Offset: 0x00D45154
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIArtText)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUISprite)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x0602F9B0 RID: 194992 RVA: 0x00D4709C File Offset: 0x00D4529C
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
			extendToggle.OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
			EventSystem.Instance.Add(EEventName.OnFlagChallengeUpdateLevelData, new Action(this.OnLevelDataUpdate));
		}

		// Token: 0x0602F9B1 RID: 194993 RVA: 0x00D470FC File Offset: 0x00D452FC
		protected override void OnBeforeDestroy()
		{
			if (this.IsInitRedDot && this.Data != null)
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityLevelNewlyUnlocked, base.GetItem(10), this.Data.Id);
				this.IsInitRedDot = false;
			}
			this.RemoveTimer();
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeUpdateLevelData, new Action(this.OnLevelDataUpdate));
		}

		// Token: 0x0602F9B2 RID: 194994 RVA: 0x00D47164 File Offset: 0x00D45364
		public override void Refresh(FlagChallengeLevelData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshView(isSelected);
		}

		// Token: 0x0602F9B3 RID: 194995 RVA: 0x00D47174 File Offset: 0x00D45374
		public override object GetKey(FlagChallengeLevelData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x0602F9B4 RID: 194996 RVA: 0x00D47184 File Offset: 0x00D45384
		private void RefreshView(bool isSelected)
		{
			this.RemoveTimer();
			if (!this.IsInitRedDot)
			{
				RedDotController.Instance.BindRedDot(ERedDotName.RedDotFlagChallengeActivityLevelNewlyUnlocked, base.GetItem(10), null, this.Data.Id);
				this.IsInitRedDot = true;
			}
			UUIArtText artText = base.GetArtText(7);
			UUISprite sprite = base.GetSprite(9);
			if (this.Data.IsHiddenLevel())
			{
				sprite.SetUIActive(true);
				artText.SetUIActive(false);
			}
			else
			{
				sprite.SetUIActive(false);
				artText.SetUIActive(true);
				artText.SetText(this.Data.Index.ToString().PadLeft(2, '0'));
			}
			base.GetSprite(8).SetUIActive(this.Data.IsCompleted());
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			bool flag = this.Data.IsLocked();
			base.GetItem(11).SetUIActive(flag);
			UUIItem uuiitem = artText;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(artText.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			if (flag)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
				UUISprite sprite2 = base.GetSprite(5);
				UUIText text = base.GetText(6);
				if (!this.Data.IsReachUnlockTime())
				{
					this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath("SP_IconMorale3"), sprite2, false, null, null);
					string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat7(this.Data.GetRemainTime() * 0.0010000000474974513).CountDownText;
					text.SetText(countDownText, true);
					this.AddTimer();
				}
				else
				{
					this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath("SP_IconMorale4"), sprite2, false, null, null);
					text.SetText(this.Data.GetUnlockLevel().ToString(), true);
				}
			}
			else
			{
				this.SetToggleState(isSelected, false);
			}
			UUITexture texture = base.GetTexture(1);
			texture.SetUIActive(!flag);
			Dictionary<string, string> dictionary;
			if (!FlagChallengeDefine.Instance.flagChallengeStyleRes.TryGetValue(this.Data.GetUiStyle(), out dictionary))
			{
				return;
			}
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(dictionary["LevelTabItemNormal"]), texture, null, null);
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(dictionary["LevelTabItemHover"]), base.GetTexture(2), null, null);
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(dictionary["LevelTabItemSelect"]), base.GetTexture(4), null, null);
		}

		// Token: 0x0602F9B5 RID: 194997 RVA: 0x00D47401 File Offset: 0x00D45601
		private void AddTimer()
		{
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.RefreshRemainTime();
			}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x0602F9B6 RID: 194998 RVA: 0x00D47432 File Offset: 0x00D45632
		private void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0602F9B7 RID: 194999 RVA: 0x00D47454 File Offset: 0x00D45654
		private void RefreshRemainTime()
		{
			double remainTime = this.Data.GetRemainTime();
			if (remainTime <= 0.0)
			{
				this.RefreshView(false);
				return;
			}
			string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat7(remainTime * 0.0010000000474974513).CountDownText;
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			text.SetText(countDownText, true);
		}

		// Token: 0x0602F9B8 RID: 195000 RVA: 0x00D474B0 File Offset: 0x00D456B0
		public void SetToggleState(bool state, bool fireEvent = false)
		{
			if (state)
			{
				int id = this.Data.Id;
				int levelActivityId = FlagChallengeUtils.GetLevelActivityId(id);
				FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(levelActivityId);
				if (flagChallengeData.IsLevelNewlyUnlocked(id))
				{
					flagChallengeData.SetLevelNewlyUnlocked(id, false);
				}
			}
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state2, fireEvent, false, false);
		}

		// Token: 0x0602F9B9 RID: 195001 RVA: 0x00D47508 File Offset: 0x00D45708
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true, fireEvent);
		}

		// Token: 0x0602F9BA RID: 195002 RVA: 0x00D47512 File Offset: 0x00D45712
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, fireEvent);
		}

		// Token: 0x0602F9BB RID: 195003 RVA: 0x00D4751C File Offset: 0x00D4571C
		public void SetToggleCallback(Action<int> cb)
		{
			this.ToggleCallback = cb;
		}

		// Token: 0x0602F9BC RID: 195004 RVA: 0x00D47525 File Offset: 0x00D45725
		public void SetCanExecuteCallback(Func<int, bool> cb)
		{
			this.CanExecuteCallback = cb;
		}

		// Token: 0x0602F9BD RID: 195005 RVA: 0x00D4752E File Offset: 0x00D4572E
		private void OnClickToggle(EToggleState state)
		{
			Action<int> toggleCallback = this.ToggleCallback;
			if (toggleCallback == null)
			{
				return;
			}
			toggleCallback(this.Data.Id);
		}

		// Token: 0x0602F9BE RID: 195006 RVA: 0x00D4754B File Offset: 0x00D4574B
		private bool OnCanExecuteChange()
		{
			if (this.Data.IsLocked())
			{
				return false;
			}
			Func<int, bool> canExecuteCallback = this.CanExecuteCallback;
			return canExecuteCallback == null || canExecuteCallback(this.Data.Id);
		}

		// Token: 0x0602F9BF RID: 195007 RVA: 0x00D47578 File Offset: 0x00D45778
		private void OnUndeterminedClicked()
		{
			if (!this.Data.IsLocked())
			{
				return;
			}
			if (!this.Data.IsReachUnlockTime())
			{
				string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat7(this.Data.GetRemainTime() * 0.0010000000474974513).CountDownText;
				ScrollingTipsController.Instance.ShowTipsByTextId("Morale_32_Main_LvLocked_Tips", new object[]
				{
					countDownText
				});
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("Morale_32_Main_TimeLocked_Tips", new object[]
			{
				this.Data.GetUnlockLevel()
			});
		}

		// Token: 0x0602F9C0 RID: 195008 RVA: 0x00D47608 File Offset: 0x00D45808
		private void OnLevelDataUpdate()
		{
			if (this.Data == null)
			{
				return;
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			this.RefreshView(extendToggle.GetToggleState() == EToggleState.ETT_Checked);
		}

		// Token: 0x0401940D RID: 103437
		private FlagChallengeLevelData Data;

		// Token: 0x0401940E RID: 103438
		[Nullable(2)]
		private Action<int> ToggleCallback;

		// Token: 0x0401940F RID: 103439
		[Nullable(2)]
		private Func<int, bool> CanExecuteCallback;

		// Token: 0x04019410 RID: 103440
		private bool IsInitRedDot;

		// Token: 0x04019411 RID: 103441
		[Nullable(2)]
		protected TimerHandle TimerHandle;
	}
}
