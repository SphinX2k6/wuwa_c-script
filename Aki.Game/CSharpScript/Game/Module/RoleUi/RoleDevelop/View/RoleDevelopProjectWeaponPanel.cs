using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D4A RID: 19786
	public class RoleDevelopProjectWeaponPanel : RoleDevelopProjectBasePanel
	{
		// Token: 0x060331EB RID: 209387 RVA: 0x00BEB5CC File Offset: 0x00BE97CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060331EC RID: 209388 RVA: 0x00BEB638 File Offset: 0x00BE9838
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectWeaponPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectWeaponPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060331ED RID: 209389 RVA: 0x00BEB67B File Offset: 0x00BE987B
		public override void OnCommonItemCountAnyChange(int configId)
		{
			this.WeaponDevItem.OnCommonItemCountAnyChange(configId);
		}

		// Token: 0x060331EE RID: 209390 RVA: 0x00BEB689 File Offset: 0x00BE9889
		protected override void OnRefreshView(bool forceRefresh)
		{
			this.InitSelectWeaponType(forceRefresh);
			this.RefreshWeaponView();
		}

		// Token: 0x060331EF RID: 209391 RVA: 0x00BEB698 File Offset: 0x00BE9898
		private void InitSelectWeaponType(bool reset = false)
		{
			if (this.CurSelectWeaponType != null && !reset)
			{
				return;
			}
			WeaponInstance weaponInstance = this.Data.GetDevelopRoleData().GetWeaponInstance();
			if (weaponInstance != null && !WeaponModel.Instance.IsWeaponHighQuality(weaponInstance))
			{
				this.CurSelectWeaponType = new ERoleDevelopWeaponType?(ERoleDevelopWeaponType.Recommend);
				return;
			}
			this.CurSelectWeaponType = new ERoleDevelopWeaponType?(ERoleDevelopWeaponType.Develop);
		}

		// Token: 0x060331F0 RID: 209392 RVA: 0x00BEB6F0 File Offset: 0x00BE98F0
		private void RefreshWeaponView()
		{
			RoleDevelopData data = this.Data;
			this.WeaponDevItem.SetUiActive(this.CurSelectWeaponType.GetValueOrDefault() == ERoleDevelopWeaponType.Develop);
			this.WeaponRecommendItem.SetUiActive(this.CurSelectWeaponType.GetValueOrDefault() == ERoleDevelopWeaponType.Recommend);
			if (this.CurSelectWeaponType.GetValueOrDefault() == ERoleDevelopWeaponType.Develop)
			{
				this.WeaponDevItem.RefreshByData(data);
				return;
			}
			this.WeaponRecommendItem.RefreshByData(data);
		}

		// Token: 0x060331F1 RID: 209393 RVA: 0x00BEB75D File Offset: 0x00BE995D
		private void OnClickSwitchButton()
		{
			this.CurSelectWeaponType = new ERoleDevelopWeaponType?((this.CurSelectWeaponType.GetValueOrDefault() == ERoleDevelopWeaponType.Develop) ? ERoleDevelopWeaponType.Recommend : ERoleDevelopWeaponType.Develop);
			this.RefreshWeaponView();
		}

		// Token: 0x0401B2C0 RID: 111296
		private ERoleDevelopWeaponType? CurSelectWeaponType;

		// Token: 0x0401B2C1 RID: 111297
		[Nullable(1)]
		private RoleDevelopProjectWeaponDevItem WeaponDevItem;

		// Token: 0x0401B2C2 RID: 111298
		[Nullable(1)]
		private RoleDevelopProjectWeaponRecommendItem WeaponRecommendItem;

		// Token: 0x0200AEB8 RID: 44728
		public static class EComponentType
		{
			// Token: 0x040350FE RID: 217342
			public const int PlanWeaponDevelop = 0;

			// Token: 0x040350FF RID: 217343
			public const int PlanWeaponRecommend = 1;
		}
	}
}
