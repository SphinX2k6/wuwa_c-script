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
	// Token: 0x02004D12 RID: 19730
	[NullableContext(2)]
	[Nullable(0)]
	public class GrapplingHookPoint : UiPanelBase
	{
		// Token: 0x0603175E RID: 202590 RVA: 0x00DD4274 File Offset: 0x00DD2474
		[NullableContext(1)]
		public GrapplingHookPoint(Vector targetLocation, UUIItem parentItem)
		{
			this.PlayerController = Global.CharacterController;
			this.TargetLocation.X = targetLocation.X;
			this.TargetLocation.Y = targetLocation.Y;
			this.TargetLocation.Z = targetLocation.Z;
			base.CreateThenShowByResourceIdAsync("UiItem_Gousuo", parentItem, true).Forget();
		}

		// Token: 0x0603175F RID: 202591 RVA: 0x00DD42EC File Offset: 0x00DD24EC
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

		// Token: 0x06031760 RID: 202592 RVA: 0x00DD43C0 File Offset: 0x00DD25C0
		protected override UniTask OnBeforeStartAsync()
		{
			GrapplingHookPoint.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GrapplingHookPoint.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031761 RID: 202593 RVA: 0x00DD4404 File Offset: 0x00DD2604
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

		// Token: 0x06031762 RID: 202594 RVA: 0x00DD44C2 File Offset: 0x00DD26C2
		private void OnMotorcycleStateChanged(bool bDriving)
		{
			this.RefreshKeyAction();
		}

		// Token: 0x06031763 RID: 202595 RVA: 0x00DD44CA File Offset: 0x00DD26CA
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

		// Token: 0x06031764 RID: 202596 RVA: 0x00DD4507 File Offset: 0x00DD2707
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

		// Token: 0x06031765 RID: 202597 RVA: 0x00DD4525 File Offset: 0x00DD2725
		[NullableContext(1)]
		private void OnPlotSequenceEnd(PlotResultInfo plotResult)
		{
			this.EnableMarker();
		}

		// Token: 0x06031766 RID: 202598 RVA: 0x00DD452D File Offset: 0x00DD272D
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

		// Token: 0x06031767 RID: 202599 RVA: 0x00DD4555 File Offset: 0x00DD2755
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

		// Token: 0x06031768 RID: 202600 RVA: 0x00DD457D File Offset: 0x00DD277D
		public void UpdateHookPointLocation(in FVectorDouble location)
		{
			this.TargetLocation = location;
		}

		// Token: 0x06031769 RID: 202601 RVA: 0x00DD458C File Offset: 0x00DD278C
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

		// Token: 0x0603176A RID: 202602 RVA: 0x00DD467C File Offset: 0x00DD287C
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

		// Token: 0x0603176B RID: 202603 RVA: 0x00DD46B9 File Offset: 0x00DD28B9
		private void SetPosition(in FVector2D position)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(position);
		}

		// Token: 0x0603176C RID: 202604 RVA: 0x00DD46D4 File Offset: 0x00DD28D4
		private FVector2D? ProjectWorldToScreen(in FVectorDouble worldLocation)
		{
			FVector2D fvector2D = new FVector2D();
			if (!UGameplayStatics.D_ProjectWorldToScreen(this.PlayerController, worldLocation, ref fvector2D, false))
			{
				return null;
			}
			return new FVector2D?(UiLayer.Instance.UiRootItem.GetCanvasScaler().ConvertPositionFromViewportToLGUICanvas(fvector2D));
		}

		// Token: 0x0401A318 RID: 107288
		private FVectorDouble TargetLocation = new FVectorDouble();

		// Token: 0x0401A319 RID: 107289
		private readonly APlayerController PlayerController;

		// Token: 0x0401A31A RID: 107290
		private bool MakerEnabled = true;

		// Token: 0x0401A31B RID: 107291
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A31C RID: 107292
		private CombineKeyItem KeyItem;

		// Token: 0x0200A9CC RID: 43468
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403476F RID: 214895
			CommonItem,
			// Token: 0x04034770 RID: 214896
			InterruptItem,
			// Token: 0x04034771 RID: 214897
			SkillIcon,
			// Token: 0x04034772 RID: 214898
			EffectOnce,
			// Token: 0x04034773 RID: 214899
			KeyItem
		}
	}
}
