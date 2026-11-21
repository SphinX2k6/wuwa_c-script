using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B4F RID: 11087
	[NullableContext(2)]
	[Nullable(0)]
	public class ITuningStand : IUiGame
	{
		// Token: 0x0600F3B9 RID: 62393 RVA: 0x00238DE4 File Offset: 0x00236FE4
		[NullableContext(0)]
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

		// Token: 0x170049C9 RID: 18889
		// (get) Token: 0x0600F3BA RID: 62394 RVA: 0x00238E03 File Offset: 0x00237003
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049CA RID: 18890
		// (get) Token: 0x0600F3BB RID: 62395 RVA: 0x00238E10 File Offset: 0x00237010
		public virtual ETuningStandVisualType VisualType
		{
			get
			{
				return (ETuningStandVisualType)this.Instance.VisualType;
			}
		}

		// Token: 0x170049CB RID: 18891
		// (get) Token: 0x0600F3BC RID: 62396 RVA: 0x00238E20 File Offset: 0x00237020
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ITuningStandBubbleConfig> BubbleConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x170049CC RID: 18892
		// (get) Token: 0x0600F3BD RID: 62397 RVA: 0x00238E9A File Offset: 0x0023709A
		public virtual string GuidancePath
		{
			get
			{
				return this.Instance.GuidancePath;
			}
		}

		// Token: 0x170049CD RID: 18893
		// (get) Token: 0x0600F3BE RID: 62398 RVA: 0x00238EA7 File Offset: 0x002370A7
		public virtual string MusicScorePath
		{
			get
			{
				return this.Instance.MusicScorePath;
			}
		}

		// Token: 0x170049CE RID: 18894
		// (get) Token: 0x0600F3BF RID: 62399 RVA: 0x00238EB4 File Offset: 0x002370B4
		public virtual string NoteSequence
		{
			get
			{
				return this.Instance.NoteSequence;
			}
		}

		// Token: 0x170049CF RID: 18895
		// (get) Token: 0x0600F3C0 RID: 62400 RVA: 0x00238EC1 File Offset: 0x002370C1
		public virtual string CompleteMusic
		{
			get
			{
				return this.Instance.CompleteMusic;
			}
		}

		// Token: 0x170049D0 RID: 18896
		// (get) Token: 0x0600F3C1 RID: 62401 RVA: 0x00238ECE File Offset: 0x002370CE
		[Nullable(0)]
		public virtual ITuningStandGridBoard BoardConfig
		{
			[NullableContext(0)]
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

		// Token: 0x040085AD RID: 34221
		private ITuningStand Instance;

		// Token: 0x040085AE RID: 34222
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ITuningStandBubbleConfig> _BubbleConfigCache;

		// Token: 0x040085AF RID: 34223
		private bool _BubbleConfigInited;

		// Token: 0x040085B0 RID: 34224
		private ITuningStandGridBoard _BoardConfigCache;

		// Token: 0x040085B1 RID: 34225
		private bool _BoardConfigInited;
	}
}
