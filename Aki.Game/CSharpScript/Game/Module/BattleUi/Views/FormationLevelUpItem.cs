using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D27 RID: 23847
	public class FormationLevelUpItem : UiPanelBase
	{
		// Token: 0x0603C786 RID: 247686 RVA: 0x00E8147E File Offset: 0x00E7F67E
		[NullableContext(1)]
		public FormationLevelUpItem(UUIItem rootUiItem)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_FormationLevelUpItem", rootUiItem, false).Forget();
		}

		// Token: 0x0603C787 RID: 247687 RVA: 0x00E81498 File Offset: 0x00E7F698
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

		// Token: 0x0603C788 RID: 247688 RVA: 0x00E814E0 File Offset: 0x00E7F6E0
		protected override void OnStart()
		{
			if (this.LevelHandle != null)
			{
				base.GetText(0).SetText(this.LevelHandle, true);
			}
			this.LevelHandle = null;
		}

		// Token: 0x0603C789 RID: 247689 RVA: 0x00E81504 File Offset: 0x00E7F704
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

		// Token: 0x0401F823 RID: 129059
		[Nullable(2)]
		public string LevelHandle;

		// Token: 0x0200BFB2 RID: 49074
		private enum EFormationLevelUpItem
		{
			// Token: 0x04039D58 RID: 236888
			LevelText
		}
	}
}
