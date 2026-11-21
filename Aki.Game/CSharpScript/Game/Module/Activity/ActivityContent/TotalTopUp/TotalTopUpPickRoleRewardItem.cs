using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F88 RID: 20360
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPickRoleRewardItem : UiPanelBase
	{
		// Token: 0x0603310D RID: 209165 RVA: 0x00E50056 File Offset: 0x00E4E256
		public TotalTopUpPickRoleRewardItem(ITotalTopUpPickRoleRewardItemData data)
		{
			this.Data = data;
		}

		// Token: 0x0603310E RID: 209166 RVA: 0x00E50068 File Offset: 0x00E4E268
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnSelectItem))
			};
		}

		// Token: 0x0603310F RID: 209167 RVA: 0x00E50169 File Offset: 0x00E4E369
		protected override void OnStart()
		{
			this.RefreshView();
			this.ExtendToggle = base.GetExtendToggle(0);
		}

		// Token: 0x06033110 RID: 209168 RVA: 0x00E50180 File Offset: 0x00E4E380
		private void RefreshView()
		{
			if (this.Data == null)
			{
				return;
			}
			bool flag = !this.Data.CanClaim;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(flag);
			}
			UUIItem item4 = base.GetItem(5);
			if (item4 != null)
			{
				item4.SetUIActive(flag);
			}
			UUITexture texture = base.GetTexture(3);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			bool flag2 = this.Data.RoleId > 0;
			if (flag2)
			{
				string formationRoleCard = RoleConfig.Instance.GetRoleConfig(this.Data.RoleId).Value.FormationRoleCard;
				base.SetTextureByPath(formationRoleCard, texture, null, null);
				UUIItem uuiitem2 = texture;
				bool bUseChangeColor2 = flag;
				fcolor = new FColor?(texture.changeColor);
				uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			}
			else
			{
				UUIText text = base.GetText(7);
				if (text != null)
				{
					text.SetText("x" + this.Data.ItemCount.ToString(), true);
				}
			}
			UUITexture texture2 = base.GetTexture(8);
			if (texture2 != null)
			{
				texture2.SetUIActive(!flag2);
			}
			UUITexture texture3 = base.GetTexture(3);
			if (texture3 != null)
			{
				texture3.SetUIActive(flag2);
			}
			UUIText text2 = base.GetText(7);
			if (text2 != null)
			{
				text2.SetUIActive(!flag2);
			}
			UUIItem item5 = base.GetItem(5);
			if (item5 == null)
			{
				return;
			}
			item5.SetUIActive(!this.Data.CanClaim);
		}

		// Token: 0x06033111 RID: 209169 RVA: 0x00E50309 File Offset: 0x00E4E509
		public void SetSelectCallback(Action<ITotalTopUpPickRoleRewardItemData> callback)
		{
			this.OnSelectCallback = callback;
		}

		// Token: 0x06033112 RID: 209170 RVA: 0x00E50314 File Offset: 0x00E4E514
		public void SetSelected(bool selected)
		{
			EToggleState state = selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = this.ExtendToggle;
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, false, false, false);
		}

		// Token: 0x06033113 RID: 209171 RVA: 0x00E5033E File Offset: 0x00E4E53E
		public void SelectItem()
		{
			this.OnSelectItem(EToggleState.ETT_Checked);
		}

		// Token: 0x06033114 RID: 209172 RVA: 0x00E50347 File Offset: 0x00E4E547
		private void OnSelectItem(EToggleState state)
		{
			if (this.OnSelectCallback != null)
			{
				this.OnSelectCallback(this.Data);
			}
		}

		// Token: 0x0401B1BA RID: 111034
		private readonly ITotalTopUpPickRoleRewardItemData Data;

		// Token: 0x0401B1BB RID: 111035
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ITotalTopUpPickRoleRewardItemData> OnSelectCallback;

		// Token: 0x0401B1BC RID: 111036
		[Nullable(2)]
		private UUIExtendToggle ExtendToggle;

		// Token: 0x0200AC8B RID: 44171
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x040355E9 RID: 218601
			public const int RoleItem = 0;

			// Token: 0x040355EA RID: 218602
			public const int RoleBg = 1;

			// Token: 0x040355EB RID: 218603
			public const int RoleLockBg = 2;

			// Token: 0x040355EC RID: 218604
			public const int RoleTex = 3;

			// Token: 0x040355ED RID: 218605
			public const int NormalItem = 4;

			// Token: 0x040355EE RID: 218606
			public const int LockItem = 5;

			// Token: 0x040355EF RID: 218607
			public const int RedDotItem = 6;

			// Token: 0x040355F0 RID: 218608
			public const int TextCount = 7;

			// Token: 0x040355F1 RID: 218609
			public const int TextureProps = 8;
		}
	}
}
