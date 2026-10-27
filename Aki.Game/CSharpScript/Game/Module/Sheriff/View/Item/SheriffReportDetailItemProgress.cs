using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C75 RID: 19573
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SheriffReportDetailItemProgress : GridProxyAbstract<ISheriffProgressPopInfo>
	{
		// Token: 0x0603297F RID: 207231 RVA: 0x00BCC213 File Offset: 0x00BCA413
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06032980 RID: 207232 RVA: 0x00BCC228 File Offset: 0x00BCA428
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032981 RID: 207233 RVA: 0x00BCC294 File Offset: 0x00BCA494
		[NullableContext(1)]
		public override void Refresh(ISheriffProgressPopInfo data, bool isSelected, int gridIndex)
		{
			SheriffProgress progress = data.Progress;
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(progress.Title);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.ShowTextNew(progress.Context);
			}
			if (data.NeedAnim)
			{
				data.NeedAnim = false;
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.PlayOrReplaySequenceByName("Notice", false, null);
			}
		}

		// Token: 0x0401AEB9 RID: 110265
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AE2A RID: 44586
		private static class EItemComponent
		{
			// Token: 0x04034E67 RID: 216679
			public const int TxtTitle = 0;

			// Token: 0x04034E68 RID: 216680
			public const int TxtInfo = 1;
		}
	}
}
