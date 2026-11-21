using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CA4 RID: 7332
	public class IHeadStyleWeakSignal : IHeadStyle
	{
		// Token: 0x06009BB8 RID: 39864 RVA: 0x00167814 File Offset: 0x00165A14
		private IHeadStyleWeakSignal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyleWeakSignal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyleWeakSignal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyleWeakSignal_SetValue());
			}
			return result;
		}

		// Token: 0x06009BB9 RID: 39865 RVA: 0x0016784C File Offset: 0x00165A4C
		public static IHeadStyleWeakSignal Create([Nullable(2)] IHeadStyleWeakSignal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleWeakSignal
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BBA RID: 39866 RVA: 0x0016785F File Offset: 0x00165A5F
		public static IHeadStyleWeakSignal CreateFromSetValue([Nullable(2)] IHeadStyleWeakSignal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyleWeakSignal
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BBB RID: 39867 RVA: 0x00167872 File Offset: 0x00165A72
		public new IHeadStyleWeakSignal_SetValue ToSetValue()
		{
			return new IHeadStyleWeakSignal_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x06009BBC RID: 39868 RVA: 0x00167885 File Offset: 0x00165A85
		// (set) Token: 0x06009BBD RID: 39869 RVA: 0x001678B0 File Offset: 0x00165AB0
		public override EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F5C RID: 24412
		[Nullable(2)]
		protected new IHeadStyleWeakSignal FbInstance;

		// Token: 0x04005F5D RID: 24413
		[Nullable(2)]
		protected new IHeadStyleWeakSignal_SetValue PocoInterface;
	}
}
