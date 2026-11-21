using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CFF RID: 7423
	public class IInteractOptionConfirmBox
	{
		// Token: 0x06009DA3 RID: 40355 RVA: 0x0016AEEC File Offset: 0x001690EC
		private IInteractOptionConfirmBox_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractOptionConfirmBox 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractOptionConfirmBox_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractOptionConfirmBox_SetValue());
			}
			return result;
		}

		// Token: 0x06009DA4 RID: 40356 RVA: 0x0016AF24 File Offset: 0x00169124
		public static IInteractOptionConfirmBox Create([Nullable(2)] IInteractOptionConfirmBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractOptionConfirmBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DA5 RID: 40357 RVA: 0x0016AF37 File Offset: 0x00169137
		public static IInteractOptionConfirmBox CreateFromSetValue([Nullable(2)] IInteractOptionConfirmBox_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractOptionConfirmBox
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DA6 RID: 40358 RVA: 0x0016AF4A File Offset: 0x0016914A
		public IInteractOptionConfirmBox_SetValue ToSetValue()
		{
			return new IInteractOptionConfirmBox_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x06009DA7 RID: 40359 RVA: 0x0016AF5D File Offset: 0x0016915D
		// (set) Token: 0x06009DA8 RID: 40360 RVA: 0x0016AF84 File Offset: 0x00169184
		public virtual IInteractionConfirmBoxType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				IInteractOptionConfirmBox_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400603E RID: 24638
		[Nullable(2)]
		protected IInteractOptionConfirmBox FbInstance;

		// Token: 0x0400603F RID: 24639
		[Nullable(2)]
		protected IInteractOptionConfirmBox_SetValue PocoInterface;
	}
}
