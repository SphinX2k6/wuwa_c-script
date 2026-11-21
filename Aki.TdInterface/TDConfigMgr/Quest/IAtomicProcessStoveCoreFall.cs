using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FE8 RID: 4072
	public class IAtomicProcessStoveCoreFall : IAtomicProcessBase
	{
		// Token: 0x0600593C RID: 22844 RVA: 0x000D9FE4 File Offset: 0x000D81E4
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

		// Token: 0x0600593D RID: 22845 RVA: 0x000DA01C File Offset: 0x000D821C
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

		// Token: 0x0600593E RID: 22846 RVA: 0x000DA02F File Offset: 0x000D822F
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

		// Token: 0x0600593F RID: 22847 RVA: 0x000DA042 File Offset: 0x000D8242
		public new IAtomicProcessStoveCoreFall_SetValue ToSetValue()
		{
			return new IAtomicProcessStoveCoreFall_SetValue
			{
				Type = this.Type,
				SplineEntityIds = this.SplineEntityIds
			};
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06005940 RID: 22848 RVA: 0x000DA061 File Offset: 0x000D8261
		// (set) Token: 0x06005941 RID: 22849 RVA: 0x000DA08C File Offset: 0x000D828C
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

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06005942 RID: 22850 RVA: 0x000DA09A File Offset: 0x000D829A
		// (set) Token: 0x06005943 RID: 22851 RVA: 0x000DA0C1 File Offset: 0x000D82C1
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

		// Token: 0x040035C3 RID: 13763
		[Nullable(2)]
		protected new IAtomicProcessStoveCoreFall FbInstance;

		// Token: 0x040035C4 RID: 13764
		[Nullable(2)]
		protected new IAtomicProcessStoveCoreFall_SetValue PocoInterface;
	}
}
