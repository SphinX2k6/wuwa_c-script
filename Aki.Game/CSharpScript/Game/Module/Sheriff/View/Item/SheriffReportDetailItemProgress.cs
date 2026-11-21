using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C26 RID: 15398
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SheriffReportDetailItemProgress : GridProxyAbstract<ISheriffProgressPopInfo>
	{
		// Token: 0x06027732 RID: 161586 RVA: 0x00B10E77 File Offset: 0x00B0F077
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06027733 RID: 161587 RVA: 0x00B10E8C File Offset: 0x00B0F08C
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

		// Token: 0x06027734 RID: 161588 RVA: 0x00B10EF8 File Offset: 0x00B0F0F8
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

		// Token: 0x04015816 RID: 88086
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x02009848 RID: 38984
		private static class EItemComponent
		{
			// Token: 0x0402F80C RID: 194572
			public const int TxtTitle = 0;

			// Token: 0x0402F80D RID: 194573
			public const int TxtInfo = 1;
		}
	}
}
