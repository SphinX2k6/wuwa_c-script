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
	// Token: 0x02003D13 RID: 15635
	public class RoleDevelopProjectWeaponPanel : RoleDevelopProjectBasePanel
	{
		// Token: 0x0602804E RID: 163918 RVA: 0x00B34934 File Offset: 0x00B32B34
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

		// Token: 0x0602804F RID: 163919 RVA: 0x00B349A0 File Offset: 0x00B32BA0
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectWeaponPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectWeaponPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028050 RID: 163920 RVA: 0x00B349E3 File Offset: 0x00B32BE3
		public override void OnCommonItemCountAnyChange(int configId)
		{
			this.WeaponDevItem.OnCommonItemCountAnyChange(configId);
		}

		// Token: 0x06028051 RID: 163921 RVA: 0x00B349F1 File Offset: 0x00B32BF1
		protected override void OnRefreshView(bool forceRefresh)
		{
			this.InitSelectWeaponType(forceRefresh);
			this.RefreshWeaponView();
		}

		// Token: 0x06028052 RID: 163922 RVA: 0x00B34A00 File Offset: 0x00B32C00
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

		// Token: 0x06028053 RID: 163923 RVA: 0x00B34A58 File Offset: 0x00B32C58
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

		// Token: 0x06028054 RID: 163924 RVA: 0x00B34AC5 File Offset: 0x00B32CC5
		private void OnClickSwitchButton()
		{
			this.CurSelectWeaponType = new ERoleDevelopWeaponType?((this.CurSelectWeaponType.GetValueOrDefault() == ERoleDevelopWeaponType.Develop) ? ERoleDevelopWeaponType.Recommend : ERoleDevelopWeaponType.Develop);
			this.RefreshWeaponView();
		}

		// Token: 0x04015C92 RID: 89234
		private ERoleDevelopWeaponType? CurSelectWeaponType;

		// Token: 0x04015C93 RID: 89235
		[Nullable(1)]
		private RoleDevelopProjectWeaponDevItem WeaponDevItem;

		// Token: 0x04015C94 RID: 89236
		[Nullable(1)]
		private RoleDevelopProjectWeaponRecommendItem WeaponRecommendItem;

		// Token: 0x020098EC RID: 39148
		private enum EComponentType
		{
			// Token: 0x0402FB25 RID: 195365
			PlanWeaponDevelop,
			// Token: 0x0402FB26 RID: 195366
			PlanWeaponRecommend
		}
	}
}
