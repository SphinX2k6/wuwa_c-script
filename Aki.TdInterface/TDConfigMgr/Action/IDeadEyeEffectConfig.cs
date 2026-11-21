using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AFD RID: 6909
	public class IDeadEyeEffectConfig
	{
		// Token: 0x060092C1 RID: 37569 RVA: 0x00157AB8 File Offset: 0x00155CB8
		private IDeadEyeEffectConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeadEyeEffectConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeadEyeEffectConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeadEyeEffectConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060092C2 RID: 37570 RVA: 0x00157AF0 File Offset: 0x00155CF0
		public static IDeadEyeEffectConfig Create([Nullable(2)] IDeadEyeEffectConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadEyeEffectConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092C3 RID: 37571 RVA: 0x00157B03 File Offset: 0x00155D03
		public static IDeadEyeEffectConfig CreateFromSetValue([Nullable(2)] IDeadEyeEffectConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeadEyeEffectConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092C4 RID: 37572 RVA: 0x00157B16 File Offset: 0x00155D16
		public IDeadEyeEffectConfig_SetValue ToSetValue()
		{
			return new IDeadEyeEffectConfig_SetValue
			{
				FilterEffect = this.FilterEffect,
				TargetIdleMaterialDa = this.TargetIdleMaterialDa,
				TargetLockedMaterialDa = this.TargetLockedMaterialDa
			};
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x060092C5 RID: 37573 RVA: 0x00157B41 File Offset: 0x00155D41
		// (set) Token: 0x060092C6 RID: 37574 RVA: 0x00157B6C File Offset: 0x00155D6C
		public virtual string FilterEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FilterEffect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.FilterEffect;
			}
			set
			{
				this.GetOrCreatePoco().FilterEffect = value;
			}
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x060092C7 RID: 37575 RVA: 0x00157B7A File Offset: 0x00155D7A
		// (set) Token: 0x060092C8 RID: 37576 RVA: 0x00157BA1 File Offset: 0x00155DA1
		[Nullable(2)]
		public virtual string TargetIdleMaterialDa
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetIdleMaterialDa;
				}
				IDeadEyeEffectConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetIdleMaterialDa;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TargetIdleMaterialDa = value;
			}
		}

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x060092C9 RID: 37577 RVA: 0x00157BAF File Offset: 0x00155DAF
		// (set) Token: 0x060092CA RID: 37578 RVA: 0x00157BD6 File Offset: 0x00155DD6
		[Nullable(2)]
		public virtual string TargetLockedMaterialDa
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetLockedMaterialDa;
				}
				IDeadEyeEffectConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetLockedMaterialDa;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TargetLockedMaterialDa = value;
			}
		}

		// Token: 0x04005B5C RID: 23388
		[Nullable(2)]
		protected IDeadEyeEffectConfig FbInstance;

		// Token: 0x04005B5D RID: 23389
		[Nullable(2)]
		protected IDeadEyeEffectConfig_SetValue PocoInterface;
	}
}
