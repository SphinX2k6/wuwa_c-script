using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000ED0 RID: 3792
	[NullableContext(1)]
	[Nullable(0)]
	public class IAtomicProcessBase
	{
		// Token: 0x060053B8 RID: 21432 RVA: 0x000CDD80 File Offset: 0x000CBF80
		private IAtomicProcessBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAtomicProcessBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAtomicProcessBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAtomicProcessBase_SetValue());
			}
			return result;
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x000CDDB8 File Offset: 0x000CBFB8
		public static IAtomicProcessBase Create([Nullable(2)] IAtomicProcessBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAtomicProcessBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x000CDDCB File Offset: 0x000CBFCB
		public static IAtomicProcessBase CreateFromSetValue([Nullable(2)] IAtomicProcessBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAtomicProcessBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x000CDDDE File Offset: 0x000CBFDE
		public IAtomicProcessBase_SetValue ToSetValue()
		{
			return new IAtomicProcessBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x060053BC RID: 21436 RVA: 0x000CDDF1 File Offset: 0x000CBFF1
		// (set) Token: 0x060053BD RID: 21437 RVA: 0x000CDE1C File Offset: 0x000CC01C
		public virtual EAtomicProcess Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAtomicProcess.StoveCoreFall;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040032B3 RID: 12979
		[Nullable(2)]
		protected IAtomicProcessBase FbInstance;

		// Token: 0x040032B4 RID: 12980
		[Nullable(2)]
		protected IAtomicProcessBase_SetValue PocoInterface;
	}
}
