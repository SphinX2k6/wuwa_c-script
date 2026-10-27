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
	// Token: 0x02004721 RID: 18209
	public class ProgressItem : UiPanelBase
	{
		// Token: 0x0602F95C RID: 194908 RVA: 0x00B05830 File Offset: 0x00B03A30
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

		// Token: 0x0602F95D RID: 194909 RVA: 0x00B0589C File Offset: 0x00B03A9C
		protected override UniTask OnBeforeStartAsync()
		{
			ProgressItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ProgressItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F95E RID: 194910 RVA: 0x00B058E0 File Offset: 0x00B03AE0
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

		// Token: 0x04019B21 RID: 105249
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04019B22 RID: 105250
		private bool LastActive;

		// Token: 0x0200A96E RID: 43374
		private enum EViewComponent
		{
			// Token: 0x04033922 RID: 211234
			PnlNml,
			// Token: 0x04033923 RID: 211235
			PnlActive
		}
	}
}
