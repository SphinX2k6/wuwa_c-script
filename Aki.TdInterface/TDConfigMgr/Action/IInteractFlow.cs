using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B48 RID: 6984
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractFlow : IInteractType
	{
		// Token: 0x06009575 RID: 38261 RVA: 0x0015985C File Offset: 0x00157A5C
		private IInteractFlow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractFlow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractFlow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractFlow_SetValue());
			}
			return result;
		}

		// Token: 0x06009576 RID: 38262 RVA: 0x00159894 File Offset: 0x00157A94
		public static IInteractFlow Create([Nullable(2)] IInteractFlow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractFlow
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009577 RID: 38263 RVA: 0x001598A7 File Offset: 0x00157AA7
		public static IInteractFlow CreateFromSetValue([Nullable(2)] IInteractFlow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractFlow
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009578 RID: 38264 RVA: 0x001598BA File Offset: 0x00157ABA
		public new IInteractFlow_SetValue ToSetValue()
		{
			return new IInteractFlow_SetValue
			{
				Type = this.Type,
				Flow = this.Flow
			};
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x06009579 RID: 38265 RVA: 0x001598D9 File Offset: 0x00157AD9
		// (set) Token: 0x0600957A RID: 38266 RVA: 0x00159904 File Offset: 0x00157B04
		public override EInteractOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractOption.Flow;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x0600957B RID: 38267 RVA: 0x00159914 File Offset: 0x00157B14
		// (set) Token: 0x0600957C RID: 38268 RVA: 0x00159975 File Offset: 0x00157B75
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = PlayFlow.Create(this.FbInstance.Flow);
				}
				else
				{
					IInteractFlow_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x04005B74 RID: 23412
		[Nullable(2)]
		protected new IInteractFlow FbInstance;

		// Token: 0x04005B75 RID: 23413
		[Nullable(2)]
		protected new IInteractFlow_SetValue PocoInterface;

		// Token: 0x04005B76 RID: 23414
		private PlayFlow _FlowCache;

		// Token: 0x04005B77 RID: 23415
		private bool _FlowInited;
	}
}
