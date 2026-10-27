using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A68 RID: 23144
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeLevelTabItem : GridProxyAbstract<FlagChallengeLevelData>
	{
		// Token: 0x0603AA66 RID: 240230 RVA: 0x00DF69D0 File Offset: 0x00DF4BD0
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

		// Token: 0x0603AA67 RID: 240231 RVA: 0x00DF6B18 File Offset: 0x00DF4D18
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
			extendToggle.OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
			EventSystem.Instance.Add(EEventName.OnFlagChallengeUpdateLevelData, new Action(this.OnLevelDataUpdate));
		}

		// Token: 0x0603AA68 RID: 240232 RVA: 0x00DF6B78 File Offset: 0x00DF4D78
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

		// Token: 0x0603AA69 RID: 240233 RVA: 0x00DF6BE0 File Offset: 0x00DF4DE0
		public override void Refresh(FlagChallengeLevelData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshView(isSelected);
		}

		// Token: 0x0603AA6A RID: 240234 RVA: 0x00DF6BF0 File Offset: 0x00DF4DF0
		public override object GetKey(FlagChallengeLevelData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x0603AA6B RID: 240235 RVA: 0x00DF6C00 File Offset: 0x00DF4E00
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

		// Token: 0x0603AA6C RID: 240236 RVA: 0x00DF6E7D File Offset: 0x00DF507D
		private void AddTimer()
		{
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.RefreshRemainTime();
			}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x0603AA6D RID: 240237 RVA: 0x00DF6EAE File Offset: 0x00DF50AE
		private void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0603AA6E RID: 240238 RVA: 0x00DF6ED0 File Offset: 0x00DF50D0
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

		// Token: 0x0603AA6F RID: 240239 RVA: 0x00DF6F2C File Offset: 0x00DF512C
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

		// Token: 0x0603AA70 RID: 240240 RVA: 0x00DF6F84 File Offset: 0x00DF5184
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true, fireEvent);
		}

		// Token: 0x0603AA71 RID: 240241 RVA: 0x00DF6F8E File Offset: 0x00DF518E
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, fireEvent);
		}

		// Token: 0x0603AA72 RID: 240242 RVA: 0x00DF6F98 File Offset: 0x00DF5198
		public void SetToggleCallback(Action<int> cb)
		{
			this.ToggleCallback = cb;
		}

		// Token: 0x0603AA73 RID: 240243 RVA: 0x00DF6FA1 File Offset: 0x00DF51A1
		public void SetCanExecuteCallback(Func<int, bool> cb)
		{
			this.CanExecuteCallback = cb;
		}

		// Token: 0x0603AA74 RID: 240244 RVA: 0x00DF6FAA File Offset: 0x00DF51AA
		private void OnClickToggle(EToggleState state)
		{
			Action<int> toggleCallback = this.ToggleCallback;
			if (toggleCallback == null)
			{
				return;
			}
			toggleCallback(this.Data.Id);
		}

		// Token: 0x0603AA75 RID: 240245 RVA: 0x00DF6FC7 File Offset: 0x00DF51C7
		private bool OnCanExecuteChange()
		{
			if (this.Data.IsLocked())
			{
				return false;
			}
			Func<int, bool> canExecuteCallback = this.CanExecuteCallback;
			return canExecuteCallback == null || canExecuteCallback(this.Data.Id);
		}

		// Token: 0x0603AA76 RID: 240246 RVA: 0x00DF6FF4 File Offset: 0x00DF51F4
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

		// Token: 0x0603AA77 RID: 240247 RVA: 0x00DF7084 File Offset: 0x00DF5284
		private void OnLevelDataUpdate()
		{
			if (this.Data == null)
			{
				return;
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			this.RefreshView(extendToggle.GetToggleState() == EToggleState.ETT_Checked);
		}

		// Token: 0x0401E966 RID: 125286
		private FlagChallengeLevelData Data;

		// Token: 0x0401E967 RID: 125287
		[Nullable(2)]
		private Action<int> ToggleCallback;

		// Token: 0x0401E968 RID: 125288
		[Nullable(2)]
		private Func<int, bool> CanExecuteCallback;

		// Token: 0x0401E969 RID: 125289
		private bool IsInitRedDot;

		// Token: 0x0401E96A RID: 125290
		[Nullable(2)]
		protected TimerHandle TimerHandle;
	}
}
