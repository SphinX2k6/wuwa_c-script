using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000ED2 RID: 3794
	[NullableContext(1)]
	[Nullable(0)]
	public class IAtomicProcessStoveCoreFall : IAtomicProcessBase
	{
		// Token: 0x060053C0 RID: 21440 RVA: 0x000CDE3C File Offset: 0x000CC03C
		private IAtomicProcessStoveCoreFall_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAtomicProcessStoveCoreFall 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAtomicProcessStoveCoreFall_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAtomicProcessStoveCoreFall_SetValue());
			}
			return result;
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x000CDE74 File Offset: 0x000CC074
		public static IAtomicProcessStoveCoreFall Create([Nullable(2)] IAtomicProcessStoveCoreFall instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAtomicProcessStoveCoreFall
			{
				FbInstance = instance
			};
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x000CDE87 File Offset: 0x000CC087
		public static IAtomicProcessStoveCoreFall CreateFromSetValue([Nullable(2)] IAtomicProcessStoveCoreFall_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAtomicProcessStoveCoreFall
			{
				PocoInterface = value
			};
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x000CDE9A File Offset: 0x000CC09A
		public new IAtomicProcessStoveCoreFall_SetValue ToSetValue()
		{
			return new IAtomicProcessStoveCoreFall_SetValue
			{
				Type = this.Type,
				SplineEntityIds = this.SplineEntityIds
			};
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x060053C4 RID: 21444 RVA: 0x000CDEB9 File Offset: 0x000CC0B9
		// (set) Token: 0x060053C5 RID: 21445 RVA: 0x000CDEE4 File Offset: 0x000CC0E4
		public override EAtomicProcess Type
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

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x060053C6 RID: 21446 RVA: 0x000CDEF2 File Offset: 0x000CC0F2
		// (set) Token: 0x060053C7 RID: 21447 RVA: 0x000CDF19 File Offset: 0x000CC119
		public virtual List<int> SplineEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityIds;
				}
				IAtomicProcessStoveCoreFall_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SplineEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityIds = value;
			}
		}

		// Token: 0x040032B6 RID: 12982
		[Nullable(2)]
		protected new IAtomicProcessStoveCoreFall FbInstance;

		// Token: 0x040032B7 RID: 12983
		[Nullable(2)]
		protected new IAtomicProcessStoveCoreFall_SetValue PocoInterface;
	}
}
