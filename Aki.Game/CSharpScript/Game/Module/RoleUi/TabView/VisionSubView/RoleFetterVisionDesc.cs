using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02003C9E RID: 15518
	public class RoleFetterVisionDesc : UiPanelBase
	{
		// Token: 0x06027BD5 RID: 162773 RVA: 0x00B214EA File Offset: 0x00B1F6EA
		[NullableContext(1)]
		public RoleFetterVisionDesc(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06027BD6 RID: 162774 RVA: 0x00B214FF File Offset: 0x00B1F6FF
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06027BD7 RID: 162775 RVA: 0x00B21538 File Offset: 0x00B1F738
		[NullableContext(1)]
		public void Refresh(IReadOnlyList<PhantomFetter> data)
		{
			this.RoleVisionDescScroller.SetActive(data.Count > 0);
			this.RoleVisionDescScroller.Update(data);
		}

		// Token: 0x06027BD8 RID: 162776 RVA: 0x00B2155A File Offset: 0x00B1F75A
		protected override void OnBeforeDestroy()
		{
			this.RoleVisionDescScroller.Destroy(null);
		}

		// Token: 0x04015A83 RID: 88707
		[Nullable(2)]
		private readonly RoleVisionDescScroller RoleVisionDescScroller;

		// Token: 0x02009899 RID: 39065
		private enum EComponent
		{
			// Token: 0x0402F94E RID: 194894
			Title,
			// Token: 0x0402F94F RID: 194895
			DescScrollerItem
		}
	}
}
