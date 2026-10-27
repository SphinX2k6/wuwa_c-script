using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002F1 RID: 753
	[NullableContext(1)]
	[Nullable(0)]
	public class IEffectAreaMode
	{
		// Token: 0x06000E87 RID: 3719 RVA: 0x0003484C File Offset: 0x00032A4C
		private IEffectAreaMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEffectAreaMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEffectAreaMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEffectAreaMode_SetValue());
			}
			return result;
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00034884 File Offset: 0x00032A84
		public static IEffectAreaMode Create([Nullable(2)] IEffectAreaMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectAreaMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00034897 File Offset: 0x00032A97
		public static IEffectAreaMode CreateFromSetValue([Nullable(2)] IEffectAreaMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEffectAreaMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000348AA File Offset: 0x00032AAA
		public IEffectAreaMode_SetValue ToSetValue()
		{
			return new IEffectAreaMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x000348BD File Offset: 0x00032ABD
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x000348E8 File Offset: 0x00032AE8
		public virtual EEffectAreaType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectAreaType.BuffArea;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000CD4 RID: 3284
		[Nullable(2)]
		protected IEffectAreaMode FbInstance;

		// Token: 0x04000CD5 RID: 3285
		[Nullable(2)]
		protected IEffectAreaMode_SetValue PocoInterface;
	}
}
