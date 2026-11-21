using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TreasureHunt;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200142B RID: 5163
[NullableContext(1)]
[Nullable(0)]
public class TreasureCompassUnit : HudUnitBase
{
	// Token: 0x0600CD88 RID: 52616 RVA: 0x003D2720 File Offset: 0x003D0920
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CD89 RID: 52617 RVA: 0x003D2768 File Offset: 0x003D0968
	protected override UniTask OnCreateAsync()
	{
		TreasureCompassUnit.<OnCreateAsync>d__9 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<TreasureCompassUnit.<OnCreateAsync>d__9>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CD8A RID: 52618 RVA: 0x003D27AC File Offset: 0x003D09AC
	protected override void OnBeforeDestroy()
	{
		foreach (TreasureCompassArrow treasureCompassArrow in this.ArrowItems)
		{
			treasureCompassArrow.Clean();
			treasureCompassArrow.Destroy(null);
		}
		this.ArrowItems.Clear();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600CD8B RID: 52619 RVA: 0x003D2828 File Offset: 0x003D0A28
	private UniTask AddArrowItem()
	{
		TreasureCompassUnit.<AddArrowItem>d__11 <AddArrowItem>d__;
		<AddArrowItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddArrowItem>d__.<>4__this = this;
		<AddArrowItem>d__.<>1__state = -1;
		<AddArrowItem>d__.<>t__builder.Start<TreasureCompassUnit.<AddArrowItem>d__11>(ref <AddArrowItem>d__);
		return <AddArrowItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600CD8C RID: 52620 RVA: 0x003D286C File Offset: 0x003D0A6C
	protected override void OnStart()
	{
		base.OnStart();
		this.IsVisible = false;
		this.RingItem = base.GetItem(0);
		foreach (TreasureCompassArrow treasureCompassArrow in this.ArrowItems)
		{
			treasureCompassArrow.GetRootItem().SetUIParent(this.RingItem, false);
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600CD8D RID: 52621 RVA: 0x003D28F4 File Offset: 0x003D0AF4
	public override void SetActive(bool visibility)
	{
		if (visibility == this.IsVisible)
		{
			return;
		}
		this.IsVisible = visibility;
		if (visibility)
		{
			base.SetActive(true);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely("Start", false, false, null, null, false);
			}
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.StopCurrentSequence(false, false);
			}
			this.PlayCloseAsync().Forget();
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnTreasureCompassUnitVisibleChange, visibility);
	}

	// Token: 0x0600CD8E RID: 52622 RVA: 0x003D2984 File Offset: 0x003D0B84
	private UniTask PlayCloseAsync()
	{
		TreasureCompassUnit.<PlayCloseAsync>d__14 <PlayCloseAsync>d__;
		<PlayCloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseAsync>d__.<>4__this = this;
		<PlayCloseAsync>d__.<>1__state = -1;
		<PlayCloseAsync>d__.<>t__builder.Start<TreasureCompassUnit.<PlayCloseAsync>d__14>(ref <PlayCloseAsync>d__);
		return <PlayCloseAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CD8F RID: 52623 RVA: 0x003D29C7 File Offset: 0x003D0BC7
	public void InitHide()
	{
		base.SetActive(false);
		this.IsVisible = false;
	}

	// Token: 0x0600CD90 RID: 52624 RVA: 0x003D29D8 File Offset: 0x003D0BD8
	public void RefreshCompass(List<ITreasureData> treasureList, Vector actorLocation)
	{
		int count = treasureList.Count;
		int count2 = this.ArrowItems.Count;
		bool flag = false;
		int num = -1;
		for (int i = 0; i < count; i++)
		{
			ITreasureData treasureData = treasureList[i];
			if (treasureData.IsEnableCompassTracking.GetValueOrDefault())
			{
				num++;
				if (num >= count2 || i >= 5)
				{
					break;
				}
				TreasureCompassArrow treasureCompassArrow = this.ArrowItems[num];
				if (treasureData.IsNearbyTracking.GetValueOrDefault())
				{
					treasureCompassArrow.SetVisible(false);
				}
				else
				{
					flag = true;
					treasureData.Location.Subtraction(actorLocation, this.TempLocation);
					float num2 = (float)MathUtils.Instance.GetAngleByVector2D(this.TempLocation);
					this.TempRotator.Yaw = -num2 + CameraController.Instance.MainModel.CameraRotator.Yaw;
					treasureCompassArrow.SetRotation(this.TempRotator.ToUeRotator());
					double? distSquared = treasureData.DistSquared;
					double? highlightRangeSquared = treasureData.HighlightRangeSquared;
					if (distSquared.GetValueOrDefault() < highlightRangeSquared.GetValueOrDefault() & (distSquared != null & highlightRangeSquared != null))
					{
						treasureCompassArrow.SetHighLight(true);
						treasureCompassArrow.GetRootItem().SetAsLastHierarchy();
					}
					else
					{
						double valueOrDefault = ((double)1 - 0.5 * (treasureData.DistSquared - treasureData.HighlightRangeSquared) / (treasureData.RangeSquared - treasureData.HighlightRangeSquared)).GetValueOrDefault(1.0);
						double arrowScale = MathUtils.Instance.Clamp(valueOrDefault, 0.5, 1.0);
						treasureCompassArrow.SetArrowScale(arrowScale);
						treasureCompassArrow.SetHighLight(false);
					}
					treasureCompassArrow.SetVisible(true);
				}
			}
		}
		if (num < 0)
		{
			num = 0;
		}
		for (int j = num; j < count2; j++)
		{
			this.ArrowItems[j].SetVisible(false);
		}
		if (flag && !this.IsVisible)
		{
			this.SetActive(true);
			return;
		}
		if (!flag && this.IsVisible)
		{
			this.SetActive(false);
		}
	}

	// Token: 0x04007518 RID: 29976
	private const int MAX_ARROW_COUNT = 5;

	// Token: 0x04007519 RID: 29977
	[StaticVariableRuleIgnore]
	private static readonly Stat RefreshStatsObject = Stat.Create("TreasureCompassUnitRefresh", "", "");

	// Token: 0x0400751A RID: 29978
	[Nullable(2)]
	private UUIItem RingItem;

	// Token: 0x0400751B RID: 29979
	private readonly Vector TempLocation = Vector.Create();

	// Token: 0x0400751C RID: 29980
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x0400751D RID: 29981
	private readonly List<TreasureCompassArrow> ArrowItems = new List<TreasureCompassArrow>();

	// Token: 0x0400751E RID: 29982
	private bool IsVisible = true;

	// Token: 0x0400751F RID: 29983
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;
}
