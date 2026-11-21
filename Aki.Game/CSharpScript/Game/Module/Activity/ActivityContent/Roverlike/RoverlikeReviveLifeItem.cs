using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050CB RID: 20683
	public class RoverlikeReviveLifeItem : GridProxyAbstract<bool>
	{
		// Token: 0x06033C3D RID: 212029 RVA: 0x00E7D934 File Offset: 0x00E7BB34
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

		// Token: 0x06033C3E RID: 212030 RVA: 0x00E7D97C File Offset: 0x00E7BB7C
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06033C3F RID: 212031 RVA: 0x00E7D98F File Offset: 0x00E7BB8F
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06033C40 RID: 212032 RVA: 0x00E7D9AC File Offset: 0x00E7BBAC
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

		// Token: 0x06033C41 RID: 212033 RVA: 0x00E7D9EC File Offset: 0x00E7BBEC
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

		// Token: 0x0401B6F7 RID: 112375
		[Nullable(1)]
		private const string NEWLY_ACQUIRED_LIFE_SEQ = "Get";

		// Token: 0x0401B6F8 RID: 112376
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401B6F9 RID: 112377
		private bool? IsAvailable;

		// Token: 0x0200AD97 RID: 44439
		private class EChildType
		{
			// Token: 0x04035A38 RID: 219704
			public const int SprLight = 0;
		}
	}
}
