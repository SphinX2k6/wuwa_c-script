using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DDE RID: 15838
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeRandomEventItem : GridProxyAbstract<RogueGainEntry>
	{
		// Token: 0x0602876F RID: 165743 RVA: 0x00B57358 File Offset: 0x00B55558
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06028770 RID: 165744 RVA: 0x00B573E2 File Offset: 0x00B555E2
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnStateChange.Clear();
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnClickEvent));
		}

		// Token: 0x06028771 RID: 165745 RVA: 0x00B57412 File Offset: 0x00B55612
		protected void OnClickEvent(EToggleState toggleState)
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = ((toggleState == EToggleState.ETT_Checked) ? this.Data : null);
			if (this.OnSelectHandle != null)
			{
				this.OnSelectHandle(this, toggleState);
			}
		}

		// Token: 0x06028772 RID: 165746 RVA: 0x00B57440 File Offset: 0x00B55640
		public void SetButtonState(bool isSelected)
		{
			base.GetExtendToggle(0).SetSelfInteractive(isSelected);
		}

		// Token: 0x06028773 RID: 165747 RVA: 0x00B5744F File Offset: 0x00B5564F
		public void SetToggleState(bool isSelected)
		{
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06028774 RID: 165748 RVA: 0x00B57468 File Offset: 0x00B55668
		public EToggleState GetToggleState()
		{
			return base.GetExtendToggle(0).GetToggleState();
		}

		// Token: 0x06028775 RID: 165749 RVA: 0x00B57478 File Offset: 0x00B55678
		public override void Refresh(RogueGainEntry entry, bool isSelected, int gridIndex)
		{
			this.Data = entry;
			RogueEvent? rogueEventConfigById = RoguelikeConfig.Instance.GetRogueEventConfigById(entry.ConfigId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ((rogueEventConfigById != null) ? rogueEventConfigById.GetValueOrDefault().Title : null) ?? "", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), ((rogueEventConfigById != null) ? rogueEventConfigById.GetValueOrDefault().TextId : null) ?? "", Array.Empty<object>());
			bool flag = entry.IsSell ?? (RoguelikeModel.Instance.GetRoguelikeCurrency(80100000) >= entry.Cost);
			this.SetButtonState(!entry.IsSelect && flag);
		}

		// Token: 0x04015F6A RID: 89962
		public RogueGainEntry Data;

		// Token: 0x04015F6B RID: 89963
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoguelikeRandomEventItem, EToggleState> OnSelectHandle;

		// Token: 0x020099E2 RID: 39394
		[NullableContext(0)]
		private class ERoguelikeRandomEventItemDefine
		{
			// Token: 0x0402FF8C RID: 196492
			public const int BtnEvent = 0;

			// Token: 0x0402FF8D RID: 196493
			public const int TxtTitle = 1;

			// Token: 0x0402FF8E RID: 196494
			public const int TxtDesc = 2;
		}
	}
}
