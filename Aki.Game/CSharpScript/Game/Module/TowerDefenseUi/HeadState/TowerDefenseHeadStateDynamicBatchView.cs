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
	// Token: 0x02004AFE RID: 19198
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseHeadStateDynamicBatchView : UiPanelBase
	{
		// Token: 0x06031B7A RID: 203642 RVA: 0x00B8BAEC File Offset: 0x00B89CEC
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

		// Token: 0x06031B7B RID: 203643 RVA: 0x00B8BB58 File Offset: 0x00B89D58
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseHeadStateDynamicBatchView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseHeadStateDynamicBatchView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031B7C RID: 203644 RVA: 0x00B8BB9C File Offset: 0x00B89D9C
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

		// Token: 0x06031B7D RID: 203645 RVA: 0x00B8BC00 File Offset: 0x00B89E00
		protected override void OnBeforeDestroy()
		{
			this.IsEnable = false;
			if (this.HeadStateView != null)
			{
				this.HeadStateView.Destroy(null);
				this.HeadStateView = null;
			}
		}

		// Token: 0x06031B7E RID: 203646 RVA: 0x00B8BC24 File Offset: 0x00B89E24
		public bool GetIsEnable()
		{
			return this.IsEnable;
		}

		// Token: 0x06031B7F RID: 203647 RVA: 0x00B8BC2C File Offset: 0x00B89E2C
		public void RefreshRotation(Rotator cameraRotation)
		{
			this.ActorRotation.Yaw = cameraRotation.Yaw + 90f;
			this.ActorRotation.Roll = cameraRotation.Pitch - 90f;
			this.ActorRotation.Pitch = 0f;
			FHitResult fhitResult = null;
			this.HpParentItem.K2_SetWorldRotation(this.ActorRotation.ToUeRotator(), false, ref fhitResult, true);
		}

		// Token: 0x06031B80 RID: 203648 RVA: 0x00B8BC93 File Offset: 0x00B89E93
		public void AddToDynamicBatchMesh(TowerDefenseHeadStateData headStateData)
		{
			this.HeadStateView.Refresh(headStateData, this.HpItemWorldPos);
			this.DynamicBatch.AddContainerNode(this.HpItem, true);
		}

		// Token: 0x06031B81 RID: 203649 RVA: 0x00B8BCB9 File Offset: 0x00B89EB9
		public void ClearDynamicBatchMesh()
		{
			this.DynamicBatch.ClearAllGeometries();
		}

		// Token: 0x0401A8C7 RID: 108743
		private bool IsEnable;

		// Token: 0x0401A8C8 RID: 108744
		[Nullable(2)]
		private TowerDefenseHeadStateView HeadStateView;

		// Token: 0x0401A8C9 RID: 108745
		[Nullable(2)]
		private UUIDynamicBatchMesh DynamicBatch;

		// Token: 0x0401A8CA RID: 108746
		[Nullable(2)]
		private UUIItem HpParentItem;

		// Token: 0x0401A8CB RID: 108747
		[Nullable(2)]
		private UUIItem HpItem;

		// Token: 0x0401A8CC RID: 108748
		private readonly Rotator ActorRotation = Rotator.Create();

		// Token: 0x0401A8CD RID: 108749
		private readonly Vector HpItemWorldPos = Vector.Create();

		// Token: 0x0200AC8B RID: 44171
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040346F6 RID: 214774
			UIDynamicBatchMesh,
			// Token: 0x040346F7 RID: 214775
			HpContainerItem
		}
	}
}
