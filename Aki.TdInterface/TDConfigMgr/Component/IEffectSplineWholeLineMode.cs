using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000340 RID: 832
	public class IEffectSplineWholeLineMode : IEffectSplineCreationMode
	{
		// Token: 0x06000FDF RID: 4063 RVA: 0x00037BEC File Offset: 0x00035DEC
		private IEffectSplineWholeLineMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEffectSplineWholeLineMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEffectSplineWholeLineMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEffectSplineWholeLineMode_SetValue());
			}
			return result;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00037C24 File Offset: 0x00035E24
		public static IEffectSplineWholeLineMode Create([Nullable(2)] IEffectSplineWholeLineMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSplineWholeLineMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00037C37 File Offset: 0x00035E37
		public static IEffectSplineWholeLineMode CreateFromSetValue([Nullable(2)] IEffectSplineWholeLineMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEffectSplineWholeLineMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00037C4A File Offset: 0x00035E4A
		public new IEffectSplineWholeLineMode_SetValue ToSetValue()
		{
			return new IEffectSplineWholeLineMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00037C5D File Offset: 0x00035E5D
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00037C88 File Offset: 0x00035E88
		public override EEffectSplineCreateMode Type
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

		// Token: 0x04000DD0 RID: 3536
		[Nullable(2)]
		protected new IEffectSplineWholeLineMode FbInstance;

		// Token: 0x04000DD1 RID: 3537
		[Nullable(2)]
		protected new IEffectSplineWholeLineMode_SetValue PocoInterface;
	}
}
