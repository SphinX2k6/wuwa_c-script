using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018F2 RID: 6386
	[NullableContext(1)]
	[Nullable(0)]
	public class ICollectibleMarkerType
	{
		// Token: 0x060088E1 RID: 35041 RVA: 0x00143750 File Offset: 0x00141950
		private ICollectibleMarkerType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICollectibleMarkerType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICollectibleMarkerType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICollectibleMarkerType_SetValue());
			}
			return result;
		}

		// Token: 0x060088E2 RID: 35042 RVA: 0x00143788 File Offset: 0x00141988
		public static ICollectibleMarkerType Create([Nullable(2)] ICollectibleMarkerType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICollectibleMarkerType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x0014379B File Offset: 0x0014199B
		public static ICollectibleMarkerType CreateFromSetValue([Nullable(2)] ICollectibleMarkerType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICollectibleMarkerType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x001437AE File Offset: 0x001419AE
		public ICollectibleMarkerType_SetValue ToSetValue()
		{
			return new ICollectibleMarkerType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x060088E5 RID: 35045 RVA: 0x001437C1 File Offset: 0x001419C1
		// (set) Token: 0x060088E6 RID: 35046 RVA: 0x001437EC File Offset: 0x001419EC
		public virtual ECollectibleMarkerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECollectibleMarkerType.Placeholder;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040055DB RID: 21979
		[Nullable(2)]
		protected ICollectibleMarkerType FbInstance;

		// Token: 0x040055DC RID: 21980
		[Nullable(2)]
		protected ICollectibleMarkerType_SetValue PocoInterface;
	}
}
