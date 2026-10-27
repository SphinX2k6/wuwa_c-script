using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E3A RID: 20026
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleBuffSelectItem : GridProxyAbstract<RogueGainEntry>
	{
		// Token: 0x06033A00 RID: 211456 RVA: 0x00C14FDD File Offset: 0x00C131DD
		public override void Refresh(RogueGainEntry data, bool isSelected, int gridIndex)
		{
			this.Update(data);
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033A01 RID: 211457 RVA: 0x00C14FFD File Offset: 0x00C131FD
		public void Update(RogueGainEntry rogueGainEntry)
		{
			this.RogueGainEntry = rogueGainEntry;
			this.RefreshPanel();
		}

		// Token: 0x06033A02 RID: 211458 RVA: 0x00C1500C File Offset: 0x00C1320C
		public void SetToggleStateChangeCallback(Action<int, bool> callback)
		{
			this.ToggleStateChangeCallback = callback;
		}

		// Token: 0x06033A03 RID: 211459 RVA: 0x00C15015 File Offset: 0x00C13215
		public bool IsSelect()
		{
			return base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x06033A04 RID: 211460 RVA: 0x00C15028 File Offset: 0x00C13228
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.SelfToggle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnDetail));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033A05 RID: 211461 RVA: 0x00C15196 File Offset: 0x00C13396
		private void SelfToggle(EToggleState state)
		{
			Action<int, bool> toggleStateChangeCallback = this.ToggleStateChangeCallback;
			if (toggleStateChangeCallback == null)
			{
				return;
			}
			toggleStateChangeCallback(base.GridIndex, state == EToggleState.ETT_Checked);
		}

		// Token: 0x06033A06 RID: 211462 RVA: 0x00C151B2 File Offset: 0x00C133B2
		private void OnClickBtnDetail()
		{
			Action<int> onClickBtnDetailCallback = this.OnClickBtnDetailCallback;
			if (onClickBtnDetailCallback == null)
			{
				return;
			}
			onClickBtnDetailCallback(base.GridIndex);
		}

		// Token: 0x06033A07 RID: 211463 RVA: 0x00C151CC File Offset: 0x00C133CC
		public void RefreshPanel()
		{
			RogueCharacterBuff? rogueCharacterBuffConfig = RoguelikeConfig.Instance.GetRogueCharacterBuffConfig(this.RogueGainEntry.ConfigId);
			if (rogueCharacterBuffConfig == null)
			{
				return;
			}
			if (RoguelikeModel.Instance.GetDescModel() == EDescModel.SIMPLE)
			{
				base.GetText(1).ShowTextNew(rogueCharacterBuffConfig.Value.AffixDescSimple);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueCharacterBuffConfig.Value.AffixDesc, rogueCharacterBuffConfig.Value.AffixDescParam());
			}
			base.GetText(3).ShowTextNew(rogueCharacterBuffConfig.Value.AffixTitle);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("RogueCharacterBuff_Type", null);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string id in rogueCharacterBuffConfig.Value.AffixTypeListIter())
			{
				string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(id, null);
				stringBuilder.Append(StringUtils.Format(localTextNew, new string[]
				{
					localTextNew2
				}));
			}
			if (rogueCharacterBuffConfig.Value.AffixTypeListLength > 0)
			{
				base.GetText(6).ShowTextNew(stringBuilder.ToString());
				base.GetText(6).SetUIActive(true);
			}
			else
			{
				base.GetText(6).SetUIActive(false);
			}
			this.SetSpriteByPath(rogueCharacterBuffConfig.Value.AffixIcon, base.GetSprite(2), false, null, null);
			base.GetItem(4).SetUIActive(this.RogueGainEntry.IsNew);
		}

		// Token: 0x06033A08 RID: 211464 RVA: 0x00C15364 File Offset: 0x00C13564
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x06033A09 RID: 211465 RVA: 0x00C15377 File Offset: 0x00C13577
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0401B616 RID: 112150
		[Nullable(2)]
		public RogueGainEntry RogueGainEntry;

		// Token: 0x0401B617 RID: 112151
		[Nullable(2)]
		private Action<int, bool> ToggleStateChangeCallback;

		// Token: 0x0401B618 RID: 112152
		[Nullable(2)]
		public Action<int> OnClickBtnDetailCallback;

		// Token: 0x0200AFEF RID: 45039
		[NullableContext(0)]
		public static class ERoleBuffSelectItemCom
		{
			// Token: 0x0403569C RID: 218780
			public const int SelfToggle = 0;

			// Token: 0x0403569D RID: 218781
			public const int DescText = 1;

			// Token: 0x0403569E RID: 218782
			public const int SpriteIcon = 2;

			// Token: 0x0403569F RID: 218783
			public const int TxtName = 3;

			// Token: 0x040356A0 RID: 218784
			public const int NewItem = 4;

			// Token: 0x040356A1 RID: 218785
			public const int BtnDetail = 5;

			// Token: 0x040356A2 RID: 218786
			public const int TxtClassify = 6;
		}
	}
}
