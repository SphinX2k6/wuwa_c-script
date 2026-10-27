using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C74 RID: 7284
public class DrawMainViewNew : UiTickViewBase
{
	// Token: 0x0600DB89 RID: 56201 RVA: 0x0033153A File Offset: 0x0032F73A
	[NullableContext(1)]
	public DrawMainViewNew(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DB8A RID: 56202 RVA: 0x0033154C File Offset: 0x0032F74C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickSkip));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600DB8B RID: 56203 RVA: 0x003315F4 File Offset: 0x0032F7F4
	protected override UniTask OnBeforeStartAsync()
	{
		DrawMainViewNew.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrawMainViewNew.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DB8C RID: 56204 RVA: 0x00331630 File Offset: 0x0032F830
	protected override void OnBeforeShow()
	{
		if (this.IsFirstShow)
		{
			int times = GachaModel.Instance.CurGachaResult.Length;
			int num = 0;
			foreach (GachaResult gachaResult in GachaModel.Instance.CurGachaResult)
			{
				int itemId = gachaResult.Proto_GachaReward.ItemId;
				ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
				int num2 = (itemConfigData != null) ? itemConfigData.QualityId : 0;
				this.HasNewItems = (this.HasNewItems || (num2 >= 4 && gachaResult.IsNew));
				num = Math.Max(num, num2);
			}
			this.InitGachaBp(times, num);
			this.InitAudioState(times, num);
			this.IsFirstShow = false;
		}
		if (Info.Instance.IsMacPlatform())
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.AllowHardwareOcclusion 0", null);
		}
		MenuController.Instance.CloseAllFilter();
	}

	// Token: 0x0600DB8D RID: 56205 RVA: 0x00331704 File Offset: 0x0032F904
	protected override void OnStart()
	{
		base.GetButton(1).RootUIComp.Get().SetUIActive(true);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600DB8E RID: 56206 RVA: 0x0033173C File Offset: 0x0032F93C
	protected override void OnTick(float delta)
	{
		if (!this.IsHold && !this.IsShowTips && !this.IsEnd)
		{
			this.Delay += delta;
			if (this.Delay > 2000f)
			{
				this.IsShowTips = true;
			}
		}
	}

	// Token: 0x0600DB8F RID: 56207 RVA: 0x00331778 File Offset: 0x0032F978
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.EndGachaScene, new Action(this.OnEndGacha));
		EventSystem.Instance.Add<bool>(EEventName.GachaClick, new Action<bool>(this.OnGachaClick));
		EventSystem.Instance.Add(EEventName.GachaInteractFinish, new Action(this.OnGachaInteractFinish));
	}

	// Token: 0x0600DB90 RID: 56208 RVA: 0x003317DC File Offset: 0x0032F9DC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.EndGachaScene, new Action(this.OnEndGacha));
		EventSystem.Instance.Remove(EEventName.GachaClick, new Action<bool>(this.OnGachaClick));
		EventSystem.Instance.Remove(EEventName.GachaInteractFinish, new Action(this.OnGachaInteractFinish));
	}

	// Token: 0x0600DB91 RID: 56209 RVA: 0x00331840 File Offset: 0x0032FA40
	protected void InitGachaBp(int times, int maxQuality)
	{
		E_GachaResultNew gachaResult = E_GachaResultNew.OneShotNormal;
		if (times == 1)
		{
			if (maxQuality == 3)
			{
				gachaResult = E_GachaResultNew.OneShotNormal;
			}
			else if (maxQuality == 4)
			{
				gachaResult = E_GachaResultNew.OneShotPurple;
			}
			else if (maxQuality == 5)
			{
				gachaResult = E_GachaResultNew.OneShotGolden;
			}
		}
		else if (maxQuality == 4)
		{
			gachaResult = E_GachaResultNew.TenShotsPurple;
		}
		else if (maxQuality == 5)
		{
			gachaResult = E_GachaResultNew.TenShotsGolden;
		}
		this.MaxQuality = maxQuality;
		this.GachaBP = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("GachaBP").Value, ECollectActorType.Default) as BP_GachaInteract_C);
		this.GachaBP.TSInitParameters(gachaResult);
		this.GachaBP.SetTickableWhenPaused(true);
		UTimelineComponent timeline_ = this.GachaBP.Timeline_0;
		if (timeline_ == null)
		{
			return;
		}
		timeline_.SetTickableWhenPaused(true);
	}

	// Token: 0x0600DB92 RID: 56210 RVA: 0x003318D4 File Offset: 0x0032FAD4
	protected void InitAudioState(int times, int maxQuality)
	{
		AudioSystem.Instance.SetState("ui_gacha_times", (times == 1) ? "one" : "ten", true);
		if (maxQuality == 3)
		{
			AudioSystem.Instance.SetState("ui_gacha_quality_max", "normal", true);
			return;
		}
		if (maxQuality == 4)
		{
			AudioSystem.Instance.SetState("ui_gacha_quality_max", "purple", true);
			return;
		}
		if (maxQuality == 5)
		{
			AudioSystem.Instance.SetState("ui_gacha_quality_max", "golden", true);
		}
	}

	// Token: 0x0600DB93 RID: 56211 RVA: 0x00331950 File Offset: 0x0032FB50
	protected override void OnBeforeDestroyImplement()
	{
		BP_GachaInteract_C gachaBP = this.GachaBP;
		if (gachaBP != null && gachaBP.IsValid())
		{
			BP_GachaInteract_C gachaBP2 = this.GachaBP;
			if (gachaBP2 != null)
			{
				gachaBP2.EndGachaSequence();
			}
			BP_GachaInteract_C gachaBP3 = this.GachaBP;
			if (gachaBP3 == null)
			{
				return;
			}
			ALevelSequenceActor levelSequenceShow = gachaBP3.LevelSequenceShow;
			if (levelSequenceShow == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = levelSequenceShow.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.Stop();
		}
	}

	// Token: 0x0600DB94 RID: 56212 RVA: 0x003319A8 File Offset: 0x0032FBA8
	protected void OnClickSkip()
	{
		this.GachaBP.IsSkip = true;
		if (this.GachaBP.WhiteScreen)
		{
			UTimelineComponent timeline_ = this.GachaBP.Timeline_0;
			if (timeline_ != null)
			{
				timeline_.Stop();
			}
			this.GachaBP.WhiteScreenOff();
		}
		this.OnEndGacha();
	}

	// Token: 0x0600DB95 RID: 56213 RVA: 0x003319F8 File Offset: 0x0032FBF8
	protected void OnEndGacha()
	{
		this.IsShowTips = true;
		if (this.IsFireEndGacha)
		{
			return;
		}
		if (this.GachaBP.IsSkip)
		{
			BlackScreenController.Instance.AddBlackScreenAsync("Start", "GachaSkip", "Black", "Default").ContinueWith(delegate()
			{
				if (this.MaxQuality == 5 || this.HasNewItems)
				{
					object obj = this.OpenParam;
					if (obj != null)
					{
						(obj as IGachaViewOpenData).IsOnlyShowGold = true;
					}
					else
					{
						obj = new GachaViewOpenData
						{
							SkipOnLoadResourceFinish = false,
							ResultViewHideExtraReward = false,
							IsOnlyShowGold = true
						};
					}
					UiManager.Instance.OpenView(EUiViewName.GachaScanView, obj, delegate(bool _, int _)
					{
						UiManager.Instance.CloseView(this.ViewInfo.Name, null);
					});
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.GachaResultView, this.OpenParam, delegate(bool _, int _)
				{
					UiManager.Instance.CloseView(this.ViewInfo.Name, null);
				});
				BP_UpdateInteract_C bp_UpdateInteract_C = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("UpdateInteractBP").Value, ECollectActorType.Default) as BP_UpdateInteract_C;
				if (bp_UpdateInteract_C != null)
				{
					bp_UpdateInteract_C.EndGachaScene();
				}
				if (bp_UpdateInteract_C == null)
				{
					return;
				}
				bp_UpdateInteract_C.SetTickableWhenPaused(true);
			}).Forget();
		}
		else
		{
			UiManager.Instance.OpenView(EUiViewName.GachaScanView, this.OpenParam, delegate(bool _, int _)
			{
				UiManager.Instance.CloseView(this.ViewInfo.Name, null);
			});
		}
		this.IsFireEndGacha = true;
	}

	// Token: 0x0600DB96 RID: 56214 RVA: 0x00331A80 File Offset: 0x0032FC80
	protected void OnGachaInteractFinish()
	{
		this.IsEnd = true;
		bool isShowTips = this.IsShowTips;
	}

	// Token: 0x0600DB97 RID: 56215 RVA: 0x00331A90 File Offset: 0x0032FC90
	protected void OnGachaClick(bool isPress)
	{
		if (isPress)
		{
			this.IsHold = true;
			this.Delay = 0f;
			this.IsShowTips = false;
			return;
		}
		this.IsHold = false;
	}

	// Token: 0x040064BA RID: 25786
	private const int SHOW_TIPS_DELAY = 2000;

	// Token: 0x040064BB RID: 25787
	protected float Delay;

	// Token: 0x040064BC RID: 25788
	protected bool IsHold;

	// Token: 0x040064BD RID: 25789
	protected bool IsShowTips;

	// Token: 0x040064BE RID: 25790
	protected bool IsEnd;

	// Token: 0x040064BF RID: 25791
	protected int MaxQuality;

	// Token: 0x040064C0 RID: 25792
	protected bool HasNewItems;

	// Token: 0x040064C1 RID: 25793
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040064C2 RID: 25794
	[Nullable(2)]
	protected BP_GachaInteract_C GachaBP;

	// Token: 0x040064C3 RID: 25795
	protected bool IsFirstShow = true;

	// Token: 0x040064C4 RID: 25796
	protected bool IsFireEndGacha;

	// Token: 0x0200822B RID: 33323
	private enum EDrawMainViewNewDefine
	{
		// Token: 0x0402A79B RID: 173979
		DragArea,
		// Token: 0x0402A79C RID: 173980
		SkipBtn
	}
}
