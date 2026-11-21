using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C1E RID: 23582
	[NullableContext(1)]
	[Nullable(0)]
	public class PianoQteBtnItem
	{
		// Token: 0x17006E4D RID: 28237
		// (get) Token: 0x06039E96 RID: 237206 RVA: 0x01048F92 File Offset: 0x01047192
		public string KeyName
		{
			get
			{
				return this.KeyNameInternal;
			}
		}

		// Token: 0x17006E4E RID: 28238
		// (get) Token: 0x06039E97 RID: 237207 RVA: 0x01048F9A File Offset: 0x0104719A
		[Nullable(2)]
		public UUIItem UiItem
		{
			[NullableContext(2)]
			get
			{
				return this.UiItemInternal;
			}
		}

		// Token: 0x17006E4F RID: 28239
		// (get) Token: 0x06039E98 RID: 237208 RVA: 0x01048FA2 File Offset: 0x010471A2
		public bool Visibility
		{
			get
			{
				return this.VisibilityInternal;
			}
		}

		// Token: 0x06039E99 RID: 237209 RVA: 0x01048FAC File Offset: 0x010471AC
		public PianoQteBtnItem(string keyName, UUIItem uiItem, bool visibility)
		{
			this.KeyNameInternal = keyName;
			this.UiItemInternal = uiItem;
			this.VisibilityInternal = visibility;
			if (this.UiItemInternal != null)
			{
				this.UiItemInternal.SetUIActive(visibility);
			}
			this.LevelSequence = new LevelSequencePlayer(this.UiItemInternal);
			this.LevelSequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x06039E9A RID: 237210 RVA: 0x0104901C File Offset: 0x0104721C
		public void Dispose()
		{
			LevelSequencePlayer levelSequence = this.LevelSequence;
			if (levelSequence != null)
			{
				levelSequence.Clear();
			}
			this.LevelSequence = null;
			this.UiItemInternal = null;
		}

		// Token: 0x06039E9B RID: 237211 RVA: 0x01049040 File Offset: 0x01047240
		public void SetVisibility(bool visibility, EPianoQteResult? qteResult = null)
		{
			this.VisibilityInternal = visibility;
			if (this.UiItem == null)
			{
				return;
			}
			if (visibility)
			{
				LevelSequencePlayer levelSequence = this.LevelSequence;
				if (levelSequence != null)
				{
					levelSequence.PlayLevelSequenceByName("Start", false, null, false);
				}
				this.UiItem.SetUIActive(visibility);
				return;
			}
			if (qteResult == null)
			{
				this.UiItem.SetUIActive(visibility);
				return;
			}
			EPianoQteResult? epianoQteResult = qteResult;
			EPianoQteResult epianoQteResult2 = EPianoQteResult.Success;
			if (epianoQteResult.GetValueOrDefault() == epianoQteResult2 & epianoQteResult != null)
			{
				LevelSequencePlayer levelSequence2 = this.LevelSequence;
				if (levelSequence2 != null)
				{
					levelSequence2.PlayLevelSequenceByName("Success", false, null, false);
				}
				AudioSystem.Instance.PostEvent("play_sfx_gp_pianist_qte");
				return;
			}
			LevelSequencePlayer levelSequence3 = this.LevelSequence;
			if (levelSequence3 == null)
			{
				return;
			}
			levelSequence3.PlayLevelSequenceByName("Fail", false, null, false);
		}

		// Token: 0x06039E9C RID: 237212 RVA: 0x0104910E File Offset: 0x0104730E
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Success" || sequenceName == "Fail")
			{
				this.UiItem.SetUIActive(this.VisibilityInternal);
			}
		}

		// Token: 0x0401E9CE RID: 125390
		private readonly string KeyNameInternal = "";

		// Token: 0x0401E9CF RID: 125391
		[Nullable(2)]
		private UUIItem UiItemInternal;

		// Token: 0x0401E9D0 RID: 125392
		private bool VisibilityInternal;

		// Token: 0x0401E9D1 RID: 125393
		[Nullable(2)]
		private LevelSequencePlayer LevelSequence;
	}
}
