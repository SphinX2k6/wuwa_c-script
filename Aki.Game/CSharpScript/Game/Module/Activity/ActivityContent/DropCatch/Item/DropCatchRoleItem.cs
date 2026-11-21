using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x0200563D RID: 22077
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropCatchRoleItem : GridProxyAbstract<IDropCatchRoleItemData>
	{
		// Token: 0x060368B7 RID: 223415 RVA: 0x00F3892C File Offset: 0x00F36B2C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClicked))
			};
		}

		// Token: 0x060368B8 RID: 223416 RVA: 0x00F38A04 File Offset: 0x00F36C04
		public override void Refresh(IDropCatchRoleItemData data, bool isSelected, int gridIndex)
		{
			if (data == null)
			{
				return;
			}
			this.CfgId = data.RoleCfgId;
			this.BookCfgId = data.BookCfgId;
			this.IsUnlock = data.IsUnlock;
			this.SetToggleSelect(isSelected);
			DropCatchRole? dropCatchRoleById = DropCatchConfig.Instance.GetDropCatchRoleById(this.CfgId);
			if (dropCatchRoleById != null)
			{
				UUITexture texture = base.GetTexture(2);
				if (texture != null)
				{
					texture.SetUIActive(this.IsUnlock);
				}
				UUITexture texture2 = base.GetTexture(3);
				if (texture2 != null)
				{
					texture2.SetUIActive(!this.IsUnlock);
				}
				if (this.IsUnlock)
				{
					base.SetTextureByPath(dropCatchRoleById.Value.RoleTexturePath, base.GetTexture(2), null, null);
					UUIText text = base.GetText(1);
					if (text != null)
					{
						text.ShowTextNew(dropCatchRoleById.Value.Name);
					}
				}
				else
				{
					base.SetTextureByPath(dropCatchRoleById.Value.SilhouettePath, base.GetTexture(6), null, null);
					UUIText text2 = base.GetText(1);
					if (text2 != null)
					{
						text2.ShowTextNew("CoinCatch_Character_UnlockName");
					}
				}
			}
			string text3 = (gridIndex + 1).ToString();
			this.SetSpriteByPath(StringUtils.Format("/Game/Aki/UI/UIResources/Common/Atlas/Num/Roman/RomanB/SP_RomanA0{0}.SP_RomanA0{1}", new string[]
			{
				text3,
				text3
			}), base.GetSprite(4), false, null, null);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(!this.IsUnlock);
			}
			bool uiactive = this.IsUnlock && DropCatchActivityController.Instance.IsNewRoleClicked(this.CfgId);
			UUIItem item2 = base.GetItem(5);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(uiactive);
		}

		// Token: 0x060368B9 RID: 223417 RVA: 0x00F38BA7 File Offset: 0x00F36DA7
		public void SetClickCallback(Action<int, int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x060368BA RID: 223418 RVA: 0x00F38BB0 File Offset: 0x00F36DB0
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleSelect(true);
		}

		// Token: 0x060368BB RID: 223419 RVA: 0x00F38BB9 File Offset: 0x00F36DB9
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false);
		}

		// Token: 0x060368BC RID: 223420 RVA: 0x00F38BC4 File Offset: 0x00F36DC4
		private void OnClicked(EToggleState state)
		{
			if (this.IsUnlock)
			{
				DropCatchActivityController.Instance.SetNewRoleClicked(this.CfgId);
				bool uiactive = DropCatchActivityController.Instance.IsNewRoleClicked(this.CfgId);
				UUIItem item = base.GetItem(5);
				if (item != null)
				{
					item.SetUIActive(uiactive);
				}
			}
			Action<int, int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.BookCfgId, base.GridIndex);
		}

		// Token: 0x060368BD RID: 223421 RVA: 0x00F38C29 File Offset: 0x00F36E29
		public void SetToggleSelect(bool select)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401CD16 RID: 118038
		private int CfgId;

		// Token: 0x0401CD17 RID: 118039
		private int BookCfgId;

		// Token: 0x0401CD18 RID: 118040
		private bool IsUnlock;

		// Token: 0x0401CD19 RID: 118041
		private Action<int, int> ClickCallback = delegate(int configId, int index)
		{
		};

		// Token: 0x0401CD1A RID: 118042
		private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/Num/Roman/RomanB/SP_RomanA0{0}.SP_RomanA0{1}";
	}
}
