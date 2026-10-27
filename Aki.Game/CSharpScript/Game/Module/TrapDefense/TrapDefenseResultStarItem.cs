using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AA4 RID: 19108
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class TrapDefenseResultStarItem : GridProxyAbstract<ITrapDefenseStarInfo>
	{
		// Token: 0x06031846 RID: 202822 RVA: 0x00B7AC84 File Offset: 0x00B78E84
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

		// Token: 0x06031847 RID: 202823 RVA: 0x00B7ACCC File Offset: 0x00B78ECC
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnAnimEnd), false);
		}

		// Token: 0x06031848 RID: 202824 RVA: 0x00B7ACF7 File Offset: 0x00B78EF7
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

		// Token: 0x06031849 RID: 202825 RVA: 0x00B7AD30 File Offset: 0x00B78F30
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

		// Token: 0x0603184A RID: 202826 RVA: 0x00B7ADC3 File Offset: 0x00B78FC3
		private void OnAnimEnd(string name)
		{
			this.Data.HasPlayed = true;
		}

		// Token: 0x0401A77E RID: 108414
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A77F RID: 108415
		private ITrapDefenseStarInfo Data;
	}
}
