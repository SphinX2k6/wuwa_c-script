using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F5 RID: 10229
	public class IPermanentRogueRandomEvent : ISystemOptionType
	{
		// Token: 0x0600E287 RID: 57991 RVA: 0x00215307 File Offset: 0x00213507
		public static IPermanentRogueRandomEvent Create(IPermanentRogueRandomEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPermanentRogueRandomEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x0600E288 RID: 57992 RVA: 0x00215326 File Offset: 0x00213526
		public override ESystemOptionType Type
		{
			get
			{
				return (ESystemOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x0600E289 RID: 57993 RVA: 0x00215334 File Offset: 0x00213534
		public override List<ISystemOption> SystemOptions
		{
			get
			{
				if (this._SystemOptionsInited)
				{
					return this._SystemOptionsCache;
				}
				this._SystemOptionsInited = true;
				int systemOptionsLength = this.Instance.SystemOptionsLength;
				this._SystemOptionsCache = new List<ISystemOption>(systemOptionsLength);
				for (int i = 0; i < systemOptionsLength; i++)
				{
					this._SystemOptionsCache.Add(ISystemOption.Create(this.Instance.SystemOptions(i)));
				}
				return this._SystemOptionsCache;
			}
		}

		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x0600E28A RID: 57994 RVA: 0x002153A0 File Offset: 0x002135A0
		public override bool? KeepPreTalkItem
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepPreTalkItem);
			}
		}

		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x0600E28B RID: 57995 RVA: 0x002153D6 File Offset: 0x002135D6
		public virtual int EventId
		{
			get
			{
				return this.Instance.EventId;
			}
		}

		// Token: 0x04007B61 RID: 31585
		private IPermanentRogueRandomEvent Instance;

		// Token: 0x04007B62 RID: 31586
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04007B63 RID: 31587
		private bool _SystemOptionsInited;
	}
}
