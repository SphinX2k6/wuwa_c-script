using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D30 RID: 23856
	[NullableContext(2)]
	[Nullable(0)]
	public class GrapplingHookPoint : UiPanelBase
	{
		// Token: 0x0603C805 RID: 247813 RVA: 0x00E83AD4 File Offset: 0x00E81CD4
		[NullableContext(1)]
		public GrapplingHookPoint(Vector targetLocation, UUIItem parentItem)
		{
			this.PlayerController = Global.CharacterController;
			this.TargetLocation.X = targetLocation.X;
			this.TargetLocation.Y = targetLocation.Y;
			this.TargetLocation.Z = targetLocation.Z;
			base.CreateThenShowByResourceIdAsync("UiItem_Gousuo", parentItem, true).Forget();
		}

		// Token: 0x0603C806 RID: 247814 RVA: 0x00E83B4C File Offset: 0x00E81D4C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
			}
		}

		// Token: 0x0603C807 RID: 247815 RVA: 0x00E83C20 File Offset: 0x00E81E20
		protected override UniTask OnBeforeStartAsync()
		{
			GrapplingHookPoint.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GrapplingHookPoint.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C808 RID: 247816 RVA: 0x00E83C64 File Offset: 0x00E81E64
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(false);
			base.GetItem(2).SetUIActive(false);
			if (this.MakerEnabled)
			{
				CombineKeyItem keyItem = this.KeyItem;
				if (keyItem != null)
				{
					keyItem.GetRootItem().SetUIActive(true);
				}
			}
			this.RefreshKeyAction();
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
			EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotSequencePlay));
			EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotSequenceEnd));
		}

		// Token: 0x0603C809 RID: 247817 RVA: 0x00E83D22 File Offset: 0x00E81F22
		private void OnMotorcycleStateChanged(bool bDriving)
		{
			this.RefreshKeyAction();
		}

		// Token: 0x0603C80A RID: 247818 RVA: 0x00E83D2A File Offset: 0x00E81F2A
		private void RefreshKeyAction()
		{
			if (this.KeyItem == null)
			{
				return;
			}
			if (BattleUiModel.Instance.MotorcycleData.IsDriving)
			{
				this.KeyItem.RefreshAction("载具探索工具");
				return;
			}
			this.KeyItem.RefreshAction("幻象1");
		}

		// Token: 0x0603C80B RID: 247819 RVA: 0x00E83D67 File Offset: 0x00E81F67
		private void OnPlotSequencePlay(PlotInfo plotInfo)
		{
			if (plotInfo == null)
			{
				return;
			}
			if (plotInfo.PlotLevel != EPlotLevel.LevelD && plotInfo.PlotLevel != EPlotLevel.LevelE)
			{
				this.DisableMarker();
			}
		}

		// Token: 0x0603C80C RID: 247820 RVA: 0x00E83D85 File Offset: 0x00E81F85
		[NullableContext(1)]
		private void OnPlotSequenceEnd(PlotResultInfo plotResult)
		{
			this.EnableMarker();
		}

		// Token: 0x0603C80D RID: 247821 RVA: 0x00E83D8D File Offset: 0x00E81F8D
		public void EnableMarker()
		{
			if (this.MakerEnabled)
			{
				return;
			}
			this.MakerEnabled = true;
			CombineKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.GetRootItem().SetUIActive(true);
		}

		// Token: 0x0603C80E RID: 247822 RVA: 0x00E83DB5 File Offset: 0x00E81FB5
		public void DisableMarker()
		{
			if (!this.MakerEnabled)
			{
				return;
			}
			this.MakerEnabled = false;
			CombineKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.GetRootItem().SetUIActive(false);
		}

		// Token: 0x0603C80F RID: 247823 RVA: 0x00E83DDD File Offset: 0x00E81FDD
		public void UpdateHookPointLocation(in FVectorDouble location)
		{
			this.TargetLocation = location;
		}

		// Token: 0x0603C810 RID: 247824 RVA: 0x00E83DEC File Offset: 0x00E81FEC
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
				this.LevelSequencePlayer = null;
			}
			if (this.KeyItem != null)
			{
				this.KeyItem.Destroy(null);
				this.KeyItem = null;
			}
			if (EventSystem.Instance.Has(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged)))
			{
				EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
			}
			if (EventSystem.Instance.Has(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotSequencePlay)))
			{
				EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotSequencePlay));
			}
			if (EventSystem.Instance.Has(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotSequenceEnd)))
			{
				EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotSequenceEnd));
			}
		}

		// Token: 0x0603C811 RID: 247825 RVA: 0x00E83EDC File Offset: 0x00E820DC
		public void AfterTick()
		{
			if (!this.MakerEnabled)
			{
				return;
			}
			FVector2D? fvector2D = this.ProjectWorldToScreen(this.TargetLocation);
			if (fvector2D == null)
			{
				return;
			}
			FVector2D value = fvector2D.Value;
			this.SetPosition(value);
		}

		// Token: 0x0603C812 RID: 247826 RVA: 0x00E83F19 File Offset: 0x00E82119
		private void SetPosition(in FVector2D position)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(position);
		}

		// Token: 0x0603C813 RID: 247827 RVA: 0x00E83F34 File Offset: 0x00E82134
		private FVector2D? ProjectWorldToScreen(in FVectorDouble worldLocation)
		{
			FVector2D fvector2D = new FVector2D();
			if (!UGameplayStatics.D_ProjectWorldToScreen(this.PlayerController, worldLocation, ref fvector2D, false))
			{
				return null;
			}
			return new FVector2D?(UiLayer.Instance.UiRootItem.GetCanvasScaler().ConvertPositionFromViewportToLGUICanvas(fvector2D));
		}

		// Token: 0x0401F85F RID: 129119
		private FVectorDouble TargetLocation = new FVectorDouble();

		// Token: 0x0401F860 RID: 129120
		private readonly APlayerController PlayerController;

		// Token: 0x0401F861 RID: 129121
		private bool MakerEnabled = true;

		// Token: 0x0401F862 RID: 129122
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F863 RID: 129123
		private CombineKeyItem KeyItem;

		// Token: 0x0200BFC6 RID: 49094
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039DAD RID: 236973
			CommonItem,
			// Token: 0x04039DAE RID: 236974
			InterruptItem,
			// Token: 0x04039DAF RID: 236975
			SkillIcon,
			// Token: 0x04039DB0 RID: 236976
			EffectOnce,
			// Token: 0x04039DB1 RID: 236977
			KeyItem
		}
	}
}
