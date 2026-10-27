using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200614D RID: 24909
	public class RoverlikeReviveLifeItem : GridProxyAbstract<bool>
	{
		// Token: 0x0603EF7D RID: 257917 RVA: 0x00F36A60 File Offset: 0x00F34C60
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

		// Token: 0x0603EF7E RID: 257918 RVA: 0x00F36AA8 File Offset: 0x00F34CA8
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0603EF7F RID: 257919 RVA: 0x00F36ABB File Offset: 0x00F34CBB
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0603EF80 RID: 257920 RVA: 0x00F36AD8 File Offset: 0x00F34CD8
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			bool? isAvailable = this.IsAvailable;
			if (isAvailable.GetValueOrDefault() == data & isAvailable != null)
			{
				return;
			}
			this.IsAvailable = new bool?(data);
			this.OnStateChange(data);
		}

		// Token: 0x0603EF81 RID: 257921 RVA: 0x00F36B18 File Offset: 0x00F34D18
		private void OnStateChange(bool newState)
		{
			UUIItem item = base.GetItem(0);
			if (!newState)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.StopSequenceByKey("Get", false, true);
				}
				if (item != null)
				{
					item.SetUIActive(false);
				}
				return;
			}
			if (item != null)
			{
				item.SetUIActive(true);
			}
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 == null)
			{
				return;
			}
			sequencePlayer2.PlayLevelSequenceByName("Get", false, null, false);
		}

		// Token: 0x04020DCA RID: 134602
		[Nullable(1)]
		private const string NEWLY_ACQUIRED_LIFE_SEQ = "Get";

		// Token: 0x04020DCB RID: 134603
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04020DCC RID: 134604
		private bool? IsAvailable;

		// Token: 0x0200C3B0 RID: 50096
		private class EChildType
		{
			// Token: 0x0403B0D7 RID: 241879
			public const int SprLight = 0;
		}
	}
}
