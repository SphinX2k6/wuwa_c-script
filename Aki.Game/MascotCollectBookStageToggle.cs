using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013D3 RID: 5075
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MascotCollectBookStageToggle : GridProxyAbstract<HonamiStoryAreaData>
{
	// Token: 0x0600C92E RID: 51502 RVA: 0x003BDEAD File Offset: 0x003BC0AD
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
	}

	// Token: 0x0600C92F RID: 51503 RVA: 0x003BDEC8 File Offset: 0x003BC0C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggle))
		};
	}

	// Token: 0x0600C930 RID: 51504 RVA: 0x003BE025 File Offset: 0x003BC225
	protected override void OnStart()
	{
		if (this.ActivityData == null)
		{
			this.ActivityData = HonamiStoryModel.Instance.GetActivityData(true);
		}
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x1700134E RID: 4942
	// (get) Token: 0x0600C931 RID: 51505 RVA: 0x003BE050 File Offset: 0x003BC250
	public HonamiStoryAreaData Data
	{
		get
		{
			return this.AreaData;
		}
	}

	// Token: 0x0600C932 RID: 51506 RVA: 0x003BE058 File Offset: 0x003BC258
	public override void Refresh(HonamiStoryAreaData areaData, bool isSelected, int gridIndex)
	{
		this.AreaData = areaData;
		this.RefreshItem();
		if (areaData.IsSecretFinished)
		{
			UiBehaviorLevelSequence levelPlaySequence = this.LevelPlaySequence;
			if (levelPlaySequence == null)
			{
				return;
			}
			levelPlaySequence.PlaySequence("Unlock", false, null);
		}
	}

	// Token: 0x0600C933 RID: 51507 RVA: 0x003BE09C File Offset: 0x003BC29C
	private void RefreshItem()
	{
		bool isAreaUnlock = this.AreaData.IsAreaUnlock;
		base.GetItem(9).SetUIActive(!isAreaUnlock);
		base.GetItem(10).SetUIActive(isAreaUnlock);
		base.GetItem(11).SetUIActive(isAreaUnlock);
		base.GetExtendToggle(0).SetSelfInteractive(isAreaUnlock);
		UUIText text = base.GetText(8);
		if (text != null)
		{
			text.ShowTextNew(this.AreaData.Name);
		}
		if (isAreaUnlock)
		{
			EHonamiStoryCollectState collectMascotState = this.AreaData.CollectMascotState;
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(collectMascotState == EHonamiStoryCollectState.Finished);
			}
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(collectMascotState == EHonamiStoryCollectState.Unfinished);
			}
			UUITexture texture2 = base.GetTexture(1);
			if (collectMascotState != EHonamiStoryCollectState.Unfinished)
			{
				base.SetTextureShowUntilLoaded(this.AreaData.Config.Value.ToggleBgPath, texture2, null);
			}
			texture2.SetUIActive(collectMascotState > EHonamiStoryCollectState.Unfinished);
			List<HonamiStoryMascotData> honamiStoryMascotDataListByAreaId = this.ActivityData.GetHonamiStoryMascotDataListByAreaId(this.AreaData.Id);
			int num = 5;
			using (List<HonamiStoryMascotData>.Enumerator enumerator = honamiStoryMascotDataListByAreaId.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					HonamiStoryMascotData honamiStoryMascotData = enumerator.Current;
					UUISprite sprite2 = base.GetSprite(num);
					if (sprite2 != null)
					{
						sprite2.SetUIActive(honamiStoryMascotData.State > EHonamiStoryCollectState.Unfinished);
					}
					num++;
				}
				goto IL_155;
			}
		}
		UUIText text2 = base.GetText(8);
		if (text2 != null)
		{
			text2.ShowTextNew("HonamiStory_UnknownAreaName");
		}
		IL_155:
		base.SetTextureShowUntilLoaded(this.AreaData.Config.Value.ToggleBgPath, base.GetTexture(12), null);
	}

	// Token: 0x0600C934 RID: 51508 RVA: 0x003BE23C File Offset: 0x003BC43C
	public void BindStageToggleClick(Action<MascotCollectBookStageToggle> callback)
	{
		this.StageToggleClick = callback;
	}

	// Token: 0x0600C935 RID: 51509 RVA: 0x003BE245 File Offset: 0x003BC445
	private void OnToggle(EToggleState toggleState)
	{
		Action<MascotCollectBookStageToggle> stageToggleClick = this.StageToggleClick;
		if (stageToggleClick == null)
		{
			return;
		}
		stageToggleClick(this);
	}

	// Token: 0x0600C936 RID: 51510 RVA: 0x003BE258 File Offset: 0x003BC458
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600C937 RID: 51511 RVA: 0x003BE26A File Offset: 0x003BC46A
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400723E RID: 29246
	private HonamiStoryActivityData ActivityData;

	// Token: 0x0400723F RID: 29247
	private HonamiStoryAreaData AreaData;

	// Token: 0x04007240 RID: 29248
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MascotCollectBookStageToggle> StageToggleClick;

	// Token: 0x04007241 RID: 29249
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x020076A7 RID: 30375
	[NullableContext(0)]
	private enum EMascotCollectBookStageToggleComponent
	{
		// Token: 0x04026868 RID: 157800
		Toggle,
		// Token: 0x04026869 RID: 157801
		BgTexture,
		// Token: 0x0402686A RID: 157802
		DescTexture,
		// Token: 0x0402686B RID: 157803
		LockTexture,
		// Token: 0x0402686C RID: 157804
		GiftSprite,
		// Token: 0x0402686D RID: 157805
		FindOneSprite,
		// Token: 0x0402686E RID: 157806
		FindTwoSprite,
		// Token: 0x0402686F RID: 157807
		FindThreeSprite,
		// Token: 0x04026870 RID: 157808
		NameText,
		// Token: 0x04026871 RID: 157809
		EmptyPanel,
		// Token: 0x04026872 RID: 157810
		InfoPanel,
		// Token: 0x04026873 RID: 157811
		MascotStatePanel,
		// Token: 0x04026874 RID: 157812
		GrayBgTexture
	}
}
