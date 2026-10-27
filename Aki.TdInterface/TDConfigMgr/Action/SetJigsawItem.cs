using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C1 RID: 8641
	[NullableContext(1)]
	[Nullable(0)]
	public class SetJigsawItem : ActionParams
	{
		// Token: 0x0600BDC8 RID: 48584 RVA: 0x001B50C4 File Offset: 0x001B32C4
		private SetJigsawItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetJigsawItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetJigsawItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetJigsawItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDC9 RID: 48585 RVA: 0x001B50FC File Offset: 0x001B32FC
		public static SetJigsawItem Create([Nullable(2)] SetJigsawItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetJigsawItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDCA RID: 48586 RVA: 0x001B510F File Offset: 0x001B330F
		public static SetJigsawItem CreateFromSetValue([Nullable(2)] SetJigsawItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetJigsawItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDCB RID: 48587 RVA: 0x001B5122 File Offset: 0x001B3322
		public SetJigsawItem_SetValue ToSetValue()
		{
			return new SetJigsawItem_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0600BDCC RID: 48588 RVA: 0x001B5138 File Offset: 0x001B3338
		// (set) Token: 0x0600BDCD RID: 48589 RVA: 0x001B5199 File Offset: 0x001B3399
		public virtual IMoveJigsawItem Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = IMoveJigsawItem.Create(this.FbInstance.Config);
				}
				else
				{
					SetJigsawItem_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x04007144 RID: 28996
		[Nullable(2)]
		protected new SetJigsawItem FbInstance;

		// Token: 0x04007145 RID: 28997
		[Nullable(2)]
		protected SetJigsawItem_SetValue PocoInterface;

		// Token: 0x04007146 RID: 28998
		private IMoveJigsawItem _ConfigCache;

		// Token: 0x04007147 RID: 28999
		private bool _ConfigInited;
	}
}
