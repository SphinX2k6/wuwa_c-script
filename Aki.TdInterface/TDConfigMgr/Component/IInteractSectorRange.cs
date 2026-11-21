using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004E8 RID: 1256
	public class IInteractSectorRange
	{
		// Token: 0x06001910 RID: 6416 RVA: 0x0004ADE0 File Offset: 0x00048FE0
		private IInteractSectorRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractSectorRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractSectorRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractSectorRange_SetValue());
			}
			return result;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0004AE18 File Offset: 0x00049018
		public static IInteractSectorRange Create([Nullable(2)] IInteractSectorRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractSectorRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0004AE2B File Offset: 0x0004902B
		public static IInteractSectorRange CreateFromSetValue([Nullable(2)] IInteractSectorRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractSectorRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0004AE3E File Offset: 0x0004903E
		public IInteractSectorRange_SetValue ToSetValue()
		{
			return new IInteractSectorRange_SetValue
			{
				Begin = this.Begin,
				End = this.End
			};
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x0004AE5D File Offset: 0x0004905D
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x0004AE8C File Offset: 0x0004908C
		public virtual float Begin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Begin;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Begin;
			}
			set
			{
				this.GetOrCreatePoco().Begin = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x0004AE9A File Offset: 0x0004909A
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x0004AEC9 File Offset: 0x000490C9
		public virtual float End
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.End;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.End;
			}
			set
			{
				this.GetOrCreatePoco().End = value;
			}
		}

		// Token: 0x040012B4 RID: 4788
		[Nullable(2)]
		protected IInteractSectorRange FbInstance;

		// Token: 0x040012B5 RID: 4789
		[Nullable(2)]
		protected IInteractSectorRange_SetValue PocoInterface;
	}
}
