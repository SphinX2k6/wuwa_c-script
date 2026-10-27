using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D10 RID: 7440
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayGuestCartethyia : IPlayGuestUiAnimationType
	{
		// Token: 0x06009FA1 RID: 40865 RVA: 0x0016C884 File Offset: 0x0016AA84
		private IPlayGuestCartethyia_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayGuestCartethyia 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayGuestCartethyia_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayGuestCartethyia_SetValue());
			}
			return result;
		}

		// Token: 0x06009FA2 RID: 40866 RVA: 0x0016C8BC File Offset: 0x0016AABC
		public static IPlayGuestCartethyia Create([Nullable(2)] IPlayGuestCartethyia instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayGuestCartethyia
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FA3 RID: 40867 RVA: 0x0016C8CF File Offset: 0x0016AACF
		public static IPlayGuestCartethyia CreateFromSetValue([Nullable(2)] IPlayGuestCartethyia_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayGuestCartethyia
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FA4 RID: 40868 RVA: 0x0016C8E2 File Offset: 0x0016AAE2
		public new IPlayGuestCartethyia_SetValue ToSetValue()
		{
			return new IPlayGuestCartethyia_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x06009FA5 RID: 40869 RVA: 0x0016C8F5 File Offset: 0x0016AAF5
		// (set) Token: 0x06009FA6 RID: 40870 RVA: 0x0016C920 File Offset: 0x0016AB20
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

		// Token: 0x04006050 RID: 24656
		[Nullable(2)]
		protected new IPlayGuestCartethyia FbInstance;

		// Token: 0x04006051 RID: 24657
		[Nullable(2)]
		protected new IPlayGuestCartethyia_SetValue PocoInterface;
	}
}
