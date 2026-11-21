using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x0200565E RID: 22110
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayView : UiTickViewBase
	{
		// Token: 0x0603697D RID: 223613 RVA: 0x00F3C18C File Offset: 0x00F3A38C
		[NullableContext(1)]
		public DropCatchGameplayView(UiViewInfo viewInfo)
		{
			EDropCatchRobotAnimState[][] array = new EDropCatchRobotAnimState[2][];
			array[0] = new EDropCatchRobotAnimState[]
			{
				EDropCatchRobotAnimState.IdleRight,
				EDropCatchRobotAnimState.IdleLeft
			};
			int num = 1;
			EDropCatchRobotAnimState[] array2 = new EDropCatchRobotAnimState[2];
			array2[0] = EDropCatchRobotAnimState.HappyRight;
			array[num] = array2;
			this.RobotAnimStateTable = array;
			base..ctor(viewInfo);
		}

		// Token: 0x0603697E RID: 223614 RVA: 0x00F3C1F4 File Offset: 0x00F3A3F4
		protected override void OnRegisterComponent()
		{
			this.Proxy = (this.OpenParam as DropCatchGameplayProxy);
			this.Proxy.RegisterView(this);
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIArtText)),
				new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUISprite)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIText)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIArtText)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUIItem)),
				new ValueTuple<int, Type>(21, typeof(UUIItem)),
				new ValueTuple<int, Type>(22, typeof(UUIItem)),
				new ValueTuple<int, Type>(23, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(24, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnSkillButtonClick)),
				new ValueTuple<int, Delegate>(4, new Action(this.OnPauseButtonClick)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnDetailButtonClick))
			};
		}

		// Token: 0x0603697F RID: 223615 RVA: 0x00F3C49C File Offset: 0x00F3A69C
		protected override UniTask OnBeforeStartAsync()
		{
			DropCatchGameplayView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DropCatchGameplayView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036980 RID: 223616 RVA: 0x00F3C4DF File Offset: 0x00F3A6DF
		protected override void OnStart()
		{
			this.InitDropItemLayer();
			this.InitPools();
		}

		// Token: 0x06036981 RID: 223617 RVA: 0x00F3C4F0 File Offset: 0x00F3A6F0
		private UniTask RefreshBgRoleView()
		{
			DropCatchGameplayView.<RefreshBgRoleView>d__22 <RefreshBgRoleView>d__;
			<RefreshBgRoleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshBgRoleView>d__.<>4__this = this;
			<RefreshBgRoleView>d__.<>1__state = -1;
			<RefreshBgRoleView>d__.<>t__builder.Start<DropCatchGameplayView.<RefreshBgRoleView>d__22>(ref <RefreshBgRoleView>d__);
			return <RefreshBgRoleView>d__.<>t__builder.Task;
		}

		// Token: 0x06036982 RID: 223618 RVA: 0x00F3C534 File Offset: 0x00F3A734
		private void InitPools()
		{
			if (this.FloatEffPool == null)
			{
				this.FloatEffPool = new DropCatchGameplayPanelViewPool<DropCatchGameplayFloatEffView>();
				this.FloatEffPool.Init(delegate
				{
					DropCatchGameplayView.<<InitPools>b__23_0>d <<InitPools>b__23_0>d;
					<<InitPools>b__23_0>d.<>t__builder = AsyncUniTaskMethodBuilder<DropCatchGameplayFloatEffView>.Create();
					<<InitPools>b__23_0>d.<>4__this = this;
					<<InitPools>b__23_0>d.<>1__state = -1;
					<<InitPools>b__23_0>d.<>t__builder.Start<DropCatchGameplayView.<<InitPools>b__23_0>d>(ref <<InitPools>b__23_0>d);
					return <<InitPools>b__23_0>d.<>t__builder.Task;
				});
			}
			if (this.DropItemFxPool == null)
			{
				this.DropItemFxPool = new DropCatchGameplayPanelViewPool<DropCatchGameplayDropItemFxView>();
				this.DropItemFxPool.Init(delegate
				{
					DropCatchGameplayView.<<InitPools>b__23_1>d <<InitPools>b__23_1>d;
					<<InitPools>b__23_1>d.<>t__builder = AsyncUniTaskMethodBuilder<DropCatchGameplayDropItemFxView>.Create();
					<<InitPools>b__23_1>d.<>4__this = this;
					<<InitPools>b__23_1>d.<>1__state = -1;
					<<InitPools>b__23_1>d.<>t__builder.Start<DropCatchGameplayView.<<InitPools>b__23_1>d>(ref <<InitPools>b__23_1>d);
					return <<InitPools>b__23_1>d.<>t__builder.Task;
				});
			}
		}

		// Token: 0x06036983 RID: 223619 RVA: 0x00F3C595 File Offset: 0x00F3A795
		private void DestroyPools()
		{
			DropCatchGameplayPanelViewPool<DropCatchGameplayFloatEffView> floatEffPool = this.FloatEffPool;
			if (floatEffPool != null)
			{
				floatEffPool.DestroyAll();
			}
			DropCatchGameplayPanelViewPool<DropCatchGameplayDropItemFxView> dropItemFxPool = this.DropItemFxPool;
			if (dropItemFxPool == null)
			{
				return;
			}
			dropItemFxPool.DestroyAll();
		}

		// Token: 0x06036984 RID: 223620 RVA: 0x00F3C5B8 File Offset: 0x00F3A7B8
		protected override void OnBeforeDestroy()
		{
			this.DestroyPools();
			AudioSystem.Instance.SetState("game_sys_fever", "none", true);
			this.Proxy.OnGameplayViewDestroyed();
		}

		// Token: 0x06036985 RID: 223621 RVA: 0x00F3C5E0 File Offset: 0x00F3A7E0
		private void RecyclePools()
		{
			DropCatchGameplayPanelViewPool<DropCatchGameplayFloatEffView> floatEffPool = this.FloatEffPool;
			if (floatEffPool != null)
			{
				floatEffPool.RecycleAll();
			}
			DropCatchGameplayPanelViewPool<DropCatchGameplayDropItemFxView> dropItemFxPool = this.DropItemFxPool;
			if (dropItemFxPool == null)
			{
				return;
			}
			dropItemFxPool.RecycleAll();
		}

		// Token: 0x06036986 RID: 223622 RVA: 0x00F3C604 File Offset: 0x00F3A804
		public UniTask ResetView(bool isRestart)
		{
			DropCatchGameplayView.<ResetView>d__27 <ResetView>d__;
			<ResetView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetView>d__.<>4__this = this;
			<ResetView>d__.isRestart = isRestart;
			<ResetView>d__.<>1__state = -1;
			<ResetView>d__.<>t__builder.Start<DropCatchGameplayView.<ResetView>d__27>(ref <ResetView>d__);
			return <ResetView>d__.<>t__builder.Task;
		}

		// Token: 0x06036987 RID: 223623 RVA: 0x00F3C650 File Offset: 0x00F3A850
		public UniTask CreateFloatEffView(string icon = null, float? score = null)
		{
			DropCatchGameplayView.<CreateFloatEffView>d__28 <CreateFloatEffView>d__;
			<CreateFloatEffView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFloatEffView>d__.<>4__this = this;
			<CreateFloatEffView>d__.icon = icon;
			<CreateFloatEffView>d__.score = score;
			<CreateFloatEffView>d__.<>1__state = -1;
			<CreateFloatEffView>d__.<>t__builder.Start<DropCatchGameplayView.<CreateFloatEffView>d__28>(ref <CreateFloatEffView>d__);
			return <CreateFloatEffView>d__.<>t__builder.Task;
		}

		// Token: 0x06036988 RID: 223624 RVA: 0x00F3C6A4 File Offset: 0x00F3A8A4
		[NullableContext(1)]
		public UniTask CreateDropItemFxView(EDropCatchDropItemNiagaraType type, Vector2D pos)
		{
			DropCatchGameplayView.<CreateDropItemFxView>d__29 <CreateDropItemFxView>d__;
			<CreateDropItemFxView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDropItemFxView>d__.<>4__this = this;
			<CreateDropItemFxView>d__.type = type;
			<CreateDropItemFxView>d__.pos = pos;
			<CreateDropItemFxView>d__.<>1__state = -1;
			<CreateDropItemFxView>d__.<>t__builder.Start<DropCatchGameplayView.<CreateDropItemFxView>d__29>(ref <CreateDropItemFxView>d__);
			return <CreateDropItemFxView>d__.<>t__builder.Task;
		}

		// Token: 0x06036989 RID: 223625 RVA: 0x00F3C6F8 File Offset: 0x00F3A8F8
		private UniTask InitJoyStick()
		{
			DropCatchGameplayView.<InitJoyStick>d__30 <InitJoyStick>d__;
			<InitJoyStick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitJoyStick>d__.<>4__this = this;
			<InitJoyStick>d__.<>1__state = -1;
			<InitJoyStick>d__.<>t__builder.Start<DropCatchGameplayView.<InitJoyStick>d__30>(ref <InitJoyStick>d__);
			return <InitJoyStick>d__.<>t__builder.Task;
		}

		// Token: 0x0603698A RID: 223626 RVA: 0x00F3C73C File Offset: 0x00F3A93C
		private UniTask InitMsgItem()
		{
			DropCatchGameplayView.<InitMsgItem>d__31 <InitMsgItem>d__;
			<InitMsgItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMsgItem>d__.<>4__this = this;
			<InitMsgItem>d__.<>1__state = -1;
			<InitMsgItem>d__.<>t__builder.Start<DropCatchGameplayView.<InitMsgItem>d__31>(ref <InitMsgItem>d__);
			return <InitMsgItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603698B RID: 223627 RVA: 0x00F3C780 File Offset: 0x00F3A980
		[NullableContext(1)]
		public void ShowMsgView(IDropCatchGameplayLeftMsgParams @params)
		{
			EDropCatchGameplayLeftMsgType type = @params.Type;
			if (type != EDropCatchGameplayLeftMsgType.Gameplay)
			{
				if (type != EDropCatchGameplayLeftMsgType.DropItem)
				{
					return;
				}
				this.MsgDropItemView.OpenParam = @params;
				DropCatchGameplayLeftMsgView msgDropItemView = this.MsgDropItemView;
				if (msgDropItemView == null)
				{
					return;
				}
				msgDropItemView.Show(null);
				return;
			}
			else
			{
				this.MsgGameplayView.OpenParam = @params;
				DropCatchGameplayLeftMsgView msgGameplayView = this.MsgGameplayView;
				if (msgGameplayView == null)
				{
					return;
				}
				msgGameplayView.Show(null);
				return;
			}
		}

		// Token: 0x0603698C RID: 223628 RVA: 0x00F3C7D7 File Offset: 0x00F3A9D7
		public void HideMsgView()
		{
			DropCatchGameplayLeftMsgView msgGameplayView = this.MsgGameplayView;
			if (msgGameplayView != null)
			{
				msgGameplayView.Hide(null);
			}
			DropCatchGameplayLeftMsgView msgDropItemView = this.MsgDropItemView;
			if (msgDropItemView == null)
			{
				return;
			}
			msgDropItemView.Hide(null);
		}

		// Token: 0x0603698D RID: 223629 RVA: 0x00F3C7FC File Offset: 0x00F3A9FC
		private UniTask InitRoleView()
		{
			DropCatchGameplayView.<InitRoleView>d__34 <InitRoleView>d__;
			<InitRoleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleView>d__.<>4__this = this;
			<InitRoleView>d__.<>1__state = -1;
			<InitRoleView>d__.<>t__builder.Start<DropCatchGameplayView.<InitRoleView>d__34>(ref <InitRoleView>d__);
			return <InitRoleView>d__.<>t__builder.Task;
		}

		// Token: 0x0603698E RID: 223630 RVA: 0x00F3C840 File Offset: 0x00F3AA40
		private UniTask RefreshRoleView()
		{
			DropCatchGameplayView.<RefreshRoleView>d__35 <RefreshRoleView>d__;
			<RefreshRoleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleView>d__.<>4__this = this;
			<RefreshRoleView>d__.<>1__state = -1;
			<RefreshRoleView>d__.<>t__builder.Start<DropCatchGameplayView.<RefreshRoleView>d__35>(ref <RefreshRoleView>d__);
			return <RefreshRoleView>d__.<>t__builder.Task;
		}

		// Token: 0x0603698F RID: 223631 RVA: 0x00F3C884 File Offset: 0x00F3AA84
		private void InitScoreLayout()
		{
			DropCatchGameplayViewModel gameplayViewModel = this.Proxy.GetGameplayViewModel();
			List<float> list = (gameplayViewModel != null) ? gameplayViewModel.GetScoreLevels() : null;
			if (list == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "获取关卡配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.Proxy.GetCurGameplayId());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.ScoreLevelLayout == null)
			{
				this.ScoreLevelLayout = new GenericLayout<DropCatchGameplayScoreItem, IScoreLevelItemData>(base.GetVerticalLayout(7), () => new DropCatchGameplayScoreItem(), null, false, true);
			}
			this.ScoreDataList.Clear();
			foreach (float score in list)
			{
				this.ScoreDataList.Add(new IScoreLevelItemData
				{
					Score = score,
					IsFinish = false
				});
			}
		}

		// Token: 0x06036990 RID: 223632 RVA: 0x00F3C988 File Offset: 0x00F3AB88
		private void InitDropItemLayer()
		{
			UUIItem item = base.GetItem(1);
			this.DropItemLayerTemplate = ((item != null) ? item.GetAttachUIChild(0) : null);
			if (this.DropItemLayerTemplate == null)
			{
				return;
			}
			UUIItem dropItemLayerTemplate = this.DropItemLayerTemplate;
			if (dropItemLayerTemplate == null)
			{
				return;
			}
			dropItemLayerTemplate.SetUIActive(false);
		}

		// Token: 0x06036991 RID: 223633 RVA: 0x00F3C9C0 File Offset: 0x00F3ABC0
		public UUIItem GetDropItemLayer(int index)
		{
			if (this.DropItemLayerTemplate == null)
			{
				Log.Instance.Error(ELogModule.DropCatch, ELogAuthor.CB, "DropItemLayerTemplate is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			int count = this.DropItemLayers.Count;
			if (count <= index)
			{
				for (int i = count; i <= index; i++)
				{
					UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.DropItemLayerTemplate, base.GetItem(1));
					uuiitem.SetUIActive(true);
					this.DropItemLayers.Add(uuiitem);
				}
				for (int j = 0; j < this.DropItemLayers.Count; j++)
				{
					this.DropItemLayers[j].SetHierarchyIndex(this.DropItemLayers.Count - j);
				}
			}
			return this.DropItemLayers[index];
		}

		// Token: 0x06036992 RID: 223634 RVA: 0x00F3CA83 File Offset: 0x00F3AC83
		[NullableContext(1)]
		public UUIItem GetRoleUiParent()
		{
			return base.GetItem(2);
		}

		// Token: 0x06036993 RID: 223635 RVA: 0x00F3CA8C File Offset: 0x00F3AC8C
		private void OnSkillButtonClick()
		{
			base.PlaySequence("Use", null, false);
			AudioSystem.Instance.PostEvent("play_ui_goldcatch_efx_energy_use");
			this.Proxy.UseRoleSkill();
		}

		// Token: 0x06036994 RID: 223636 RVA: 0x00F3CAB6 File Offset: 0x00F3ACB6
		private void OnPauseButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DropCatchGameplayPauseView, this.Proxy, null);
		}

		// Token: 0x06036995 RID: 223637 RVA: 0x00F3CACE File Offset: 0x00F3ACCE
		private void OnDetailButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DropCatchDropItemDetailView, this.Proxy, null);
		}

		// Token: 0x06036996 RID: 223638 RVA: 0x00F3CAE8 File Offset: 0x00F3ACE8
		public void UpdateRoleEnergy()
		{
			DropCatchGameplayLogic gameplayLogic = this.Proxy.GetGameplayLogic();
			IRoleInstance roleInstance = (gameplayLogic != null) ? gameplayLogic.GetRole() : null;
			if (roleInstance == null)
			{
				Log.Instance.Error(ELogModule.DropCatch, ELogAuthor.CB, "获取角色失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			float energy = roleInstance.GetEnergy();
			float maxEnergy = roleInstance.GetMaxEnergy();
			UUISprite sprite = base.GetSprite(10);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(energy / maxEnergy);
		}

		// Token: 0x06036997 RID: 223639 RVA: 0x00F3CB54 File Offset: 0x00F3AD54
		public void UpdateRoleSkillState()
		{
			DropCatchGameplay? gameplayConfig = this.Proxy.GetGameplayConfig();
			if (gameplayConfig != null && gameplayConfig.GetValueOrDefault().IsSpecial)
			{
				return;
			}
			DropCatchGameplayLogic gameplayLogic = this.Proxy.GetGameplayLogic();
			IRoleInstance roleInstance = (gameplayLogic != null) ? gameplayLogic.GetRole() : null;
			if (roleInstance == null)
			{
				Log.Instance.Error(ELogModule.DropCatch, ELogAuthor.CB, "获取角色失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EDropCatchRoleSkillState skillState = roleInstance.GetSkillState();
			if (skillState == EDropCatchRoleSkillState.Enable)
			{
				base.PlaySequence("FullEnergy", null, false);
				AudioSystem.Instance.PostEvent("play_ui_goldcatch_efx_energy_full");
			}
			else
			{
				base.PlaySequence("Disable", null, false);
			}
			if (skillState == EDropCatchRoleSkillState.Enable)
			{
				UUIButtonComponent button = base.GetButton(3);
				if (button != null && !button.IsSelfInteractive)
				{
					EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "DropCatchSkillActive");
				}
			}
			UUIButtonComponent button2 = base.GetButton(3);
			if (button2 != null)
			{
				button2.SetSelfInteractive(skillState == EDropCatchRoleSkillState.Enable);
			}
			if (skillState == EDropCatchRoleSkillState.InSkill)
			{
				DropCatchGameplayRoleView roleView = this.RoleView;
				if (roleView != null)
				{
					DropCatchGameplayRoleFxView fxView = roleView.GetFxView();
					if (fxView != null)
					{
						fxView.PlaySpeedUp();
					}
				}
				AudioSystem.Instance.SetState("game_sys_fever", "fever", true);
				return;
			}
			DropCatchGameplayRoleView roleView2 = this.RoleView;
			if (roleView2 != null)
			{
				DropCatchGameplayRoleFxView fxView2 = roleView2.GetFxView();
				if (fxView2 != null)
				{
					fxView2.HideSpeedUp();
				}
			}
			AudioSystem.Instance.SetState("game_sys_fever", "none", true);
		}

		// Token: 0x06036998 RID: 223640 RVA: 0x00F3CCB0 File Offset: 0x00F3AEB0
		public void UpdateScore()
		{
			float curScore = this.Proxy.GetCurScore();
			UUIArtText artText = base.GetArtText(6);
			if (artText != null)
			{
				artText.SetText(curScore.ToString());
			}
			foreach (IScoreLevelItemData scoreLevelItemData in this.ScoreDataList)
			{
				scoreLevelItemData.IsFinish = (curScore >= scoreLevelItemData.Score);
			}
			GenericLayout<DropCatchGameplayScoreItem, IScoreLevelItemData> scoreLevelLayout = this.ScoreLevelLayout;
			if (scoreLevelLayout == null)
			{
				return;
			}
			scoreLevelLayout.RefreshByData(this.ScoreDataList, null, false);
		}

		// Token: 0x06036999 RID: 223641 RVA: 0x00F3CD4C File Offset: 0x00F3AF4C
		public void UpdateRemainTime()
		{
			DropCatchGameplayLogic gameplayLogic = this.Proxy.GetGameplayLogic();
			float num = (gameplayLogic != null) ? gameplayLogic.GetRemainingTime() : 0f;
			string remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat6((double)num * TimeUtil.Instance.Millisecond);
			UUIText text = base.GetText(9);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeDataFormat, true);
		}

		// Token: 0x0603699A RID: 223642 RVA: 0x00F3CDA1 File Offset: 0x00F3AFA1
		public void RefreshCrazyMode(bool isCrazyMode)
		{
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(isCrazyMode);
			}
			base.PlaySequence("CrazyMode", null, false);
		}

		// Token: 0x0603699B RID: 223643 RVA: 0x00F3CDC4 File Offset: 0x00F3AFC4
		public DropCatchGameplayRoleView GetRoleView()
		{
			return this.RoleView;
		}

		// Token: 0x0603699C RID: 223644 RVA: 0x00F3CDCC File Offset: 0x00F3AFCC
		public DropCatchGameplayJoystickView GetJoystickView()
		{
			return this.JoystickView;
		}

		// Token: 0x0603699D RID: 223645 RVA: 0x00F3CDD4 File Offset: 0x00F3AFD4
		[NullableContext(1)]
		public UniTask PlayCountDown(Action onComplete)
		{
			DropCatchGameplayView.<PlayCountDown>d__50 <PlayCountDown>d__;
			<PlayCountDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCountDown>d__.<>4__this = this;
			<PlayCountDown>d__.onComplete = onComplete;
			<PlayCountDown>d__.<>1__state = -1;
			<PlayCountDown>d__.<>t__builder.Start<DropCatchGameplayView.<PlayCountDown>d__50>(ref <PlayCountDown>d__);
			return <PlayCountDown>d__.<>t__builder.Task;
		}

		// Token: 0x0603699E RID: 223646 RVA: 0x00F3CE1F File Offset: 0x00F3B01F
		protected override void OnTick(float delta)
		{
			this.DrawDebug();
		}

		// Token: 0x0603699F RID: 223647 RVA: 0x00F3CE27 File Offset: 0x00F3B027
		public void Pause()
		{
			DropCatchGameplayCountDownView countDownView = this.CountDownView;
			if (countDownView == null)
			{
				return;
			}
			countDownView.Pause();
		}

		// Token: 0x060369A0 RID: 223648 RVA: 0x00F3CE39 File Offset: 0x00F3B039
		public void Resume()
		{
			DropCatchGameplayCountDownView countDownView = this.CountDownView;
			if (countDownView == null)
			{
				return;
			}
			countDownView.Resume();
		}

		// Token: 0x060369A1 RID: 223649 RVA: 0x00F3CE4C File Offset: 0x00F3B04C
		private void RefreshHistoryScore()
		{
			DropCatchGameplay? gameplayConfig = this.Proxy.GetGameplayConfig();
			if (gameplayConfig == null)
			{
				return;
			}
			bool flag = gameplayConfig.Value.IsSpecial && gameplayConfig.Value.IsNeedSettle;
			UUIItem item = base.GetItem(17);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				float gameplayScoreRecord = DropCatchModel.Instance.GetGameplayScoreRecord(gameplayConfig.Value.Id);
				UUIArtText artText = base.GetArtText(18);
				if (artText == null)
				{
					return;
				}
				artText.SetText(gameplayScoreRecord.ToString());
			}
		}

		// Token: 0x060369A2 RID: 223650 RVA: 0x00F3CEE0 File Offset: 0x00F3B0E0
		private void RefreshSkillVisible()
		{
			DropCatchGameplay? gameplayConfig = this.Proxy.GetGameplayConfig();
			if (gameplayConfig == null)
			{
				return;
			}
			UUIItem item = base.GetItem(20);
			if (item != null)
			{
				item.SetUIActive(!gameplayConfig.Value.IsSpecial);
			}
			UUIButtonComponent button = base.GetButton(3);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(!gameplayConfig.Value.IsSpecial);
		}

		// Token: 0x060369A3 RID: 223651 RVA: 0x00F3CF58 File Offset: 0x00F3B158
		private void RefreshDetailButtonVisible()
		{
			DropCatchGameplay? gameplayConfig = this.Proxy.GetGameplayConfig();
			if (gameplayConfig == null)
			{
				return;
			}
			UUIButtonComponent button = base.GetButton(5);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(!gameplayConfig.Value.IsSpecial);
		}

		// Token: 0x060369A4 RID: 223652 RVA: 0x00F3CFAB File Offset: 0x00F3B1AB
		private void SetRobotLeft(int isLeft)
		{
			if (this.IsRobotLeft == isLeft)
			{
				return;
			}
			this.IsRobotLeft = isLeft;
			this.PlayRobotAnimation();
		}

		// Token: 0x060369A5 RID: 223653 RVA: 0x00F3CFC4 File Offset: 0x00F3B1C4
		private void SetRobotHappy(int isHappy)
		{
			if (this.IsRobotHappy == isHappy)
			{
				return;
			}
			this.IsRobotHappy = isHappy;
			this.PlayRobotAnimation();
		}

		// Token: 0x060369A6 RID: 223654 RVA: 0x00F3CFE0 File Offset: 0x00F3B1E0
		public void PlayRobotAnimation()
		{
			EDropCatchRobotAnimState edropCatchRobotAnimState = this.RobotAnimStateTable[this.IsRobotHappy][this.IsRobotLeft];
			EDropCatchRobotAnimState? lastRobotAnimState = this.LastRobotAnimState;
			EDropCatchRobotAnimState edropCatchRobotAnimState2 = edropCatchRobotAnimState;
			if (lastRobotAnimState.GetValueOrDefault() == edropCatchRobotAnimState2 & lastRobotAnimState != null)
			{
				return;
			}
			this.LastRobotAnimState = new EDropCatchRobotAnimState?(edropCatchRobotAnimState);
			USpineSkeletonAnimationComponent spine = base.GetSpine(23);
			if (spine == null)
			{
				return;
			}
			spine.SetAnimation(0, edropCatchRobotAnimState.ToEnumString(), true);
		}

		// Token: 0x060369A7 RID: 223655 RVA: 0x00F3D048 File Offset: 0x00F3B248
		public UniTask PlayStartSequence()
		{
			DropCatchGameplayView.<PlayStartSequence>d__60 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<DropCatchGameplayView.<PlayStartSequence>d__60>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x060369A8 RID: 223656 RVA: 0x00F3D08C File Offset: 0x00F3B28C
		private void DrawDebug()
		{
			if (this.Proxy.GetEnableDebug())
			{
				DropCatchGameplayLogic gameplayLogic = this.Proxy.GetGameplayLogic();
				IRoleInstance roleInstance = (gameplayLogic != null) ? gameplayLogic.GetRole() : null;
				string text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (roleInstance.GetSkillState() != EDropCatchRoleSkillState.InSkill)
				{
					text = "";
				}
				else
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
					defaultInterpolatedStringHandler.AppendLiteral("\n技能能量消耗:");
					defaultInterpolatedStringHandler.AppendFormatted<float>(roleInstance.GetSkillReduceEnergy());
					defaultInterpolatedStringHandler.AppendLiteral("\n技能能量消耗提升间隔:");
					defaultInterpolatedStringHandler.AppendFormatted<float>(roleInstance.GetSkillReduceEnergyRateInterval());
					defaultInterpolatedStringHandler.AppendLiteral("\n技能能量消耗提升倍率:");
					defaultInterpolatedStringHandler.AppendFormatted<float>(roleInstance.GetSkillReduceEnergyRate());
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				string value = text;
				string text2 = "";
				DropCatchGameplayLogic gameplayLogic2 = this.Proxy.GetGameplayLogic();
				Dictionary<int, IDropPoolRuntime> dictionary;
				if (gameplayLogic2 == null)
				{
					dictionary = null;
				}
				else
				{
					DropCatchGameplayDropItemMgr gameplayDropItemMgr = gameplayLogic2.GetGameplayDropItemMgr();
					dictionary = ((gameplayDropItemMgr != null) ? gameplayDropItemMgr.GetDropPools() : null);
				}
				Dictionary<int, IDropPoolRuntime> dictionary2 = dictionary;
				DropCatchGameplayLogic gameplayLogic3 = this.Proxy.GetGameplayLogic();
				float? num;
				if (gameplayLogic3 == null)
				{
					num = null;
				}
				else
				{
					DropCatchGameplayTimeMgr gameplayTimeMgr = gameplayLogic3.GetGameplayTimeMgr();
					num = ((gameplayTimeMgr != null) ? new float?(gameplayTimeMgr.GetTime()) : null);
				}
				float? num2 = num;
				if (dictionary2 != null && num2 != null)
				{
					foreach (IDropPoolRuntime dropPoolRuntime in dictionary2.Values)
					{
						float? num3 = num2;
						double? num4 = (num3 != null) ? new double?((double)num3.GetValueOrDefault()) : null;
						double num5 = dropPoolRuntime.TimeRange[0];
						bool flag;
						if (num4.GetValueOrDefault() >= num5 & num4 != null)
						{
							if (dropPoolRuntime.TimeRange.Count != 1)
							{
								num3 = num2;
								num4 = ((num3 != null) ? new double?((double)num3.GetValueOrDefault()) : null);
								num5 = dropPoolRuntime.TimeRange[1];
								flag = (num4.GetValueOrDefault() <= num5 & num4 != null);
							}
							else
							{
								flag = true;
							}
						}
						else
						{
							flag = false;
						}
						if (flag)
						{
							string str = text2;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
							defaultInterpolatedStringHandler.AppendLiteral("\nID:");
							defaultInterpolatedStringHandler.AppendFormatted<int>(dropPoolRuntime.PoolId);
							text2 = str + defaultInterpolatedStringHandler.ToStringAndClear();
						}
					}
				}
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(146, 21);
				defaultInterpolatedStringHandler.AppendLiteral("角色信息:Id:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(roleInstance.GetRoleId());
				defaultInterpolatedStringHandler.AppendLiteral("\n角色Size:X:");
				defaultInterpolatedStringHandler.AppendFormatted<double>(roleInstance.GetRoleSize().X);
				defaultInterpolatedStringHandler.AppendLiteral(",Y:");
				defaultInterpolatedStringHandler.AppendFormatted<double>(roleInstance.GetRoleSize().Y);
				defaultInterpolatedStringHandler.AppendLiteral("\n碗Size:X:");
				defaultInterpolatedStringHandler.AppendFormatted<double>(roleInstance.GetBowlSize().X);
				defaultInterpolatedStringHandler.AppendLiteral(",Y:");
				defaultInterpolatedStringHandler.AppendFormatted<double>(roleInstance.GetBowlSize().Y);
				defaultInterpolatedStringHandler.AppendLiteral("\n速度:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(roleInstance.GetSpeedAttr().GetFinalValue());
				defaultInterpolatedStringHandler.AppendLiteral(",能量:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(roleInstance.GetEnergy());
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<float>(roleInstance.GetMaxEnergy());
				defaultInterpolatedStringHandler.AppendLiteral("\n角色能量获取倍率:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(roleInstance.GetEnergyGetRate());
				defaultInterpolatedStringHandler.AppendLiteral("\n角色能量自动回复:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(roleInstance.GetEnergySelfRecover());
				defaultInterpolatedStringHandler.AppendLiteral("/秒\n角色护盾时间:");
				defaultInterpolatedStringHandler.AppendFormatted<double>((double)roleInstance.GetShieldTime() * TimeUtil.Instance.Millisecond);
				defaultInterpolatedStringHandler.AppendLiteral("秒\n角色技能状态:");
				defaultInterpolatedStringHandler.AppendFormatted<EDropCatchRoleSkillState>(roleInstance.GetSkillState());
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("\n生效的掉落物池:");
				defaultInterpolatedStringHandler.AppendFormatted(text2);
				defaultInterpolatedStringHandler.AppendLiteral("\n关卡信息:Id:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Proxy.GetCurGameplayId());
				defaultInterpolatedStringHandler.AppendLiteral("\n区域:MinX:");
				DropCatchGameplayLogic gameplayLogic4 = this.Proxy.GetGameplayLogic();
				defaultInterpolatedStringHandler.AppendFormatted<double?>((gameplayLogic4 != null) ? new double?(gameplayLogic4.GetGameplayArea().MinX) : null);
				defaultInterpolatedStringHandler.AppendLiteral(",MinY:");
				DropCatchGameplayLogic gameplayLogic5 = this.Proxy.GetGameplayLogic();
				defaultInterpolatedStringHandler.AppendFormatted<double?>((gameplayLogic5 != null) ? new double?(gameplayLogic5.GetGameplayArea().MinY) : null);
				defaultInterpolatedStringHandler.AppendLiteral("\nMaxX:");
				DropCatchGameplayLogic gameplayLogic6 = this.Proxy.GetGameplayLogic();
				defaultInterpolatedStringHandler.AppendFormatted<double?>((gameplayLogic6 != null) ? new double?(gameplayLogic6.GetGameplayArea().MaxX) : null);
				defaultInterpolatedStringHandler.AppendLiteral(",MaxY:");
				DropCatchGameplayLogic gameplayLogic7 = this.Proxy.GetGameplayLogic();
				defaultInterpolatedStringHandler.AppendFormatted<double?>((gameplayLogic7 != null) ? new double?(gameplayLogic7.GetGameplayArea().MaxY) : null);
				defaultInterpolatedStringHandler.AppendLiteral("\n全局分数获取倍率:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.Proxy.GetGameplayLogic().GetAddScoreRate());
				defaultInterpolatedStringHandler.AppendLiteral("\n全局能量获取倍率:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.Proxy.GetGameplayLogic().GetEnergyGetRate());
				string newText = defaultInterpolatedStringHandler.ToStringAndClear();
				base.GetText(16).SetText(newText, true);
			}
		}

		// Token: 0x0401CDBA RID: 118202
		private readonly int ROBOT_POS_X = 140;

		// Token: 0x0401CDBB RID: 118203
		[Nullable(1)]
		private DropCatchGameplayProxy Proxy;

		// Token: 0x0401CDBC RID: 118204
		private DropCatchGameplayJoystickView JoystickView;

		// Token: 0x0401CDBD RID: 118205
		private DropCatchGameplayLeftMsgView MsgGameplayView;

		// Token: 0x0401CDBE RID: 118206
		private DropCatchGameplayLeftMsgView MsgDropItemView;

		// Token: 0x0401CDBF RID: 118207
		private DropCatchGameplayRoleView RoleView;

		// Token: 0x0401CDC0 RID: 118208
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DropCatchGameplayScoreItem, IScoreLevelItemData> ScoreLevelLayout;

		// Token: 0x0401CDC1 RID: 118209
		[Nullable(1)]
		private readonly List<IScoreLevelItemData> ScoreDataList = new List<IScoreLevelItemData>();

		// Token: 0x0401CDC2 RID: 118210
		[Nullable(1)]
		private readonly List<UUIItem> DropItemLayers = new List<UUIItem>();

		// Token: 0x0401CDC3 RID: 118211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private DropCatchGameplayPanelViewPool<DropCatchGameplayFloatEffView> FloatEffPool;

		// Token: 0x0401CDC4 RID: 118212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private DropCatchGameplayPanelViewPool<DropCatchGameplayDropItemFxView> DropItemFxPool;

		// Token: 0x0401CDC5 RID: 118213
		private DropCatchGameplayCountDownView CountDownView;

		// Token: 0x0401CDC6 RID: 118214
		private UUIItem DropItemLayerTemplate;

		// Token: 0x0401CDC7 RID: 118215
		private int IsRobotLeft = 1;

		// Token: 0x0401CDC8 RID: 118216
		private int IsRobotHappy;

		// Token: 0x0401CDC9 RID: 118217
		private EDropCatchRobotAnimState? LastRobotAnimState;

		// Token: 0x0401CDCA RID: 118218
		[Nullable(1)]
		private readonly EDropCatchRobotAnimState[][] RobotAnimStateTable;

		// Token: 0x0401CDCB RID: 118219
		private DropCatchGameplayRoleView BgRoleView;
	}
}
