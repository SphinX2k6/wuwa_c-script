using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066ED RID: 26349
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropCatchRoleItem : GridProxyAbstract<IDropCatchRoleItemData>
	{
		// Token: 0x06041D6B RID: 269675 RVA: 0x00FF7528 File Offset: 0x00FF5728
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

		// Token: 0x06041D6C RID: 269676 RVA: 0x00FF7600 File Offset: 0x00FF5800
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

		// Token: 0x06041D6D RID: 269677 RVA: 0x00FF77A3 File Offset: 0x00FF59A3
		public void SetClickCallback(Action<int, int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06041D6E RID: 269678 RVA: 0x00FF77AC File Offset: 0x00FF59AC
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleSelect(true);
		}

		// Token: 0x06041D6F RID: 269679 RVA: 0x00FF77B5 File Offset: 0x00FF59B5
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false);
		}

		// Token: 0x06041D70 RID: 269680 RVA: 0x00FF77C0 File Offset: 0x00FF59C0
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

		// Token: 0x06041D71 RID: 269681 RVA: 0x00FF7825 File Offset: 0x00FF5A25
		public void SetToggleSelect(bool select)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x040224BD RID: 140477
		private int CfgId;

		// Token: 0x040224BE RID: 140478
		private int BookCfgId;

		// Token: 0x040224BF RID: 140479
		private bool IsUnlock;

		// Token: 0x040224C0 RID: 140480
		private Action<int, int> ClickCallback = delegate(int configId, int index)
		{
		};

		// Token: 0x040224C1 RID: 140481
		private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/Num/Roman/RomanB/SP_RomanA0{0}.SP_RomanA0{1}";
	}
}
