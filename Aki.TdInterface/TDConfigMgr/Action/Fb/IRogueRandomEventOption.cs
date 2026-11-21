using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F4 RID: 10228
	public class IRogueRandomEventOption : ISystemOptionType
	{
		// Token: 0x0600E281 RID: 57985 RVA: 0x00215222 File Offset: 0x00213422
		public static IRogueRandomEventOption Create(IRogueRandomEventOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueRandomEventOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x0600E282 RID: 57986 RVA: 0x00215241 File Offset: 0x00213441
		public override ESystemOptionType Type
		{
			get
			{
				return (ESystemOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x0600E283 RID: 57987 RVA: 0x00215250 File Offset: 0x00213450
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

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x0600E284 RID: 57988 RVA: 0x002152BC File Offset: 0x002134BC
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

		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x0600E285 RID: 57989 RVA: 0x002152F2 File Offset: 0x002134F2
		public virtual int EventId
		{
			get
			{
				return this.Instance.EventId;
			}
		}

		// Token: 0x04007B5E RID: 31582
		private IRogueRandomEventOption Instance;

		// Token: 0x04007B5F RID: 31583
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04007B60 RID: 31584
		private bool _SystemOptionsInited;
	}
}
