using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200136C RID: 4972
	[NullableContext(1)]
	[Nullable(0)]
	public class IAddInteractOption
	{
		// Token: 0x060071C2 RID: 29122 RVA: 0x00111EE0 File Offset: 0x001100E0
		public static IAddInteractOption Create(IAddInteractOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddInteractOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x060071C3 RID: 29123 RVA: 0x00111EFF File Offset: 0x001100FF
		public virtual IInteractOption Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IInteractOption.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x060071C4 RID: 29124 RVA: 0x00111F33 File Offset: 0x00110133
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x060071C5 RID: 29125 RVA: 0x00111F40 File Offset: 0x00110140
		public virtual bool? IsManualFinish
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsManualFinish);
			}
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x060071C6 RID: 29126 RVA: 0x00111F78 File Offset: 0x00110178
		public virtual bool? IsManualDelete
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsManualDelete);
			}
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x060071C7 RID: 29127 RVA: 0x00111FAE File Offset: 0x001101AE
		[Nullable(2)]
		public virtual string InteractToken
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.InteractToken;
			}
		}

		// Token: 0x040041B6 RID: 16822
		private IAddInteractOption Instance;

		// Token: 0x040041B7 RID: 16823
		[Nullable(2)]
		private IInteractOption _OptionCache;

		// Token: 0x040041B8 RID: 16824
		private bool _OptionInited;
	}
}
