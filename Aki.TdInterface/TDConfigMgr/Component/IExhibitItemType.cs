using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000345 RID: 837
	[NullableContext(1)]
	[Nullable(0)]
	public class IExhibitItemType
	{
		// Token: 0x0600108E RID: 4238 RVA: 0x00039308 File Offset: 0x00037508
		private IExhibitItemType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExhibitItemType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExhibitItemType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExhibitItemType_SetValue());
			}
			return result;
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00039340 File Offset: 0x00037540
		public static IExhibitItemType Create([Nullable(2)] IExhibitItemType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExhibitItemType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00039353 File Offset: 0x00037553
		public static IExhibitItemType CreateFromSetValue([Nullable(2)] IExhibitItemType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExhibitItemType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00039366 File Offset: 0x00037566
		public IExhibitItemType_SetValue ToSetValue()
		{
			return new IExhibitItemType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x00039379 File Offset: 0x00037579
		// (set) Token: 0x06001093 RID: 4243 RVA: 0x000393A4 File Offset: 0x000375A4
		public virtual EExhibitItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExhibitItemType.Phantom;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000DE3 RID: 3555
		[Nullable(2)]
		protected IExhibitItemType FbInstance;

		// Token: 0x04000DE4 RID: 3556
		[Nullable(2)]
		protected IExhibitItemType_SetValue PocoInterface;
	}
}
