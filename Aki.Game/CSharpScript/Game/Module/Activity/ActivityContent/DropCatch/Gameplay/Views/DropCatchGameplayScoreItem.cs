using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x0200565F RID: 22111
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DropCatchGameplayScoreItem : GridProxyAbstract<IScoreLevelItemData>
	{
		// Token: 0x060369AD RID: 223661 RVA: 0x00F3D674 File Offset: 0x00F3B874
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

		// Token: 0x060369AE RID: 223662 RVA: 0x00F3D6E4 File Offset: 0x00F3B8E4
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x060369AF RID: 223663 RVA: 0x00F3D6F8 File Offset: 0x00F3B8F8
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

		// Token: 0x060369B0 RID: 223664 RVA: 0x00F3D7A8 File Offset: 0x00F3B9A8
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.Clear();
		}

		// Token: 0x0401CDCC RID: 118220
		private bool HasFinished;

		// Token: 0x0401CDCD RID: 118221
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;
	}
}
