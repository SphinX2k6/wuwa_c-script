using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x0200670F RID: 26383
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DropCatchGameplayScoreItem : GridProxyAbstract<IScoreLevelItemData>
	{
		// Token: 0x06041E61 RID: 269921 RVA: 0x00FFC2A8 File Offset: 0x00FFA4A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06041E62 RID: 269922 RVA: 0x00FFC318 File Offset: 0x00FFA518
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x06041E63 RID: 269923 RVA: 0x00FFC32C File Offset: 0x00FFA52C
		public override void Refresh(IScoreLevelItemData data, bool isSelected, int gridIndex)
		{
			UUIArtText artText = base.GetArtText(0);
			if (artText != null)
			{
				artText.SetText(data.Score.ToString());
			}
			UUIArtText artText2 = base.GetArtText(1);
			if (artText2 != null)
			{
				artText2.SetText(data.Score.ToString());
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!data.IsFinish);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(data.IsFinish);
			}
			if (data.IsFinish && !this.HasFinished)
			{
				this.HasFinished = true;
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlaySequence("Bright", false, null);
			}
		}

		// Token: 0x06041E64 RID: 269924 RVA: 0x00FFC3DC File Offset: 0x00FFA5DC
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.Clear();
		}

		// Token: 0x04022573 RID: 140659
		private bool HasFinished;

		// Token: 0x04022574 RID: 140660
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;
	}
}
