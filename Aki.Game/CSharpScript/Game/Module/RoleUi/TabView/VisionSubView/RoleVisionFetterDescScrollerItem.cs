using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02003CA2 RID: 15522
	internal class RoleVisionFetterDescScrollerItem : UiPanelBase
	{
		// Token: 0x06027BDF RID: 162783 RVA: 0x00B21644 File Offset: 0x00B1F844
		[NullableContext(1)]
		public RoleVisionFetterDescScrollerItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06027BE0 RID: 162784 RVA: 0x00B21659 File Offset: 0x00B1F859
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06027BE1 RID: 162785 RVA: 0x00B21692 File Offset: 0x00B1F892
		public void Update(PhantomFetter data)
		{
			base.GetText(0).ShowTextNew(data.Name);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.EffectDescription, data.EffectDescriptionParam());
		}
	}
}
