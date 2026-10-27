using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020021B6 RID: 8630
[NullableContext(1)]
[Nullable(0)]
public class LordGymThirdBossSelectView : LordGymLordEntranceSelectView
{
	// Token: 0x17001556 RID: 5462
	// (get) Token: 0x06010CAA RID: 68778 RVA: 0x0041410F File Offset: 0x0041230F
	protected override string ShopTextId
	{
		get
		{
			return "BossChanllengeShop";
		}
	}

	// Token: 0x17001557 RID: 5463
	// (get) Token: 0x06010CAB RID: 68779 RVA: 0x00414116 File Offset: 0x00412316
	protected override string ConfirmTextId
	{
		get
		{
			return "BossChanllengeStart";
		}
	}

	// Token: 0x17001558 RID: 5464
	// (get) Token: 0x06010CAC RID: 68780 RVA: 0x0041411D File Offset: 0x0041231D
	protected override int ShopTabIndex
	{
		get
		{
			return 4;
		}
	}

	// Token: 0x06010CAD RID: 68781 RVA: 0x00414120 File Offset: 0x00412320
	public LordGymThirdBossSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010CAE RID: 68782 RVA: 0x00414134 File Offset: 0x00412334
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUISprite)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout)));
	}

	// Token: 0x06010CAF RID: 68783 RVA: 0x00414198 File Offset: 0x00412398
	protected override void OpenSelectView()
	{
		LordGymModel.Instance.EntranceEntityId = this.SelectedEntranceId;
		LordGymDifficultySelectViewParam param = new LordGymDifficultySelectViewParam
		{
			LordEntranceSetId = this.EntranceSetId,
			LordEntranceId = this.SelectedEntranceId,
			IsPlaySpecialSequence = false
		};
		ALevelSequenceActor lordGymThirdBossSequenceActor = LordGymModel.Instance.GetLordGymThirdBossSequenceActor();
		if (lordGymThirdBossSequenceActor != null)
		{
			ULevelSequencePlayer sequencePlayer = lordGymThirdBossSequenceActor.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Play();
			}
		}
		UiManager.Instance.OpenView(EUiViewName.LordGymThirdDifficultySelectView, param, delegate(bool _, int _)
		{
			UiManager.Instance.CloseView(EUiViewName.LordGymThirdBossSelectView, null);
		});
	}

	// Token: 0x06010CB0 RID: 68784 RVA: 0x00414228 File Offset: 0x00412428
	protected override void OnStart()
	{
		if (this.LordEntranceList != null && this.LordEntranceList.Count > 7)
		{
			base.GetVerticalLayout(8).SetAlign(ELGUILayoutAlignmentType.UpperLeft);
			base.GetVerticalLayout(8).SetHeightFitToChildren(true);
		}
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetHomeBtnShowState(true);
		}
		PopupCaptionItem captionItem2 = this.CaptionItem;
		if (captionItem2 != null)
		{
			captionItem2.SetCloseCallBack(new Action(this.OnClickClose));
		}
		this.AddHomeBtnExitDungeonCallback();
		LordGymLordEntranceSelectViewParam lordGymLordEntranceSelectViewParam = this.OpenParam as LordGymLordEntranceSelectViewParam;
		if (lordGymLordEntranceSelectViewParam != null && lordGymLordEntranceSelectViewParam.IsPlaySpecialSequence.GetValueOrDefault())
		{
			this.UiViewSequence.StartSequenceName = "StartZ";
			return;
		}
		this.UiViewSequence.StartSequenceName = "Start01";
	}

	// Token: 0x06010CB1 RID: 68785 RVA: 0x004142D9 File Offset: 0x004124D9
	public override string GetBlackScreenTypeOnOpenViewLoadScene()
	{
		LordGymLordEntranceSelectViewParam lordGymLordEntranceSelectViewParam = this.OpenParam as LordGymLordEntranceSelectViewParam;
		if (lordGymLordEntranceSelectViewParam != null && lordGymLordEntranceSelectViewParam.NeedBlackScreenAnim)
		{
			return "Start";
		}
		return "None";
	}

	// Token: 0x06010CB2 RID: 68786 RVA: 0x004142FF File Offset: 0x004124FF
	protected override void InitSelect()
	{
	}

	// Token: 0x06010CB3 RID: 68787 RVA: 0x00414304 File Offset: 0x00412504
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymThirdBossSelectView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymThirdBossSelectView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010CB4 RID: 68788 RVA: 0x00414348 File Offset: 0x00412548
	private UniTask PreloadSceneEffect(string effectPath)
	{
		LordGymThirdBossSelectView.<PreloadSceneEffect>d__17 <PreloadSceneEffect>d__;
		<PreloadSceneEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadSceneEffect>d__.<>4__this = this;
		<PreloadSceneEffect>d__.effectPath = effectPath;
		<PreloadSceneEffect>d__.<>1__state = -1;
		<PreloadSceneEffect>d__.<>t__builder.Start<LordGymThirdBossSelectView.<PreloadSceneEffect>d__17>(ref <PreloadSceneEffect>d__);
		return <PreloadSceneEffect>d__.<>t__builder.Task;
	}

	// Token: 0x06010CB5 RID: 68789 RVA: 0x00414394 File Offset: 0x00412594
	protected UniTask InitSelectAsync()
	{
		LordGymThirdBossSelectView.<InitSelectAsync>d__18 <InitSelectAsync>d__;
		<InitSelectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSelectAsync>d__.<>4__this = this;
		<InitSelectAsync>d__.<>1__state = -1;
		<InitSelectAsync>d__.<>t__builder.Start<LordGymThirdBossSelectView.<InitSelectAsync>d__18>(ref <InitSelectAsync>d__);
		return <InitSelectAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010CB6 RID: 68790 RVA: 0x004143D7 File Offset: 0x004125D7
	protected override LordGymLordEntranceItem CreateItem()
	{
		return new LordGymThirdBossItem
		{
			OnToggleClick = new Action<int>(base.OnLordEntranceToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(base.CanLordEntranceToggleChange)
		};
	}

	// Token: 0x06010CB7 RID: 68791 RVA: 0x00414402 File Offset: 0x00412602
	protected override void ReBuildLordEntranceList()
	{
		if (this.LordEntranceList != null && this.LordEntranceList.Count < 2)
		{
			this.LordEntranceList.Add(0);
		}
	}

	// Token: 0x06010CB8 RID: 68792 RVA: 0x00414428 File Offset: 0x00412628
	protected override void OnHandleLoadScene()
	{
		if (!UiSceneManager.Instance.HasLordSkeletalHandle())
		{
			UiSceneManager.Instance.InitLordSkeletalHandle();
			LordGymController.Instance.CreateLordModelByEntranceId();
			LordGymController.Instance.LoadLordModelByEntranceId(this.SelectedEntranceId, true, true);
		}
		else
		{
			LordGymController.Instance.CreateLordModelByEntranceId();
		}
		LordGymLordEntranceSelectViewParam lordGymLordEntranceSelectViewParam = this.OpenParam as LordGymLordEntranceSelectViewParam;
		if (lordGymLordEntranceSelectViewParam != null && lordGymLordEntranceSelectViewParam.IsPlaySpecialSequence.GetValueOrDefault() && !this.HasPlayEffect)
		{
			LordGymEntrance? config = ConfigLordGymEntranceById.GetConfig(this.SelectedEntranceId, true);
			if (config != null && !string.IsNullOrEmpty(config.Value.LordUISceneEffect))
			{
				EffectSystem instance = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(this.CacheTransform);
				this.SceneEffectHandle = instance.SpawnEffect(world, ftransformDouble, config.Value.LordUISceneEffect, "LordGymSceneEffect", null, EEffectType.UiScene3D, null, null, null, false, false);
			}
		}
		LordGymController.Instance.PlayLordModelMaterialAnimationByEntranceId(this.SelectedEntranceId, null, null, this.HasPlayEffect, !this.HasPlayEffect);
		this.HasPlayEffect = true;
	}

	// Token: 0x06010CB9 RID: 68793 RVA: 0x0041452C File Offset: 0x0041272C
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymThirdBossSelectView.<OnHandlePostLoadSceneAsync>d__22 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymThirdBossSelectView.<OnHandlePostLoadSceneAsync>d__22>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010CBA RID: 68794 RVA: 0x00414570 File Offset: 0x00412770
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymThirdBossSelectView.<OnHandlePreReleaseSceneAsync>d__23 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymThirdBossSelectView.<OnHandlePreReleaseSceneAsync>d__23>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010CBB RID: 68795 RVA: 0x004145B4 File Offset: 0x004127B4
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyLordSkeletalHandle();
		if (EffectSystem.Instance.IsValid(this.SceneEffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.SceneEffectHandle, "[LordGymThirdBossSelectView.OnBeforeDestroy]", true, null);
			this.SceneEffectHandle = 0;
		}
	}

	// Token: 0x06010CBC RID: 68796 RVA: 0x00414604 File Offset: 0x00412804
	public override void SelectLordEntranceByIndex(int index)
	{
		int num = this.LordEntranceList[index];
		if (num == 0)
		{
			return;
		}
		GenericScrollViewNew<LordGymLordEntranceItem, int> lordEntranceScrollView = this.LordEntranceScrollView;
		if (lordEntranceScrollView != null)
		{
			GenericLayout<LordGymLordEntranceItem, int> genericLayout = lordEntranceScrollView.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.SelectGridProxy(index, false);
			}
		}
		this.SelectedEntranceId = num;
		LordGymController.Instance.LoadLordModelByEntranceId(this.SelectedEntranceId, true, true);
		string text = (index + 1).ToString();
		this.SetSpriteByPath(StringUtils.Format("/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity30/LordGym/SP_BossNum0{0}.SP_BossNum0{1}", new string[]
		{
			text,
			text
		}), base.GetSprite(7), true, null, null);
		base.PlaySequence("Switch", null, false);
	}

	// Token: 0x06010CBD RID: 68797 RVA: 0x004146A4 File Offset: 0x004128A4
	protected UniTask SelectLordEntranceByIndexAsync(int index)
	{
		LordGymThirdBossSelectView.<SelectLordEntranceByIndexAsync>d__26 <SelectLordEntranceByIndexAsync>d__;
		<SelectLordEntranceByIndexAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SelectLordEntranceByIndexAsync>d__.<>4__this = this;
		<SelectLordEntranceByIndexAsync>d__.index = index;
		<SelectLordEntranceByIndexAsync>d__.<>1__state = -1;
		<SelectLordEntranceByIndexAsync>d__.<>t__builder.Start<LordGymThirdBossSelectView.<SelectLordEntranceByIndexAsync>d__26>(ref <SelectLordEntranceByIndexAsync>d__);
		return <SelectLordEntranceByIndexAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010CBE RID: 68798 RVA: 0x004146F0 File Offset: 0x004128F0
	protected override void OnBeforeDestroy()
	{
		if (EffectSystem.Instance.IsValid(this.SceneEffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.SceneEffectHandle, "[LordGymThirdBossSelectView.OnBeforeDestroy]", true, null);
			this.SceneEffectHandle = 0;
		}
		InstanceDungeonEntranceController.Instance.RestoreDungeonEntranceEntity();
	}

	// Token: 0x06010CBF RID: 68799 RVA: 0x00414740 File Offset: 0x00412940
	private void AddHomeBtnExitDungeonCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			LordGymThirdBossSelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__28_0>d <<AddHomeBtnExitDungeonCallback>b__28_0>d;
			<<AddHomeBtnExitDungeonCallback>b__28_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExitDungeonCallback>b__28_0>d.<>1__state = -1;
			<<AddHomeBtnExitDungeonCallback>b__28_0>d.<>t__builder.Start<LordGymThirdBossSelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__28_0>d>(ref <<AddHomeBtnExitDungeonCallback>b__28_0>d);
			return <<AddHomeBtnExitDungeonCallback>b__28_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x06010CC0 RID: 68800 RVA: 0x00414774 File Offset: 0x00412974
	private void OnClickClose()
	{
		if (LordGymController.Instance.IsInLordGymDungeon())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.LordGymExitInstanceConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().ContinueWith(delegate(bool _)
				{
					base.CloseMe(null);
				});
			};
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x04007FA5 RID: 32677
	private bool HasPlayEffect;

	// Token: 0x04007FA6 RID: 32678
	private readonly FTransformDouble CacheTransform = new FTransformDouble();

	// Token: 0x04007FA7 RID: 32679
	private int SceneEffectHandle;

	// Token: 0x020086F5 RID: 34549
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402BE74 RID: 179828
		public const int ShopHotDot = 6;

		// Token: 0x0402BE75 RID: 179829
		public const int BossNumSprite = 7;

		// Token: 0x0402BE76 RID: 179830
		public const int Content = 8;
	}
}
