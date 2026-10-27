using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x02005411 RID: 21521
	public class MenuScrollSettingTitleItem : MenuScrollSettingBaseItem
	{
		// Token: 0x06037028 RID: 225320 RVA: 0x00D08F33 File Offset: 0x00D07133
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06037029 RID: 225321 RVA: 0x00D08F6C File Offset: 0x00D0716C
		protected override void OnStart()
		{
			if (this.SequencePlayer == null)
			{
				this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			}
		}

		// Token: 0x0603702A RID: 225322 RVA: 0x00D08F87 File Offset: 0x00D07187
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

		// Token: 0x0603702B RID: 225323 RVA: 0x00D08FA7 File Offset: 0x00D071A7
		[NullableContext(1)]
		public override void Update(MenuData data, bool bGameSettingsUpdate)
		{
			this.Data = data;
			this.RefreshTitle();
		}

		// Token: 0x0603702C RID: 225324 RVA: 0x00D08FB8 File Offset: 0x00D071B8
		private void RefreshTitle()
		{
			this.SetSpriteByPath(this.Data.SubImage, base.GetSprite(0), false, null, null);
			base.GetText(1).ShowTextNew(this.Data.SubName ?? "");
		}

		// Token: 0x0603702D RID: 225325 RVA: 0x00D09008 File Offset: 0x00D07208
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

		// Token: 0x0603702E RID: 225326 RVA: 0x00D09031 File Offset: 0x00D07231
		public override void SetInteractionActive(bool val)
		{
		}

		// Token: 0x0401D043 RID: 118851
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B6AA RID: 46762
		private class EComponents
		{
			// Token: 0x04037578 RID: 226680
			public const int TitleSprite = 0;

			// Token: 0x04037579 RID: 226681
			public const int TitleText = 1;
		}
	}
}
