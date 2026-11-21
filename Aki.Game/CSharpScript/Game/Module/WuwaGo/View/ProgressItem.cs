using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.View
{
	// Token: 0x02003651 RID: 13905
	public class ProgressItem : UiPanelBase
	{
		// Token: 0x06024122 RID: 147746 RVA: 0x00A35500 File Offset: 0x00A33700
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024123 RID: 147747 RVA: 0x00A3556C File Offset: 0x00A3376C
		protected override UniTask OnBeforeStartAsync()
		{
			ProgressItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ProgressItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024124 RID: 147748 RVA: 0x00A355B0 File Offset: 0x00A337B0
		public override void SetActive(bool active)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!active);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(active);
			}
			if (active && !this.LastActive)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.PlayLevelSequenceByName("Light_Up", false, null, false);
				}
			}
			this.LastActive = active;
		}

		// Token: 0x040141D0 RID: 82384
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x040141D1 RID: 82385
		private bool LastActive;

		// Token: 0x02009328 RID: 37672
		private enum EViewComponent
		{
			// Token: 0x0402E0B2 RID: 188594
			PnlNml,
			// Token: 0x0402E0B3 RID: 188595
			PnlActive
		}
	}
}
