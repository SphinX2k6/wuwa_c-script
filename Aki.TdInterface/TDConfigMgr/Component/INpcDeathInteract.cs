using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005C1 RID: 1473
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcDeathInteract
	{
		// Token: 0x06001E02 RID: 7682 RVA: 0x000555FC File Offset: 0x000537FC
		[NullableContext(0)]
		private INpcDeathInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcDeathInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcDeathInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcDeathInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00055634 File Offset: 0x00053834
		[NullableContext(0)]
		public static INpcDeathInteract Create([Nullable(2)] INpcDeathInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcDeathInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00055647 File Offset: 0x00053847
		[NullableContext(0)]
		public static INpcDeathInteract CreateFromSetValue([Nullable(2)] INpcDeathInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcDeathInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0005565A File Offset: 0x0005385A
		[NullableContext(0)]
		public INpcDeathInteract_SetValue ToSetValue()
		{
			return new INpcDeathInteract_SetValue
			{
				Montage = this.Montage,
				MaterialDa = this.MaterialDa
			};
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x0005567C File Offset: 0x0005387C
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x000556DD File Offset: 0x000538DD
		public virtual IMontageId Montage
		{
			get
			{
				if (this._MontageInited)
				{
					return this._MontageCache;
				}
				this._MontageInited = true;
				if (this.FbInstance != null)
				{
					this._MontageCache = IMontageId.Create(this.FbInstance.Montage);
				}
				else
				{
					INpcDeathInteract_SetValue pocoInterface = this.PocoInterface;
					this._MontageCache = ((pocoInterface != null) ? pocoInterface.Montage : null);
				}
				return this._MontageCache;
			}
			set
			{
				this.GetOrCreatePoco().Montage = value;
				this._MontageInited = false;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000556F2 File Offset: 0x000538F2
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x00055719 File Offset: 0x00053919
		public virtual string MaterialDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaterialDa;
				}
				INpcDeathInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaterialDa;
			}
			set
			{
				this.GetOrCreatePoco().MaterialDa = value;
			}
		}

		// Token: 0x0400157D RID: 5501
		protected INpcDeathInteract FbInstance;

		// Token: 0x0400157E RID: 5502
		protected INpcDeathInteract_SetValue PocoInterface;

		// Token: 0x0400157F RID: 5503
		[Nullable(0)]
		private IMontageId _MontageCache;

		// Token: 0x04001580 RID: 5504
		private bool _MontageInited;
	}
}
