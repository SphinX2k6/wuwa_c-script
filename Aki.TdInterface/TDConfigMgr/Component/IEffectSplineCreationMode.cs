using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200033C RID: 828
	public class IEffectSplineCreationMode
	{
		// Token: 0x06000FCD RID: 4045 RVA: 0x00037A30 File Offset: 0x00035C30
		private IEffectSplineCreationMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEffectSplineCreationMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEffectSplineCreationMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEffectSplineCreationMode_SetValue());
			}
			return result;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00037A68 File Offset: 0x00035C68
		public static IEffectSplineCreationMode Create([Nullable(2)] IEffectSplineCreationMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSplineCreationMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00037A7B File Offset: 0x00035C7B
		public static IEffectSplineCreationMode CreateFromSetValue([Nullable(2)] IEffectSplineCreationMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEffectSplineCreationMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00037A8E File Offset: 0x00035C8E
		public IEffectSplineCreationMode_SetValue ToSetValue()
		{
			return new IEffectSplineCreationMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00037AA1 File Offset: 0x00035CA1
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00037ACC File Offset: 0x00035CCC
		public virtual EEffectSplineCreateMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectSplineCreateMode.WholeLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000DC9 RID: 3529
		[Nullable(2)]
		protected IEffectSplineCreationMode FbInstance;

		// Token: 0x04000DCA RID: 3530
		[Nullable(2)]
		protected IEffectSplineCreationMode_SetValue PocoInterface;
	}
}
