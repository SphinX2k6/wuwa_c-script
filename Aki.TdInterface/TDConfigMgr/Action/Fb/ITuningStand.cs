using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002879 RID: 10361
	[NullableContext(2)]
	[Nullable(0)]
	public class ITuningStand : IUiGame
	{
		// Token: 0x0600E588 RID: 58760 RVA: 0x0021BE90 File Offset: 0x0021A090
		[NullableContext(1)]
		public static ITuningStand Create(ITuningStand? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITuningStand
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004658 RID: 18008
		// (get) Token: 0x0600E589 RID: 58761 RVA: 0x0021BEAF File Offset: 0x0021A0AF
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004659 RID: 18009
		// (get) Token: 0x0600E58A RID: 58762 RVA: 0x0021BEBC File Offset: 0x0021A0BC
		public virtual ETuningStandVisualType VisualType
		{
			get
			{
				return (ETuningStandVisualType)this.Instance.VisualType;
			}
		}

		// Token: 0x1700465A RID: 18010
		// (get) Token: 0x0600E58B RID: 58763 RVA: 0x0021BECC File Offset: 0x0021A0CC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ITuningStandBubbleConfig> BubbleConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._BubbleConfigInited)
				{
					return this._BubbleConfigCache;
				}
				this._BubbleConfigInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int bubbleConfigLength = this.Instance.BubbleConfigLength;
				this._BubbleConfigCache = new List<ITuningStandBubbleConfig>(bubbleConfigLength);
				for (int i = 0; i < bubbleConfigLength; i++)
				{
					this._BubbleConfigCache.Add(ITuningStandBubbleConfig.Create(this.Instance.BubbleConfig(i)));
				}
				return this._BubbleConfigCache;
			}
		}

		// Token: 0x1700465B RID: 18011
		// (get) Token: 0x0600E58C RID: 58764 RVA: 0x0021BF46 File Offset: 0x0021A146
		public virtual string GuidancePath
		{
			get
			{
				return this.Instance.GuidancePath;
			}
		}

		// Token: 0x1700465C RID: 18012
		// (get) Token: 0x0600E58D RID: 58765 RVA: 0x0021BF53 File Offset: 0x0021A153
		public virtual string MusicScorePath
		{
			get
			{
				return this.Instance.MusicScorePath;
			}
		}

		// Token: 0x1700465D RID: 18013
		// (get) Token: 0x0600E58E RID: 58766 RVA: 0x0021BF60 File Offset: 0x0021A160
		public virtual string NoteSequence
		{
			get
			{
				return this.Instance.NoteSequence;
			}
		}

		// Token: 0x1700465E RID: 18014
		// (get) Token: 0x0600E58F RID: 58767 RVA: 0x0021BF6D File Offset: 0x0021A16D
		public virtual string CompleteMusic
		{
			get
			{
				return this.Instance.CompleteMusic;
			}
		}

		// Token: 0x1700465F RID: 18015
		// (get) Token: 0x0600E590 RID: 58768 RVA: 0x0021BF7A File Offset: 0x0021A17A
		[Nullable(1)]
		public virtual ITuningStandGridBoard BoardConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._BoardConfigInited)
				{
					return this._BoardConfigCache;
				}
				this._BoardConfigInited = true;
				this._BoardConfigCache = ITuningStandGridBoard.Create(this.Instance.BoardConfig);
				return this._BoardConfigCache;
			}
		}

		// Token: 0x04007EED RID: 32493
		private ITuningStand Instance;

		// Token: 0x04007EEE RID: 32494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITuningStandBubbleConfig> _BubbleConfigCache;

		// Token: 0x04007EEF RID: 32495
		private bool _BubbleConfigInited;

		// Token: 0x04007EF0 RID: 32496
		private ITuningStandGridBoard _BoardConfigCache;

		// Token: 0x04007EF1 RID: 32497
		private bool _BoardConfigInited;
	}
}
