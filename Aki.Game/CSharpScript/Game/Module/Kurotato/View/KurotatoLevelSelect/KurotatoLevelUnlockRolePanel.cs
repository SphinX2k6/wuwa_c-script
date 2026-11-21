using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x02004738 RID: 18232
	public class KurotatoLevelUnlockRolePanel : UiPanelBase
	{
		// Token: 0x0602DC62 RID: 187490 RVA: 0x00CCEE60 File Offset: 0x00CCD060
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnRoleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DC63 RID: 187491 RVA: 0x00CCEF6C File Offset: 0x00CCD16C
		public void Refresh(int roleId)
		{
			this.RoleId = roleId;
			KurotatoRoleData kurotatoRoleData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoRoleData(roleId);
			RoleInfo value = RoleConfig.Instance.GetRoleConfig(kurotatoRoleData.RealRoleId).Value;
			base.SetTextureByPath(SkinConfig.Instance.GetRoleSkinConfig(kurotatoRoleData.RealRoleSkinId).Value.RoleHeadIconLarge, base.GetTexture(1), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Name, Array.Empty<object>());
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(kurotatoRoleData.IsUnLock);
			}
			UUITexture texture = base.GetTexture(4);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(!kurotatoRoleData.IsUnLock);
		}

		// Token: 0x0602DC64 RID: 187492 RVA: 0x00CCF032 File Offset: 0x00CCD232
		private void OnBtnRoleClick()
		{
			this.OnRoleBtnClick(this.RoleId);
		}

		// Token: 0x0401878C RID: 100236
		private int RoleId;

		// Token: 0x0401878D RID: 100237
		[Nullable(1)]
		public Action<int> OnRoleBtnClick = delegate(int _)
		{
		};

		// Token: 0x0200A377 RID: 41847
		private enum EComponent
		{
			// Token: 0x04032AD8 RID: 207576
			BtnRole,
			// Token: 0x04032AD9 RID: 207577
			TextureRole,
			// Token: 0x04032ADA RID: 207578
			TextName,
			// Token: 0x04032ADB RID: 207579
			SpriteFinish,
			// Token: 0x04032ADC RID: 207580
			TextureLock
		}
	}
}
