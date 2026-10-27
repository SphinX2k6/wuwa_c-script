using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02004CEC RID: 19692
	public class RoleFetterVisionDesc : UiPanelBase
	{
		// Token: 0x06032DFA RID: 208378 RVA: 0x00BDBBE2 File Offset: 0x00BD9DE2
		[NullableContext(1)]
		public RoleFetterVisionDesc(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06032DFB RID: 208379 RVA: 0x00BDBBF7 File Offset: 0x00BD9DF7
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06032DFC RID: 208380 RVA: 0x00BDBC30 File Offset: 0x00BD9E30
		[NullableContext(1)]
		public void Refresh(IReadOnlyList<PhantomFetter> data)
		{
			this.RoleVisionDescScroller.SetActive(data.Count > 0);
			this.RoleVisionDescScroller.Update(data);
		}

		// Token: 0x06032DFD RID: 208381 RVA: 0x00BDBC52 File Offset: 0x00BD9E52
		protected override void OnBeforeDestroy()
		{
			this.RoleVisionDescScroller.Destroy(null);
		}

		// Token: 0x0401B0FE RID: 110846
		[Nullable(2)]
		private readonly RoleVisionDescScroller RoleVisionDescScroller;

		// Token: 0x0200AE7B RID: 44667
		private enum EComponent
		{
			// Token: 0x04034FA6 RID: 216998
			Title,
			// Token: 0x04034FA7 RID: 216999
			DescScrollerItem
		}
	}
}
