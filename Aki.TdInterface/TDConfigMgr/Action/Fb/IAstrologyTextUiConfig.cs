using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002855 RID: 10325
	[NullableContext(2)]
	[Nullable(0)]
	public class IAstrologyTextUiConfig : ITextUiConfig
	{
		// Token: 0x0600E4DE RID: 58590 RVA: 0x0021ACCB File Offset: 0x00218ECB
		[NullableContext(1)]
		public static IAstrologyTextUiConfig Create(IAstrologyTextUiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAstrologyTextUiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045F6 RID: 17910
		// (get) Token: 0x0600E4DF RID: 58591 RVA: 0x0021ACEA File Offset: 0x00218EEA
		public override ETextUiType Type
		{
			get
			{
				return (ETextUiType)this.Instance.Type;
			}
		}

		// Token: 0x170045F7 RID: 17911
		// (get) Token: 0x0600E4E0 RID: 58592 RVA: 0x0021ACF7 File Offset: 0x00218EF7
		public override string InitTipText
		{
			get
			{
				return this.Instance.InitTipText;
			}
		}

		// Token: 0x170045F8 RID: 17912
		// (get) Token: 0x0600E4E1 RID: 58593 RVA: 0x0021AD04 File Offset: 0x00218F04
		public override string ProgressTipText
		{
			get
			{
				return this.Instance.ProgressTipText;
			}
		}

		// Token: 0x170045F9 RID: 17913
		// (get) Token: 0x0600E4E2 RID: 58594 RVA: 0x0021AD11 File Offset: 0x00218F11
		public override string SkipText
		{
			get
			{
				return this.Instance.SkipText;
			}
		}

		// Token: 0x170045FA RID: 17914
		// (get) Token: 0x0600E4E3 RID: 58595 RVA: 0x0021AD1E File Offset: 0x00218F1E
		public override string FinishText
		{
			get
			{
				return this.Instance.FinishText;
			}
		}

		// Token: 0x170045FB RID: 17915
		// (get) Token: 0x0600E4E4 RID: 58596 RVA: 0x0021AD2C File Offset: 0x00218F2C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> InitDialogues
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

		// Token: 0x170045FC RID: 17916
		// (get) Token: 0x0600E4E5 RID: 58597 RVA: 0x0021ADA4 File Offset: 0x00218FA4
		public override int? SkipConfirmBoxId
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

		// Token: 0x170045FD RID: 17917
		// (get) Token: 0x0600E4E6 RID: 58598 RVA: 0x0021ADDA File Offset: 0x00218FDA
		public override string LoopAudioEvent
		{
			get
			{
				return this.Instance.LoopAudioEvent;
			}
		}

		// Token: 0x04007E9D RID: 32413
		private IAstrologyTextUiConfig Instance;

		// Token: 0x04007E9E RID: 32414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _InitDialoguesCache;

		// Token: 0x04007E9F RID: 32415
		private bool _InitDialoguesInited;
	}
}
