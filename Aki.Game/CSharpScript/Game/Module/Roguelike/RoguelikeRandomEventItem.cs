using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E15 RID: 19989
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeRandomEventItem : GridProxyAbstract<RogueGainEntry>
	{
		// Token: 0x06033904 RID: 211204 RVA: 0x00C0DE4C File Offset: 0x00C0C04C
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

		// Token: 0x06033905 RID: 211205 RVA: 0x00C0DED6 File Offset: 0x00C0C0D6
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnStateChange.Clear();
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnClickEvent));
		}

		// Token: 0x06033906 RID: 211206 RVA: 0x00C0DF06 File Offset: 0x00C0C106
		protected void OnClickEvent(EToggleState toggleState)
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = ((toggleState == EToggleState.ETT_Checked) ? this.Data : null);
			if (this.OnSelectHandle != null)
			{
				this.OnSelectHandle(this, toggleState);
			}
		}

		// Token: 0x06033907 RID: 211207 RVA: 0x00C0DF34 File Offset: 0x00C0C134
		public void SetButtonState(bool isSelected)
		{
			base.GetExtendToggle(0).SetSelfInteractive(isSelected);
		}

		// Token: 0x06033908 RID: 211208 RVA: 0x00C0DF43 File Offset: 0x00C0C143
		public void SetToggleState(bool isSelected)
		{
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033909 RID: 211209 RVA: 0x00C0DF5C File Offset: 0x00C0C15C
		public EToggleState GetToggleState()
		{
			return base.GetExtendToggle(0).GetToggleState();
		}

		// Token: 0x0603390A RID: 211210 RVA: 0x00C0DF6C File Offset: 0x00C0C16C
		public override void Refresh(RogueGainEntry entry, bool isSelected, int gridIndex)
		{
			this.Data = entry;
			RogueEvent? rogueEventConfigById = RoguelikeConfig.Instance.GetRogueEventConfigById(entry.ConfigId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ((rogueEventConfigById != null) ? rogueEventConfigById.GetValueOrDefault().Title : null) ?? "", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), ((rogueEventConfigById != null) ? rogueEventConfigById.GetValueOrDefault().TextId : null) ?? "", Array.Empty<object>());
			bool flag = entry.IsSell ?? (RoguelikeModel.Instance.GetRoguelikeCurrency(80100000) >= entry.Cost);
			this.SetButtonState(!entry.IsSelect && flag);
		}

		// Token: 0x0401B597 RID: 112023
		public RogueGainEntry Data;

		// Token: 0x0401B598 RID: 112024
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoguelikeRandomEventItem, EToggleState> OnSelectHandle;

		// Token: 0x0200AFAD RID: 44973
		[NullableContext(0)]
		private class ERoguelikeRandomEventItemDefine
		{
			// Token: 0x04035559 RID: 218457
			public const int BtnEvent = 0;

			// Token: 0x0403555A RID: 218458
			public const int TxtTitle = 1;

			// Token: 0x0403555B RID: 218459
			public const int TxtDesc = 2;
		}
	}
}
