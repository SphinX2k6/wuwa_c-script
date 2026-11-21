using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x0200565B RID: 22107
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayRoleView : UiPanelBase
	{
		// Token: 0x0603696D RID: 223597 RVA: 0x00F3BB48 File Offset: 0x00F39D48
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

		// Token: 0x0603696E RID: 223598 RVA: 0x00F3BC10 File Offset: 0x00F39E10
		protected override UniTask OnBeforeStartAsync()
		{
			DropCatchGameplayRoleView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DropCatchGameplayRoleView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603696F RID: 223599 RVA: 0x00F3BC53 File Offset: 0x00F39E53
		protected override void OnStart()
		{
		}

		// Token: 0x06036970 RID: 223600 RVA: 0x00F3BC55 File Offset: 0x00F39E55
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

		// Token: 0x06036971 RID: 223601 RVA: 0x00F3BC80 File Offset: 0x00F39E80
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

		// Token: 0x06036972 RID: 223602 RVA: 0x00F3BCAC File Offset: 0x00F39EAC
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

		// Token: 0x06036973 RID: 223603 RVA: 0x00F3BD4F File Offset: 0x00F39F4F
		[NullableContext(2)]
		public DropCatchGameplayRoleFxView GetFxView()
		{
			return this.FxView;
		}

		// Token: 0x06036974 RID: 223604 RVA: 0x00F3BD58 File Offset: 0x00F39F58
		public UniTask CreateFxView()
		{
			DropCatchGameplayRoleView.<CreateFxView>d__17 <CreateFxView>d__;
			<CreateFxView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFxView>d__.<>4__this = this;
			<CreateFxView>d__.<>1__state = -1;
			<CreateFxView>d__.<>t__builder.Start<DropCatchGameplayRoleView.<CreateFxView>d__17>(ref <CreateFxView>d__);
			return <CreateFxView>d__.<>t__builder.Task;
		}

		// Token: 0x06036975 RID: 223605 RVA: 0x00F3BD9C File Offset: 0x00F39F9C
		public UniTask RefreshSpine()
		{
			DropCatchGameplayRoleView.<RefreshSpine>d__18 <RefreshSpine>d__;
			<RefreshSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSpine>d__.<>4__this = this;
			<RefreshSpine>d__.<>1__state = -1;
			<RefreshSpine>d__.<>t__builder.Start<DropCatchGameplayRoleView.<RefreshSpine>d__18>(ref <RefreshSpine>d__);
			return <RefreshSpine>d__.<>t__builder.Task;
		}

		// Token: 0x06036976 RID: 223606 RVA: 0x00F3BDE0 File Offset: 0x00F39FE0
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

		// Token: 0x06036977 RID: 223607 RVA: 0x00F3BE38 File Offset: 0x00F3A038
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

		// Token: 0x06036978 RID: 223608 RVA: 0x00F3BEF8 File Offset: 0x00F3A0F8
		private void ClearTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			}
			this.TimerHandle = null;
		}

		// Token: 0x06036979 RID: 223609 RVA: 0x00F3BF24 File Offset: 0x00F3A124
		protected override void OnBeforeHide()
		{
			DropCatchGameplayRoleFxView fxView = this.FxView;
			if (fxView == null)
			{
				return;
			}
			fxView.ResetView();
		}

		// Token: 0x0603697A RID: 223610 RVA: 0x00F3BF36 File Offset: 0x00F3A136
		protected override void OnBeforeDestroy()
		{
			this.ClearTimer();
		}

		// Token: 0x0603697B RID: 223611 RVA: 0x00F3BF40 File Offset: 0x00F3A140
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

		// Token: 0x0401CD91 RID: 118161
		private readonly int ROLE_FX_OFFSET = 12;

		// Token: 0x0401CD92 RID: 118162
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

		// Token: 0x0401CD93 RID: 118163
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

		// Token: 0x0401CD94 RID: 118164
		private readonly HashSet<EDropCatchRoleAnimState> BowlStates = new HashSet<EDropCatchRoleAnimState>
		{
			EDropCatchRoleAnimState.IdleBowlLeft,
			EDropCatchRoleAnimState.IdleBowlRight,
			EDropCatchRoleAnimState.WalkBowlLeft,
			EDropCatchRoleAnimState.WalkBowlRight
		};

		// Token: 0x0401CD95 RID: 118165
		private readonly HashSet<EDropCatchRoleAnimState> LeftStates = new HashSet<EDropCatchRoleAnimState>
		{
			EDropCatchRoleAnimState.IdleLeft,
			EDropCatchRoleAnimState.IdleBowlLeft,
			EDropCatchRoleAnimState.WalkLeft,
			EDropCatchRoleAnimState.WalkBowlLeft
		};

		// Token: 0x0401CD96 RID: 118166
		[Nullable(2)]
		private DropCatchGameplayRoleFxView FxView;

		// Token: 0x0401CD97 RID: 118167
		[Nullable(2)]
		public Action<double> PosChangeCallback;

		// Token: 0x0401CD98 RID: 118168
		private float BowlSpineScaleX;

		// Token: 0x0401CD99 RID: 118169
		private readonly Vector Scale = Vector.Create(0.0, 0.32199999690055847, 0.32199999690055847);

		// Token: 0x0401CD9A RID: 118170
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
