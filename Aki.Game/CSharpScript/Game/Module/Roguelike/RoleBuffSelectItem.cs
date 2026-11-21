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
	// Token: 0x02003E03 RID: 15875
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleBuffSelectItem : GridProxyAbstract<RogueGainEntry>
	{
		// Token: 0x0602886B RID: 165995 RVA: 0x00B5E505 File Offset: 0x00B5C705
		public override void Refresh(RogueGainEntry data, bool isSelected, int gridIndex)
		{
			this.Update(data);
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602886C RID: 165996 RVA: 0x00B5E525 File Offset: 0x00B5C725
		public void Update(RogueGainEntry rogueGainEntry)
		{
			this.RogueGainEntry = rogueGainEntry;
			this.RefreshPanel();
		}

		// Token: 0x0602886D RID: 165997 RVA: 0x00B5E534 File Offset: 0x00B5C734
		public void SetToggleStateChangeCallback(Action<int, bool> callback)
		{
			this.ToggleStateChangeCallback = callback;
		}

		// Token: 0x0602886E RID: 165998 RVA: 0x00B5E53D File Offset: 0x00B5C73D
		public bool IsSelect()
		{
			return base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x0602886F RID: 165999 RVA: 0x00B5E550 File Offset: 0x00B5C750
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

		// Token: 0x06028870 RID: 166000 RVA: 0x00B5E6BE File Offset: 0x00B5C8BE
		private void SelfToggle(EToggleState state)
		{
			Action<int, bool> toggleStateChangeCallback = this.ToggleStateChangeCallback;
			if (toggleStateChangeCallback == null)
			{
				return;
			}
			toggleStateChangeCallback(base.GridIndex, state == EToggleState.ETT_Checked);
		}

		// Token: 0x06028871 RID: 166001 RVA: 0x00B5E6DA File Offset: 0x00B5C8DA
		private void OnClickBtnDetail()
		{
			Action<int> onClickBtnDetailCallback = this.OnClickBtnDetailCallback;
			if (onClickBtnDetailCallback == null)
			{
				return;
			}
			onClickBtnDetailCallback(base.GridIndex);
		}

		// Token: 0x06028872 RID: 166002 RVA: 0x00B5E6F4 File Offset: 0x00B5C8F4
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

		// Token: 0x06028873 RID: 166003 RVA: 0x00B5E88C File Offset: 0x00B5CA8C
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x06028874 RID: 166004 RVA: 0x00B5E89F File Offset: 0x00B5CA9F
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x04015FE9 RID: 90089
		[Nullable(2)]
		public RogueGainEntry RogueGainEntry;

		// Token: 0x04015FEA RID: 90090
		[Nullable(2)]
		private Action<int, bool> ToggleStateChangeCallback;

		// Token: 0x04015FEB RID: 90091
		[Nullable(2)]
		public Action<int> OnClickBtnDetailCallback;

		// Token: 0x02009A21 RID: 39457
		[NullableContext(0)]
		public static class ERoleBuffSelectItemCom
		{
			// Token: 0x040300CC RID: 196812
			public const int SelfToggle = 0;

			// Token: 0x040300CD RID: 196813
			public const int DescText = 1;

			// Token: 0x040300CE RID: 196814
			public const int SpriteIcon = 2;

			// Token: 0x040300CF RID: 196815
			public const int TxtName = 3;

			// Token: 0x040300D0 RID: 196816
			public const int NewItem = 4;

			// Token: 0x040300D1 RID: 196817
			public const int BtnDetail = 5;

			// Token: 0x040300D2 RID: 196818
			public const int TxtClassify = 6;
		}
	}
}
