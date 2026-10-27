using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200560D RID: 22029
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RewardItemToggle : GridProxyAbstract<MapRogueRewardItemData>
	{
		// Token: 0x06038100 RID: 229632 RVA: 0x00D46DBC File Offset: 0x00D44FBC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
			};
		}

		// Token: 0x06038101 RID: 229633 RVA: 0x00D46EA7 File Offset: 0x00D450A7
		protected override void OnStart()
		{
			this.Toggle = base.GetExtendToggle(0);
			this.Toggle.SetSelfInteractive(!this.IsAllSelect);
			this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x06038102 RID: 229634 RVA: 0x00D46EE6 File Offset: 0x00D450E6
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle != null)
			{
				toggle.CanExecuteChange.Unbind();
			}
			this.Toggle = null;
		}

		// Token: 0x06038103 RID: 229635 RVA: 0x00D46F08 File Offset: 0x00D45108
		public override void Refresh(MapRogueRewardItemData rewardData, bool isSelected, int gridIndex)
		{
			this.Data = rewardData;
			UUITexture texture = base.GetTexture(7);
			UUITexture texture2 = base.GetTexture(1);
			UUIText text = base.GetText(2);
			UUIText text2 = base.GetText(5);
			int value;
			if (rewardData.IsRole)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(rewardData.ConfigId, true);
				if (roleDataById == null)
				{
					return;
				}
				int roleSkinId = roleDataById.GetRoleSkinId();
				RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId);
				texture2.SetUIActive(false);
				base.SetTextureShowUntilLoaded(roleSkinConfig.Value.FormationRoleCard, texture, null);
				text.SetText(roleDataById.GetName(null), true);
				LguiUtil.Instance.SetLocalTextNew(text2, "RogueRes_AddRole_Desc", new <>z__ReadOnlySingleElementList<object>(roleDataById.GetName(null)));
				value = roleDataById.GetQualityConfig().Id;
			}
			else
			{
				ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(rewardData.ConfigId);
				if (itemConfigData == null)
				{
					return;
				}
				base.SetItemIcon(texture2, rewardData.ConfigId, null, null);
				texture2.SetUIActive(true);
				texture.SetUIActive(false);
				LguiUtil.Instance.SetLocalTextNew(text, itemConfigData.Name, Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(text2, itemConfigData.AttributesDescription, Array.Empty<object>());
				value = itemConfigData.QualityId;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "RogueRes_AccuracyNumShow", new <>z__ReadOnlySingleElementList<object>(rewardData.Count));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("T_RogueItemQualityBg");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureShowUntilLoaded(resourcePath, base.GetTexture(4), null);
			this.SetItemDone(rewardData.IsSelect);
		}

		// Token: 0x06038104 RID: 229636 RVA: 0x00D470D8 File Offset: 0x00D452D8
		public void SetToggleState(bool bSelectOn, bool bFireEvent = false)
		{
			EToggleState state = bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, bFireEvent, false, false);
		}

		// Token: 0x06038105 RID: 229637 RVA: 0x00D470FD File Offset: 0x00D452FD
		public void SetItemDone(bool bDone)
		{
			base.GetText(6).SetUIActive(!bDone);
			base.GetItem(3).SetUIActive(bDone);
		}

		// Token: 0x06038106 RID: 229638 RVA: 0x00D4711C File Offset: 0x00D4531C
		private bool CanExecuteChange()
		{
			if (this.OnCanExecuteChangeFunc != null)
			{
				Func<bool, MapRogueRewardItemData, bool> onCanExecuteChangeFunc = this.OnCanExecuteChangeFunc;
				UUIExtendToggle toggle = this.Toggle;
				return onCanExecuteChangeFunc(toggle != null && toggle.GetToggleState() == EToggleState.ETT_Checked, this.Data);
			}
			return true;
		}

		// Token: 0x06038107 RID: 229639 RVA: 0x00D4714E File Offset: 0x00D4534E
		private void OnToggleClick(EToggleState state)
		{
			Action<bool, MapRogueRewardItemData> onExtendToggleClicked = this.OnExtendToggleClicked;
			if (onExtendToggleClicked == null)
			{
				return;
			}
			onExtendToggleClicked(state == EToggleState.ETT_Checked, this.Data);
		}

		// Token: 0x06038108 RID: 229640 RVA: 0x00D4716A File Offset: 0x00D4536A
		public override object GetKey(MapRogueRewardItemData data, int displayIndex)
		{
			return this.Data.Index;
		}

		// Token: 0x0401D782 RID: 120706
		protected MapRogueRewardItemData Data;

		// Token: 0x0401D783 RID: 120707
		[Nullable(2)]
		protected UUIExtendToggle Toggle;

		// Token: 0x0401D784 RID: 120708
		public bool IsAllSelect;

		// Token: 0x0401D785 RID: 120709
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<bool, MapRogueRewardItemData> OnExtendToggleClicked;

		// Token: 0x0401D786 RID: 120710
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<bool, MapRogueRewardItemData, bool> OnCanExecuteChangeFunc;
	}
}
