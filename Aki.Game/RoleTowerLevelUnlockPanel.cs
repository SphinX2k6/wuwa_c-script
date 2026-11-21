using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CD5 RID: 7381
public class RoleTowerLevelUnlockPanel : UiPanelBase
{
	// Token: 0x0601246C RID: 74860 RVA: 0x005638BB File Offset: 0x00561ABB
	public void SetGroupId(int groupId)
	{
		this.GroupId = groupId;
	}

	// Token: 0x0601246D RID: 74861 RVA: 0x005638C4 File Offset: 0x00561AC4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(12, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUITexture)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickRank)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickRestart)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickStartAtSave)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickStart)),
			new ValueTuple<int, Delegate>(11, new Action<EToggleState>(this.OnToggleRoleUpgrade)),
			new ValueTuple<int, Delegate>(12, new Action<EToggleState>(this.OnToggleBestRecord))
		};
	}

	// Token: 0x0601246E RID: 74862 RVA: 0x00563B28 File Offset: 0x00561D28
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerLevelUnlockPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerLevelUnlockPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601246F RID: 74863 RVA: 0x00563B6B File Offset: 0x00561D6B
	protected override void OnBeforeDestroy()
	{
		this.CancelLoadVideoMaterial();
		MediaPlayer mediaPlayer = this.MediaPlayer;
		if (mediaPlayer != null)
		{
			mediaPlayer.Clear();
		}
		this.MediaPlayer = null;
	}

	// Token: 0x06012470 RID: 74864 RVA: 0x00563B8C File Offset: 0x00561D8C
	private UniTask LoadVideoMaterial()
	{
		RoleTowerLevelUnlockPanel.<LoadVideoMaterial>d__11 <LoadVideoMaterial>d__;
		<LoadVideoMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadVideoMaterial>d__.<>4__this = this;
		<LoadVideoMaterial>d__.<>1__state = -1;
		<LoadVideoMaterial>d__.<>t__builder.Start<RoleTowerLevelUnlockPanel.<LoadVideoMaterial>d__11>(ref <LoadVideoMaterial>d__);
		return <LoadVideoMaterial>d__.<>t__builder.Task;
	}

	// Token: 0x06012471 RID: 74865 RVA: 0x00563BCF File Offset: 0x00561DCF
	private void CancelLoadVideoMaterial()
	{
		if (this.MaterialHandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.MaterialHandleId);
			this.MaterialHandleId = -1;
		}
	}

	// Token: 0x06012472 RID: 74866 RVA: 0x00563BF4 File Offset: 0x00561DF4
	public void Refresh(int levelId, bool isUnlock)
	{
		RoleTowerLevelData levelState = RoleTowerModel.Instance.GetLevelState(levelId);
		bool flag = levelState != null && levelState.BestPassWave > 0;
		this.HasRecord = flag;
		bool flag2 = levelState != null && levelState.HasSave;
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		if (flag)
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(levelState.BestPassWave.ToString(), true);
			}
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				text2.SetText(RoleTowerTimeUtil.Format(levelState.BestRemainTime), true);
			}
		}
		UUIText text3 = base.GetText(3);
		if (text3 != null)
		{
			text3.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(6);
		if (item3 != null)
		{
			item3.SetUIActive(flag2);
		}
		if (flag2 && levelState != null)
		{
			string saveFloorName = RoleTowerModel.Instance.GetSaveFloorName(levelId);
			if (string.IsNullOrEmpty(saveFloorName))
			{
				UUIText text4 = base.GetText(7);
				if (text4 != null)
				{
					text4.SetText(levelState.SaveFloorIndex.ToString(), true);
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), saveFloorName, Array.Empty<object>());
			}
		}
		UUIButtonComponent button = base.GetButton(10);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(isUnlock && !flag2);
			}
		}
		UUIButtonComponent button2 = base.GetButton(8);
		if (button2 != null)
		{
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(isUnlock && flag2);
			}
		}
		UUIButtonComponent button3 = base.GetButton(9);
		if (button3 != null)
		{
			UUIItem uuiitem3 = button3.RootUIComp.Get();
			if (uuiitem3 != null)
			{
				uuiitem3.SetUIActive(isUnlock && flag2);
			}
		}
		this.RefreshRoleUpgrade(levelId);
		this.ApplyTab(!flag);
	}

	// Token: 0x06012473 RID: 74867 RVA: 0x00563DA8 File Offset: 0x00561FA8
	private void RefreshRoleUpgrade(int levelId)
	{
		RoleTowerLevel? levelCfg = RoleTowerModel.Instance.GetLevelCfg(levelId);
		string text = ((levelCfg != null) ? levelCfg.GetValueOrDefault().VideoName : null) ?? string.Empty;
		string text2 = ((levelCfg != null) ? levelCfg.GetValueOrDefault().VideoPath : null) ?? string.Empty;
		bool flag = !string.IsNullOrEmpty(text2);
		UUIItem item = base.GetItem(17);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUITexture texture = base.GetTexture(15);
		if (texture != null)
		{
			texture.SetUIActive(flag);
		}
		UUIText text3 = base.GetText(16);
		if (text3 != null)
		{
			text3.SetUIActive(flag && !string.IsNullOrEmpty(text));
		}
		if (!flag)
		{
			this.PlayingVideoLevelId = 0;
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), text, Array.Empty<object>());
		if (this.PlayingVideoLevelId != levelId)
		{
			this.PlayingVideoLevelId = levelId;
			MediaPlayer mediaPlayer = this.MediaPlayer;
			if (mediaPlayer == null)
			{
				return;
			}
			mediaPlayer.PlayVideo(text, text2, true);
		}
	}

	// Token: 0x06012474 RID: 74868 RVA: 0x00563EAC File Offset: 0x005620AC
	private void ApplyTab(bool showRoleUpgrade)
	{
		this.ShowRoleUpgrade = showRoleUpgrade;
		UUIExtendToggle extendToggle = base.GetExtendToggle(11);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(showRoleUpgrade ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(12);
		if (extendToggle2 != null)
		{
			extendToggle2.SetToggleStateForce(showRoleUpgrade ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
		}
		UUIItem item = base.GetItem(14);
		if (item != null)
		{
			item.SetUIActive(showRoleUpgrade);
		}
		UUIItem item2 = base.GetItem(13);
		if (item2 != null)
		{
			item2.SetUIActive(!showRoleUpgrade);
		}
		UUIItem item3 = base.GetItem(18);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(!showRoleUpgrade && !this.HasRecord);
	}

	// Token: 0x06012475 RID: 74869 RVA: 0x00563F46 File Offset: 0x00562146
	private void OnToggleRoleUpgrade(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ApplyTab(true);
		}
	}

	// Token: 0x06012476 RID: 74870 RVA: 0x00563F53 File Offset: 0x00562153
	private void OnToggleBestRecord(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ApplyTab(false);
		}
	}

	// Token: 0x06012477 RID: 74871 RVA: 0x00563F60 File Offset: 0x00562160
	private void OnClickRank()
	{
		RoleTowerModel.Instance.OpenRankView(RoleTowerModel.Instance.CurSelectLevel);
	}

	// Token: 0x06012478 RID: 74872 RVA: 0x00563F76 File Offset: 0x00562176
	private void OnClickStart()
	{
		RoleTowerModel.Instance.OpenPrepareView(RoleTowerModel.Instance.CurSelectLevel, false, false, false);
	}

	// Token: 0x06012479 RID: 74873 RVA: 0x00563F8F File Offset: 0x0056218F
	private void OnClickStartAtSave()
	{
		RoleTowerModel.Instance.OpenPrepareView(RoleTowerModel.Instance.CurSelectLevel, true, false, false);
	}

	// Token: 0x0601247A RID: 74874 RVA: 0x00563FA8 File Offset: 0x005621A8
	private void OnClickRestart()
	{
		RoleTowerModel.Instance.ConfirmDeleteSaveAndRestart(RoleTowerModel.Instance.CurSelectLevel);
	}

	// Token: 0x04009F8F RID: 40847
	private int GroupId;

	// Token: 0x04009F90 RID: 40848
	private bool ShowRoleUpgrade;

	// Token: 0x04009F91 RID: 40849
	private bool HasRecord;

	// Token: 0x04009F92 RID: 40850
	[Nullable(2)]
	private MediaPlayer MediaPlayer;

	// Token: 0x04009F93 RID: 40851
	private int PlayingVideoLevelId;

	// Token: 0x04009F94 RID: 40852
	private int MaterialHandleId = -1;

	// Token: 0x02007FCE RID: 32718
	private static class EChildType
	{
		// Token: 0x04029581 RID: 169345
		public const int PnlContent = 0;

		// Token: 0x04029582 RID: 169346
		public const int TxtWaveValue = 1;

		// Token: 0x04029583 RID: 169347
		public const int TxtRemainTime = 2;

		// Token: 0x04029584 RID: 169348
		public const int TxtUseTime = 3;

		// Token: 0x04029585 RID: 169349
		public const int BtnArchiveFunc = 4;

		// Token: 0x04029586 RID: 169350
		public const int PnlBestRecordEmpty = 5;

		// Token: 0x04029587 RID: 169351
		public const int PnlRecordProgress = 6;

		// Token: 0x04029588 RID: 169352
		public const int TxtRecordValue = 7;

		// Token: 0x04029589 RID: 169353
		public const int BtnRestart = 8;

		// Token: 0x0402958A RID: 169354
		public const int BtnStarAtRecord = 9;

		// Token: 0x0402958B RID: 169355
		public const int BtnStar = 10;

		// Token: 0x0402958C RID: 169356
		public const int TogTopTabItemA = 11;

		// Token: 0x0402958D RID: 169357
		public const int TogTopTabItemB = 12;

		// Token: 0x0402958E RID: 169358
		public const int PnlBestRecord = 13;

		// Token: 0x0402958F RID: 169359
		public const int PnlRoleUpgrade = 14;

		// Token: 0x04029590 RID: 169360
		public const int CG = 15;

		// Token: 0x04029591 RID: 169361
		public const int TxtDesc = 16;

		// Token: 0x04029592 RID: 169362
		public const int PnlRoleUpgradeEmpty = 17;

		// Token: 0x04029593 RID: 169363
		public const int PnlRecordTabEmpty = 18;
	}
}
