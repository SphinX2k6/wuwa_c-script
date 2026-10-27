using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02004CF0 RID: 19696
	internal class RoleVisionFetterDescScrollerItem : UiPanelBase
	{
		// Token: 0x06032E04 RID: 208388 RVA: 0x00BDBD3C File Offset: 0x00BD9F3C
		[NullableContext(1)]
		public RoleVisionFetterDescScrollerItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06032E05 RID: 208389 RVA: 0x00BDBD51 File Offset: 0x00BD9F51
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06032E06 RID: 208390 RVA: 0x00BDBD8A File Offset: 0x00BD9F8A
		public void Update(PhantomFetter data)
		{
			base.GetText(0).ShowTextNew(data.Name);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.EffectDescription, data.EffectDescriptionParam());
		}
	}
}
