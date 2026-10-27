using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002F5 RID: 757
	[NullableContext(1)]
	[Nullable(0)]
	public class IEffectSplineCreationMode
	{
		// Token: 0x06000E9D RID: 3741 RVA: 0x00034AFC File Offset: 0x00032CFC
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

		// Token: 0x06000E9E RID: 3742 RVA: 0x00034B34 File Offset: 0x00032D34
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

		// Token: 0x06000E9F RID: 3743 RVA: 0x00034B47 File Offset: 0x00032D47
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

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00034B5A File Offset: 0x00032D5A
		public IEffectSplineCreationMode_SetValue ToSetValue()
		{
			return new IEffectSplineCreationMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00034B6D File Offset: 0x00032D6D
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x00034B98 File Offset: 0x00032D98
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

		// Token: 0x04000CDF RID: 3295
		[Nullable(2)]
		protected IEffectSplineCreationMode FbInstance;

		// Token: 0x04000CE0 RID: 3296
		[Nullable(2)]
		protected IEffectSplineCreationMode_SetValue PocoInterface;
	}
}
