using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200254B RID: 9547
	[NullableContext(1)]
	[Nullable(0)]
	public class ISystemOptionType
	{
		// Token: 0x0600D518 RID: 54552 RVA: 0x001F9689 File Offset: 0x001F7889
		public static ISystemOptionType Create(ISystemOptionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemOptionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x0600D519 RID: 54553 RVA: 0x001F96A8 File Offset: 0x001F78A8
		public virtual ESystemOptionType Type
		{
			get
			{
				return (ESystemOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x0600D51A RID: 54554 RVA: 0x001F96B8 File Offset: 0x001F78B8
		public virtual List<ISystemOption> SystemOptions
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

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x0600D51B RID: 54555 RVA: 0x001F9724 File Offset: 0x001F7924
		public virtual bool? KeepPreTalkItem
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

		// Token: 0x04007503 RID: 29955
		private ISystemOptionType Instance;

		// Token: 0x04007504 RID: 29956
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04007505 RID: 29957
		private bool _SystemOptionsInited;
	}
}
