using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200515E RID: 20830
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceGymTabView : PhantomArenaChildViewBase
	{
		// Token: 0x17008119 RID: 33049
		// (get) Token: 0x06035401 RID: 218113 RVA: 0x00C9C0DF File Offset: 0x00C9A2DF
		// (set) Token: 0x06035402 RID: 218114 RVA: 0x00C9C0EC File Offset: 0x00C9A2EC
		public new PhantomArenaEntranceViewModel ViewModel
		{
			get
			{
				return this.ViewModel as PhantomArenaEntranceViewModel;
			}
			set
			{
				this.ViewModel = value;
			}
		}

		// Token: 0x06035403 RID: 218115 RVA: 0x00C9C0F8 File Offset: 0x00C9A2F8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUISprite)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickCard)),
				new ValueTuple<int, Delegate>(10, new Action(this.OnClickRole)),
				new ValueTuple<int, Delegate>(11, new Action(this.OnClickCollect))
			};
		}

		// Token: 0x06035404 RID: 218116 RVA: 0x00C9C314 File Offset: 0x00C9A514
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaEntranceGymTabView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaEntranceGymTabView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035405 RID: 218117 RVA: 0x00C9C358 File Offset: 0x00C9A558
		protected override void OnStart()
		{
			base.GetItem(1).SetWidth(base.GetItem(13).GetWidth());
			DragInteractParam param = new DragInteractParam
			{
				Draggable = base.GetDraggable(0),
				CallbackOnDown = new Action(this.OnDown),
				CallbackOnDrag = new Action<Vector2D>(this.OnDrag),
				CallbackOnInertia = new Action<Vector2D>(this.OnInertia)
			};
			this.TweenerDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnTweenUpdate));
			this.DragComponent = new DragInteractComponent(param);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEnd));
			FVector2D anchorOffset = base.GetItem(14).GetAnchorOffset();
			this.GymOffset = Vector2D.Create((double)anchorOffset.X, (double)anchorOffset.Y);
		}

		// Token: 0x06035406 RID: 218118 RVA: 0x00C9C428 File Offset: 0x00C9A628
		protected override void OnBeforeShow()
		{
			this.DragComponent.Enable();
			this.BindRedDot();
			this.RefreshBackground();
			this.RefreshBtns();
		}

		// Token: 0x06035407 RID: 218119 RVA: 0x00C9C447 File Offset: 0x00C9A647
		protected override void OnAfterShow()
		{
			this.UpdateBgOffsetMin();
		}

		// Token: 0x06035408 RID: 218120 RVA: 0x00C9C44F File Offset: 0x00C9A64F
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
			this.DragComponent.Disable();
		}

		// Token: 0x06035409 RID: 218121 RVA: 0x00C9C462 File Offset: 0x00C9A662
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnViewportSizeChange));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaChallengeUpdate, new Action(this.OnChallengeUpdate));
		}

		// Token: 0x0603540A RID: 218122 RVA: 0x00C9C499 File Offset: 0x00C9A699
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnViewportSizeChange));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaChallengeUpdate, new Action(this.OnChallengeUpdate));
		}

		// Token: 0x0603540B RID: 218123 RVA: 0x00C9C4D0 File Offset: 0x00C9A6D0
		private void OnViewportSizeChange()
		{
			this.UpdateBgOffsetMin();
			FVector2D anchorOffset = base.GetItem(13).GetAnchorOffset();
			this.SetPosition(Vector2D.Create((double)anchorOffset.X, (double)anchorOffset.Y), false);
		}

		// Token: 0x0603540C RID: 218124 RVA: 0x00C9C50C File Offset: 0x00C9A70C
		protected override void OnBeforeDestroy()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenUpdate));
			if (this.GuideTimerHandle != null && TimerSystem.RealTimeInstance.Has(this.GuideTimerHandle))
			{
				TimerSystem.RealTimeInstance.Remove(this.GuideTimerHandle);
				this.GuideTimerHandle = null;
			}
		}

		// Token: 0x0603540D RID: 218125 RVA: 0x00C9C55C File Offset: 0x00C9A75C
		private void RefreshBackground()
		{
			if (this.IsSwitching)
			{
				this.SequencePlayer.StopPrevSequence(true, true);
			}
			this.Background.RefreshBg(true, this.LastHoverLevel);
			this.IsSwitching = true;
			this.SequencePlayer.PlaySequence("AreaSwitch", false, new float?(1.6f));
		}

		// Token: 0x0603540E RID: 218126 RVA: 0x00C9C5B4 File Offset: 0x00C9A7B4
		private void RefreshBtns()
		{
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.PhantomArenaCard);
			base.SetButtonUiActive(9, flag);
			bool flag2 = FunctionModel.Instance.IsOpen(EFunctionType.PhantomArenaRole);
			base.SetButtonUiActive(10, flag2);
			bool flag3 = FunctionModel.Instance.IsOpen(EFunctionType.PhantomArenaCollect);
			base.SetButtonUiActive(11, flag3);
			base.GetSprite(15).SetUIActive(flag || flag2 || flag3);
		}

		// Token: 0x0603540F RID: 218127 RVA: 0x00C9C620 File Offset: 0x00C9A820
		private void PlayUnlock()
		{
			foreach (GymItemBase gymItemBase in this.GymItemMap.Values)
			{
				gymItemBase.PlayUnlock();
			}
		}

		// Token: 0x06035410 RID: 218128 RVA: 0x00C9C678 File Offset: 0x00C9A878
		private void OnClickLevel(int level)
		{
			PhantomBattleGym? phantomBattleGymConfigByLevel = PhantomArenaModel.Instance.GetPhantomBattleGymConfigByLevel(level, base.ActivityId);
			if (phantomBattleGymConfigByLevel == null)
			{
				return;
			}
			if (phantomBattleGymConfigByLevel.Value.IfRepeat)
			{
				this.ViewModel.SetTabView(EPhantomArenaChildViewName.PhantomArenaEntranceRepeatTabView, false);
				return;
			}
			BattleMatchViewOpenParam param = new BattleMatchViewOpenParam
			{
				Level = level,
				ActivityId = base.ActivityId
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMatchView, param, null);
		}

		// Token: 0x06035411 RID: 218129 RVA: 0x00C9C6EC File Offset: 0x00C9A8EC
		private void OnFocusLevel(int level)
		{
			this.KillPositionTweener(new bool?(true));
			Vector2D gymFocusPosition = this.GetGymFocusPosition(level);
			this.SetPosition(gymFocusPosition, true);
		}

		// Token: 0x06035412 RID: 218130 RVA: 0x00C9C718 File Offset: 0x00C9A918
		private Vector2D GetGymFocusPosition(int level)
		{
			double num = this.GymItemMap[level].GetAnchorOffsetX() - -700.0;
			return Vector2D.Create(330.0 - num, 0.0);
		}

		// Token: 0x06035413 RID: 218131 RVA: 0x00C9C75A File Offset: 0x00C9A95A
		private void OnHoverLevel(int level)
		{
			if (PhantomArenaDefine.positionGymLevel[this.LastHoverLevel - 1] == PhantomArenaDefine.positionGymLevel[level - 1])
			{
				return;
			}
			this.LastHoverLevel = level;
			this.RefreshBackground();
		}

		// Token: 0x06035414 RID: 218132 RVA: 0x00C9C788 File Offset: 0x00C9A988
		private void OnUnHoverLevel(int level)
		{
		}

		// Token: 0x06035415 RID: 218133 RVA: 0x00C9C78A File Offset: 0x00C9A98A
		private void OnSequenceEnd(string sequenceName)
		{
			if (sequenceName == "AreaSwitch")
			{
				this.IsSwitching = false;
				this.Background.RefreshBg(false, this.LastHoverLevel);
				return;
			}
			if (sequenceName == "Start")
			{
				this.PlayUnlock();
			}
		}

		// Token: 0x06035416 RID: 218134 RVA: 0x00C9C7C8 File Offset: 0x00C9A9C8
		private void OnClickCard()
		{
			PhantomArenaMainViewOpenParam param = new PhantomArenaMainViewOpenParam
			{
				ChallengeId = 0,
				OpenView = EPhantomArenaChildViewName.PhantomArenaDeckOverviewTabView,
				ActivityId = base.ActivityId
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMainView, param, null);
		}

		// Token: 0x06035417 RID: 218135 RVA: 0x00C9C808 File Offset: 0x00C9AA08
		private void OnClickRole()
		{
			PhantomArenaMainViewOpenParam param = new PhantomArenaMainViewOpenParam
			{
				ChallengeId = 0,
				OpenView = EPhantomArenaChildViewName.PhantomArenaRoleSelectTabView,
				ActivityId = base.ActivityId
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMainView, param, null);
		}

		// Token: 0x06035418 RID: 218136 RVA: 0x00C9C846 File Offset: 0x00C9AA46
		private void OnClickCollect()
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaCollectView, base.ActivityId, null);
		}

		// Token: 0x06035419 RID: 218137 RVA: 0x00C9C863 File Offset: 0x00C9AA63
		private void OnDown()
		{
			this.KillPositionTweener(new bool?(true));
		}

		// Token: 0x0603541A RID: 218138 RVA: 0x00C9C874 File Offset: 0x00C9AA74
		private void OnDrag(Vector2D delta)
		{
			if (this.GymOffset == null)
			{
				return;
			}
			Vector2D inTarget = Vector2D.Create(this.GymOffset).AdditionEqual(delta);
			this.SetPosition(inTarget, false);
		}

		// Token: 0x0603541B RID: 218139 RVA: 0x00C9C8A4 File Offset: 0x00C9AAA4
		private void OnInertia(Vector2D speed)
		{
			Vector2D vector2D = Vector2D.Create();
			speed.Multiply(0.6179999709129333, vector2D);
			Vector2D inTarget = Vector2D.Create(this.GymOffset).AdditionEqual(vector2D);
			this.SetPosition(inTarget, true);
		}

		// Token: 0x0603541C RID: 218140 RVA: 0x00C9C8E4 File Offset: 0x00C9AAE4
		[NullableContext(2)]
		public void SetPosition(Vector2D inTarget, bool bUseTween)
		{
			if (inTarget == null)
			{
				return;
			}
			Vector2D vector2D = Vector2D.Create();
			if (inTarget != null)
			{
				vector2D.DeepCopy(inTarget);
			}
			Vector2D position = Vector2D.Create(vector2D.X, vector2D.Y);
			vector2D = this.ClampPosition(position);
			FVector2D startValue = this.GymOffset.ToUeVector2D(false);
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			bool flag = this.NearlyPosition(this.GymOffset.X, (double)fvector2D.X);
			if (!bUseTween || flag)
			{
				FVector2D anchorOffset = vector2D.ToUeVector2D(false);
				FVector2D anchorOffset2 = Vector2D.Create(vector2D.X * 0.85, vector2D.Y).ToUeVector2D(false);
				base.GetItem(14).SetAnchorOffset(anchorOffset2);
				base.GetItem(13).SetAnchorOffset(anchorOffset);
				this.GymOffset = vector2D;
				return;
			}
			this.KillPositionTweener(null);
			this.PositionTweener = ULTweenBPLibrary.Vector2To(GlobalData.World, this.TweenerDelegate, startValue, fvector2D, 0.618f, 0f, LTweenEase.OutQuad);
		}

		// Token: 0x0603541D RID: 218141 RVA: 0x00C9C9DC File Offset: 0x00C9ABDC
		private bool NearlyPosition(double srcPositionX, double dstPositionX)
		{
			return MathUtils.Instance.IsNearlyEqual(srcPositionX, dstPositionX, null);
		}

		// Token: 0x0603541E RID: 218142 RVA: 0x00C9C9FE File Offset: 0x00C9ABFE
		private Vector2D ClampPosition(Vector2D position)
		{
			double x = position.X;
			return Vector2D.Create(MathCommon.Clamp(position.X, this.BgOffsetMin, 330.0), 0.0);
		}

		// Token: 0x0603541F RID: 218143 RVA: 0x00C9CA2F File Offset: 0x00C9AC2F
		private void KillPositionTweener(bool? callComplete = null)
		{
			ULTweener positionTweener = this.PositionTweener;
			if (positionTweener != null && positionTweener.IsValid())
			{
				this.PositionTweener.Kill(callComplete.GetValueOrDefault());
				this.PositionTweener = null;
			}
		}

		// Token: 0x06035420 RID: 218144 RVA: 0x00C9CA60 File Offset: 0x00C9AC60
		private void UpdateBgOffsetMin()
		{
			double num = (double)base.GetItem(13).Width;
			double num2 = (double)base.GetItem(13).GetParentAsUIItem().Width;
			this.BgOffsetMin = num2 - num;
		}

		// Token: 0x06035421 RID: 218145 RVA: 0x00C9CA9C File Offset: 0x00C9AC9C
		private void OnTweenUpdate(FVector2D value)
		{
			Vector2D inTarget = Vector2D.Create(value);
			this.SetPosition(inTarget, false);
		}

		// Token: 0x06035422 RID: 218146 RVA: 0x00C9CAC0 File Offset: 0x00C9ACC0
		private void BindRedDot()
		{
			this.UnBindRedDot();
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotPhantomArenaCollect, base.GetItem(18), null, base.ActivityId);
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotPhantomArenaRole, base.GetItem(17), null, base.ActivityId);
			base.GetItem(16).SetUIActive(false);
			foreach (GymItemBase gymItemBase in this.GymItemMap.Values)
			{
				gymItemBase.RefreshRedDot();
			}
		}

		// Token: 0x06035423 RID: 218147 RVA: 0x00C9CB68 File Offset: 0x00C9AD68
		private void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomArenaCollect, base.GetItem(18), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomArenaRole, base.GetItem(17), 0);
		}

		// Token: 0x06035424 RID: 218148 RVA: 0x00C9CB9C File Offset: 0x00C9AD9C
		private void OnChallengeUpdate()
		{
			foreach (GymItemBase gymItemBase in this.GymItemMap.Values)
			{
				gymItemBase.RefreshRedDot();
			}
		}

		// Token: 0x06035425 RID: 218149 RVA: 0x00C9CBF4 File Offset: 0x00C9ADF4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx([Nullable(new byte[]
		{
			2,
			1
		})] string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "GuideHook"))
			{
				return null;
			}
			if (configParams.Length < 2)
			{
				return null;
			}
			string text = configParams[1];
			UUIItem guideUiItem = base.GetGuideUiItem(text);
			if (text == "1")
			{
				this.GuideTimerHandle = TimerSystem.RealTimeInstance.Delay(delegate(float _)
				{
					this.OnFocusLevel(7);
				}, 1000f, null, null, true, 1f);
			}
			if (guideUiItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideUiItem,
				guideUiItem
			};
		}

		// Token: 0x0401C556 RID: 116054
		private int LastHoverLevel = 1;

		// Token: 0x0401C557 RID: 116055
		private bool IsSwitching;

		// Token: 0x0401C558 RID: 116056
		private readonly Dictionary<int, GymItemBase> GymItemMap = new Dictionary<int, GymItemBase>();

		// Token: 0x0401C559 RID: 116057
		[Nullable(2)]
		private DragInteractComponent DragComponent;

		// Token: 0x0401C55A RID: 116058
		[Nullable(2)]
		private Vector2D GymOffset;

		// Token: 0x0401C55B RID: 116059
		[Nullable(2)]
		private EntranceBackgroundPanel Background;

		// Token: 0x0401C55C RID: 116060
		[Nullable(2)]
		private ULTweener PositionTweener;

		// Token: 0x0401C55D RID: 116061
		[Nullable(2)]
		private FLTweenVector2SetterDynamic TweenerDelegate;

		// Token: 0x0401C55E RID: 116062
		private double BgOffsetMin;

		// Token: 0x0401C55F RID: 116063
		[Nullable(2)]
		private TimerHandle GuideTimerHandle;

		// Token: 0x0200B2BE RID: 45758
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036278 RID: 221816
			public const int DragLevel = 0;

			// Token: 0x04036279 RID: 221817
			public const int ContentMain = 1;

			// Token: 0x0403627A RID: 221818
			public const int BtnLevel1 = 2;

			// Token: 0x0403627B RID: 221819
			public const int BtnLevel2 = 3;

			// Token: 0x0403627C RID: 221820
			public const int BtnLevel3 = 4;

			// Token: 0x0403627D RID: 221821
			public const int BtnLevel4 = 5;

			// Token: 0x0403627E RID: 221822
			public const int BtnLevel5 = 6;

			// Token: 0x0403627F RID: 221823
			public const int BtnLevel6 = 7;

			// Token: 0x04036280 RID: 221824
			public const int BtnLevel7 = 8;

			// Token: 0x04036281 RID: 221825
			public const int BtnMenuCard = 9;

			// Token: 0x04036282 RID: 221826
			public const int BtnMenuRole = 10;

			// Token: 0x04036283 RID: 221827
			public const int BtnMenuCollect = 11;

			// Token: 0x04036284 RID: 221828
			public const int PanelBg = 12;

			// Token: 0x04036285 RID: 221829
			public const int ContentBg = 13;

			// Token: 0x04036286 RID: 221830
			public const int PanelBtnLevel = 14;

			// Token: 0x04036287 RID: 221831
			public const int SpriteBtnBg = 15;

			// Token: 0x04036288 RID: 221832
			public const int ItemRedDotCard = 16;

			// Token: 0x04036289 RID: 221833
			public const int ItemRedDotRole = 17;

			// Token: 0x0403628A RID: 221834
			public const int ItemRedDotCollect = 18;
		}
	}
}
