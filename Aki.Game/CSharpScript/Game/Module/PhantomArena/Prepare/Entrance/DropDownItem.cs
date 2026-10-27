using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005161 RID: 20833
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropDownItem : DropDownItemBase<GymChallengeData>
	{
		// Token: 0x06035440 RID: 218176 RVA: 0x00C9D38C File Offset: 0x00C9B58C
		public DropDownItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06035441 RID: 218177 RVA: 0x00C9D395 File Offset: 0x00C9B595
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06035442 RID: 218178 RVA: 0x00C9D3CE File Offset: 0x00C9B5CE
		[NullableContext(2)]
		protected override UUIExtendToggle GetDropDownToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06035443 RID: 218179 RVA: 0x00C9D3D8 File Offset: 0x00C9B5D8
		protected override void OnShowDropDownItemBase(GymChallengeData data)
		{
			this.Data = data;
			string textStringId = this.Data.IsLast ? "PhantomBattle_1115" : "PhantomBattle_1114";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
			if (data.State == EChallengeState.Lock)
			{
				this.GetDropDownToggle().OnUndeterminedClicked.Add(new Action(this.OnClickedLock));
				this.GetDropDownToggle().SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
			}
		}

		// Token: 0x06035444 RID: 218180 RVA: 0x00C9D450 File Offset: 0x00C9B650
		private void OnClickedLock()
		{
			GymChallengeData data = this.Data;
			if (data != null && data.State == EChallengeState.Lock)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1112", Array.Empty<object>());
			}
		}

		// Token: 0x0401C565 RID: 116069
		[Nullable(2)]
		private GymChallengeData Data;

		// Token: 0x0200B2C4 RID: 45764
		[NullableContext(0)]
		private class EDropDownItemComponent
		{
			// Token: 0x040362A6 RID: 221862
			public const int Toggle = 0;

			// Token: 0x040362A7 RID: 221863
			public const int Content = 1;
		}
	}
}
