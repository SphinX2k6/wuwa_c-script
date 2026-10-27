using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x0200670B RID: 26379
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayRoleView : UiPanelBase
	{
		// Token: 0x06041E21 RID: 269857 RVA: 0x00FFA754 File Offset: 0x00FF8954
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x06041E22 RID: 269858 RVA: 0x00FFA81C File Offset: 0x00FF8A1C
		protected override UniTask OnBeforeStartAsync()
		{
			DropCatchGameplayRoleView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DropCatchGameplayRoleView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041E23 RID: 269859 RVA: 0x00FFA85F File Offset: 0x00FF8A5F
		protected override void OnStart()
		{
		}

		// Token: 0x06041E24 RID: 269860 RVA: 0x00FFA861 File Offset: 0x00FF8A61
		private void UpdateBowlScaleX(float scaleX)
		{
			this.Scale.X = (double)scaleX;
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIItemScale(this.Scale.ToUeVectorOld());
		}

		// Token: 0x06041E25 RID: 269861 RVA: 0x00FFA88C File Offset: 0x00FF8A8C
		public void UpdateRolePos(Vector2D pos)
		{
			base.GetRootItem().SetAnchorOffset(pos.ToUeVector2D(false));
			Action<double> posChangeCallback = this.PosChangeCallback;
			if (posChangeCallback == null)
			{
				return;
			}
			posChangeCallback(pos.X);
		}

		// Token: 0x06041E26 RID: 269862 RVA: 0x00FFA8B8 File Offset: 0x00FF8AB8
		public void PlayAnimation(EDropCatchRoleAnimState state)
		{
			string animationName = this.StateToAnimName[state].ToEnumString();
			if ((this.OpenParam as IDropCatchGameplayRoleViewParams).RoleId == 3)
			{
				animationName = this.StateToMorningSpecialAnimName[state].ToEnumString();
			}
			USpineSkeletonAnimationComponent spine = base.GetSpine(0);
			if (spine != null)
			{
				spine.SetAnimation(0, animationName, true);
			}
			if (this.BowlStates.Contains(state))
			{
				USpineSkeletonAnimationComponent spine2 = base.GetSpine(3);
				if (spine2 != null)
				{
					spine2.SetAnimation(0, state.ToEnumString(), true);
				}
				this.UpdateBowlScaleX(this.BowlSpineScaleX);
			}
			else
			{
				this.UpdateBowlScaleX(0f);
			}
			this.UpdateFxOffset(state);
		}

		// Token: 0x06041E27 RID: 269863 RVA: 0x00FFA95B File Offset: 0x00FF8B5B
		[NullableContext(2)]
		public DropCatchGameplayRoleFxView GetFxView()
		{
			return this.FxView;
		}

		// Token: 0x06041E28 RID: 269864 RVA: 0x00FFA964 File Offset: 0x00FF8B64
		public UniTask CreateFxView()
		{
			DropCatchGameplayRoleView.<CreateFxView>d__17 <CreateFxView>d__;
			<CreateFxView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFxView>d__.<>4__this = this;
			<CreateFxView>d__.<>1__state = -1;
			<CreateFxView>d__.<>t__builder.Start<DropCatchGameplayRoleView.<CreateFxView>d__17>(ref <CreateFxView>d__);
			return <CreateFxView>d__.<>t__builder.Task;
		}

		// Token: 0x06041E29 RID: 269865 RVA: 0x00FFA9A8 File Offset: 0x00FF8BA8
		public UniTask RefreshSpine()
		{
			DropCatchGameplayRoleView.<RefreshSpine>d__18 <RefreshSpine>d__;
			<RefreshSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSpine>d__.<>4__this = this;
			<RefreshSpine>d__.<>1__state = -1;
			<RefreshSpine>d__.<>t__builder.Start<DropCatchGameplayRoleView.<RefreshSpine>d__18>(ref <RefreshSpine>d__);
			return <RefreshSpine>d__.<>t__builder.Task;
		}

		// Token: 0x06041E2A RID: 269866 RVA: 0x00FFA9EC File Offset: 0x00FF8BEC
		public void UpdateFxOffset(EDropCatchRoleAnimState state)
		{
			if (this.LeftStates.Contains(state))
			{
				DropCatchGameplayRoleFxView fxView = this.FxView;
				if (fxView == null)
				{
					return;
				}
				fxView.GetRootItem().SetAnchorOffsetX((float)this.ROLE_FX_OFFSET);
				return;
			}
			else
			{
				DropCatchGameplayRoleFxView fxView2 = this.FxView;
				if (fxView2 == null)
				{
					return;
				}
				fxView2.GetRootItem().SetAnchorOffsetX((float)(-(float)this.ROLE_FX_OFFSET));
				return;
			}
		}

		// Token: 0x06041E2B RID: 269867 RVA: 0x00FFAA44 File Offset: 0x00FF8C44
		public void SetChangeColor(bool useChangeColor, string hexColor, float? duration = null)
		{
			FColor color = FColor.FromHex(hexColor);
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				bool useChangeColor2 = useChangeColor;
				FColor? fcolor = new FColor?(color);
				item.SetChangeColor(useChangeColor2, fcolor);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				bool useChangeColor3 = useChangeColor;
				FColor? fcolor = new FColor?(color);
				item2.SetChangeColor(useChangeColor3, fcolor);
			}
			this.ClearTimer();
			if (duration == null)
			{
				return;
			}
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UUIItem item3 = this.GetItem(7);
				FColor? fcolor2;
				if (item3 != null)
				{
					bool bUseChangeColor = !useChangeColor;
					fcolor2 = new FColor?(color);
					item3.SetChangeColor(bUseChangeColor, fcolor2);
				}
				UUIItem item4 = this.GetItem(4);
				if (item4 == null)
				{
					return;
				}
				bool bUseChangeColor2 = !useChangeColor;
				fcolor2 = new FColor?(color);
				item4.SetChangeColor(bUseChangeColor2, fcolor2);
			}, duration.Value * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
		}

		// Token: 0x06041E2C RID: 269868 RVA: 0x00FFAB04 File Offset: 0x00FF8D04
		private void ClearTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			}
			this.TimerHandle = null;
		}

		// Token: 0x06041E2D RID: 269869 RVA: 0x00FFAB30 File Offset: 0x00FF8D30
		protected override void OnBeforeHide()
		{
			DropCatchGameplayRoleFxView fxView = this.FxView;
			if (fxView == null)
			{
				return;
			}
			fxView.ResetView();
		}

		// Token: 0x06041E2E RID: 269870 RVA: 0x00FFAB42 File Offset: 0x00FF8D42
		protected override void OnBeforeDestroy()
		{
			this.ClearTimer();
		}

		// Token: 0x06041E2F RID: 269871 RVA: 0x00FFAB4C File Offset: 0x00FF8D4C
		private void UpdateDebugSize(float[] roleSizeBias, Tuple<float, float> roleSize, float[] bowlSizeBias, Tuple<float, float> bowlSize)
		{
			if (!DropCatchGameplayController.Instance.EnableDebug)
			{
				UUIItem item = base.GetItem(5);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(6);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else
			{
				UUIItem item3 = base.GetItem(5);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUIItem item4 = base.GetItem(6);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				UUIItem item5 = base.GetItem(5);
				if (item5 != null)
				{
					item5.SetAnchorOffsetX(roleSizeBias[0]);
				}
				UUIItem item6 = base.GetItem(5);
				if (item6 != null)
				{
					item6.SetAnchorOffsetY(roleSizeBias[1]);
				}
				UUIItem item7 = base.GetItem(5);
				if (item7 != null)
				{
					item7.SetWidth(roleSize.Item1);
				}
				UUIItem item8 = base.GetItem(5);
				if (item8 != null)
				{
					item8.SetHeight(roleSize.Item2);
				}
				UUIItem item9 = base.GetItem(6);
				if (item9 != null)
				{
					item9.SetAnchorOffsetX(bowlSizeBias[0]);
				}
				UUIItem item10 = base.GetItem(6);
				if (item10 != null)
				{
					item10.SetAnchorOffsetY(bowlSizeBias[1]);
				}
				UUIItem item11 = base.GetItem(6);
				if (item11 != null)
				{
					item11.SetWidth(bowlSize.Item1);
				}
				UUIItem item12 = base.GetItem(6);
				if (item12 == null)
				{
					return;
				}
				item12.SetHeight(bowlSize.Item2);
				return;
			}
		}

		// Token: 0x04022538 RID: 140600
		private readonly int ROLE_FX_OFFSET = 12;

		// Token: 0x04022539 RID: 140601
		private readonly Dictionary<EDropCatchRoleAnimState, EDropCatchRoleAnimState> StateToAnimName = new Dictionary<EDropCatchRoleAnimState, EDropCatchRoleAnimState>
		{
			{
				EDropCatchRoleAnimState.IdleBowlLeft,
				EDropCatchRoleAnimState.IdleLeft
			},
			{
				EDropCatchRoleAnimState.IdleLeft,
				EDropCatchRoleAnimState.IdleLeft
			},
			{
				EDropCatchRoleAnimState.IdleBowlRight,
				EDropCatchRoleAnimState.IdleRight
			},
			{
				EDropCatchRoleAnimState.IdleRight,
				EDropCatchRoleAnimState.IdleRight
			},
			{
				EDropCatchRoleAnimState.WalkBowlLeft,
				EDropCatchRoleAnimState.WalkLeft
			},
			{
				EDropCatchRoleAnimState.WalkLeft,
				EDropCatchRoleAnimState.WalkLeft
			},
			{
				EDropCatchRoleAnimState.WalkBowlRight,
				EDropCatchRoleAnimState.WalkRight
			},
			{
				EDropCatchRoleAnimState.WalkRight,
				EDropCatchRoleAnimState.WalkRight
			}
		};

		// Token: 0x0402253A RID: 140602
		private readonly Dictionary<EDropCatchRoleAnimState, EMorningSpecialAnimState> StateToMorningSpecialAnimName = new Dictionary<EDropCatchRoleAnimState, EMorningSpecialAnimState>
		{
			{
				EDropCatchRoleAnimState.IdleBowlLeft,
				EMorningSpecialAnimState.IdleNothingLeft
			},
			{
				EDropCatchRoleAnimState.IdleLeft,
				EMorningSpecialAnimState.IdleNothingLeft
			},
			{
				EDropCatchRoleAnimState.IdleBowlRight,
				EMorningSpecialAnimState.IdleNothingRight
			},
			{
				EDropCatchRoleAnimState.IdleRight,
				EMorningSpecialAnimState.IdleNothingRight
			},
			{
				EDropCatchRoleAnimState.WalkBowlLeft,
				EMorningSpecialAnimState.WalkNothingLeft
			},
			{
				EDropCatchRoleAnimState.WalkLeft,
				EMorningSpecialAnimState.WalkNothingLeft
			},
			{
				EDropCatchRoleAnimState.WalkBowlRight,
				EMorningSpecialAnimState.WalkNothingRight
			},
			{
				EDropCatchRoleAnimState.WalkRight,
				EMorningSpecialAnimState.WalkNothingRight
			}
		};

		// Token: 0x0402253B RID: 140603
		private readonly HashSet<EDropCatchRoleAnimState> BowlStates = new HashSet<EDropCatchRoleAnimState>
		{
			EDropCatchRoleAnimState.IdleBowlLeft,
			EDropCatchRoleAnimState.IdleBowlRight,
			EDropCatchRoleAnimState.WalkBowlLeft,
			EDropCatchRoleAnimState.WalkBowlRight
		};

		// Token: 0x0402253C RID: 140604
		private readonly HashSet<EDropCatchRoleAnimState> LeftStates = new HashSet<EDropCatchRoleAnimState>
		{
			EDropCatchRoleAnimState.IdleLeft,
			EDropCatchRoleAnimState.IdleBowlLeft,
			EDropCatchRoleAnimState.WalkLeft,
			EDropCatchRoleAnimState.WalkBowlLeft
		};

		// Token: 0x0402253D RID: 140605
		[Nullable(2)]
		private DropCatchGameplayRoleFxView FxView;

		// Token: 0x0402253E RID: 140606
		[Nullable(2)]
		public Action<double> PosChangeCallback;

		// Token: 0x0402253F RID: 140607
		private float BowlSpineScaleX;

		// Token: 0x04022540 RID: 140608
		private readonly Vector Scale = Vector.Create(0.0, 0.32199999690055847, 0.32199999690055847);

		// Token: 0x04022541 RID: 140609
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
