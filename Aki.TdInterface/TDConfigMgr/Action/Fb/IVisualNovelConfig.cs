using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002879 RID: 10361
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelConfig
	{
		// Token: 0x0600E6F0 RID: 59120 RVA: 0x00222B6A File Offset: 0x00220D6A
		[NullableContext(0)]
		public static IVisualNovelConfig Create(IVisualNovelConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x0600E6F1 RID: 59121 RVA: 0x00222B8C File Offset: 0x00220D8C
		public virtual EVisualNovelSubType? VisualNovelSubType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EVisualNovelSubType?((EVisualNovelSubType)this.Instance.VisualNovelSubType);
			}
		}

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x0600E6F2 RID: 59122 RVA: 0x00222BC4 File Offset: 0x00220DC4
		public virtual bool? EnableReadRecord
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableReadRecord);
			}
		}

		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x0600E6F3 RID: 59123 RVA: 0x00222BFC File Offset: 0x00220DFC
		public virtual bool? EnableFastForward
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableFastForward);
			}
		}

		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x0600E6F4 RID: 59124 RVA: 0x00222C34 File Offset: 0x00220E34
		public virtual bool? HideControlUi
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HideControlUi);
			}
		}

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x0600E6F5 RID: 59125 RVA: 0x00222C6C File Offset: 0x00220E6C
		public virtual int? InitialBackgroundId
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new int?(this.Instance.InitialBackgroundId);
			}
		}

		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x0600E6F6 RID: 59126 RVA: 0x00222CA4 File Offset: 0x00220EA4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> InitialAudioEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._InitialAudioEventsInited)
				{
					return this._InitialAudioEventsCache;
				}
				this._InitialAudioEventsInited = true;
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				int initialAudioEventsLength = this.Instance.InitialAudioEventsLength;
				this._InitialAudioEventsCache = new List<string>(initialAudioEventsLength);
				for (int i = 0; i < initialAudioEventsLength; i++)
				{
					this._InitialAudioEventsCache.Add(this.Instance.InitialAudioEvents(i));
				}
				return this._InitialAudioEventsCache;
			}
		}

		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x0600E6F7 RID: 59127 RVA: 0x00222D1A File Offset: 0x00220F1A
		public virtual ISolarSchoolTime InitialTime
		{
			get
			{
				if (this._InitialTimeInited)
				{
					return this._InitialTimeCache;
				}
				this._InitialTimeInited = true;
				this._InitialTimeCache = ISolarSchoolTime.Create(this.Instance.InitialTime);
				return this._InitialTimeCache;
			}
		}

		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x0600E6F8 RID: 59128 RVA: 0x00222D50 File Offset: 0x00220F50
		public virtual float? EndFadeOutTime
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new float?(this.Instance.EndFadeOutTime);
			}
		}

		// Token: 0x04007F29 RID: 32553
		private IVisualNovelConfig Instance;

		// Token: 0x04007F2A RID: 32554
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _InitialAudioEventsCache;

		// Token: 0x04007F2B RID: 32555
		private bool _InitialAudioEventsInited;

		// Token: 0x04007F2C RID: 32556
		private ISolarSchoolTime _InitialTimeCache;

		// Token: 0x04007F2D RID: 32557
		private bool _InitialTimeInited;
	}
}
