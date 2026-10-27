using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E42 RID: 7746
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetSpineAnimationType
	{
		// Token: 0x0600A5BF RID: 42431 RVA: 0x001775FC File Offset: 0x001757FC
		private ISetSpineAnimationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetSpineAnimationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetSpineAnimationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetSpineAnimationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x00177634 File Offset: 0x00175834
		public static ISetSpineAnimationType Create([Nullable(2)] ISetSpineAnimationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetSpineAnimationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x00177647 File Offset: 0x00175847
		public static ISetSpineAnimationType CreateFromSetValue([Nullable(2)] ISetSpineAnimationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetSpineAnimationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x0017765A File Offset: 0x0017585A
		public ISetSpineAnimationType_SetValue ToSetValue()
		{
			return new ISetSpineAnimationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600A5C3 RID: 42435 RVA: 0x0017766D File Offset: 0x0017586D
		// (set) Token: 0x0600A5C4 RID: 42436 RVA: 0x00177698 File Offset: 0x00175898
		public virtual ESetSpineAnimation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetSpineAnimation.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006316 RID: 25366
		[Nullable(2)]
		protected ISetSpineAnimationType FbInstance;

		// Token: 0x04006317 RID: 25367
		[Nullable(2)]
		protected ISetSpineAnimationType_SetValue PocoInterface;
	}
}
