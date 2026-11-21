using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005826 RID: 22566
	[NullableContext(2)]
	[Nullable(0)]
	public class CoopEntryRoleItem : UiPanelBase
	{
		// Token: 0x06037AC2 RID: 228034 RVA: 0x00F90325 File Offset: 0x00F8E525
		[NullableContext(1)]
		public CoopEntryRoleItem(CoopActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x06037AC3 RID: 228035 RVA: 0x00F90334 File Offset: 0x00F8E534
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn))
			};
		}

		// Token: 0x06037AC4 RID: 228036 RVA: 0x00F9044C File Offset: 0x00F8E64C
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointEnterCallBack.Bind(new Action(this.OnPointerEnter));
			button.OnPointExitCallBack.Bind(new Action(this.OnPointerExit));
		}

		// Token: 0x06037AC5 RID: 228037 RVA: 0x00F90482 File Offset: 0x00F8E682
		protected override void OnBeforeDestroy()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointEnterCallBack.Unbind();
			button.OnPointExitCallBack.Unbind();
		}

		// Token: 0x06037AC6 RID: 228038 RVA: 0x00F904A0 File Offset: 0x00F8E6A0
		[NullableContext(1)]
		public void Refresh(CoopRoleData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			CoopRole? coopRoleConfigByRoleId = CoopConfig.Instance.GetCoopRoleConfigByRoleId(data.RoleId);
			base.SetTextureByPath(data.IconPath, base.GetTexture(2), null, null);
			if (((coopRoleConfigByRoleId != null) ? coopRoleConfigByRoleId.GetValueOrDefault().RoleName : null) != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), coopRoleConfigByRoleId.Value.RoleName, Array.Empty<object>());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Coop_Role_Number", new <>z__ReadOnlyArray<object>(new object[]
			{
				data.CurRoleLevel,
				data.MaxCoopLevel
			}));
			base.GetItem(1).SetUIActive(data.IsUnLock);
			base.GetItem(5).SetUIActive(data.IsUnLock);
			base.GetItem(4).SetUIActive(!data.IsUnLock);
			base.GetItem(3).SetUIActive(data.IsMaxLevel);
			bool flag = this.ActivityData.IsRoleHasRedDot(data.RoleId);
			base.GetSprite(8).SetUIActive(data.IsMaxLevel && !flag);
			base.GetItem(9).SetUIActive(flag);
		}

		// Token: 0x06037AC7 RID: 228039 RVA: 0x00F905E7 File Offset: 0x00F8E7E7
		private void OnClickBtn()
		{
			Action<CoopRoleData> selectCallback = this.SelectCallback;
			if (selectCallback == null)
			{
				return;
			}
			selectCallback(this.Data);
		}

		// Token: 0x06037AC8 RID: 228040 RVA: 0x00F905FF File Offset: 0x00F8E7FF
		private void OnPointerEnter()
		{
			CoopRoleData data = this.Data;
			if (data == null || !data.IsUnLock)
			{
				return;
			}
			Action<CoopRoleData> pointerEnterCallback = this.PointerEnterCallback;
			if (pointerEnterCallback == null)
			{
				return;
			}
			pointerEnterCallback(this.Data);
		}

		// Token: 0x06037AC9 RID: 228041 RVA: 0x00F9062F File Offset: 0x00F8E82F
		private void OnPointerExit()
		{
			Action pointerExitCallback = this.PointerExitCallback;
			if (pointerExitCallback == null)
			{
				return;
			}
			pointerExitCallback();
		}

		// Token: 0x0401D5DD RID: 120285
		private CoopRoleData Data;

		// Token: 0x0401D5DE RID: 120286
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<CoopRoleData> SelectCallback;

		// Token: 0x0401D5DF RID: 120287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<CoopRoleData> PointerEnterCallback;

		// Token: 0x0401D5E0 RID: 120288
		public Action PointerExitCallback;

		// Token: 0x0401D5E1 RID: 120289
		private readonly CoopActivityData ActivityData;
	}
}
