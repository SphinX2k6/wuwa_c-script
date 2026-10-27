using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E9A RID: 7834
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryBackpackLevelItem : UiPanelBase
{
	// Token: 0x0600F085 RID: 61573 RVA: 0x0039B16E File Offset: 0x0039936E
	public HonamiStoryBackpackLevelItem(bool isInDungeon)
	{
		this.IsInDungeon = isInDungeon;
	}

	// Token: 0x0600F086 RID: 61574 RVA: 0x0039B180 File Offset: 0x00399380
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUINiagara)),
			new ValueTuple<int, Type>(8, typeof(UUISprite)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(11, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickedUpdate))
		};
	}

	// Token: 0x0600F087 RID: 61575 RVA: 0x0039B2B0 File Offset: 0x003994B0
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryBackpackLevelItem.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryBackpackLevelItem.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F088 RID: 61576 RVA: 0x0039B2F3 File Offset: 0x003994F3
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600F089 RID: 61577 RVA: 0x0039B308 File Offset: 0x00399508
	protected override void OnBeforeShow()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(false);
		this.ActivityOpen = (activityData != null && activityData.GetPreGuideQuestFinishState());
		HonamiStoryLevelPowerItem powerItem = this.PowerItem;
		if (powerItem != null)
		{
			powerItem.RefreshPowerVisible(this.ActivityOpen);
		}
		this.RefreshLifeSupport();
		this.RefreshPowerLevel(false, false, 0, 0);
		this.CheckCanUpgrade();
		EventSystem.Instance.Add(EEventName.OnHonamiStoryLifeSupportLevelUp, new Action(this.ShowSuccessPanel));
	}

	// Token: 0x0600F08A RID: 61578 RVA: 0x0039B37B File Offset: 0x0039957B
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryLifeSupportLevelUp, new Action(this.ShowSuccessPanel));
	}

	// Token: 0x0600F08B RID: 61579 RVA: 0x0039B39C File Offset: 0x0039959C
	public void RefreshLifeSupport()
	{
		int lifeSupportMaxLevel = HonamiStoryModel.Instance.GetPlayerData().GetLifeSupportMaxLevel();
		int lifeSupportLevel = HonamiStoryModel.Instance.GetPlayerData().LifeSupportLevel;
		bool flag = FunctionModel.Instance.IsOpen(10122);
		bool flag2 = !this.IsInDungeon && lifeSupportLevel < lifeSupportMaxLevel && flag;
		bool flag3 = HonamiStoryUtil.CheckInHonamiStoryDungeon();
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag2);
		}
		string resourceId = flag2 ? "T_BackpackUpdateBgB" : "T_BackpackUpdateBg";
		string path = UiResourceConfig.Instance.GetResourcePath(resourceId) ?? string.Empty;
		base.SetTextureByPath(path, base.GetTexture(9), null, null);
		bool flag4 = FunctionModel.Instance.IsOpen(10105);
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetUIActive(flag4 && lifeSupportLevel != lifeSupportMaxLevel);
		}
		UUISprite sprite = base.GetSprite(8);
		if (sprite != null)
		{
			sprite.SetUIActive(flag4 && lifeSupportLevel == lifeSupportMaxLevel);
		}
		string key = flag4 ? "HonamiStory_TableValue_1" : "HonamiStory_TableValue_0";
		UUIText text2 = base.GetText(11);
		if (text2 != null)
		{
			text2.ShowTextNew(key);
		}
		if (flag4 && lifeSupportLevel != lifeSupportMaxLevel)
		{
			UUIText text3 = base.GetText(1);
			if (text3 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(lifeSupportLevel);
				text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}
		EFormationAttributeId attrId = EFormationAttributeId.HonamiStoryLifeSupport;
		if (flag3)
		{
			float value = FormationAttributeController.Instance.GetValue(attrId);
			float max = FormationAttributeController.Instance.GetMax(attrId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "HonamiStory_LifeSupport_Value", new <>z__ReadOnlyArray<object>(new object[]
			{
				value,
				max
			}));
			UUISprite sprite2 = base.GetSprite(4);
			if (sprite2 != null)
			{
				sprite2.SetFillAmount(value / max);
			}
		}
		else
		{
			int curMaxValue = HonamiStoryModel.Instance.GetPlayerData().GetCurMaxValue();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "HonamiStory_LifeSupport_Value", new <>z__ReadOnlyArray<object>(new object[]
			{
				curMaxValue,
				curMaxValue
			}));
			UUISprite sprite3 = base.GetSprite(4);
			if (sprite3 != null)
			{
				sprite3.SetFillAmount((float)(curMaxValue / curMaxValue));
			}
		}
		string lifeSupportIcon = HonamiStoryModel.Instance.GetPlayerData().GetLifeSupportIcon();
		this.SetSpriteByPath(lifeSupportIcon, base.GetSprite(6), false, null, null);
	}

	// Token: 0x0600F08C RID: 61580 RVA: 0x0039B5F8 File Offset: 0x003997F8
	public void RefreshPowerLevel(bool needAnim, bool isAdd, int oldValue, int newValue)
	{
		if (!this.ActivityOpen)
		{
			return;
		}
		if (needAnim)
		{
			this.FrameCount = 0;
			this.IsAdd = isAdd;
			this.NewValue = newValue;
			if (this.AnimTimerHandle != null)
			{
				if (this.AnimTimerHandle.Valid())
				{
					TimerSystem.GameplayTimeInstance.Remove(this.AnimTimerHandle);
				}
				this.OldValue = this.CurValue;
			}
			else
			{
				this.OldValue = oldValue;
			}
			this.AnimTimerHandle = TimerSystem.GameplayTimeInstance.Next(new TTimerAction(this.OnPowerAnim), null, null);
			if (isAdd)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlayOrReplaySequenceByName("Up", false, null);
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null && levelSequencePlayer2.IsPlayingSequence("Down"))
				{
					LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
					if (levelSequencePlayer3 == null)
					{
						return;
					}
					levelSequencePlayer3.StopSequenceByKey("Down", false, false);
					return;
				}
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
				if (levelSequencePlayer4 != null)
				{
					levelSequencePlayer4.PlayOrReplaySequenceByName("Down", false, null);
				}
				LevelSequencePlayer levelSequencePlayer5 = this.LevelSequencePlayer;
				if (levelSequencePlayer5 != null && levelSequencePlayer5.IsPlayingSequence("Up"))
				{
					LevelSequencePlayer levelSequencePlayer6 = this.LevelSequencePlayer;
					if (levelSequencePlayer6 == null)
					{
						return;
					}
					levelSequencePlayer6.StopSequenceByKey("Up", false, false);
				}
			}
			return;
		}
		if (newValue != 0)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(newValue);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			return;
		}
		else
		{
			int powerLevel = HonamiStoryModel.Instance.GetPlayerData().PowerLevel;
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(powerLevel);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			return;
		}
	}

	// Token: 0x0600F08D RID: 61581 RVA: 0x0039B78F File Offset: 0x0039998F
	public void SetIsEnable(bool value)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetAlpha(value ? 1f : 0.4f);
		}
		UUIButtonComponent button = base.GetButton(3);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(value);
	}

	// Token: 0x0600F08E RID: 61582 RVA: 0x0039B7C4 File Offset: 0x003999C4
	public void CheckCanUpgrade()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		if (activityData == null)
		{
			return;
		}
		if (!FunctionModel.Instance.IsOpen(10122))
		{
			return;
		}
		int lifeSupportLevel = HonamiStoryModel.Instance.GetPlayerData().LifeSupportLevel;
		int lifeSupportMaxLevel = HonamiStoryModel.Instance.GetPlayerData().GetLifeSupportMaxLevel();
		if (!this.IsInDungeon && lifeSupportLevel < lifeSupportMaxLevel)
		{
			int curLevelId = HonamiStoryModel.Instance.GetPlayerData().GetCurLevelId(lifeSupportLevel);
			Dictionary<int, int> dictionary = HonamiStoryConfig.Instance.GetLifeSupport(curLevelId).Value.ConsumeItems();
			int? num = null;
			int value;
			if (dictionary.TryGetValue(activityData.OutCoinItemId, out value))
			{
				num = new int?(value);
			}
			int currencyCount = HonamiStoryModel.Instance.GetCurrencyCount();
			bool flag;
			if (num != null)
			{
				int? num2 = num;
				int num3 = currencyCount;
				flag = (num2.GetValueOrDefault() <= num3 & num2 != null);
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			if (flag2 != this.IsAnimOn)
			{
				this.IsAnimOn = flag2;
				if (flag2)
				{
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer == null)
					{
						return;
					}
					levelSequencePlayer.PlayLevelSequenceByName("Tips_Circle", false, null, false);
					return;
				}
				else
				{
					UUINiagara uiNiagara = base.GetUiNiagara(7);
					if (uiNiagara == null)
					{
						return;
					}
					uiNiagara.SetUIActive(false);
				}
			}
			return;
		}
		UUINiagara uiNiagara2 = base.GetUiNiagara(7);
		if (uiNiagara2 == null)
		{
			return;
		}
		uiNiagara2.SetUIActive(false);
	}

	// Token: 0x0600F08F RID: 61583 RVA: 0x0039B904 File Offset: 0x00399B04
	private void OnClickedUpdate()
	{
		if (this.IsInDungeon)
		{
			return;
		}
		int lifeSupportLevel = HonamiStoryModel.Instance.GetPlayerData().LifeSupportLevel;
		int lifeSupportMaxLevel = HonamiStoryModel.Instance.GetPlayerData().GetLifeSupportMaxLevel();
		if (lifeSupportLevel < lifeSupportMaxLevel)
		{
			int num = lifeSupportLevel + 1;
			int num2 = lifeSupportLevel + 1;
			int id = num + 1;
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
			if (activityData == null)
			{
				return;
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(activityData.OutCoinItemId, 0);
			Dictionary<int, int> dictionary = HonamiStoryConfig.Instance.GetLifeSupport(num).Value.ConsumeItems();
			int? num3 = null;
			int value;
			if (dictionary.TryGetValue(activityData.OutCoinItemId, out value))
			{
				num3 = new int?(value);
			}
			int steadyValue = HonamiStoryConfig.Instance.GetLifeSupport(num).Value.SteadyValue;
			int steadyValue2 = HonamiStoryConfig.Instance.GetLifeSupport(id).Value.SteadyValue;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(activityData.OutCoinItemId);
			string value2 = string.Empty;
			if (itemConfigData != null && !string.IsNullOrEmpty(itemConfigData.IconSmall))
			{
				value2 = itemConfigData.IconSmall;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<texture=");
			stringBuilder.Append(value2);
			stringBuilder.Append("/>");
			int valueOrDefault = num3.GetValueOrDefault();
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.HonamiStoryLifeSupportLevelConfirm);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				valueOrDefault.ToString(),
				stringBuilder.ToString(),
				num2.ToString(),
				steadyValue.ToString(),
				steadyValue2.ToString()
			});
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.RequestForUpgrade));
			if (itemCountByConfigId < valueOrDefault)
			{
				confirmBoxDataNew.SetTipsBgRed = true;
				confirmBoxDataNew.SetTableTextArgNew("Text_NotEnoughItem_Text", Array.Empty<object>());
				confirmBoxDataNew.InteractionMap.Add(1, false);
			}
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}

	// Token: 0x0600F090 RID: 61584 RVA: 0x0039BAF8 File Offset: 0x00399CF8
	private void RequestForUpgrade()
	{
		HonamiStoryController.Instance.RequestHonamiStoryLifeSupportUp().ContinueWith(delegate(bool _)
		{
			this.RefreshLifeSupport();
		});
	}

	// Token: 0x0600F091 RID: 61585 RVA: 0x0039BB18 File Offset: 0x00399D18
	private void ShowSuccessPanel()
	{
		this.CheckCanUpgrade();
		int lifeSupportLevel = HonamiStoryModel.Instance.GetPlayerData().LifeSupportLevel;
		int lifeSupportMaxLevel = HonamiStoryModel.Instance.GetPlayerData().GetLifeSupportMaxLevel();
		int steadyValue = HonamiStoryConfig.Instance.GetLifeSupport(lifeSupportLevel).Value.SteadyValue;
		int steadyValue2 = HonamiStoryConfig.Instance.GetLifeSupport(lifeSupportLevel + 1).Value.SteadyValue;
		List<IAttributeInfo> list = new List<IAttributeInfo>();
		AttributeInfo item = new AttributeInfo
		{
			Name = "HonamiStory_Tech_TalentTreeTips",
			ShowArrow = new bool?(true),
			PreText = steadyValue.ToString(),
			CurText = steadyValue2.ToString()
		};
		list.Add(item);
		LevelUpSuccessAttributeData data = new LevelUpSuccessAttributeData
		{
			LevelInfo = new LevelInfo
			{
				PreUpgradeLv = lifeSupportLevel - 1,
				UpgradeLv = lifeSupportLevel,
				FormatStringId = "Text_LevelShow_Text",
				IsMaxLevel = new bool?(lifeSupportLevel == lifeSupportMaxLevel)
			},
			WiderScrollView = new bool?(true),
			AttributeInfo = list
		};
		RoleLevelUpSuccessController.Instance.OpenSuccessAttributeView(data, null);
	}

	// Token: 0x0600F092 RID: 61586 RVA: 0x0039BC30 File Offset: 0x00399E30
	private void OnPowerAnim(float _)
	{
		this.FrameCount++;
		int num = this.IsAdd ? 9 : 6;
		this.CurValue = (this.IsAdd ? ((int)Math.Ceiling((double)((float)this.OldValue + (float)((this.NewValue - this.OldValue) * this.FrameCount) / (float)num))) : ((int)Math.Floor((double)((float)this.OldValue - (float)((this.OldValue - this.NewValue) * this.FrameCount) / (float)num))));
		if (this.IsAdd)
		{
			this.CurValue = Math.Min(this.NewValue, this.CurValue);
		}
		else
		{
			this.CurValue = Math.Max(this.NewValue, this.CurValue);
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurValue);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		if (this.FrameCount < num)
		{
			this.AnimTimerHandle = TimerSystem.GameplayTimeInstance.Next(new TTimerAction(this.OnPowerAnim), null, null);
			return;
		}
		this.AnimTimerHandle = null;
	}

	// Token: 0x04006F45 RID: 28485
	private const int ADD_FRAME = 9;

	// Token: 0x04006F46 RID: 28486
	private const int DOWN_FRAME = 6;

	// Token: 0x04006F47 RID: 28487
	private bool ActivityOpen;

	// Token: 0x04006F48 RID: 28488
	private bool IsAnimOn;

	// Token: 0x04006F49 RID: 28489
	private int OldValue;

	// Token: 0x04006F4A RID: 28490
	private int CurValue;

	// Token: 0x04006F4B RID: 28491
	private int NewValue;

	// Token: 0x04006F4C RID: 28492
	private bool IsAdd;

	// Token: 0x04006F4D RID: 28493
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006F4E RID: 28494
	private TimerHandle AnimTimerHandle;

	// Token: 0x04006F4F RID: 28495
	private int FrameCount;

	// Token: 0x04006F50 RID: 28496
	private HonamiStoryLevelPowerItem PowerItem;

	// Token: 0x04006F51 RID: 28497
	private readonly bool IsInDungeon;

	// Token: 0x02008461 RID: 33889
	[NullableContext(0)]
	private enum EItem
	{
		// Token: 0x0402B167 RID: 176487
		TxtPower,
		// Token: 0x0402B168 RID: 176488
		TxtLevel,
		// Token: 0x0402B169 RID: 176489
		TxtNum,
		// Token: 0x0402B16A RID: 176490
		BtnUpdate,
		// Token: 0x0402B16B RID: 176491
		Bar,
		// Token: 0x0402B16C RID: 176492
		PowerItem,
		// Token: 0x0402B16D RID: 176493
		StateSprite,
		// Token: 0x0402B16E RID: 176494
		Niagara,
		// Token: 0x0402B16F RID: 176495
		SpriteMax,
		// Token: 0x0402B170 RID: 176496
		TexBg,
		// Token: 0x0402B171 RID: 176497
		PanelTips,
		// Token: 0x0402B172 RID: 176498
		TxtName
	}
}
