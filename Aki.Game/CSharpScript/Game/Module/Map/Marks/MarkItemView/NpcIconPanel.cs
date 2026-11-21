using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044EE RID: 17646
	internal class NpcIconPanel : UiPanelBase
	{
		// Token: 0x0602C91A RID: 182554 RVA: 0x00C833FC File Offset: 0x00C815FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602C91B RID: 182555 RVA: 0x00C83465 File Offset: 0x00C81665
		protected override void OnStart()
		{
			this.LevelSequencer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602C91C RID: 182556 RVA: 0x00C83478 File Offset: 0x00C81678
		[NullableContext(1)]
		public void SetIcon(string iconPath, Action successCb)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(1), false, null, delegate(bool success)
			{
				successCb();
			});
		}

		// Token: 0x0602C91D RID: 182557 RVA: 0x00C834B8 File Offset: 0x00C816B8
		public void PlaySequence()
		{
			LevelSequencePlayer levelSequencer = this.LevelSequencer;
			if (levelSequencer == null)
			{
				return;
			}
			levelSequencer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x04017EA8 RID: 97960
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencer;

		// Token: 0x0200A185 RID: 41349
		private enum ENpcChildComp
		{
			// Token: 0x04032279 RID: 205433
			Item,
			// Token: 0x0403227A RID: 205434
			Icon
		}
	}
}
