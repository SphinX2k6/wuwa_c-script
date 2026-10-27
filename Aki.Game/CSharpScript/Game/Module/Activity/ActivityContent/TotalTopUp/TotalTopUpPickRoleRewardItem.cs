using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FA1 RID: 24481
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPickRoleRewardItem : UiPanelBase
	{
		// Token: 0x0603E173 RID: 254323 RVA: 0x00EFE39D File Offset: 0x00EFC59D
		public TotalTopUpPickRoleRewardItem(ITotalTopUpPickRoleRewardItemData data)
		{
			this.Data = data;
		}

		// Token: 0x0603E174 RID: 254324 RVA: 0x00EFE3AC File Offset: 0x00EFC5AC
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

		// Token: 0x0603E175 RID: 254325 RVA: 0x00EFE4AD File Offset: 0x00EFC6AD
		protected override void OnStart()
		{
			this.RefreshView();
			this.ExtendToggle = base.GetExtendToggle(0);
		}

		// Token: 0x0603E176 RID: 254326 RVA: 0x00EFE4C4 File Offset: 0x00EFC6C4
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

		// Token: 0x0603E177 RID: 254327 RVA: 0x00EFE64D File Offset: 0x00EFC84D
		public void SetSelectCallback(Action<ITotalTopUpPickRoleRewardItemData> callback)
		{
			this.OnSelectCallback = callback;
		}

		// Token: 0x0603E178 RID: 254328 RVA: 0x00EFE658 File Offset: 0x00EFC858
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

		// Token: 0x0603E179 RID: 254329 RVA: 0x00EFE682 File Offset: 0x00EFC882
		public void SelectItem()
		{
			this.OnSelectItem(EToggleState.ETT_Checked);
		}

		// Token: 0x0603E17A RID: 254330 RVA: 0x00EFE68B File Offset: 0x00EFC88B
		private void OnSelectItem(EToggleState state)
		{
			if (this.OnSelectCallback != null)
			{
				this.OnSelectCallback(this.Data);
			}
		}

		// Token: 0x040206E8 RID: 132840
		private readonly ITotalTopUpPickRoleRewardItemData Data;

		// Token: 0x040206E9 RID: 132841
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ITotalTopUpPickRoleRewardItemData> OnSelectCallback;

		// Token: 0x040206EA RID: 132842
		[Nullable(2)]
		private UUIExtendToggle ExtendToggle;

		// Token: 0x0200C280 RID: 49792
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x0403AC0D RID: 240653
			public const int RoleItem = 0;

			// Token: 0x0403AC0E RID: 240654
			public const int RoleBg = 1;

			// Token: 0x0403AC0F RID: 240655
			public const int RoleLockBg = 2;

			// Token: 0x0403AC10 RID: 240656
			public const int RoleTex = 3;

			// Token: 0x0403AC11 RID: 240657
			public const int NormalItem = 4;

			// Token: 0x0403AC12 RID: 240658
			public const int LockItem = 5;

			// Token: 0x0403AC13 RID: 240659
			public const int RedDotItem = 6;

			// Token: 0x0403AC14 RID: 240660
			public const int TextCount = 7;

			// Token: 0x0403AC15 RID: 240661
			public const int TextureProps = 8;
		}
	}
}
