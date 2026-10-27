using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x0200634C RID: 25420
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemSyncWeaponGridView : PinballItemView, ISyncGridProxy<IPinballItemSyncWeaponGridViewData>, ISyncGridProxy
	{
		// Token: 0x17009328 RID: 37672
		// (get) Token: 0x0603FF77 RID: 262007 RVA: 0x00F79DD1 File Offset: 0x00F77FD1
		// (set) Token: 0x0603FF78 RID: 262008 RVA: 0x00F79DD9 File Offset: 0x00F77FD9
		public int GridIndex { get; set; }

		// Token: 0x0603FF79 RID: 262009 RVA: 0x00F79DE2 File Offset: 0x00F77FE2
		protected override void OnStart()
		{
			base.OnStart();
			base.GetItemToggle().bLockStateOnSelect = true;
		}

		// Token: 0x0603FF7A RID: 262010 RVA: 0x00F79DF8 File Offset: 0x00F77FF8
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

		// Token: 0x0603FF7B RID: 262011 RVA: 0x00F79E9F File Offset: 0x00F7809F
		void ISyncGridProxy.Refresh(object data)
		{
			this.Refresh((IPinballItemSyncWeaponGridViewData)data);
		}

		// Token: 0x0603FF7C RID: 262012 RVA: 0x00F79EAD File Offset: 0x00F780AD
		void ISyncGridProxy.CreateByActor(AActor actor)
		{
			base.CreateByActor(actor, null);
		}

		// Token: 0x0603FF7D RID: 262013 RVA: 0x00F79EB7 File Offset: 0x00F780B7
		void ISyncGridProxy.CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x0603FF7E RID: 262014 RVA: 0x00F79EC4 File Offset: 0x00F780C4
		private bool CheckIsRecommendedWeapon(PinballWeaponData weaponData, int roleId)
		{
			if (weaponData.RoleId != 0)
			{
				return false;
			}
			int roleWeaponMaxQuality = PinballModel.Instance.ActivityData.GetRoleWeaponMaxQuality(roleId);
			return weaponData.Quality == roleWeaponMaxQuality;
		}

		// Token: 0x0603FF7F RID: 262015 RVA: 0x00F79EF8 File Offset: 0x00F780F8
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

		// Token: 0x0603FF80 RID: 262016 RVA: 0x00F79F40 File Offset: 0x00F78140
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

		// Token: 0x0603FF81 RID: 262017 RVA: 0x00F79F80 File Offset: 0x00F78180
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

		// Token: 0x0603FF82 RID: 262018 RVA: 0x00F79FC4 File Offset: 0x00F781C4
		public void Clear()
		{
		}

		// Token: 0x040215AF RID: 136623
		[Nullable(2)]
		private IPinballItemSyncWeaponGridViewData SyncGridData;
	}
}
