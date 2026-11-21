using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001508 RID: 5384
[NullableContext(2)]
[Nullable(0)]
public class KingShipAttributeItem : UiPanelBase
{
	// Token: 0x0600D753 RID: 55123 RVA: 0x003FD040 File Offset: 0x003FB240
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

	// Token: 0x0600D754 RID: 55124 RVA: 0x003FD187 File Offset: 0x003FB387
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600D755 RID: 55125 RVA: 0x003FD1A4 File Offset: 0x003FB3A4
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

	// Token: 0x0600D756 RID: 55126 RVA: 0x003FD258 File Offset: 0x003FB458
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

	// Token: 0x0600D757 RID: 55127 RVA: 0x003FD320 File Offset: 0x003FB520
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

	// Token: 0x0600D758 RID: 55128 RVA: 0x003FD380 File Offset: 0x003FB580
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

	// Token: 0x0600D759 RID: 55129 RVA: 0x003FD4BC File Offset: 0x003FB6BC
	public void RefreshBuffItem(int buffChangeValue, int buffRounds)
	{
		if (buffChangeValue == 0)
		{
			return;
		}
		this.BuffValueList[buffChangeValue] = buffRounds;
	}

	// Token: 0x0600D75A RID: 55130 RVA: 0x003FD4D0 File Offset: 0x003FB6D0
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

	// Token: 0x0600D75B RID: 55131 RVA: 0x003FD568 File Offset: 0x003FB768
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

	// Token: 0x0600D75C RID: 55132 RVA: 0x003FD5F0 File Offset: 0x003FB7F0
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

	// Token: 0x0600D75D RID: 55133 RVA: 0x003FD678 File Offset: 0x003FB878
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

	// Token: 0x0600D75E RID: 55134 RVA: 0x003FD700 File Offset: 0x003FB900
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

	// Token: 0x0600D75F RID: 55135 RVA: 0x003FD7C8 File Offset: 0x003FB9C8
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

	// Token: 0x0600D760 RID: 55136 RVA: 0x003FD8D4 File Offset: 0x003FBAD4
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

	// Token: 0x0600D761 RID: 55137 RVA: 0x003FD96C File Offset: 0x003FBB6C
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

	// Token: 0x0600D762 RID: 55138 RVA: 0x003FD9CA File Offset: 0x003FBBCA
	[NullableContext(1)]
	public UUIItem GetShowItem()
	{
		return base.GetItem(10);
	}

	// Token: 0x0400787B RID: 30843
	private int AttributeId;

	// Token: 0x0400787C RID: 30844
	private int MaxCount;

	// Token: 0x0400787D RID: 30845
	private int MinCount;

	// Token: 0x0400787E RID: 30846
	private float BarSpeed;

	// Token: 0x0400787F RID: 30847
	private float KingShipValueUseBigEffect;

	// Token: 0x04007880 RID: 30848
	public int CurrentCount;

	// Token: 0x04007881 RID: 30849
	public bool HaveRefresh;

	// Token: 0x04007882 RID: 30850
	private bool IsRedSpriteMoving;

	// Token: 0x04007883 RID: 30851
	private bool IsGreenSpriteMoving;

	// Token: 0x04007884 RID: 30852
	private UUISprite RedSprite;

	// Token: 0x04007885 RID: 30853
	private UUISprite GreenSprite;

	// Token: 0x04007886 RID: 30854
	private UUISprite NormalSprite;

	// Token: 0x04007887 RID: 30855
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007888 RID: 30856
	public Action<bool> OnClickTipsCallBack;

	// Token: 0x04007889 RID: 30857
	private bool UpHideFlag;

	// Token: 0x0400788A RID: 30858
	private bool DownHideFlag;

	// Token: 0x0400788B RID: 30859
	[Nullable(1)]
	private readonly Dictionary<int, int> BuffValueList = new Dictionary<int, int>();

	// Token: 0x0400788C RID: 30860
	public bool IsShowByKingShip;

	// Token: 0x020077B6 RID: 30646
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04026DAD RID: 159149
		public const int IconSprite = 0;

		// Token: 0x04026DAE RID: 159150
		public const int BarSprite = 1;

		// Token: 0x04026DAF RID: 159151
		public const int DownItem = 2;

		// Token: 0x04026DB0 RID: 159152
		public const int UpItem = 3;

		// Token: 0x04026DB1 RID: 159153
		public const int RedBarSprite = 4;

		// Token: 0x04026DB2 RID: 159154
		public const int GreenBarSprite = 5;

		// Token: 0x04026DB3 RID: 159155
		public const int StrongEffectItem = 6;

		// Token: 0x04026DB4 RID: 159156
		public const int WeekEffectItem = 7;

		// Token: 0x04026DB5 RID: 159157
		public const int TipsItem = 8;

		// Token: 0x04026DB6 RID: 159158
		public const int TipsText = 9;

		// Token: 0x04026DB7 RID: 159159
		public const int ShowItem = 10;

		// Token: 0x04026DB8 RID: 159160
		public const int Button = 11;
	}
}
