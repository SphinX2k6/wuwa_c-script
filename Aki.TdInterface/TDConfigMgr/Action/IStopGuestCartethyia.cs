using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020F6 RID: 8438
	public class IStopGuestCartethyia : IStopGuestUiAnimationType
	{
		// Token: 0x0600B34C RID: 45900 RVA: 0x001926AC File Offset: 0x001908AC
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

		// Token: 0x0600B34D RID: 45901 RVA: 0x001926E4 File Offset: 0x001908E4
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

		// Token: 0x0600B34E RID: 45902 RVA: 0x001926F7 File Offset: 0x001908F7
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

		// Token: 0x0600B34F RID: 45903 RVA: 0x0019270A File Offset: 0x0019090A
		public new IStopGuestCartethyia_SetValue ToSetValue()
		{
			return new IStopGuestCartethyia_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x0600B350 RID: 45904 RVA: 0x0019271D File Offset: 0x0019091D
		// (set) Token: 0x0600B351 RID: 45905 RVA: 0x00192748 File Offset: 0x00190948
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

		// Token: 0x04006A4F RID: 27215
		[Nullable(2)]
		protected new IStopGuestCartethyia FbInstance;

		// Token: 0x04006A50 RID: 27216
		[Nullable(2)]
		protected new IStopGuestCartethyia_SetValue PocoInterface;
	}
}
