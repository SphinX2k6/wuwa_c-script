using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B28 RID: 11048
	[NullableContext(2)]
	[Nullable(0)]
	public class IAstrologyTextUiConfig : ITextUiConfig
	{
		// Token: 0x0600F303 RID: 62211 RVA: 0x00237B2F File Offset: 0x00235D2F
		[NullableContext(0)]
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

		// Token: 0x17004961 RID: 18785
		// (get) Token: 0x0600F304 RID: 62212 RVA: 0x00237B4E File Offset: 0x00235D4E
		public override ETextUiType Type
		{
			get
			{
				return (ETextUiType)this.Instance.Type;
			}
		}

		// Token: 0x17004962 RID: 18786
		// (get) Token: 0x0600F305 RID: 62213 RVA: 0x00237B5B File Offset: 0x00235D5B
		public override string InitTipText
		{
			get
			{
				return this.Instance.InitTipText;
			}
		}

		// Token: 0x17004963 RID: 18787
		// (get) Token: 0x0600F306 RID: 62214 RVA: 0x00237B68 File Offset: 0x00235D68
		public override string ProgressTipText
		{
			get
			{
				return this.Instance.ProgressTipText;
			}
		}

		// Token: 0x17004964 RID: 18788
		// (get) Token: 0x0600F307 RID: 62215 RVA: 0x00237B75 File Offset: 0x00235D75
		public override string SkipText
		{
			get
			{
				return this.Instance.SkipText;
			}
		}

		// Token: 0x17004965 RID: 18789
		// (get) Token: 0x0600F308 RID: 62216 RVA: 0x00237B82 File Offset: 0x00235D82
		public override string FinishText
		{
			get
			{
				return this.Instance.FinishText;
			}
		}

		// Token: 0x17004966 RID: 18790
		// (get) Token: 0x0600F309 RID: 62217 RVA: 0x00237B90 File Offset: 0x00235D90
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<string> InitDialogues
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

		// Token: 0x17004967 RID: 18791
		// (get) Token: 0x0600F30A RID: 62218 RVA: 0x00237C08 File Offset: 0x00235E08
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

		// Token: 0x17004968 RID: 18792
		// (get) Token: 0x0600F30B RID: 62219 RVA: 0x00237C3E File Offset: 0x00235E3E
		public override string LoopAudioEvent
		{
			get
			{
				return this.Instance.LoopAudioEvent;
			}
		}

		// Token: 0x0400855A RID: 34138
		private IAstrologyTextUiConfig Instance;

		// Token: 0x0400855B RID: 34139
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _InitDialoguesCache;

		// Token: 0x0400855C RID: 34140
		private bool _InitDialoguesInited;
	}
}
