using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000173 RID: 371
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowComponent : IComponentBase
	{
		// Token: 0x060004E0 RID: 1248 RVA: 0x0001F2D8 File Offset: 0x0001D4D8
		private FlowComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FlowComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FlowComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FlowComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001F310 File Offset: 0x0001D510
		public static FlowComponent Create([Nullable(2)] FlowComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FlowComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001F323 File Offset: 0x0001D523
		public static FlowComponent CreateFromSetValue([Nullable(2)] FlowComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FlowComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001F336 File Offset: 0x0001D536
		public new FlowComponent_SetValue ToSetValue()
		{
			return new FlowComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				InitState = this.InitState
			};
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0001F364 File Offset: 0x0001D564
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0001F39E File Offset: 0x0001D59E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				FlowComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0001F3AC File Offset: 0x0001D5AC
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x0001F3D6 File Offset: 0x0001D5D6
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0001F3E4 File Offset: 0x0001D5E4
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x0001F445 File Offset: 0x0001D645
		public virtual PlayFlow InitState
		{
			get
			{
				if (this._InitStateInited)
				{
					return this._InitStateCache;
				}
				this._InitStateInited = true;
				if (this.FbInstance != null)
				{
					this._InitStateCache = PlayFlow.Create(this.FbInstance.InitState);
				}
				else
				{
					FlowComponent_SetValue pocoInterface = this.PocoInterface;
					this._InitStateCache = ((pocoInterface != null) ? pocoInterface.InitState : null);
				}
				return this._InitStateCache;
			}
			set
			{
				this.GetOrCreatePoco().InitState = value;
				this._InitStateInited = false;
			}
		}

		// Token: 0x04000713 RID: 1811
		[Nullable(2)]
		protected new FlowComponent FbInstance;

		// Token: 0x04000714 RID: 1812
		[Nullable(2)]
		protected new FlowComponent_SetValue PocoInterface;

		// Token: 0x04000715 RID: 1813
		private PlayFlow _InitStateCache;

		// Token: 0x04000716 RID: 1814
		private bool _InitStateInited;
	}
}
