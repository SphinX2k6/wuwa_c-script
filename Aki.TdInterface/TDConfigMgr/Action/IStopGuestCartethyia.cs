using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EBD RID: 7869
	[NullableContext(1)]
	[Nullable(0)]
	public class IStopGuestCartethyia : IStopGuestUiAnimationType
	{
		// Token: 0x0600A87A RID: 43130 RVA: 0x0017C6B4 File Offset: 0x0017A8B4
		private IStopGuestCartethyia_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStopGuestCartethyia 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStopGuestCartethyia_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStopGuestCartethyia_SetValue());
			}
			return result;
		}

		// Token: 0x0600A87B RID: 43131 RVA: 0x0017C6EC File Offset: 0x0017A8EC
		public static IStopGuestCartethyia Create([Nullable(2)] IStopGuestCartethyia instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopGuestCartethyia
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A87C RID: 43132 RVA: 0x0017C6FF File Offset: 0x0017A8FF
		public static IStopGuestCartethyia CreateFromSetValue([Nullable(2)] IStopGuestCartethyia_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStopGuestCartethyia
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A87D RID: 43133 RVA: 0x0017C712 File Offset: 0x0017A912
		public new IStopGuestCartethyia_SetValue ToSetValue()
		{
			return new IStopGuestCartethyia_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600A87E RID: 43134 RVA: 0x0017C725 File Offset: 0x0017A925
		// (set) Token: 0x0600A87F RID: 43135 RVA: 0x0017C750 File Offset: 0x0017A950
		public override EGuestUiAnimationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGuestUiAnimationType.GuestCartethyia;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006460 RID: 25696
		[Nullable(2)]
		protected new IStopGuestCartethyia FbInstance;

		// Token: 0x04006461 RID: 25697
		[Nullable(2)]
		protected new IStopGuestCartethyia_SetValue PocoInterface;
	}
}
