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
	// Token: 0x02005761 RID: 22369
	public class KurotatoLevelUnlockRolePanel : UiPanelBase
	{
		// Token: 0x06038D52 RID: 232786 RVA: 0x00D803B8 File Offset: 0x00D7E5B8
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

		// Token: 0x06038D53 RID: 232787 RVA: 0x00D804C4 File Offset: 0x00D7E6C4
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

		// Token: 0x06038D54 RID: 232788 RVA: 0x00D8058A File Offset: 0x00D7E78A
		private void OnBtnRoleClick()
		{
			this.OnRoleBtnClick(this.RoleId);
		}

		// Token: 0x0401DCF6 RID: 122102
		private int RoleId;

		// Token: 0x0401DCF7 RID: 122103
		[Nullable(1)]
		public Action<int> OnRoleBtnClick = delegate(int _)
		{
		};

		// Token: 0x0200B95B RID: 47451
		private enum EComponent
		{
			// Token: 0x040380D6 RID: 229590
			BtnRole,
			// Token: 0x040380D7 RID: 229591
			TextureRole,
			// Token: 0x040380D8 RID: 229592
			TextName,
			// Token: 0x040380D9 RID: 229593
			SpriteFinish,
			// Token: 0x040380DA RID: 229594
			TextureLock
		}
	}
}
