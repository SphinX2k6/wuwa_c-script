using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F11 RID: 7953
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MascotCollectBookStageToggle : GridProxyAbstract<HonamiStoryAreaData>
{
	// Token: 0x0600F50F RID: 62735 RVA: 0x003B23C1 File Offset: 0x003B05C1
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
	}

	// Token: 0x0600F510 RID: 62736 RVA: 0x003B23DC File Offset: 0x003B05DC
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

	// Token: 0x0600F511 RID: 62737 RVA: 0x003B2539 File Offset: 0x003B0739
	protected override void OnStart()
	{
		if (this.ActivityData == null)
		{
			this.ActivityData = HonamiStoryModel.Instance.GetActivityData(true);
		}
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x17001324 RID: 4900
	// (get) Token: 0x0600F512 RID: 62738 RVA: 0x003B2564 File Offset: 0x003B0764
	public HonamiStoryAreaData Data
	{
		get
		{
			return this.AreaData;
		}
	}

	// Token: 0x0600F513 RID: 62739 RVA: 0x003B256C File Offset: 0x003B076C
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

	// Token: 0x0600F514 RID: 62740 RVA: 0x003B25B0 File Offset: 0x003B07B0
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

	// Token: 0x0600F515 RID: 62741 RVA: 0x003B2750 File Offset: 0x003B0950
	public void BindStageToggleClick(Action<MascotCollectBookStageToggle> callback)
	{
		this.StageToggleClick = callback;
	}

	// Token: 0x0600F516 RID: 62742 RVA: 0x003B2759 File Offset: 0x003B0959
	private void OnToggle(EToggleState toggleState)
	{
		Action<MascotCollectBookStageToggle> stageToggleClick = this.StageToggleClick;
		if (stageToggleClick == null)
		{
			return;
		}
		stageToggleClick(this);
	}

	// Token: 0x0600F517 RID: 62743 RVA: 0x003B276C File Offset: 0x003B096C
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600F518 RID: 62744 RVA: 0x003B277E File Offset: 0x003B097E
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400715D RID: 29021
	private HonamiStoryActivityData ActivityData;

	// Token: 0x0400715E RID: 29022
	private HonamiStoryAreaData AreaData;

	// Token: 0x0400715F RID: 29023
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MascotCollectBookStageToggle> StageToggleClick;

	// Token: 0x04007160 RID: 29024
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x02008522 RID: 34082
	[NullableContext(0)]
	private enum EMascotCollectBookStageToggleComponent
	{
		// Token: 0x0402B544 RID: 177476
		Toggle,
		// Token: 0x0402B545 RID: 177477
		BgTexture,
		// Token: 0x0402B546 RID: 177478
		DescTexture,
		// Token: 0x0402B547 RID: 177479
		LockTexture,
		// Token: 0x0402B548 RID: 177480
		GiftSprite,
		// Token: 0x0402B549 RID: 177481
		FindOneSprite,
		// Token: 0x0402B54A RID: 177482
		FindTwoSprite,
		// Token: 0x0402B54B RID: 177483
		FindThreeSprite,
		// Token: 0x0402B54C RID: 177484
		NameText,
		// Token: 0x0402B54D RID: 177485
		EmptyPanel,
		// Token: 0x0402B54E RID: 177486
		InfoPanel,
		// Token: 0x0402B54F RID: 177487
		MascotStatePanel,
		// Token: 0x0402B550 RID: 177488
		GrayBgTexture
	}
}
