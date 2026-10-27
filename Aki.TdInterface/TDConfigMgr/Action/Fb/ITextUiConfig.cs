using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002854 RID: 10324
	[NullableContext(2)]
	[Nullable(0)]
	public class ITextUiConfig
	{
		// Token: 0x0600E4D4 RID: 58580 RVA: 0x0021ABA7 File Offset: 0x00218DA7
		[NullableContext(1)]
		public static ITextUiConfig Create(ITextUiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITextUiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045EE RID: 17902
		// (get) Token: 0x0600E4D5 RID: 58581 RVA: 0x0021ABC6 File Offset: 0x00218DC6
		public virtual ETextUiType Type
		{
			get
			{
				return (ETextUiType)this.Instance.Type;
			}
		}

		// Token: 0x170045EF RID: 17903
		// (get) Token: 0x0600E4D6 RID: 58582 RVA: 0x0021ABD3 File Offset: 0x00218DD3
		public virtual string InitTipText
		{
			get
			{
				return this.Instance.InitTipText;
			}
		}

		// Token: 0x170045F0 RID: 17904
		// (get) Token: 0x0600E4D7 RID: 58583 RVA: 0x0021ABE0 File Offset: 0x00218DE0
		public virtual string ProgressTipText
		{
			get
			{
				return this.Instance.ProgressTipText;
			}
		}

		// Token: 0x170045F1 RID: 17905
		// (get) Token: 0x0600E4D8 RID: 58584 RVA: 0x0021ABED File Offset: 0x00218DED
		public virtual string SkipText
		{
			get
			{
				return this.Instance.SkipText;
			}
		}

		// Token: 0x170045F2 RID: 17906
		// (get) Token: 0x0600E4D9 RID: 58585 RVA: 0x0021ABFA File Offset: 0x00218DFA
		public virtual string FinishText
		{
			get
			{
				return this.Instance.FinishText;
			}
		}

		// Token: 0x170045F3 RID: 17907
		// (get) Token: 0x0600E4DA RID: 58586 RVA: 0x0021AC08 File Offset: 0x00218E08
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> InitDialogues
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._InitDialoguesInited)
				{
					return this._InitDialoguesCache;
				}
				this._InitDialoguesInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int initDialoguesLength = this.Instance.InitDialoguesLength;
				this._InitDialoguesCache = new List<string>(initDialoguesLength);
				for (int i = 0; i < initDialoguesLength; i++)
				{
					this._InitDialoguesCache.Add(this.Instance.InitDialogues(i));
				}
				return this._InitDialoguesCache;
			}
		}

		// Token: 0x170045F4 RID: 17908
		// (get) Token: 0x0600E4DB RID: 58587 RVA: 0x0021AC80 File Offset: 0x00218E80
		public virtual int? SkipConfirmBoxId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SkipConfirmBoxId);
			}
		}

		// Token: 0x170045F5 RID: 17909
		// (get) Token: 0x0600E4DC RID: 58588 RVA: 0x0021ACB6 File Offset: 0x00218EB6
		public virtual string LoopAudioEvent
		{
			get
			{
				return this.Instance.LoopAudioEvent;
			}
		}

		// Token: 0x04007E9A RID: 32410
		private ITextUiConfig Instance;

		// Token: 0x04007E9B RID: 32411
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _InitDialoguesCache;

		// Token: 0x04007E9C RID: 32412
		private bool _InitDialoguesInited;
	}
}
