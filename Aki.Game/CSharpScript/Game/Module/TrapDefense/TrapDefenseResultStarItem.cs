using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A4C RID: 14924
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class TrapDefenseResultStarItem : GridProxyAbstract<ITrapDefenseStarInfo>
	{
		// Token: 0x060265D6 RID: 157142 RVA: 0x00ABEC38 File Offset: 0x00ABCE38
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060265D7 RID: 157143 RVA: 0x00ABEC80 File Offset: 0x00ABCE80
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnAnimEnd), false);
		}

		// Token: 0x060265D8 RID: 157144 RVA: 0x00ABECAB File Offset: 0x00ABCEAB
		public override void Refresh(ITrapDefenseStarInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data.IsAchieve && (!data.IsNew || data.HasPlayed));
		}

		// Token: 0x060265D9 RID: 157145 RVA: 0x00ABECE4 File Offset: 0x00ABCEE4
		public void PlayAnim()
		{
			if (this.Data.IsNew && !this.Data.HasPlayed)
			{
				if (this.Data.PlayDelay <= 0)
				{
					UUIItem item = base.GetItem(0);
					if (item != null)
					{
						item.SetUIActive(true);
					}
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer == null)
					{
						return;
					}
					levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
					return;
				}
				else
				{
					TimerSystem.Instance.Delay(delegate(float _)
					{
						UUIItem item2 = base.GetItem(0);
						if (item2 != null)
						{
							item2.SetUIActive(true);
						}
						LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
						if (levelSequencePlayer2 == null)
						{
							return;
						}
						levelSequencePlayer2.PlayOrReplaySequenceByName("Start", false, null);
					}, (float)this.Data.PlayDelay, null, null, true, 1f);
				}
			}
		}

		// Token: 0x060265DA RID: 157146 RVA: 0x00ABED77 File Offset: 0x00ABCF77
		private void OnAnimEnd(string name)
		{
			this.Data.HasPlayed = true;
		}

		// Token: 0x040150D0 RID: 86224
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040150D1 RID: 86225
		private ITrapDefenseStarInfo Data;
	}
}
