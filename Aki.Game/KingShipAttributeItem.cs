using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002035 RID: 8245
[NullableContext(2)]
[Nullable(0)]
public class KingShipAttributeItem : UiPanelBase
{
	// Token: 0x060102EB RID: 66283 RVA: 0x003F0A48 File Offset: 0x003EEC48
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(11, new Action(this.OnClickButton))
		};
	}

	// Token: 0x060102EC RID: 66284 RVA: 0x003F0B8F File Offset: 0x003EED8F
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x060102ED RID: 66285 RVA: 0x003F0BAC File Offset: 0x003EEDAC
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		this.RedSprite = base.GetSprite(4);
		this.NormalSprite = base.GetSprite(1);
		this.GreenSprite = base.GetSprite(5);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(delegate(string name)
		{
			if (name == "ArrowOut")
			{
				if (this.DownHideFlag)
				{
					base.GetItem(2).SetUIActive(false);
					this.DownHideFlag = false;
				}
				if (this.UpHideFlag)
				{
					base.GetItem(3).SetUIActive(false);
					this.UpHideFlag = false;
				}
			}
		}, false);
		this.BarSpeed = ConfigCommonParamById.GetFloatConfig("KingShipStaticAttributeChangeMoveSpeed").GetValueOrDefault();
		this.KingShipValueUseBigEffect = ConfigCommonParamById.GetFloatConfig("KingShipValueUseBigEffect").GetValueOrDefault();
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x060102EE RID: 66286 RVA: 0x003F0C60 File Offset: 0x003EEE60
	[NullableContext(1)]
	public void RefreshItem(IKingShipAttributeItemData data, Action<bool> onClickTipsCallBack)
	{
		this.HaveRefresh = true;
		this.AttributeId = data.AttributeId;
		this.OnClickTipsCallBack = onClickTipsCallBack;
		this.SetSpriteByPath(KingShipConfig.Instance.GetKingShipAttribute(data.AttributeId).Icon, base.GetSprite(0), false, null, null);
		this.MaxCount = data.MaxCount;
		this.MinCount = data.MinCount;
		this.CurrentCount = data.Current;
		UUISprite normalSprite = this.NormalSprite;
		if (normalSprite != null)
		{
			normalSprite.SetFillAmount((float)this.CurrentCount / (float)this.MaxCount);
		}
		UUISprite greenSprite = this.GreenSprite;
		if (greenSprite != null)
		{
			greenSprite.SetFillAmount(0f);
		}
		UUISprite redSprite = this.RedSprite;
		if (redSprite == null)
		{
			return;
		}
		redSprite.SetFillAmount(0f);
	}

	// Token: 0x060102EF RID: 66287 RVA: 0x003F0D28 File Offset: 0x003EEF28
	public void SetIsShow(bool isShow)
	{
		this.IsShowByKingShip = isShow;
		base.GetItem(10).SetUIActive(isShow);
		if (isShow)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
		}
		EventSystem.Instance.Emit<int, bool>(EEventName.OnKingShipAttrItemSetShow, this.AttributeId, isShow);
	}

	// Token: 0x060102F0 RID: 66288 RVA: 0x003F0D88 File Offset: 0x003EEF88
	public void RefreshAttribute(int valueChange)
	{
		this.CurrentCount += valueChange;
		this.CurrentCount = MathUtils.Instance.Clamp(this.CurrentCount, this.MinCount, this.MaxCount);
		this.IsRedSpriteMoving = false;
		this.IsGreenSpriteMoving = false;
		if (valueChange < 0)
		{
			UUISprite redSprite = this.RedSprite;
			if (redSprite != null)
			{
				UUISprite normalSprite = this.NormalSprite;
				redSprite.SetFillAmount((normalSprite != null) ? normalSprite.fillAmount : 0f);
			}
			UUISprite normalSprite2 = this.NormalSprite;
			if (normalSprite2 != null)
			{
				normalSprite2.SetFillAmount((float)this.CurrentCount / (float)this.MaxCount);
			}
			UUISprite normalSprite3 = this.NormalSprite;
			if (normalSprite3 != null)
			{
				normalSprite3.SetUIActive(false);
			}
			UUISprite greenSprite = this.GreenSprite;
			if (greenSprite != null)
			{
				greenSprite.SetFillAmount(0f);
			}
			this.IsRedSpriteMoving = true;
			return;
		}
		UUISprite greenSprite2 = this.GreenSprite;
		if (greenSprite2 != null)
		{
			UUISprite normalSprite4 = this.NormalSprite;
			greenSprite2.SetFillAmount((normalSprite4 != null) ? normalSprite4.fillAmount : 0f);
		}
		UUISprite normalSprite5 = this.NormalSprite;
		if (normalSprite5 != null)
		{
			normalSprite5.SetFillAmount((float)this.CurrentCount / (float)this.MaxCount);
		}
		UUISprite normalSprite6 = this.NormalSprite;
		if (normalSprite6 != null)
		{
			normalSprite6.SetUIActive(false);
		}
		UUISprite redSprite2 = this.RedSprite;
		if (redSprite2 != null)
		{
			redSprite2.SetFillAmount(0f);
		}
		this.IsGreenSpriteMoving = true;
	}

	// Token: 0x060102F1 RID: 66289 RVA: 0x003F0EC4 File Offset: 0x003EF0C4
	public void RefreshBuffItem(int buffChangeValue, int buffRounds)
	{
		if (buffChangeValue == 0)
		{
			return;
		}
		this.BuffValueList[buffChangeValue] = buffRounds;
	}

	// Token: 0x060102F2 RID: 66290 RVA: 0x003F0ED8 File Offset: 0x003EF0D8
	public void RefreshUpDownItem()
	{
		int num = 0;
		if (this.BuffValueList.Count <= 0)
		{
			this.SetDownItem(false);
			this.SetUpItem(false);
			return;
		}
		foreach (KeyValuePair<int, int> keyValuePair in this.BuffValueList)
		{
			num += keyValuePair.Key;
		}
		if (num > 0)
		{
			this.SetUpItem(true);
			this.SetDownItem(false);
			return;
		}
		this.SetUpItem(false);
		this.SetDownItem(true);
	}

	// Token: 0x060102F3 RID: 66291 RVA: 0x003F0F70 File Offset: 0x003EF170
	public void RefreshBuffRounds()
	{
		foreach (int key in new List<int>(this.BuffValueList.Keys))
		{
			int num = this.BuffValueList[key] - 1;
			if (num <= 0)
			{
				this.BuffValueList.Remove(key);
			}
			else
			{
				this.BuffValueList[key] = num;
			}
		}
	}

	// Token: 0x060102F4 RID: 66292 RVA: 0x003F0FF8 File Offset: 0x003EF1F8
	public void SetDownItem(bool visible)
	{
		if (base.GetItem(2).IsUIActiveSelf() != visible)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			if (visible)
			{
				base.GetItem(2).SetUIActive(true);
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.PlayLevelSequenceByName("ArrowIn", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 != null)
				{
					levelSequencePlayer3.PlayLevelSequenceByName("ArrowOut", false, null, false);
				}
				this.DownHideFlag = true;
			}
		}
	}

	// Token: 0x060102F5 RID: 66293 RVA: 0x003F1080 File Offset: 0x003EF280
	public void SetUpItem(bool visible)
	{
		if (base.GetItem(3).IsUIActiveSelf() != visible)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			if (visible)
			{
				base.GetItem(3).SetUIActive(true);
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.PlayLevelSequenceByName("ArrowIn", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 != null)
				{
					levelSequencePlayer3.PlayLevelSequenceByName("ArrowOut", false, null, false);
				}
				this.UpHideFlag = true;
			}
		}
	}

	// Token: 0x060102F6 RID: 66294 RVA: 0x003F1108 File Offset: 0x003EF308
	public void SetAttributeItem(bool visible, int value = 0)
	{
		if (!visible || value == 0)
		{
			base.GetItem(6).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			return;
		}
		bool flag = (float)Math.Abs(value) >= this.KingShipValueUseBigEffect;
		base.GetItem(6).SetUIActive(flag);
		base.GetItem(7).SetUIActive(!flag);
		if (flag)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayLevelSequenceByName("GLoop", false, null, false);
			return;
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
			if (levelSequencePlayer4 == null)
			{
				return;
			}
			levelSequencePlayer4.PlayLevelSequenceByName("Loop", false, null, false);
			return;
		}
	}

	// Token: 0x060102F7 RID: 66295 RVA: 0x003F11D0 File Offset: 0x003EF3D0
	public void Update()
	{
		if (this.GreenSprite == null || this.NormalSprite == null || this.RedSprite == null || (!this.IsRedSpriteMoving && !this.IsGreenSpriteMoving))
		{
			return;
		}
		if (this.IsGreenSpriteMoving)
		{
			if (this.GreenSprite.fillAmount < this.NormalSprite.fillAmount)
			{
				this.GreenSprite.SetUIActive(true);
				this.GreenSprite.SetFillAmount(this.GreenSprite.fillAmount + this.BarSpeed);
			}
			else
			{
				this.NormalSprite.SetUIActive(true);
				this.GreenSprite.SetUIActive(false);
				this.IsGreenSpriteMoving = false;
			}
		}
		if (this.IsRedSpriteMoving)
		{
			if (this.RedSprite.fillAmount > this.NormalSprite.fillAmount)
			{
				this.RedSprite.SetUIActive(true);
				this.RedSprite.SetFillAmount(this.RedSprite.fillAmount - this.BarSpeed);
				return;
			}
			this.NormalSprite.SetUIActive(true);
			this.RedSprite.SetUIActive(false);
			this.IsRedSpriteMoving = false;
		}
	}

	// Token: 0x060102F8 RID: 66296 RVA: 0x003F12DC File Offset: 0x003EF4DC
	private void OnClickButton()
	{
		if (this.AttributeId == 0)
		{
			return;
		}
		base.GetItem(8).SetUIActive(true);
		Action<bool> onClickTipsCallBack = this.OnClickTipsCallBack;
		if (onClickTipsCallBack != null)
		{
			onClickTipsCallBack(true);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.PlayOrReplaySequenceByName("InfoIn", false, null);
		}
		KingShipAttribute kingShipAttribute = KingShipConfig.Instance.GetKingShipAttribute(this.AttributeId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), kingShipAttribute.DesText, Array.Empty<object>());
	}

	// Token: 0x060102F9 RID: 66297 RVA: 0x003F1374 File Offset: 0x003EF574
	public void CloseTipsItem()
	{
		base.GetItem(8).SetUIActive(false);
		Action<bool> onClickTipsCallBack = this.OnClickTipsCallBack;
		if (onClickTipsCallBack != null)
		{
			onClickTipsCallBack(false);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayOrReplaySequenceByName("InfoOut", false, null);
	}

	// Token: 0x060102FA RID: 66298 RVA: 0x003F13D2 File Offset: 0x003EF5D2
	[NullableContext(1)]
	public UUIItem GetShowItem()
	{
		return base.GetItem(10);
	}

	// Token: 0x04007792 RID: 30610
	private int AttributeId;

	// Token: 0x04007793 RID: 30611
	private int MaxCount;

	// Token: 0x04007794 RID: 30612
	private int MinCount;

	// Token: 0x04007795 RID: 30613
	private float BarSpeed;

	// Token: 0x04007796 RID: 30614
	private float KingShipValueUseBigEffect;

	// Token: 0x04007797 RID: 30615
	public int CurrentCount;

	// Token: 0x04007798 RID: 30616
	public bool HaveRefresh;

	// Token: 0x04007799 RID: 30617
	private bool IsRedSpriteMoving;

	// Token: 0x0400779A RID: 30618
	private bool IsGreenSpriteMoving;

	// Token: 0x0400779B RID: 30619
	private UUISprite RedSprite;

	// Token: 0x0400779C RID: 30620
	private UUISprite GreenSprite;

	// Token: 0x0400779D RID: 30621
	private UUISprite NormalSprite;

	// Token: 0x0400779E RID: 30622
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400779F RID: 30623
	public Action<bool> OnClickTipsCallBack;

	// Token: 0x040077A0 RID: 30624
	private bool UpHideFlag;

	// Token: 0x040077A1 RID: 30625
	private bool DownHideFlag;

	// Token: 0x040077A2 RID: 30626
	[Nullable(1)]
	private readonly Dictionary<int, int> BuffValueList = new Dictionary<int, int>();

	// Token: 0x040077A3 RID: 30627
	public bool IsShowByKingShip;

	// Token: 0x0200862F RID: 34351
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402BA9E RID: 178846
		public const int IconSprite = 0;

		// Token: 0x0402BA9F RID: 178847
		public const int BarSprite = 1;

		// Token: 0x0402BAA0 RID: 178848
		public const int DownItem = 2;

		// Token: 0x0402BAA1 RID: 178849
		public const int UpItem = 3;

		// Token: 0x0402BAA2 RID: 178850
		public const int RedBarSprite = 4;

		// Token: 0x0402BAA3 RID: 178851
		public const int GreenBarSprite = 5;

		// Token: 0x0402BAA4 RID: 178852
		public const int StrongEffectItem = 6;

		// Token: 0x0402BAA5 RID: 178853
		public const int WeekEffectItem = 7;

		// Token: 0x0402BAA6 RID: 178854
		public const int TipsItem = 8;

		// Token: 0x0402BAA7 RID: 178855
		public const int TipsText = 9;

		// Token: 0x0402BAA8 RID: 178856
		public const int ShowItem = 10;

		// Token: 0x0402BAA9 RID: 178857
		public const int Button = 11;
	}
}
