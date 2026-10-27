using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200254C RID: 9548
	[NullableContext(1)]
	[Nullable(0)]
	public class IRogueRandomEventOption : ISystemOptionType
	{
		// Token: 0x0600D51D RID: 54557 RVA: 0x001F9762 File Offset: 0x001F7962
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

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x0600D51E RID: 54558 RVA: 0x001F9781 File Offset: 0x001F7981
		public override ESystemOptionType Type
		{
			get
			{
				return (ESystemOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x0600D51F RID: 54559 RVA: 0x001F9790 File Offset: 0x001F7990
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

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x0600D520 RID: 54560 RVA: 0x001F97FC File Offset: 0x001F79FC
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

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x0600D521 RID: 54561 RVA: 0x001F9832 File Offset: 0x001F7A32
		public virtual int EventId
		{
			get
			{
				return this.Instance.EventId;
			}
		}

		// Token: 0x04007506 RID: 29958
		private IRogueRandomEventOption Instance;

		// Token: 0x04007507 RID: 29959
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04007508 RID: 29960
		private bool _SystemOptionsInited;
	}
}
