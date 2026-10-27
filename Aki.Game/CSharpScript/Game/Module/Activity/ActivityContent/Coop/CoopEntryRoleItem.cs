using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068D6 RID: 26838
	[NullableContext(2)]
	[Nullable(0)]
	public class CoopEntryRoleItem : UiPanelBase
	{
		// Token: 0x06042F6A RID: 274282 RVA: 0x0104ECFD File Offset: 0x0104CEFD
		[NullableContext(1)]
		public CoopEntryRoleItem(CoopActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x06042F6B RID: 274283 RVA: 0x0104ED0C File Offset: 0x0104CF0C
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

		// Token: 0x06042F6C RID: 274284 RVA: 0x0104EE24 File Offset: 0x0104D024
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointEnterCallBack.Bind(new Action(this.OnPointerEnter));
			button.OnPointExitCallBack.Bind(new Action(this.OnPointerExit));
		}

		// Token: 0x06042F6D RID: 274285 RVA: 0x0104EE5A File Offset: 0x0104D05A
		protected override void OnBeforeDestroy()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointEnterCallBack.Unbind();
			button.OnPointExitCallBack.Unbind();
		}

		// Token: 0x06042F6E RID: 274286 RVA: 0x0104EE78 File Offset: 0x0104D078
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

		// Token: 0x06042F6F RID: 274287 RVA: 0x0104EFBF File Offset: 0x0104D1BF
		private void OnClickBtn()
		{
			Action<CoopRoleData> selectCallback = this.SelectCallback;
			if (selectCallback == null)
			{
				return;
			}
			selectCallback(this.Data);
		}

		// Token: 0x06042F70 RID: 274288 RVA: 0x0104EFD7 File Offset: 0x0104D1D7
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

		// Token: 0x06042F71 RID: 274289 RVA: 0x0104F007 File Offset: 0x0104D207
		private void OnPointerExit()
		{
			Action pointerExitCallback = this.PointerExitCallback;
			if (pointerExitCallback == null)
			{
				return;
			}
			pointerExitCallback();
		}

		// Token: 0x04022D81 RID: 142721
		private CoopRoleData Data;

		// Token: 0x04022D82 RID: 142722
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<CoopRoleData> SelectCallback;

		// Token: 0x04022D83 RID: 142723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<CoopRoleData> PointerEnterCallback;

		// Token: 0x04022D84 RID: 142724
		public Action PointerExitCallback;

		// Token: 0x04022D85 RID: 142725
		private readonly CoopActivityData ActivityData;
	}
}
