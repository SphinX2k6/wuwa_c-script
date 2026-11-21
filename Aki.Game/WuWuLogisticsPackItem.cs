using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000B23 RID: 2851
[NullableContext(1)]
[Nullable(0)]
public class WuWuLogisticsPackItem : GridProxyAbstract<int>
{
	// Token: 0x060075A8 RID: 30120 RVA: 0x002457B0 File Offset: 0x002439B0
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

	// Token: 0x060075A9 RID: 30121 RVA: 0x002458C8 File Offset: 0x00243AC8
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060075AA RID: 30122 RVA: 0x002458DB File Offset: 0x00243ADB
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x060075AB RID: 30123 RVA: 0x002458E4 File Offset: 0x00243AE4
	public void SetPackToggleInteractive(bool interactive)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(interactive);
	}

	// Token: 0x060075AC RID: 30124 RVA: 0x002458F8 File Offset: 0x00243AF8
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

	// Token: 0x060075AD RID: 30125 RVA: 0x002459F4 File Offset: 0x00243BF4
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

	// Token: 0x060075AE RID: 30126 RVA: 0x00245B1F File Offset: 0x00243D1F
	private void OnClicked(EToggleState state)
	{
		Action<int> clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback(this.CfgId);
	}

	// Token: 0x060075AF RID: 30127 RVA: 0x00245B37 File Offset: 0x00243D37
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleSelect(true);
	}

	// Token: 0x060075B0 RID: 30128 RVA: 0x00245B40 File Offset: 0x00243D40
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleSelect(false);
	}

	// Token: 0x060075B1 RID: 30129 RVA: 0x00245B4C File Offset: 0x00243D4C
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

	// Token: 0x060075B2 RID: 30130 RVA: 0x00245B94 File Offset: 0x00243D94
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

	// Token: 0x04004A55 RID: 19029
	private int CfgId;

	// Token: 0x04004A56 RID: 19030
	private Action<int> ClickCallback = delegate(int _)
	{
	};

	// Token: 0x04004A57 RID: 19031
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;
}
