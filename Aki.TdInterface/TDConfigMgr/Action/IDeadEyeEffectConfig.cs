using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001972 RID: 6514
	[NullableContext(2)]
	[Nullable(0)]
	public class IDeadEyeEffectConfig
	{
		// Token: 0x06008B89 RID: 35721 RVA: 0x00148028 File Offset: 0x00146228
		[NullableContext(1)]
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

		// Token: 0x06008B8A RID: 35722 RVA: 0x00148060 File Offset: 0x00146260
		[NullableContext(1)]
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

		// Token: 0x06008B8B RID: 35723 RVA: 0x00148073 File Offset: 0x00146273
		[NullableContext(1)]
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

		// Token: 0x06008B8C RID: 35724 RVA: 0x00148086 File Offset: 0x00146286
		[NullableContext(1)]
		public IDeadEyeEffectConfig_SetValue ToSetValue()
		{
			return new IDeadEyeEffectConfig_SetValue
			{
				FilterEffect = this.FilterEffect,
				TargetIdleMaterialDa = this.TargetIdleMaterialDa,
				TargetLockedMaterialDa = this.TargetLockedMaterialDa
			};
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x06008B8D RID: 35725 RVA: 0x001480B1 File Offset: 0x001462B1
		// (set) Token: 0x06008B8E RID: 35726 RVA: 0x001480DC File Offset: 0x001462DC
		[Nullable(1)]
		public virtual string FilterEffect
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().FilterEffect = value;
			}
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x06008B8F RID: 35727 RVA: 0x001480EA File Offset: 0x001462EA
		// (set) Token: 0x06008B90 RID: 35728 RVA: 0x00148111 File Offset: 0x00146311
		public virtual string TargetIdleMaterialDa
		{
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
			set
			{
				this.GetOrCreatePoco().TargetIdleMaterialDa = value;
			}
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x06008B91 RID: 35729 RVA: 0x0014811F File Offset: 0x0014631F
		// (set) Token: 0x06008B92 RID: 35730 RVA: 0x00148146 File Offset: 0x00146346
		public virtual string TargetLockedMaterialDa
		{
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
			set
			{
				this.GetOrCreatePoco().TargetLockedMaterialDa = value;
			}
		}

		// Token: 0x04005707 RID: 22279
		protected IDeadEyeEffectConfig FbInstance;

		// Token: 0x04005708 RID: 22280
		protected IDeadEyeEffectConfig_SetValue PocoInterface;
	}
}
