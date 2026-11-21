using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000188 RID: 392
	public class FlowComponent : IComponentBase
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x0001FC4C File Offset: 0x0001DE4C
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

		// Token: 0x060004E5 RID: 1253 RVA: 0x0001FC84 File Offset: 0x0001DE84
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

		// Token: 0x060004E6 RID: 1254 RVA: 0x0001FC97 File Offset: 0x0001DE97
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

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001FCAA File Offset: 0x0001DEAA
		public new FlowComponent_SetValue ToSetValue()
		{
			return new FlowComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				InitState = this.InitState
			};
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0001FCD8 File Offset: 0x0001DED8
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x0001FD12 File Offset: 0x0001DF12
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

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x0001FD20 File Offset: 0x0001DF20
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x0001FD4A File Offset: 0x0001DF4A
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

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0001FD58 File Offset: 0x0001DF58
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x0001FDB9 File Offset: 0x0001DFB9
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

		// Token: 0x04000760 RID: 1888
		[Nullable(2)]
		protected new FlowComponent FbInstance;

		// Token: 0x04000761 RID: 1889
		[Nullable(2)]
		protected new FlowComponent_SetValue PocoInterface;

		// Token: 0x04000762 RID: 1890
		private PlayFlow _InitStateCache;

		// Token: 0x04000763 RID: 1891
		private bool _InitStateInited;
	}
}
