using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x020043F4 RID: 17396
	public class MenuScrollSettingTitleItem : MenuScrollSettingBaseItem
	{
		// Token: 0x0602BF71 RID: 180081 RVA: 0x00C5835B File Offset: 0x00C5655B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602BF72 RID: 180082 RVA: 0x00C58394 File Offset: 0x00C56594
		protected override void OnStart()
		{
			if (this.SequencePlayer == null)
			{
				this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			}
		}

		// Token: 0x0602BF73 RID: 180083 RVA: 0x00C583AF File Offset: 0x00C565AF
		protected override void OnBeforeDestroy()
		{
			if (this.SequencePlayer != null)
			{
				this.SequencePlayer = null;
			}
			if (this.Data != null)
			{
				this.Data = null;
			}
		}

		// Token: 0x0602BF74 RID: 180084 RVA: 0x00C583CF File Offset: 0x00C565CF
		[NullableContext(1)]
		public override void Update(MenuData data, bool bGameSettingsUpdate)
		{
			this.Data = data;
			this.RefreshTitle();
		}

		// Token: 0x0602BF75 RID: 180085 RVA: 0x00C583E0 File Offset: 0x00C565E0
		private void RefreshTitle()
		{
			this.SetSpriteByPath(this.Data.SubImage, base.GetSprite(0), false, null, null);
			base.GetText(1).ShowTextNew(this.Data.SubName ?? "");
		}

		// Token: 0x0602BF76 RID: 180086 RVA: 0x00C58430 File Offset: 0x00C56630
		[NullableContext(1)]
		public override void PlaySequenceFromName(string name)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName(name, false, null, false);
		}

		// Token: 0x0602BF77 RID: 180087 RVA: 0x00C58459 File Offset: 0x00C56659
		public override void SetInteractionActive(bool val)
		{
		}

		// Token: 0x04017ADC RID: 96988
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200A0E2 RID: 41186
		private class EComponents
		{
			// Token: 0x04031FCD RID: 204749
			public const int TitleSprite = 0;

			// Token: 0x04031FCE RID: 204750
			public const int TitleText = 1;
		}
	}
}
