using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004131 RID: 16689
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropDownItem : DropDownItemBase<GymChallengeData>
	{
		// Token: 0x0602A33C RID: 172860 RVA: 0x00BEA8BC File Offset: 0x00BE8ABC
		public DropDownItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x0602A33D RID: 172861 RVA: 0x00BEA8C5 File Offset: 0x00BE8AC5
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602A33E RID: 172862 RVA: 0x00BEA8FE File Offset: 0x00BE8AFE
		[NullableContext(2)]
		protected override UUIExtendToggle GetDropDownToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0602A33F RID: 172863 RVA: 0x00BEA908 File Offset: 0x00BE8B08
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

		// Token: 0x0602A340 RID: 172864 RVA: 0x00BEA980 File Offset: 0x00BE8B80
		private void OnClickedLock()
		{
			GymChallengeData data = this.Data;
			if (data != null && data.State == EChallengeState.Lock)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1112", Array.Empty<object>());
			}
		}

		// Token: 0x04016F9A RID: 94106
		[Nullable(2)]
		private GymChallengeData Data;

		// Token: 0x02009CFD RID: 40189
		[NullableContext(0)]
		private class EDropDownItemComponent
		{
			// Token: 0x04030CFB RID: 199931
			public const int Toggle = 0;

			// Token: 0x04030CFC RID: 199932
			public const int Content = 1;
		}
	}
}
