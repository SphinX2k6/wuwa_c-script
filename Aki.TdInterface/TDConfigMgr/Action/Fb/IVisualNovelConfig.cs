using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025CA RID: 9674
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelConfig
	{
		// Token: 0x0600D976 RID: 55670 RVA: 0x00206E96 File Offset: 0x00205096
		[NullableContext(1)]
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

		// Token: 0x17003FA4 RID: 16292
		// (get) Token: 0x0600D977 RID: 55671 RVA: 0x00206EB8 File Offset: 0x002050B8
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

		// Token: 0x17003FA5 RID: 16293
		// (get) Token: 0x0600D978 RID: 55672 RVA: 0x00206EF0 File Offset: 0x002050F0
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

		// Token: 0x17003FA6 RID: 16294
		// (get) Token: 0x0600D979 RID: 55673 RVA: 0x00206F28 File Offset: 0x00205128
		public virtual bool? HideControlUi
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HideControlUi);
			}
		}

		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x0600D97A RID: 55674 RVA: 0x00206F60 File Offset: 0x00205160
		public virtual int? InitialBackgroundId
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.InitialBackgroundId);
			}
		}

		// Token: 0x17003FA8 RID: 16296
		// (get) Token: 0x0600D97B RID: 55675 RVA: 0x00206F96 File Offset: 0x00205196
		public virtual string InitialAudioEvent
		{
			get
			{
				return this.Instance.InitialAudioEvent;
			}
		}

		// Token: 0x17003FA9 RID: 16297
		// (get) Token: 0x0600D97C RID: 55676 RVA: 0x00206FA3 File Offset: 0x002051A3
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

		// Token: 0x040078C2 RID: 30914
		private IVisualNovelConfig Instance;

		// Token: 0x040078C3 RID: 30915
		private ISolarSchoolTime _InitialTimeCache;

		// Token: 0x040078C4 RID: 30916
		private bool _InitialTimeInited;
	}
}
