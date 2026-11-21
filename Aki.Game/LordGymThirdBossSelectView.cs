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

// Token: 0x0200169A RID: 5786
[NullableContext(1)]
[Nullable(0)]
public class LordGymThirdBossSelectView : LordGymLordEntranceSelectView
{
	// Token: 0x1700158D RID: 5517
	// (get) Token: 0x0600E13B RID: 57659 RVA: 0x004209EF File Offset: 0x0041EBEF
	protected override string ShopTextId
	{
		get
		{
			return "BossChanllengeShop";
		}
	}

	// Token: 0x1700158E RID: 5518
	// (get) Token: 0x0600E13C RID: 57660 RVA: 0x004209F6 File Offset: 0x0041EBF6
	protected override string ConfirmTextId
	{
		get
		{
			return "BossChanllengeStart";
		}
	}

	// Token: 0x1700158F RID: 5519
	// (get) Token: 0x0600E13D RID: 57661 RVA: 0x004209FD File Offset: 0x0041EBFD
	protected override int ShopTabIndex
	{
		get
		{
			return 4;
		}
	}

	// Token: 0x0600E13E RID: 57662 RVA: 0x00420A00 File Offset: 0x0041EC00
	public LordGymThirdBossSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E13F RID: 57663 RVA: 0x00420A14 File Offset: 0x0041EC14
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUISprite)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout)));
	}

	// Token: 0x0600E140 RID: 57664 RVA: 0x00420A78 File Offset: 0x0041EC78
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

	// Token: 0x0600E141 RID: 57665 RVA: 0x00420B08 File Offset: 0x0041ED08
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

	// Token: 0x0600E142 RID: 57666 RVA: 0x00420BB9 File Offset: 0x0041EDB9
	public override string GetBlackScreenTypeOnOpenViewLoadScene()
	{
		LordGymLordEntranceSelectViewParam lordGymLordEntranceSelectViewParam = this.OpenParam as LordGymLordEntranceSelectViewParam;
		if (lordGymLordEntranceSelectViewParam != null && lordGymLordEntranceSelectViewParam.NeedBlackScreenAnim)
		{
			return "Start";
		}
		return "None";
	}

	// Token: 0x0600E143 RID: 57667 RVA: 0x00420BDF File Offset: 0x0041EDDF
	protected override void InitSelect()
	{
	}

	// Token: 0x0600E144 RID: 57668 RVA: 0x00420BE4 File Offset: 0x0041EDE4
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymThirdBossSelectView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymThirdBossSelectView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E145 RID: 57669 RVA: 0x00420C28 File Offset: 0x0041EE28
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

	// Token: 0x0600E146 RID: 57670 RVA: 0x00420C74 File Offset: 0x0041EE74
	protected UniTask InitSelectAsync()
	{
		LordGymThirdBossSelectView.<InitSelectAsync>d__18 <InitSelectAsync>d__;
		<InitSelectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSelectAsync>d__.<>4__this = this;
		<InitSelectAsync>d__.<>1__state = -1;
		<InitSelectAsync>d__.<>t__builder.Start<LordGymThirdBossSelectView.<InitSelectAsync>d__18>(ref <InitSelectAsync>d__);
		return <InitSelectAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E147 RID: 57671 RVA: 0x00420CB7 File Offset: 0x0041EEB7
	protected override LordGymLordEntranceItem CreateItem()
	{
		return new LordGymThirdBossItem
		{
			OnToggleClick = new Action<int>(base.OnLordEntranceToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(base.CanLordEntranceToggleChange)
		};
	}

	// Token: 0x0600E148 RID: 57672 RVA: 0x00420CE2 File Offset: 0x0041EEE2
	protected override void ReBuildLordEntranceList()
	{
		if (this.LordEntranceList != null && this.LordEntranceList.Count < 2)
		{
			this.LordEntranceList.Add(0);
		}
	}

	// Token: 0x0600E149 RID: 57673 RVA: 0x00420D08 File Offset: 0x0041EF08
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

	// Token: 0x0600E14A RID: 57674 RVA: 0x00420E0C File Offset: 0x0041F00C
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymThirdBossSelectView.<OnHandlePostLoadSceneAsync>d__22 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymThirdBossSelectView.<OnHandlePostLoadSceneAsync>d__22>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E14B RID: 57675 RVA: 0x00420E50 File Offset: 0x0041F050
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymThirdBossSelectView.<OnHandlePreReleaseSceneAsync>d__23 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymThirdBossSelectView.<OnHandlePreReleaseSceneAsync>d__23>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E14C RID: 57676 RVA: 0x00420E94 File Offset: 0x0041F094
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyLordSkeletalHandle();
		if (EffectSystem.Instance.IsValid(this.SceneEffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.SceneEffectHandle, "[LordGymThirdBossSelectView.OnBeforeDestroy]", true, null);
			this.SceneEffectHandle = 0;
		}
	}

	// Token: 0x0600E14D RID: 57677 RVA: 0x00420EE4 File Offset: 0x0041F0E4
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

	// Token: 0x0600E14E RID: 57678 RVA: 0x00420F84 File Offset: 0x0041F184
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

	// Token: 0x0600E14F RID: 57679 RVA: 0x00420FD0 File Offset: 0x0041F1D0
	protected override void OnBeforeDestroy()
	{
		if (EffectSystem.Instance.IsValid(this.SceneEffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.SceneEffectHandle, "[LordGymThirdBossSelectView.OnBeforeDestroy]", true, null);
			this.SceneEffectHandle = 0;
		}
		InstanceDungeonEntranceController.Instance.RestoreDungeonEntranceEntity();
	}

	// Token: 0x0600E150 RID: 57680 RVA: 0x00421020 File Offset: 0x0041F220
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

	// Token: 0x0600E151 RID: 57681 RVA: 0x00421054 File Offset: 0x0041F254
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

	// Token: 0x040080EC RID: 33004
	private bool HasPlayEffect;

	// Token: 0x040080ED RID: 33005
	private readonly FTransformDouble CacheTransform = new FTransformDouble();

	// Token: 0x040080EE RID: 33006
	private int SceneEffectHandle;

	// Token: 0x02007880 RID: 30848
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027195 RID: 160149
		public const int ShopHotDot = 6;

		// Token: 0x04027196 RID: 160150
		public const int BossNumSprite = 7;

		// Token: 0x04027197 RID: 160151
		public const int Content = 8;
	}
}
