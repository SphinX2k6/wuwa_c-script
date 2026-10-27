using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x0200551B RID: 21787
	internal class NpcIconPanel : UiPanelBase
	{
		// Token: 0x06037A4C RID: 227916 RVA: 0x00D35628 File Offset: 0x00D33828
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

		// Token: 0x06037A4D RID: 227917 RVA: 0x00D35691 File Offset: 0x00D33891
		protected override void OnStart()
		{
			this.LevelSequencer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06037A4E RID: 227918 RVA: 0x00D356A4 File Offset: 0x00D338A4
		[NullableContext(1)]
		public void SetIcon(string iconPath, Action successCb)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(1), false, null, delegate(bool success)
			{
				successCb();
			});
		}

		// Token: 0x06037A4F RID: 227919 RVA: 0x00D356E4 File Offset: 0x00D338E4
		public void PlaySequence()
		{
			LevelSequencePlayer levelSequencer = this.LevelSequencer;
			if (levelSequencer == null)
			{
				return;
			}
			levelSequencer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0401D425 RID: 119845
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencer;

		// Token: 0x0200B75A RID: 46938
		private enum ENpcChildComp
		{
			// Token: 0x0403784E RID: 227406
			Item,
			// Token: 0x0403784F RID: 227407
			Icon
		}
	}
}
