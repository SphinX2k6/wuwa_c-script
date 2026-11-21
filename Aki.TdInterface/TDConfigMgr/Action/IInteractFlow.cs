using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF7 RID: 7415
	public class IInteractFlow : IInteractType
	{
		// Token: 0x06009D5F RID: 40287 RVA: 0x0016A538 File Offset: 0x00168738
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

		// Token: 0x06009D60 RID: 40288 RVA: 0x0016A570 File Offset: 0x00168770
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

		// Token: 0x06009D61 RID: 40289 RVA: 0x0016A583 File Offset: 0x00168783
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

		// Token: 0x06009D62 RID: 40290 RVA: 0x0016A596 File Offset: 0x00168796
		public new IInteractFlow_SetValue ToSetValue()
		{
			return new IInteractFlow_SetValue
			{
				Type = this.Type,
				Flow = this.Flow
			};
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x06009D63 RID: 40291 RVA: 0x0016A5B5 File Offset: 0x001687B5
		// (set) Token: 0x06009D64 RID: 40292 RVA: 0x0016A5E0 File Offset: 0x001687E0
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

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x06009D65 RID: 40293 RVA: 0x0016A5F0 File Offset: 0x001687F0
		// (set) Token: 0x06009D66 RID: 40294 RVA: 0x0016A651 File Offset: 0x00168851
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

		// Token: 0x04006012 RID: 24594
		[Nullable(2)]
		protected new IInteractFlow FbInstance;

		// Token: 0x04006013 RID: 24595
		[Nullable(2)]
		protected new IInteractFlow_SetValue PocoInterface;

		// Token: 0x04006014 RID: 24596
		private PlayFlow _FlowCache;

		// Token: 0x04006015 RID: 24597
		private bool _FlowInited;
	}
}
