using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E8C RID: 20108
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleRoleBuffItem : GridProxyAbstract<RogueResGainData>
	{
		// Token: 0x06033B70 RID: 211824 RVA: 0x00C1D07C File Offset: 0x00C1B27C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickExtendToggle)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnDetail))
			};
		}

		// Token: 0x06033B71 RID: 211825 RVA: 0x00C1D153 File Offset: 0x00C1B353
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.RogueBattleDescModeChange, new Action(this.RefreshDescText));
		}

		// Token: 0x06033B72 RID: 211826 RVA: 0x00C1D171 File Offset: 0x00C1B371
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RogueBattleDescModeChange, new Action(this.RefreshDescText));
		}

		// Token: 0x06033B73 RID: 211827 RVA: 0x00C1D18F File Offset: 0x00C1B38F
		private void OnClickExtendToggle(EToggleState state)
		{
			Action<int> onSelectCallback = this.OnSelectCallback;
			if (onSelectCallback == null)
			{
				return;
			}
			onSelectCallback(base.GridIndex);
		}

		// Token: 0x06033B74 RID: 211828 RVA: 0x00C1D1A7 File Offset: 0x00C1B3A7
		private void OnClickBtnDetail()
		{
			Action<int> onClickBtnDetailCallback = this.OnClickBtnDetailCallback;
			if (onClickBtnDetailCallback == null)
			{
				return;
			}
			onClickBtnDetailCallback(base.GridIndex);
		}

		// Token: 0x06033B75 RID: 211829 RVA: 0x00C1D1C0 File Offset: 0x00C1B3C0
		[NullableContext(1)]
		public override void Refresh(RogueResGainData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RogueResCharacterBuff? rogueResCharacterBuff = RogueBattleConfig.Instance.GetRogueResCharacterBuff(data.RogueResRoleBuff.ConfigId);
			if (rogueResCharacterBuff == null)
			{
				return;
			}
			this.RefreshDescText();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueResCharacterBuff.Value.AffixTitle, Array.Empty<object>());
			base.GetSprite(2).SetUIActive(false);
			this.SetSpriteByPath(rogueResCharacterBuff.Value.AffixIcon, base.GetSprite(2), false, null, delegate(bool result)
			{
				if (result)
				{
					base.GetSprite(2).SetUIActive(true);
				}
			});
			base.GetItem(4).SetUIActive(data.RogueResRoleBuff.IsNew);
		}

		// Token: 0x06033B76 RID: 211830 RVA: 0x00C1D278 File Offset: 0x00C1B478
		private void RefreshDescText()
		{
			if (this.Data == null)
			{
				return;
			}
			RogueResCharacterBuff? rogueResCharacterBuff = RogueBattleConfig.Instance.GetRogueResCharacterBuff(this.Data.RogueResRoleBuff.ConfigId);
			if (rogueResCharacterBuff == null)
			{
				return;
			}
			if (RogueBattleModel.Instance.DescMode == EDescModel.SIMPLE)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueResCharacterBuff.Value.AffixDescSimple, Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueResCharacterBuff.Value.AffixDesc, rogueResCharacterBuff.Value.AffixDescParam());
		}

		// Token: 0x06033B77 RID: 211831 RVA: 0x00C1D314 File Offset: 0x00C1B514
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06033B78 RID: 211832 RVA: 0x00C1D327 File Offset: 0x00C1B527
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033B79 RID: 211833 RVA: 0x00C1D33C File Offset: 0x00C1B53C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "FirstBuffDetail"))
			{
				return null;
			}
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				item,
				item
			};
		}

		// Token: 0x0401B74E RID: 112462
		private RogueResGainData Data;

		// Token: 0x0401B74F RID: 112463
		public Action<int> OnSelectCallback;

		// Token: 0x0401B750 RID: 112464
		public Action<int> OnClickBtnDetailCallback;
	}
}
