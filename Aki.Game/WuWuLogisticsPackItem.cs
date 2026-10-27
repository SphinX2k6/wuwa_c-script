using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200166B RID: 5739
[NullableContext(1)]
[Nullable(0)]
public class WuWuLogisticsPackItem : GridProxyAbstract<int>
{
	// Token: 0x0600A1CA RID: 41418 RVA: 0x0023B914 File Offset: 0x00239B14
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClicked))
		};
	}

	// Token: 0x0600A1CB RID: 41419 RVA: 0x0023BA2C File Offset: 0x00239C2C
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600A1CC RID: 41420 RVA: 0x0023BA3F File Offset: 0x00239C3F
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x0600A1CD RID: 41421 RVA: 0x0023BA48 File Offset: 0x00239C48
	public void SetPackToggleInteractive(bool interactive)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(interactive);
	}

	// Token: 0x0600A1CE RID: 41422 RVA: 0x0023BA5C File Offset: 0x00239C5C
	public override void Refresh(int cfgId, bool isSelected, int gridIndex)
	{
		this.CfgId = cfgId;
		this.SetToggleSelect(isSelected);
		WuWuTaskPackage? taskPackageById = WuWuLogisticsConfig.Instance.GetTaskPackageById(this.CfgId);
		if (taskPackageById != null)
		{
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.ShowTextNew(taskPackageById.Value.Title);
			}
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_TurntableNormal_Index0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CfgId);
		string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(4), false, null, null);
		this.RefreshStateInfo();
		this.PlaySequencePurely();
		WuWuLogisticsActivityData activityData = WuWuLogisticsActivityController.Instance.GetActivityData();
		bool uiactive = (activityData != null && activityData.TargetPackChildTaskHasReceiveReward(this.CfgId)) || (activityData != null && activityData.TargetPackHasReceiveReward(this.CfgId));
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600A1CF RID: 41423 RVA: 0x0023BB58 File Offset: 0x00239D58
	private void RefreshStateInfo()
	{
		UUIItem item = base.GetItem(1);
		UUIItem item2 = base.GetItem(2);
		UUIItem item3 = base.GetItem(3);
		UUITexture texture = base.GetTexture(8);
		UUISprite sprite = base.GetSprite(7);
		UUIItem item4 = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		int activityId = WuWuLogisticsActivityController.Instance.ActivityId;
		WuWuLogisticsActivityData wuWuLogisticsActivityData = ActivityModel.Instance.GetActivityById(activityId) as WuWuLogisticsActivityData;
		if (wuWuLogisticsActivityData == null)
		{
			return;
		}
		if (wuWuLogisticsActivityData.GetTaskPackById(this.CfgId) == null)
		{
			return;
		}
		if (wuWuLogisticsActivityData.TargetPackIsFullyRewarded(this.CfgId))
		{
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			if (item4 != null)
			{
				item4.SetUIActive(true);
			}
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			return;
		}
		if (!wuWuLogisticsActivityData.IsPackUnlocked(this.CfgId))
		{
			if (item4 != null)
			{
				item4.SetUIActive(true);
			}
			if (item != null)
			{
				item.SetUIActive(true);
			}
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			return;
		}
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
	}

	// Token: 0x0600A1D0 RID: 41424 RVA: 0x0023BC83 File Offset: 0x00239E83
	private void OnClicked(EToggleState state)
	{
		Action<int> clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback(this.CfgId);
	}

	// Token: 0x0600A1D1 RID: 41425 RVA: 0x0023BC9B File Offset: 0x00239E9B
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleSelect(true);
	}

	// Token: 0x0600A1D2 RID: 41426 RVA: 0x0023BCA4 File Offset: 0x00239EA4
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleSelect(false);
	}

	// Token: 0x0600A1D3 RID: 41427 RVA: 0x0023BCB0 File Offset: 0x00239EB0
	public void SetToggleSelect(bool select)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		UUISprite sprite = base.GetSprite(4);
		FColor changeColor = sprite.changeColor;
		FColor? fcolor = new FColor?(changeColor);
		sprite.SetChangeColor(select, fcolor);
	}

	// Token: 0x0600A1D4 RID: 41428 RVA: 0x0023BCF8 File Offset: 0x00239EF8
	public void PlaySequencePurely()
	{
		if (this.SeqPlayer != null && this.SeqPlayer.IsPlayingSequence("Loop"))
		{
			return;
		}
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.PlayLevelSequenceByName("Loop", false, null, false);
	}

	// Token: 0x040049AF RID: 18863
	private int CfgId;

	// Token: 0x040049B0 RID: 18864
	private Action<int> ClickCallback = delegate(int _)
	{
	};

	// Token: 0x040049B1 RID: 18865
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;
}
