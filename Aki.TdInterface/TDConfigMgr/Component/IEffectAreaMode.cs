using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000338 RID: 824
	public class IEffectAreaMode
	{
		// Token: 0x06000FB7 RID: 4023 RVA: 0x00037780 File Offset: 0x00035980
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

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000377B8 File Offset: 0x000359B8
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

		// Token: 0x06000FB9 RID: 4025 RVA: 0x000377CB File Offset: 0x000359CB
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

		// Token: 0x06000FBA RID: 4026 RVA: 0x000377DE File Offset: 0x000359DE
		public IEffectAreaMode_SetValue ToSetValue()
		{
			return new IEffectAreaMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x000377F1 File Offset: 0x000359F1
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x0003781C File Offset: 0x00035A1C
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

		// Token: 0x04000DBE RID: 3518
		[Nullable(2)]
		protected IEffectAreaMode FbInstance;

		// Token: 0x04000DBF RID: 3519
		[Nullable(2)]
		protected IEffectAreaMode_SetValue PocoInterface;
	}
}
