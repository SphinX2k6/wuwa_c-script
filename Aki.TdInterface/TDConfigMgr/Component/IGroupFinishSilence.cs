using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200045B RID: 1115
	public class IGroupFinishSilence : IGroupFinishConfig
	{
		// Token: 0x0600164B RID: 5707 RVA: 0x00045A70 File Offset: 0x00043C70
		private IGroupFinishSilence_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupFinishSilence 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupFinishSilence_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupFinishSilence_SetValue());
			}
			return result;
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00045AA8 File Offset: 0x00043CA8
		public static IGroupFinishSilence Create([Nullable(2)] IGroupFinishSilence instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupFinishSilence
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00045ABB File Offset: 0x00043CBB
		public static IGroupFinishSilence CreateFromSetValue([Nullable(2)] IGroupFinishSilence_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupFinishSilence
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00045ACE File Offset: 0x00043CCE
		public new IGroupFinishSilence_SetValue ToSetValue()
		{
			return new IGroupFinishSilence_SetValue
			{
				Type = this.Type,
				SwitchSpecifiedStatus = this.SwitchSpecifiedStatus
			};
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x00045AED File Offset: 0x00043CED
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x00045B18 File Offset: 0x00043D18
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

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x00045B28 File Offset: 0x00043D28
		// (set) Token: 0x06001652 RID: 5714 RVA: 0x00045B89 File Offset: 0x00043D89
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
					IGroupFinishSilence_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001158 RID: 4440
		[Nullable(2)]
		protected new IGroupFinishSilence FbInstance;

		// Token: 0x04001159 RID: 4441
		[Nullable(2)]
		protected new IGroupFinishSilence_SetValue PocoInterface;

		// Token: 0x0400115A RID: 4442
		private IEntityState _SwitchSpecifiedStatusCache;

		// Token: 0x0400115B RID: 4443
		private bool _SwitchSpecifiedStatusInited;
	}
}
