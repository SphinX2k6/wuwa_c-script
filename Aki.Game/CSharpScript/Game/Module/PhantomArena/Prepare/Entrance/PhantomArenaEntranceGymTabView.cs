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
	// Token: 0x0200412E RID: 16686
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceGymTabView : PhantomArenaChildViewBase
	{
		// Token: 0x170054D9 RID: 21721
		// (get) Token: 0x0602A2FD RID: 172797 RVA: 0x00BE95DF File Offset: 0x00BE77DF
		// (set) Token: 0x0602A2FE RID: 172798 RVA: 0x00BE95EC File Offset: 0x00BE77EC
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

		// Token: 0x0602A2FF RID: 172799 RVA: 0x00BE95F8 File Offset: 0x00BE77F8
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

		// Token: 0x0602A300 RID: 172800 RVA: 0x00BE9814 File Offset: 0x00BE7A14
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaEntranceGymTabView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaEntranceGymTabView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A301 RID: 172801 RVA: 0x00BE9858 File Offset: 0x00BE7A58
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

		// Token: 0x0602A302 RID: 172802 RVA: 0x00BE9928 File Offset: 0x00BE7B28
		protected override void OnBeforeShow()
		{
			this.DragComponent.Enable();
			this.BindRedDot();
			this.RefreshBackground();
			this.RefreshBtns();
		}

		// Token: 0x0602A303 RID: 172803 RVA: 0x00BE9947 File Offset: 0x00BE7B47
		protected override void OnAfterShow()
		{
			this.UpdateBgOffsetMin();
		}

		// Token: 0x0602A304 RID: 172804 RVA: 0x00BE994F File Offset: 0x00BE7B4F
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
			this.DragComponent.Disable();
		}

		// Token: 0x0602A305 RID: 172805 RVA: 0x00BE9962 File Offset: 0x00BE7B62
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnViewportSizeChange));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaChallengeUpdate, new Action(this.OnChallengeUpdate));
		}

		// Token: 0x0602A306 RID: 172806 RVA: 0x00BE9999 File Offset: 0x00BE7B99
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnViewportSizeChange));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaChallengeUpdate, new Action(this.OnChallengeUpdate));
		}

		// Token: 0x0602A307 RID: 172807 RVA: 0x00BE99D0 File Offset: 0x00BE7BD0
		private void OnViewportSizeChange()
		{
			this.UpdateBgOffsetMin();
			FVector2D anchorOffset = base.GetItem(13).GetAnchorOffset();
			this.SetPosition(Vector2D.Create((double)anchorOffset.X, (double)anchorOffset.Y), false);
		}

		// Token: 0x0602A308 RID: 172808 RVA: 0x00BE9A0C File Offset: 0x00BE7C0C
		protected override void OnBeforeDestroy()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenUpdate));
			if (this.GuideTimerHandle != null && TimerSystem.RealTimeInstance.Has(this.GuideTimerHandle))
			{
				TimerSystem.RealTimeInstance.Remove(this.GuideTimerHandle);
				this.GuideTimerHandle = null;
			}
		}

		// Token: 0x0602A309 RID: 172809 RVA: 0x00BE9A5C File Offset: 0x00BE7C5C
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

		// Token: 0x0602A30A RID: 172810 RVA: 0x00BE9AB4 File Offset: 0x00BE7CB4
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

		// Token: 0x0602A30B RID: 172811 RVA: 0x00BE9B20 File Offset: 0x00BE7D20
		private void PlayUnlock()
		{
			foreach (GymItemBase gymItemBase in this.GymItemMap.Values)
			{
				gymItemBase.PlayUnlock();
			}
		}

		// Token: 0x0602A30C RID: 172812 RVA: 0x00BE9B78 File Offset: 0x00BE7D78
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

		// Token: 0x0602A30D RID: 172813 RVA: 0x00BE9BEC File Offset: 0x00BE7DEC
		private void OnFocusLevel(int level)
		{
			this.KillPositionTweener(new bool?(true));
			Vector2D gymFocusPosition = this.GetGymFocusPosition(level);
			this.SetPosition(gymFocusPosition, true);
		}

		// Token: 0x0602A30E RID: 172814 RVA: 0x00BE9C18 File Offset: 0x00BE7E18
		private Vector2D GetGymFocusPosition(int level)
		{
			double num = this.GymItemMap[level].GetAnchorOffsetX() - -700.0;
			return Vector2D.Create(330.0 - num, 0.0);
		}

		// Token: 0x0602A30F RID: 172815 RVA: 0x00BE9C5A File Offset: 0x00BE7E5A
		private void OnHoverLevel(int level)
		{
			if (PhantomArenaDefine.positionGymLevel[this.LastHoverLevel - 1] == PhantomArenaDefine.positionGymLevel[level - 1])
			{
				return;
			}
			this.LastHoverLevel = level;
			this.RefreshBackground();
		}

		// Token: 0x0602A310 RID: 172816 RVA: 0x00BE9C88 File Offset: 0x00BE7E88
		private void OnUnHoverLevel(int level)
		{
		}

		// Token: 0x0602A311 RID: 172817 RVA: 0x00BE9C8A File Offset: 0x00BE7E8A
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

		// Token: 0x0602A312 RID: 172818 RVA: 0x00BE9CC8 File Offset: 0x00BE7EC8
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

		// Token: 0x0602A313 RID: 172819 RVA: 0x00BE9D08 File Offset: 0x00BE7F08
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

		// Token: 0x0602A314 RID: 172820 RVA: 0x00BE9D46 File Offset: 0x00BE7F46
		private void OnClickCollect()
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaCollectView, base.ActivityId, null);
		}

		// Token: 0x0602A315 RID: 172821 RVA: 0x00BE9D63 File Offset: 0x00BE7F63
		private void OnDown()
		{
			this.KillPositionTweener(new bool?(true));
		}

		// Token: 0x0602A316 RID: 172822 RVA: 0x00BE9D74 File Offset: 0x00BE7F74
		private void OnDrag(Vector2D delta)
		{
			if (this.GymOffset == null)
			{
				return;
			}
			Vector2D inTarget = Vector2D.Create(this.GymOffset).AdditionEqual(delta);
			this.SetPosition(inTarget, false);
		}

		// Token: 0x0602A317 RID: 172823 RVA: 0x00BE9DA4 File Offset: 0x00BE7FA4
		private void OnInertia(Vector2D speed)
		{
			Vector2D vector2D = Vector2D.Create();
			speed.Multiply(0.6179999709129333, vector2D);
			Vector2D inTarget = Vector2D.Create(this.GymOffset).AdditionEqual(vector2D);
			this.SetPosition(inTarget, true);
		}

		// Token: 0x0602A318 RID: 172824 RVA: 0x00BE9DE4 File Offset: 0x00BE7FE4
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

		// Token: 0x0602A319 RID: 172825 RVA: 0x00BE9EDC File Offset: 0x00BE80DC
		private bool NearlyPosition(double srcPositionX, double dstPositionX)
		{
			return MathUtils.Instance.IsNearlyEqual(srcPositionX, dstPositionX, null);
		}

		// Token: 0x0602A31A RID: 172826 RVA: 0x00BE9EFE File Offset: 0x00BE80FE
		private Vector2D ClampPosition(Vector2D position)
		{
			double x = position.X;
			return Vector2D.Create(MathCommon.Clamp(position.X, this.BgOffsetMin, 330.0), 0.0);
		}

		// Token: 0x0602A31B RID: 172827 RVA: 0x00BE9F2F File Offset: 0x00BE812F
		private void KillPositionTweener(bool? callComplete = null)
		{
			ULTweener positionTweener = this.PositionTweener;
			if (positionTweener != null && positionTweener.IsValid())
			{
				this.PositionTweener.Kill(callComplete.GetValueOrDefault());
				this.PositionTweener = null;
			}
		}

		// Token: 0x0602A31C RID: 172828 RVA: 0x00BE9F60 File Offset: 0x00BE8160
		private void UpdateBgOffsetMin()
		{
			double num = (double)base.GetItem(13).Width;
			double num2 = (double)base.GetItem(13).GetParentAsUIItem().Width;
			this.BgOffsetMin = num2 - num;
		}

		// Token: 0x0602A31D RID: 172829 RVA: 0x00BE9F9C File Offset: 0x00BE819C
		private void OnTweenUpdate(FVector2D value)
		{
			Vector2D inTarget = Vector2D.Create(value);
			this.SetPosition(inTarget, false);
		}

		// Token: 0x0602A31E RID: 172830 RVA: 0x00BE9FC0 File Offset: 0x00BE81C0
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

		// Token: 0x0602A31F RID: 172831 RVA: 0x00BEA068 File Offset: 0x00BE8268
		private void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomArenaCollect, base.GetItem(18), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomArenaRole, base.GetItem(17), 0);
		}

		// Token: 0x0602A320 RID: 172832 RVA: 0x00BEA09C File Offset: 0x00BE829C
		private void OnChallengeUpdate()
		{
			foreach (GymItemBase gymItemBase in this.GymItemMap.Values)
			{
				gymItemBase.RefreshRedDot();
			}
		}

		// Token: 0x0602A321 RID: 172833 RVA: 0x00BEA0F4 File Offset: 0x00BE82F4
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

		// Token: 0x04016F8B RID: 94091
		private int LastHoverLevel = 1;

		// Token: 0x04016F8C RID: 94092
		private bool IsSwitching;

		// Token: 0x04016F8D RID: 94093
		private readonly Dictionary<int, GymItemBase> GymItemMap = new Dictionary<int, GymItemBase>();

		// Token: 0x04016F8E RID: 94094
		[Nullable(2)]
		private DragInteractComponent DragComponent;

		// Token: 0x04016F8F RID: 94095
		[Nullable(2)]
		private Vector2D GymOffset;

		// Token: 0x04016F90 RID: 94096
		[Nullable(2)]
		private EntranceBackgroundPanel Background;

		// Token: 0x04016F91 RID: 94097
		[Nullable(2)]
		private ULTweener PositionTweener;

		// Token: 0x04016F92 RID: 94098
		[Nullable(2)]
		private FLTweenVector2SetterDynamic TweenerDelegate;

		// Token: 0x04016F93 RID: 94099
		private double BgOffsetMin;

		// Token: 0x04016F94 RID: 94100
		[Nullable(2)]
		private TimerHandle GuideTimerHandle;

		// Token: 0x02009CF7 RID: 40183
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030CCD RID: 199885
			public const int DragLevel = 0;

			// Token: 0x04030CCE RID: 199886
			public const int ContentMain = 1;

			// Token: 0x04030CCF RID: 199887
			public const int BtnLevel1 = 2;

			// Token: 0x04030CD0 RID: 199888
			public const int BtnLevel2 = 3;

			// Token: 0x04030CD1 RID: 199889
			public const int BtnLevel3 = 4;

			// Token: 0x04030CD2 RID: 199890
			public const int BtnLevel4 = 5;

			// Token: 0x04030CD3 RID: 199891
			public const int BtnLevel5 = 6;

			// Token: 0x04030CD4 RID: 199892
			public const int BtnLevel6 = 7;

			// Token: 0x04030CD5 RID: 199893
			public const int BtnLevel7 = 8;

			// Token: 0x04030CD6 RID: 199894
			public const int BtnMenuCard = 9;

			// Token: 0x04030CD7 RID: 199895
			public const int BtnMenuRole = 10;

			// Token: 0x04030CD8 RID: 199896
			public const int BtnMenuCollect = 11;

			// Token: 0x04030CD9 RID: 199897
			public const int PanelBg = 12;

			// Token: 0x04030CDA RID: 199898
			public const int ContentBg = 13;

			// Token: 0x04030CDB RID: 199899
			public const int PanelBtnLevel = 14;

			// Token: 0x04030CDC RID: 199900
			public const int SpriteBtnBg = 15;

			// Token: 0x04030CDD RID: 199901
			public const int ItemRedDotCard = 16;

			// Token: 0x04030CDE RID: 199902
			public const int ItemRedDotRole = 17;

			// Token: 0x04030CDF RID: 199903
			public const int ItemRedDotCollect = 18;
		}
	}
}
