using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200048F RID: 1167
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractSectorRange
	{
		// Token: 0x06001776 RID: 6006 RVA: 0x00047098 File Offset: 0x00045298
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

		// Token: 0x06001777 RID: 6007 RVA: 0x000470D0 File Offset: 0x000452D0
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

		// Token: 0x06001778 RID: 6008 RVA: 0x000470E3 File Offset: 0x000452E3
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

		// Token: 0x06001779 RID: 6009 RVA: 0x000470F6 File Offset: 0x000452F6
		public IInteractSectorRange_SetValue ToSetValue()
		{
			return new IInteractSectorRange_SetValue
			{
				Begin = this.Begin,
				End = this.End
			};
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00047115 File Offset: 0x00045315
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x00047144 File Offset: 0x00045344
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

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x00047152 File Offset: 0x00045352
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x00047181 File Offset: 0x00045381
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

		// Token: 0x04001192 RID: 4498
		[Nullable(2)]
		protected IInteractSectorRange FbInstance;

		// Token: 0x04001193 RID: 4499
		[Nullable(2)]
		protected IInteractSectorRange_SetValue PocoInterface;
	}
}
