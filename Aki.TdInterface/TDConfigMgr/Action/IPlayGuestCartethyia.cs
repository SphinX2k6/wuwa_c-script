using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F21 RID: 7969
	public class IPlayGuestCartethyia : IPlayGuestUiAnimationType
	{
		// Token: 0x0600A98D RID: 43405 RVA: 0x00180CA8 File Offset: 0x0017EEA8
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

		// Token: 0x0600A98E RID: 43406 RVA: 0x00180CE0 File Offset: 0x0017EEE0
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

		// Token: 0x0600A98F RID: 43407 RVA: 0x00180CF3 File Offset: 0x0017EEF3
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

		// Token: 0x0600A990 RID: 43408 RVA: 0x00180D06 File Offset: 0x0017EF06
		public new IPlayGuestCartethyia_SetValue ToSetValue()
		{
			return new IPlayGuestCartethyia_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600A991 RID: 43409 RVA: 0x00180D19 File Offset: 0x0017EF19
		// (set) Token: 0x0600A992 RID: 43410 RVA: 0x00180D44 File Offset: 0x0017EF44
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

		// Token: 0x040065CC RID: 26060
		[Nullable(2)]
		protected new IPlayGuestCartethyia FbInstance;

		// Token: 0x040065CD RID: 26061
		[Nullable(2)]
		protected new IPlayGuestCartethyia_SetValue PocoInterface;
	}
}
