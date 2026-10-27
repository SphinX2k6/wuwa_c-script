using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000400 RID: 1024
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupFinishDestroy : IGroupFinishConfig
	{
		// Token: 0x060014A7 RID: 5287 RVA: 0x00041BE8 File Offset: 0x0003FDE8
		private IGroupFinishDestroy_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupFinishDestroy 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupFinishDestroy_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupFinishDestroy_SetValue());
			}
			return result;
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00041C20 File Offset: 0x0003FE20
		public static IGroupFinishDestroy Create([Nullable(2)] IGroupFinishDestroy instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupFinishDestroy
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00041C33 File Offset: 0x0003FE33
		public static IGroupFinishDestroy CreateFromSetValue([Nullable(2)] IGroupFinishDestroy_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupFinishDestroy
			{
				PocoInterface = value
			};
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00041C46 File Offset: 0x0003FE46
		public new IGroupFinishDestroy_SetValue ToSetValue()
		{
			return new IGroupFinishDestroy_SetValue
			{
				Type = this.Type,
				SwitchSpecifiedStatus = this.SwitchSpecifiedStatus
			};
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x00041C65 File Offset: 0x0003FE65
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x00041C90 File Offset: 0x0003FE90
		public override EGroupFinishConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupFinishConfig.Silence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x00041CA0 File Offset: 0x0003FEA0
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x00041D01 File Offset: 0x0003FF01
		[Nullable(2)]
		public virtual IEntityState SwitchSpecifiedStatus
		{
			[NullableContext(2)]
			get
			{
				if (this._SwitchSpecifiedStatusInited)
				{
					return this._SwitchSpecifiedStatusCache;
				}
				this._SwitchSpecifiedStatusInited = true;
				if (this.FbInstance != null)
				{
					this._SwitchSpecifiedStatusCache = IEntityState.Create(this.FbInstance.SwitchSpecifiedStatus);
				}
				else
				{
					IGroupFinishDestroy_SetValue pocoInterface = this.PocoInterface;
					this._SwitchSpecifiedStatusCache = ((pocoInterface != null) ? pocoInterface.SwitchSpecifiedStatus : null);
				}
				return this._SwitchSpecifiedStatusCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SwitchSpecifiedStatus = value;
				this._SwitchSpecifiedStatusInited = false;
			}
		}

		// Token: 0x04001030 RID: 4144
		[Nullable(2)]
		protected new IGroupFinishDestroy FbInstance;

		// Token: 0x04001031 RID: 4145
		[Nullable(2)]
		protected new IGroupFinishDestroy_SetValue PocoInterface;

		// Token: 0x04001032 RID: 4146
		private IEntityState _SwitchSpecifiedStatusCache;

		// Token: 0x04001033 RID: 4147
		private bool _SwitchSpecifiedStatusInited;
	}
}
