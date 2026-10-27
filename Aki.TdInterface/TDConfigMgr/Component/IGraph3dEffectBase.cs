using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E0 RID: 992
	[NullableContext(1)]
	[Nullable(0)]
	public class IGraph3dEffectBase
	{
		// Token: 0x060013F3 RID: 5107 RVA: 0x000403CC File Offset: 0x0003E5CC
		private IGraph3dEffectBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGraph3dEffectBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGraph3dEffectBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGraph3dEffectBase_SetValue());
			}
			return result;
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00040404 File Offset: 0x0003E604
		public static IGraph3dEffectBase Create([Nullable(2)] IGraph3dEffectBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dEffectBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00040417 File Offset: 0x0003E617
		public static IGraph3dEffectBase CreateFromSetValue([Nullable(2)] IGraph3dEffectBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGraph3dEffectBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0004042A File Offset: 0x0003E62A
		public IGraph3dEffectBase_SetValue ToSetValue()
		{
			return new IGraph3dEffectBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0004043D File Offset: 0x0003E63D
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x00040468 File Offset: 0x0003E668
		public virtual EGraph3dEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGraph3dEffectType.FireBoxFish;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000FC8 RID: 4040
		[Nullable(2)]
		protected IGraph3dEffectBase FbInstance;

		// Token: 0x04000FC9 RID: 4041
		[Nullable(2)]
		protected IGraph3dEffectBase_SetValue PocoInterface;
	}
}
