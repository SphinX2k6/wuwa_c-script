using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseUi.HeadState
{
	// Token: 0x02003AA6 RID: 15014
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseHeadStateDynamicBatchView : UiPanelBase
	{
		// Token: 0x0602690A RID: 157962 RVA: 0x00ACFB48 File Offset: 0x00ACDD48
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDynamicBatchMesh));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602690B RID: 157963 RVA: 0x00ACFBB4 File Offset: 0x00ACDDB4
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseHeadStateDynamicBatchView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseHeadStateDynamicBatchView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602690C RID: 157964 RVA: 0x00ACFBF8 File Offset: 0x00ACDDF8
		protected override void OnStart()
		{
			this.IsEnable = true;
			this.DynamicBatch = base.GetDynamicBatchMesh(0);
			this.HpParentItem = base.GetItem(1);
			this.HpItem = this.HeadStateView.GetRootItem();
			Vector hpItemWorldPos = this.HpItemWorldPos;
			FVector uiworldPosition = this.HpItem.GetUIWorldPosition();
			hpItemWorldPos.FromUeVector(uiworldPosition);
			this.HpParentItem.SetUIActive(true);
		}

		// Token: 0x0602690D RID: 157965 RVA: 0x00ACFC5C File Offset: 0x00ACDE5C
		protected override void OnBeforeDestroy()
		{
			this.IsEnable = false;
			if (this.HeadStateView != null)
			{
				this.HeadStateView.Destroy(null);
				this.HeadStateView = null;
			}
		}

		// Token: 0x0602690E RID: 157966 RVA: 0x00ACFC80 File Offset: 0x00ACDE80
		public bool GetIsEnable()
		{
			return this.IsEnable;
		}

		// Token: 0x0602690F RID: 157967 RVA: 0x00ACFC88 File Offset: 0x00ACDE88
		public void RefreshRotation(Rotator cameraRotation)
		{
			this.ActorRotation.Yaw = cameraRotation.Yaw + 90f;
			this.ActorRotation.Roll = cameraRotation.Pitch - 90f;
			this.ActorRotation.Pitch = 0f;
			FHitResult fhitResult = null;
			this.HpParentItem.K2_SetWorldRotation(this.ActorRotation.ToUeRotator(), false, ref fhitResult, true);
		}

		// Token: 0x06026910 RID: 157968 RVA: 0x00ACFCEF File Offset: 0x00ACDEEF
		public void AddToDynamicBatchMesh(TowerDefenseHeadStateData headStateData)
		{
			this.HeadStateView.Refresh(headStateData, this.HpItemWorldPos);
			this.DynamicBatch.AddContainerNode(this.HpItem, true);
		}

		// Token: 0x06026911 RID: 157969 RVA: 0x00ACFD15 File Offset: 0x00ACDF15
		public void ClearDynamicBatchMesh()
		{
			this.DynamicBatch.ClearAllGeometries();
		}

		// Token: 0x04015219 RID: 86553
		private bool IsEnable;

		// Token: 0x0401521A RID: 86554
		[Nullable(2)]
		private TowerDefenseHeadStateView HeadStateView;

		// Token: 0x0401521B RID: 86555
		[Nullable(2)]
		private UUIDynamicBatchMesh DynamicBatch;

		// Token: 0x0401521C RID: 86556
		[Nullable(2)]
		private UUIItem HpParentItem;

		// Token: 0x0401521D RID: 86557
		[Nullable(2)]
		private UUIItem HpItem;

		// Token: 0x0401521E RID: 86558
		private readonly Rotator ActorRotation = Rotator.Create();

		// Token: 0x0401521F RID: 86559
		private readonly Vector HpItemWorldPos = Vector.Create();

		// Token: 0x020096AB RID: 38571
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0402F0A7 RID: 192679
			UIDynamicBatchMesh,
			// Token: 0x0402F0A8 RID: 192680
			HpContainerItem
		}
	}
}
