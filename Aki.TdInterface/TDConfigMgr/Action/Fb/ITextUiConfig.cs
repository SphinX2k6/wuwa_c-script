using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B27 RID: 11047
	[NullableContext(2)]
	[Nullable(0)]
	public class ITextUiConfig
	{
		// Token: 0x0600F2F9 RID: 62201 RVA: 0x00237A0B File Offset: 0x00235C0B
		[NullableContext(0)]
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

		// Token: 0x17004959 RID: 18777
		// (get) Token: 0x0600F2FA RID: 62202 RVA: 0x00237A2A File Offset: 0x00235C2A
		public virtual ETextUiType Type
		{
			get
			{
				return (ETextUiType)this.Instance.Type;
			}
		}

		// Token: 0x1700495A RID: 18778
		// (get) Token: 0x0600F2FB RID: 62203 RVA: 0x00237A37 File Offset: 0x00235C37
		public virtual string InitTipText
		{
			get
			{
				return this.Instance.InitTipText;
			}
		}

		// Token: 0x1700495B RID: 18779
		// (get) Token: 0x0600F2FC RID: 62204 RVA: 0x00237A44 File Offset: 0x00235C44
		public virtual string ProgressTipText
		{
			get
			{
				return this.Instance.ProgressTipText;
			}
		}

		// Token: 0x1700495C RID: 18780
		// (get) Token: 0x0600F2FD RID: 62205 RVA: 0x00237A51 File Offset: 0x00235C51
		public virtual string SkipText
		{
			get
			{
				return this.Instance.SkipText;
			}
		}

		// Token: 0x1700495D RID: 18781
		// (get) Token: 0x0600F2FE RID: 62206 RVA: 0x00237A5E File Offset: 0x00235C5E
		public virtual string FinishText
		{
			get
			{
				return this.Instance.FinishText;
			}
		}

		// Token: 0x1700495E RID: 18782
		// (get) Token: 0x0600F2FF RID: 62207 RVA: 0x00237A6C File Offset: 0x00235C6C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> InitDialogues
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x1700495F RID: 18783
		// (get) Token: 0x0600F300 RID: 62208 RVA: 0x00237AE4 File Offset: 0x00235CE4
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

		// Token: 0x17004960 RID: 18784
		// (get) Token: 0x0600F301 RID: 62209 RVA: 0x00237B1A File Offset: 0x00235D1A
		public virtual string LoopAudioEvent
		{
			get
			{
				return this.Instance.LoopAudioEvent;
			}
		}

		// Token: 0x04008557 RID: 34135
		private ITextUiConfig Instance;

		// Token: 0x04008558 RID: 34136
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _InitDialoguesCache;

		// Token: 0x04008559 RID: 34137
		private bool _InitDialoguesInited;
	}
}
