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
	// Token: 0x02003E55 RID: 15957
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleRoleBuffItem : GridProxyAbstract<RogueResGainData>
	{
		// Token: 0x060289DB RID: 166363 RVA: 0x00B66598 File Offset: 0x00B64798
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

		// Token: 0x060289DC RID: 166364 RVA: 0x00B6666F File Offset: 0x00B6486F
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.RogueBattleDescModeChange, new Action(this.RefreshDescText));
		}

		// Token: 0x060289DD RID: 166365 RVA: 0x00B6668D File Offset: 0x00B6488D
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RogueBattleDescModeChange, new Action(this.RefreshDescText));
		}

		// Token: 0x060289DE RID: 166366 RVA: 0x00B666AB File Offset: 0x00B648AB
		private void OnClickExtendToggle(EToggleState state)
		{
			Action<int> onSelectCallback = this.OnSelectCallback;
			if (onSelectCallback == null)
			{
				return;
			}
			onSelectCallback(base.GridIndex);
		}

		// Token: 0x060289DF RID: 166367 RVA: 0x00B666C3 File Offset: 0x00B648C3
		private void OnClickBtnDetail()
		{
			Action<int> onClickBtnDetailCallback = this.OnClickBtnDetailCallback;
			if (onClickBtnDetailCallback == null)
			{
				return;
			}
			onClickBtnDetailCallback(base.GridIndex);
		}

		// Token: 0x060289E0 RID: 166368 RVA: 0x00B666DC File Offset: 0x00B648DC
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

		// Token: 0x060289E1 RID: 166369 RVA: 0x00B66794 File Offset: 0x00B64994
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

		// Token: 0x060289E2 RID: 166370 RVA: 0x00B66830 File Offset: 0x00B64A30
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060289E3 RID: 166371 RVA: 0x00B66843 File Offset: 0x00B64A43
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060289E4 RID: 166372 RVA: 0x00B66858 File Offset: 0x00B64A58
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

		// Token: 0x04016121 RID: 90401
		private RogueResGainData Data;

		// Token: 0x04016122 RID: 90402
		public Action<int> OnSelectCallback;

		// Token: 0x04016123 RID: 90403
		public Action<int> OnClickBtnDetailCallback;
	}
}
