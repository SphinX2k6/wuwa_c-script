using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200254D RID: 9549
	[NullableContext(1)]
	[Nullable(0)]
	public class IPermanentRogueRandomEvent : ISystemOptionType
	{
		// Token: 0x0600D523 RID: 54563 RVA: 0x001F9847 File Offset: 0x001F7A47
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

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x0600D524 RID: 54564 RVA: 0x001F9866 File Offset: 0x001F7A66
		public override ESystemOptionType Type
		{
			get
			{
				return (ESystemOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x0600D525 RID: 54565 RVA: 0x001F9874 File Offset: 0x001F7A74
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

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0600D526 RID: 54566 RVA: 0x001F98E0 File Offset: 0x001F7AE0
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

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0600D527 RID: 54567 RVA: 0x001F9916 File Offset: 0x001F7B16
		public virtual int EventId
		{
			get
			{
				return this.Instance.EventId;
			}
		}

		// Token: 0x04007509 RID: 29961
		private IPermanentRogueRandomEvent Instance;

		// Token: 0x0400750A RID: 29962
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x0400750B RID: 29963
		private bool _SystemOptionsInited;
	}
}
