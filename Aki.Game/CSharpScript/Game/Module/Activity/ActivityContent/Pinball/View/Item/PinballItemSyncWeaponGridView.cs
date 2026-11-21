using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052CA RID: 21194
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemSyncWeaponGridView : PinballItemView, ISyncGridProxy<IPinballItemSyncWeaponGridViewData>, ISyncGridProxy
	{
		// Token: 0x1700668A RID: 26250
		// (get) Token: 0x06034C38 RID: 216120 RVA: 0x00EC0D31 File Offset: 0x00EBEF31
		// (set) Token: 0x06034C39 RID: 216121 RVA: 0x00EC0D39 File Offset: 0x00EBEF39
		public int GridIndex { get; set; }

		// Token: 0x06034C3A RID: 216122 RVA: 0x00EC0D42 File Offset: 0x00EBEF42
		protected override void OnStart()
		{
			base.OnStart();
			base.GetItemToggle().bLockStateOnSelect = true;
		}

		// Token: 0x06034C3B RID: 216123 RVA: 0x00EC0D58 File Offset: 0x00EBEF58
		public void Refresh(IPinballItemSyncWeaponGridViewData data)
		{
			PinballWeaponData weaponData = data.WeaponData;
			this.SyncGridData = data;
			this.RefreshToggleState(true);
			PinballItemDataWeapon data2 = new PinballItemDataWeapon
			{
				Type = EPinballItemType.Weapon,
				Id = weaponData.Id,
				IncId = weaponData.IncId,
				IsUnavailable = new bool?(!data.CanEquip),
				RoleId = new int?(weaponData.RoleId),
				IsLocked = new bool?(weaponData.GetIsLock()),
				IsRecommendedWeapon = new bool?(data.CanEquip && this.CheckIsRecommendedWeapon(weaponData, data.RoleId))
			};
			this.ApplyWithTask(data2);
		}

		// Token: 0x06034C3C RID: 216124 RVA: 0x00EC0DFF File Offset: 0x00EBEFFF
		void ISyncGridProxy.Refresh(object data)
		{
			this.Refresh((IPinballItemSyncWeaponGridViewData)data);
		}

		// Token: 0x06034C3D RID: 216125 RVA: 0x00EC0E0D File Offset: 0x00EBF00D
		void ISyncGridProxy.CreateByActor(AActor actor)
		{
			base.CreateByActor(actor, null);
		}

		// Token: 0x06034C3E RID: 216126 RVA: 0x00EC0E17 File Offset: 0x00EBF017
		void ISyncGridProxy.CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x06034C3F RID: 216127 RVA: 0x00EC0E24 File Offset: 0x00EBF024
		private bool CheckIsRecommendedWeapon(PinballWeaponData weaponData, int roleId)
		{
			if (weaponData.RoleId != 0)
			{
				return false;
			}
			int roleWeaponMaxQuality = PinballModel.Instance.ActivityData.GetRoleWeaponMaxQuality(roleId);
			return weaponData.Quality == roleWeaponMaxQuality;
		}

		// Token: 0x06034C40 RID: 216128 RVA: 0x00EC0E58 File Offset: 0x00EBF058
		private void ApplyWithTask(IPinballItemDataWeapon data)
		{
			PinballItemSyncWeaponGridView.<>c__DisplayClass11_0 CS$<>8__locals1 = new PinballItemSyncWeaponGridView.<>c__DisplayClass11_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			UiAsyncTask task = new UiAsyncTask("PinballItemSyncWeaponGridView.Apply", delegate()
			{
				PinballItemSyncWeaponGridView.<>c__DisplayClass11_0.<<ApplyWithTask>b__0>d <<ApplyWithTask>b__0>d;
				<<ApplyWithTask>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<ApplyWithTask>b__0>d.<>4__this = CS$<>8__locals1;
				<<ApplyWithTask>b__0>d.<>1__state = -1;
				<<ApplyWithTask>b__0>d.<>t__builder.Start<PinballItemSyncWeaponGridView.<>c__DisplayClass11_0.<<ApplyWithTask>b__0>d>(ref <<ApplyWithTask>b__0>d);
				return <<ApplyWithTask>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x06034C41 RID: 216129 RVA: 0x00EC0EA0 File Offset: 0x00EBF0A0
		public void RefreshToggleState(bool bJumpToEnd)
		{
			if (this.SyncGridData == null)
			{
				return;
			}
			EToggleState state = this.SyncGridData.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle itemToggle = base.GetItemToggle();
			if (itemToggle == null)
			{
				return;
			}
			itemToggle.SetToggleState(state, false, false, bJumpToEnd);
		}

		// Token: 0x06034C42 RID: 216130 RVA: 0x00EC0EE0 File Offset: 0x00EBF0E0
		[NullableContext(2)]
		public UUIItem GetWeaponItemToggleRootUiItem()
		{
			UUIExtendToggle itemToggle = base.GetItemToggle();
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (itemToggle != null) ? new TWeakObjectPtr<UUIItem>?(itemToggle.RootUIComp) : null;
			if (tweakObjectPtr == null)
			{
				return null;
			}
			return tweakObjectPtr.GetValueOrDefault();
		}

		// Token: 0x06034C43 RID: 216131 RVA: 0x00EC0F24 File Offset: 0x00EBF124
		public void Clear()
		{
		}

		// Token: 0x0401BEDE RID: 114398
		[Nullable(2)]
		private IPinballItemSyncWeaponGridViewData SyncGridData;
	}
}
