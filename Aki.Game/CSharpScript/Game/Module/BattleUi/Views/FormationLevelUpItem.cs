using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D09 RID: 19721
	public class FormationLevelUpItem : UiPanelBase
	{
		// Token: 0x060316DF RID: 202463 RVA: 0x00DD1C1E File Offset: 0x00DCFE1E
		[NullableContext(1)]
		public FormationLevelUpItem(UUIItem rootUiItem)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_FormationLevelUpItem", rootUiItem, false).Forget();
		}

		// Token: 0x060316E0 RID: 202464 RVA: 0x00DD1C38 File Offset: 0x00DCFE38
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060316E1 RID: 202465 RVA: 0x00DD1C80 File Offset: 0x00DCFE80
		protected override void OnStart()
		{
			if (this.LevelHandle != null)
			{
				base.GetText(0).SetText(this.LevelHandle, true);
			}
			this.LevelHandle = null;
		}

		// Token: 0x060316E2 RID: 202466 RVA: 0x00DD1CA4 File Offset: 0x00DCFEA4
		[NullableContext(1)]
		public void SetLevelText(string level)
		{
			if (base.InAsyncLoading())
			{
				this.LevelHandle = level;
				return;
			}
			base.GetText(0).SetText(level, true);
		}

		// Token: 0x0401A2DC RID: 107228
		[Nullable(2)]
		public string LevelHandle;

		// Token: 0x0200A9B8 RID: 43448
		private enum EFormationLevelUpItem
		{
			// Token: 0x0403471A RID: 214810
			LevelText
		}
	}
}
