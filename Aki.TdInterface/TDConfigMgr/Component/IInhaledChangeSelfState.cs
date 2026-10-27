using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200045C RID: 1116
	[NullableContext(1)]
	[Nullable(0)]
	public class IInhaledChangeSelfState : IInhaledPerResultType
	{
		// Token: 0x0600168D RID: 5773 RVA: 0x00045760 File Offset: 0x00043960
		private IInhaledChangeSelfState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInhaledChangeSelfState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInhaledChangeSelfState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInhaledChangeSelfState_SetValue());
			}
			return result;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00045798 File Offset: 0x00043998
		public static IInhaledChangeSelfState Create([Nullable(2)] IInhaledChangeSelfState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledChangeSelfState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000457AB File Offset: 0x000439AB
		public static IInhaledChangeSelfState CreateFromSetValue([Nullable(2)] IInhaledChangeSelfState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInhaledChangeSelfState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000457BE File Offset: 0x000439BE
		public new IInhaledChangeSelfState_SetValue ToSetValue()
		{
			return new IInhaledChangeSelfState_SetValue
			{
				Type = this.Type,
				ChangeSelfState = this.ChangeSelfState
			};
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x000457DD File Offset: 0x000439DD
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x00045808 File Offset: 0x00043A08
		public override EInhaledPerResultType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInhaledPerResultType.DestroySelf;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00045816 File Offset: 0x00043A16
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x00045841 File Offset: 0x00043A41
		public virtual string ChangeSelfState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSelfState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ChangeSelfState;
			}
			set
			{
				this.GetOrCreatePoco().ChangeSelfState = value;
			}
		}

		// Token: 0x0400112D RID: 4397
		[Nullable(2)]
		protected new IInhaledChangeSelfState FbInstance;

		// Token: 0x0400112E RID: 4398
		[Nullable(2)]
		protected new IInhaledChangeSelfState_SetValue PocoInterface;
	}
}
