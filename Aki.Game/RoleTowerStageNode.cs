using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D00 RID: 7424
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerStageNode : UiPanelBase
{
	// Token: 0x17001B74 RID: 7028
	// (get) Token: 0x06012617 RID: 75287 RVA: 0x0056DC5A File Offset: 0x0056BE5A
	// (set) Token: 0x06012618 RID: 75288 RVA: 0x0056DC62 File Offset: 0x0056BE62
	public int StageId { get; private set; }

	// Token: 0x06012619 RID: 75289 RVA: 0x0056DC6C File Offset: 0x0056BE6C
	public UUIItem GetTogUiItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.RootUIComp.Get();
	}

	// Token: 0x0601261A RID: 75290 RVA: 0x0056DC94 File Offset: 0x0056BE94
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTog))
		};
	}

	// Token: 0x0601261B RID: 75291 RVA: 0x0056DDDC File Offset: 0x0056BFDC
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
		base.GetExtendToggle(0).OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnTogPointDown));
		this.FloorPointLayout = new GenericLayout<RoleTowerWavePointItem, RoleTowerFloorPointData>(base.GetHorizontalLayout(3), () => new RoleTowerWavePointItem(), null, false, true);
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0601261C RID: 75292 RVA: 0x0056DE58 File Offset: 0x0056C058
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.OnPointDownCallBack.Unbind();
	}

	// Token: 0x0601261D RID: 75293 RVA: 0x0056DE70 File Offset: 0x0056C070
	[NullableContext(1)]
	public void Refresh(RoleTowerStageNodeData data, bool isSelected)
	{
		this.StageId = data.StageId;
		this.StageSeq = data.StageSeq;
		RoleTowerStage? stageCfg = RoleTowerModel.Instance.GetStageCfg(this.StageId);
		bool flag = stageCfg != null;
		RoleTowerStageData stageState = RoleTowerModel.Instance.GetStageState(this.StageId);
		bool flag2 = stageState != null && stageState.IsPassed;
		bool isChallengeable = data.IsChallengeable;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		if (isSelected && !this.IsSelected)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayLevelSequenceByName("Selected", false, null, false);
			}
		}
		this.IsSelected = isSelected;
		this.RefreshStageBg(flag, stageCfg);
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(isChallengeable);
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 != null)
		{
			item2.SetUIActive(!isChallengeable && flag2);
		}
		UUIItem item3 = base.GetItem(7);
		if (item3 != null)
		{
			item3.SetUIActive(!isChallengeable && !flag2);
		}
		this.RefreshStageIcon(flag, stageCfg);
		if (flag && !string.IsNullOrEmpty(stageCfg.Value.RoleTowerStageName))
		{
			UUIText text = base.GetText(10);
			if (text != null)
			{
				text.ShowTextNew(stageCfg.Value.RoleTowerStageName);
			}
		}
		this.RefreshFloorPoints(isSelected, flag2);
		this.RefreshTimeDelta(flag2, stageState);
	}

	// Token: 0x0601261E RID: 75294 RVA: 0x0056DFD0 File Offset: 0x0056C1D0
	public void SetCentered(bool isCentered)
	{
		if (this.IsCentered == isCentered)
		{
			return;
		}
		this.IsCentered = isCentered;
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopSequenceByKey(isCentered ? "ActivateOut" : "Activate", false, false);
		}
		LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 == null)
		{
			return;
		}
		sequencePlayer2.PlayLevelSequenceByName(isCentered ? "Activate" : "ActivateOut", false, null, false);
	}

	// Token: 0x0601261F RID: 75295 RVA: 0x0056E03C File Offset: 0x0056C23C
	private void RefreshStageBg(bool hasCfg, RoleTowerStage? cfgOpt)
	{
		UUITexture texture = base.GetTexture(1);
		UUITexture texture2 = base.GetTexture(2);
		UUITexture texture3 = base.GetTexture(11);
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		if (texture2 != null)
		{
			texture2.SetUIActive(false);
		}
		if (texture3 != null)
		{
			texture3.SetUIActive(false);
		}
		string text = hasCfg ? cfgOpt.Value.RoleTowerStageIconBg : null;
		if (!string.IsNullOrEmpty(text) && text != "0")
		{
			if (texture != null)
			{
				texture.SetUIActive(true);
				base.SetTextureByPath(text, texture, null, null);
			}
			return;
		}
		bool flag = this.IsLastStage();
		if (texture != null)
		{
			texture.SetUIActive(!flag);
		}
		if (texture2 != null)
		{
			texture2.SetUIActive(flag);
		}
	}

	// Token: 0x06012620 RID: 75296 RVA: 0x0056E0EC File Offset: 0x0056C2EC
	private void RefreshStageIcon(bool hasCfg, RoleTowerStage? cfgOpt)
	{
		UUISprite sprite = base.GetSprite(5);
		if (sprite == null)
		{
			return;
		}
		string text = hasCfg ? cfgOpt.Value.RoleTowerStageIcon : null;
		if (string.IsNullOrEmpty(text))
		{
			sprite.SetUIActive(false);
			return;
		}
		sprite.SetUIActive(true);
		this.SetSpriteByPath(text, sprite, false, null, null);
	}

	// Token: 0x06012621 RID: 75297 RVA: 0x0056E148 File Offset: 0x0056C348
	private void RefreshFloorPoints(bool isSelected, bool stagePassed)
	{
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		int count = RoleTowerModel.Instance.GetStageFloorPassedList(curSelectLevel, this.StageSeq).Count;
		List<RoleTowerFloorPointData> list = new List<RoleTowerFloorPointData>(count);
		for (int i = 0; i < count; i++)
		{
			list.Add(new RoleTowerFloorPointData
			{
				IsPassed = stagePassed
			});
		}
		GenericLayout<RoleTowerWavePointItem, RoleTowerFloorPointData> floorPointLayout = this.FloorPointLayout;
		if (floorPointLayout == null)
		{
			return;
		}
		floorPointLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06012622 RID: 75298 RVA: 0x0056E1B0 File Offset: 0x0056C3B0
	private void RefreshTimeDelta(bool isPassed, RoleTowerStageData state)
	{
		UUIText text = base.GetText(6);
		if (text == null)
		{
			return;
		}
		if (isPassed && state != null)
		{
			text.SetUIActive(true);
			text.SetText(RoleTowerTimeUtil.Format(state.PassRemainTime), true);
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x06012623 RID: 75299 RVA: 0x0056E1F0 File Offset: 0x0056C3F0
	private bool IsLastStage()
	{
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		IReadOnlyList<RoleTowerStage> stageCfgListByLevel = RoleTowerModel.Instance.GetStageCfgListByLevel(curSelectLevel);
		return stageCfgListByLevel.Count > 0 && this.StageSeq >= stageCfgListByLevel.Count;
	}

	// Token: 0x06012624 RID: 75300 RVA: 0x0056E230 File Offset: 0x0056C430
	private void OnClickTog(EToggleState check)
	{
		if (check == EToggleState.ETT_Checked)
		{
			RoleTowerModel.Instance.SelectStage(this.StageId);
		}
	}

	// Token: 0x06012625 RID: 75301 RVA: 0x0056E246 File Offset: 0x0056C446
	private void OnTogPointDown(EToggleState state)
	{
		if (this.StageId == RoleTowerModel.Instance.CurSelectStage)
		{
			RoleTowerModel.Instance.SelectStage(this.StageId);
		}
	}

	// Token: 0x0400A02D RID: 41005
	private int StageSeq;

	// Token: 0x0400A02E RID: 41006
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerWavePointItem, RoleTowerFloorPointData> FloorPointLayout;

	// Token: 0x0400A02F RID: 41007
	[Nullable(1)]
	private const string SequenceSelected = "Selected";

	// Token: 0x0400A030 RID: 41008
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400A031 RID: 41009
	private bool IsCentered;

	// Token: 0x0400A032 RID: 41010
	private bool IsSelected;

	// Token: 0x0200802A RID: 32810
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402977B RID: 169851
		public const int TogItem = 0;

		// Token: 0x0402977C RID: 169852
		public const int TexItemBg = 1;

		// Token: 0x0402977D RID: 169853
		public const int TexItemBgRed = 2;

		// Token: 0x0402977E RID: 169854
		public const int PnlLevelProgress = 3;

		// Token: 0x0402977F RID: 169855
		public const int UiItemLevelProgressPoint = 4;

		// Token: 0x04029780 RID: 169856
		public const int SprLevelNum = 5;

		// Token: 0x04029781 RID: 169857
		public const int TxtLevelTime = 6;

		// Token: 0x04029782 RID: 169858
		public const int PnlStateLock = 7;

		// Token: 0x04029783 RID: 169859
		public const int PnlStateFinished = 8;

		// Token: 0x04029784 RID: 169860
		public const int PnlStateCurr = 9;

		// Token: 0x04029785 RID: 169861
		public const int TxtLevelName = 10;

		// Token: 0x04029786 RID: 169862
		public const int TexItemBgGreen = 11;
	}
}
